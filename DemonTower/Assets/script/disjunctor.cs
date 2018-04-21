using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disjunctor : MonoBehaviour {

	public GameObject people;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (((people.transform.position.x - this.transform.position.x) * (people.transform.position.x - this.transform.position.x)
		    + (people.transform.position.z - this.transform.position.z) * (people.transform.position.z - this.transform.position.z))
		    <= 225.0f) {

            GetComponent<Light>().enabled = true;
        } else {

            GetComponent<Light>().enabled = false;
        }
	}
}
