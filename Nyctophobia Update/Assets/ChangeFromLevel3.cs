using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFromLevel3 : ChangeLevel
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //ChangeLevel.setLevel(3);
        GameOver();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
