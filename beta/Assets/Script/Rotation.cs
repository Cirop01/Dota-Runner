using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 50f; // Скорость вращения (градусы в секунду)
    public Vector3 rotationAxis = Vector3.up; // Ось вращения (по умолчанию ось Y)

    void Update()
    {
        // Вращаем объект вокруг указанной оси на угол, зависящий от времени
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}