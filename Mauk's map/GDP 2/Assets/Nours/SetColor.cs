using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetColor : MonoBehaviour {

public InputField SelectedInputField;
public string[] colorcodes;
public Color[] colors;
public bool Achievement2Completed = false;



 CommandScript getAnimal;
 GeneralCodeToggle activate;

    public GameObject error;

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
					if(getAnimal.GetAnimal().tag == "Fish"){ //For the achievements
					Achievement2Completed = true;
					}
                }
            }
            
            if (!valid)
            {
                activate.ToggleInputField(false);
                error.SetActive(true);


                //Debug.Log("dbgn");
            }
        }
    });
}

    private void Update()
    {
    }

    void ChangeColor(Color chosencolor){
		//Fetch the Renderer from the GameObject
        Renderer[] rend = getAnimal.GetAnimal().GetComponentsInChildren<Renderer>();
        //Set the main Color of the Material to blue
        rend[0].material.color = chosencolor;
	}

}