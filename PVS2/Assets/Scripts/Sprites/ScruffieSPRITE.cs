using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScruffieSPRITE : MonoBehaviour
{
    private SpriteRenderer SR;
    private GameObject camera;
    private Transform tform;
    private GameObject player;
    private OutdoorPlayerController playerController;
    bool talking = false;
    GameObject Sns;
    OutdoorScript ODC;
    private bool uTalking;
    private OutdoorScript outdoorScript;
    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        SR.sortingLayerName = "Default";
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        tform = camera.GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<OutdoorPlayerController>();
        Sns = GameObject.FindGameObjectWithTag("NPC");
        ODC = Sns.GetComponent<OutdoorScript>();
        uTalking = ODC.anTalking;
        outdoorScript = GameObject.Find("snssprite").GetComponent<OutdoorScript>();
    }

    // Update is called once per frame
    void Update()
    {
        talking = playerController.talking;
        if (talking == true && outdoorScript.uTalking == true)
        {
            SR.sortingLayerName = "talksprite";
            transform.position = new Vector2(tform.position.x - 7f, tform.position.y - 3);
        }
        if (outdoorScript.uTalking == false)
        {
            SR.sortingLayerName = "Default";
        }
    }
}
