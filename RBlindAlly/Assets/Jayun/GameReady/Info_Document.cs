using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info_Document : MonoBehaviour {
    public Btn_Control bc;
    public RawImage info;
    public Text document_text;

    float delta = 10f;

    public RawImage miniPark;
    public RawImage bubble;
    // Use this for initialization
    void Start () {
        info.gameObject.SetActive(false);
        document_text.gameObject.SetActive(false);

        miniPark.gameObject.SetActive(false);
        bubble.gameObject.SetActive(false);

    }
    void DropDown()
    {
        RawImage rpi = info.GetComponent<RawImage>();
        rpi.enabled = true;

        RectTransform t = info.GetComponent<RectTransform>();
        t.position = new Vector3(t.position.x
                                 , t.position.y - delta * 2.3f
                                 , 0);
    }
    // Update is called once per frame
    void Update () {
        RectTransform t = info.GetComponent<RectTransform>();

        if (bc.page == 3)
        {
            info.gameObject.SetActive(true);

            if (t.position.y >= 1000f) DropDown();
            else
            {
                document_text.gameObject.SetActive(true);
                miniPark.gameObject.SetActive(true);
                bubble.gameObject.SetActive(true);
            }
        }
	}
}
