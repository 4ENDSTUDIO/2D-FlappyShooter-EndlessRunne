﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverCanvas;
    public static GameManager instance = null;
    
   
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
       
    }
    void Start()
    {
        gameoverCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
  public void destroyDDo()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Play")
        {
            Destroy(gameObject);
            Debug.Log("I am inside the if statement");
        }
    }

    public void GameOver()
    {
        gameoverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
