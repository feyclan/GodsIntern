using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectColor : MonoBehaviour {

    public InputField SelectedInput;

    public string[] color;
    public Color[] colors;

    CommandScript getAnimal;
    GeneralCodeToggle activate;

    void Start () {

        getAnimal = this.gameObject.GetComponent<CommandScript>();
        activate = this.gameObject.GetComponent<GeneralCodeToggle>();
        SelectedInput.onEndEdit.AddListener(delegate
        {
            if (activate.GetColor())
            {
                string text = SelectedInput.text;
                bool valid = false;
                for (int i = 0; i < color.Length; i++)
                {
                    if (text == color[i])
                    {
                        valid = true;
                        ChangeColor(colors[i]);
                    }
                }

                if (!valid)
                {
                    Debug.Log("invalid color!");
                }
            }
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ChangeColor(Color i)
    {
        Renderer rend = getAnimal.GetAnimal().GetComponent<Renderer>();
        Shader shader1 = Shader.Find("Standard");
        rend.material.shader = shader1;
        rend.material.SetColor("_Color", i);
    }
}
