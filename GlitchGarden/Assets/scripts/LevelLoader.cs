using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int CurrentSceneIndex;
    [SerializeField] int TimeToWait = 4;
    private void Start()
    {
        CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(CurrentSceneIndex == 0 )
        {
            StartCoroutine(WaitForSeconds());
        }
    }
    IEnumerator  WaitForSeconds()    
    {
        yield return new WaitForSeconds(TimeToWait);
        LoadNextScene();

    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(CurrentSceneIndex + 1);
    }
}
