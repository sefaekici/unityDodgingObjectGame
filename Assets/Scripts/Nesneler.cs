using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Nesneler : MonoBehaviour
{
    public GameObject kontrolObject;
  
    

    void Start()
    {
         
        
    }

    
    void Update()
    {   
        
        
    }

    
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        float randomX = Random.Range(-3.53f, 3.53f);
         
        float randomY = Random.Range(2.8f, 10f);


        if (collision.gameObject.tag == kontrolObject.tag)
        {
            gameObject.transform.position = new Vector3(randomX, randomY,0f);
            
           

        }
        else if (collision.gameObject.tag == "Karakter")
        {   
            //nesneler karaktere degdiğinde random bir konuma atandı bu işlem spawn işleminin ve oyunun devamlılığını sağladı. 
            gameObject.transform.position = new Vector3(randomX, randomY, 0f);

        }
    }


}
