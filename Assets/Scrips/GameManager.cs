using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Gameplay Settings")]
    public int score = 0;
    public int winScore = 500;
    public float timer = 60f;

    [Header("UI References")]
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Update()
    {
        timer -= Time.deltaTime;

        UpdateUI();

        if (timer <= 0)
        {
            LoseGame();
        }
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        timerText.text = "Time: " + Mathf.CeilToInt(timer) + "s";
    }

    public void AddScore(int points)
    {
        score += points;
        if (score >= winScore)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        Debug.Log(" You Win!"); 
        SceneManager.LoadScene("Credit"); // Load next scene
        // You can show a "Win" screen here
    }

    void LoseGame()
    {
        Debug.Log(" Time's Up! You Lose!");
        SceneManager.LoadScene("YouLost"); // Load next scene
        // You can show a "Lose" screen here
    }
}
