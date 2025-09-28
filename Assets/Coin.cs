using UnityEngine;

public class Coin : MonoBehaviour
{
    // Esta función se activa automáticamente cuando la moneda detecta
    // que un objeto ha entrado en su Trigger.
    private void OnTriggerEnter(Collider other)
    {
        // 1. Preguntamos si el objeto que entró tiene la etiqueta "Player".
        if (other.CompareTag("Player"))
        {
            // 2. Si es el jugador, buscamos el GameManager y le avisamos que sume una moneda.
            GameManager.instance.AddCoin();

            // 3. La moneda se destruye a sí misma.
            Destroy(gameObject);
        }
    }
}