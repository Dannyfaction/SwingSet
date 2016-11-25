using UnityEngine;
using System.Collections;

public class CreditsVR : MonoBehaviour {

	[SerializeField] GameObject credits;
	[SerializeField] GameObject main;
	[SerializeField] GameObject startButton;
	[SerializeField] GameObject creditsButton;
	[SerializeField] GameObject backButton;

	public bool settrue = false;

	// Use this for initialization
	void Start () {
		settrue = false;
		credits.SetActive (false);
		backButton.SetActive (false);
	}

	public void Activation()
	{
		settrue = true;
		main.SetActive (false);
		credits.SetActive (true);
		startButton.SetActive (false);
		creditsButton.SetActive (false);
		backButton.SetActive (true);

	}

	public void GetBack()
	{
		settrue = true;
		main.SetActive (true);
		credits.SetActive (false);
		startButton.SetActive (true);
		creditsButton.SetActive (true);
		backButton.SetActive (false);
	}
}
