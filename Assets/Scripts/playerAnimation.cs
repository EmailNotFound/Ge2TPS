using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour {
    //定义一个动画控制器，用来储存主角的动画控制器
    private Animator playerAnimator;  

	void Start () {
        //获取到主角的动画控制器，并赋值
        playerAnimator = GetComponent<Animator>();  
	}
	void Update () {
        //如果按下左键，就将条件变量设为true，此时播放shoot动画
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            playerAnimator.SetBool("shoot",true);
        }
        //如果弹起左键，就将条件变量设为false，此时停止播放shoot动画
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            playerAnimator.SetBool("shoot", false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerAnimator.SetBool("w", true);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("shift", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("shift", false);
        }
    }
}
