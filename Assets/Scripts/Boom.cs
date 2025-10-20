
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag != "Player" & col.gameObject.tag != "Terrain" & col.gameObject.tag != "Path")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }

}
