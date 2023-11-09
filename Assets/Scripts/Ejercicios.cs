using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Ejercicios : MonoBehaviour
{
    public float rectangleHeight;
    public float rectangleWidth;

    public float cylinderRadius;
    public float cylinderHeight;

    void Start()
    {
        Rectangle();
        Cylinder();
    }

    private void Rectangle()
    {
        float rectangleArea;
        float rectanglePerimeter;
        float rectangleDiagonal;

        rectangleArea = rectangleHeight * rectangleWidth;
        rectanglePerimeter = (2 * rectangleHeight) + (2 * rectangleWidth);
        rectangleDiagonal = Mathf.Sqrt(Mathf.Pow(rectangleWidth, 2) + Mathf.Pow(rectangleHeight, 2));

        Debug.Log("El �rea del rect�ngulo es: " + rectangleArea);
        Debug.Log("El per�metro del rect�ngulo es: " + rectanglePerimeter);
        Debug.Log("La diagonal del rect�ngulo mide: " + rectangleDiagonal);
    }

    private void Cylinder()
    {
        float cylinderArea;
        float cylinderVolume;

        cylinderArea = 2 * Mathf.PI * cylinderRadius * (cylinderRadius + cylinderHeight);
        cylinderVolume = Mathf.PI * Mathf.Pow(cylinderRadius, 2) * cylinderHeight;

        Debug.Log("El �rea del cilindro es: " + cylinderArea);
        Debug.Log("El volumen del cilindro es: " + cylinderVolume);
    }
}
