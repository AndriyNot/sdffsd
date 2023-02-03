using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthPlayer : MonoBehaviour
{

    public int LevelHeath;
    public Slider MySlider;
    public Image MyImage;
    public Text TextLevelHealth;
   

    private void Start()
    {
        
    }
    public void Update()
    {
        DataHolder.healthg = LevelHeath;
        MySlider.value = LevelHeath;
        TextLevelHealth.text = "" + LevelHeath;
        if (LevelHeath < 10)
        {
            MyImage.enabled = false;

        }
        else
        {
            MyImage.enabled = true;
        }
        if (LevelHeath <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

   
}
