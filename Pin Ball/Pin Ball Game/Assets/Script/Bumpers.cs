using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpers : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {

        collision.rigidbody.AddForce(-collision.contacts[0].normal, ForceMode2D.Impulse);
    }



}
