using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class selectAnimal : MonoBehaviour {

    public InputField SelectedInputField; //fill which animal
    public GameObject ActivatedInput; //set color input active
    public InputField ActivatedInputSelect; //read color input
    public string[] CorrectAnimal; //list of correct animals input
    public GameObject[] RelevantAnimal; //list of animalobjects
    public string[] colorCode;
    public Color[] colors;

    // Use this for initialization
    void Start() {

        SelectedInputField.onEndEdit.AddListener(delegate
        {
            string inputCode = SelectedInputField.text;
            for (int i = 0; i < CorrectAnimal.Length; i++)
            {
                if (inputCode == CorrectAnimal[i])
                {
                    ReadAnimal(RelevantAnimal[i]);
                }
            }
        });
            


    }
	
	// Update is called once per frame
	void ReadAnimal(GameObject a) {

        ActivatedInput.SetActive(true);
        ActivatedInputSelect.onEndEdit.AddListener(delegate
        {
            string colorInput = ActivatedInputSelect.text;
            for (int i = 0; i < colorCode.Length; i++)
            {
                if (colorInput == colorCode[i]){
                    Renderer rend = a.GetComponent<Renderer>();
                    ChangeColor(rend, colors[i]);
                }
            }
        });
	}

    void ChangeColor(Renderer a, Color b)
    {
        Shader shader1 = Shader.Find("Standard");
        a.material.shader = shader1;
        a.material.SetColor("_Color", b);
    }
    
}
