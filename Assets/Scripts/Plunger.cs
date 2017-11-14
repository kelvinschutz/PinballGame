﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{

    private Vector3 StartPosition;

    void Awake()
    {
        StartPosition = transform.position;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.Space))
	    {
	        transform.position = Vector3.Lerp(
	            transform.position,
	            transform.position + new Vector3(0, 0, 3),
	            Time.deltaTime * 10);
	    }
	    else
	    {
	        transform.position = StartPosition;
	    }

	}
}
