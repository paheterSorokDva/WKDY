using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SecretButton : MonoBehaviour
{
    [SerializeField] private int FinishViktorin;
    //[SerializeField] private int FinishViktorineHard;
    [SerializeField] private GameObject Button1;
    [SerializeField] private GameObject SeckretButton1;
    private string a;
    public int b;
    //public int a;
    // Start is called before the first frame update
    void Start()
    {
        a = FinishViktorin.ToString();
        b = PlayerPrefs.GetInt(a);
        SwipeSeckretButton(b, Button1, SeckretButton1);

        
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void SwipeSeckretButton(int i, GameObject Button, GameObject SeckretButton)
    {
        if (i == 0)
        {

            SeckretButton.SetActive(false);
            Button.SetActive(true);
        }
        else
        {
            Button.SetActive(false);
            SeckretButton.SetActive(true);

        }
    }

    
}
