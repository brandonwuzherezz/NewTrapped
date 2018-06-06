using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoThisForMe : MonoBehaviour {

    public string DisccusionName;
    public bool Isdead;
    public static List<string> DeadDialouge = new List<string>();

    void Start()
    {
        if (DeadDialouge.Contains(DisccusionName))
        {
            Destroy(GameObject.Find(DisccusionName));
            Destroy(this);
        }
    }
    void Update()
    {
        Isdead = GameObject.Find("DialougeMan").GetComponent<DialougeMan>().Dead;
        if (Isdead == true)
        {
            DeadDialouge.Add(DisccusionName);
            GameObject.Find("Girl").GetComponent<Player_Movement>().anim.SetInteger("State", 0);
            GameObject.Find("Girl").GetComponent<Player_Movement>().enabled = true;
            Destroy(GameObject.Find(DisccusionName));
            Destroy(this);
        }
        else
        {
            GameObject.Find("Girl").GetComponent<Player_Movement>().anim.SetInteger("State", 0);
            GameObject.Find("Girl").GetComponent<Player_Movement>().audioSource.Stop();
            GameObject.Find("Girl").GetComponent<Player_Movement>().enabled = false;
        }
    }
}
