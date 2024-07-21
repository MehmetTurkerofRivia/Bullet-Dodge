using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    [SerializeField] GameObject deathPanel;
    [SerializeField] GameObject gameScreen;
    public void Death()
    {
        deathPanel.SetActive(true);
        gameScreen.SetActive(false);
        Time.timeScale = 0;
    }
    public void ReloadCurrentScene()
    {
        Time.timeScale = 1;        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Character.Score = 0;
    }
}
