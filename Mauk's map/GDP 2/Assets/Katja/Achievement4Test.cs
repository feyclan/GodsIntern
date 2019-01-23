using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement4Test : MonoBehaviour {

public bool Achievement4Completed = false;

	void OnCollisionStay(Collision other){
		if (other.gameObject.tag == "Bird"){
			Achievement4Completed = true;
		}
	}
}
