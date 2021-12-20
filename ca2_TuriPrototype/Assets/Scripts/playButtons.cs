using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButtons : MonoBehaviour
{

    public string sceneName;

    public void ChangeScene(){
        SceneManager.LoadScene(sceneName);
    }

    public void OnQuitButton()
    {
        Application.Quit();
        Debug.Log("Quit button quits the game");
    }
  
}
