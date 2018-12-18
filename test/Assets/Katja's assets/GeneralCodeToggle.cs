using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralCodeToggle : MonoBehaviour {

public GameObject SelectedInputField;
public string[] CorrectCode;
public GameObject[] RelevantInputField;
	
	// Update is called once per frame
	void Update () {
		string TypedCode = SelectedInputField.GetComponent<InputField>().text;
		for (int i = 0; i < CorrectCode.Length; i++){
			if(TypedCode == CorrectCode[i]){
				ToggleInputField(RelevantInputField[i]);
			}
		}
	}
	
	void ToggleInputField(GameObject input){
		input.SetActive(true);
	}
}
