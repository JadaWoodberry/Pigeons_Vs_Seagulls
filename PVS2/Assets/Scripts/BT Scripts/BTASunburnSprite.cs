﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTASunburnSprite : MonoBehaviour
{
    private SpriteRenderer SR;
    private GameObject camera;
    private Transform tform;
    private GameObject player;
    private BTAPlayerController playerController;
    GameObject BTAObject;
    BTAScript BTAScript;
    private bool sTalking;
    private bool talking;
    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        SR.sortingLayerName = "Default";
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        tform = camera.GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<BTAPlayerController>();
        //player controller ^^
        // BTASCRIPT vv
        BTAObject = GameObject.FindGameObjectWithTag("LT");
        BTAScript = BTAObject.GetComponent<BTAScript>();
        sTalking = BTAScript.sTalking;
    }

    // Update is called once per frame
    void Update()
    {
        talking = playerController.getTalking();
        if (talking == true && BTAScript.sTalking == true)
        {
            SR.sortingLayerName = "talksprite";
            transform.position = new Vector2(tform.position.x - 7f, tform.position.y - 2);
        }
        if (BTAScript.sTalking == false)
        {
            SR.sortingLayerName = "Default";
        }
    }
}
