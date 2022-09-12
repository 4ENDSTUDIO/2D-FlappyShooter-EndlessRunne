using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenTransition : MonoBehaviour
{
    public Animator transitionAnimator;
    public string sceneName;

    private void Start()
    {
       
    }

    public void Update()
    {
        if(Score.score == 1)
        {
            StartCoroutine(LoadScene());
        }
       if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(LoadScene());
        }
    }

  
    public IEnumerator LoadScene()
    {
        transitionAnimator.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
}
