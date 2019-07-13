using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OutdoorScript : MonoBehaviour
{
    private GameObject player;
    private OutdoorPlayerController playerController;
    public string[] array;
    bool talking;
    private int counter;
    public Text textbox;
    public bool aTalking;
    public bool uTalking;
    public bool anTalking;
    public bool sTalking;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<OutdoorPlayerController>();
        counter = 0;

        array = new string[39];
        array[0] = "Sunburn right?";
        array[1] = "...";
        array[2] = "Who are you?";
        array[3] = "Allow us to introduce ourselves.";
        array[4] = "Reps for the Street Chickens? Why are you here?";
        array[5] = "I’m scruffie and this is my brother Scrapie.";
        array[6] = "Sup.";
        array[7] = "Okay but why are you here?";
        array[8] = "We’ve come against his wishes. There’s a slaughter about to take place.";
        array[9] = "a slaughter?";
        array[10] = "We were hangin' out at the spot, and all of a sudden some SEAGULLS roll up!";
        array[11] = "And then we noticed that it wasn’t just any seagull it was the leader HIMSELF!!";
        array[12] = "and then-";
        array[13] = "AND THEN HE HAD THE AUDACITY!-";
        array[14] = "I was telling the story.";
        array[15] = "You weren’t telling it right SO LIKE I WAS SAYING!-";
        array[16] = "DON’T INTERRUPT ME!";
        array[17] = "...";
        array[18] = "So are you going to tell me or…?";
        array[19] = "The Beach Chicken Leader disrespected him in front of everyone to see and challenges him to a fight.";
        array[20] = "I was JUST about to get to that.";
        array[21] = "Whatever, shut up.";
        array[22] = "So you want me to help?";
        array[23] = "OBVIOUSLY!";
        array[24] = "Don’t be rude. We need him to help, remember?";
        array[25] = "Do you know WHY he wants to fight?";
        array[26] = "No clue, but I want to find some type of negotiation. If they win, they threatened to take a lot from us.";
        array[27] = "And you’re scared because...?";
        array[28] = "Between us, our leader hasn’t been doing the best. We don’t know if he’d be able to pull through.";
        array[29] = "What happened to him?";
        array[30] = "He broke his wing. Badly.";
        array[31] = "When?";
        array[32] = "Two days ago.";
        array[33] = "Dang.";
        array[34] = "Can you help us?";
        array[35] = "This is gonna take more than fowl y'know.";
        array[36] = "We got the money up front!";
        array[37] = "Alright then.";
        array[38] = " ";

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
                sTalking = false;
                textbox.text = "";
            }
        }
        if (counter == 2 || counter == 3 || counter == 5 || counter == 8 ||
         counter == 10 || counter == 18 || counter == 19 || counter == 23 ||
         counter == 26 || counter == 28 || counter == 30 || counter == 32 ||
          counter == 34 ||counter == 36 || counter == 38)
        {
            //Debug.Log("Sunburn Talking");
            sTalking = true;
            aTalking = false;
            uTalking = false;
            anTalking = false;
        }
        else if (counter == 0 || counter == 1 || counter == 4)
        {
            //Debug.Log("Anon Talking");
            sTalking = false;
            aTalking = false;
            uTalking = false;
            anTalking = true;
        }
        else if (counter == 6 || counter == 9 || counter == 13 || counter == 15 ||
         counter == 17 || counter == 20 || counter == 22 || counter == 24 || counter == 25 ||
             counter == 27 || counter == 31 || counter == 33 || counter == 35)
        {
            //Debug.Log("Sruffie Talking");
            sTalking = false;
            aTalking = false;
            uTalking = true;
            anTalking = false;
        }
        else if (counter == 7 || counter == 11 || counter == 12 || counter == 14 || counter == 16 ||
         counter == 21 || counter == 25 || counter == 29 || counter == 37)
        {
            //Debug.Log("Srapie Talking");
            sTalking = false;
            aTalking = true;
            uTalking = false;
            anTalking = false;
        }

    }

}
