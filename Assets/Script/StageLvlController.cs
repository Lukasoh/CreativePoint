using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageLvlController : MonoBehaviour
{
    LevelSelection levelSelection;
    int currentScene;
    
    void Start()
    {
        levelSelection = FindObjectOfType<LevelSelection>();
        currentScene = SceneManager.GetActiveScene().buildIndex;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CorrectAnswer()
    {
        levelSelection.LevelManager(currentScene);
    }
}
