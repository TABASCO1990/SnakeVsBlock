using TMPro;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float forwardSpeed = 5;
    public float sensitivity = 10;
    private float sidewaysSpeed;
    public static int lengthTail = 0;

    private Camera mainCamera;
    private Rigidbody snakeRb;
    private Vector3 touchLastPos;
    public static SnakeBody component;
    

    private void Start()
    {
        mainCamera = Camera.main;
        snakeRb = GetComponent<Rigidbody>();
        component = GetComponent<SnakeBody>();
    }

    private void Update()
    {
        Movement();

        if (Input.GetKeyDown(KeyCode.A))
        {
            component.AddTail();
            /*lengthTail++;
            Debug.Log(lengthTail);*/
        }

        if (Input.GetKeyDown(KeyCode.D)){
            component.RemoveTail();
            /*lengthTail--;
            Debug.Log(lengthTail);*/
        }
        
    }
    private void FixedUpdate()
    {
       
        snakeRb.velocity = new Vector3(sidewaysSpeed*5,0 ,forwardSpeed);
        sidewaysSpeed = 0;
    }

    private void Movement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchLastPos = mainCamera.ScreenToViewportPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            sidewaysSpeed = 0;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 delta = mainCamera.ScreenToViewportPoint(Input.mousePosition) - touchLastPos;
            sidewaysSpeed += delta.x * sensitivity;
            touchLastPos = mainCamera.ScreenToViewportPoint(Input.mousePosition);
        }
    }
}
