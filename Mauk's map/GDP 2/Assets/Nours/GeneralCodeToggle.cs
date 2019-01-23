using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralCodeToggle : MonoBehaviour {

public InputField SelectedInputField;
string[] CorrectCode;
public GameObject RelevantInputField;


    bool scale; //to activate scalescript
    bool color;
    bool pos;
    string TypedCode;
    string position;

	void Start(){

        CorrectCode = new string[] {"SetColor", "SetScale", "transform.x", "transform.y", "transform.z", "AbilityFly", "AbilitySwim", "AbilityWalk"};
	SelectedInputField.onEndEdit.AddListener(delegate {
		ReadCode(); 
		});
}
	
	void ReadCode(){
        scale = false;
        color = false;
        pos = false;
        TypedCode = SelectedInputField.text;
        bool validCode = false;
		for (int i = 0; i < CorrectCode.Length; i++){
			if(TypedCode == CorrectCode[i]){
                validCode = true;
				ToggleInputField(true);
			}
		}

        if (!validCode) //als de boolean alsnog false is, dan is er een foute code ingevoerd
        {

            Debug.Log("disaster"); //!! has to change into ingame error
            //button.SetActive(true);

            ToggleInputField(false);
        } 
        
	}
	
	public void ToggleInputField(bool i){
		RelevantInputField.SetActive(i);
        if (i)
        {
            Vector3 a = SelectedInputField.transform.localPosition;
            RelevantInputField.transform.localPosition = new Vector3(a.x + 160, a.y, a.x);
            if (TypedCode == CorrectCode[0]) {
                color = true;
            } else if (TypedCode == CorrectCode[1])
            {
                scale = true;
                
            } else if (TypedCode == CorrectCode[2] || TypedCode == CorrectCode[3] || TypedCode == CorrectCode[4])
            {
                position = TypedCode;
                pos = true;
                //transform script
            } else
            {
                //boolean ability script??
            }
        }
    }

    public bool GetScale()
    {
        return scale;
    }

    public bool GetColor()
    {
        return color;
    }

    public bool GetPos()
    {
        return pos;
    }

    public string GetAxis()
    {
        return position;
    }
}
