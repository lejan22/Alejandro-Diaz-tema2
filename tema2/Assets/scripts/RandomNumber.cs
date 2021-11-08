using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumber : MonoBehaviour
{

    private int randNum;
    public int myNum;
    private int counter; //contador de intentos

    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(0, 11);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            myNum = int.Parse(GetComponent<InputField>().text);
            CompareToRandomNumber(myNum);
            //añadir uno a los intentos
            counter ++;
        }


    }

    public void CompareToRandomNumber(int userNum)
    {
        if (userNum < randNum)
        {
            Debug.Log("Demasiado bajo simple mortal");
        }
        if (userNum > randNum)
        {
            Debug.Log("Demasiado alto insecto indecente");
        }
        if (userNum == randNum)
        {
            Debug.Log($"Estas son las croquetas que quiero {randNum}, muchas gracias");
            Debug.Log($"Has utilizado {counter} intentos");
        }
    }
}
