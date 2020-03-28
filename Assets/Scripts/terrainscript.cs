using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class terrainscript : MonoBehaviour {

    public GameObject[] terrainboi1 = new GameObject[8];
    private GameObject submarine;
    float diff;
	private bool nextterrainvalue = false;
    // Use this for initialization\
    private GameObject pinpoint0, pinpoint1, pinpoint2, pinpoint3, pinpoint4;
    private int index;
    private float value;
    private GameObject oxygenlevel;
    private bool dropoxygen = false;
	public GameObject oxygentank;

    void Start () {
       

        submarine = GameObject.Find("submarine");

        oxygenlevel = GameObject.Find("Canvas").transform.GetChild(0).gameObject.transform.GetChild(4).gameObject;
        pinpoint0 = this.gameObject.transform.GetChild(0).gameObject;

		switch (LayerMask.LayerToName (gameObject.layer))
        {

		case "t1group":

			pinpoint0 = this.gameObject.transform.GetChild (2).gameObject;
			pinpoint1 = transform.GetChild (3).gameObject;
			pinpoint2 = transform.GetChild (4).gameObject;
			index = UnityEngine.Random.Range (0, 2);


                break;
            case "t2group":
				
                pinpoint0 = transform.GetChild(2).gameObject;
                pinpoint1 = transform.GetChild(3).gameObject;
                pinpoint2 = transform.GetChild(4).gameObject;
                index = UnityEngine.Random.Range(0, 2);

                break;
            case "t3groupBig3":

                pinpoint0 = transform.GetChild(5).gameObject;
                pinpoint1 = transform.GetChild(6).gameObject;
                pinpoint2 = transform.GetChild(7).gameObject;
                pinpoint3 = transform.GetChild(8).gameObject;
                index = UnityEngine.Random.Range(0, 3);

                break;
            case "t4group":

                pinpoint0 = transform.GetChild(3).gameObject;
                pinpoint1 = transform.GetChild(4).gameObject;
                pinpoint2 = transform.GetChild(5).gameObject;
                index = UnityEngine.Random.Range(0, 2);

                break;
            case "t5group":

                pinpoint0 = transform.GetChild(4).gameObject;
                pinpoint1 = transform.GetChild(5).gameObject;
                pinpoint2 = transform.GetChild(6).gameObject;
                pinpoint3 = transform.GetChild(7).gameObject;
                index = UnityEngine.Random.Range(0, 3);

                break;
            case "t6groupBig2":

                pinpoint0 = transform.GetChild(2).gameObject;
                pinpoint1 = transform.GetChild(3).gameObject;
                pinpoint2 = transform.GetChild(4).gameObject;
                pinpoint3 = transform.GetChild(5).gameObject;
                index = UnityEngine.Random.Range(0, 3);

                break;
            case "t7groupbig4":

                pinpoint0 = transform.GetChild(4).gameObject;
                pinpoint1 = transform.GetChild(5).gameObject;
                pinpoint2 = transform.GetChild(6).gameObject;
                pinpoint3 = transform.GetChild(7).gameObject;
                index = UnityEngine.Random.Range(0, 3);

                break;
            case "t8groupbig7":
                pinpoint0 = transform.GetChild(7).gameObject;
                pinpoint1 = transform.GetChild(8).gameObject;
                pinpoint2 = transform.GetChild(9).gameObject;
                pinpoint3 = transform.GetChild(10).gameObject;
                index = UnityEngine.Random.Range(0, 3);

                break;

        }


        value = oxygenlevel.GetComponent<Image>().fillAmount;


        if (gameplay.oxygenvalue == false && value < 0.6f && dropoxygen == false)
        {
        

            switch (index)
            {
                case 0:
                
				oxygentank.transform.position = pinpoint0.transform.position;
                    break;
                case 1:
                
				oxygentank.transform.position = pinpoint1.transform.position;
                    break;
                case 2:
               
				oxygentank.transform.position = pinpoint2.transform.position;
                    break;
                case 3:
                
				oxygentank.transform.position = pinpoint3.transform.position;
                    break;

            }

			Instantiate (oxygentank, oxygentank.transform.position, Quaternion.identity);

            gameplay.oxygenvalue = true;
            dropoxygen = true;
        }


    }

    // Update is called once per frame
	private void generateterrain(int n){
		if (nextterrainvalue == false) {
			nextterrainvalue = true;
			int index = UnityEngine.Random.Range(0, 8);

			Instantiate(terrainboi1[index], new Vector3(transform.position.x + 17.77f * n,0,0),Quaternion.identity);
		}

	}

	void LateUpdate(){
	

		diff = submarine.transform.position.x - transform.position.x;


		//-30


		string layer = LayerMask.LayerToName (gameObject.layer);



		switch (LayerMask.LayerToName (gameObject.layer))
		{

		case "t1group":




			if (diff > 15f) {

				Debug.Log ("t1group yeah");
				Destroy (gameObject);
			} else if (diff > -10f) {

				int n = Convert.ToInt32(transform.tag);
				generateterrain (n);
				//subtract -5 before, add 5 back if needed
//				if (nextterrainvalue == false) {
//					nextterrainvalue = true;
//					int index = UnityEngine.Random.Range(0, 8);
//					int n = Convert.ToInt32(transform.tag);
//					Instantiate(terrainboi1[index], new Vector3(transform.position.x + 17.77f * n,0,0),Quaternion.identity);
//				}

			}


			break;
		case "t2group":
			if (diff > 15f) {


				Destroy (gameObject);
			}else if (diff >  -10f) {
				int n = Convert.ToInt32(transform.tag);
				generateterrain (n);

			}


			break;
		case "t3groupBig3":

			if (diff > 50f) {

				Destroy (gameObject);
			}else if(diff>21f){
				int n = Convert.ToInt32(transform.tag);
				generateterrain (n);

			}

			break;
		case "t4group":

			if (diff > 15f) {


				Destroy (gameObject);
			}else if (diff >  -10f) {
				int n = Convert.ToInt32(transform.tag);
				generateterrain (n);
			}

			break;
		case "t5group":
			if (diff > 15f) {


				Destroy (gameObject);
			}else if (diff >  -10f) {
				int n = Convert.ToInt32(transform.tag);
				generateterrain (n);

			}

			break;
		case "t6groupBig2":


			if (diff > 32f) {

				Destroy (gameObject);
			} else if (diff > 6f) {
				int n = Convert.ToInt32(transform.tag);
				generateterrain (n);
			}

			break;
		case "t7groupbig4":

			if (diff > 70f) {

				Destroy (gameObject);
			} else if (diff > 42f) {
				int n = Convert.ToInt32(transform.tag);
				generateterrain (n);
			}



			break;
		case "t8groupbig7":

			if (diff > 123f) {

				Destroy (gameObject);
			}else if(diff>95f){
				int n = Convert.ToInt32(transform.tag);
				generateterrain (n);
			}



			break;

		}


	}
   
		
      
       

	


}
