using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Mouselook : MonoBehaviour
{
    public float cameraSensitivity = 75f;
    public Transform transformCamera;
    private Vector2 cameraDelta;
    private Vector2 touchPosition;
    public RectTransform moveCameraArea;
    public bool inMoveCameraArea;
    private PlayerInput playerInput;
    private InputAction cameraMoveAction;
    private InputAction touchPositionAction;
    float xRotation = 0f;
    private Vector2 viewInfo;
    private bool isAndroid;
    private InputAction touchAction;
    public GameObject Book;


    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        cameraMoveAction = playerInput.actions["PlayerView"];
        touchPositionAction = playerInput.actions["TouchPosition"];
        touchAction = playerInput.actions["Touch"];
    }

    void Start()
    {

        
        
         if(Application.platform == RuntimePlatform.Android)
        {
            isAndroid = true;
        }
        inMoveCameraArea = true;
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (isAndroid)
        {
            float isTouching = touchAction.ReadValue<float>();
            if (isTouching > 0)
            {
                touchPosition = touchPositionAction.ReadValue<Vector2>();
                inMoveCameraArea = RectTransformUtility.RectangleContainsScreenPoint(moveCameraArea, touchPosition);
            }
            else
            {
                inMoveCameraArea = false;
            }
        }
        cameraDelta = cameraMoveAction.ReadValue<Vector2>();
        if (inMoveCameraArea && !Book.active) {
           // Debug.Log("inMoveCameraArea");
            float positionX = cameraDelta.x * cameraSensitivity * Time.deltaTime;
            float positionY = cameraDelta.y * cameraSensitivity * Time.deltaTime;

            xRotation -= positionY;
            xRotation = Mathf.Clamp(xRotation, -90, 90);
            // rotaciona a câmera para cima ou para baixo
            // mantendo como ângulo máximo 90 graus
            transformCamera.localRotation = Quaternion.Euler(xRotation, 0, 0);

            // rotaciona o player fixando o eixo y
            // para direita ou esquerda, de acordo com a posição x do mouse ou touchscreen
            transform.Rotate(Vector3.up * positionX);
            
        }
    }


}