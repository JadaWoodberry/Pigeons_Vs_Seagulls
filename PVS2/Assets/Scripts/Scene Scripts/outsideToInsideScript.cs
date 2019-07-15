using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class outsideToInsideScript : MonoBehaviour
{
    int counter;
    private GameObject SNS;
    private OutdoorScript odis;
    bool start;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        SNS = GameObject.FindGameObjectWithTag("NPC");
        odis = SNS.GetComponent<OutdoorScript>();
        start = false;

    }

    // Update is called once per frame
    void Update()
    {
        start = odis.getTrans();

        if (start == true)
        {
            counter++;
        }

        if (counter == 100)
        {
            SceneManager.LoadScene("BTArcade", LoadSceneMode.Single);
        }
    }
}
