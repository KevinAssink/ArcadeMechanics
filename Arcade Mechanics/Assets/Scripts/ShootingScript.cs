﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{

    public Transform GO_FiringPoint;
    public GameObject bulletPrefab;
    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown("Fire1"))
		{
            Shoot();
		}
    }

    void Shoot() 
    {
        Instantiate(bulletPrefab, GO_FiringPoint.position, GO_FiringPoint.rotation);

    }
}