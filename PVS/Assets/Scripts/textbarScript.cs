using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textbarScript : MonoBehaviour
{
    private SpriteRenderer SR;
    private GameObject camera;
    private Transform tform;
    private GameObject player;
    private playerController playerController;
    bool talking = false;

    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        SR.sortingLayerName = "Default";
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        tform = camera.GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<playerController>();
        talking = playerController.talking;
    }

    // Update is called once per frame
    void Update()
    {
        talking = playerController.gettalking();

        if (talking == true)
        {
            SR.sortingLayerName = "Textbars";
            transform.position = new Vector2(tform.position.x, tform.position.y - 3.8f);
        }
        else if (talking == false)
        {
            SR.sortingLayerName = "Default";
        }


    }
}
