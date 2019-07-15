using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class BTAScript : MonoBehaviour
{
    private GameObject player;
    private BTAPlayerController playerController;
    public string[] array;
    bool talking;
    private int counter;
    public Text textbox;
    public bool sTalking;
    public bool nTalking;
    public bool tTalking;
    bool trans;
    int timer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<BTAPlayerController>();
        counter = 0;
        sTalking = false;
        nTalking = false;
        tTalking = false;
        trans = false;
        timer = 0;

        array = new string[14];
        array[0] = "quack. (I need your help).";
        array[1] = "You need my help for what?";
        array[2] = "Take me to the beach.";
        array[3] = "*shrug* Okay. Beach it is!";
        array[4] = "Why are you talking at a duck?";
        array[5] = "I'm talking to him not at him, and we’re going on a mission. Nosey.";
        array[6] = "You’re crazy lol.";
        array[7] = "Quack!";
        array[8] = "Aw cute, don’t kidnap this poor duck";
        array[9] = "uhm... What he said about you wasn’t cute but okay";
        array[10] = "???";
        array[11] = "Quack!! (If he touches me again I’m smacking him)";
        array[12] = "okay bye Nick! Let's go Sunburn";
        array[13] = " ";

    }

    // Update is called once per frame
    void Update()
    {
        talking = playerController.talking;

        if (talking == true)
        {
            if (counter < 39 && Input.GetKeyDown(KeyCode.Return))
            {
                textbox.text = array[counter];
                counter++;
            }
            else if (counter >= 39)
            {
                talking = false;

                textbox.text = "";
            }
        }
        if (counter == 14)
        {
            timer++;
        }
        if (timer == 100)
        {
            SceneManager.LoadScene("BusScene", LoadSceneMode.Single);
        }
        if (counter == 1 || counter == 3 || counter == 8 || counter == 12)
        {
            print("Sunny B talking");
            sTalking = true;
            tTalking = false;
        }
        else if (counter == 2 || counter == 4 || counter == 6 || counter == 10 || counter == 13)
        {
            print("Tam Tam talking");
            sTalking = false;
            tTalking = true;
        }
        else if (counter == 5 || counter == 7 || counter == 9 || counter == 11)
        {
            print("Nickel boii talkin");
            sTalking = false;
            tTalking = false;
        }
        if (counter >= 14)
        {
            sTalking = false;
            tTalking = false;
            nTalking = false;
            talking = false;
        }
    }
}
