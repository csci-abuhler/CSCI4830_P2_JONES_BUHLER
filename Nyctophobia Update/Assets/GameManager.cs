﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private int mylevel;
	/*public float levelStartDelay = 2f;


	private float timeToComplete = 1f;
	private Text levelText;
	private GameObject levelImage;
	private int level = 0;
	private bool doingSetup;

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

    */
    void GameOver()
    {
        return;
        //this is where we'd display survey I guess
   
    }


    void OnCollisionEnter(Collision collision)
    {

        Debug.Log("1");
        if (collision.gameObject.name == "Exit")
        {
            Debug.Log("Testing if wall collision is happening");
            if(mylevel == 0)
            {
                mylevel++;
                SceneManager.LoadScene("Level1");
            }
            else if(mylevel == 1)
            {
                mylevel++;
                SceneManager.LoadScene("Level2");
            }
            else
            {
                GameOver();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //InitGame();




    }

    // Update is called once per frame
    void Update()
    {




		/*if (doingSetup)
		{
			return;
		}*/
    }
}
