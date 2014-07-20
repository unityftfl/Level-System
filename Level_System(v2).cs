using UnityEngine;
using System.Collections;

public class Level_System : MonoBehaviour {
	public GameObject [] Prefabs;
	public GameObject RF,RL,RR;
	// Use this for initialization
	void Start () {
		Prefabs [0] = RF;
		Prefabs [1] = RL;
		Prefabs [2] = RR;

		GameObject obj = (GameObject )Instantiate (Prefabs[Random.Range(0, Prefabs.Length-1)]);
		obj.transform.position = new Vector3 (0, 0, 0);

	}
	
	// Update is called once per frame
	void Update () {
	

	}
}
