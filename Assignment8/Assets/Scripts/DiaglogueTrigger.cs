using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DiaglogueTrigger : MonoBehaviour {

    public Dialogue diaglogue;

     
    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Player")
        {
            FindObjectOfType<DialogueManager>().StartDialogue(diaglogue);
        }
       
    }


}
