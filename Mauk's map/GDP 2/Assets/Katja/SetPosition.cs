using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPosition : MonoBehaviour {
public GameObject SelectedObject;
//public InputField XposInputField;			these are not necessary anymore
//public InputField YposInputField;
//public InputField ZposInputField;
public GameObject XposGameObject;
public GameObject YposGameObject;
public GameObject ZposGameObject;
public float speed;
float Xpos = 0;
float Ypos = 0;
float Zpos = 0;
float Xi;
float Yi;
float Zi;
Vector3 a;

	void Start () {
		InputField XposInputField = XposGameObject.GetComponent<InputField>();
		InputField YposInputField = YposGameObject.GetComponent<InputField>();
		InputField ZposInputField = ZposGameObject.GetComponent<InputField>();
		XposInputField.onEndEdit.AddListener(delegate {
			Xi = 1; 
			Xpos = float.Parse(XposInputField.text);
			XposGameObject.SetActive(false);
		});
		YposInputField.onEndEdit.AddListener(delegate {
			Yi = 1;
			Ypos = float.Parse(YposInputField.text);
			YposGameObject.SetActive(false);
		});
		ZposInputField.onEndEdit.AddListener(delegate {
			Zi = 1;
			Zpos = float.Parse(ZposInputField.text);
			ZposGameObject.SetActive(false);
		});
	}
	
	void Update () {
		
        a = SelectedObject.transform.localPosition;
		//Xposition
		if(Xi>0 && Xi < Mathf.Abs(Xpos)){
			SelectedObject.transform.localPosition = new Vector3(a.x + (Xpos/Mathf.Abs(Xpos))*speed,a.y, a.z);
			SelectedObject.transform.LookAt(new Vector3(a.x + (Xpos/Mathf.Abs(Xpos)),a.y, a.z)); // change looking direction
			Xi += 1*speed;
		}
		else{
			Xi = 0;
		}
		
		//Yposition
		if(Yi>0 && Yi < Mathf.Abs(Ypos)){
			SelectedObject.transform.localPosition = new Vector3(a.x, a.y + (Ypos/Mathf.Abs(Ypos))*speed, a.z);
			//SelectedObject.transform.LookAt(new Vector3(a.x, a.y + (Ypos/Mathf.Abs(Ypos)), a.z));
			Yi += 1*speed;
		}
		else{
			Yi = 0;
		}
		
		//Zposition
		if(Zi>0 && Zi < Mathf.Abs(Zpos)){
			SelectedObject.transform.localPosition = new Vector3(a.x, a.y, a.z + (Zpos/Mathf.Abs(Zpos))*speed);
			SelectedObject.transform.LookAt(new Vector3(a.x, a.y, a.z + (Zpos/Mathf.Abs(Zpos))));
			Zi += 1*speed;
		}
		else{
			Zi = 0;
		}
		
	}
}