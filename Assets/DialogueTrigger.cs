using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {
    public Animator animator;

    void Start()
    {
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            EndDialogue();
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {            
            StartDialogue();
        }

    }

    public void StartDialogue()
    {
        animator.SetBool("IsOpen", true);
        return;
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }
}
