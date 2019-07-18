using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push2 : MonoBehaviour {

    public GameObject sun ;



    void Update()
    {

        transform.position = new Vector3(sun.transform.position.x-1, sun.transform.position.y , sun.transform.position.z);

    }

}
