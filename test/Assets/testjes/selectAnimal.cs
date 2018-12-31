using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class selectAnimal : MonoBehaviour {

    public InputField SelectedInputField;
    public GameObject ActivatedInput;
    public string[] CorrectAnimal;
    public GameObject[] RelevantAnimal;


    // Use this for initialization
    void Start() {

        SelectedInputField.onEndEdit.AddListener(delegate
        {
            ReadCode();
        });
            


    }
	
	// Update is called once per frame
	void ReadCode () {

        string inputCode = SelectedInputField.text;
        for (int i = 0; i < CorrectAnimal.Length; i++){
            if(inputCode == CorrectAnimal[i])
            {
                ActivatedInput.SetActive(true);

            }

        }
		
	}
}
