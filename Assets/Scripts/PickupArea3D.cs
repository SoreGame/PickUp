using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Добавьте этот namespace для работы с UI

public class PickupArea3D : MonoBehaviour
{
    public List<GameObject> itemsInPickup = new List<GameObject>();
    public Text resultText; // Ссылка на текстовое поле

    private void OnTriggerEnter(Collider other)
    {
       
    }

    public void CheckSolution()
    {
        // Логика проверки решения
        Debug.Log("Проверка решения...");
        resultText.text = "Проверка решения:n"; // Сброс текста перед выводом

        foreach (var item in itemsInPickup)
        {
            Debug.Log(item.name);
            resultText.text += item.name + "n"; // Добавляем имя предмета к результату
        }
    }
}