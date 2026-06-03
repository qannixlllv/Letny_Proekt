using UnityEngine;

public class SpawnBulet : MonoBehaviour
{
    public GameObject PrefabBulet;
    public float speed = 20f;

    void shoot()
    {
        GameObject InstBulet = Instantiate(PrefabBulet, transform.position, transform.rotation);
        InstBulet.GetComponent<Rigidbody>().linearVelocity = transform.forward * speed;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            shoot();
        }
    }
}
