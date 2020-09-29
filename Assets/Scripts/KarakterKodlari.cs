using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class KarakterKodlari : MonoBehaviour
{
    
    private float hiz=4.1f;
    //diğer kod bloklarından erişilebilmesi için public ve static olarak atanmıştır.
    public static int canHak = 3;
    public TextMeshProUGUI textHealth;
    public GameObject gameOverPanel;
    public bool oyunSonu = false;

    void Start()
    {
        textHealth.text = "HEALTH:" + canHak.ToString();
        //oyunun basinda bitis panelinin gözükmemesini sağlar.
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        kelepcele();
        hareketEt();
        canGuncelle();
        
    }

    //karakterin ekranda belirlenen sınırlar dışına çıkmamasini saglayan kod.   
    void kelepcele()
    {
        float xPosition = Mathf.Clamp(transform.position.x, -3.59f, 3.59f);
        transform.position = new Vector2(xPosition, transform.position.y);
    }

    void hareketEt()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(horizontal * Time.deltaTime*hiz, 0f,0f);
        

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Engel")
        {
                canHak--;
        }
    }
    void canGuncelle()
    {
        textHealth.text = "HEALTH:" + canHak.ToString();
        if (!oyunSonu)
        {   
            //bir kere gameover yazısı çıkması için eklenmiş if bloğu
            if (canHak == 0)
            {   
                //bitişte ekrana panelin çıkmasını sağlar.
                gameOverPanel.SetActive(true);
                oyunSonu = true;
                //oyunu durdurur yani oyun hızını sıfırlar varsayılan değeri 1 dir.
                Time.timeScale = 0;
            }
        }
        
    }
    

}
