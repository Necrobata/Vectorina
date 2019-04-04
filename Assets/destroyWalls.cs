using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyWalls : MonoBehaviour
{
    private boss1Movement boss1Movement;
    public GameObject boxExplo;




    #region GameObjects
    public GameObject boxx1;
    public GameObject boxx2;
    public GameObject boxx3;
    public GameObject boxx4;
    public GameObject boxx5;
    public GameObject boxx6;
    public GameObject boxx7;
    public GameObject boxx8;
    public GameObject boxx9;
    public GameObject boxx10;
    public GameObject boxx11;
    public GameObject boxx12;
    #endregion



    void Awake()
    {
        boss1Movement = FindObjectOfType<boss1Movement>();
    }

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
        Instantiate(boxExplo, boxx1.transform.position, boxx1.transform.rotation);
        Destroy(boxx1);
        Instantiate(boxExplo, boxx10.transform.position, boxx10.transform.rotation);
        Destroy(boxx10);
        Instantiate(boxExplo, boxx2.transform.position, boxx2.transform.rotation);
        Destroy(boxx2);
        Instantiate(boxExplo, boxx3.transform.position, boxx3.transform.rotation);
        Destroy(boxx3);
        Instantiate(boxExplo, boxx4.transform.position, boxx4.transform.rotation);
        Destroy(boxx4);
        Instantiate(boxExplo, boxx5.transform.position, boxx5.transform.rotation);
        Destroy(boxx5);
        Instantiate(boxExplo, boxx6.transform.position, boxx6.transform.rotation);
        Destroy(boxx6);
        Instantiate(boxExplo, boxx7.transform.position, boxx7.transform.rotation);
        Destroy(boxx7);
        Instantiate(boxExplo, boxx8.transform.position, boxx8.transform.rotation);
        Destroy(boxx8);
        Instantiate(boxExplo, boxx9.transform.position, boxx9.transform.rotation);
        Destroy(boxx9);
        Instantiate(boxExplo, boxx11.transform.position, boxx11.transform.rotation);
        Destroy(boxx11);
        Instantiate(boxExplo, boxx12.transform.position, boxx12.transform.rotation);
        Destroy(boxx12);

        boss1Movement.triggered = true;
        
    }

}
