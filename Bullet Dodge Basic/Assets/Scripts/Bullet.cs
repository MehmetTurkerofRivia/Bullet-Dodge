using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed;
    public static float zaman = 1f;
    private void Start()
    {
        speed = Random.Range(3+(zaman/30), 5 + (zaman / 30));
    }
    void Update()
    {
        zaman += Time.deltaTime;
        bulletmovement();
        Debug.Log("zaman" + zaman);
    }     

    void bulletmovement()
    {
        transform.localPosition -= new Vector3(speed * zaman, 0f, 0f);

        if (transform.localPosition.x <= -21)
            Destroy(gameObject);
    }

}
