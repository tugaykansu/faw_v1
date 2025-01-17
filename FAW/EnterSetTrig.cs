﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterSetTrig : MonoBehaviour
{
    public GameObject go;
    public string trig;

    private Animator anim;
    
    void Start()
    {
        anim = go.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger(trig);
    }
}
