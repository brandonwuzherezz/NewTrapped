﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterClosetToMasterBedroom : MonoBehaviour {

    IEnumerator OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag== "Player")
        {
            float fadeTime = GameObject.Find("Fade").GetComponent<CatchThisFade>().BeginFade(1);
            yield return new WaitForSeconds(fadeTime);
            SceneManager.LoadScene("MasterBedroom");
            LoadLevel.MasterCloset = true;
        }
    }
}
