using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales : MonoBehaviour
{
    public int number = 0;
    void Start()
    {
        PositiveOrNegative();
    }

    private void PositiveOrNegative()
    {
        if(number > 0)
        {
            Debug.Log(number + " es positivo");
        }

        else if (number < 0)
        {
            Debug.Log(number + " es negativo");
        }

        else if (number == 0)
        {
            Debug.Log(number + " es el cero, ni positivo ni negativo. Est� m�s all�.");
        }
    }

    private void ParOrImpar()
    {

        if ( number % 2 == 0)
        {
            Debug.Log(number + " es un n�mero par.");
        }
        else
        {
            Debug.Log(number + " es un n�mero impar.");
        }
    } 

}
