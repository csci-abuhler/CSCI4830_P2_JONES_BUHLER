using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public void GameOver()
    {
        return;
        //this is where we'd display survey I guess
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Level1");
    }

    // Start is called before the first frame update
    void Start()
    {
        
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
