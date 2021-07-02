using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement2 : MonoBehaviour {


    public Rigidbody rb;
    public float[] xPos;
    int xPosIndex = 1;
    public float speed = 5f;
    public float floorHeight;

    bool alive = true;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!alive) {
            return;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            MoveLeft();
        if (Input.GetKeyDown(KeyCode.RightArrow))
            MoveRight();

        int scoreValue = GameObject.Find("GameManager").GetComponent<GameManager>().score;

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(xPos[xPosIndex], floorHeight, transform.position.z), Time.deltaTime * speed) + (transform.forward * (speed + scoreValue) * Time.fixedDeltaTime);
        //Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        //rb.MovePosition(rb.position + forwardMove + transform.position);
	}

    public void MoveLeft () {

        xPosIndex--;
        if (xPosIndex < 0)
            xPosIndex = 0;
    }

    public void MoveRight () {

        xPosIndex++;
        if (xPosIndex > xPos.Length - 1)
            xPosIndex = xPos.Length - 1;
    }

    public void Die()
    {

        alive = false;
        // Restart the game
        Invoke("Restart", 0.5f);
    }

    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
