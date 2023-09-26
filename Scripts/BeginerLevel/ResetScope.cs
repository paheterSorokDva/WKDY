using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScope : MonoBehaviour
{
    [SerializeField] private string NameSchet;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt(NameSchet, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
