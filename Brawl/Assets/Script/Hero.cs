using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public GameObject PlayrOne;
    public GameObject PlayrTwo;
    public int IndexPlayers;
    private void Awake()
    {
        IndexPlayers = DataHolder.indexhero;
    }


    void Update()
    {
        if (IndexPlayers == 1)
        {
            PlayrOne.SetActive(true);
            PlayrTwo.SetActive(false);
        }
        if (IndexPlayers == 2)
        {
            PlayrTwo.SetActive(true);
            PlayrOne.SetActive(false);
        }
    }
}
