using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CinematicEffects;

public class Trigger : MonoBehaviour {
    private GameObject[] terrain;
    private GameObject[] terraingrow;
    private GameObject[] terraingroup;

    private GameObject background, shipflow, terraintest, terraingrowtest, radar, camera, viewtest,submarine;

    public AudioSource[] signal;
    public static GameObject radarimage;
    public static bool radarbool=true;

    void Start() {

        camera = GameObject.Find("Main Camera");
        background = camera.transform.GetChild(4).gameObject;
        viewtest = camera.transform.GetChild(3).gameObject;

        submarine = GameObject.Find("submarine");
        shipflow = camera.transform.GetChild(5).gameObject;
        radar = submarine.transform.GetChild(1).gameObject;

     
		terrain = GameObject.FindGameObjectsWithTag("terrain");
       

        
        signal = GetComponents<AudioSource>();

        radarimage = GameObject.Find("Canvas").transform.GetChild(0).gameObject.transform.GetChild(1).gameObject ;
       
    }

    public void clickradar()
    {
        radarbool = false;

        signal[0].Play();


        terrain = GameObject.FindGameObjectsWithTag("terrain");
        foreach (GameObject k in terrain)
        {
            k.GetComponent<Renderer>().material = gameplay.mterrain[1];
        }
        whileradareffect();
    }



    private void whileradareffect()
    {
        camera.transform.GetComponent<Bloom>().enabled = false;
        background.SetActive(false);
        shipflow.SetActive(false);
        viewtest.SetActive(false);

        radar.SetActive(true);

        gameObject.SetActive(false);
        radarimage.SetActive(false);
    }



    void aftertrigger()
    {
    
		terrain = GameObject.FindGameObjectsWithTag("terrain");
		foreach (GameObject k in terrain)

        {
			
            k.GetComponent<Renderer>().material = gameplay.mterrain[0];
        }

        aftertriggereffect();

    }


    private void aftertriggereffect()
    {
        camera.transform.GetComponent<Bloom>().enabled = true;
        background.SetActive(true);
        shipflow.SetActive(true);
        viewtest.SetActive(true);

        radar.SetActive(false);
    }

  
   

}

