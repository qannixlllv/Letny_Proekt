using UnityEngine;

public class checkPointSystem : MonoBehaviour
{
    Vector3 checkpointCordinates;
    void Start()
    {
        checkpointCordinates = gameObject.transform.position;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "checkPoint")
        {
            Debug.Log("Чекпоинт сработал:" + col.gameObject.name);
            checkpointCordinates = col.gameObject.transform.position;
        }
        if (col.gameObject.tag == "Death")
        {
            Death();
        }       
    }

    public void Death()
    {
        gameObject.transform.position = checkpointCordinates;
    }  
}
