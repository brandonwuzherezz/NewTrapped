using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactivate : MonoBehaviour {


    // Update is called once per frame
    void Update()
    {
        if (DoThisForMe.DeadDialouge.Contains("Image1"))
        {
            GameObject.Find("DialougeMan").GetComponent<DialougeMan>().enabled = true; 
        }
    }
}
