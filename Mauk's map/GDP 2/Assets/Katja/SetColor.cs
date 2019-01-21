using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetColor : MonoBehaviour {

public GameObject SelectedObject;
public GameObject GameObjectInput;
public InputField SelectedInputField;
public string[] colorcodes;
public Color[] colors;

void Start(){
	SelectedInputField = GameObjectInput.GetComponent<InputField>();
	SelectedInputField.onEndEdit.AddListener(delegate {
		string ColorPreference = SelectedInputField.text;
		for (int i = 0; i < colorcodes.Length; i++){
			if(ColorPreference == colorcodes[i]){
				ChangeColor(colors[i]);
				}
			}
		GameObjectInput.SetActive(false);
		});
}

void ChangeColor(Color chosencolor){
		//Fetch the Renderer from the GameObject
        Renderer[] rend = SelectedObject.GetComponentsInChildren<Renderer>();
        //Set the main Color of the Material to blue
        rend[0].material.color = chosencolor;
	}

}