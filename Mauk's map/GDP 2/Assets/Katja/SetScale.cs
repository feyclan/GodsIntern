using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScale : MonoBehaviour {

public GameObject SelectedObject;
public GameObject GameObjectInput;
public float scale;
public InputField SelectedInputField;

void Start(){
	SelectedInputField = GameObjectInput.GetComponent<InputField>();
	SelectedInputField.onEndEdit.AddListener(delegate {
		//ChangeScale(); 
		scale = float.Parse(SelectedInputField.text); 
		SelectedObject.transform.localScale *= scale;
		GameObjectInput.SetActive(false);
		});
	}
	
void ChangeScale(){
	scale = float.Parse(SelectedInputField.text); 
	SelectedObject.transform.localScale *= scale;
	}
}
