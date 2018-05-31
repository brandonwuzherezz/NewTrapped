using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {
    public Animator animator;
   
    void Start()
    {
        if (Battery.DeletedBatteries.Contains("battery1") == true)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            EndDialogue();
            if (Battery.DeletedBatteries.Contains("battery1") == true)
            {
                Destroy(gameObject);
            }
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
        GameObject.Find("Girl").GetComponent<Player_Movement>().anim.SetInteger("State", 0);
        GameObject.Find("Girl").GetComponent<Player_Movement>().audioSource.Stop();
        GameObject.Find("Girl").GetComponent<Player_Movement>().enabled = false;
        return;
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        GameObject.Find("Girl").GetComponent<Player_Movement>().enabled = true;
    }
}
