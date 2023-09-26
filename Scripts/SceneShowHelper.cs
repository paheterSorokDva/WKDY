
using System.Collections;
using System.Collections.Generic;
using TMPro;
//using Unity.Random;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneShowHelper : MonoBehaviour
{
    public GameObject TextObject;
    public GameObject ImageObject;
    public string text;
    public string StartGameScene;

    public Sprite[] DogsImage;          
    public string[] DogsName;           // Должны соответсвовать друг другу
    public int randomInt;
    


    // Start is called before the first frame update
    void Start()
    {
        randomInt = Random.Range(0, DogsImage.Length - 1);
        
       // ImageObject.GetComponent<Image>().sprite = DogsImage[randomInt];
    }

    // Update is called once per frame
    void Update()
    {
        TextObject.GetComponent<TextMeshProUGUI>().text = text +  " " + DogsName[randomInt];
        ImageObject.GetComponent<Image>().sprite = DogsImage[randomInt];
    }


    public void StartGameAgain()
    {
        SceneManager.LoadScene(StartGameScene);
    }


    public void TestRand()
    {
        randomInt = Random.Range(0, DogsImage.Length - 1);
    }
}
