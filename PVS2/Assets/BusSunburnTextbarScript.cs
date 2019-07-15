using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusSunburnTextbarScript : MonoBehaviour
{
    RectTransform rectTrans;
    float y;
    private Vector2 hide;
    GameObject BusConvo;
    BusConvoScript busConvoScript;
    bool sTalking;
    bool talking;
    // Start is called before the first frame update
    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        y = rectTrans.position.y;
        hide = new Vector2(0, 1000);
        BusConvo = GameObject.FindWithTag("GameController");
        busConvoScript = BusConvo.GetComponent<BusConvoScript>();
        sTalking = busConvoScript.sTalking;
        talking = busConvoScript.talking;
    }

    // Update is called once per frame
    void Update()
    {
        talking = busConvoScript.getTalking();
        if (talking == true && busConvoScript.sTalking == true)
        {

        }
        if (busConvoScript.sTalking == false)
        {

        }
    }
}
