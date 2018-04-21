using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour {
    public Animator animator;
    public Transform transform;
    bool arrived = true;
    float dest_z = 0f;
    float rotation_y = 0f;
    Vector3 origin = new Vector3();
    Vector3 dest = new Vector3();

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        transform = gameObject.GetComponent<Transform>();
    }
  
    // Update is called once per frame
    void Update () {
        walkAround();
        //if(arrived == true)
        //{
        //    transform.Rotate(0, 180, 0);
        //    arrived = false;
        //}
        //Vector3 v = transform.forward;
        //print(v.x + "  " + v.y + "  " + v.z);
        //operation();
    }

    public void operation()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("attack");
        }
        if (Input.GetMouseButtonDown(1))
        {
            animator.SetTrigger("die");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("walk", true);
            animator.SetBool("stop", false);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("walk", false);
            animator.SetBool("stop", true);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 2 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -2, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 2, 0);
        }
    }

    public void walkAround()
    {
        if (arrived == true)
        {
            origin = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
            dest_z = Random.Range(origin.z + 5, origin.z + 15);
            dest = new Vector3(origin.x, origin.y, dest_z);
            print(origin); 
            print(dest);
            arrived = false;
        }

        if (Mathf.Abs(transform.localPosition.z - dest.z) > 2)
        {
            animator.SetBool("walk", true);
            animator.SetBool("stop", false);
            //transform.localPosition = Vector3.Lerp(origin, dest, 2 * Time.deltaTime);
            transform.Translate(0, 0, 2 * Time.deltaTime);
        }
        else
        {
            animator.SetBool("walk", false);
            animator.SetBool("stop", true);
            //new  WaitForSeconds(5);
            rotation_y = Random.Range(135, 225);
            transform.Rotate(0, rotation_y, 0);
            print(rotation_y);
            arrived = true;
        }
           
    }
}

