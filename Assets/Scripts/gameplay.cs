using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CinematicEffects;

public class gameplay : MonoBehaviour
{
    private GameObject[] terrain;
    private GameObject ship, camera, trigger;

    public Material defaultterrain, hologramterrain;
    public static Material[] mterrain;

    public static bool playgame = false;
    private static float time;
    private AudioSource[] gameoversound;
    public static Admobs Ads = new Admobs();

    public static bool oxygenvalue = false;
    fishmanager fishgroup;


    void Start()
    {
        terrain = GameObject.FindGameObjectsWithTag("terrain");
        ship = GameObject.Find("submarine");
        camera = GameObject.Find("Main Camera");
        gameoversound = GetComponents<AudioSource>();
        trigger = camera.transform.GetChild(2).gameObject;

      

        mterrain = new Material[2] { defaultterrain, hologramterrain };

        fishgroup = new fishmanager();

        Ads.RequestBanner();
        Ads.RequestInterstitial();

    }



    void Update()
    {

        if (Trigger.radarbool == false)
        {
            cooldownradar();
        }
        else
        {
            fishgroup.turnfishon(Random.Range(0, 4));
        }



        try
        {
            if (PlayerPrefs.GetInt("deadtime") == 5)
            {
                Ads.ShowInterstitial();
                PlayerPrefs.SetInt("deadtime", 0);
            }

        }
        catch (System.Exception e)
        {

        }

    }



    private void cooldownradar()
    {
        time += Time.deltaTime;
        if (time > 15f)
        {
            Trigger.radarbool = true;
            time = 0f;
            Trigger.radarimage.SetActive(true);
            trigger.SetActive(true);

        }
    }




    //following code is used to call showpanel

    void afterplay()
    {

        showpanel.afterplay();

    }

    void playrestart()
    {


        gameoversound[3].Play();
        showpanel.playrestart();
    }

    void restartscene()
    {
        Application.LoadLevel("gameplay");
    }

    public void pausebtn()
    {
        Time.timeScale = 0;
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.transform.GetChild(6).gameObject.SetActive(true);

    }

    public void resumebtn()
    {
        Time.timeScale = 1;
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.transform.GetChild(6).gameObject.SetActive(false);

    }

}
