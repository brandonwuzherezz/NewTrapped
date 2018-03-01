﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterTheDH : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("6HallWay1");
            LoadLevel.HallWay = true;
        }
    }
}
