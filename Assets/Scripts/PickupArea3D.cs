using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // �������� ���� namespace ��� ������ � UI

public class PickupArea3D : MonoBehaviour
{
    public List<GameObject> itemsInPickup = new List<GameObject>();
    public Text resultText; // ������ �� ��������� ����

    private void OnTriggerEnter(Collider other)
    {
       
    }

    public void CheckSolution()
    {
        // ������ �������� �������
        Debug.Log("�������� �������...");
        resultText.text = "�������� �������:n"; // ����� ������ ����� �������

        foreach (var item in itemsInPickup)
        {
            Debug.Log(item.name);
            resultText.text += item.name + "n"; // ��������� ��� �������� � ����������
        }
    }
}