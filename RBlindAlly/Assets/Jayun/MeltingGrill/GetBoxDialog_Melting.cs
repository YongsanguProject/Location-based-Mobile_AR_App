using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetBoxDialog_Melting : MonoBehaviour
{
    public BoxSelect_Melting obj_box;

    public RawImage getBox;
    // Use this for initialization
    void Start()
    {
        RawImage r = getBox.GetComponent<RawImage>();
        r.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (!obj_box.is_appear)
        {
            RawImage r = getBox.GetComponent<RawImage>();
            r.enabled = true;

            Destroy(getBox, 1.5f);
        }
    }
}
