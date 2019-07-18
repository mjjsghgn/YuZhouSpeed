using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YinCang : MonoBehaviour {

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public GameObject gameObject;
    public void SetActive()
    {
        gameObject.SetActive(true);
    }
    public void SetActive1()
    {
        gameObject.SetActive(false);
    }
}
