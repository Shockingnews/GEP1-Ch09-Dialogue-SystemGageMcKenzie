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
        manager.StartDialogue(dialogue);
        
    }


    public void Focused()
    {

    }

    public void UnFocused()
    {
    }
}
