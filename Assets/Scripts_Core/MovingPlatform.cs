using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        col.transform.parent = gameObject.transform;
    }
    void OnCollisionExit(Collision col)
    {
        col.transform.parent = null;
    }
}
