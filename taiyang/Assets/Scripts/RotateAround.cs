using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {
    public GameObject taiyang;
    public GameObject diqiu;
    public float speed;
    private float a;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(taiyang.transform.position, Vector3.left, speed * Time.deltaTime);   

	}
}
