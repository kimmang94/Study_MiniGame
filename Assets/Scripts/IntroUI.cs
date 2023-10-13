using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroUI : MonoBehaviour
{
    [SerializeField] private Button startBtn = null;
    [SerializeField] private Button quitBtn= null;

    private void Awake()
    {
        startBtn.onClick.AddListener(OnclickStart);
        quitBtn.onClick.AddListener(OnClickQuit);
    }


    private void OnclickStart()
    {
        SceneManager.LoadScene("LobbyScene");
    }

    private void OnClickQuit()
    {
        Application.Quit();
    }
}
