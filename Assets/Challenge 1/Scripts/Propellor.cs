using UnityEngine;

public class Propellor : MonoBehaviour
{
    public float rotationSpeed = 100.0f;

    void Update()
    {
        // Gira a h�lice no eixo Z (ajuste se necess�rio)
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}