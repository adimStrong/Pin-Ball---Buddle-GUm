using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalllScript : MonoBehaviour
{
    public Rigidbody2D rb;

    public float ballForce;



    int counter;

    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        counter = 0;

    }

    private void Update()
    {
        if(counter != 1 )
        {
            if (Input.GetKeyDown(KeyCode.Space)) {
                rb.AddForce(new Vector2(700, 700));
              
                counter = 1;
                Debug.Log(counter);
            }
        }
    }





}

