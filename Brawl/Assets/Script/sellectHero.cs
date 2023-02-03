using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sellectHero : MonoBehaviour
{

    public GameObject[] Heroes;

    private int _heroIndex;
   

   
    public void PlayeOne()
    {
        Heroes[0].SetActive(true);
        Heroes[1].SetActive(false);
        _heroIndex = 1;
        DataHolder.indexhero = _heroIndex;
    }

    public void PlayerTwo()
    {
        Heroes[1].SetActive(true);
        Heroes[0].SetActive(false);
        _heroIndex = 2;
        DataHolder.indexhero = _heroIndex;
    }
}
