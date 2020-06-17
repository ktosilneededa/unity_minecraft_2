using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class StartText : MonoBehaviour
{
    public InputAction gameStart;

    private void OnEnable()
    {
        gameStart.Enable();
    }

    private void OnDisable()
    {
        gameStart.Disable();
    }

    void Update()
    {
        if (gameStart.triggered)
        {
            StartGame();
        }
    }

    void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
