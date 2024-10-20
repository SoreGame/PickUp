using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject car;


    public void CheckAnswer() 
    {
        int targetItems = car.GetComponent<PickupAreaController>().GetTargetItems();
        int countItems = car.GetComponent<PickupAreaController>().GetCountItemsInCar();
        if (countItems == targetItems) 
        {
            gameObject.SetActive(false);
            Application.Quit();
            Debug.Log("Correct Anser");
        }
    }

    public void ReastartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
