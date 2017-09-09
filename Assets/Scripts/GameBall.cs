using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBall : MonoBehaviour {

    Rigidbody rb;

    GameObject[] Goal;

    Vector3 datSpin = Vector3.zero;

    private GameObject reSpawnPoint;

    private bool respawned;

    Transform setPT;



    // Use this for initialization
    void Start () {

        reSpawnPoint = GameObject.FindGameObjectWithTag("reSpawnPoint");
        Goal = GameObject.FindGameObjectsWithTag("Goal");

        

        rb = GetComponent<Rigidbody>();
        Vector3 datSpin = new Vector3(0,3,0);
        
        

        respawned = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.M))
        {
            setPT = reSpawnPoint.transform;

            transform.position = setPT.transform.position;

            rb.MovePosition(setPT.transform.position + transform.up * Time.deltaTime);
        }
        //Debug.Log(transform.position.Set);
	}

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player") ///this is where my physics is
        {
            transform.position = Vector3.MoveTowards(transform.position, Goal[Random.Range(0, Goal.Length)].transform.position, 1.5f);
            //Debug.LogWarning("Hit");
            rb.MoveRotation(Quaternion.AngleAxis(30, datSpin));
            //add force explosion
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "goal")
        { 
            Debug.LogWarning("Point Hype");
            
        }  
    }

    void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "goal")
        {
            transform.position = reSpawnPoint.transform.position;
            respawned = true;
        }
    }
}
