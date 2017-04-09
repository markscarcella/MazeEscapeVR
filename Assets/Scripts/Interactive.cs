using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactive : MonoBehaviour {

    // Define a bool to check if selected


    // Define a colour to hold the tint 


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
        //if ()
        {
            // Change the colour to the selected tint

        }
        //else
        {
            // Change the colour to the original tint

        }
    }
}
