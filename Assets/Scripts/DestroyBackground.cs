using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBackground : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
         if(DontDestroy.isCreated == true)
        {
            Destroy(GameObject.Find("BackgroundSounds"));
            DontDestroy.isCreated = false;
        }
    }

}
