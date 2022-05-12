using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DebugProfilerCS : MonoBehaviour
{
    public string output = "";
    public string stack = "";
    public string logtype = "";
    public GameObject error;
    public GameObject info;
    public GameObject warning;
    public Text dbgText;
    void OnEnable()
    {
        Application.logMessageReceived += HandleLog;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }

    void HandleLog(string logString, string stackTrace, LogType type)
    {
        output = logString;
        stack = stackTrace;
        logtype = type.ToString();
    }
    void Update()
    {
        dbgText.text = output;
        if (logtype == "Error")
        {
            error.SetActive(true);
        }
        else
        {
            error.SetActive(false);
        }
        if (logtype == "Warning")
        {
            warning.SetActive(true);
        }
        else
        {
            warning.SetActive(false);
        }
        if (logtype == "Log")
        {
            info.SetActive(true);
        }
        else
        {
            info.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.LogWarning("testwarn.");
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("testlog.");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.LogError("testerror.");
        }
    }
}
// bad code i k
