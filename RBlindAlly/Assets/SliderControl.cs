using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour {
    public TimeControl s_flag;
    public Slider slider;
    public float value;

	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
        value = 100 - float.Parse(string.Format("{0:N0}", s_flag.flag)) ;
        slider.value = value;
	}
}
