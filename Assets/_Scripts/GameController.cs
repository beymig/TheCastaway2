/*
Source File Name: MeetTheGuaca.CSharp
Author's Name: Beymig Munoz Martinez
Last Modified by: Beymig Munoz Martinez
Date Last Modified: March 25th, 2016
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private int _scoreValue;
    private int _livesValue;
    private Vector3 _playerSpawnPoint;
  


    //PUBLIC ACCESS METHODS
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
            
        }
        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "SCORE: " + this._scoreValue;

        }
    }
    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }
        set
        {
            this._livesValue = value;
            if (this._livesValue <=0)
            {
                _endGame();
            }
            else
            { 
            this.LivesLabel.text = "LIVES: " + this._livesValue;
            }
        }
    }


    //PUBLIC INSTANCE VARIABLES
    
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
    public GameObject player;
    public GameObject villain;
    public int villainCount;
    public int helpCount;
    public GameObject help;
    
    public Text YourScoreLabel;
    
    public Button RestartButton;


    // Use this for initialization
    void Start () {
        this._initialize();

        Instantiate(this.player, this._playerSpawnPoint, Quaternion.identity);
        }
    //PRIVATE METHODS
    private void _initialize()
    {
        this._GenerateHelp();
        this._GenerateVillains();
        this._playerSpawnPoint = new Vector3(60f, 40f, 65f);
        //keep the player score
        this.ScoreValue = 0;
        //keep the player's number of lives
        this.LivesValue = 5;
        //holds the game over label
        this.GameOverLabel.enabled = false;
        //holds the final score
        this.YourScoreLabel.enabled = false;
        //button to restart the game 
        this.RestartButton.gameObject.SetActive(false);
    }


    private void _GenerateVillains()
    {
        for (int count = 0; count < this.villainCount; count++)
        {
            Instantiate(villain);
        }
    }

    private void _GenerateHelp()
    {
        for (int count = 0; count < this.helpCount; count++)
        {
            Instantiate(help);
        }
    }


    private void _endGame()
    {
    
        this.YourScoreLabel.text = "YOUR SCORE: " + this._scoreValue;
        this.GameOverLabel.enabled = true;
        this.YourScoreLabel.enabled = true;
        this.LivesLabel.enabled = false;
        this.ScoreLabel.enabled = false;
        this.RestartButton.gameObject.SetActive(true);
       
    }

    //PUBLIC METHODS
    //Reloads the main scene que the restart button is clicked
    public void RestartButtonClick()
    {
        SceneManager.LoadScene("Main");
    }

}


