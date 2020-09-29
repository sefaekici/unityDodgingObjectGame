using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//textmesh pro için eklenmiş kütüphane
using TMPro;

public class kontrol : MonoBehaviour
{   
    //skor saymak için oluşturulmuş değişken.s
    private int skor = 0;
    //skor atama işlemi yapılacak olan textMesh için oluşturulmuş nesne.
    public TextMeshProUGUI skorText,gameOverText;
    void Start()
    {
        
    }

    
    void Update()
    {
        skorText.text = "SKOR:" + skor.ToString();
        gameOverText.text = "GAME OVER!" + "\n" + "\n" + "SKOR:" + skor.ToString();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Engel")
        {
            skor++;
        }
    }
}
