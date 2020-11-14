using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaySetTrig : MonoBehaviour
{
    public GameObject go;
    public string trig;

    private Animator anim;
    
    void Start()
    {
        anim = go.GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        anim.SetTrigger(trig);
    }
}
