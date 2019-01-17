using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPosition : MonoBehaviour {
public GameObject SelectedObject;
public InputField XposInputField;
public InputField YposInputField;
public InputField ZposInputField;
float Xpos = 0;
float Ypos = 0;
float Zpos = 0;
int Xi;
int Yi;
int Zi;
Vector3 a;

	void Start () {
		XposInputField.onEndEdit.AddListener(delegate {
			Xi = 1; 
			Xpos = float.Parse(XposInputField.text);
			XposInputField.DeactivateInputField();
		});
		YposInputField.onEndEdit.AddListener(delegate {
			Yi = 1;
			Ypos = float.Parse(YposInputField.text);
		});
		ZposInputField.onEndEdit.AddListener(delegate {
			Zi = 1;
			Zpos = float.Parse(ZposInputField.text);
		});
	}
	
	void Update () {
		
        a = SelectedObject.transform.localPosition;
		
		//Xposition
		if(Xi>0 && Xi < Mathf.Abs(Xpos)){
			SelectedObject.transform.localPosition = new Vector3(a.x + (Xpos/Mathf.Abs(Xpos)),a.y, a.z);
			Xi++;
		}
		else{
			Xi = 0;
		}
		
		//Yposition
		if(Yi>0 && Yi < Mathf.Abs(Ypos)){
			SelectedObject.transform.localPosition = new Vector3(a.x, a.y + (Ypos/Mathf.Abs(Ypos)), a.z);
			Yi++;
		}
		else{
			Yi = 0;
		}
		
		//Zposition
		if(Zi>0 && Zi < Mathf.Abs(Zpos)){
			SelectedObject.transform.localPosition = new Vector3(a.x, a.y, a.z + (Zpos/Mathf.Abs(Zpos)));
			Zi++;
		}
		else{
			Zi = 0;
		}
	}
}