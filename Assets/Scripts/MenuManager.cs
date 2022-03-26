using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject credits;

    private void Awake()
    {
        CloseCredits();
    }

    public void OpenCredits()
    {
        credits.gameObject.SetActive(true);
        menu.gameObject.SetActive(false);
    }
    public void CloseCredits()
    {
        credits.gameObject.SetActive(false);
        menu.gameObject.SetActive(true);
    }

    public static void LoadGameScene()
    {
        SceneManager.LoadScene((int)General.SceneName.Game);
    }

    public static void CloseGame()
    {
        Application.Quit();
    }

}
