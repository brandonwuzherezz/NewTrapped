using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnterBarricadeDH : MonoBehaviour {

    public static bool dhKey;
    public bool inTrigger;
    public static bool DHlocked = true;
    public MeshRenderer myDoor;
    public Material UnlockedDoor;
    public AudioSource Locked;
    public AudioSource UnLock;
    public static bool DHDestroyed = false;
    public RawImage MyRaw;
    public RawImage MyDiss;
    public static bool DialougeActive = false;
    public Texture[] MyImages;
    public Animator animator;
    public bool Isdead;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            if (DHlocked == true)
            {
                Locked.Play();
                if (DialougeActive == false) {
                    print("HERE");
                    GameObject.Find("DialougeMan").GetComponent<DialougeMan>().MyRaw = MyDiss;
                    GameObject.Find("DialougeMan").GetComponent<DialougeMan>().animator = animator;
                    GameObject.Find("DialougeMan").GetComponent<DialougeMan>().Dead = false;
                    //GameObject.Find("DialougeMan").GetComponent<DialougeMan>().Images.Clear();
                    foreach (Texture img in MyImages)
                    {
                        GameObject.Find("DialougeMan").GetComponent<DialougeMan>().Images.Enqueue(img);
                    }
                    animator.SetBool("IsOpen", true);
                    GameObject.Find("DialougeMan").GetComponent<DialougeMan>().WalkieTalkie.Play();
                    
                    GameObject.Find("DialougeMan").GetComponent<DialougeMan>().enabled = true ;
                    GameObject.Find("InMyCar").GetComponent<DoThisForMe>().DisccusionName = "RawrImage";
                    GameObject.Find("InMyCar").GetComponent<DoThisForMe>().enabled = true;
                    DialougeActive = true;
                }
            }
        }
    }
    

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
        }
    }

    void Start()
    {
        if (DHlocked == false)
        {
            myDoor.material = UnlockedDoor;
        }
    }
    void Update()
    {
        if (DHlocked)
        {
            if (inTrigger)
            {
                if (dhKey)
                {
                    if (DHlocked)
                    {
                        MyRaw.enabled = true;
                    }
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        DHlocked = false;
                        KeyManager.isImgOn = false;
                        //image changing code
                        myDoor.material = UnlockedDoor;
                        //play soundeffect
                        UnLock.Play();
                        DHDestroyed = true;


                    }

                }
               
            }
            else
            {
               
                    MyRaw.enabled = false;
                    
            }
        }
        if (DHDestroyed == true)
        {
            Destroy(gameObject);
        }
    }
    
}
