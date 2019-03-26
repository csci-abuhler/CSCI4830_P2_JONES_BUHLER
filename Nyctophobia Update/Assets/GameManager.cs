using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public float levelStartDelay = 2f;


	private float timeToComplete = 1f;
	private Text levelText;
	private GameObject levelImage;
	private int level = 0;
	private bool doingSetup;


	private void Awake()
	{
		
	}
	
	void OnLevelWasLoaded(int index)
	{
		level++;

		InitGame();
	}

	void InitGame()
	{
		doingSetup = true;

		levelImage = GameObject.Find("LevelImage");

		levelText = GameObject.Find("LevelText").GetComponent<Text>();		

		if(level == 0)
		{
			levelText.text = "Tutorial";

			levelImage.SetActive(true);

			Invoke("HideLevelImage", levelStartDelay);

			SceneManager.LoadScene("Tutorial");
		}
		else if(level == 1)
		{
			levelText.text = "Level " + level;

			levelImage.SetActive(true);

			Invoke("HideLevelImage", levelStartDelay);

			SceneManager.LoadScene("Level1");
		}
		else if(level == 2)
		{
			levelText.text = "Level " + level;

			levelImage.SetActive(true);

			Invoke("HideLevelImage", levelStartDelay);

			SceneManager.LoadScene("Level2");
		}
		else if(level == 3)
		{
			levelText.text = "Level " + level;

			levelImage.SetActive(true);

			Invoke("HideLevelImage", levelStartDelay);

			SceneManager.LoadScene("Level3");
		}
		else
		{
			GameOver();
		}
	}


	void HideLevelImage()
	{
		levelImage.SetActive(false);

		doingSetup = false;
	}

	void GameOver()
	{
		levelText.text = "It took you " + timeToComplete + "minutes to complete";
		levelImage.SetActive(true);
		enabled = false;
	}



	// Start is called before the first frame update
	void Start()
    {
		InitGame();
    }

    // Update is called once per frame
    void Update()
    {
		if (doingSetup)
		{
			return;
		}
    }
}
