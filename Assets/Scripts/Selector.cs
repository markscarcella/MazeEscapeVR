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
                SelectInteractive();
            }
            else
            {
                // deselect interactive
                DeselectInteractive();
            }
        }
        else
        {
            // deselect interactive
            DeselectInteractive();
        }
	}

    void SelectInteractive()
    {
        // turn on the selector ui
        selector.SetActive(true);

        // start the selection timer
        selectionTimer += Time.deltaTime;

        // fill the selector ui by amount of time passed
        selectorFill.fillAmount = selectionTimer / selectionTime;

        // check if enough time has passed for selection
        if (selectionTimer >= selectionTime)
        {
            // turn on the hint ui
            hint.SetActive(true);

            // save the object as selected
            selectedInteractive = hit.transform.GetComponent<Interactive>();

            // set the interactive to selected
            selectedInteractive.isSelected = true;

            // turn off the selector ui
            selector.SetActive(false);
        }
    }

    void DeselectInteractive()
    {
        // turn off the hint ui
        hint.SetActive(false);

        // turn off selector ui
        selector.SetActive(false);

        // reset the selection timer
        selectionTimer = 0;

        // reset the selector ui fill
        selectorFill.fillAmount = 0.0f;

        // check if any hint are previously selected
        if (selectedInteractive)
        {
            // deselect the hint
            selectedInteractive.isSelected = false;
        }
    }
}
