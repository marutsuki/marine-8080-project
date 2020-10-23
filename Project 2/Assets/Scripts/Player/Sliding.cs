﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding : MonoBehaviour
{
    LookAtMouse lm;
    Movement mv;
    public AnimationManager am;
    CharacterController cc;
    BoxCollider slidingcollider;
    public float pushStrength = 3f;
    // Start is called before the first frame update
    void Start()
    {
        lm = this.GetComponent<LookAtMouse>();
        mv = this.GetComponent<Movement>();
        cc = this.GetComponent<CharacterController>();
        slidingcollider = this.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (!mv.inAir && ((lm.playerIsRight && mv.velocity.x < -5f) || (!lm.playerIsRight && mv.velocity.x > 5f)))
            {
                Slide();
                am.Slide();
                mv.isSliding = true;
                cc.detectCollisions = false;
                slidingcollider.enabled = true;
                Invoke("GetUp", 1f);
            }
        }

    }
    void Slide()
    {
        mv.maxRestrictSpeedScale = 0.01f;
        mv.recoverDuration = 1f;
        mv.AddVelocity(new Vector3(1, 0, 0) * pushStrength * (lm.playerIsRight ? -1 : 1));
        mv.CeaseControl();
    }
    void GetUp()
    {
        slidingcollider.enabled = false;
        cc.detectCollisions = true;
    }
}