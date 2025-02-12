using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float rotateSpeed = 150f;

    private void Update()
    {
        float rotationAmount = rotateSpeed * Time.deltaTime;
        transform.Rotate(rotationAmount, rotationAmount, rotationAmount);
    }
}