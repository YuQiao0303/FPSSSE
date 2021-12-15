using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstPersonController : MonoBehaviour {

    //走、跑、跳（平移）
    public float walkSpeed = 3.0F;
    public float runSpeed = 7.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 10.0F;
    private Vector3 moveDirection = Vector3.zero;
    //旋转
    public float sensitivityX = 150F;
    public float rotationX = 0f;
    //重心浮动
    public float upAndDown = 2.0f;
    void Start()
    {
        //GameObject unitychan = GameObject.Find("unitychan");
        //GameObject cam3 = GameObject.Find("MultipurposeCameraRig");
        //unitychan.SetActive(false);
        //cam3.SetActive(false);
    }

    void Update()
    {
        //走、跑、跳（平移）
        
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)                 //如果着地
        {
            moveDirection = new Vector3(-Input.GetAxis("Horizontal"), 0, -Input.GetAxis("Vertical"));
            //变换方向x, y, z从局部坐标到世界坐标。
            moveDirection = transform.TransformDirection(moveDirection);
            if (Input.GetKey(KeyCode.LeftShift))   //如果跑
            {
                moveDirection *= runSpeed;
            }
            else                                     //如果走
            {
                moveDirection *= walkSpeed;
            }
            if (Input.GetButton("Jump"))              //如果跳
                moveDirection.y = jumpSpeed;

     
            if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) //重心浮动
            {
  
                if ((int)(Time.time * 1000) % 10 == 1)
                {
                    moveDirection.y += upAndDown;
                }
            }
        }
        
        moveDirection.y -= gravity * Time.deltaTime;  //重力作用
        controller.Move(moveDirection * Time.deltaTime); 

        //旋转  
        rotationX += sensitivityX * Input.GetAxis("Mouse X") * Time.deltaTime;
        //总体设置一下相机角度  
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, rotationX , 0);
    }
}
