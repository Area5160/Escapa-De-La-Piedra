using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escena

public class MainMenuManager : MonoBehaviour
{
    // Esta función se llamará desde el botón de "Jugar"
    public void PlayGame()
    {
        // Carga la escena del juego.
        // ¡ASEGÚRATE de que el nombre "NombreDeTuEscenaDeJuego" coincida
        // con el nombre de tu escena de la arena en los Build Settings!
        // O puedes usar el índice: SceneManager.LoadScene(0);
        SceneManager.LoadScene("SampleScene");
    }

    // Esta función se llamará desde el botón de "Salir"
    public void QuitGame()
    {
        // Escribe un mensaje en la consola para saber que funciona en el editor.
        Debug.Log("SALIENDO DEL JUEGO...");

        // Cierra la aplicación.
        // ¡OJO! Esto solo funciona en un juego ya compilado (un .exe),
        // no funcionará en el editor de Unity.
        Application.Quit();
    }
}