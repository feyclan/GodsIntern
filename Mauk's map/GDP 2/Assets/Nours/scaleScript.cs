using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scaleScript : MonoBehaviour {


    public InputField SelectedInput;
    float scaleSize = 1;

    CommandScript getAnimal;
    GeneralCodeToggle activate;
    // Use this for initialization
     void Start() {

        getAnimal = this.gameObject.GetComponent<CommandScript>();
        activate = this.gameObject.GetComponent<GeneralCodeToggle>();
        SelectedInput.onEndEdit.AddListener(delegate {
            if (activate.GetScale())
            {
                //ERROR VOOR ALS JE GEEN NUMMERS ERIN DOET ENALLSES

                float size = float.Parse(SelectedInput.text);

                UpdateScale(size);
            }
        });

	}
	
	// Update is called once per frame
	 void UpdateScale (float a) {

        
        float b = (a - scaleSize) * 1;

        scaleSize = a;
        getAnimal.GetAnimal().transform.localScale += new Vector3(b, b, b);

        
	}
}
