using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardTelepatedObject : TelepatedObject {

    private float moveH;

    public override void Move()
    {
        if (isMoveable)
        {
            if (Input.GetAxis("J1_L_J_X_Axise") != 0)
            {
                moveH = Input.GetAxis("J1_L_J_X_Axise");
                if (moveH < 0)
                    gameObject.transform.rotation = new Quaternion(0, 180, 0, 0);
                if (moveH >= 0)
                    gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
                transform.Translate(Vector2.right * 0.01f);
                //rb.AddForce(movement * speed);
                //Debug.Log("MainX = " + moveH);
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

    public override void Rotate()
    {
        if (isRotateble)
        {
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
            //Отслеживаешь нажатие кнопки 3 и делаешь уникальное интерактивное действие (DEbug.Log)
        }
    }


}
