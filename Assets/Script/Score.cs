using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public ScreenTransition screen;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();

       if(score == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

        }
    }

    public  static void  upScore()
    {
        score +=1;
    }
    public IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Time.timeScale = 1;
    }

   
}
