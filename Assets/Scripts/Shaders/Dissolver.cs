using UnityEngine;
using System.Collections;

public class Dissolver : MonoBehaviour {

	float floatValue = 1f;
	private MeshRenderer meshR;
	public bool isSpawning = false;

	void Start()
	{
		//gameObject.SetActive(false);
	}

	// Use this for initialization
	void OnEnable() {
		StartCoroutine(ChangeIntensity());
	}
				
	IEnumerator ChangeIntensity()
	{
		isSpawning = true;

		while(true)
		{
			if(isSpawning){
				floatValue -= 0.01f;
			}
				
			GetObj();
			yield return new WaitForFixedUpdate();
		}
	}

	void GetObj()
	{
		meshR = gameObject.GetComponent<MeshRenderer>();

		for (int i = 0; i < meshR.materials.Length ; i++) {
			meshR.materials[i].SetFloat("_DissolveIntensity", floatValue);
		}
	}
}
