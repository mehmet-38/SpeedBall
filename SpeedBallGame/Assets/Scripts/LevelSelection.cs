using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelSelection : MonoBehaviour
{
    public GameObject player;

    public void LevelSelect()
    {

        int level = int.Parse(EventSystem.current.currentSelectedGameObject.name);

        SceneManager.LoadScene(level);
    }
}

 
