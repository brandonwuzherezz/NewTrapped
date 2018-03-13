using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {
    public static bool isCreated = false;
    void Awake()
    {
        if (isCreated == false)
        {
            DontDestroyOnLoad(transform.gameObject);
            isCreated = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
