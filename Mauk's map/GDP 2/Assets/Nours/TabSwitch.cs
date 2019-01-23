using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabSwitch : MonoBehaviour {

    public GameObject[] animals;

    public GameObject commandInput;

    GeneralCodeToggle cScript;
    CommandScript tScript;

    int getList = 0;

    // Use this for initialization
	void Start () {
        cScript = this.gameObject.GetComponent<GeneralCodeToggle>();
        tScript = this.gameObject.GetComponent<CommandScript>();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("tab"))
        {
            Debug.Log("tab is pressed");
            cScript.ToggleInputField(false);
            commandInput.SetActive(true);
            
            tScript.Initialize(animals[getList]);
            if (getList == 6)
            {
                getList = 0;
            }
            else
            {
                getList++;
            }
        }
	}
}
