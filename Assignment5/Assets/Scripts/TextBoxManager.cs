using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class TextBoxManager : MonoBehaviour
{
    public GameObject textBox;

    public Text theText;

    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;

    public RigidbodyFirstPersonController player;
    public walkTo npc;

    public bool isActive;
    public bool stopPlayerMovement;

    // Use this for initialization
    void Start()
    {
        npc = FindObjectOfType<walkTo>();
        player = FindObjectOfType<RigidbodyFirstPersonController>();

        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }

        if (endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }

        if(isActive)
        {
            EnableTextBox();
        }
        else
        {
            DiableTextBox();
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (!isActive)
        {
            return;
        }
        
        theText.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine += 1;
        }

        if (currentLine > endAtLine)
        {
            DiableTextBox();
        }
    }

    public void EnableTextBox()
    {
        textBox.SetActive(true);
        if (stopPlayerMovement)
        {
            npc.RaceOn = false;
            player.canMove = false;
        }
    }

    public void DiableTextBox()
    {
        textBox.SetActive(false);
        player.canMove = true;
        isActive = false;
        npc.RaceOn = true;

    }

    public void ReloadScript(TextAsset theText)
    {
        if(theText != null)
        {
            textLines = new string[1];
        }
    }
}
