using UnityEngine;

public class RayInteract : MonoBehaviour
{
    public float range = 10f;
    public GameObject InteractText;

    void Update()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;

        RaycastHit hit;


        if(Physics.Raycast(origin, direction, out hit, range))
        {
            if(hit.collider.tag == "Key")
            {
                //Debug.Log("Hit: " + hit.collider.name);
                InteractText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.F))
                {
                    hit.collider.GetComponent<Key>().Interact();
                }
    
            }
            else
            {
                InteractText.SetActive(false);
            }
            //Debug.DrawLine(origin, hit.point, Color.green);
        }
        else
        {
            InteractText.SetActive(false);
        }
        
    }
}
