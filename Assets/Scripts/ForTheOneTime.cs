﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForTheOneTime : MonoBehaviour
{
    public string DisccusionName;
    public bool Deactivate = false;
    void Start()
    {
        if (DoThisForMe.DeadDialouge.Contains(DisccusionName))
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Girl").GetComponent<Player_Movement>().anim.SetInteger("State", 0);
        GameObject.Find("Girl").GetComponent<Player_Movement>().audioSource.Stop();
        GameObject.Find("Girl").GetComponent<Player_Movement>().enabled = false;
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //Press Enter And Then Close Image Using Anim
            GameObject.Find("Girl").GetComponent<Player_Movement>().anim.SetInteger("State", 0);
            GameObject.Find("Girl").GetComponent<Player_Movement>().enabled = true;
            DoThisForMe.DeadDialouge.Add(DisccusionName);
            Destroy(gameObject);
        }
    }
}