using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHelper : MonoBehaviour
{
    /// <summary>
    ///  icon <a href="https://www.freepik.com/free-vector/cute-corgi-dog-eating-bone-cartoon_11919374.htm#query=dog%20cartoon&position=4&from_view=keyword&track=ais">Image by catalyststuff</a> on Freepik
    /// </summary>
    public GameObject poleVoprosText;


    // обращение к тексту кнопок
    public GameObject[] buttonText;
    public GameObject SchetText;

    public string StringpoleVoprosText;
    public string StringbuttonText1;
    public string StringbuttonText2;
    public string StringbuttonText3;
    public string StringbuttonText4;
    public string NameSchet;            /// проверка счетчика
    public int a; /// проверка счетчика
    public int MaxVopros;
    

    public string StringSchetText;
    [SerializeField] private int IntSchetText;

    public string NextScena;

    


    
    void Start()
    {
        StringSchetText = IntSchetText.ToString() + "/" + MaxVopros;
        
    }

    
    void Update()
    {
        poleVoprosText.GetComponent<TextMeshProUGUI>().text = StringpoleVoprosText;

        buttonText[0].GetComponent<TextMeshProUGUI>().text = StringbuttonText1;
        buttonText[1].GetComponent<TextMeshProUGUI>().text = StringbuttonText2;
        buttonText[2].GetComponent<TextMeshProUGUI>().text = StringbuttonText3;
        buttonText[3].GetComponent<TextMeshProUGUI>().text = StringbuttonText4;
        
        SchetText.GetComponent<TextMeshProUGUI>().text = StringSchetText;
        a = PlayerPrefs.GetInt(NameSchet); /// проверка счетчика
    }


    public void NextSceneMetod()
    {

        SceneManager.LoadScene(NextScena);

    }

    public void NextSceneMetod(string s)
    {

        SceneManager.LoadScene(s);

    }


  
}
