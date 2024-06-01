using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float hareketHizi = 11f;
    private Rigidbody2D rb;
    public static int Score = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float yatayHareket = Input.GetAxis("Horizontal") * hareketHizi;
        float dikeyHareket = Input.GetAxis("Vertical") * hareketHizi;
        rb.velocity = new Vector2(yatayHareket, dikeyHareket);
        Debug.Log(Score);
    }
}
