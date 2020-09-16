using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class ViveInput : MonoBehaviour
{
    public SteamVR_Action_Single squeezeAction = SteamVR_Input.GetAction<SteamVR_Action_Single>("Squeeze", true);
    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Input.GetStateDown("default", "Teleport", SteamVR_Input_Sources.Any, true))
        {
            Debug.Log("Teleport button pressed");
        }
        if (SteamVR_Input.GetStateUp("default", "GrabPinch", SteamVR_Input_Sources.Any, true))
        {
            Debug.Log("Pinch button pressed");
        }
        float triggerValue = squeezeAction.GetAxis(SteamVR_Input_Sources.Any);
        if(triggerValue > 0.0f)
        {
            Debug.Log(triggerValue);
        }
    }
}