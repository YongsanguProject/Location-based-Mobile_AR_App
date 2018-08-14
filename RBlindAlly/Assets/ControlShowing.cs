using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControlShowing : MonoBehaviour
{
    public BoxTracking_bl bt;
    public Text Clicktext;
   
    // Use this for initialization
    void Start()
    {
        Clicktext.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (bt.is_detected_)
        {
            Clicktext.gameObject.SetActive(true);

        }else
        {
            Clicktext.gameObject.SetActive(false);
        }
    }

}
