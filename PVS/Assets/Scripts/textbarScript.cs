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
    public bool hiding;
    bool equipped = false;
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
        textarray = new string[6];
        textarray[0] = "hey";
        textarray[1] = "use the arrow keys to move";
        textarray[2] = "talk to people";
        textarray[3] = "if you find a key bring it back to me";
        textarray[4] = "then you're free to do whatever, leave lol";
        textarray[5] = " ";
        counter = 0;
        hiding = true;
    }

    // Update is called once per frame
    void Update()
    {
        talking = playerController.gettalking();
        equipped = playerController.getEquipped();

        if (talking == true)
        {
            SR.sortingLayerName = "Textbars";
            hiding = false;
            transform.position = new Vector2(tform.position.x, tform.position.y - 3.8f);
            if (counter < 6 && Input.GetKeyDown(KeyCode.Return))
            {
                textbox.text = textarray[counter];
                counter++;
            }
            else if (counter >= 6)
            {
                playerController.setTalking(false);
                talking = false;
               // gameObject.SetActive(false);
              //  textbox.gameObject.SetActive(false);
                counter = 0;
                Debug.Log("count" + counter);
                SR.sortingLayerName ="Default";
                hiding = true;
            }
        }
            
            else if (talking == false)
        {
            SR.sortingLayerName = "Default";
            hiding = true;
        }

        if (talking == true && equipped == true)
        {
            Debug.Log("Start different text");
            textarray = new string[5];
            textarray[0] = "Thanks! That'll come in handy. You're free to leave";
            textarray[1] = "Oh, where it is?";
            textarray[2] = "Go left and down past the booths and the girl who lost her brother.";
            textarray[3] = "Don't worry she'll be fine. They come here every Wednesday.";
            textarray[4] = "";
                if (counter >= 5)
            {
                playerController.setTalking(false);
                talking = false;
                counter = 0;
                Debug.Log("count" + counter);
                SR.sortingLayerName = "Default";
                hiding = true;
            }
        }



    }

    public bool ishiding()
    {
        return hiding;

    }

}

