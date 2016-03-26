using UnityEngine;
using System.Collections;

public class DeathScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}


    
    void OntrigerEnter(Collider other)
    {
        Debug.Log(other);
        Destroy(other.gameObject);
    }
    
}
