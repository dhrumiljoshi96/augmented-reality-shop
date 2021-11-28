using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class table_1 : MonoBehaviour {
	private InstantTrackerController trackerScript;
	private GameObject ButtonsParent;


	// Useing this for initialization
	void Start () {
		trackerScript = GameObject.Find ("Controller").gameObject.GetComponent<InstantTrackerController> ();
		ButtonsParent = GameObject.Find ("Buttons Parent");

		trackerScript._gridRenderer.enabled = false;//false
		ButtonsParent.SetActive (true);//fasle

	}

	void OnEnable(){
		    trackerScript._gridRenderer.enabled = false;//false
			ButtonsParent.SetActive (true);//false

	}

	void OnDisable(){
		ButtonsParent.SetActive (true);	
	}
}