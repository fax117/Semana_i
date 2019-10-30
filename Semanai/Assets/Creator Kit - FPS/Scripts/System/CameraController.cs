using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraController : NetworkBehaviour {
    void Update()
    {
        if(!isLocalPlayer)
        {
            GetComponent<Camera>().enabled = false;
        }
    }
}
