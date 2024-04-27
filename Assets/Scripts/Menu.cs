using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Toggle toggle;

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
        //SceneManager.LoadScene (name);
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
}
