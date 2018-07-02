﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    #region Private Fields

    float smoothFactor = 0.5f;

    Vector3 offset;
    float rotationSpeed = 5f;//0.25f;


    float inputX, inputY;

    #endregion

    #region Unity Messages

    private void Start()
    {
        offset = transform.position;// - cube.position;
    }

    private void Update()
    {

        //if (PlayerController2.Instance.phase == PlayerController2.Phase.WaitingForInput || PlayerController2.Instance.phase == PlayerController2.Phase.Planning)
        //{
            float inputX = 0, inputY = 0;

            //if(Application.isMobilePlatform)
            //{
            if (Input.touchCount == 2 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                inputX = touchDeltaPosition.x;
                inputY = touchDeltaPosition.y;
            }

            //if (Input.GetMouseButton(1))
            //{
            //    inputX = Input.GetAxis("Mouse X") * 16;
            //    inputY = Input.GetAxis("Mouse Y") * 16;
            //}

            //transform.RotateAround(cube)
            //}
            //else
            //    inputX = Input.GetAxis("Mouse X");

            //Quaternion angleX = Quaternion.AngleAxis(inputX * rotationSpeed, Vector3.up);
            //Quaternion angleY = Quaternion.AngleAxis(-inputY * rotationSpeed, Vector3.forward);
            //Quaternion angle = Quaternion.Euler(angleX.eulerAngles.normalized + angleY.eulerAngles.normalized);
            //offset = angle * offset;

            //Vector3 newPos = cube.position + offset;

            //transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);

            //transform.LookAt(cube.position);
            //Debug.Log(Input.touchCount);
            transform.RotateAround(Vector3.zero, Vector3.up, inputX * rotationSpeed * Time.deltaTime);
            transform.RotateAround(Vector3.zero, Vector3.forward, inputY * rotationSpeed * Time.deltaTime);
        //}
        //else
        //{

        //    //transform.RotateAround(Vector3.zero, transform.parent.up, 1);
        //    //transform.RotateAround(Vector3.zero, Vector3.forward, inputY * rotationSpeed * Time.deltaTime);
        //}
        
    }

    #endregion

    #region Methods

    float GetWindowsInputX()
    {
        return 0;
    }

    float GetAndroidInputX()
    {
        return 0;
    }

    #endregion
}
