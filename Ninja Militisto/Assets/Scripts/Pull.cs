﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pull : MonoBehaviour
{

    public SteamVR_TrackedObject controller;

    [HideInInspector]
    public Vector3 prevPos;

    public bool canGrip;

    // Use this for initialization
    void Start()
    {
        prevPos = controller.transform.localPosition;
    }

    private void OnTriggerEnter()
    {
        canGrip = true;
    }

    private void OnTriggerExit()
    {
        canGrip = false;
    }
}