using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AndroidManager : MonoBehaviour {
   
    private void Awake()
    {
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currActivity = jc.GetStatic<AndroidJavaObject>("currentActivity");
        if (currActivity != null)
        {
            currActivity.Call("GetSceneName");
        }
    }
    void ChangeScene(string s_n)
    {
        SceneManager.LoadScene(s_n);
    }

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    }
}
