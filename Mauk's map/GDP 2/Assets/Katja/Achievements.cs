using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour {

public int achievementNumber;
public GameObject Achievement1;
public GameObject Achievement2;
public GameObject Achievement3;
public GameObject Achievement4;
public GameObject EndGame;
public bool Achievement1Completed = false;
public bool Achievement2Completed = false;
public bool Achievement3Completed = false;
public bool Achievement4Completed = false;
public GameObject DrinkingWater;
public GameObject CommandObject;
public GameObject AppleTree;
public GameObject RedFox;

	// Use this for initialization
	void Start () {
		DrinkingWater = GameObject.Find("DrinkingWater");
		CommandObject = GameObject.Find("CommandObject");
		AppleTree = GameObject.Find("AppleTree");
		RedFox = GameObject.Find("Red Fox");
	}
	
	// Update is called once per frame
	void Update () {
		if (achievementNumber == 1){
			Achievement1Completed = DrinkingWater.GetComponent<Achievement1Test>().Achievement1Completed;
			if (Achievement1Completed == true){
				Achievement1.SetActive(false);
				Achievement2.SetActive(true);
				achievementNumber = 2;
			}
		}
		else if (achievementNumber == 2){
			Achievement2Completed = CommandObject.GetComponent<SetColor>().Achievement2Completed;
			if (Achievement2Completed == true){
				Achievement2.SetActive(false);
				Achievement3.SetActive(true);
				achievementNumber = 3;
			}
		}
		else if (achievementNumber == 3){
			Achievement3Completed = AppleTree.GetComponent<Achievement3Test>().Achievement3Completed;
			if (Achievement3Completed == true){
				Achievement3.SetActive(false);
				Achievement4.SetActive(true);
				achievementNumber = 4;
			}
		}
		else if (achievementNumber == 4){
			Achievement4Completed = RedFox.GetComponent<Achievement4Test>().Achievement4Completed;
			if (Achievement4Completed == true){
				Achievement4.SetActive(false);
				EndGame.SetActive(true);
				achievementNumber = 5;
			}
		}
	}
}
