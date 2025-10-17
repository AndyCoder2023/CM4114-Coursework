using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public AttributesManager playerAtm;
    public AttributesManager enemyAtm;

    public void Update()
    {
        // Damage is dealt to enemy once key is pressed
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerAtm.DealDamage(enemyAtm.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            enemyAtm.DealDamage(playerAtm.gameObject);
        }
        if (enemyAtm.health <= 0 )
        {
            Destroy(enemyAtm.gameObject);
        }
    }
}
