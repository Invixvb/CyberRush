using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public void MainMenuEnd()
    {
        SceneManager.LoadScene("MenuScreen");
    }

    public void QuitGameEnd()
    {
        Application.Quit();
    }
}