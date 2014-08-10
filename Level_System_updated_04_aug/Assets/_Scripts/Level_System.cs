//using UnityEngine;
//using System.Collections;
//
//public class Level_System : MonoBehaviour
//{
//		public GameObject RF, RL, RR;
//		public GameObject[] Prefabs;
//		
//		//public Vector3 origin;
//		int randomNumber = 0;
//		int randomSide = 0;
//		public Vector3 currentPosition; 			//current prefab position
//		public Vector3 currentRotation; 			//current prefab rotation
//	public GameObject start;
//		public GameObject currentPrefab; 			//current prefab (start)
//		public GameObject oldPrefab; 				//old prefab (old)
//		private GameObject selectedPrefab;
//		private float userPosition; 				//user defined postion
//		public int currentType = 0; 				//0 = Front 1 = Left 2 = Right
//		public int nextType; 						//selected prefab type
//
//		// Use this for initialization
//		void Start ()
//		{
//
//				//origin = new Vector3 (0, 0, 0);
//				
//				Prefabs = new GameObject[3];
//				
//				//		Prefabs [0] = Resources.Load ("F:\\FTFL_UNITY_3D\\Level_System-2014-07-20\\Level_System_updated\\Assets\\Resources\\RF.prefab") as GameObject;
//				//		Prefabs [1] = Resources.Load ("F:\\FTFL_UNITY_3D\\Level_System-2014-07-20\\Level_System_updated\\Assets\\Resources\\RL.prefab") as GameObject;
//				//		Prefabs [2] = Resources.Load ("RR.prefab") as GameObject;
//
//				Prefabs [0] = RF;
//				Prefabs [1] = RL;
//				Prefabs [2] = RR;
//
//
//				//int randomNumber = randomNumberGenerator ();
//
//				currentPrefab = (GameObject)Instantiate (start);
//				//currentPrefab.transform.position = Vector3.zero;
//				//currentPrefab.transform.rotation = Quaternion.identity;
//
//
//				currentPosition = currentPrefab.transform.position; 		//set current prefab position
//				currentRotation = currentPrefab.transform.eulerAngles; 		//set current prefab rotation
//		
//				//getLevelType = 1; //defined town
//		
//				currentType = 0; 			//defined front
//		
//				userPosition = 100F; 		//defined
//
//		}
//	
//		// Update is called once per frame
//		void Update ()
//		{
//		
//		}
//
//		void OnTriggerEnter (Collider hit)
//		{
//
//
//				randomNumber = Random.Range (0, Prefabs.Length - 1);
//				randomSide = Random.Range (0, 2);
//
//				selectedPrefab = (GameObject)Instantiate (Prefabs [randomNumber]);
//
//				if (selectedPrefab.activeSelf == false) 
//						selectedPrefab.SetActive (true);
//
//			
//						if (randomNumber == 0 && randomSide == 0) {
////								if (selectedPrefab.activeSelf == false) {
////										//selectedPrefab = (GameObject)Instantiate (Prefabs [randomNumber]);
////
////										RF.SetActive (true);
////										Debug.Log ("F Activated");
////								}
//								nextType = 0;
//						} else if (randomNumber == 1 && randomSide == 1) {
////								if (selectedPrefab.activeSelf == false) {
////										//selectedPrefab = (GameObject)Instantiate (Prefabs [randomNumber]);
////
////										RL.SetActive (true);
////										Debug.Log ("L Activated");
////								}
//								nextType = 1;
//						} else if (randomNumber == 2 && randomSide == 2) {
////								if (selectedPrefab.activeSelf == false) {
////										//selectedPrefab = (GameObject)Instantiate (Prefabs [randomNumber]);
////
////										RR.SetActive (true);
////										Debug.Log ("R Activated");
////								}
//								nextType = 2;
//						}
//				
//
//
//				switch (currentType) {
//			
//
//
//				case 0: //Front
//			
//						if (currentRotation.y == 0F || currentRotation.y == 360F) {
//				
//								selectedPrefab.transform.position = new Vector3 (currentPosition.x, currentPosition.y, currentPosition.z + userPosition);
//				
//								float x = 0F;
//								float y = 0F;
//								float z = 0F;
//								Vector3 rotation = new Vector3 (x, y, z);
//								selectedPrefab.transform.localEulerAngles = rotation;
//						}
//			
//						if (currentRotation.y == 90F) {
//				
//								selectedPrefab.transform.position = new Vector3 (currentPosition.x + userPosition, currentPosition.y, currentPosition.z);
//				
//								float x = 0F;
//								float y = 90F;
//								float z = 0F;
//								Vector3 rotation = new Vector3 (x, y, z);
//								selectedPrefab.transform.localEulerAngles = rotation;
//						}
//			
//						if (currentRotation.y == -90F || currentRotation.y == 270F) {
//				
//								selectedPrefab.transform.position = new Vector3 (currentPosition.x - userPosition, currentPosition.y, currentPosition.z);
//				
//								float x = 0F;
//								float y = -90F;
//								float z = 0F;
//								Vector3 rotation = new Vector3 (x, y, z);
//								selectedPrefab.transform.localEulerAngles = rotation;
//						}
//			
////						if (currentRotation.y == -180F || currentRotation.y == 180F) {
////				
////								selectedPrefab.transform.position = new Vector3 (currentPosition.x, currentPosition.y, currentPosition.z - userPosition);
////				
////								float x = 0F;
////								float y = 180F;
////								float z = 0F;
////								Vector3 rotation = new Vector3 (x, y, z);
////								selectedPrefab.transform.localEulerAngles = rotation;
////						}
//			
//						break;
//			
//				case 1: //Left
//			
//						if (currentRotation.y == 0F || currentRotation.y == 360F) {
//				
//								selectedPrefab.transform.position = new Vector3 (currentPosition.x - userPosition, currentPosition.y, currentPosition.z);
//				
//								float x = 0F;
//								float y = -90F;
//								float z = 0F;
//								Vector3 rotation = new Vector3 (x, y, z);
//								selectedPrefab.transform.localEulerAngles = rotation;
//						}
//			
//						if (currentRotation.y == 90F) {
//				
//								selectedPrefab.transform.position = new Vector3 (currentPosition.x, currentPosition.y, currentPosition.z + userPosition);
//				
//								float x = 0F;
//								float y = 0F;
//								float z = 0F;
//								Vector3 rotation = new Vector3 (x, y, z);
//								selectedPrefab.transform.localEulerAngles = rotation;
//						}
//			
//						if (currentRotation.y == -90F || currentRotation.y == 270F) {
//				
//								selectedPrefab.transform.position = new Vector3 (currentPosition.x, currentPosition.y, currentPosition.z - userPosition);
//				
//								float x = 0F;
//								float y = 180F;
//								float z = 0F;
//								Vector3 rotation = new Vector3 (x, y, z);
//								selectedPrefab.transform.localEulerAngles = rotation;
//						}
//			
////						if (currentRotation.y == -180F || currentRotation.y == 180F) {
////				
////								selectedPrefab.transform.position = new Vector3 (currentPosition.x + userPosition, currentPosition.y, currentPosition.z);
////				
////								float x = 0F;
////								float y = 90F;
////								float z = 0F;
////								Vector3 rotation = new Vector3 (x, y, z);
////								selectedPrefab.transform.localEulerAngles = rotation;
////						}
//			
//						break;
//			
//				case 2: //Right
//			
//						if (currentRotation.y == 0F || currentRotation.y == 360F) {
//				
//								selectedPrefab.transform.position = new Vector3 (currentPosition.x + userPosition, currentPosition.y, currentPosition.z);
//								float x = 0F;
//								float y = 90F;
//								float z = 0F;
//								Vector3 rotation = new Vector3 (x, y, z);
//								selectedPrefab.transform.localEulerAngles = rotation;
//						}
//			
//						if (currentRotation.y == 90F) {
//				
//								selectedPrefab.transform.position = new Vector3 (currentPosition.x, currentPosition.y, currentPosition.z - userPosition);
//				
//								float x = 0F;
//								float y = 180F;
//								float z = 0F;
//								Vector3 rotation = new Vector3 (x, y, z);
//								selectedPrefab.transform.localEulerAngles = rotation;
//						}
//			
//						if (currentRotation.y == -90F || currentRotation.y == 270F) {
//				
//								selectedPrefab.transform.position = new Vector3 (currentPosition.x, currentPosition.y, currentPosition.z + userPosition);
//				
//								float x = 0F;
//								float y = 0F;
//								float z = 0F;
//								Vector3 rotation = new Vector3 (x, y, z);
//								selectedPrefab.transform.localEulerAngles = rotation;
//						}
//			
////						if (currentRotation.y == -180F || currentRotation.y == 180F) {
////				
////								selectedPrefab.transform.position = new Vector3 (currentPosition.x - userPosition, currentPosition.y, currentPosition.z);
////				
////								float x = 0F;
////								float y = -90F;
////								float z = 0F;
////								Vector3 rotation = new Vector3 (x, y, z);
////								selectedPrefab.transform.localEulerAngles = rotation;
////						}
//			
//						break;
//				}
//
//
//
//
//				Debug.Log (nextType);
//		
//				currentType = nextType;
//
//				Deactive ();
//				oldPrefab = currentPrefab;
//
//				currentPrefab = selectedPrefab;
//				currentPosition = selectedPrefab.transform.position;
//
//				currentRotation.x = Mathf.Round (selectedPrefab.transform.eulerAngles.x / 90F) * 90F;
//				currentRotation.y = Mathf.Round (selectedPrefab.transform.eulerAngles.y / 90F) * 90F;
//				currentRotation.z = Mathf.Round (selectedPrefab.transform.eulerAngles.z / 90F) * 90F;
//		
//
//
//
//		
//		}
//		/*Deactive old prefab*/
//		public void Deactive ()
//		{
//				oldPrefab.transform.position = Vector3.zero;
//				oldPrefab.transform.rotation = Quaternion.identity;
//
//				
//				oldPrefab.SetActive (false);		
//
//		}
//
//}




