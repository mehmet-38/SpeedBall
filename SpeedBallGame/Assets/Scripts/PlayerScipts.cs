using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScipts : MonoBehaviour
{
    public GameObject level2,level1;
    public GameObject rightPosition, leftPosition;
    [SerializeField]
    float speed;
    bool changePosition,startGame;
    Rigidbody rb;
    public int buildIndex;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        buildIndex = SceneManager.GetActiveScene().buildIndex;

    }
    private void Update()
    {
        Position();
    }
    void LateUpdate()
    {
        
        Startspeed();
    }
   
    void Startspeed()
    {

        rb.velocity = Vector3.forward * speed;
        
    }

    void Position()
    {
        if (changePosition == true && startGame == true)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(rightPosition.transform.position.x, transform.position.y, transform.position.z), 10f * Time.deltaTime); 
        }
        if (changePosition == false && startGame == true)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(leftPosition.transform.position.x, transform.position.y, transform.position.z), 10f * Time.deltaTime);
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startGame = true;
                    if (changePosition == false && startGame == true)
                    {
                        changePosition = true;
                    }
                    else if (changePosition == true && startGame == true)
                    {
                        changePosition = false;
                    }

                    break;

            }
            
        }
       
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wall")
        {

            this.gameObject.SetActive(false);
            SceneManager.LoadScene(5);

        }

       else if (other.gameObject.tag == "finish")
        {

            if (buildIndex == 4)
            {

                SceneManager.LoadScene(0);
            }
            else
            {
               
                SceneManager.LoadScene(buildIndex + 1);
                int currentLevel = SceneManager.GetActiveScene().buildIndex;
                if (currentLevel >= PlayerPrefs.GetInt("levelsUnlocked"))
                {
                    PlayerPrefs.SetInt("levelsUnlocked", currentLevel + 1);
                    
                }

            }

        }


    }
 
}
