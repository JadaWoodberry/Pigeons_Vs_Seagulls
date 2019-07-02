using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCtrigger : MonoBehaviour
{
    public bool touching;
    // Start is called before the first frame update
    void Start()
    {
        touching = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (touching == true)
        {
            //Debug.Log("touching = " + touching);
        }
        else
        {
            //Debug.Log("false");
        }
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            touching = true;


        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            touching = false;
        }
    }

    public void setTouching(bool touch)
    {
        touching = touch;
    }
}
