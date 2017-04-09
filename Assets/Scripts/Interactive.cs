using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactive : MonoBehaviour {

    // Define a bool to check if selected
    public bool isSelected;

    // Define a colour to hold the tint 
    public Color selectedTint;

    // Define a colour to hold the original colour
    Color originalTint;

    // Use this for initialization
    void Start () {

        // Assign the original tint of the object
        originalTint = GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update () {

        // Check if the object is selected
        if (isSelected)
        {
            // Change the colour to the selected tint
            GetComponent<Renderer>().material.color = selectedTint;
        }
        else
        {
            // Change the colour to the original tint
            GetComponent<Renderer>().material.color = originalTint;
        }
    }
}
