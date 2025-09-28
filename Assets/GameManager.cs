using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // ¡Añadimos esta línea para manejar escenas!

public class GameManager : MonoBehaviour
{
    // --- Singleton ---
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // --- Fin Singleton ---

    [Header("UI Elements")]
    public TMP_Text scoreText;

    [Header("Game Stats")]
    private int coinsCollected = 0;
    private int totalCoinsInLevel;

    void Start()
    {
        totalCoinsInLevel = GameObject.FindGameObjectsWithTag("Coin").Length;
        UpdateScoreText();
    }

    public void AddCoin()
    {
        coinsCollected++;
        UpdateScoreText();

        // --- ¡NUEVA LÓGICA DE VICTORIA! ---
        // Después de sumar una moneda, comprobamos si hemos alcanzado el objetivo.
        if (coinsCollected >= 23)
        {
            // Si hemos recogido 23 o más monedas, cargamos la escena de victoria.
            Debug.Log("¡Condición de victoria cumplida! Cargando pantalla de victoria...");
            SceneManager.LoadScene("VictoryScreen");
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            int coinsRemaining = totalCoinsInLevel - coinsCollected;
            scoreText.text = "Llevas: " + coinsCollected + " / Faltan: " + coinsRemaining;
        }
    }
}