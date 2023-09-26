using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSetting : MonoBehaviour
{
    [SerializeField] private int FinishViktorineBeginer;
    [SerializeField] private int FinishViktorineMed;
    [SerializeField] private int FinishViktorineHard;

    // Start is called before the first frame update
    void Start()
    {
        FinishViktorineBeginer = PlayerPrefs.GetInt("1");
        FinishViktorineMed = PlayerPrefs.GetInt("2");
        FinishViktorineHard = PlayerPrefs.GetInt("3");

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    

    public void NextScene(string SceneNext)
    {
        SceneManager.LoadScene(SceneNext);
        
    }


    

}
