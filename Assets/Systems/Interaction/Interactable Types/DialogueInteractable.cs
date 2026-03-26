using UnityEngine;

public class DialogueInteractable : MonoBehaviour, IInteractable
{
    public Dialogue dialogue;
    public DialogueManager manager;

    //[SerializeField] private GameObject dialogueImg;

    void Awake()
    {

    }
    public void Interact()
    {
        //FindObjectOfType<Dialogue
        if (manager.inText == true)
        {

            Debug.Log("true");
            manager.DisplayNextSentence();



        }
        else { manager.StartDialogue(dialogue); }
            
        
        //manager.text = false;


    }


    public void Focused()
    {

    }

    public void UnFocused()
    {
    }
}
