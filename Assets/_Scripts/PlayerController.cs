using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private GameController _gameController;
	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();
        this._gameController = GameObject.FindWithTag("_gameController").GetComponent("_gameController") as GameController;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Health"))
        {
            //this._coinSound.Play();
            Destroy(other.gameObject);
            this._gameController.ScoreValue += 100;
        }

        if (other.gameObject.CompareTag("end"))
        {
            //this.win.Play();
            Destroy(other.gameObject);
            this._gameController.LivesLabel.gameObject.SetActive(false);
            this._gameController.ScoreLabel.gameObject.SetActive(false);
            //this._gameController.WonLabel.gameObject.SetActive(true);
            this._gameController.RestartButton.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }



        if (other.gameObject.CompareTag("Villain"))
        {
            //this._hurtSound.Play();

            this._gameController.LivesValue--;
        }


        if (other.gameObject.CompareTag("Death"))
        {
            //this._spawn();
            //this._hurtSound.Play();
            this._gameController.LivesValue--;
        }
    }
}
