using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour {

    public GameObject hand;
    PickUpController pickUpController;

    // Use this for initialization
    void Start () {
        pickUpController = GetComponent<PickUpController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "finger")
        {
            pickUpController.touchingFinger = true;
        }
        else if (other.gameObject.tag == "palm")
        {
            pickUpController.touchingPalm = true;
        }
    }
   void OnTriggerExit(Collider other)
   {
       if (other.gameObject.tag == "finger")
       {
           pickUpController.touchingFinger = false;
       }
       else if (other.gameObject.tag == "palm")
       {
           pickUpController.touchingPalm = false;
       }
   }
}
