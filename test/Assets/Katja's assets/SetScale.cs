using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScale : MonoBehaviour {

public GameObject SelectedObject;
public InputField SelectedInputField;
public float scale;

void Start(){
	SelectedInputField.onEndEdit.AddListener(delegate {
		ChangeScale(); 
		});
	}
	
void ChangeScale(){
	scale = float.Parse(SelectedInputField.text); 
	SelectedObject.transform.localScale *= scale;
	}
}
