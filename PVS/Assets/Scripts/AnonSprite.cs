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
    bool talking;
    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        SR.sortingLayerName = "Default";
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        tform = camera.GetComponent<Transform>();

        //Sns = GameObject.FindGameObjectWithTag("NPC");
        //ODC = Sns.GetComponent<OutdoorScript>();
        //anTalking = ODC.anTalking;

        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<OutdoorPlayerController>();
        talking = playerController.talking;
    }

    // Update is called once per frame
    void Update()
    {
        //anTalking = ODC.getanTalking();
        //Debug.Log("antalking: " + anTalking);
        talking = playerController.talking;

        if (talking == true && Input.GetKeyDown(KeyCode.Return))
        {
            SR.sortingLayerName = "Textbars";
            transform.position = new Vector2(tform.position.x - 3.5f, tform.position.y - 2.1f);
        }
        if (talking == false)
        {
            //Debug.Log("anTalking false changing layer");
            SR.sortingLayerName = "Default";
        }
    }
}
