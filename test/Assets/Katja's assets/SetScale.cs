using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScale : MonoBehaviour {

public GameObject SelectedObject;
public InputField SelectedInputField;
float PreferredScale = 1;

void Start(){
	SelectedInputField.onEndEdit.AddListener(delegate {ChangeScale(PreferredScale); });
}

	
void ChangeScale(float scale)
{
	PreferredScale = float.Parse(SelectedInputField.text);
	SelectedObject.transform.localScale *= scale;
}
}