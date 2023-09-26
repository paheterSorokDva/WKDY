using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Answer : MonoBehaviour
{
  
    public bool isTruAnswer;
    public GameObject PanelBlock;
    public HardlLevelStart HardlLevelStart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void ClickAnswer()
    {
        
            if (isTruAnswer)
            {
                GetComponent<Animator>().SetTrigger("Green");
                PanelBlock.SetActive(true);
                

            }
            else
            {
                GetComponent<Animator>().SetTrigger("Red");
                HardlLevelStart.minusHearth();
                PanelBlock.SetActive(true);

            }
 
    }



    public void ClickAnswerBeginer()
    {

        if (isTruAnswer)
        {
            GetComponent<Animator>().SetTrigger("Green");
            PanelBlock.SetActive(true);
            PlayerPrefs.SetInt("Schet1", PlayerPrefs.GetInt("Schet1") + 1);


        }
        else
        {
            GetComponent<Animator>().SetTrigger("Red");
            PanelBlock.SetActive(true);

        }

    }

    public void ClickAnswerMedium()
    {

        if (isTruAnswer)
        {
            GetComponent<Animator>().SetTrigger("Green");
            PanelBlock.SetActive(true);
            PlayerPrefs.SetInt("Schet2", PlayerPrefs.GetInt("Schet2") + 1);


        }
        else
        {
            GetComponent<Animator>().SetTrigger("Red");
            PanelBlock.SetActive(true);

        }

    }
}
