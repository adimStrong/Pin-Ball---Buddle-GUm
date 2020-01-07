using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    // constant gravity
    const float G = 0.6674f;
    public Rigidbody2D rb;

    public static List<Attractor> Attractors;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
       
        foreach (Attractor attractor in Attractors)
        {
            if(attractor != this)
            Attract(attractor);
        }
    }


    private void OnEnable()
    {
        if (Attractors == null)
            Attractors = new List<Attractor>();
        Attractors.Add(this);
    }
    private void OnDisable()
    {

        Attractors.Remove(this);
    }
    void Attract(Attractor objToAttract)
    {
        Rigidbody2D rbToAttract = objToAttract.rb;
        

        Vector2 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;

        if (distance == 0)
            return;
        float forceMagnitude = G* (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector2 force = direction.normalized * forceMagnitude;

        // to apply the pull force  
        rbToAttract.AddForce(force);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Attractor") {
            Debug.Log("Attract on");
          }
        
    }
}
