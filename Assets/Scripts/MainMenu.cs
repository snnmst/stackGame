﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Text scoreText;

    private void Start()
    {
        scoreText.text = PlayerPrefs.GetInt("score").ToString();  
    }

    public void ToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void doquit()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
