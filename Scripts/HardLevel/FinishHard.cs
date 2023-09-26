using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishHard : MonoBehaviour
{
    [SerializeField] private GameObject DoskaText;
    [SerializeField] private string TextLow;
    [SerializeField] private string TextMed;
    [SerializeField] private string TextWiner;
    [SerializeField] private int idWiner;
    [SerializeField] private int Hp;
    [SerializeField] private string HpString;
    [SerializeField] private string SceneMenu;
    // Start is called before the first frame update
    void Start()
    {
        Hp = PlayerPrefs.GetInt(HpString);
        if(Hp == 3)
        {
            DoskaText.GetComponent<TextMeshProUGUI>().text = TextWiner;
            idWiner = 1;
        }
        else if(Hp == 2)
        {
            DoskaText.GetComponent<TextMeshProUGUI>().text = TextMed;
            idWiner = 2;
        }
        else
        {
            DoskaText.GetComponent<TextMeshProUGUI>().text = TextLow;
            idWiner = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ButtonSetExit()
    {
        if(idWiner == 1)
        {
            SceneManager.LoadScene(SceneMenu);
            PlayerPrefs.SetInt("3", 1);
        }
        else
        {
            SceneManager.LoadScene(SceneMenu);
        }
    }

    public void ButtonFreeExit()
    {
        SceneManager.LoadScene(SceneMenu);
    }

}
