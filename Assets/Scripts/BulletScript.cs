using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public int power;
    public GameObject ball;


    void Start()
    {
        power = 500;
    }

    void Update()
    {
        GameObject sp;
        Rigidbody body;
        Camera cam;

        cam = Camera.main;

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            power += 100;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            power -= 100;
        }

        if (Input.GetMouseButtonDown(0))
        {
            sp = Instantiate(ball, cam.transform.position, Quaternion.identity);

            body = sp.AddComponent(typeof(Rigidbody)) as Rigidbody;

            body.AddRelativeForce(cam.transform.forward.normalized * power);
        }
    }
}

