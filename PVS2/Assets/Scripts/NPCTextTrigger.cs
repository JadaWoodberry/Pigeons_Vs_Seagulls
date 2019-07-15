using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTextTrigger : MonoBehaviour
{
    private SpriteRenderer SR;
   
    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        SR.sortingLayerName = "Default";
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SR.sortingLayerName = "foreground";
        }
    }
      void OnTriggerExit2D(Collider2D other)
     {
            if (other.gameObject.CompareTag("Player"))
            {
                SR.sortingLayerName = "Default";
            }
        }
       

      }
