using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    [SerializeField] private string LoadScene;
    [SerializeField] private string LoadScene2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(LoadScene);
        }

    }

    public void restart()
    {
        SceneManager.LoadScene(LoadScene);
    }   
    public void menu()
    {
        SceneManager.LoadScene(LoadScene2);
    }   
    public void quit()
    {
        Application.Quit();
    }

}
