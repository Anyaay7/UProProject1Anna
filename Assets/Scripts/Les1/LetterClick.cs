using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterClick : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//Создаем луч из камеры по позиции мыщки

            if (Physics.Raycast(ray, out RaycastHit hit))//Запускаем луч и проверяем попал ли он
                if (hit.collider.GetComponent<ILetter>() != null)//Проверяем есть ли интерфейс ILetter
                    hit.collider.GetComponent<ILetter>().Click();//Вызываем метод Click ILetter
        }
    }
}
