using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Alert : MonoBehaviour
{
    [SerializeField] private GameObject alert;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void showAlert()
    {   
        if (alert.GetComponent<Animator>().enabled == false)
        {
            alert.GetComponent<Animator>().enabled = true;
        }
        else
        {
            alert.GetComponent<Animator>().SetTrigger("Show");
        }

    }

}
