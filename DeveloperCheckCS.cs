using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeveloperCheckCS : MonoBehaviour
{
    public GameObject DevOnly;
    void Start()
    {
        if (Debug.isDebugBuild)
        {
            DevOnly.SetActive(true);
        }
    }
}
