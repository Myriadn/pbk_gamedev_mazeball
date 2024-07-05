using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGameOver : MonoBehaviour
{
    public void ClickButton()
    {
        SceneManager.LoadScene("Maze");
    }
    public void ClickMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
