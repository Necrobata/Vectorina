using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverScript : MonoBehaviour
{
    public Animator animator;
    public GameObject box1;
    public GameObject box2;
    public GameObject vectorToFlip;
    public GameObject vectorToInstantiate;
    public GameObject boxExplo;
    public GameObject smallExplo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {          
            
            animator.SetBool("pulled", true);
        }

        Instantiate(boxExplo, box1.transform.position, box1.transform.rotation);
        Instantiate(boxExplo, box2.transform.position, box2.transform.rotation);
        Destroy(box1);
        Destroy(box2);


        Instantiate(vectorToInstantiate, vectorToFlip.transform.position,vectorToFlip.transform.rotation);
        Instantiate(smallExplo, vectorToFlip.transform.position, vectorToFlip.transform.rotation);
        Destroy(vectorToFlip);



    }
}
