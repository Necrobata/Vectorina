using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introScript : MonoBehaviour
{
    public GameObject intro;
    public GameObject tuto1;
    public GameObject tuto2;
    public GameObject tuto3;
    public int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            counter++;

            if(counter == 1)
            {
                Destroy(intro);
            }
            else if (counter == 2)
            {
                Destroy(tuto1);
            }
            else if (counter == 3)
            {
                Destroy(tuto3);
                
            }
            else if (counter == 4)
            {
                SceneManager.LoadScene("SampleScene");
            }


        }
    }


}
