using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public Rigidbody plataformRB;
    public Transform[] platformPositions;
    public float plataformSpeed;

    private int actualPosition = 0;
    private int nextPosition = 1;

    //public bool ToTheNext = true;
   // public float waitTime;

    // Update is called once per frame
    void Update()
    {
        MovePlataform();
    }

    void MovePlataform()
    {
        //if(ToTheNext == true)
        //{
        //    StopCoroutine(WaitForMove(0));
        //    plataformRB.MovePosition(Vector3.MoveTowards(plataformRB.position, platformPositions[1].position, plataformSpeed * Time.deltaTime));
        //}

        plataformRB.MovePosition(Vector3.MoveTowards(plataformRB.position, platformPositions[nextPosition].position, plataformSpeed * Time.deltaTime));

        if (Vector3.Distance(plataformRB.position, platformPositions[nextPosition].position) <= 0)
        {
           // StartCoroutine(WaitForMove(waitTime));
            actualPosition = nextPosition;
            nextPosition++;

            if (nextPosition > platformPositions.Length - 1)
            {
                nextPosition = 0;
            }
        }
    }

    //IEnumerator WaitForMove(float time)
    //{
    //    ToTheNext = false;
    //    yield return new WaitForSeconds(time);
    //    ToTheNext = true;
    //}
}
