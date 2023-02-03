using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.tag == ("Player"))
        {
            collision.GetComponent<HealthPlayer>().LevelHeath -= 45;
            
        }
        if (collision.name == ("PLAYERDogPolyart"))
        {
            collision.GetComponent<HealthPlayer>().LevelHeath -= 45;

        }

    }
}
