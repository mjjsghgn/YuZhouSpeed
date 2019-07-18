using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenSui : MonoBehaviour {
    public GameObject moon;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = moon.transform.position;
	}
}
