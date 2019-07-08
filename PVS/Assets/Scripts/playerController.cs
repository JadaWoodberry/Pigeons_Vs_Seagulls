using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    private int position;
    public bool talking;
    public bool touching;
    GameObject tamiyo;
    BoxCollider2D bc2d;
    public bool equipped;

    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;  // How much to smooth out the movement
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        talking = false;
        touching = false;
        rb2d.bodyType = RigidbodyType2D.Dynamic;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(touching);

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 targetVelocity = new Vector2(moveHorizontal * 3f, moveVertical * 3f);
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

        if (touching == true && Input.GetKeyDown(KeyCode.Return))
        {
            talking = true;
        }

        if (talking == true)
        {
            rb2d.bodyType = RigidbodyType2D.Static;
        }
        else if (talking == false)
        {
            rb2d.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
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
            tamiyo = GameObject.FindGameObjectWithTag("NPC");
            bc2d = tamiyo.GetComponent<BoxCollider2D>();
           // bc2d.enabled = false;
        }
        if (other.gameObject.CompareTag("pick-up"))
        {
            equipped = true;
            Debug.Log(equipped);
        }

    }

    public bool gettalking()
    {
        return talking;
    }

    public void setTalking(bool talk)
    {
        this.talking = talk;
        //Debug.Log("Setting Talking to false");
    }
    public bool getEquipped()
    {
        return equipped;
    }
}