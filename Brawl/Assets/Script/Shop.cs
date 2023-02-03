using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    public string objectName;
    public int price;
    public int access;
    public GameObject block;
    public GameObject sold;
    public GameObject playerTwo;
    public TextMeshProUGUI objectPrice;
    public TextMeshProUGUI CoinCount;
    public TextMeshProUGUI CoinCountmenu;
    

    private void Awake()
    {
       
        AccessUpdate();
    }

    public void AccessUpdate()
    {
        access = PlayerPrefs.GetInt(objectName + "access");
        objectPrice.text = price.ToString();
        CoinCount.text = PlayerPrefs.GetInt("Coin").ToString();
        CoinCountmenu.text = PlayerPrefs.GetInt("Coin").ToString();

        if (access == 1)
        {
            block.SetActive(false);
            objectPrice.gameObject.SetActive(false);
            sold.SetActive(true);
            playerTwo.SetActive(true);
        }


    }

    public void OnButtonDown()
    {
        int coins = PlayerPrefs.GetInt("Coin");

        if (access == 0)
        {
            if (coins >= price)
            {
                PlayerPrefs.SetInt(objectName + "access", 1);
                PlayerPrefs.SetInt("Coin", coins - price);
                AccessUpdate();
            }
        }
    }
}