/*
//Hierarchy
	Controller
		LevelController --> Script
//Script Settings
	Set Level Prefabs
	Set Current Prefab
	Set Old Prefab
	Set GetLevelType
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level_System : MonoBehaviour {
	
	public GameObject town; //level prefab
	//public GameObject ruin; //level prefab
	//public GameObject village; //level prefab
	
	public List<GameObject> townFront;
	public List<GameObject> townLeft;
	public List<GameObject> townRight;
	
	private bool getTownList = false; //bool value to retrieve lists(front,left,right) from town
	
	public GameObject currentPrefab; //current prefab (start)
	public GameObject oldPrefab; //old prefab (old)
	private GameObject selectedPrefab;
	
	public bool activeFrontGameobject;
	public bool activeLeftGameobject;
	public bool activeRightGameobject;
	
	public int currentType = 0; //0 = Front 1 = Left 2 = Right
	public int nextType; //selected prefab type
	
	public int randomChangeSide; //randomly change side (front/left/right)
	public int randomChangePrefab; //randomly change prefab
	
	public Vector3 currentPosition; //current prefab position
	public Vector3 currentRotation; //current prefab rotation
	
	private float userPosition; //user defined postion
	
	public int getLevelType; //1 = Town 2 = Ruin 3 = Village
	
	
	// Use this for initialization
	void Start () {
		
		NotificationCenter.DefaultCenter.AddObserver (this, "EnterLevelTrigger"); //trigger enter
		
		currentPosition = currentPrefab.transform.position; //set current prefab position
		currentRotation = currentPrefab.transform.eulerAngles; //set current prefab rotation
		
		getLevelType = 1; //defined town
		
		currentType = 0; //defined front
		
		userPosition = 100F; //defined
	}
	
	// Update is called once per frame
	void Update () {
		
		if (getTownList == false) {
			SetTownList();
		}
		
		//		if (getRuinList == false) {
		//			SetRuinList();
		//		}
		//
		//		if (getVillageList == false) {
		//			SetVillageList();
		//		}
		
	}
	
	/*Randomly select prefab*/
	public void Randomization () {
		
		randomChangePrefab = Random.Range (0, 2);
		randomChangeSide = Random.Range (0, 3);
		
		bool randomFront = true;
		bool randomLeft = true;
		bool randomRight = true;
		
		if (randomChangeSide == 0 && randomFront == true) {
			
			CheckActive (0);
			
			if (activeFrontGameobject == true) {
				
				if (townFront[randomChangePrefab].activeSelf == false) {
					
					selectedPrefab = townFront[randomChangePrefab].gameObject;
					nextType = 0;
				}
				else {
					
					Randomization ();
				}
			}
			
			else {
				
				randomFront = false;
				Randomization ();
			}
		}
		
		else if (randomChangeSide == 1 && randomLeft == true) {
			
			CheckActive (1);
			
			if (activeLeftGameobject == true) {
				
				if (townLeft[randomChangePrefab].activeSelf == false) {
					
					selectedPrefab = townLeft[randomChangePrefab].gameObject;
					nextType = 1;
				}
				else {
					
					Randomization ();
				}
			}
			
			else {
				
				randomLeft = false;
				Randomization ();
			}
		}
		
		else if (randomChangeSide == 2 && randomRight == true) {
			
			CheckActive (2);
			
			if (activeRightGameobject == true) {
				
				if (townRight[randomChangePrefab].activeSelf == false) {
					
					selectedPrefab = townRight[randomChangePrefab].gameObject;
					nextType = 2;
				}
				else {
					
					Randomization ();
				}
			}
			
			else {
				
				randomRight = false;
				Randomization ();
			}
		}
	}
	
	/*Check whether a game object (front/left/right) is active in town*/
	public void CheckActive (int type) {
		
		if (type == 0) {
			
			foreach (GameObject active in townFront) {
				
				if (active.activeSelf == false) {
					
					activeFrontGameobject = true;
					break;
				}
				
				else {
					
					activeFrontGameobject = false;
				}
			}
		}
		
		if (type == 1) {
			
			foreach (GameObject active in townLeft) {
				
				if (active.activeSelf == false) {
					
					activeLeftGameobject = true;
					break;
				}
				
				else {
					
					activeLeftGameobject = false;
				}
			}
		}
		
		
		if (type == 2) {
			
			foreach (GameObject active in townRight) {
				
				if (active.activeSelf == false) {
					
					activeRightGameobject = true;
					break;
				}
				
				else {
					
					activeRightGameobject = false;
				}
			}
		}
		
	}
	
	/*Active waypoints of the selected prefab*/ 
	public void ActiveWayPoints (Transform wayPoints) {
		
		for (int i = 0; i < wayPoints.transform.childCount; ++i)
		{
			for (int j = 0; j < wayPoints.transform.GetChild(i).transform.childCount; ++j) {
				
				wayPoints.transform.GetChild(i).transform.GetChild(j).gameObject.SetActive(true);
			}
		}
	}
	
	
	
	public void EnterLevelTrigger () {
		
		Randomization ();
		
		if (getLevelType == 1) {
			
			selectedPrefab.SetActive(true);
			
			ActiveWayPoints (selectedPrefab.transform);
			
			switch (currentType) {
				
			case 0: //Front
				
				if (currentRotation.y == 0F || currentRotation.y == 360F) {
					
					selectedPrefab.transform.position = new Vector3 (currentPosition.x, currentPosition.y, currentPosition.z + userPosition);
					
					float x = 0F;
					float y = 0F;
					float z	= 0F;
					Vector3 rotation = new Vector3 (x, y, z);
					selectedPrefab.transform.localEulerAngles = rotation;
				}
				
				if (currentRotation.y == 90F) {
					
					selectedPrefab.transform.position = new Vector3 (currentPosition.x + userPosition, currentPosition.y, currentPosition.z);
					
					float x = 0F;
					float y = 90F;
					float z	= 0F;
					Vector3 rotation = new Vector3 (x, y, z);
					selectedPrefab.transform.localEulerAngles = rotation;
				}
				
				if (currentRotation.y == -90F || currentRotation.y == 270F) {
					
					selectedPrefab.transform.position = new Vector3 (currentPosition.x - userPosition, currentPosition.y, currentPosition.z);
					
					float x = 0F;
					float y = -90F;
					float z	= 0F;
					Vector3 rotation = new Vector3 (x, y, z);
					selectedPrefab.transform.localEulerAngles = rotation;
				}
				
				if (currentRotation.y == -180F || currentRotation.y == 180F) {
					
					selectedPrefab.transform.position = new Vector3 (currentPosition.x, currentPosition.y, currentPosition.z - userPosition);
					
					float x = 0F;
					float y = 180F;
					float z	= 0F;
					Vector3 rotation = new Vector3 (x, y, z);
					selectedPrefab.transform.localEulerAngles = rotation;
				}
				
				break;
				
			case 1: //Left
				
				if (currentRotation.y == 0F || currentRotation.y == 360F) {
					
					selectedPrefab.transform.position = new Vector3 (currentPosition.x - userPosition, currentPosition.y, currentPosition.z);
					
					float x = 0F;
					float y = -90F;
					float z	= 0F;
					Vector3 rotation = new Vector3 (x, y, z);
					selectedPrefab.transform.localEulerAngles = rotation;
				}
				
				if (currentRotation.y == 90F) {
					
					selectedPrefab.transform.position = new Vector3 (currentPosition.x, currentPosition.y, currentPosition.z + userPosition);
					
					float x = 0F;
					float y = 0F;
					float z	= 0F;
					Vector3 rotation = new Vector3 (x, y, z);
					selectedPrefab.transform.localEulerAngles = rotation;
				}
				
				if (currentRotation.y == -90F || currentRotation.y == 270F) {
					
					selectedPrefab.transform.position = new Vector3 (currentPosition.x, currentPosition.y, currentPosition.z - userPosition);
					
					float x = 0F;
					float y = 180F;
					float z	= 0F;
					Vector3 rotation = new Vector3 (x, y, z);
					selectedPrefab.transform.localEulerAngles = rotation;
				}
				
				if (currentRotation.y == -180F || currentRotation.y == 180F) {
					
					selectedPrefab.transform.position = new Vector3 (currentPosition.x + userPosition, currentPosition.y, currentPosition.z);
					
					float x = 0F;
					float y = 90F;
					float z	= 0F;
					Vector3 rotation = new Vector3 (x, y, z);
					selectedPrefab.transform.localEulerAngles = rotation;
				}
				
				break;
				
			case 2: //Right
				
				if (currentRotation.y == 0F || currentRotation.y == 360F) {
					
					selectedPrefab.transform.position = new Vector3 (currentPosition.x + userPosition, currentPosition.y, currentPosition.z);
					float x = 0F;
					float y = 90F;
					float z	= 0F;
					Vector3 rotation = new Vector3 (x, y, z);
					selectedPrefab.transform.localEulerAngles = rotation;
				}
				
				if (currentRotation.y == 90F) {
					
					selectedPrefab.transform.position = new Vector3 (currentPosition.x, currentPosition.y, currentPosition.z - userPosition);
					
					float x = 0F;
					float y = 180F;
					float z	= 0F;
					Vector3 rotation = new Vector3 (x, y, z);
					selectedPrefab.transform.localEulerAngles = rotation;
				}
				
				if (currentRotation.y == -90F || currentRotation.y == 270F) {
					
					selectedPrefab.transform.position = new Vector3 (currentPosition.x, currentPosition.y, currentPosition.z + userPosition);
					
					float x = 0F;
					float y = 0F;
					float z	= 0F;
					Vector3 rotation = new Vector3 (x, y, z);
					selectedPrefab.transform.localEulerAngles = rotation;
				}
				
				if (currentRotation.y == -180F || currentRotation.y == 180F) {
					
					selectedPrefab.transform.position = new Vector3 (currentPosition.x - userPosition, currentPosition.y, currentPosition.z);
					
					float x = 0F;
					float y = -90F;
					float z	= 0F;
					Vector3 rotation = new Vector3 (x, y, z);
					selectedPrefab.transform.localEulerAngles = rotation;
				}
				
				break;
			}
			
			currentType = nextType;
			Deactive ();
			oldPrefab = currentPrefab;
			
			currentRotation.x = Mathf.Round(selectedPrefab.transform.eulerAngles.x / 90F) * 90F;
			currentRotation.y = Mathf.Round(selectedPrefab.transform.eulerAngles.y  / 90F) * 90F;
			currentRotation.z = Mathf.Round(selectedPrefab.transform.eulerAngles.z  / 90F) * 90F;
			
			currentPrefab = selectedPrefab;
			currentPosition = selectedPrefab.transform.position;
			
		}
		
	}
	
	/*Deactive old prefab*/
	public void Deactive () {
		
		oldPrefab.transform.position = new Vector3 (0F, 0F, 0F);
		oldPrefab.transform.eulerAngles = Vector3.zero;
		oldPrefab.SetActive (false);
	}
	
	/*Add town prefabs in town list*/
	public void SetTownList () {
		
		foreach (Transform go in town.transform) {
			
			foreach (Transform go2 in go.transform) {
				
				if (go2.gameObject.tag == "Front") {
					
					townFront.Add(go2.gameObject);
				}
				
				if (go2.gameObject.tag == "Left") {
					
					townLeft.Add(go2.gameObject);
				}
				
				if (go2.gameObject.tag == "Right") {
					
					townRight.Add(go2.gameObject);
				}
			}
		}
		
		getTownList = true;
	}
	
	

}
