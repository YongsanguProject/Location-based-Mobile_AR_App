using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GPSCheck : MonoBehaviour
{

    public float lat;
    public float lon;
    // Use this for initialization
    void Start()
    {
        Input.location.Start();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLocation();
    }

    private void UpdateLocation()
    {
        if (Input.location.isEnabledByUser)
        {
            lat = Input.location.lastData.latitude;
            lon = Input.location.lastData.longitude;

        }
    }


}
