using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SELF : MonoBehaviour
{
    public Transform self;
    // Use this for initialization
    void Start()
    { }
    void Update()
   {
    //    Sequence mySequence = DOTween.Sequence();//创建一个序列
    //    mySequence.Append(transform.DOMoveX(11, 6));//6秒内沿着X轴移动到X=6
    //    mySequence.Insert(0, transform.DOMoveY(2, mySequence.Duration()));//沿着Y轴移到Y=2的地方，此动作贯穿整个项目
    //    mySequence.Append(transform.DORotate(new Vector3(0, 180, 0), 2));//绕Y轴绕到180deg的角度
    //    mySequence.Append(transform.DORotate(new Vector3(0, 0, 0), 2));//绕Y轴绕到0deg的角度
    //    mySequence.Append(transform.DORotate(new Vector3(0, 270, 0), 3));//绕Y轴绕到270deg的角度
    //    mySequence.Append(transform.DOMoveX(7, 6));//沿着X轴运动到X=7
    //    mySequence.Join(transform.DORotate(new Vector3(0, 180, 0), 7));//绕Y轴旋转到180deg
    //    mySequence.Append(transform.DOMoveZ(-29, 6));//沿着Z轴运动到Z=-29的位置
    //    mySequence.Insert(22, transform.DORotate(new Vector3(0, 270, 0), 3));//从第22秒开始绕着Y轴转到270deg的方向，持续时间为三秒
    //    mySequence.Insert(25, transform.DORotate(new Vector3(0, 90, 0), 3));//从第25秒开始绕着Y轴转到90deg的方向，持续时间为三秒
    //    mySequence.Append(transform.DOMoveX(14, 6));
    //    mySequence.Join(transform.DORotate(new Vector3(0, 180, 0), 8));
    //    mySequence.Append(transform.DOMoveZ(-36, 8));//沿Z轴运动到-36的位置，时间8秒
    //    mySequence.Join(transform.DOMoveY(4, 8));//盐Y轴运动到Y=4的位置，时间8秒
    //    mySequence.Append(transform.DORotate(new Vector3(0, 270, 0), 3));
    //    mySequence.Join(transform.DOMoveX(12, 2));
    //    mySequence.Join(transform.DORotate(new Vector3(0, 360, 0), 4));
    //    mySequence.Append(transform.DOMoveZ(-29, 8));
    //    mySequence.Join(transform.DOMoveY(6, 6));
    //    mySequence.Append(transform.DORotate(new Vector3(0, 268, 0), 4));
    //    mySequence.Append(transform.DOMoveX(0, 8));

        // mySequence.SetLoops(4, LoopType.Yoyo);


    }
    public void automatictravel() {
        Sequence mySequence = DOTween.Sequence();//创建一个序列
        mySequence.Append(transform.DOMoveX(11, 6));//6秒内沿着X轴移动到X=6
        mySequence.Insert(0, transform.DOMoveY(2, mySequence.Duration()));//沿着Y轴移到Y=2的地方，此动作贯穿整个项目
        mySequence.Append(transform.DORotate(new Vector3(0, 180, 0), 2));//绕Y轴绕到180deg的角度
        mySequence.Append(transform.DORotate(new Vector3(0, 0, 0), 2));//绕Y轴绕到0deg的角度
        mySequence.Append(transform.DORotate(new Vector3(0, 270, 0), 3));//绕Y轴绕到270deg的角度
        mySequence.Append(transform.DOMoveX(7, 6));//沿着X轴运动到X=7
        mySequence.Join(transform.DORotate(new Vector3(0, 180, 0), 7));//绕Y轴旋转到180deg
        mySequence.Append(transform.DOMoveZ(-29, 6));//沿着Z轴运动到Z=-29的位置
        mySequence.Insert(22, transform.DORotate(new Vector3(0, 270, 0), 3));//从第22秒开始绕着Y轴转到270deg的方向，持续时间为三秒
        mySequence.Insert(25, transform.DORotate(new Vector3(0, 90, 0), 3));//从第25秒开始绕着Y轴转到90deg的方向，持续时间为三秒
        mySequence.Append(transform.DOMoveX(14, 6));
        mySequence.Join(transform.DORotate(new Vector3(0, 180, 0), 8));
        mySequence.Append(transform.DOMoveZ(-36, 8));//沿Z轴运动到-36的位置，时间8秒
        mySequence.Join(transform.DOMoveY(4, 8));//盐Y轴运动到Y=4的位置，时间8秒
        mySequence.Append(transform.DORotate(new Vector3(0, 270, 0), 3));
        mySequence.Join(transform.DOMoveX(12, 2));
        mySequence.Join(transform.DORotate(new Vector3(0, 360, 0), 4));
        mySequence.Append(transform.DOMoveZ(-29, 8));
        mySequence.Join(transform.DOMoveY(6, 6));
        mySequence.Append(transform.DORotate(new Vector3(0, 268, 0), 4));
        mySequence.Append(transform.DOMoveX(0, 8));
    }
}
