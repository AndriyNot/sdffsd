using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Threading;

public class Enemy : MonoBehaviour
{
    
    private NavMeshAgent _myAgent;
    private Animator animator;
    private float distance;
    public Transform[] target;
    private int index = 0;
    [SerializeField] private HealthEnemyZombies _health;
    public scoreEnemy enemyScore;
    public GameObject gmbj;
    public Hero hero;
    private int indexhero;
    void Start()
    {
        _myAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        _health = GetComponent<HealthEnemyZombies>();
    }

    private void FixedUpdate()
    {
        
        if (_health.levelHeath <= 0)
        {
            animator.SetBool("death", true);
            Destroy(gameObject);
            enemyScore._scoreEnemy += 1;
           
        }
    }
    void Update()
    {
        index = hero.IndexPlayers;

        if (index == 1)
        {
            indexhero = 0;
        }
        if (index == 2)
        {
            indexhero = 1;
        }

        distance = Vector3.Distance (target[indexhero].position, transform.position);

        if (distance > 10)
        {
            _myAgent.enabled = false;
            animator.SetBool("run", false);
        }
        if (distance < 10 && distance > 1f)
        {
            _myAgent.enabled = true;
            _myAgent.SetDestination (target[indexhero].position);
            animator.SetBool("run", true);
            animator.SetBool("attack", false);
        }

        if (distance <= 1)
        {
           
            _myAgent.enabled = false;
            animator.SetBool("attack", true);
            
            
        }

        


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            _health.levelHeath -= 25;
        }
    }

}
