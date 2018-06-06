using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateUntilNeeded : MonoBehaviour {

    void Update()
    {
        foreach (Transform child in this.transform)
        {
            if (Shadows.DeletedShadows.Contains("TrappedFountain"))
            {
                child.gameObject.SetActive(true);
            }
            else
            {
                child.gameObject.SetActive(false);
            }
        }

    }
}
