using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxygentankscript : MonoBehaviour {

	// Use this for initialization

	private GameObject submarineobj;
	private float diff;

	void Start () {
		submarineobj = GameObject.Find ("submarine");
	}
	


	void LateUpdate(){
		diff = submarineobj.transform.position.x - transform.position.x;
		if (diff > 5f) {
			gameplay.oxygenvalue = false;
			Destroy (gameObject);
		
		}
	}

	void OnTriggerEnter2D(){
		submarine.oxygen.GetComponent<Image> ().fillAmount += 0.4f;
		gameplay.oxygenvalue = false;
	
		Destroy(gameObject);
	}

}
