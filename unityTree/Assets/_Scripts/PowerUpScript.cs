﻿using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

    HUDScript hud;

    void OnTriggerEnter2D(Collider2D other)
    //void OnCollissionExit2D(Collider2D other)
    {
        if(other.tag =="Player")
        {
            hud = GameObject.Find("Main Camera").GetComponent<HUDScript>();
            hud.IncreaseScore(100);
            //Destroy(this.gameObject);
        }
    }
}
