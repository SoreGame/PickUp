using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class StartUI : MonoBehaviour
{
    [SerializeField]
    private GameObject UI;
    public Button button;
    public GameObject firstDoor;
    public GameObject secondDoor;

    private Vector3 firstDoorStartPos;
    private Vector3 secondDoorStartPos;
    private Vector3 velocity = Vector3.zero;

    private bool isStart = false;

    public void StartLevel()
    {
        isStart = true;
        UI.SetActive(true);
        button.gameObject.SetActive(false);
    }
    private void Start()
    {
        firstDoorStartPos = firstDoor.transform.position;
        secondDoorStartPos = secondDoor.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isStart)
        {
            firstDoor.transform.position = Vector3.SmoothDamp(firstDoor.transform.position, new Vector3(firstDoorStartPos.x - 12, firstDoorStartPos.y, firstDoorStartPos.z),
                    ref velocity, 0.1f);
            secondDoor.transform.position = Vector3.SmoothDamp(secondDoor.transform.position, new Vector3(secondDoorStartPos.x + 12, firstDoorStartPos.y, firstDoorStartPos.z),
                    ref velocity, 0.1f);
        }
    }
}
