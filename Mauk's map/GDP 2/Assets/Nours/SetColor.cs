using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetColor : MonoBehaviour {

public InputField SelectedInputField;
public string[] colorcodes;
public Color[] colors;

 CommandScript getAnimal;
 GeneralCodeToggle activate;

void Start(){

        getAnimal = this.gameObject.GetComponent<CommandScript>();
        activate = this.gameObject.GetComponent<GeneralCodeToggle>();
	SelectedInputField.onEndEdit.AddListener(delegate {
        if (activate.GetColor())
        {
            string ColorPreference = SelectedInputField.text;
            bool valid = false;
            for (int i = 0; i < colorcodes.Length; i++)
            {
                if (ColorPreference == colorcodes[i])
                {
                    valid = true;
                    ChangeColor(colors[i]);
                }
            }
            
            if (!valid)
            {
                activate.ToggleInputField(false);
                Debug.Log("dbgn");
            }
        }
    });
}

void ChangeColor(Color chosencolor){
		//Fetch the Renderer from the GameObject
        Renderer[] rend = getAnimal.GetAnimal().GetComponentsInChildren<Renderer>();
        //Set the main Color of the Material to blue
        rend[0].material.color = chosencolor;
	}

}