﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
	public Rigidbody Bullet;
	public Transform firePlace;
	private Rigidbody projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
		{
			projectile = Instantiate(Bullet, firePlace.position, transform.rotation);
		}
    }
}
