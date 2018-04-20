using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newmove : MonoBehaviour
{

    private Transform camTrans;
    private Vector3 camAng;
    private float camHeight = 2.2f;
    private float comback = -1f;
    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
        camTrans = Camera.main.transform;
        Vector3 startPos = transform.position;
        startPos.y += camHeight;
        startPos.z += comback;
        camTrans.position = startPos;
        camTrans.rotation = transform.rotation;
        camAng = camTrans.eulerAngles;
        camTrans.LookAt(this.transform.position);
    }

    void Rot_move()
    {
        float y = Input.GetAxis("Mouse X");
        float x = Input.GetAxis("Mouse Y");
        camAng.x -= x;
        camAng.y += y;
        camTrans.eulerAngles = camAng;
        camTrans.position = new Vector3(this.transform.position.x, camTrans.position.y, this.transform.position.z);
        float camy = camAng.y;
        this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, camy, this.transform.eulerAngles.z);
        Vector3 startPos = transform.position;
        startPos.y += camHeight;
        startPos.z += comback;
        camTrans.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        Rot_move();
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * 2f);
        }
    }
}
