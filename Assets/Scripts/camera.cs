using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

    // Use this for initialization
    private GameObject submarine;
	void Start () {
        submarine = GameObject.Find("submarine");
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(submarine.transform.position.x+5.14f, submarine.transform.position.y+0.2f, transform.position.z);
    }

    
}
