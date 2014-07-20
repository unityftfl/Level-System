using UnityEngine;
using System.Collections;
//using System;
public class Level_System : MonoBehaviour {
	public GameObject RF,RL,RR;
	//public Vector3 origin;
	public GameObject[] Prefabs;
	int randomNumber = 0;
	// Use this for initialization
	void Start () {
		Prefabs = new GameObject[3];
		//Debug.Log ("1");
		Prefabs [0] = RF;
		Debug.Log ("2");
		Prefabs [1] = RL;
		//Debug.Log ("3");
		Prefabs [2] = RR;
		//Debug.Log ("4");
		randomNumber = Random.Range (0, Prefabs.Length - 1);
		//Debug.Log (randomNumber.ToString());
		
		GameObject obj = (GameObject )Instantiate (Prefabs[randomNumber]);
		obj.transform.position = new Vector3 (0, 0, 0);

		/*foreach (prefabs in prefab){
			Prefabs = 
		}*/
		

		/*origin = new Vector3 (0, 0, 0);
		GameObject obj = (GameObject)Instantiate(RF);
		obj.transform.position = new Vector3 (0, 0, 0);*/

	}
	
	// Update is called once per frame
	void Update () {

		//DateTime time = DateTime.Now;
		//Debug.Log (String.Format ("{0:0.00}",time.Second));


			/*GameObject obj1 = (GameObject)Instantiate(RL);
			obj1.transform.position = origin + new Vector3(10,0,0);
			obj1.transform.rotation = Quaternion.Euler(0f,0f,-90f);*/


		
	}
}
