using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragOnPlane : MonoBehaviour
{
    public float ySpeed = 0.5f;
    public float planeY = 0;
    
    void OnMouseDrag(){
        Plane plane = new Plane(Vector3.up,new Vector3(0, planeY, 0));
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float distance;
        if(plane.Raycast(ray, out distance)) {
            transform.position=ray.GetPoint(distance);
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            planeY -= Input.GetAxis("Mouse ScrollWheel") * ySpeed;
        }
    }
}
