using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallAndroidActivity : MonoBehaviour {
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
            activityContext = activityClass.GetStatic<AndroidJavaObject>("UnityPlayerActivity");
        }
        using (AndroidJavaClass ajc = new AndroidJavaClass("com.smtown.yongsangu_ar_project.sookmyung.ending.camera.CameraTestActivity"))
        {
            if (ajc != null)
            {
                ajc.CallStatic("CallActivity", activityContext);
            }
        }
    }
}
