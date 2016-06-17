using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour {
	float timer = 0f;

	public GameObject Violin;
	public GameObject RowBoat1;
    public GameObject RowBoat1Parent;
	public GameObject RowBoat2;
    public GameObject RowBoat2Parent;

	public GameObject Clock;
	public GameObject Clock2;
	public GameObject Clock3;



	void Start()
	{
		Violin.SetActive(false);
		RowBoat1Parent.SetActive(false);
		RowBoat2Parent.SetActive(false);

		Clock.SetActive(false);
		Clock2.SetActive(false);
		Clock3.SetActive(false);

	}

	void Update()
	{
		CheckTime();
		timer += Time.deltaTime;
	}

	void CheckTime()
	{
		if(timer > 15 && timer < 17){
			Violin.SetActive(true);
		}

		if(timer > 20 && timer < 22){
            RowBoat1Parent.SetActive(true);
            RowBoat2Parent.SetActive(true);
		}
		if(timer > 25 && timer < 27)
		{
			Clock.SetActive(true);		
			Clock2.SetActive(true);
			Clock3.SetActive(true);
		}
        if (timer > 120)
        {
            //SceneManager.LoadScene("");
        }
	}
}
