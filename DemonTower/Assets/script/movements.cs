using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour {

    public float speed = 1.0f;
    public Animator animator;
   
    float xSpeed = 250.0f;
    float ySpeed = 120.0f;
    float yMinLimit = -20;
    float yMaxLimit = 80;
    private float x = 0.0f;
    private float y = 0.0f;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        var angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
    }
    static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
        {
            angle += 360;
        }
        if (angle > 360)
        {
            angle -= 360;
        }
        return Mathf.Clamp(angle, min, max);
    }
    // Update is called once per frame
    void Update()
    {

        //w键前进  
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime), this.gameObject.transform);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //this.gameObject.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime), this.gameObject.transform);
            animator.SetBool("walk", true);
            animator.SetBool("stop", false);          
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("walk", false);
            animator.SetBool("stop", true);
            //this.gameObject.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime), this.gameObject.transform);
        }
        //s键后退  
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.Translate(new Vector3(0, 0, -1 * speed * Time.deltaTime), this.gameObject.transform);
        }
        //a键后退  
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Translate(new Vector3(-1 * speed * Time.deltaTime, 0, 0), this.gameObject.transform);
        }
        //d键后退  
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Translate(new Vector3(Time.deltaTime * speed, 0, 0), this.gameObject.transform);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            this.gameObject.transform.Translate(new Vector3(0, Time.deltaTime * speed, 0), this.gameObject.transform);
        }
        if (Input.GetKey(KeyCode.E))
        {
            this.gameObject.transform.Translate(new Vector3(0, -1 * Time.deltaTime * speed, 0), this.gameObject.transform);
        }
        if (Input.GetMouseButton(1))
        {
            x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
            y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;

            y = ClampAngle(y, yMinLimit, yMaxLimit);

            var rotation = Quaternion.Euler(y, x, 0);
            transform.rotation = rotation;

        }
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("beat");
        }
    }
}
