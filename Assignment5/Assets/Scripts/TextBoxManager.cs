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
    public bool interaction;

    // Use this for initialization
    void Start()
    {
        npc = FindObjectOfType<walkTo>();
        player = FindObjectOfType<RigidbodyFirstPersonController>();
        interaction = false;

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
        if (currentLine == 2)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                npc.playerNpcChoice = 1;
                
                DiableTextBox();
            }

            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                npc.playerNpcChoice = 2;
              
                DiableTextBox();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
              
                npc.playerNpcChoice = 3;
                DiableTextBox();
            }
            else
            {
                npc.playerNpcChoice = 0;
            }

        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine += 1;
           
        }

        if (currentLine > endAtLine)
        {
            if (npc.playerNpcChoice == 0)
            {
                theText.text = textLines[3];
            }
            DiableTextBox();
        }
    }

    public void EnableTextBox()
    {
        textBox.SetActive(true);
        isActive = true;
        if (stopPlayerMovement)
        {
            npc.RaceOn = false;
            player.canMove = false;
        }

        interaction = true;
    }

    public void DiableTextBox()
    {

        textBox.SetActive(false);
        player.canMove = true;
        isActive = false;
       
        if (interaction)
        {
            if(npc.playerNpcChoice == 1 || npc.playerNpcChoice == 2 || npc.playerNpcChoice == 3)
            {
                npc.RaceOn = true;
            }
            interaction = false;
        }
       

    }

    public void ReloadScript(TextAsset theText)
    {
        if(theText != null)
        {
            textLines = new string[1];
            textLines = (theText.text.Split('\n'));
        }
    }
}
