using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AddArray();
        PositiveNumbers();
    }


    private void PositiveNumbers()
    {
        int[] array = { -10, 5, 2, -6, 1, -1, 3, -120, 2454};

        int i = 0;
        while (i < array.Length)
        {
            if(array[i] > 0)
            {
                Debug.Log("Los números positivos son: " + array[i]);
            }

            i++;
        }

    }
    private void NegativeNumbers()
    {
        int[] array = { -10, 5, 2, -6, 1, -1, 3, -120, 2454 };

        int i = 0;

        while (i < array.Length)
        {
            if (array[i] < 0)
            {
                Debug.Log("Los números negativos son: " + array[i]);
            }

            i++;
        }
    }

    private void AddArray()
    {

        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 1, 2, 3, 4, 5 };
        int[] result = { 0, 0, 0, 0, 0 };
        //int[] result = new int[array1.Length];
        //int[] result = new int[5];

        if (array1.Length != array2.Length)
        {
            Debug.Log("Los arrays no tienen la misma longitud.");
        }

        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + array2[i];
            Debug.Log(result[i]);
        }

    }
}
