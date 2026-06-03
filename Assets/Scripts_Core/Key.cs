using UnityEngine;

public class Key : MonoBehaviour
{
    public Animator Door;
    
    public void Interact()
    {
        Door.SetBool("Key", true);
    }


}
