using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicle : MonoBehaviour
{
// Variabe que guarda el sonido del vehiculo
    [SerializeField] private string sound = "Bruuum , fiuuuuum!";
   //Variable que indica el nombre
    [SerializeField] private string name;
    //Variable que indica el numero de ruedas
    [SerializeField] private int numberWheels = 4 ;
   //Variable que indica si tiene sirena
    [SerializeField] private bool hasSiren;
    //Variable que indica is esta encendido
    [SerializeField] private bool isOn = true;
    [SerializeField] private float Gasoline;

    // Start is called before the first frame update
    void Start()
    {
        /*info coche
        Debug.Log($"{name} tiene { numberWheels} ruedas y hace { sound}");
        info de la sirena
       
        if (hasSiren == true)
        {
            Debug.Log($"{name} tiene sirena");
        }
        else
        {
            Debug.Log($"{name} no tiene sirena xd");
        }
        
        if (isOn == true)
        {
            Debug.Log($"{sound}");
        }
        else if (hasSiren == true)
        {
            Debug.Log($"{name} hara {sound} cuando se ponga en marcha");
        }
        else 
        {
            Debug.Log($"({name} no esta en marcha.");
        }
       */
        if (isOn) 

        {
           if(Gasoline<10)
            {
                Debug.Log($"{name} tiene sed");

                if (hasSiren = true)
                {
                    Debug.Log($"{name} hara {sound} cuando se ponga en marcha");
                }
                else
                {
                    Debug.Log($"{name} no tiene sirena");
                }
                
            }

        }
        else
        {
            Debug.Log($"{name} no esta en marcha");
        }
   
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
