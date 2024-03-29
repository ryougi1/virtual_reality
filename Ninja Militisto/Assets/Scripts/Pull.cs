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

    private void OnTriggerEnter(Collider obj)
    {
        if (controller.GetComponent<Pull>().enabled == false)
            return;
        canGrip = true;
    }

    private void OnTriggerExit()
    {
        canGrip = false;
    }
}
