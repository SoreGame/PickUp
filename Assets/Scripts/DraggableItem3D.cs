using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class DraggableItem3D : MonoBehaviour
{
    private bool isDragging = false;
    private Camera mainCamera;
    private Vector3 strartPosition;
    private Quaternion startRotation;
    private bool inACar = false;
    [SerializeField] 
    float speed = 100f;

    void Start()
    {
        mainCamera = Camera.main; // Получаем основную камеру
        strartPosition = transform.position;
        startRotation = transform.rotation;
    }

    void OnMouseDown()
    {
        isDragging = true; // Начинаем перетаскивание
    }

    void OnMouseUp()
    {
        isDragging = false; // Завершаем перетаскивание
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            inACar = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            inACar = false;
        }
    }

    void Update()
    {
        if (isDragging)
        {
            if (Input.GetMouseButton(0))
            {
                var posVec = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                posVec.z = transform.position.z;

                transform.position = Vector3.MoveTowards(transform.position, posVec, speed * Time.deltaTime);
                gameObject.GetComponent<Rigidbody>().freezeRotation = false;
            }
        }
        else 
        {
            if (!inACar) 
            {
                transform.position = strartPosition;
                transform.rotation = startRotation;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
            }
        }
    }
}