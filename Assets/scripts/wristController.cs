using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pose = Thalmic.Myo.Pose;

public class wristController : MonoBehaviour {

    public GameObject myo = null;
    public float smooth = 5.0f;

    private Pose _lastPose = Pose.Unknown;

    //public Vector3 resetHand;
    // Use this for initialization
    void Start () {

        transform.Rotate(160f,0,0);
       // Quaternion target = Quaternion.Euler(-60.0f, 0, 0);
        // Dampen towards the target rotation
        //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        //resetHand = transform.localEulerAngles;

       // transform.localEulerAngles = resetHand + new Vector3(60.0f, 60.0f, 60.0f);
    }
	
	// Update is called once per frame
	void Update () {
        /*
        ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo>();

        if (thalmicMyo.pose != _lastPose)
        {
            _lastPose = thalmicMyo.pose;

            if (thalmicMyo.pose == Pose.WaveIn)
            {
                transform.localEulerAngles = new Vector3(60.0f, 0.0f, 0.0f);
            }

            else if (thalmicMyo.pose == Pose.WaveOut)
            {
                transform.localEulerAngles = new Vector3(-60.0f, 0.0f, 0.0f);
            }

            //else if (thalmicMyo.pose == Pose.FingersSpread)
            //{
                //transform.localEulerAngles = new Vector3(0.0f, 45.0f, 0.0f);
            //}

            else
            {
                transform.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
            }
        }*/
    }
}
