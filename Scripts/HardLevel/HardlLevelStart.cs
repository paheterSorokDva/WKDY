using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HardlLevelStart : MonoBehaviour
{
    [SerializeField] private GameObject[] HearthImages;
    //[SerializeField] private int Lives;
    [SerializeField] private int LivesChet;
    [SerializeField] private string Scene0;
    [SerializeField] private GameObject PanelBlock0hp;
    // Start is called before the first frame update
    void Start()
    {
        LivesChet = PlayerPrefs.GetInt("Hp");

        if (LivesChet == 0)
        {
            PanelBlock0hp.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        LivesChet = PlayerPrefs.GetInt("Hp");
        /*if(LivesChet == 0)
        {
            PlayerPrefs.SetInt("Hp", HearthImages.Length);
            SceneManager.LoadScene(Scene0);

        }*/


        if (LivesChet < 3)
        {
            for (int i = 3; i > LivesChet; i--)
            {
                HearthImages[i-1].GetComponent<Image>().color = Color.black;
            }
        }

    }



    public void minusHearth()
    {
        if(LivesChet == 0)
        {

        }
        else
        {
            HearthImages[LivesChet - 1].GetComponent<Image>().color = Color.black;
            LivesChet--;
            PlayerPrefs.SetInt("Hp", LivesChet);
        }
        
    }

    public void plusHearth()
    {

        if (LivesChet == HearthImages.Length)
        {

        }
        else
        {
            HearthImages[LivesChet].GetComponent<Image>().color = Color.white;
            LivesChet++;
        }
        
    }


    
}
