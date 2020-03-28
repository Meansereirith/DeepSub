using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class showpanel {


    public static void afterdie()
    {
        gameplay.playgame = false;
        float score = GameObject.Find("submarine").transform.position.x + 6f;
        GameObject.Find("submarine").SetActive(false);
        GameObject.Find("Canvas").transform.GetChild(2).gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(false);

        GameObject.Find("Canvas").transform.GetChild(2).transform.GetChild(1).transform.GetComponent<TextMeshProUGUI>().text = "You have reached " + Convert.ToInt32(score).ToString() + "m";

    }

    public static void afterplay()
    {
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.GetChild(1).gameObject.SetActive(false);

    }

    public static void playrestart()
    {
        GameObject.Find("Canvas").transform.GetChild(2).transform.GetComponent<Animator>().Play("restart");
    }

  
}
