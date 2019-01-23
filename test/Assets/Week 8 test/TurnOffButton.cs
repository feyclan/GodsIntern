using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffButton : MonoBehaviour {


    //public GameObject button;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Debug.Log("sgkhjsn")
;    }

    void Tester()
    {
        this.gameObject.SetActive(false);
        Debug.Log("WEKRT DIT");
    }
}
