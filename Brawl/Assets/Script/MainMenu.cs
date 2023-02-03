using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class MainMenu : MonoBehaviour
{
    private int _mapselectionindex;
    private int _modeselectionindex;
    private int _indexselectionScenes;
    private bool _ferst = false;
    public TMP_InputField InName;
    public TextMeshProUGUI textname;
    public TextMeshProUGUI textnameStatistics;
    private string _names;
    public GameObject[] Sceness;
    public TextMeshProUGUI textmode;
    public GameObject[] gameobject;
    void Update()
    {

        textname.text = "" + _names;
        textnameStatistics.text = "" + _names;

        if (_modeselectionindex == 0)
        {
            textmode.text = "Виберіть режим";
        }
        if (_modeselectionindex == 1)
        {
            textmode.text = "Режим:Zombies";
        }
        if (_modeselectionindex == 2)
        {
            textmode.text = "Режим:Test";
        }

    }

    private void Awake()
    {
        
        _names = PlayerPrefs.GetString("Name");
        _mapselectionindex = PlayerPrefs.GetInt("Index");
        _indexselectionScenes = PlayerPrefs.GetInt("Inscene");
        _modeselectionindex = PlayerPrefs.GetInt("Indexmode");
        if (_indexselectionScenes == 1)
        {
            Sceness[0].SetActive(false);
            Sceness[1].SetActive(true);
        }
        if (_indexselectionScenes == 0)
        {
            Sceness[1].SetActive(false);
            Sceness[0].SetActive(true);
        }


    }

    public void Next()
    {
        _indexselectionScenes = 1;
        _names = InName.text;
        if (_names != "")
        {
            gameobject[0].SetActive(true);
            gameobject[1].SetActive(false);
        }
        PlayerPrefs.SetString("Name", _names);
        PlayerPrefs.SetInt("Inscene", _indexselectionScenes);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + _mapselectionindex);
    }

    public void selectMap()
    {
        _mapselectionindex = 1;
        _modeselectionindex = 1;
        PlayerPrefs.SetInt("Index", _mapselectionindex);
        PlayerPrefs.SetInt("Indexmode", _modeselectionindex);
    }

    public void selectMapTest()
    {
        _mapselectionindex = 3;
        _modeselectionindex = 2;
        PlayerPrefs.SetInt("Index", _mapselectionindex);
        PlayerPrefs.SetInt("Indexmode", _modeselectionindex);
    }

    public void OnnClik()
    {
        if (_ferst == false)
        {
            OnClick();
            _ferst = true;
        }
        if (_ferst == true)
        {
            OffClick();
            _ferst = false;
        }
    }

    public void ExitResultat()
    {
        SceneManager.LoadScene("Menu");

    }

    public void OnClick()
    {

        gameObject.SetActive(true);

    }

    public void OffClick()
    {

        gameObject.SetActive(false);

    }

    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}  
