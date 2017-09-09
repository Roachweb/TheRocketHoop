using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class assOne : MonoBehaviour {



    float mass = 100;
    public float fuel = 50;
    float force = 2000;
    float acceleration = 0;
    float velocity = 0;
    float gravity = -9.81f;
    bool TurnedOn = true;

    Transform tr;

    void Start()
    {
    }
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKeyDown(KeyCode.S))
        {
            TurnedOn = true;
        }

        
        if (TurnedOn && fuel > 0)
        {

            float totalMass = fuel + mass;


            acceleration += (force / totalMass ) * Time.fixedDeltaTime;
            fuel -= Time.fixedDeltaTime * 10;
        }

        acceleration += gravity * Time.fixedDeltaTime;

        transform.position += new Vector3(0, acceleration * Time.fixedDeltaTime, 0);




    }

}
