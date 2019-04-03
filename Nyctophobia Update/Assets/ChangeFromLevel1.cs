using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeFromLevel1 : ChangeLevel
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //ChangeLevel.setLevel(1);
        //ChangeLevel.mylevel++;
        SceneManager.LoadScene("Level2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
