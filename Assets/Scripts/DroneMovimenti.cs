using UnityEngine;

public class DroneMovimenti : MonoBehaviour
{
    public float velocita = 15f;
    public float sensibilitaMouse = 2f;
    
    float rotazioneX = 0;
    float rotazioneY = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direzione = new Vector3(h, 0, v);
        transform.Translate(direzione * velocita * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X") * sensibilitaMouse;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilitaMouse;
        
        rotazioneY += mouseX;
        rotazioneX -= mouseY;
        rotazioneX = Mathf.Clamp(rotazioneX, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(rotazioneX, rotazioneY, 0);
    }
}