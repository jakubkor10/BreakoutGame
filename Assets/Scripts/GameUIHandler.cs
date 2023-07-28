using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUIHandler : MonoBehaviour
{
    public GameManager manager;
    public Text HighScoreText;
    public int currentHighscore;
    private void Awake()
    {
        manager = FindObjectOfType<GameManager>();
    }
    void Start()
    {
        currentHighscore = manager.highScore;
        UpdateHighscore();
    }
    private void Update()
    {
        if (manager.highScore != currentHighscore)
        {
            UpdateHighscore();
        }
    }
    public void UpdateHighscore()
    {
        HighScoreText.text = $"HighestScore:{manager.highScore} Player: {manager.bestPlayer}";
        currentHighscore = manager.highScore;
    }
}
