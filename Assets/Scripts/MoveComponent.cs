    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveComponent : MonoBehaviour
{
    public float speed = 1f;
    public Transform[] points;

    private int movePointNumber = 1;

    private void Update()
    {
        Vector3 moveDirection = points[movePointNumber].position - transform.position;
        transform.position = transform.position + moveDirection.normalized * speed * Time.deltaTime;

        if (moveDirection.magnitude <= 0.1f)
        {
            movePointNumber++;

            if (movePointNumber == points.Length) movePointNumber = 0;
        }
    }
}
 

