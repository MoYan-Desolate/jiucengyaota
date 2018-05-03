using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear : MonoBehaviour {

	public GameObject people;
	public GameObject door;
	bool start = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if( ( (people.transform.position.x - this.transform.position.x)*(people.transform.position.x - this.transform.position.x) 
			+ (people.transform.position.z - this.transform.position.z)*(people.transform.position.z - this.transform.position.z) )
			<= 1.0f && start == false
		){

			start = true;
		}

		if(start && door.transform.position.y<6){

			door.transform.Translate(0, 1 * Time.deltaTime, 0);
		}
	}
}
