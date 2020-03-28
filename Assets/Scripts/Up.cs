using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour {


    private IEnumerator coroutine, coroutine2;
    public AudioSource[] Engine;
    private bool value = false;
    // Use this for initialization
    void Start()
    {
        Engine = GetComponents<AudioSource>();
    }


    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
 
       
		submarine.zrot = submarine.zrot + 0.08f;
       
    }

    private IEnumerator Idle(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);


    }



    public void onDown()
    {

        value = true;
        Engine[0].Play();
    }

    public void onUP()
    {
        
  
        value = false;


    }

    public void hold()
    {
        
        if(value == true)
        {
          
     
			submarine.zrot = submarine.zrot + 0.09f;
        }
      
    }

}
