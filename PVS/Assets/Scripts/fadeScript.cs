using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeScript : MonoBehaviour
{
    Animator anim;
    private GameObject player;
    private playerController playerController;
    bool talking;
    bool equipped;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<playerController>();
        talking = playerController.talking;
        equipped = playerController.equipped;
      
    }

    // Update is called once per frame
    void Update()
    {
        talking = playerController.gettalking();
        equipped = playerController.getEquipped();

     

    }
}
