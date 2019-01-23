using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePosition : MonoBehaviour {

    public InputField SelectedInput;

    CommandScript getAnimal;
    GeneralCodeToggle activate;

    void Start () {

        getAnimal = this.gameObject.GetComponent<CommandScript>();
        activate = this.gameObject.GetComponent<GeneralCodeToggle>();
        SelectedInput.onEndEdit.AddListener(delegate
        {

            if (activate.GetPos())
            {
                float coord = float.Parse(SelectedInput.text);
                MovePosition(coord);
            }
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void MovePosition(float i)
    {
        Vector3 a = getAnimal.GetAnimal().transform.localPosition;

        if (activate.GetAxis() == "transform.x")
        {
            getAnimal.GetAnimal().transform.localPosition = new Vector3(a.x + i, a.y, a.z);
        } else if (activate.GetAxis() == "transform.y")
        {
            getAnimal.GetAnimal().transform.localPosition = new Vector3(a.x, a.y+i, a.z);
        } else
        {
            getAnimal.GetAnimal().transform.localPosition = new Vector3(a.x, a.y, a.z + i);
        }
         
       
    }
}
