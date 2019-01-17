using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickObject : MonoBehaviour {

    public InputField commandInput;
    public GameObject commandInput2;

    //public string[] commands;

    public string[] colors;
    public Color[] colors2;


    // Use this for initialization
	void Start () {
 

    }
	
	// Update is called once per frame
	void Update () {
		//if animal moving, input should stay close, MoveField()
	}

    private void OnMouseDown()
    {
        //Debug.Log("success");
        commandInput2.SetActive(true);
        MoveField();

        GameObject g = GameObject.Find("TESTOBJECT");
        GetComponentTest bScript = g.GetComponent<GetComponentTest>();
        bScript.Tester(this.gameObject);
        bScript.Tester();
        //Tester();

        //GET.COMPONENT<> PROBEREN
    }

    void MoveField()
    {
        Vector3 a = this.gameObject.transform.localPosition;
        //Debug.Log(a);
        commandInput2.transform.localPosition = new Vector3(a.x + 665 + ((a.x + 385)*23) , -31, 0);
    }

    /*
    void ChangeColor(Color i)
    {
        Renderer rend = this.gameObject.GetComponent<Renderer>();
        Shader shader1 = Shader.Find("Standard");
        rend.material.shader = shader1;
        rend.material.SetColor("_Color", i);

    }



    void Tester()
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
    }  */
}
