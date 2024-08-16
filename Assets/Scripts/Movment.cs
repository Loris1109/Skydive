using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movment : MonoBehaviour
{
    public float speed = 1f;
    private InputActions inputActions;

   private void Awake()
   {
     inputActions = new InputActions();
     inputActions.Playerflying.Enable();
   }

   public void Update()
   {
    Debug.Log(inputActions.Playerflying.movment.ReadValue<Vector2>());
    Vector2 inputVector = inputActions.Playerflying.movment.ReadValue<Vector2>();
    transform.Translate(inputVector * speed * Time.deltaTime);
   }

}
