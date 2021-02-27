using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f,5f)]
     float CurrentSpeed = 1f;
    float Speed = 1f;
   
    void Update()
    {
        transform.Translate(Vector2.left * CurrentSpeed  * Time.deltaTime);
    }
    private void  SetMovementSpeed(float speed)
    {
        CurrentSpeed = speed;
    }
}
