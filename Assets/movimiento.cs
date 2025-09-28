using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Sensibilidad del mouse, la puedes ajustar desde el Inspector.
    public float mouseSensitivity = 100f;

    // Referencia al Transform de tu personaje para poder rotarlo.
    public Transform playerBody;

    // Variable para almacenar la rotación en el eje X (vertical).
    private float xRotation = 0f;

    // El método Start se llama una vez al inicio del juego.
    void Start()
    {
        // Bloquea el cursor en el centro de la pantalla y lo hace invisible.
        // Presiona 'Esc' para liberarlo mientras juegas en el editor.
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // El método Update se llama en cada frame.
    void Update()
    {
        // 1. Obtener el input del mouse.
        // Multiplicamos por la sensibilidad y Time.deltaTime para que sea fluido e independiente de los FPS.
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // 2. Rotación vertical (arriba y abajo).
        // Restamos mouseY para que el movimiento no sea invertido.
        xRotation -= mouseY;
        
        // Ponemos un límite a la rotación vertical para no poder dar una vuelta completa.
        // Generalmente entre -90 (mirar al suelo) y 90 (mirar al cielo) grados.
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Aplicamos la rotación vertical solo a la cámara.
        // Usamos Quaternion.Euler para crear una rotación a partir de un ángulo.
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // 3. Rotación horizontal (izquierda y derecha).
        // Aplicamos esta rotación a todo el cuerpo del personaje.
        playerBody.Rotate(Vector3.up * mouseX);
    }
}