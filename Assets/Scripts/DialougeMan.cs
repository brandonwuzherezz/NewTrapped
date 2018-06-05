﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialougeMan : MonoBehaviour {
    public Queue<Texture> Images;
    public Texture[] MyImages;
    public RawImage MyRaw;
    //public AudioSource StartWalkie;
    public AudioSource WalkieTalkie;
    public AudioSource EndWalkie;
    public bool Dead = false;
    //public Animator animator;

    void Start () {
        Images = new Queue<Texture>();
        Images.Clear();
        foreach (Texture img in MyImages)
        {
            Images.Enqueue(img);
        }
        //StartWalkie.Play();
        //animator.SetBool("IsOpen", false);
        WalkieTalkie.Play();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Images.Count == 0 && Dead == false)
        {
            //MyRaw.texture = Empty;
            WalkieTalkie.loop = false;
            WalkieTalkie.Stop();
            WalkieTalkie.Stop();
            EndWalkie.Play();
            Dead = true;
            return;
        }
        if (Input.GetKeyDown(KeyCode.Return) && Images.Count > 0)
        {
            //animator.SetBool("IsOpen", true);
            //StartCoroutine("Wait");
            Texture IMG = Images.Dequeue();
            MyRaw.texture = IMG;
        }
        
    }
    public void StartDialogue()
    {
        //animator.SetBool("IsOpen", true);
        return;
    }

    void EndDialogue()
    {
        //animator.SetBool("IsOpen", false);
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        Texture IMG = Images.Dequeue();
        MyRaw.texture = IMG;
        //animator.SetBool("IsOpen", false);
    }
}
