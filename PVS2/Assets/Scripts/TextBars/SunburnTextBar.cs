using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunburnTextBar : MonoBehaviour
{
    private SpriteRenderer SR;
    private GameObject camera;
    private Transform tform;
    private GameObject player;
    private OutdoorPlayerController playerController;
    bool talking = false;
    GameObject Sns;
    OutdoorScript ODC;
    private bool anTalking;
    private OutdoorScript outdoorScript;

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
        anTalking = ODC.anTalking;
        outdoorScript = GameObject.Find("snssprite").GetComponent<OutdoorScript>();
    }

    void Update()
    {
        talking = playerController.talking;
        if (talking == true && outdoorScript.sTalking == true)
        {
            SR.sortingLayerName = "Textbars";
            transform.position = new Vector2(tform.position.x, tform.position.y - 3.8f);
        }
        if (outdoorScript.sTalking == false)
        {
            SR.sortingLayerName = "Default";
        }
    }
}
