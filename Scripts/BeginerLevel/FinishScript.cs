using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    [SerializeField] private string schetName;
    [SerializeField] private string FlagFinish;

    [SerializeField] private string HpFinish;
    [SerializeField] private int schet;
    [SerializeField] private GameObject DoskaText;
    [SerializeField] private string TextLow;
    [SerializeField] private string TextMed;
    [SerializeField] private string TextWiner;
    [SerializeField] private int idWiner;
    [SerializeField] private string SceneMenu;


    // Start is called before the first frame update
    void Start()
    {
        schet = PlayerPrefs.GetInt(schetName);
        
        if (schet <= 5)
        {
            DoskaText.GetComponent<TextMeshProUGUI>().text = TextLow;
            idWiner = 1;
        }
        else if (schet > 5 & schet < 10)
        {
            DoskaText.GetComponent<TextMeshProUGUI>().text = TextMed;
            idWiner = 2;
        }
        else if (schet >= 10)
        {
            DoskaText.GetComponent<TextMeshProUGUI>().text = TextWiner;
            idWiner = 3;
        }



    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonSet()
    {
        if (idWiner == 1)
        {
            SceneManager.LoadScene(SceneMenu);
        }
        else if (idWiner == 2)
        {
            SceneManager.LoadScene(SceneMenu);
        }
        else if (idWiner == 3)
        {
            PlayerPrefs.SetInt(FlagFinish, 1);
            SceneManager.LoadScene(SceneMenu);
        }


    }



    public void ButtonExit()
    {
        SceneManager.LoadScene(SceneMenu);
    }

}
