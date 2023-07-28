using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUIHandler : MonoBehaviour
{
    public GameManager manager;
    public Text HighScoreText;
    private void Awake()
    {
        manager = FindObjectOfType<GameManager>();
    }
    void Start()
    {
        HighScoreText.text = $"HighestScore:{manager.highScore} Player: {manager.bestPlayer}";
    }
}
