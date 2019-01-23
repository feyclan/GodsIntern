using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement3Test : MonoBehaviour {

public bool Achievement3Completed = false;

	void OnCollisionStay(Collision other){
		if (other.gameObject.tag == "Bird"){
			Achievement3Completed = true;
		}
	}
}
