using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text text;
    private void Update()
    {
        text.text = "Dodged Arrow : " + Character.Score;
    }
}
