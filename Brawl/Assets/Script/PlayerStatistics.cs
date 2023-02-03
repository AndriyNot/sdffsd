using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerStatistics : MonoBehaviour
{

    private int _scorecoins;
    private int _coins;
    private int _point;
    private int _numberFights;
   
    public TextMeshProUGUI textcoins;
    public TextMeshProUGUI textpoints;
    public TextMeshProUGUI textpointsmenu;
    public TextMeshProUGUI textfights;

    


    private void Awake()
    {
        StatisticsUpdate();
    }
    
    public void StatisticsUpdate()
    {
     
        _coins = PlayerPrefs.GetInt("Coin");
        _point = PlayerPrefs.GetInt("Poins");
        _numberFights = PlayerPrefs.GetInt("Fight");
        _scorecoins = DataHolder.scoreEnemy;

        if (_scorecoins == 13 || _scorecoins == 12)
        {
            _coins += 60;
            _point += 7;
        }
        if (_scorecoins <= 11 && _scorecoins >= 8)
        {
            _coins += 50;
            _point += 5;
        }
        if (_scorecoins <= 7 && _scorecoins >= 4)
        {
            _coins += 40;
            _point += 3;
        }
        if (_scorecoins == 3 || _scorecoins == 2)
        {
            _coins += 15;
            _point += 1;
        }
        if (_scorecoins == 1)
        {
            _coins += 3;
            _point -= 5;
        }

        textpoints.text = "" + _point;
        textpointsmenu.text = "" + _point;
        textfights.text = "" + _numberFights;
        PlayerPrefs.SetInt("Coin", _coins);
        PlayerPrefs.SetInt("Poins", _point);
    }

    public void OnClikfought()
    {
        _numberFights++;
        PlayerPrefs.SetInt("Fight", _numberFights);

    }
   
   
}
