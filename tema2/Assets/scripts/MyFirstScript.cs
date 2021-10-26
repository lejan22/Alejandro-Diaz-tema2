using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public int number1;
    public int number2;

    private float playerSpeed = 5.25f;
    public string playerName = "Lejan";
    [SerializeField] private bool gameOver;


    public int x = 5;
    public int y = 2;

    public float a = 5f;
    public float b = 2f;

    public bool isRaining = false;

    public bool isCold = true;
    public int playerAge = 35;

    public string hello;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Product(number1, number2));


        //HelloWorld();
        //hello = GetHello();
        //Debug.Log(hello);


        // Debug.Log( GetHello())

        //transform.position = new Vector3(0,0,0);
        transform.position = Vector3.zero;
        Debug.Log(transform.position);
        /*
        if (x== 2 || y <= 5)
        {
            Debug.Log("verdadero");
        }
        else
        {
            Debug.Log("Falso");
        }
        
        Debug.Log($"suma: {x} + {y} = {x + y}");
        Debug.Log("Resta: " + x + " - " + y + " = " + (x - y));
        Debug.Log($"producto: {x} * {y} = {x * y}");
        Debug.Log(string.Format("Division: {0} / {1} = {2}", x, y, x/y));
        
        if(isRaining)
        {
            Debug.Log("Lleva paraguas.");
        }
        else 
        {
            Debug.Log("No Llueve. No lleves paraguas.");
        }
        
        if (playerAge >= 18)
        {
            Debug.Log("Eres mayor de edad");
        }
        else if (playerAge >= 13)
        {
            Debug.Log("Eres adolescente");
        }
        else
        {
            Debug.Log("Eres un niño tontito");
        }
       */
    }
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(transform.position);
        //movimiento personaje
        MovementToDirection(KeyCode.D, Vector3.right);
        MovementToDirection(KeyCode.A, Vector3.left);
        MovementToDirection(KeyCode.W, Vector3.forward);
        MovementToDirection(KeyCode.S, Vector3.back);
        MovementToDirection(KeyCode.E, Vector3.up);
        MovementToDirection(KeyCode.Q, Vector3.down);

        //Rotacion personaje
        RotationToDirection(KeyCode.RightArrow, new Vector3(0, 10, 0));
        RotationToDirection(KeyCode.LeftArrow, new Vector3(0, -10, 0));
        RotationToDirection(KeyCode.UpArrow, new Vector3(10, 0, 0));
        RotationToDirection(KeyCode.DownArrow, new Vector3(-10, 0, 0));

        //Escalar
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.localScale += Vector3.one;
        }
        ScaleFigure(KeyCode.X, Vector3.right);
        ScaleFigure(KeyCode.Y, Vector3.up);
        ScaleFigure(KeyCode.U, Vector3.forward);
    }

    public void HelloWorld()
    {
        Debug.Log("Hola,Mundo");
    }

    public string GetHello()
    {
        return "Hola";
    }

    public void MovementToDirection(KeyCode key, Vector3 direction)
    {
        if (Input.GetKeyDown(key))
        {
            transform.position += direction;
        }


    }

    public void ScaleFigure(KeyCode key, Vector3 axis)
    {
        if (Input.GetKeyDown(key))
        {
            transform.localScale += axis;
        }

    }
    public void RotationToDirection(KeyCode key, Vector3 axis)
    {
        if (Input.GetKeyDown(key))
        {
            transform.rotation *= Quaternion.Euler(axis);
        }
    }
    public int Product(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1} * {num2} = {result}");
        return result;
    }
}

