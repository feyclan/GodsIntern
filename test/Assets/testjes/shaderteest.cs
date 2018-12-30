using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shaderteest : MonoBehaviour
{

    public GameObject SelectedObject;
    public InputField SelectedInputField;
    public string[] colorcodes;
    public Color[] colors;

    void Start()
    {
        SelectedInputField.onEndEdit.AddListener(delegate {
            string ColorPreference = SelectedInputField.text;
            for (int i = 0; i < colorcodes.Length; i++)
            {
                if (ColorPreference == colorcodes[i])
                {
                    ChangeColor(colors[i]);
                }
            }
        });
    }

    void ChangeColor(Color chosencolor)
    {
        //Fetch the Renderer from the GameObject
        Renderer rend = SelectedObject.GetComponent<Renderer>();
        Shader shader1 = Shader.Find("Standard");
        //Set the main Color of the Material to blue
        //rend.material.SetPass(2);
        //rend.material.color = chosencolor;
        rend.material.shader = shader1;
        rend.material.SetColor("_Color", chosencolor);

    }

}