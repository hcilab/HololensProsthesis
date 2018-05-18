using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour {

    public GameObject parentShape;
    public GameObject hand;

    public float animState;
    public bool attached = false;
    public bool touchingFinger = false;
    public bool touchingPalm = false;

    private HandAnimatorManager handAnimatorManager;

	// Use this for initialization
	void Start () {
        handAnimatorManager = hand.GetComponent<HandAnimatorManager>();
    }
	
	// Update is called once per frame
	void Update () {

       //handAnimatorManager.isAttached = attached;
       
       if (IsPickedUp() && !attached)
        {
            attached = true;
            parentShape.GetComponent<Rigidbody>().isKinematic = true;
            parentShape.transform.parent = hand.transform;
            handAnimatorManager.isAttached = true;
        }

		else if (!IsPickedUp() && attached)
        {
            attached = false;
            parentShape.GetComponent<Rigidbody>().isKinematic = false;
            parentShape.transform.parent = null;
            handAnimatorManager.isAttached = false;
        }
	}

    private bool IsPickedUp()
    {
        return (touchingFinger && touchingPalm);
    }
}
