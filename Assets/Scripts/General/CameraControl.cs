using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Синхронизирует позицию камеры с позицией Y
// целевого объекта, соблюдая некоторые ограничения.
public class CameraControl : MonoBehaviour
{
    // Целевой объект, с позицией Y которого будет
    // синхронизироваться положение камеры.
    public Transform target;

    // Скорость следования за целевым объектом.
    public float followSpeed = 0.5f;
    // Определяет положение камеры после установки
    // позиций всех объектов

    //private void Update()
    //{
    //    if (Input.touchCount < 1)
    //    {
    //        Move.Amove = 0;
    //    }
    //}


    void LateUpdate()
    {
        // Если целевой объект определен...
        if (target != null)
        {
            // Получить его позицию
            Vector3 newPosition = this.transform.position;
            // Определить, где камера должна находиться
            newPosition.y = Mathf.Lerp(newPosition.y,
            target.position.y, followSpeed);
            newPosition.x = Mathf.Lerp(newPosition.x,
        target.position.x, followSpeed);

            // Обновить местоположение
            transform.position = newPosition;
        }
    }



}