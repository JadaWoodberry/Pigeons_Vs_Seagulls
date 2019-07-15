using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class BTATamiSprite : MonoBehaviour
{
    private SpriteRenderer SR;
    private GameObject camera;
    private Transform tform;
    private GameObject player;
    private BTAPlayerController playerController;
    GameObject BTAObject;
    BTAScript BTAScript;
    private bool tTalking;
    private bool talking;
    int counter;
    bool trans;

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
        tTalking = BTAScript.tTalking;
    }

    // Update is called once per frame
    void Update()
    {
        talking = playerController.getTalking();
        if (talking == true && BTAScript.tTalking == true)
        {
            SR.sortingLayerName = "talksprite";
            transform.position = new Vector2(tform.position.x - 7f, tform.position.y);
        }
        if (BTAScript.tTalking == false)
        {
            SR.sortingLayerName = "Default";
        }
    }
}
