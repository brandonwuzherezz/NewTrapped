using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    public static List<string> Deletedimages = new List<string>();
    public int Time = 0;
    private void Start()
    {
        if (Deletedimages.Contains(gameObject.name))
        {
            Destroy(gameObject);
        }

    }
    // Update is called once per frame
    void Update() {
        if (!Deletedimages.Contains(gameObject.name))
        {
            Time++;
            if (Time == 160)
            {
                Deletedimages.Add(gameObject.name);
                Destroy(gameObject);
            }
        }
    }

}
