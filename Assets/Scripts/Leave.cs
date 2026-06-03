using UnityEngine;

public class Leave : MonoBehaviour
{
    public GameObject player;
    public GameObject whatToLeave;

    public void Interact()
    {
        whatToLeave = player.GetComponent<RayInteract>().WhatInArm3D;
        GameObject objectToLeave = Instantiate(whatToLeave, transform.position, transform.rotation);
        player.GetComponent<RayInteract>().WhatInArm3D = null;
        GameObject.FindWithTag("grabUI").SetActive(false);
        GameObject.FindWithTag("grabUI").SetActive(false);
    }
}
