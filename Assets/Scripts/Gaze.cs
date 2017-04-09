using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gaze : MonoBehaviour {

    // Define the reticle transform
    public Transform reticle;

    // Define the raycast hit
    RaycastHit hit;

    // Define the original reticle scale
    Vector3 originalScale;

    // Define the player's head
    Transform head;

    // Use this for initialization
	void Start () {

        // Set the original reticle scale
        originalScale = reticle.localScale;

        // Set the player's head to be the same as the main camera
        head = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {

        // Cast a ray in the direction you are looking, and save a reference to the object it runs into as hit
        if (Physics.Raycast(transform.position, head.forward, out hit, 100.0f))
        {
            // set the reticle at the hit point
            reticle.position = hit.point;

            // set the reticle direction to match the normal of the object
            reticle.forward = -hit.normal;

            // set the scale based on how far away the hit is
            reticle.localScale = originalScale * hit.distance;
        }
        else
        {
            // set the reticle far away
            reticle.position = head.forward * 100.0f;

            // set the reticle direction to be toward the head
            reticle.forward = head.forward;

            // set the scale based on how far away the hit is
            reticle.localScale = originalScale * 100.0f;
        }
	}
}
