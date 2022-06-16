using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Malo : MonoBehaviour
{
    public Rigidbody plataformRB;
    public Transform[] platformPositions;
    public float plataformSpeed;

    private int actualPosition = 0;
    private int nextPosition = 1;

    void Update()
    {
        MovePlataform();
    }

    void MovePlataform()
    {
       
        plataformRB.MovePosition(Vector3.MoveTowards(plataformRB.position, platformPositions[nextPosition].position, plataformSpeed * Time.deltaTime));

        if (Vector3.Distance(plataformRB.position, platformPositions[nextPosition].position) <= 0)
        {
          
            actualPosition = nextPosition;
            nextPosition++;

            if (nextPosition > platformPositions.Length - 1)
            {
                nextPosition = 0;
            }
        }
    }
}