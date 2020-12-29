using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    int levelsUnlocked;

    public List<Button> buttons;
 
    public void Start()
    {
        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked");
        for (int i = 0; i < buttons.Count; i++)
        {
            if (i<=levelsUnlocked)
            {
                buttons[i].interactable = true;
            }
            else
            {
                buttons[i].interactable = false;
            }
        }
        
    }
    
    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

   }
