using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

	public Transform people;
	public float speed;
	Animator animator;

	// Use this for initialization
	void Start () {
		
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
		this.transform.LookAt(new Vector3(people.position.x, 0, people.position.z));

		if( ( (people.transform.position.x - this.transform.position.x)*(people.transform.position.x - this.transform.position.x) 
			+ (people.transform.position.z - this.transform.position.z)*(people.transform.position.z - this.transform.position.z) )
			>= 10.0f
		){
			
			animator.SetBool("walk", true);
			animator.SetBool("stop", false);
			this.gameObject.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime), this.gameObject.transform);
		} else {

			animator.SetBool("walk", false);
			animator.SetBool("stop", true);
		}
	}
}
