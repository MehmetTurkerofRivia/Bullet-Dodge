using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MenuCodes : MonoBehaviour
{
    [SerializeField] GameObject text;      
    void Update()
    {
        text.transform.position = Vector3.MoveTowards(text.transform.position, new Vector3());
    }
}
