using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontLeaveMe : MonoBehaviour {
    public int myTimer = 0;
    public void Update()
    {
        if (Battery.DeletedBatteries.Contains("battery1") == true)
        {
            Destroy(gameObject);
        }
        if (GameObject.Find("Safety").GetComponent<Text>().enabled == true)
        {
           myTimer++;
        }
        if(myTimer > 80)
        {
            myTimer = 0;
            GameObject.Find("Safety").GetComponent<Text>().enabled = false;
        }
    }
    // Use this for initialization
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Find("Safety").GetComponent<Text>().enabled = true;
          
        }

    }
}
