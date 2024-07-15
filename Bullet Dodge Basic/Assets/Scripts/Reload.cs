using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    [SerializeField] GameObject deathPanel;
    [SerializeField] GameObject mainScene;
    public void Death()
    {
        Time.timeScale = 0;
        deathPanel.SetActive(true);
        mainScene.SetActive(false);
    }
}
