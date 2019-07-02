using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textbarScript : MonoBehaviour
{
    private SpriteRenderer SR;
    private GameObject camera;
    private Transform tform;
    private GameObject player;
    private playerController playerController;
    bool talking = false;
    public Text textbox;
    public string[] textarray;
    private int counter;

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
        textarray = new string[5];
        textarray[0] = "hi";
        textarray[1] = "hello";
        textarray[2] = "how you doin";
        textarray[3] = "hi again";
        textarray[4] = "okay bye";
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        talking = playerController.gettalking();

        if (talking == true)
        {
            //Debug.Log("Talking");
            SR.sortingLayerName = "Textbars";
            transform.position = new Vector2(tform.position.x, tform.position.y - 3.8f);
            if (counter < 5 && Input.GetKeyDown(KeyCode.Return))
            {
                textbox.text = textarray[counter];
                counter++;
            }
            else if (counter >= 5)
            {
                playerController.setTalking(false);
                talking = false;
                gameObject.SetActive(false);
                counter = 0;
                Debug.Log("count" + counter);
            }


        }
        else if (talking == false)
        {
            SR.sortingLayerName = "Default";
        }


    }
}
