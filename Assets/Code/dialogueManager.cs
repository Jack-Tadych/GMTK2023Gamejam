using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueManager : MonoBehaviour
{
    //TODO figure out textmesh pro tutorial I used https://youtu.be/_nRzoTzeyxU?si=0MTH7cuo1vKYyIYI&t=654
    public Text nameText;
    public Text dialogueText;



    private Queue<string> sentences; 
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("starting convertation with " + dialogue.name);

            nameText.text = dialogue.name;

        

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
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
        Debug.Log("End of Convertion");
    }
    
}
