using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed;
    private void Start()
    {
        speed = Random.Range(0.1f, 0.3f);
    }
    void Update()
    {
        bulletmovement();
    }     

    void bulletmovement()
    {
        transform.localPosition -= new Vector3(speed, 0f, 0f);

        if (transform.localPosition.x <= -21)
            Destroy(gameObject);
    }
                            
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("blade"))
        {
            Debug.Log("a");
            Destroy(gameObject);
            Debug.Log("b");
        }

    }

}
