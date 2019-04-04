using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikesNMonsters : MonoBehaviour
{
    public Vector3 OriginPosition;
    public GameObject Origin;
    private movementScript movementScript;
    private bool timer = false;
    public float count;
    public GameObject GameOver;



    void Awake()
    {
        movementScript = FindObjectOfType<movementScript>();

    }


    // Start is called before the first frame update
    void Start()
    {
        OriginPosition = Origin.transform.position;
        count = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer)
        {
            count += Time.deltaTime;
        }
        if(count > 3f)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "spikes")
        {
            
            gameObject.transform.position = OriginPosition;
        }

        if (col.gameObject.tag == "boss")
        {
            
            movementScript.paralyzed = true;
            timer = true;
            Instantiate(GameOver, gameObject.transform.position, gameObject.transform.rotation);

        }


    }

}
