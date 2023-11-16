using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasoPorParametro : MonoBehaviour
{
    public int position;

    void Start()
    {
        PosError();
    }

    private void PosError()
    {
        if(NumFibonacci(position) == -1)
        {
            Debug.Log("El número introducido no puede ser menor a 0.");
        }

        else
        {
            Debug.Log("La posición " + position + " en la sucesión de Fibonacci corresponde a: " + NumFibonacci(position));
        }
    }

    private int NumFibonacci (int pos)
    {
        int num1 = 0;
        int num2 = 1;
        int sum = 0;

        if (pos > 0)
        {
            for (int i = 1; i < pos; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
            }

            return sum;
        }

        return -1;
    }
}
