using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    //variables globales
    public int farenheit;
    public int celsius;

    // Start is called before the first frame update
    void Start()
    {
        FarenheitToCelsius();
        CelsiusToFarenheit();
    }

    private void FarenheitToCelsius()
    {
        float resultFarenheitToCelsius;

        resultFarenheitToCelsius = (farenheit - 32) / 1.8f;

        Debug.Log(farenheit + " grados farenheit en ceslius son: " + resultFarenheitToCelsius);
    }

    private void CelsiusToFarenheit()
    {
        float resultCelsiusToFarenheit;

        resultCelsiusToFarenheit = 1.8f * celsius + 32;

        Debug.Log(celsius + " grados ceslius en farenheit son: " + resultCelsiusToFarenheit);

    }
}
