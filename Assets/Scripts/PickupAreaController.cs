using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PickupAreaController : MonoBehaviour
{
    [SerializeField]
    private int targetItems = 9;
    public List<GameObject> itemsInPickup = new List<GameObject>();
    public TMP_Text resultText;

    private void Start()
    {
        UpdateUIMassage();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DraggableItem"))
        {
            itemsInPickup.Add(other.gameObject);
            UpdateUIMassage();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("DraggableItem"))
        {
            itemsInPickup.Remove(other.gameObject);
            UpdateUIMassage();
        }
    }

    private void UpdateUIMassage() 
    {
        resultText.text = "Осталось положить предметов: " + (9-itemsInPickup.Count).ToString();
    }

    public int GetCountItemsInCar() 
    {
        return itemsInPickup.Count;
    }

    public int GetTargetItems() 
    {
        return targetItems;
    }
}
