using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float TranslateXSpeed = 2;
    public float TranslateYSpeed = 2;
    public float TranslateZSpeed = 2;
    public float RotateXSpeed = 30;
    public float RotateYSpeed = 30;
    
    public float MaxXCoord = 5;
    public float MinXCoord = -5;
    public float MaxYCoord = 5;
    public float MinYCoord = -5;
    public float MaxZCoord = 5;
    public float MinZCoord = -5;


    // Update is called once per frame
    void Update () 
    {
        //Debug.Log(transform.forward * 360);
        if (Math.Abs(Input.GetAxis("Horizontal")) > 0.1 )    // move horiz
        {
            transform.Translate(Input.GetAxis("Horizontal") * Time.unscaledDeltaTime * TranslateXSpeed * Vector3.right);
        }
        if (Math.Abs(Input.GetAxis("Vertical")) > 0.1)    // move vert
        {
            transform.Translate(Input.GetAxis("Vertical") * Time.unscaledDeltaTime * TranslateYSpeed * Vector3.forward);
        }
        if (Math.Abs(Input.GetAxis("Fordinal")) > 0.1)    // move forw
        {
            transform.Translate(Input.GetAxis("Fordinal") * Time.unscaledDeltaTime * TranslateZSpeed * Vector3.up);
        }
        
        transform.position = new Vector3 (Mathf.Clamp(transform.position.x, MinXCoord, MaxXCoord), Mathf.Clamp(transform.position.y, MinYCoord, MaxYCoord), Mathf.Clamp(transform.position.z, MinZCoord, MaxZCoord));
        
        if (Input.GetMouseButton(1))    // rotate
        {
            if (Math.Abs(Input.GetAxis("Mouse X")) > 0.1)    // rotate horiz
            {
                transform.Rotate(Input.GetAxis("Mouse X") * RotateXSpeed  * Time.unscaledDeltaTime * Vector3.up, Space.World);
            }
            if (Math.Abs(Input.GetAxis("Mouse Y")) > 0.1)    // rotate vert
            {
                transform.Rotate(Input.GetAxis("Mouse Y") * RotateYSpeed  * Time.unscaledDeltaTime * Vector3.left, Space.World);
            }

            Vector3 v = transform.rotation.eulerAngles;        // fix z angle
            transform.rotation = Quaternion.Euler(v.x, v.y, 0);
        }
    }
}
