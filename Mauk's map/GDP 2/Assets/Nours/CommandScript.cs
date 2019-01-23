using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandScript : MonoBehaviour {


    public InputField commandInput;
    public GameObject error;

    GameObject animal;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }


    public void Initialize(GameObject i)
    {
        animal = i;
        commandInput.text = animal.name;
        this.gameObject.GetComponent<GeneralCodeToggle>();

    }

    public GameObject GetAnimal()
    {
        return animal;
    }

}
