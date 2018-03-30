﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTextAtLine : MonoBehaviour {

    public TextAsset theText;
    public int startLine;
    public int endLine;

    public bool requireButtonPress;
    private bool waitForPress;
    public bool destryWhenActivated;

    public TextBoxManager theTextBox;

	// Use this for initialization
	void Start () {
        requireButtonPress = true;
        theTextBox = FindObjectOfType<TextBoxManager>();
	}
	
	// Update is called once per frame
	void Update () {
      
        // Activates interactive NPC Dialog
        if(waitForPress && Input.GetKeyDown(KeyCode.F))
        {
            theTextBox.ReloadScript(theText);
            theTextBox.currentLine = startLine;
            theTextBox.endAtLine = endLine;
            theTextBox.EnableTextBox();

            if (destryWhenActivated)
            {
                Destroy(gameObject);
            }

        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {

            if(requireButtonPress)
            {
                waitForPress = true;
                return;
            }

            theTextBox.ReloadScript(theText);
            theTextBox.currentLine = startLine;
            theTextBox.endAtLine = endLine;
            theTextBox.EnableTextBox();

            if (destryWhenActivated)
            {
                Destroy(gameObject);
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            waitForPress = false;
        }
    }
}
