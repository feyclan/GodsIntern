using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scaleScript : MonoBehaviour {


    public GameObject SelectedObject;
    public InputField SelectedInput;

	// Use this for initialization
	void Start () {

        SelectedInput.onEndEdit.AddListener(delegate {
            float size = float.Parse(SelectedInput.text);

            UpdateScale(size); });

	}
	
	// Update is called once per frame
	void UpdateScale (float a) {

        SelectedObject.transform.localScale *= a;
	}
}
