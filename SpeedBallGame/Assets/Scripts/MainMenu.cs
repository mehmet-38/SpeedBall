using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    int currentLevel;
    private void Start()
    {
      currentLevel= PlayerPrefs.GetInt("levelsUnlocked");
    }
    public void PlayGame()
    {
        
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+currentLevel);
    }
    public void QuitGame()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
    public void LevelManu()
    {
        SceneManager.LoadScene(5);
            
    }
}
