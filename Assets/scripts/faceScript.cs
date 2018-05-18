using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceScript : MonoBehaviour {

    public PickUpController objName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /*
    void OnCollisionEnter(Collision obj)
    {
        if(obj.gameObject.tag == "Player")
            objName.AddList(gameObject);
    }

    void OnCollisionExit(Collision obj)
    {
        if (obj.gameObject.tag == "Player")
            objName.RemoveList(gameObject);
    }*/
}
