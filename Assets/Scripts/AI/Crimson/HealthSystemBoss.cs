﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystemBoss : MonoBehaviour
{
    public float maxHp = 100f;
    public float currentHp;
    public SkinnedMeshRenderer meshRenderer;
    public Animator anim;
    BossMovement bm;
    BossAttacks at;
    public AudioSource hitsound;
    public GameObject deathparticle;
    public BossEnding be;
    public PlayerHealth ph;
    Color originalColor;
    public int type;
    float fAtt;
    public float ambientAmp = 4f;
    float difficulty;
    // Start is called before the first frame update
    void Start()
    {
        originalColor = meshRenderer.material.GetVector("_SurfaceColor");
        fAtt = meshRenderer.material.GetFloat("_Ka");
        currentHp = maxHp;
        bm = this.GetComponent<BossMovement>();
        at = this.GetComponent<BossAttacks>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckHealth();
    }
    public void Damage(float damage)
    {
        //Method for taking damage
        hitsound.Play();
        currentHp -= damage;
        Flash();
        Invoke("ResetColor", 0.1f);
    }
    void CheckHealth()
    {
        if (currentHp <= 0f)
        {
            //Boss dies
            ph.enabled = false;
            anim.SetTrigger("Die");
            Debug.Log("destroyed");
            bm.enabled = false;
            at.enabled = false;
            this.GetComponent<CapsuleCollider>().enabled = false;
            this.GetComponent<Rigidbody>().useGravity = false;
            Decay();
        }
    }
    void Flash()
    {
        //Flash bright red
        meshRenderer.material.SetVector("_SurfaceColor", Color.red);
        meshRenderer.material.SetFloat("_Ka", ambientAmp);
    }
    void ResetColor()
    {
        //Reset mesh color
        meshRenderer.material.SetVector("_SurfaceColor", originalColor);
        meshRenderer.material.SetFloat("_Ka", fAtt);
    }
    void Decay()
    {
        Invoke("Explode", 5f);
        Destroy(this.gameObject, 5f);
        be.enabled = true;
    }
    void Explode()
    {
        Instantiate(deathparticle, (this.transform.position - new Vector3(0f, 5f, 0f)), Quaternion.identity);
    }
}
