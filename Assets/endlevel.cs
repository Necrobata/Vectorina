using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlevel : MonoBehaviour
{

    private movementScript movementScript;
    private bool timer = false;
    public float count;
    public GameObject Kudos;



    void Awake()
    {
        movementScript = FindObjectOfType<movementScript>();
    }

    // Start is called before the first frame update
    void Start()
    {
        count = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer)
        {
            count += Time.deltaTime;
        }
        if (count > 5f)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            movementScript.paralyzed = true;
            timer = true;
            Instantiate(Kudos, gameObject.transform.position, gameObject.transform.rotation);
        }
    }




    }
