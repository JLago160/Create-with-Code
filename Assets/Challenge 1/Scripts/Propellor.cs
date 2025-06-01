using UnityEngine;

public class Propellor : MonoBehaviour
{
    public float rotationSpeed = 100.0f;

    void Update()
    {
        // Gira a hélice no eixo Z (ajuste se necessário)
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}