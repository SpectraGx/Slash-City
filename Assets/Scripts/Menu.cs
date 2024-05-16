using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{
    public Toggle toggle;
    public GameObject mainMenu, optionsMenu;
    public GameObject mainFirstButton, loadFirstButton, optionsFirstButton;

    private void Start()
    {
        if (Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
            Debug.Log("Windows");
        }
    }
    public void Play(string name)
    {
        SceneManager.LoadScene (name);
        Debug.Log("Jugar: " + name);
    }

    public void Exit()
    {
        Debug.Log("Salir");
        Application.Quit();
    }

    public void FullScreen(bool screenBool)
    {
        Screen.fullScreen = screenBool;
        if (Screen.fullScreen)
        {
            Debug.Log("Full Screen");
        }
    }

    public void OpenOptions(){
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsFirstButton);
    }

    public void BackOptions(){
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(mainFirstButton);
    }
}
