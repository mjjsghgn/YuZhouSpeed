using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuoZhuai : MonoBehaviour {
    private bool onDrag = false;                                      //是否被拖拽
    public float speed = 3f;                                          //旋转速度
    private float tempSpeed;                                          //阻尼速度
    private float axisX;                                              //鼠标沿水平方向移动的增量
    private float axisY;
    
    private float cXY;                                                //鼠标移动的距离
    /// <summary>

    /// 接收鼠标按下的事件

    /// </summary>

    public void OnMouseDown()
    {
        axisX = 0f;                                                   //为移动的增量赋初值
        axisY = 0f;
        
    }
    /// <summary>

    /// 鼠标拖拽时的操作

    /// </summary>

    public void OnMouseDrag()
    {
        onDrag = true;                                                //被拖拽
        axisX = -Input.GetAxis("Mouse X");                            //获得鼠标增量
        axisY = Input.GetAxis("Mouse Y");

        cXY = Mathf.Sqrt(axisX* axisX + axisY* axisY);              //计算鼠标移动的长度
        if (cXY == 0f)
        {
            cXY = 1f;
        }
    }

 
    /// <summary>

    /// 计算阻尼速度

    /// </summary>

    /// <returns>阻尼的值</returns>

    public float Rigid()
    {
       if (onDrag)
        {
            tempSpeed = speed;
        }
        else
        {
            if (tempSpeed > 0)
            {
                tempSpeed -= speed* 2 * Time.deltaTime / cXY;        //通过除以鼠标移动长度实现拖拽越长速度减缓越慢
            }
            else
            {
                tempSpeed = 0;
            }

        }
        return tempSpeed;                                             //返回阻尼的值

    }
    public void Update()
    {
        gameObject.transform.Rotate(new Vector3(axisY, axisX, 0) * Rigid(), Space.World);

        if (!Input.GetMouseButton(0))
        {
            onDrag = false;
        }
    }
}
