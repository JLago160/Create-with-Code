using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 6.0f;
    public float pitchSpeed = 50.0f; // Velocidade de inclinação (pitch)

    private float verticalInput;

    void Update()
    {
        // Avião sempre se move para frente
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Captura o input vertical (setas cima/baixo ou W/S)
        verticalInput = Input.GetAxis("Vertical");

        // Inclina o avião (pitch) somente quando há input
        if (Mathf.Abs(verticalInput) > 0.01f)
        {
            transform.Rotate(Vector3.right * pitchSpeed * verticalInput * Time.deltaTime);
        }
    }
}