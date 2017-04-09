using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour {

    // Define the hint text object
    public Text hint;

    // Define the hint message
    public string message;

    // Define the interactive component
    Interactive interactive;

	// Use this for initialization
	void Start () {
        interactive = GetComponent<Interactive>();
    }

	// Update is called once per frame
	void Update () {
        if (interactive.isSelected)
        {
            hint.text = message;
        }
    }
}
