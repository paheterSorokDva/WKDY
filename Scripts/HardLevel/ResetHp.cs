using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetHp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Hp", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
