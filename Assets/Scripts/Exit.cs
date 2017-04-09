using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

    // Define the gameManager
    GameManager gameManager;

	// Use this for initialization
	void Start () {

        // Assign the game manager
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<Interactive>().isSelected)
        {
            gameManager.Restart();
        }
	}
}
