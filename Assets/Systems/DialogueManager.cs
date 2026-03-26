using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    
    public TMP_Text dialogueText;
    public bool inText = false;

    [SerializeField] private GameObject dialogueImg;
    [SerializeField] GameObject player;
    private PlayerMovementController controller;
    private Animator animator;

    private Queue<string> sentences;

    private void Awake()
    {
        sentences = new Queue<string>();
        controller = player.GetComponent<PlayerMovementController>();
        animator = player.GetComponentInChildren<Animator>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        inText = true;
        dialogueImg.SetActive(true);
        controller.enabled = false;
        animator.enabled = false;

        Debug.Log("d");

        sentences.Clear();


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
        dialogueImg.SetActive(false);
        controller.enabled = true;
        animator.enabled = true;
        inText = false;
        Debug.Log("false");
    }
}
