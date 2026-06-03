using UnityEngine;

public class Test1 : MonoBehaviour
{
    //1.Добавить(обьявить) переменную
    public float number = 1f;
    public GameObject RedColumn;
    public CapsuleCollider Col1;

    //2.Привяравнять (записать) что-то к чему-то
    //number = 8f;

    //3.Вызвать что-то
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RedColumn.transform.position = transform.position;
    }
}
