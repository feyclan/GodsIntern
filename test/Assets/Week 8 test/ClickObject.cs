using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickObject : MonoBehaviour {

    public GameObject commandInput;
    GameObject commandObject;
    CommandScript cScript; //get the commandscript
    GeneralCodeToggle tScript; //get the codetoggle script

    // Use this for initialization
    void Start () {

        commandObject = GameObject.Find("CommandObject"); //the gamecomponent with all the setcolors, etc...
        cScript = commandObject.GetComponent<CommandScript>(); //get the script from said gamecomponent
        tScript = commandObject.GetComponent<GeneralCodeToggle>();
    }
	
	// Update is called once per frame
	void Update () {
		//if animal moving, input should stay close, MoveField()
	}

    private void OnMouseDown()
    {
        tScript.ToggleInputField(false); //second input goes away when other object is selected
        commandInput.SetActive(true); //inputfield becomes visible
        MoveField(); //inputfield is moved next to animal

        
        cScript.Initialize(this.gameObject);

    }

    void MoveField()
    {
        Vector3 a = this.gameObject.transform.localPosition; //get coordinates of selected animal
        commandInput.transform.localPosition = new Vector3(a.x + 665 + ((a.x + 385)*23) , -31, 0);
    }
}
