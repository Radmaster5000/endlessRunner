using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour {

    public Rigidbody rb;
    public float[] xPos;
    int xPosIndex = 1;
    public float speed = 5f;
    public float floorHeight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            MoveLeft();
        if (Input.GetKeyDown(KeyCode.RightArrow))
            MoveRight();

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(xPos[xPosIndex], floorHeight, transform.position.z), Time.deltaTime * speed) + (transform.forward * speed * Time.fixedDeltaTime);
        //Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        //rb.MovePosition(rb.position + forwardMove + transform.position);
	}

    void MoveLeft () {

        xPosIndex--;
        if (xPosIndex < 0)
            xPosIndex = 0;
    }

    void MoveRight () {

        xPosIndex++;
        if (xPosIndex > xPos.Length - 1)
            xPosIndex = xPos.Length - 1;
    }
}
