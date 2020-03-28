using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disablefish : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void turnoff(){
		transform.parent.gameObject.SetActive (false);
		fishmanager.fishstatus = false;

	}
}
