using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement; // ¡Importante! Para poder cambiar de escena.

public class BotAI : MonoBehaviour
{
    // --- Variables ---
    private Transform player;
    private NavMeshAgent agent;

    void Start()
    {
        // Busca al jugador por su etiqueta "Player"
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Lógica para que el bot pueda caerse de la arena
        if (agent.enabled && !agent.isOnNavMesh)
        {
            agent.enabled = false;
            return;
        }

        // Lógica de persecución
        if (agent.enabled && player != null)
        {
            agent.SetDestination(player.position);
        }
    }

    // --- LÓGICA DE GAME OVER ---
    // Esta función se ejecuta una sola vez cuando el bot choca con algo.
    private void OnCollisionEnter(Collision collision)
    {
        // Comprobamos si el objeto con el que chocó es el jugador.
        if (collision.gameObject.CompareTag("Player"))
        {
            // Si es el jugador, cargamos la escena del menú principal.
            SceneManager.LoadScene("menuu");
        }
    }
}