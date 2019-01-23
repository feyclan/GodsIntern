using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralCodeToggle2 : MonoBehaviour {

public InputField SelectedInputField;
public string[] CorrectCode;
public GameObject[] RelevantInputField;
	void Start(){
	SelectedInputField.onEndEdit.AddListener(delegate {
		ReadCode(); 
		});
}
	
	void ReadCode(){
		string TypedCode = SelectedInputField.text;
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
