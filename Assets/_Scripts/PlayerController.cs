using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private GameController _gameController;
	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();
        this._gameController = GameObject.FindWithTag("GameController").GetComponent("GameController") as GameController;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
