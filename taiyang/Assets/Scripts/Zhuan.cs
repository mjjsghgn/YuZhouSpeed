using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Zhuan : MonoBehaviour
{

    public InputField inputField;
    //椭圆半长轴a、半短轴b、
    public float a, b;
    //椭圆三角函数的角θ
    float angle, angle1;
    //椭圆三角函数的角变化的速度
    public float angleSpeed = 1f;
    //三个float变量
    float z, x, y;
    //椭圆轨迹上的坐标
    Vector3 _pos;
    public Transform earth;
    public GameObject sun;
    //绕地球圆转速度
    private float speed = 80;
    private float x1, y1;
    //航天器飞行速度
    private double fspeed;
    private Text text;
    private Button button, button1;
    float i, j,n;
    private bool flag;
    public GameObject moon, mubiao;
    public GameObject trans, trans1;
    private float t;
    private float _t;
    public GameObject Fracture;
    public List<Vector3> points;
    private LineRenderer line;
    private bool flag1;
    public  GameObject target,sun1;
    private Vector3 newPos;
    private Animation animation1,animation2,animation3;
    public GameObject moon_1;
    // private GameObject[] m_gb;

    void Start()
    {
      
        angle = 0;
        i = 0;
        transform.position = new Vector3(-60, 10, 222);
        button = GameObject.Find("fashe").GetComponent<Button>();
        button = GameObject.Find("chongzhi").GetComponent<Button>();
        flag1 = false;
        animation1 = moon.GetComponent<Animation>();
        animation2 = earth.GetComponent<Animation>();
        animation3=sun.GetComponent<Animation>();
        moon_1.transform.position = new Vector3(-400, 460, 1150);
    }
    public void ChongZhi()
    {
        /* GameObject.Find("InputField").GetComponent<InputField>().text = "km/s";
         trans.SetActive(false);
         trans1.SetActive(false);
         moon.transform.position = new Vector3(-90, 10, 222);
         //Fracture.SetActive(false);       
         Destroy(Fracture.gameObject);
         moon.SetActive(true);
         moon.AddComponent<Rigidbody>();
         angle = 0;
         flag = false; ;
         t = 0;
      //   StartCoroutine(WaitAndPrint(0.015f));*/
        SceneManager.LoadScene("path");



    }
    public void FaShe()
    {
        
        inputField = GameObject.Find("InputField").GetComponent<InputField>();
        fspeed = Convert.ToDouble(inputField.text);
      //  Debug.Log(fspeed );
        moon.transform.position = new Vector3(-60, 10, 222);
        flag = true;
      
    }
    private void FixedUpdate()
    {
        if (flag == true)
        {
           

            if (fspeed > 0 && fspeed < 7.9)
            {
                flag1 = true;             
                PingPao();
                
            }
           
            else
            {
                if (fspeed == 7.9)
                {
                    Destroy(GetComponent<Rigidbody>());
                    trans1.SetActive(true);
                    trans.SetActive(false);
                    RotateAround();
                }
                else
                {
                    if (fspeed > 7.9 && fspeed < 11.2)
                    {

                         trans.SetActive(true);
                         trans1.SetActive(false);
                         RotateTuoYuan();                     

                    }
                    else
                    {
                        if (fspeed >= 11.2 && fspeed < 16.7)
                        {

                            Destroy(GetComponent<Rigidbody>());
                            animation1.Play("FlyToSun");
                            animation2.Play("FlyAway");
                           
                            animation3.Play("FlyToEarth");
                            if (sun.transform.position== new Vector3(-30, 10, 222))
                            {

                                moon_1.transform.position = moon.transform.position;
                                sun.SetActive(false);
                                sun1.SetActive(true);
                                moon.SetActive(false);
                                moon_1.SetActive(true);
                                flag1 = true;
                            }
                            if (flag1 == true)
                            {
                                RotateAroundSun();
                            }
                                                  
                        }
                        else
                        {
                            // Debug.Log(fspeed);
                            
                        }
                    }
                }
            }

        }
        else
        {
            moon.transform.position = new Vector3(-60, 10, 222);
        }
       
    }
     public void RotateTuoYuan()
     {
         angle -= Time.deltaTime * 0.8f;
         z = 222;
         y = b * Mathf.Sin(angle)+10;
         x = -a * Mathf.Cos(angle);
         _pos = new Vector3(x, y, z);
         transform.position = Vector3.Lerp(_pos, _pos, Time.deltaTime);
     }
 
 

    public void RotateAround()
    {
       moon.transform.RotateAround(earth.transform.position, Vector3.forward, speed * Time.deltaTime);

    }
    public void RotateAroundSun()
    {
        moon_1.transform.RotateAround(sun.transform.position, Vector3.forward, speed * Time.deltaTime);

    }
    public void PingPao()
    {      
        if (flag1 == true)
        {
            t += 0.005f;
            double dx = fspeed*5*t; //Sx = vt            
            double dy = Physics2D.gravity.magnitude * t * t; //竖直上抛运动 Sy=Vot- gt*t/2          
            float dxx = (float)dx;
            float dyy = (float)dy;
            Vector3 pos = new Vector3(moon.transform.position.x + dxx, moon.transform.position.y+dyy, 222);
            moon.transform.position = pos;
           
        } 

    }
   
    //检测是否与地面碰撞
    public void OnCollisionEnter(Collision collision)
    {        
      if(collision.collider.tag =="Player")
        {
            
            Fracture.transform.position = moon.transform.position;
            Fracture.SetActive(true);
            moon.SetActive(false);
           
        }
       

    }
   
  

}
