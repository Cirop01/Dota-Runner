using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticMovement : MonoBehaviour
{
    public float speed = 5f; // Скорость движения объекта
    public Vector3 endPosition; // Конечная позиция

    private Vector3 startPosition; // Начальная позиция объекта
    private Vector3 currentDirection; // Текущее направление движения

    void Start()
    {
        startPosition = transform.position; // Сохраняем начальную позицию
        currentDirection = transform.forward; // Начальное направление движения - вперед
    }

    void Update()
    {
        // Перемещаем объект
        transform.position += currentDirection * speed * Time.deltaTime;

        // Проверяем достижение конечной позиции
        if (Vector3.Distance(transform.position, endPosition) < 0.1f)
        {
            currentDirection = -currentDirection; // Меняем направление на обратное
            transform.Rotate(Vector3.up, 180f); // Разворачиваем объект на 180 градусов
        }
        // Проверяем достижение начальной позиции
        else if (Vector3.Distance(transform.position, startPosition) < 0.1f)
        {
            currentDirection = -currentDirection; // Меняем направление на обратное
            transform.Rotate(Vector3.up, 180f); // Разворачиваем объект на 180 градусов
        }
    }
}