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
		
	}

    private void OnMouseDown()
    {
        //Debug.Log("success");
        commandInput2.SetActive(true);
        Debug.Log(this.gameObject.name);
        Testing();
    }

    void Testing()
    {
        float a = this.gameObject.transform.localPosition.x;
        Debug.Log(a);
        commandInput2.transform.localPosition += new Vector3(2, 2, 2);
        //this.gameObject.GetComponent
    }
}
