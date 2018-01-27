using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardTelepatedObject : TelepatedObject {

    private float moveH;

    private void Start()
    {
        StartTransmission();
    }


    public override void Move()
    {
        if (isMoveable)
        {
            if (Input.GetAxis("J1_L_J_X_Axise") != 0)
            {
                transform.Translate(Vector2.right * 0.01f);
            }
        }
    }

    public override IEnumerator OnTransmissionLogic()
    {
        while (isOnTelepatingMode)
        {
            Move();
            Rotate();
            Use();
            yield return null;
        }
    }

    //private void Update()
    //{
    //    Move();
    //    Rotate();
    //    Use();
    //}

    public override void Rotate()
    {
        if (isRotateble)
        {
            if (Input.GetKeyDown(KeyCode.Joystick1Button3))
            {
                transform.Rotate(90, 0, 0);
            }
            //Тут как будто в апдейте ловишь листенер на кнопку "4"
            //If(Input/KeyCode(кнопка4) {Крутить объект на 90 градусов по x})
        }
    }

    public override void StartTransmission()
    {
        isOnTelepatingMode = true;
        StartCoroutine(OnTransmissionLogic());
    }

    public override void StopTransmission()
    {
        isOnTelepatingMode = false;
    }

    public override void Use()
    {
        if (isUseable)
        {
            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                Debug.Log("Use");
            }
            //Отслеживаешь нажатие кнопки 3 и делаешь уникальное интерактивное действие (DEbug.Log)
        }
    }


}
