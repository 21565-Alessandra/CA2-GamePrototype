using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class winScreen : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag=="Player")
        {
            Debug.Log("Level Completed");
            SceneManager.LoadScene(3);
        }
    }

    // void Update();
        
}
    

