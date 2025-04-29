using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    
    // Option Menu
    public GameObject optionPanel;

    // ========== INITIALIZATION ==========
    void Start()
    {
        //TEST
        SetScore(200);
        
        if (optionPanel != null)
            optionPanel.SetActive(false);
    }

    // ========== UI FUNCTIONS ==========

    public void ToggleOptionPanel()
    {
        if (optionPanel != null)
        {
            bool isActive = !optionPanel.activeSelf;
            optionPanel.SetActive(isActive);

            if (isActive)
            {
                Time.timeScale = 0f; 
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        if (optionPanel != null)
            optionPanel.SetActive(false);
    }

    public void MuteGame()
    {
        AudioListener.volume = (AudioListener.volume > 0f) ? 0f : 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1f;
    }
    
    public void MainMenuGame()
    {
        SceneManager.LoadScene("EntryScreen");
    }
    
    public void SetScore(int value)
    {
        if (scoreText != null)
            scoreText.text = "Score: " + value;
    }
    
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
    
}