using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BusConvoScript : MonoBehaviour
{
    public string[] array;
    private int counter;
    public Text textbox;
    public bool talking;
    public bool sTalking;
    public bool nTalking;
    public bool tTalking;
    GameObject TamiyoTextBar;
    RectTransform tamiRectTrans;
    GameObject SunburnTextBar;
    RectTransform sunnybRectTrans;


    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        talking = false;
        tTalking = false;
        sTalking = false;
        nTalking = false;
        TamiyoTextBar = GameObject.FindWithTag("tamiyoTextBar");
        tamiRectTrans = TamiyoTextBar.GetComponent<RectTransform>();
        SunburnTextBar = GameObject.FindWithTag("NPC");
        sunnybRectTrans = SunburnTextBar.GetComponent<RectTransform>();

        array = new string[17];
        array[0] = "What do you need to go to the beach for?";
        array[1] = "I need to chat with some seagulls.";
        array[2] = "Official business huh?";
        array[3] = "Yeah, it’s confidential right now.";
        array[4] = "Thats cool I guess. Got any seagull friends?";
        array[5] = "Nah, I don’t associate with them.";
        array[6] = "What why not?";
        array[7] = "They’ve gone seriously downhill.";
        array[8] = "How so?";
        array[9] = "They’re dirty and smelly and act crazy.";
        array[10] = "I don’t understand why when they have a whole ocean right there.";
        array[11] = "I’m sure they’re not that bad.";
        array[12] = "Even PIGEONS look down on them, they used to be in their shoes.";
        array[13] = "Well maybe the just need some guidance, or like a friends or something.";
        array[14] = "It always works in the movies! lol.";
        array[15] = "funny.";
        array[16] = " ";

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) == true)
        {
            talking = true;
        }

        if (talking == true)
        {
            if (counter < 17 && Input.GetKeyDown(KeyCode.Return))
            {
                textbox.text = array[counter];
                counter++;
            }
            else if (counter >= 17)
            {
                talking = false;
                SceneManager.LoadScene("BeachScene", LoadSceneMode.Single);

            }
        }
        if (counter == 1 || counter == 3 || counter == 5 || counter == 7 ||
         counter == 9 || counter == 12 || counter == 14 || counter == 15)
        {
            print("Tami talking");
            tTalking = true;
            sTalking = false;
            tamiRectTrans.localPosition = new Vector3(-53,-304,0);
            sunnybRectTrans.localPosition = new Vector3(-53, -604, 0);
        }
        else if (counter == 2 || counter == 4 || counter == 6 || counter == 8 || counter == 10 ||
        counter == 11 || counter == 13 || counter == 16)
        {
            print("SunyB talkinn");
            tTalking = false;
            sTalking = true;
            tamiRectTrans.localPosition = new Vector3(-53, -604, 0);
            sunnybRectTrans.localPosition = new Vector3(-53, -304, 0);

        }
    }
    public bool getTalking()
    {
        return talking;
    }
}
