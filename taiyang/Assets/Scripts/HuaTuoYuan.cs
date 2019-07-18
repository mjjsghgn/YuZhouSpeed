using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuaTuoYuan : MonoBehaviour {
    /// <summary>
    /// 首先绘制椭圆的公式
    /// 椭圆的参数方程x=acosθ,y=bsinθ；
    /// </summary>
   // public Transform taiyang;
    public Transform trans;
    public float w;//椭圆长
    public float h; //椭圆高
    public int angle = 360;
    [Range(0, 360)]
    public int speed = 0;
    private Vector3[] vec;
    private int index = 0;
    private LineRenderer line;
    
    float x, y;

    void Start()
    {
        //trans.position = taiyang.position;
        
        vec = new Vector3[angle];

        for (int i = 0; i < angle; i++)
        {
            // Mathf.Deg2Rad 单位角度的弧 相当于 1° 的弧度
            x = w * Mathf.Cos(i * Mathf.Deg2Rad);

            y = h * Mathf.Sin(i * Mathf.Deg2Rad);

            vec[i] = trans.position + new Vector3(x, y, 0);

        }

        SetLine();
    }

    void SetLine()
    {
        line = gameObject.AddComponent<LineRenderer>();
        //设置线由多少个点构成
        line.SetVertexCount(angle);
        //绘制点的坐标
        line.SetPositions(vec);
     
        //设置宽度  
        line.startWidth = 0.5f;
        line.endWidth = 0.5f;
    }


    void Update()
    {
        line.startColor = Color.gray;
        line.endColor = Color.gray;
        trans.position = vec[index];

        if ((index += speed) >= vec.Length)

        {
            index = 0;
        }
        

    }
}
