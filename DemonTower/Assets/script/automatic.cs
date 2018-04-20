using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automatic : MonoBehaviour {

	public GameObject people;
	public GameObject plant;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (plant) {

			if (this.transform.position.z - people.transform.position.z >= 0) {

				if (((people.transform.position.x - this.transform.position.x) * (people.transform.position.x - this.transform.position.x)
				    + (people.transform.position.z - this.transform.position.z) * (people.transform.position.z - this.transform.position.z))
				    <= 2.0f) {


					if (this.transform.position.y < 6) {

						this.transform.Translate (0, 1 * Time.deltaTime, 0);
					}
				} else {

					if (this.transform.position.y > 2) {

						this.transform.Translate (0, -1 * Time.deltaTime, 0);
					}
				}
			} else {

				if (this.transform.position.y > 2) {

					this.transform.Translate (0, -1 * Time.deltaTime, 0);
				}
			}
		} else {

			if (((people.transform.position.x - this.transform.position.x) * (people.transform.position.x - this.transform.position.x)
			    + (people.transform.position.z - this.transform.position.z) * (people.transform.position.z - this.transform.position.z))
			    <= 2.0f) {

				if (this.transform.position.y < 6) {

					this.transform.Translate (0, 1 * Time.deltaTime, 0);
				}
			} else {

				if (this.transform.position.y > 2) {

					this.transform.Translate (0, -1 * Time.deltaTime, 0);
				}
			}
		}

	}
}
