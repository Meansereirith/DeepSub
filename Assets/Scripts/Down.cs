using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour {

  

    private IEnumerator coroutine, coroutine2;
    public AudioSource[] Engine;
    private bool value = false;

    void Start()
    {
        Engine = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
     
     

        submarine.zrot = submarine.zrot - 0.09f;

       
    }

    private IEnumerator Idle(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

       

      
    }

    public void onDown()
    {
           Engine[0].Play();
        value = true;
	
    }

    public void onUP()	
    {
        value = false;


    }


    public void hold()
    {

       
		if (value == true) {
	
			submarine.zrot = submarine.zrot - 0.09f;
		}
      
    }

   


}
