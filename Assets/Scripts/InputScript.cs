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
        if (Input.GetKeyDown("up"))
        {
            speed += 1;

            if (speed > 10)
            {
                speed = 10;
            }
            Debug.Log("Up Arrow Pressed and Speed is " + speed);
        }
        else if (Input.GetKeyDown("down"))
        {
            speed -= 1;

            if (speed < 0)
            {
                speed = 0;
            }

            Debug.Log("Down  Arrow Pressed and Speed is " + speed);
        }

        skele.GetComponent<Animator>().SetInteger("speed", speed);

    }
}
