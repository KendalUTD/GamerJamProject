using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniScript : MonoBehaviour
{


    public string returnTitle;
    public string newGameScene1;
    public string newGameScene2;
    public string newGameScene3;
    public string newGameScene4;
    public string newGameScene5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void TitleScr(){
    SceneManager.LoadScene(returnTitle);
}
    public void Load1(){
        SceneManager.LoadScene(newGameScene1);
    }
    public void Load2(){
        SceneManager.LoadScene(newGameScene2);
    }
    public void Load3(){
        SceneManager.LoadScene(newGameScene3);
    }
    public void Load4(){
        SceneManager.LoadScene(newGameScene4);
    }
    public void Load5(){
        SceneManager.LoadScene(newGameScene5);
    }
}
