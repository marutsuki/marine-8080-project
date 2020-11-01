﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBasic : MonoBehaviour
{
    public LookAtPlayer lp;
    public GameObject projectile;
    public AudioSource se;
    public float timeBetweenShots = 2f;
    public float intDelay = 0.5f;
    private float timer;
    Transform player;
    public Transform shootingOrigin;
    void Start()
    {
        player = lp.player;
        timer = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        if (lp.inRange)
        {
            Debug.Log("fire");
            if (ReadyToFire())
            {
                
                FireProjectile(projectile);
            }
        }
        else
        {
            timer = intDelay;
        }
    }
    public void FireProjectile(GameObject projectile)
    {
        se.Play();
        Vector3 lookDir = (player.position - shootingOrigin.position).normalized;
        Quaternion dir = Quaternion.LookRotation(lookDir);
        //Make sure the projectile travels straight in the x axis
        dir.eulerAngles = new Vector3(dir.eulerAngles.x, lookDir.x > 0 ? 90f : 270f, 0f);
        GameObject proj = Instantiate(projectile, shootingOrigin.position, dir);
        //Set the player attribute of the projectile to player to destroy it when out of range.

        proj.GetComponent<BasicProjectile>().player = player;

    }
    public bool ReadyToFire()
    {
        if (timer <= 0)
        {
            timer = timeBetweenShots;
            return true;
        }
        else
        {
            timer -= Time.deltaTime;
            return false;
        }
    }
}
