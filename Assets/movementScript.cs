using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    public float movementSpeed;
    public float jumpForce=200f;    
    private Rigidbody2D rb;
    public bool paralyzed = false;
    


    // Start is called before the first frame update
    void Start()
    {    
        rb = GetComponent<Rigidbody2D>();
        movementSpeed = 25f;
    }

    void FixedUpdate()
    {
               
        if (Input.GetKey(KeyCode.A) && rb.velocity.x>-5f && (paralyzed == false))
        {
            rb.AddForce(Vector3.left*movementSpeed);
        }
            
        if (Input.GetKey(KeyCode.D) && rb.velocity.x < 5f && (paralyzed == false))
        {
            rb.AddForce(Vector3.right*movementSpeed);
        }    
        

    }




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && (paralyzed == false))
        {
            rb.AddForce(transform.up * jumpForce);
        }

        
    }


    

    

    
}
