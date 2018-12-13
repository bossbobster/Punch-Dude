using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreenButtons : MonoBehaviour
{
    public Button play;
    public Button quit;

    void Start()
    {
        //I don't actually need this (it's possible to set from inspector)
        //play = (Button)GameObject.Find("PlayButton").GetComponent("Button");
        //quit = (Button)GameObject.Find("QuitButton").GetComponent("Button");
        play.onClick.AddListener(playFunc);
        quit.onClick.AddListener(quitFunc);
    }

    void playFunc()
    {
        SceneManager.LoadScene("Game");
    }
    void quitFunc()
    {
        Application.Quit();
    }
}
