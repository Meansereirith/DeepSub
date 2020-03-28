using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class submarine : MonoBehaviour {

    public static float xdir, ydir;
  
	public static float zrot;
    private TextMeshProUGUI score;
    public AudioSource[] explosion;
    public static GameObject oxygen;
    private float oxygenlevel;
    void Start()
    {
        xdir = 0.025f;
        ydir = 0f;
		zrot = 0f;
        explosion = GetComponents<AudioSource>();
        score = GameObject.Find("Canvas").transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        oxygen = GameObject.Find("Canvas").transform.GetChild(0).gameObject.transform.GetChild(4).gameObject;
    }



    void LateUpdate()
    {
        
		if(gameplay.playgame == true)
		{

			score.text = Convert.ToInt32(transform.position.x + 6f).ToString();

			transform.Translate(new Vector2(xdir, ydir));

            oxygenlevel = Time.deltaTime * 0.005f;
            oxygen.GetComponent<Image>().fillAmount -= oxygenlevel;


            if (oxygen.GetComponent<Image>().fillAmount == 0f)
            {
                afterdie();
            } else if (oxygen.GetComponent<Image>().fillAmount < 0.3f) {
                oxygen.GetComponent<Animator>().SetTrigger("verylow");
            }
            else
            {
                oxygen.GetComponent<Animator>().SetTrigger("goodengine");
            }


			transform.eulerAngles = new Vector3(0f, 0f, zrot);

		
		}


       

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        explosion[0].Play();
      
        PlayerPrefs.SetInt("deadtime", PlayerPrefs.GetInt("deadtime") + 1);
        int gameoverscore = Convert.ToInt32(transform.position.x + 16f);
       
        if (gameoverscore > PlayerPrefs.GetInt("bestscore"))
        {

            PlayerPrefs.SetInt("bestscore", gameoverscore);
         
        }
     
        GetComponent<Animator>().Play("die");

    }

    private void afterdie()
    {
        showpanel.afterdie();
    }
}
