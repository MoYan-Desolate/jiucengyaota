using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour {

	public GameObject thing;
	public float waitTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(!this.gameObject){
			
		    thing.transform.position = this.transform.position;
		}
	}
}
