using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        //Destroy(col.gameObject);
        StartCoroutine(BulletFunction());
    }
    IEnumerator BulletFunction()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
