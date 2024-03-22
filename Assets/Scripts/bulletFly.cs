using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFly : MonoBehaviour {
    private Rigidbody myRigidbody;  //定义一个刚体组件，用来存放子弹的刚体
    public float speed = 10000;  //定义一个子弹的速度
	void Start () {
        myRigidbody = GetComponent<Rigidbody>();  //拿到子弹的刚体组件

        //通过刚体为子弹添加速度，方向是子弹的前方向，大小是speed
        myRigidbody.velocity = transform.forward * speed * Time.deltaTime;  

		
	}
	void Update () {
		
	}
    //定义一个碰撞检测函数，将碰到的物体传给collision
    private void OnCollisionEnter(Collision collision)
    {
        //如果碰到的物体的标签=target 就销毁此物体
        if (collision.collider.tag=="target") {
            Destroy(collision.gameObject);

        }
    }
}
