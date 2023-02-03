using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthEnemyZombies : MonoBehaviour
{
    public int levelHeath;
    //private Slider mySlider;
    //private Image myImage;
    public int score = 0;
    //private Text text;
    
    public void Update()
    {
        //mySlider.value = levelHeath;

        
        if (levelHeath < 10)
        {
            //myImage.enabled = false;

        }
        else
        {
            //myImage.enabled = true;
        }
    }
}
