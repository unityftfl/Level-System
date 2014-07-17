using UnityEngine;
using System.Collections;

public class Level_System : MonoBehaviour {
	public GameObject RF;
	// Use this for initialization
	void Start () {
		GameObject obj = (GameObject)Instantiate(RF);
		obj.transform.position = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
