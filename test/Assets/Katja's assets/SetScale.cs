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

void Update()
{
	PreferredScale = float.Parse(SelectedInputField.text);
	}

	
void ChangeScale(float scale)
{
SelectedObject.transform.localScale *= scale;
}
}
