using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement1Test : MonoBehaviour {
	
public bool Achievement1Completed = false;

	void OnCollisionStay(Collision other){
		if (other.gameObject.tag == "Fox"){
			Achievement1Completed = true;
		}
	}
}
