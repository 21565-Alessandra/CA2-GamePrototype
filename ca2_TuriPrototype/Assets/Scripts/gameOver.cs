using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag=="Player")
        {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(2);
        }
    }

    // void Update();
        
}
    