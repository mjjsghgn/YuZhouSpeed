using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class xiayiye : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   public void OnClick()
    {

        //场景跳转...

        //Application.LoadLevel("demo3NewScenes");//使用场景名
        SceneManager.LoadScene("path");

        //使用参数名

    }
}
