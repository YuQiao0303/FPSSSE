using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mplayer : MonoBehaviour {

    // Use this for initialization
    bool mp = true;
    private AudioSource audioclip;

    void Start()
    {
        audioclip = this.gameObject.GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void music_player()
    {
        if (mp)
        {
            audioclip.Play();
            mp = false;
        }
        else
        {
            audioclip.Stop();
            mp = true;
        }
    }

}
