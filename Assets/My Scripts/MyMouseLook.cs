using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMouseLook : MonoBehaviour {
    //方向灵敏度  
    public float sensitivityY = 150F;

    //上下最大视角(Y视角)  
    public float minimumY = -60F;
    public float maximumY = 60F;

    private float rotationY = 0f;
    void start()
    {
       // Cursor.visible = false;
    }
    void Update()
    {
        //Cursor.visible = false;
        //rotationX += sensitivityX * Input.GetAxis("Mouse X");
        rotationY += sensitivityY * Input.GetAxis("Mouse Y") * Time.deltaTime;
        //角度限制. rotationY小于min,返回min. 大于max,返回max. 否则返回value   
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

        //总体设置一下相机角度  
        transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
        print(Time.deltaTime);
    }
}
