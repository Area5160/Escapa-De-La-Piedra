using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Play()
    {
        
        SceneManager.LoadScene("rock");
    }

    public void Quit()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}