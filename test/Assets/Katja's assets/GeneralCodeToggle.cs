﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralCodeToggle : MonoBehaviour {

public InputField SelectedInputField;
public string[] CorrectCode;
public GameObject RelevantInputField;
	void Start(){
	SelectedInputField.onEndEdit.AddListener(delegate {
		ReadCode(); 
		});
}
	
	void ReadCode(){
		string TypedCode = SelectedInputField.text;
        bool validCode = false;
		for (int i = 0; i < CorrectCode.Length; i++){
			if(TypedCode == CorrectCode[i]){
                validCode = true;
				ToggleInputField(true);
			}
		}

        if (!validCode) //als de boolean alsnog false is, dan is er een foute code ingevoerd
        {

            Debug.Log("disaster"); //!! has to change into ingame error
            ToggleInputField(false);
        } 
        
	}
	
	public void ToggleInputField(bool i){
		RelevantInputField.SetActive(i);
        if (i)
        {
            Vector3 a = SelectedInputField.transform.localPosition;
            RelevantInputField.transform.localPosition = new Vector3(a.x + 160, a.y, a.x);
        }
    }
}
