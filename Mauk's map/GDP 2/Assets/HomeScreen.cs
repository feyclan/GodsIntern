using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript1  {

    public void NewGameBtn(string newGameLevel) {
        SceneManager.LoadScene(newGameLevel);
    }
}
