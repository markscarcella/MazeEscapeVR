using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selector : MonoBehaviour {

    // Define the hint game object
    public GameObject hint;

    // Define the selector game object
    public GameObject selector;

    // Define the selector fill object
    public Image selectorFill;

    // Define the selection time float
    public float selectionTime;

    // Defeine the raycast hit
    RaycastHit hit;

    // Define the selection timer float
    float selectionTimer;

    // Define the selected interactive object
    Interactive selectedInteractive;

	// Use this for initialization
	void Start () {

        // Set the hint to be inactive
        hint.SetActive(false);

        // Set the selector to be inactive
        selector.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        // Cast a ray in the direction you are looking, and save a reference to the object it runs into as hit
        if (Physics.Raycast(transform.position, Camera.main.transform.forward, out hit))
        {
            // check if the hit object has an interactive component
            if (hit.transform.GetComponent<Interactive>())
            { 
                // start selecting

            }
            else
            {
                // deselect interactive

            }
        }
        else
        {
            // deselect interactive

        }
	}

    void SelectInteractive()
    {
        // turn on the selector ui


        // start the selection timer


        // fill the selector ui by amount of time passed


        // check if enough time has passed for selection
        //if ()
        {
            // turn on the hint ui


            // save the object as selected


            // set the interactive to selected


            // turn off the selector ui

        }
    }

    void DeselectInteractive()
    {
        // turn off the hint ui


        // turn off selector ui


        // reset the selection timer


        // reset the selector ui fill


        // check if any hint are previously selected
        //if ()
        {
            // deselect the hint

        }
    }
}
