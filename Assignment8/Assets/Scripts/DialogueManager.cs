using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour {

    public Text nameText;
    public Text dialogueText;
    public GameObject npcDialogueBox;

    private Queue<string> sentences;
	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            DisplayNextSetence();
        }
    }
    public void StartDialogue(Dialogue d)
    {
        nameText.text = d.name;
        sentences.Clear();

        foreach (string sentence in d.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSetence();

    }

    public void DisplayNextSetence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }
	
    void EndDialogue()
    {
        npcDialogueBox.SetActive(false);
    }
}
