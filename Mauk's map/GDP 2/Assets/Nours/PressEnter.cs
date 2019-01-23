using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressEnter : MonoBehaviour {

    public GameObject error;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("backspace"))
        {
            error.SetActive(false);
        }
	}

    void TurnOff()
    {
        
    }
}
