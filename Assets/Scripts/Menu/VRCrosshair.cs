using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VRCrosshair : MonoBehaviour {

	[SerializeField] private Transform crosshair;
	[SerializeField] private Vector3 offset;

	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector3 (crosshair.position.x + offset.x, crosshair.position.y + offset.y, offset.z);
	}
}
