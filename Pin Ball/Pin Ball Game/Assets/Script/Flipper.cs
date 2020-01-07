using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public bool Flip;

    // Update is called once per frame
    void Update()
    {
        if ((Flip && Input.GetKeyDown(KeyCode.RightShift)) || (!Flip && Input.GetKeyDown(KeyCode.LeftShift)))
        {
            GetComponent<HingeJoint2D>().useMotor = true;
        }

    }
}
