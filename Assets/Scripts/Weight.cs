using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour
{
    public int grams;
    // Start is called before the first frame update
    void Start()
    {
        GetPounds();
        GetOunce();
        GetKilograms();
    }

    private void GetPounds()
    {
        float pounds;

        pounds = grams / 453.59237f;

        Debug.Log(grams + " gramos en libras son: " + pounds);
    }

    private void GetOunce()
    {
        float ounce;

        ounce = grams * 0.0352739619f;

        Debug.Log(grams + " gramos en onzas son: " + ounce);
    }

    private void GetKilograms()
    {
        float kilograms;

        kilograms = grams / 1000;

        Debug.Log(grams + " gramos en kilogramos son: " + kilograms);
    }
}
