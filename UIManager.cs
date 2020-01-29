using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject main_menu;
    public GameObject choose_difficulty;
    public float time;
    public Button start;
    public Button exit;
    public Button easy, medium, hard;

    public float time_scaler;
    void Start()
    {
        start.onClick.AddListener(startPressed);
        exit.onClick.AddListener(exit_pressed);
        easy.onClick.AddListener(Choose_Dif);
        medium.onClick.AddListener(Choose_Dif);
        hard.onClick.AddListener(Choose_Dif);
        
    }


    void Choose_Dif()
    {
        if(this.gameObject.name == "easy")
            time = 2;
        else if(this.gameObject.name == "medium")
            time = 1;
        else
            time = 0.5f;


        //START SCENE
    }
    void startPressed()
    {
        choose_difficulty.SetActive(true);
    }

    void exit_pressed()
    {
        Application.Quit();
    }
}
