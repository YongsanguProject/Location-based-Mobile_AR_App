using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flower_Flag : MonoBehaviour {

    public TouchTree tt;

    //int i = 0;
    public GameObject[] flower;
    public GameObject[] flag;


    // Use this for initialization

    int count = 0;

    float time = 0f;
    public Text touchtreetext;
    
	void Start () {
        flower = GameObject.FindGameObjectsWithTag("Flower");
        flag = GameObject.FindGameObjectsWithTag("Flag");

        for ( int i = 0; i < flower.Length; i++)
        {
            flower[i].gameObject.SetActive(false);
            flag[i].gameObject.SetActive(false);
        }

        touchtreetext.gameObject.SetActive(false);
    }

	// Update is called once per frame
	void Update () {

        if (count < 16)
        {
            time += Time.deltaTime;
            while (time > 0.1f)
            {
                flower[count].gameObject.SetActive(true);
                flag[count].gameObject.SetActive(true);
                count++;
                time = 0;

            }
        }
        else
        {
            touchtreetext.gameObject.SetActive(true);
            Destroy(touchtreetext, 3f);

        }
    }
}
