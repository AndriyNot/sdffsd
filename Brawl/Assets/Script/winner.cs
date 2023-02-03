using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class winner : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int _score;
    private int _scorepoints;
    public TextMeshProUGUI textpoints;
    private int _scorewiner;
    public TextMeshProUGUI title;
    public GameObject  Winer;
    public GameObject Lose;
    private int _scorewinner;
    private int _index;
    
    public GameObject[] heros;
   

    private void Awake()
    {
        _score = DataHolder.scoreEnemy;
        _scorewiner = DataHolder.healthg;
        _index = DataHolder.indexhero;
    }
    
   

    private void Update()
    {
        
        if (_score == 13 || _score == 12)
        {
           
            _scorepoints = 7;


        }
        else if (_score <= 11 && _score >= 8)
        {
            _scorepoints = 6;
        }
        else if (_score <= 7 && _score >= 4)
        {
            _scorepoints = 3;
        }
        else if (_score == 3 || _score == 2)
        {
            _scorepoints = 1;
        }
        else if (_score == 1 || _score == 0)
        {
            _scorepoints = -5;
            textpoints.text = "" + _scorepoints;
        }
       
        textpoints.text = "+" + _scorepoints;
        text.text = "" + _score;

        if (_scorewiner <= 0)
        {

            Lose.SetActive(true);
            Winer.SetActive(false);

           
        }
        else
        {
            Winer.SetActive(true);
            Lose.SetActive(false);

        }
        DataHolder.scorePoints = _scorepoints;

       

        if (_index == 1)
        {
            
            heros[0].SetActive(true);
            heros[1].SetActive(false);

        }
        if (_index == 2)
        {
            
            heros[1].SetActive(true);
            heros[0].SetActive(false);
        }

    }

}
