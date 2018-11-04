using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Catch_Box : MonoBehaviour {
    public Net_Moving netmov;
    private bool drag = false;
    private Vector3 screenSpace;
    private Vector3 offset;
    public RawImage getBox;

    public CountBox cb;
    public bool net_finish = false;
    public bool box_net_col;
    public GameObject box;

    private float holdTime = 2f;
    private float acumTime = 0;
    public Text how_to;
    float xpos = 0f;
    float delta = 1f;

    public bool test = false;
    // Use this for initialization
    void Start () {
        box_net_col = false;
        Text t = how_to.GetComponent<Text>();
        t.enabled = false;
        net_finish = false;
    }

	// Update is called once per frame
	void Update () {

    


            Transform t = GetComponent<Transform>();
            //if (t.position.z < 100f || t.position.x >-10) moveParabola();
            //else net_finish = true;

            if (net_finish)
            {
                RawImage r = getBox.GetComponent<RawImage>();
                r.enabled = true;
                Destroy(getBox, 1.5f);
                box_net_col = true;
                Destroy(how_to);
                Destroy(gameObject);
                Destroy(box);
                cb.countBox++;
            }
        }

  
}
