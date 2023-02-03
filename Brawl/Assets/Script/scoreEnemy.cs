using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreEnemy : MonoBehaviour
{
    
    public int _scoreEnemy;
    public Text scoreText;
    

    private void Update()
    {
        DataHolder.scoreEnemy = _scoreEnemy;
        scoreText.text = "" + _scoreEnemy;
       


        if (_scoreEnemy == 13)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
   

}


