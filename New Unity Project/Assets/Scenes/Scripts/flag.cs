using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class flag : MonoBehaviour
{
    public TextMeshProUGUI EndGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            Debug.Log("YATA!!!");
            EndGame.enabled = true;
            Application.Quit();
            //Exit game
        }
    }
}
