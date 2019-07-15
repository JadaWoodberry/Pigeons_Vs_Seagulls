using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoPlayer : MonoBehaviour
{
    public VideoPlayer vid;
    bool over;

    // Start is called before the first frame update
    void Start()
    {
        over = false;
        vid.loopPointReached += CheckOver;

    }

    // Update is called once per frame
    void Update()
    {
        //print(over);
        if (over == true)
        {
            gameObject.SetActive(false);
        }

        
    }
    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        over = true;
        return;
    }
}
