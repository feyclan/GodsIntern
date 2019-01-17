using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickObject : MonoBehaviour {

    public InputField commandInput;
    public GameObject commandInput2; 



    // Use this for initialization
	void Start () {
 

    }
	
	// Update is called once per frame
	void Update () {
		//if animal moving, input should stay close, MoveField()
	}

    private void OnMouseDown()
    {
        commandInput2.SetActive(true); //inputfield becomes visible
        MoveField(); //inputfield is moved next to animal

        GameObject commandInput = GameObject.Find("CommandObject"); //the gamecomponent with all the setcolors, etc...
        CommandScript cScript = commandInput.GetComponent<CommandScript>(); //get the script from said gamecomponent
        cScript.Tester();

    }

    void MoveField()
    {
        Vector3 a = this.gameObject.transform.localPosition; //get coordinates of selected animal
        commandInput2.transform.localPosition = new Vector3(a.x + 665 + ((a.x + 385)*23) , -31, 0);
    }
}
