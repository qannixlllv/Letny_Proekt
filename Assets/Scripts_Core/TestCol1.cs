using UnityEngine;

public class TestCol1 : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        
        Debug.Log("Мы пересеклись с:" + col.gameObject.name);
    }
    
}
