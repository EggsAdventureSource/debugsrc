using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugToggleCS : MonoBehaviour
{
    public int debugon;
    public GameObject DebugObj;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            if (DebugObj.activeSelf != true)
            {
                DebugObj.SetActive(true);
                return;
            }
            if (DebugObj.activeSelf == true)
            {
                DebugObj.SetActive(false);
                return;
            }
        }
    }
}
