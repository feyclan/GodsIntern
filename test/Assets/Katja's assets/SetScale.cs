using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScale : MonoBehaviour {

public GameObject SelectedObject;
public InputField SelectedInputField;
float scale;

void Start(){
	SelectedInputField.onEndEdit.AddListener(delegate {
		scale = float.Parse(SelectedInputField.text); 
		ChangeScale(); 
		});
	}
	
void ChangeScale(){
	SelectedObject.transform.localScale *= scale;
	}
}
