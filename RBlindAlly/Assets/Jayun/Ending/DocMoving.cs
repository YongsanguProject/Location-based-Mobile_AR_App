using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DocMoving : MonoBehaviour {

    public RawImage doc1;
    public RawImage doc2;
    public RawImage doc3;
    public RawImage doc4;
    public RawImage doc5;
    public string NextSceneString;
    public Text docText;

    float delta = 10f;
    float textTime = 0;

  

    // Use this for initialization
    void Start () {
        docText.gameObject.SetActive(false);
    }
	
    void DocMove()
    {
        RectTransform d1 = doc1.GetComponent<RectTransform>();
        d1.position = new Vector3(d1.position.x + delta*0.6f,
                                d1.position.y - delta,
                                d1.position.z);

        RectTransform d2 = doc2.GetComponent<RectTransform>();
        d2.position = new Vector3(d2.position.x,
                                d2.position.y - delta,
                                d2.position.z);

        RectTransform d3 = doc3.GetComponent<RectTransform>();
        d3.position = new Vector3(d3.position.x - delta * 0.6f,
                                d3.position.y - delta,
                                d3.position.z);

        RectTransform d4 = doc4.GetComponent<RectTransform>();
        d4.position = new Vector3(d4.position.x + delta * 0.6f,
                                d4.position.y + delta,
                                d4.position.z);

        RectTransform d5 = doc5.GetComponent<RectTransform>();
        d5.position = new Vector3(d5.position.x - delta * 0.6f,
                                d5.position.y + delta,
                                d5.position.z);
    }
	// Update is called once per frame
	void Update () {
        RectTransform d2 = doc2.GetComponent<RectTransform>();

        if (d2.position.y > 1000f) DocMove();
        else
        {
            docText.gameObject.SetActive(true);

            Destroy(docText, 3f);
            Destroy(doc1, 3f);
            Destroy(doc2, 3f);
            Destroy(doc3, 3f);
            Destroy(doc4, 3f);
            Destroy(doc5, 3f);
            Application.LoadLevel(NextSceneString);
            /*
            while(textTime >= 0f)
            {
                textTime += Time.deltaTime;
                if (textTime > 3f) {
                    Application.LoadLevel(NextSceneString);
                    textTime = -10f;
                }
            }
            */

        }

    }
}
