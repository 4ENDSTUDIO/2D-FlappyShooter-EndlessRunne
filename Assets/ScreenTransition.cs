using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenTransition : MonoBehaviour
{
    public Animator anim;
    public string loadSceneName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Score.score == 2)
        {
            StartCoroutine(LoadScene());
        }
    }
    IEnumerator LoadScene()
    {
        anim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(loadSceneName);
    }
}
