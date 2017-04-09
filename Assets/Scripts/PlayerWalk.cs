using UnityEngine;
using System.Collections;

public class PlayerWalk : MonoBehaviour {

    // Define the walk speed


    // Define the walk threshold using head-bop


    // Define the acceleration in the previous frame


    // Define the acceleration in the current frame


    // Define the change in acceleration


    // Define the player's head
	Transform head;

    // Define the player's rigid body
	Rigidbody rb;

	// Use this for initialization
	void Start () {
        // Assign the player's head to be the main camera
		head = Camera.main.transform;

        // Assign the player's rigid body
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        // Get the y acceleration in this frame


        // Calculate the total change in acceleration since the last frame


        // Set last frame's acceleration to be the same as this frame


        // check if the change in acceleration is greater than the walk threshold
        // or if the up arrow is pressed
        //if ()
        {
            // change the velocity of the rigid body


        }
	}
}
