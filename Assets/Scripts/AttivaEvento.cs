using UnityEngine;
using UnityEngine.Events; 

public class AttivaEvento : MonoBehaviour
{
    [Header("Cosa succede quando il drone entra?")]
    public UnityEvent eventoAlPassaggio;

    
    private void OnTriggerEnter(Collider other)
    {
    
        if (other.CompareTag("MainCamera"))
        {
            eventoAlPassaggio.Invoke(); 
        }
    }
}
