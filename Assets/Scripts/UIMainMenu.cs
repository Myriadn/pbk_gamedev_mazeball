using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainMenu : MonoBehaviour
{
    public void ClickButton()
    {
        SceneManager.LoadScene("Maze");
    }
    public void ClickMenu()
    {
        Application.Quit();
    }
}
