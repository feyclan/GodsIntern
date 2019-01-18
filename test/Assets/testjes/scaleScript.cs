using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scaleScript : MonoBehaviour {


    public InputField SelectedInput;
    float scaleSize = 1;

    CommandScript getAnimal;

    // Use this for initialization
    void Start () {

        getAnimal = this.gameObject.GetComponent<CommandScript>();
        SelectedInput.onEndEdit.AddListener(delegate {
            float size = float.Parse(SelectedInput.text);

            UpdateScale(size); });

	}
	
	// Update is called once per frame
	void UpdateScale (float a) {

        float b = (a - scaleSize) * 2;

        scaleSize = a;
        getAnimal.GetAnimal().transform.localScale += new Vector3(b, b, b);


	}
}
