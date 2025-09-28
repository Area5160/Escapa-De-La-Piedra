using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreenManager : MonoBehaviour
{
    // Esta función cargará de nuevo la escena del juego.
    public void RetryGame()
    {
        // ¡IMPORTANTE! Reemplaza "NombreDeTuEscenaDeJuego" con el nombre
        // exacto de tu escena principal (la de la arena).
        SceneManager.LoadScene("VictoryScreen");
    }

    // ¡NUEVA FUNCIÓN! Esta función cargará la escena del menú principal.
    public void GoToMainMenu()
    {
        // Asegúrate de que tu escena de menú se llame exactamente "MainMenu".
        SceneManager.LoadScene("MainMenu");
    }

    // Esta función cerrará la aplicación.
    public void QuitGame()
    {
        Debug.Log("SALIENDO DEL JUEGO...");
        Application.Quit();
    }
}