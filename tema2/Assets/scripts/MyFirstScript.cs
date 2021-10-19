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
    // Start is called before the first frame update
    void Start()
    {
        if (x== 2 || y <= 5)
        {
            Debug.Log("verdadero");
        }
        else
        {
            Debug.Log("Falso");
        }
        /*
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
        */
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
    }
}
