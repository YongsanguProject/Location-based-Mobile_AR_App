using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlArrow : MonoBehaviour {
    public GameObject arrow;

	// Use this for initialization
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        Destroy(arrow.gameObject, 3.0f);

    }
}
