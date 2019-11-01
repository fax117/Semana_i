using UnityEngine;
using UnityEngine.Networking;

[System.Obsolete]
public class PlayerSU : NetworkBehaviour
{
    public Behaviour[] componentsToDisable;
    //Camera sceneCamera;
    void Start()
    {
        if (!isLocalPlayer)
        {
            for (int i = 0; i < componentsToDisable.Length; i++)
                componentsToDisable[i].enabled = false;
        }
        /*else
        {
            sceneCamera = Camera.main;

            if (sceneCamera != null)
            {
                sceneCamera.gameObject.SetActive(false);
            }
        }*/

    }

    /*private void OnDisable()
    {
        if (sceneCamera != null)
        {
            sceneCamera.gameObject.SetActive(true);
        }
    }*/
}