using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Library_box_Tracking : MonoBehaviour, ITrackableEventHandler
{


    private TrackableBehaviour mTrackableBehaviour;
    public bool is_detected_l = false;
   // public ControlBox bas;
    public int grass = 0;
    //public GameObject box;


    // Use this for initialization
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED)
        {

            is_detected_l = true;
            Debug.Log("true");
    

        }
        else
        {
            is_detected_l = false;
            Debug.Log("false");
        }
    }
}
