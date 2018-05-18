using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VibrationType = Thalmic.Myo.VibrationType;

public class handController : MonoBehaviour {

    public float movementSpeed = 10f;
    public float scrollSpeed = 10f;
    public GameObject myo = null;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(movementSpeed * 1f * Time.deltaTime, 0f, 0f);

        }

        if (Input.GetKey("left"))
        {
            transform.position += new Vector3(movementSpeed * -1f * Time.deltaTime, 0f, 0f);

        }

        if (Input.GetKey("up"))
        {
            transform.position += new Vector3(0f, 0f, movementSpeed * 1f * Time.deltaTime);

        }

        if (Input.GetKey("down"))
        {
            transform.position += new Vector3(0f, 0f, movementSpeed * -1f * Time.deltaTime);

        }

        transform.position += new Vector3(0f, Input.GetAxis("Mouse ScrollWheel") * scrollSpeed * Time.deltaTime, 0f);
        //transform.Translate(new Vector3 (0f, 1f, 0f) * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo>();
        //thalmicMyo.Vibrate(VibrationType.Short);
    }
}
