﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PlayGame(int NextScene)
    {
        SceneManager.LoadScene(NextScene);
    }
}
