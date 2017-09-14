﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private float speed = 10;
    private bool forward = false;
    private bool backward = false;
    private bool left = false;
    private bool right = false;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        var position = transform.position;
        if (Input.GetKeyDown("w"))
        {
            forward = true;
        }
        else if (Input.GetKeyUp("w"))
        {
            forward = false;
        }
        if (Input.GetKeyDown("s"))
        {
            backward = true;
        }
        else if (Input.GetKeyUp("s"))
        {
            backward = false;
        }
        if (Input.GetKeyDown("a"))
        {
            left = true;
        }
        else if (Input.GetKeyUp("a"))
        {
            left = false;
        }
        if (Input.GetKeyDown("d"))
        {
            right = true;
        }
        else if (Input.GetKeyUp("d"))
        {
            right = false;
        }
        if (forward)
        {
            position.x += (speed * Time.deltaTime);
        }
        if (backward)
        {
            position.x -= (speed * Time.deltaTime);
        }
        if (left)
        {
            position.z += (speed * Time.deltaTime);
        }
        if (right)
        {
            position.z -= (speed * Time.deltaTime);
        }
        transform.position = position;
    }
}