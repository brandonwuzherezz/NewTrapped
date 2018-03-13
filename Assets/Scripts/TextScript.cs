using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {
    public void Update()
    {
        if(Shadows.DeletedShadows.Contains("TrappedFountain"))
        {
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Find("Text Shadows").GetComponent<Text>().enabled = true;
            GameObject.Find("Text Shadows").GetComponent<Timer>().enabled = true ;
        }

    }
}
