using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour {

	public GameObject people;
	public int flag;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if( ( (people.transform.position.x - this.transform.position.x)*(people.transform.position.x - this.transform.position.x) 
			+ (people.transform.position.z - this.transform.position.z)*(people.transform.position.z - this.transform.position.z) )
		    <= 1.0f
		){
			
			if (Input.GetKeyDown (KeyCode.F)) {

				switch(flag){
				case 0:
					break;
				case 1:
					break;
				default:
					break;
				}

				Destroy(this.gameObject,1);  
			} 
		}
	}
}
