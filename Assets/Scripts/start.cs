using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {

     void OnMouseDown()
    {
        gameplay.playgame = true;
        GameObject.Find("Canvas").transform.GetChild(1).gameObject.GetComponent<Animator>().Play("play");
        GameObject.Find("Canvastutorial").transform.GetChild(0).gameObject.SetActive(true);
        gameplay.Ads.destroybanner();
    }
}
