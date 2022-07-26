﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverCanvas;
    void Start()
    {
        gameoverCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        gameoverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}