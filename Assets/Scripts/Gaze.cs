using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gaze : MonoBehaviour {

    // Define the reticle transform


    // Define the raycast hit


    // Define the original reticle scale


    // Define the player's head


    // Use this for initialization
	void Start () {

        // Set the original reticle scale

        // Set the player's head to be the same as the main camera

    }
	
	// Update is called once per frame
	void Update () {

        // Cast a ray in the direction you are looking, and save a reference to the object it runs into as hit
        //if ()
        {
            // set the reticle at the hit point


            // set the reticle direction to match the normal of the object


            // set the scale based on how far away the hit is

        }
        //else
        {
            // set the reticle far away


            // set the reticle direction to be toward the head


            // set the scale based on how far away the hit is

        }
	}
}
