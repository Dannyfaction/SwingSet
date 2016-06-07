using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    public delegate void SpawnEvent();
    public static event SpawnEvent OnSpawnEvent;

    private float timer;
    private float rotateSpeed = 2.5f;

    private Quaternion rotation;

    private bool isSpawning;

	// Use this for initialization
	void Start () {
        timer = 5f;
	}
	
	// Update is called once per frame
	void Update () {
        rotation = transform.rotation;
        if (timer <= 0)
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed);
        }
        else
        {
            timer -= Time.deltaTime;
        }
        Debug.Log(rotation.eulerAngles.z);
        if (rotation.eulerAngles.z > 90f && !isSpawning) {
            isSpawning = true;
            //OnSpawnEvent();
        }
    }
}
