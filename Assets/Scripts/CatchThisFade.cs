using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//explantion/code gotten from https://www.youtube.com/watch?v=0HwZQt94uHQ
public class CatchThisFade : MonoBehaviour {
    public Texture fadeOutmatieral;
    public float fadeSpeed = 0.8f;

    public int drawDepth = -1000;
    private float alpha = 1.0f; //alpha value
    private int fadeDir = -1; // Fade in = -1 out = 1

    void OnGUI()
    {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutmatieral);
    }

    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return (fadeSpeed);
    }

    void OnLevelWasLoaded()
    {
        BeginFade(-1);
    }
}
