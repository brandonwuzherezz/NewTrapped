using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour {

    public Animator animator;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartDialogue()
    {
        animator.SetBool("IsOpen", true);
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }
}
