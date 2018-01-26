using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardTelepatedObject : TelepatedObject {

    public override void Move()
    {
        if (isMoveable)
        {
            //Тут как будто в апдейте проверяешь на нажатия <^v> и двигаешь объект          
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
