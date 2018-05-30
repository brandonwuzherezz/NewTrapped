using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour {
    public DialougeMan MyObj;
    void Start()
    {
        MyObj = GameObject.Find("GameObject").GetComponent<DialougeMan>();
    }
   void Update()
    {
        if(MyObj.Dead == true)
        {
            MyFade();
            SceneManager.LoadScene("1Courtyard");
        }
    }
    IEnumerator MyFade()
    {
        float fadeTime = GameObject.Find("Fade").GetComponent<CatchThisFade>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
    }
}
