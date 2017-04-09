using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // Define the player
    public GameObject player;

    // Define the start position
    Vector3 startPosition;

    // Define the start firection
    Vector3 startDirection;

	// Use this for initialization
	void Start () { 
        startPosition = player.transform.position;
        startDirection = player.transform.forward;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
     
    public void Restart()
    {        
        player.transform.position = startPosition;
        player.transform.forward = startDirection;
    }
}
