using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour {

    public GameObject npcDialogueBox;
    public Dialogue dialogue;

    private void Awake()
    {
        npcDialogueBox.SetActive(false);
    }

    void Update()
    {
       
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "checkNPC")
        {
            npcDialogueBox.SetActive(true);
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }

    }
}
