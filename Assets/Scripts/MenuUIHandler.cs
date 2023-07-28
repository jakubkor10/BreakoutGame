using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MenuUIHandler : MonoBehaviour
{
    public GameManager gameManager;
    public InputField inputField;
    private void Start()
    {
        Debug.Log("Name set");
        inputField.text = gameManager.currentPlayer;
    }
    public void ChangePlayerName()
    {
        gameManager.currentPlayer = inputField.text;
        gameManager.SavePlayerData();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
}
