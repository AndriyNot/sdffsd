using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageKnightDog : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.tag == ("Enemy"))
        {
            collision.GetComponent<HealthEnemyZombies>().levelHeath -= 50;
        }

    }
}
