using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{


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

        HelloWorld();
        hello = GetHello();
        Debug.Log(hello);

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
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.back;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position += Vector3.down;
        }
        //Rotacion personaje
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 10, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.Euler(0, -10, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation *= Quaternion.Euler(-10, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation *= Quaternion.Euler(10, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.localScale += Vector3.one;
        }
    }

    public void HelloWorld()
    {
        Debug.Log("Hola,Mundo");
    }

    public string GetHello()
    {
        return "Hola";
    }

}
