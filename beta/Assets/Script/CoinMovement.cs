using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    public float rotationSpeed = 50f; // Скорость вращения
    public float movementSpeed = 2f; // Скорость перемещения вверх-вниз
    public float movementRange = 2f; // Диапазон перемещения вверх-вниз

    private Vector3 startPosition; // Начальная позиция объекта

    void Start()
    {
        startPosition = transform.position; // Сохраняем начальную позицию
    }

    void Update()
    {
        // Вращение объекта
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);

        // Перемещение вверх-вниз
        float movementOffset = movementRange * Mathf.Sin(Time.time * movementSpeed);
        transform.position = startPosition + Vector3.up * movementOffset;
    }
}