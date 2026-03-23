using UnityEngine;

public class DialogueInteractable : MonoBehaviour, IInteractable
{
    public Dialogue dialogue;
    public DialogueManager manager;
    public void Interact()
    {
        manager.StartDialogue(dialogue);
    }


    public void Focused()
    {

    }

    public void UnFocused()
    {
    }
}
