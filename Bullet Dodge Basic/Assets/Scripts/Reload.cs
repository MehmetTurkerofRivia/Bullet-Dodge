using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
