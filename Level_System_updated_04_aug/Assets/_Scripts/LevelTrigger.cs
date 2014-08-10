/*
//Hierarchy
	Player -->Script
//Script Settings
	None
*/

using UnityEngine;
using System.Collections;

public class LevelTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter.PostNotification (this, "EnterLevelTrigger");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//void OnTriggerEnter (Collider coll) {

		//if (coll.gameObject.tag == "Boundary") {

		//}
	//}
}
