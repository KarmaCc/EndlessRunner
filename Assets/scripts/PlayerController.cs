using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public GameObject groundChecker;
    public LayerMask whatIsGround;
    Animator anim;

    float maxSpeed = 7.0f;
    bool isOnGround = false;
    //Create a reference to the Rigidbody2D so we can manipulate it
    Rigidbody2D playerObject;

    // Start is called before the first frame update
    void Start()
    {
        //Find the Rigidbody2D component that is attached to the same object as this script 
        playerObject = GetComponent<Rigidbody2D>();

        {
            anim = GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Create a 'float' that will be equal to the players horizontal input
        //float movementValueX = Input.GetAxis("Horizontal");
        float movementValueX = 1.0f;
        {
            anim.SetFloat("Speed", Mathf.Abs(movementValueX));
            anim.SetBool("IsOnGround", isOnGround);
        }
        //Change the X velocity of the Rigidbody2D to be equal to the movement value 
        playerObject.velocity = new Vector2(movementValueX * maxSpeed, playerObject.velocity.y);

        //check to see if the ground object is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 0.001f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true) 
        {
            playerObject.AddForce(new Vector2(0.0f, 300.0f));
        }
    }
}