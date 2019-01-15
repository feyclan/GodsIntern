using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scaleScript : MonoBehaviour {


    public GameObject SelectedObject;
    public InputField SelectedInput;
    float scaleSize = 1;

    // Use this for initialization
    void Start () {

        

        SelectedInput.onEndEdit.AddListener(delegate {
            float size = float.Parse(SelectedInput.text);

            UpdateScale(size); });

	}
	
	// Update is called once per frame
	void UpdateScale (float a) {

        float b = (a - scaleSize) * 2;

        scaleSize = a;
        SelectedObject.transform.localScale += new Vector3(b, b, b);


	}
}
