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

    public bool box_net_col;
    public GameObject box;

    private float holdTime = 2f;
    private float acumTime = 0;

    public Text how_to;

    // Use this for initialization
    void Start () {
        box_net_col = false;
        Text t = how_to.GetComponent<Text>();
        t.enabled = false;
    }
	void moveParabola()
    {

    }
	// Update is called once per frame
	void Update () {
		if (netmov.get_net){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)){
                if (hit.transform.tag == "Net"){
                    acumTime += Input.GetTouch(0).deltaTime;
                    if(acumTime >= holdTime)
                    {
                        moveParabola();
                        RawImage r = getBox.GetComponent<RawImage>();
                        r.enabled = true;
                        Destroy(getBox, 1.5f);
                        box_net_col = true;
                        //Text t = how_to.GetComponent<Text>();
                        Destroy(how_to);
                        Destroy(gameObject);
                        Destroy(box);
                    }
                    
                }
            }

        }
    }

  
}
