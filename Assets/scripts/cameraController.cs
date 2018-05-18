﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    public GameObject hand;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - hand.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = hand.transform.position + offset;
    }
}
