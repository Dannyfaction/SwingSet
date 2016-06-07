using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

    [SerializeField] private Transform target;
    private float timer;
    private float rotateSpeed = 5f;

	// Use this for initialization
	void Start () {
        timer = 15f;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer <= 0)
        {
            transform.RotateAround(target.position, Vector3.left, rotateSpeed * Time.deltaTime);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
