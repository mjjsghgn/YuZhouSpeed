using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChange : MonoBehaviour {
    private Text ValueText;
    // Use this for initialization
    void Start () {
        ValueText = GetComponent<Text>();
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnSliderValueChanged(float value)
    {
        ValueText.text = "飞行速度"+value.ToString("0.00")+"km/s";
    }
}
