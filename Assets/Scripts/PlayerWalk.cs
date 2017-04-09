using UnityEngine;
using System.Collections;

public class PlayerWalk : MonoBehaviour {

    // Define the walk speed
	public float walkSpeed;

    // Define the walk threshold using head-bop
	public float walkThreshold;

    // Define the acceleration in the previous frame
	float a_0;

    // Define the acceleration in the current frame
	float a_1;

    // Define the change in acceleration
	float da;

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
		a_1 = Input.acceleration.y;

        // Calculate the total change in acceleration since the last frame
		da = Mathf.Abs((a_1 - a_0) / Time.fixedDeltaTime);

        // Set last frame's acceleration to be the same as this frame
		a_0 = a_1;

        // check if the change in acceleration is greater than the walk threshold
        // or if the up arrow is pressed
        if (da > walkThreshold || Input.GetKey(KeyCode.UpArrow))
        {
            // change the velocity of the rigid body
            rb.velocity = head.forward * walkSpeed;

        }
	}
}
