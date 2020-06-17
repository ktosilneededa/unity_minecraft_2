using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public InputAction gameExit;
    public InputAction gameRestart;

    private void OnEnable()
    {
        gameRestart.Enable();
        gameExit.Enable();
    }

    private void OnDisable()
    {
        gameRestart.Disable();
        gameExit.Disable();
    }

    void Update()
    {
        if (gameRestart.triggered)
        {
            RestartGame();
        }

        if (gameExit.triggered)
        {
            ExitGame();
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    void ExitGame()
    {
        Application.Quit();
    }
}