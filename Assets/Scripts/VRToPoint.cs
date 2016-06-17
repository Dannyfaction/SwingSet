using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VRToPoint : MonoBehaviour {

	[SerializeField] GameObject vrTrigger;
	[SerializeField] string levelName;
	[SerializeField] float timeLeft;
	[SerializeField] float resetTime;
	public Button startB;
	public Text timerText;
	private bool test = false;

	CreditsVR activation;

	void Start()
	{
		timerText.enabled = false;
		activation = GetComponent<CreditsVR> ();

	}

	void OnTriggerEnter(Collider col)
	{
		
		if (col.gameObject == vrTrigger) 
		{
			test = true;
			timerText.enabled = true;
			//Debug.Log("Entering The VRBOX");
			StartCoroutine (TimerCountDown());
		}
	}

	IEnumerator TimerCountDown()
	{
		timeLeft = resetTime;

		while(test == true)
		{
			timeLeft -= Time.deltaTime;
			timerText.text = "Time Left: " + Mathf.Round(timeLeft * 10) /10;
			if(timeLeft <= 0 && gameObject.tag == "MainScene")
			{
				SceneManager.LoadScene (levelName);
			}
			else if(timeLeft <= 0 && gameObject.tag == "Credit")
			{
				activation.Activation ();
			}
			else if(timeLeft <= 0 && gameObject.tag == "Back")
			{
				activation.GetBack ();
			}
			yield return new WaitForSeconds (0.01f);
		
		}

	}

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject == vrTrigger) 
		{
			test = false;
			timerText.enabled = false;
			startB.image.color = Color.white;
			timeLeft = resetTime;
			timerText.text = "Time Left: " + timeLeft;
			Debug.Log("Exiting The VRBOX");
			StopCoroutine (TimerCountDown());
		}
	}

}