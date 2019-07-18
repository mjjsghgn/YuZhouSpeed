using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weixingzhuan : MonoBehaviour {
    public GameObject earth;
    public GameObject weixing;
    public GameObject weixing1;
    public float speed;
    private float t;
    private float angle;
    private float z;
    private float y;
    private float x;
    private Vector3 _pos;
    private int  b=30;
    private int a=60;
    private Animation ani;
    // Use this for initialization
    void Start () {
        transform.position = new Vector3(-70, 12, 190);
       ani = transform.GetComponent<Animation>();
        Invoke("PingPao", 1.0f);
        Invoke("Yingcang", 5.0f);
        Invoke("guiwei", 10.0f);
        Invoke("RotateAround", 15.0f);
        Invoke("guiwei", 40f);
        Invoke("RotateTuoYuan", 45.0f);
    }
	
	// Update is called once per frame
	void Update () {
       // PingPao();
       
       /* Invoke("guiwei", 10.0f);
        Invoke("RotateAround", 15.0f);
        Invoke("guiwei", 40f);
        Invoke("RotateTuoYuan", 45.0f);*/
    }
    public void PingPao()
    {
           ani.Play("pingpao");
  
    }
    public void RotateTuoYuan()
    {
        
        angle -= Time.deltaTime * 0.8f;
        z = 193;
        y = b * Mathf.Sin(angle) + 10;
        x = -a * Mathf.Cos(angle);
        _pos = new Vector3(x, y, z);
       weixing1.transform.position = Vector3.Lerp(_pos, _pos, Time.deltaTime);
    }
    public void guiwei()
    {
       
        weixing1.transform.position = new Vector3(-70, 12, 190);
        weixing1.transform.localEulerAngles= new Vector3(-55, 187, -4);
    }



    public void RotateAround()
    {
        
        weixing1.transform.RotateAround(earth.transform.position, Vector3.back, speed * Time.deltaTime);

    }
    public void Yingcang()
    {
       Destroy(weixing);
       weixing1.SetActive(true);
    }
    
}
