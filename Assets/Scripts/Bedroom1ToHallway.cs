using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bedroom1ToHallway : MonoBehaviour
{

    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            float fadeTime = GameObject.Find("Fade").GetComponent<CatchThisFade>().BeginFade(1);
            yield return new WaitForSeconds(fadeTime);
            SceneManager.LoadScene("secondFloorHallway");  //Don't know Jay's Hallway name
            LoadLevel.Bedroom1B = true;
        }
    }
}

