using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vectorScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float pushVector, lesserPushVector;
    private Vector3 vectorDirection;
    public GameObject pushBox;



    



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pushVector = 800f;
        lesserPushVector = 500f;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "upBox")
        {
            rb.AddForce(Vector3.up*pushVector);                

        }
        if (col.gameObject.tag == "downBox")
        {
            rb.AddForce(Vector3.down * pushVector);

        }
        if (col.gameObject.tag == "rightBox")
        {
            rb.AddForce(Vector3.right * lesserPushVector);

        }
        if (col.gameObject.tag == "leftBox")
        {
            rb.AddForce(Vector3.left * lesserPushVector);

        }
    }
}
