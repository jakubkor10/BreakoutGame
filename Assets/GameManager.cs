using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{
    public GameManager Instance;
    public Text HighScoreText;
    public int highScore = 0;
    public string bestPlayer = "";
    public string currentPlayer = "";
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    private void Start()
    {
        LoadPlayerData();
        
    }

    
    [System.Serializable]
    class SaveData
    {
        public int highScore;
        public string bestPlayer;
        public string currentPlayer;
    }
    public void SavePlayerData()
{
    SaveData data = new SaveData();
    data.highScore = highScore;
    data.bestPlayer = bestPlayer;
    data.currentPlayer = currentPlayer;
    string json = JsonUtility.ToJson(data);
    File.WriteAllText(Application.persistentDataPath + "HighScore.json", json);
}
    public void LoadPlayerData()
    {
        string path = Application.persistentDataPath + "HighScore.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            highScore = data.highScore;
            bestPlayer = data.bestPlayer;
            currentPlayer = data.currentPlayer;
        }
      
    }
    public void UpdateHighscore(int score)
    {
        bestPlayer = currentPlayer;
        highScore = score;
    }
}
