using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorlock : MonoBehaviour {

	public GameObject people;
	public int prop;
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

			if (Input.GetKeyDown (KeyCode.F)) {

				start = true;
			} 
		}

		if(start && this.transform.position.y<6){

			this.transform.Translate(0, 1 * Time.deltaTime, 0);
		}
	}
}
