using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontLeaveMe : MonoBehaviour {
    public int myTimer = 0;
    //public DialogueManager dialogue;
    public Animator animator;

    public void Update()
    {
        if (Battery.DeletedBatteries.Contains("battery1") == true)
        {
            Destroy(gameObject);
        }
       /* if (GameObject.Find("Safety").GetComponent<RawImage>().enabled == true)
        {
           myTimer++;
        }
        if(myTimer > 80)
        {
            myTimer = 0;
            GameObject.Find("Safety").GetComponent<RawImage>().enabled = false;
        }*/
    }
    // Use this for initialization
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //GameObject.Find("Safety").GetComponent<RawImage>().enabled = true;
            animator.SetBool("IsOpen", true);
        }

    }

    public void StartDialogue()
    {
        animator.SetBool("IsOpen", true);
    }

    void EndDialogue()
    {
        //animator.SetBool("IsOpen", false);
    }
}
