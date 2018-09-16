using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EndingDoCamera : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData eventData)
    {
        CallAcitivty();
    }
    private AndroidJavaObject activityContext = null;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void CallAcitivty()
    {
        using (AndroidJavaClass activityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            activityContext = activityClass.GetStatic<AndroidJavaObject>("currentActivity");
        }
        using (AndroidJavaClass ajc = new AndroidJavaClass("com.smtown.yongsangu_ar_project.sookmyung.ar.UnityPlayerActivity"))
        {
            if (ajc != null)
            {
                ajc.CallStatic("CallActivity", activityContext);
            }
        }
    }

}
