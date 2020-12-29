using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField]
    GameObject player;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, player.transform.position.z-11f);
    }
}
