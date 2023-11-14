using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{
    public float number;

    void Start()
    {
        AddNumbers1ToNumberFor();
    }

    //Números de 0 a 100
    private void Loop0to100WithFor()
    {
        for (int vueltas = 0; vueltas <= 100; vueltas++)
        {
            Debug.Log(vueltas + " For");
        }
    }

    private void Loop0to100WithWhile()
    {
        int vueltas = 0;
        
        while(vueltas <= 100)
        {
            Debug.Log(vueltas + " While");
            vueltas++;
        }
    }

    //Números de 100 a 0
    private void Loop100to0WithFor()
    {
        for (int vueltas = 100; vueltas >= 0; vueltas--)
        {
            Debug.Log(vueltas + " For");
        }
    }

    private void Loop100to0WithWhile()
    {
        int vueltas = 100;

        while (vueltas >= 0)
        {
            Debug.Log(vueltas + " While");
            vueltas--;
        }
    }

    //contar de 1 hasta el número indicado
    private void Loop1ToNumberFor()
    {

        for (int vueltas = 1; vueltas <= number; vueltas++)
        {
            Debug.Log(vueltas + " For");
        }
    }

    private void Loop1ToNumberWhile()
    {
        int vueltas = 1;

        while (vueltas <= number)
        {
            Debug.Log(vueltas + " While");
            vueltas++;
        }
    }

    //Números pares de 0 a 100
    private void Loop0To100ParFor()
    {
        for (int vueltas = 0; vueltas <= 100; vueltas += 2)
        {
            Debug.Log(vueltas + " For");
        }
    }

    private void Loop0To100ParWhile()
    {
        int vueltas = 0;

        while (vueltas <= 100)
        {
            Debug.Log(vueltas + " While");
            vueltas += 2;
        }
    }

    //Números impares de 0 a 100

    private void Loop0To100InparFor()
    {
        for (int vueltas = 1; vueltas <= 100; vueltas += 2)
        {
            Debug.Log(vueltas + " For");
        }
    }

    private void Loop0To100InparWhile()
    {
        int vueltas = 1;

        while (vueltas <= 100)
        {
            Debug.Log(vueltas + " While");
            vueltas += 2;
        }
    }

    //Números múltiplos de 2 y 3 entre 0 y 100
    private void LoopMultiples2And3()
    {
        for (int vueltas = 0; vueltas <= 100; vueltas++)
        {
            // Verifica si el número es un múltiplo de 2 y 3
            if (vueltas % 2 == 0 && vueltas % 3 == 0)
            {
                Debug.Log(vueltas + " es un múltiplo de 2 y 3");
            }
        }

    }

    //Suma del los números entre 1 y el elegido

    private void AddNumbers1ToNumberFor()
    {
        int suma = 0;
        int suma2 = 0;

        for (int vueltas = 1; vueltas <= number; vueltas++)
        {
            suma += vueltas; //Prueba haciendo la suma de las vueltas que se han dado

            suma2 = ((1 + vueltas) * vueltas) / 2; //Fórmula de internet
        }

        Debug.Log("La suma de los números del 1 al " + number + " es: " + suma);
        Debug.Log("La suma de los números del 1 al " + number + " es: " + suma2);
    }
}
