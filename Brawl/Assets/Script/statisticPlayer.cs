using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class statisticPlayer : MonoBehaviour
{
    private int _maxpont;
    public int scorepoint;
    public TextMeshProUGUI textscorewinner;
    public int _score;
   

    private void Awake()
    {
        scorepoint = DataHolder.scorePoints;
        
    }
   
}
