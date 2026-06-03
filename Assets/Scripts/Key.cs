using UnityEngine;

public class Key : MonoBehaviour
{
    //public Animator Door;
    public GameObject arm;
    public GameObject WhatInArm;
    //public string WhatInArmTxt;
    
    public void Interact()
    {
        //Door.SetBool("Key", true);
        arm.SetActive(true);
        WhatInArm.SetActive(true);
        Destroy(gameObject);
        
    }


}
