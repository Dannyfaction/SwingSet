using UnityEngine;
using System.Collections;

public class FollowZAxis : MonoBehaviour {

	[SerializeField] private KinectPointController pointController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x,transform.position.y,pointController.HipCenter.transform.position.z*2f);
	}
}
