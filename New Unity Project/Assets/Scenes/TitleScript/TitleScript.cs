using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{

    public string newGameScene;
    public string newGameScene2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void newGame(){
        SceneManager.LoadScene(newGameScene);
    }
    public void miniGame(){
        SceneManager.LoadScene(newGameScene2);
    }
    public void quitGame() => Application.Quit();
}
