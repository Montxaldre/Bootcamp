using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales : MonoBehaviour
{
    public int number;
    public char letter;

    public int number1;
    public int number2;
    public int number3;

    void Start()
    {
        PositiveOrNegative();
        VocalLetters();
        Week();
        WeekSwitch();
        Month();
        MonthSwitch();
        Order3Numbers();
    }

    //Mirar si un número es positivo o negativo
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
            Debug.Log(number + " es el cero, ni positivo ni negativo. Está más allá.");
        }
    }

    //Mirar si un número es par o impar
    private void ParOrImpar()
    {

        if ( number % 2 == 0)
        {
            Debug.Log(number + " es un número par.");
        }
        else
        {
            Debug.Log(number + " es un número impar.");
        }
    } 

    //Mirar si una letra es vocal o no
    private void VocalLetters()
    {
        if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            Debug.Log("La letra " + letter + " es una vocal");
        }

        else
        {
            Debug.Log("La letra " + letter + " es una consonante");
        }
    }

    //Decir el día de la semana en base a un número
    private void Week()
    {
        if (number == 1)
        {
            Debug.Log("Es lunes");
        }

        else if (number == 2)
        {
            Debug.Log("Es martes");
        }

        else if(number == 3)
        {
            Debug.Log("Es Miércoles");
        }

        else if (number == 4)
        {
            Debug.Log("Es jueves");
        }

        else if (number == 5)
        {
            Debug.Log("Es viernes");
        }

        else if (number == 6)
        {
            Debug.Log("Es sábado");
        }

        else if (number == 7)
        {
            Debug.Log("Es domingo");
        }

        else
        {
            Debug.Log("Tienes que introducir un valor comprendido entre el 1 y el 7");
        }
    }

    private void WeekSwitch()
    {
        switch (number)
        {
            case 1:
                Debug.Log("Es lunes Switch");
                break;

            case 2:
                Debug.Log("Es martes Switch");
                break;

            case 3:
                Debug.Log("Es miércoles Switch");
                break;

            case 4:
                Debug.Log("Es jueves Switch");
                break;

            case 5:
                Debug.Log("Es viernes Switch");
                break;

            case 6:
                Debug.Log("Es sábado Switch");
                break;

            case 7:
                Debug.Log("Es domingo Switch");
                break;

            default:
                Debug.Log("Tienes que introducir un valor comprendido entre el 1 y el 7");
                break;
        }
    }

    //Decir el día del mes en base a un número

    private void Month()
    {
        if (number == 1)
        {
            Debug.Log("Es enero");
        }

        else if (number == 2)
        {
            Debug.Log("Es febrero");
        }

        else if (number == 3)
        {
            Debug.Log("Es marzo");
        }

        else if (number == 4)
        {
            Debug.Log("Es abril");
        }

        else if (number == 5)
        {
            Debug.Log("Es mayo");
        }

        else if (number == 6)
        {
            Debug.Log("Es junio");
        }

        else if (number == 7)
        {
            Debug.Log("Es julio");
        }

        else if (number == 8)
        {
            Debug.Log("Es agosto");
        }

        else if (number == 9)
        {
            Debug.Log("Es septiembre");
        }

        else if (number == 10)
        {
            Debug.Log("Es octubre");
        }

        else if (number == 11)
        {
            Debug.Log("Es noviembre");
        }

        else if (number == 12)
        {
            Debug.Log("Es diciembre");
        }

        else
        {
            Debug.Log("Tienes que introducir un valor comprendido entre el 1 y el 12");
        }
    }

    private void MonthSwitch()
    {
        switch (number)
        {
            case 1:
                Debug.Log("Es enero Switch");
                break;

            case 2:
                Debug.Log("Es febrero Switch");
                break;

            case 3:
                Debug.Log("Es marzo Switch");
                break;

            case 4:
                Debug.Log("Es abril Switch");
                break;

            case 5:
                Debug.Log("Es mayo Switch");
                break;

            case 6:
                Debug.Log("Es junio Switch");
                break;

            case 7:
                Debug.Log("Es julio Switch");
                break;

            case 8:
                Debug.Log("Es agosto Switch");
                break;

            case 9:
                Debug.Log("Es septiembre Switch");
                break;

            case 10:
                Debug.Log("Es octubre Switch");
                break;

            case 11:
                Debug.Log("Es noviembre Switch");
                break;

            case 12:
                Debug.Log("Es diciembre Switch");
                break;

            default:
                Debug.Log("Tienes que introducir un valor comprendido entre el 1 y el 12");
                break;
        }
    }

    private void Order3Numbers()
    {
        int largest, middle, smallest;

        if (number1 >= number2 && number1 >= number3)
        {
            largest = number1;

            if (number2 >= number3)
            {
                middle = number2;
                smallest = number3;
            }
            else
            {
                middle = number3;
                smallest = number2;
            }
        }
        else if (number2 >= number1 && number2 >= number3)
        {
            largest = number2;

            if (number1 >= number3)
            {
                middle = number1;
                smallest = number3;
            }
            else
            {
                middle = number3;
                smallest = number1;
            }
        }
        else
        {
            largest = number3;

            if (number1 >= number2)
            {
                middle = number1;
                smallest = number2;
            }
            else
            {
                middle = number2;
                smallest = number1;
            }
        }

        Debug.Log("El orden de los números descendente es: " + largest + ", " + middle + ", " + smallest);
        Debug.Log("El orden de los números ascendente es: " + smallest + ", " + middle + ", " + largest);

    }
}
