using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTAPlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    BoxCollider2D bc2d;
    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;  // How much to smooth out the movement
    private Vector3 velocity = Vector3.zero;
    public bool talking;
    public bool touching;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        talking = false;
        touching = false;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 targetVelocity = new Vector2(moveHorizontal * 15f, moveVertical * 15f);
        rb2d.velocity = Vector3.SmoothDamp(rb2d.velocity, targetVelocity, ref velocity, m_MovementSmoothing);

        bool walkLeft = Input.GetKeyDown(KeyCode.LeftArrow);
        bool walkRight = Input.GetKeyDown(KeyCode.RightArrow);

        if ((transform.localScale.x < 0) && (walkRight == true))
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
        else if ((transform.localScale.x > 0) && (walkLeft == true))
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
            
        }
        if (touching == true && Input.GetKeyDown(KeyCode.Return)){
            talking = true;
        }

        if (talking == true)
        {
            //print("Talking = " + talking);
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            touching = true;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            touching = false;
            talking = false;
        }
    }

    public bool getTalking()
    {
        return talking;
    }
}
