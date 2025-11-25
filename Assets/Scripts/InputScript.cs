using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{

    public GameObject skele;
    private int speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown("up"))
        //{
            speed += 1;

            if (speed > 5)
            {
                speed = 5;
            }
        //}
        //else if (Input.GetKeyDown("down"))
        //{
        //    speed -= 1;

        //    if (speed < 0)
        //    {
        //        speed = 0;
        //    }

        //    Debug.Log("Down  Arrow Pressed and Speed is " + speed);
        //}

        skele.GetComponent<Animator>().SetInteger("speed", speed);

    }
}
