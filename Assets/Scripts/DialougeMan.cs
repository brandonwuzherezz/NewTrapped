using System.Collections;
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
    void Start () {
        Images = new Queue<Texture>();
        Images.Clear();
        foreach (Texture img in MyImages)
        {
            Images.Enqueue(img);
        }
        //StartWalkie.Play();
        WalkieTalkie.Play();
	}
	
	// Update is called once per frame
	void Update () {
        if (Images.Count == 0)
        {
            //MyRaw.texture = Empty;
            WalkieTalkie.loop = false;
            WalkieTalkie.Stop();
            EndWalkie.Play();
            Dead = true;
            return;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            
            Texture IMG = Images.Dequeue();
            MyRaw.texture = IMG;
        }
        
    }
}
