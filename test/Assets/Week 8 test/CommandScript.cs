﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandScript : MonoBehaviour {


    public InputField commandInput;

    public string[] colors;
    public Color[] colors2;

    GameObject animal;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void Initialize(GameObject i)
    {
        animal = i;
        this.gameObject.GetComponent<GeneralCodeToggle>(); //SECOND INPUT MOET VERPLAATST WORDEN
    }

}
