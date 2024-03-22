using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {
    public GameObject bullet;  //声明一个物体，用来存放子弹

	void Start () {
		
	}	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {  //判断：如果按下鼠标左键

            //将子弹实例化到当前物体的位置，保持当前物体的方向
            Instantiate(bullet,transform.position,transform.rotation); 
        }
		
	}
}
