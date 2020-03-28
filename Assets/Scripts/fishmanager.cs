using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishmanager {

	private GameObject sfish, lfish, lightfish, mfish;
	private GameObject groupfish;
	public static bool fishstatus = false;

	// Use this for initialization

	public fishmanager(){

		groupfish = GameObject.Find ("groupfish");
		sfish = groupfish.transform.GetChild (0).gameObject;
		lfish = groupfish.transform.GetChild (1).gameObject;
		lightfish = groupfish.transform.GetChild (2).gameObject;
		mfish = groupfish.transform.GetChild (3).gameObject;

	}
	
	// Update is called once per frame

	public void turnfishon(int index){

		if (fishstatus == true) {
			
		} else {
			fishstatus=true;
			switch (index) {

			case 0:
				sfish.SetActive (true);
				break;
			case 1:
				lfish.SetActive (true);
				break;
			case 2:
				lightfish.SetActive (true);
				break;
			case 3:
				mfish.SetActive (true);
				break;
			}
		}



	}

}
