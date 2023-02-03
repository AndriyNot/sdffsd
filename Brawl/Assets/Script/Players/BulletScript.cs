using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    [SerializeField] PlayerAttacking Pa;

    Vector3 BullrEndDist;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        Pa = GameObject.Find("AttackTrail").GetComponent<PlayerAttacking>();
        BullrEndDist = transform.position + transform.forward * Pa.TrailDistance;   
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == BullrEndDist)
        {
            Destroy(this.gameObject);

        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);

        }
        else
        {
            Destroy(this.gameObject);


        }
        
    }
}
