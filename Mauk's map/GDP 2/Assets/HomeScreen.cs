using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScreen  : MonoBehaviour {

    private void OnMouseDown()
    {
        SceneManager.LoadScene("Game");
    }



 //   void OnMouseUp()
 //   {
//        Debug.Log("hoi");
//               SceneManager.LoadScene("Game");
 //       // SceneManager.LoadScene.LoadSceneMode.Single("Game");
//        SceneManager.UnloadSceneAsync("New Scene");
 //   }
}
