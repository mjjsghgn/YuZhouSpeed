using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour {


    public GameObject moon;
    
   
    
    void Update ()	{

        transform.position = new Vector3(moon.transform.position.x,moon.transform.position.y-1f,moon.transform.position.z);
         
    }

}
