﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame. Gauranteed to run after update
	void LateUpdate ()
    {
        transform.position = player.transform.position + offset;
	}
}
