using UnityEngine;
using System.Collections;

public class FollowZAxis : MonoBehaviour {

	[SerializeField] private KinectPointController pointController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(pointController.HipCenter.transform.position.z*1.5f-0.5f);
		transform.position = new Vector3 (transform.position.x,transform.position.y,pointController.HipCenter.transform.position.z*1.5f-0.5f);
	}
}