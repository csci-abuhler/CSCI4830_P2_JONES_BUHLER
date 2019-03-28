using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class FlashlightOptions : MonoBehaviour
{
	public GameObject flashlight;

    // Start is called before the first frame update
    void Start()
    {
        
    }
	
    // Update is called once per frame
    void Update()
    {
		//Debug.Log(OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger));
		if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) != 0)
		{
			Debug.Log(flashlight.transform.position);
		} 
    }
}
