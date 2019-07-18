using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zhuan1 : MonoBehaviour
{
    private float angle;
    private float x, y, z;
    Vector3 _pos;
    public float a, b;
    public GameObject trans2;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        trans2.SetActive(true);
        angle -= Time.deltaTime * 0.8f;
        z =222;
        y = b* Mathf.Sin(angle) + 10;
        x = -a* Mathf.Cos(angle);
        _pos = new Vector3(x, y, z);
        transform.position = Vector3.Lerp(_pos, _pos, Time.deltaTime);

    }

}
