using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public bool equipped;
    // Start is called before the first frame update
    void Start()
    {
        equipped = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool checkEquipt()
    {
        return equipped;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
          


            gameObject.SetActive(false);
        }
    }

}