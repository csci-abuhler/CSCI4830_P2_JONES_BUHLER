using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeFromLevel2 : ChangeLevel
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //ChangeLevel.setLevel(2);
        //ChangeLevel.mylevel++;
        SceneManager.LoadScene("Level3");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
