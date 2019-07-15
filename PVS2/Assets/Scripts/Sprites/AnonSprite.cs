using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnonSprite : MonoBehaviour
{
    private SpriteRenderer SR;
    private GameObject camera;
    private Transform tform;

    GameObject Sns;
    OutdoorScript ODC;
    private bool anTalking;

    private GameObject player;
    private OutdoorPlayerController playerController;
    private OutdoorScript outdoorScript;
    bool talking;
    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        SR.sortingLayerName = "Default";
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        tform = camera.GetComponent<Transform>();
        outdoorScript = GameObject.Find("snssprite").GetComponent<OutdoorScript>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<OutdoorPlayerController>();
        talking = playerController.talking;
    }

    // Update is called once per frame
    void Update()
    {
        talking = playerController.talking;

        if (talking == true && Input.GetKeyDown(KeyCode.Return) && outdoorScript.anTalking == true)
        {
            SR.sortingLayerName = "Textbars";
            transform.position = new Vector2(tform.position.x - 8.5f, tform.position.y - 2.1f);
        }
        if (outdoorScript.anTalking == false)
        {
            SR.sortingLayerName = "Default";
        }
    }
}
