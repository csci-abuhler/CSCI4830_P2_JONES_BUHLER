using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class FlashlightOptions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		GameObject light = GameObject.Find("Flashlight");
		//Debug.Log(light.GetComponent("WhiteLight"));

    }
}
