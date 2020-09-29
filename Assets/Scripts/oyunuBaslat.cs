using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class oyunuBaslat : MonoBehaviour
{
    public void oyunuYenidenOyna()
    {   
        //çakışma olmaması için can tekrardan 3 e çıkarılmıştır.
        KarakterKodlari.canHak = 3;
        //sahne yeniden yüklenmiştir.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        //oyun hızı tekrardan 1 e çekilmiştir.
        Time.timeScale = 1;

    }
}
