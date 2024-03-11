using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Transform target;          // Objeto vacío alrededor del cual orbitará la cámara
    public float rotationSpeed = 2.0f;  // Velocidad de rotación de la cámara

    private Vector3 offset;

    void Start()
    {
        if (target != null)
        {
            offset = transform.position - target.position;
        }
    }

    void Update()
    {
        if (target != null)
        {
            // Obtén la nueva posición de la cámara
            Quaternion rotation = Quaternion.Euler(0, Time.time * rotationSpeed, 0);
            transform.position = target.position + rotation * offset;

            // Haz que la cámara mire al objeto vacío (la mesa)
            transform.LookAt(target.position);
        }
    }
}
