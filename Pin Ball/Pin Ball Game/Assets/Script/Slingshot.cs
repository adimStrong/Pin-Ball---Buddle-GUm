using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    public GameObject particle;
    float timer = 0;
    float hit = 0;

    public Vector2 moveDirection;

    // Start is called before the first frame update
    private void Start()
    {

        moveDirection = this.transform.position;
        GetComponent<PointEffector2D>().enabled = false;
        particle.SetActive(false);
    }
    private void Update()
    {
        if(GetComponent<PointEffector2D>().enabled == true)
        {
            timer += Time.deltaTime;
            particle.SetActive(true);

        }
        if(timer > 300)
        {
            particle.SetActive(false);
            timer = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(hit > 0)
        {
            GetComponent<PointEffector2D>().enabled = true;
            hit = 0;
        }
        else
        {
            hit++;
        }

        if(other.tag == "Player")
        {

            other.transform.position = Vector2.MoveTowards(other.transform.position, moveDirection, 5 * Time.deltaTime);
          
        }
    }

    IEnumerator waitToDisableBumper()
    {
        yield return new WaitForSeconds(60f);
      
    }






}
