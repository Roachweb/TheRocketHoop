using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBall : MonoBehaviour {

    Rigidbody rb;

    GameObject Goal;

    private GameObject reSpawnPoint;

    private bool respawned;

    Transform setPT;

    // Use this for initialization
    void Start () {
        reSpawnPoint = GameObject.FindGameObjectWithTag("reSpawnPoint");

        Goal = GameObject.FindGameObjectWithTag("Goal");

        rb = GetComponent<Rigidbody>();
      
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.M))
        {
            setPT = reSpawnPoint.transform;

            transform.position = setPT.transform.position;
            transform.rotation = reSpawnPoint.transform.rotation;

            rb.MovePosition(setPT.transform.position + transform.up * Time.deltaTime);
        }
        //Debug.Log(transform.position.Set);
	}

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player") 
        {
            
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
            transform.rotation = reSpawnPoint.transform.rotation;
        }
    }
}
