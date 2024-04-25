using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
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
}
