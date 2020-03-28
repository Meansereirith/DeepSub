using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalecamera : MonoBehaviour {

	private int targetwidth = 1920;
	private float pixeltounit = 108;
	// Use this for initialization
	void Start () {
		int height = Mathf.RoundToInt (targetwidth / (float)Screen.width * (float)Screen.height);
		Camera.main.orthographicSize = height / pixeltounit / 2;
	}

}
