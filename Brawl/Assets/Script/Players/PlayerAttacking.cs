using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour
{
    [SerializeField]private LineRenderer LR;

    [SerializeField]private Joystick AttackJoystick;

    [SerializeField]private Transform AttackLookAtPoint;

    [SerializeField] public float TrailDistance;

    [SerializeField] private Transform Player;

    private RaycastHit hit;

    private bool Shoot;

    [SerializeField] Transform Bullet;

   

    [SerializeField] Transform PlayerSpine;

    

    [SerializeField] private Transform PlayerSprite;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Mathf.Abs(AttackJoystick.Horizontal) > 0.3f || Mathf.Abs(AttackJoystick.Vertical) > 0.3f)
        {
            PlayerSprite.position = new Vector3(AttackJoystick.Horizontal + transform.position.x, 0, AttackJoystick.Vertical + transform.position.z);

            transform.LookAt(new Vector3(PlayerSprite.position.x, 0, PlayerSprite.position.z));
           
            transform.position = new Vector3(Player.position.x, 0, Player.position.z);

            AttackLookAtPoint.position = new Vector3(AttackJoystick.Horizontal + Player.position.x, 0, AttackJoystick.Vertical + Player.position.z);

            transform.LookAt(new Vector3(AttackLookAtPoint.position.x, 0, AttackLookAtPoint.position.z));

            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

            if (Shoot == false)
            {
                Shoot = true;
            }
        }
        else if (Shoot && Input.GetMouseButtonUp(0))
        {
            Debug.Log("Shoot");

            Instantiate(Bullet, transform.position,transform.rotation);

            Shoot = false;
        }
        else if (Shoot && Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)
            {
                Debug.Log("Shoot");
                Shoot = false;
            }
        }
        else if(Mathf.Abs(AttackJoystick.Horizontal) < 0.3f || Mathf.Abs(AttackJoystick.Vertical) < 0.3f/* && LR.gameObject.activeInHierarchy == true*/)
        {
            //LR.gameObject.SetActive(false);
            Shoot = false;

        }
    }

    
   
}
