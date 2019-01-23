using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSize : MonoBehaviour {
	
public GameObject QuitScreen;
	// Use this for initialization
	void Start () {
         Screen.SetResolution(1920,1080,true); // Change 3rd parameter to true for full screen
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
        QuitScreen.SetActive(true);
    }
	}
}
