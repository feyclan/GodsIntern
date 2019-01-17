using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickObject : MonoBehaviour {

    public GameObject commandInput; 


    // Use this for initialization
	void Start () {
 

    }
	
	// Update is called once per frame
	void Update () {
		//if animal moving, input should stay close, MoveField()
	}

    private void OnMouseDown()
    {
        commandInput.SetActive(true); //inputfield becomes visible
        MoveField(); //inputfield is moved next to animal

        GameObject commandObject = GameObject.Find("CommandObject"); //the gamecomponent with all the setcolors, etc...
        CommandScript cScript = commandObject.GetComponent<CommandScript>(); //get the script from said gamecomponent
        cScript.Initialize(this.gameObject);

    }

    void MoveField()
    {
        Vector3 a = this.gameObject.transform.localPosition; //get coordinates of selected animal
        commandInput.transform.localPosition = new Vector3(a.x + 665 + ((a.x + 385)*23) , -31, 0);
    }
}
