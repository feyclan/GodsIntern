using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandScript : MonoBehaviour {


    public InputField commandInput;

    public string[] colors;
    public Color[] colors2;

    GameObject animal;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void Tester(GameObject i)
    {

        animal = i;
        Debug.Log("success");
        Debug.Log(i.name);
        Debug.Log(this.gameObject.name);
    }


    void ChangeColor(Color i)
    {
        Renderer rend = animal.GetComponent<Renderer>();
        Shader shader1 = Shader.Find("Standard");
        rend.material.shader = shader1;
        rend.material.SetColor("_Color", i);

    }



    public void Tester()
    {
        commandInput.onEndEdit.AddListener(delegate
        {
            string inputCode = commandInput.text;
            for (int i = 0; i < colors.Length; i++)
            {
                if (inputCode == colors[i])
                {
                    ChangeColor(colors2[i]);
                }
            }
        });
    }
}
