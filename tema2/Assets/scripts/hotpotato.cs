using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotpotato : MonoBehaviour
{
    private int counter;
    public Color colorMat;
    // Start is called before the first frame update
    void Start()
    {
        counter = Random.Range(5, 22);
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    private void OnMouseDown()
    {
        /*cambiar color aleatoriamente
        colorMat = new Color (r: Random.Range(0f,1f)),
            g:Random.Range(0f,1f),b: Random.Range(0f, 1f);*/

             GetComponent<MeshRenderer>().material.color = colorMat;
        transform.localScale += 2*Vector3.one;
        counter --; //restar una unidad
        //para hacer explotar el objeto al llegar a 0 o menor
        if(counter <= 0)
        {
            Destroy(gameObject);
        }
    }


}
