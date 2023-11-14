using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    char r;
    int A, B, C;
    float x;
    int xx, y;
    bool z;
    // Start is called before the first frame update
    void Start()
    {
        A = 3;
        B = 4;

        C = A + 2 * B;
        C = C + B;
        B = C - A;
        A = B * C;

        Debug.Log(A + B + C);

        x = 2 - 0f;


        x = Mathf.Pow((x + x), 2);

        x = Mathf.Sqrt(x + Mathf.Sqrt(x) + 5);

        Debug.Log(x);


        xx = 5;
        y = xx - 2;
        xx = y * y + 1;
        z = (xx > (y + 5));
        Debug.Log(xx + y);



    }

}