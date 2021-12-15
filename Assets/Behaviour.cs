using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class Behaviour : MonoBehaviour {
    private GameObject buttonObj;
    private GameObject fps;
    //private GameObject tps;
    private GameObject cmodel;
    public GameObject cam1;
    public GameObject cam3;
    public GameObject cama;
    // public GameObject camn;
    // Use this for initialization
    void Start () {
        buttonObj = GameObject.Find("Button");
        cam1 = GameObject.Find("Camera");
        cam3 = GameObject.Find("MainCamera");
        cama = GameObject.Find("Acamera");
        fps = GameObject.Find("Capsule");
       // tps = GameObject.Find("MultipurposeCameraRig");
        cmodel = GameObject.Find("unitychan");
       // camn = GameObject.Find("newcame");
        buttonObj.GetComponent<Button>().onClick.AddListener(camera3on);
        //cmodel.SetActive(false);
        //cam3.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void camera3on() {
        //GameObject.FindWithTag("camera3").SetActive(true);
        //GameObject.FindWithTag("Player").SetActive(true);
        //GameObject.FindWithTag("camera1").SetActive(false);
         fps.SetActive(false);
        cam1.SetActive(false);
        cama.SetActive(false);
        cmodel.transform.localEulerAngles = new Vector3(0f, fps.transform.localEulerAngles.y, 0f);
        cmodel.transform.position = new Vector3(fps.transform.position.x, fps.transform.position.y - 0.9f, fps.transform.position.z);
        // tps.SetActive(true);
        cmodel.SetActive(true);
        cam3.SetActive(true);

        //camn.SetActive(false);
        print("stopcamera1");
    }
    public void camera1on()
    {
        //GameObject.FindWithTag("camera3").SetActive(false);
        //GameObject.FindWithTag("Player").SetActive(false);
        //GameObject.FindWithTag("camera1").SetActive(true);
 
        //tps.SetActive(false);
        cmodel.SetActive(false);
        cam3.SetActive(false);
        
        cama.SetActive(false);
        fps.transform.position = new Vector3(cmodel.transform.position.x, cmodel.transform.position.y + 0.9f, cmodel.transform.position.z);
        fps.transform.localEulerAngles = new Vector3(0f, cmodel.transform.localEulerAngles.y, 0f);

        fps.SetActive(true);
        cam1.SetActive(true);
        // camn.SetActive(true);
        print("stopcamera3");
    }
    public void cameraaon() {
        fps.SetActive(false);
        // tps.SetActive(true);
        cmodel.SetActive(false);
        cam3.SetActive(false);
        cam1.SetActive(false);
        cama.SetActive(true);
        
    }
   
}
