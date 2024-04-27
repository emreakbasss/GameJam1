using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YönlendirmeScripts : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject BackGroundImage1;
    public GameObject MagazaImage;
    public GameObject SoundOff;
    public GameObject SoundOn;
    public GameObject Music;
    public GameObject HikayeMenusu;
    public GameObject Sayfa1;
    public GameObject Sayfa2;
    public GameObject Sayfa3;
    public GameObject BölümSecme;
    public GameObject BölümBildirimleri, Bölüm1Bildirim1, Bölüm1Bildirim2, Bölüm1Bildirim3;
    public void CikisButonu()
    {
        Application.Quit();
    }

    public void OynaButonu()       
    {
        BölümSecme.SetActive(true);
        BackGroundImage1.SetActive(false);
        //SceneManager.LoadScene(1);
        //SceneManager.LoadScene("KayitEkrani");
    }

    public void OpenMagaza()
    {
             
        MagazaImage.SetActive(true);
        BackGroundImage1.SetActive(false);        
    }

    public void AnaMenu()
    {
        HikayeMenusu.SetActive(false);
        MagazaImage.SetActive(false);
        BackGroundImage1.SetActive(true);
        HikayeMenusu.SetActive(false);
        Sayfa1.SetActive(false);
        Sayfa2.SetActive(false);
        Sayfa3.SetActive(false);
        BölümSecme.SetActive(false);
        BölümBildirimleri.SetActive(false);
    }
    
    public void SesAcKapat()
    {
        if(SoundOff.active==true)
        {
            SoundOff.SetActive(false);
            SoundOn.SetActive(true) ;
            Music.SetActive(false );
        }
        else if(SoundOn.active==true)
        {
            SoundOn.SetActive(false);
            SoundOff.SetActive(true);
            Music.SetActive(true);
        }
    }

    public void HikayeMenuAc()
    {
        BackGroundImage1.SetActive(false );
        HikayeMenusu.SetActive(true);
        Sayfa1.SetActive(true);
     
    }
    
    public void HikayeAtla()
    {
        if(Sayfa1.active==true)
        {
            Sayfa1.SetActive(false);
            Sayfa2.SetActive(true);
        }
        else if(Sayfa2.active==true)
        {
            Sayfa2.SetActive(false);
            Sayfa3.SetActive(true);
        }
    }
    
    
    public void bölüm1()
    {
        if (BölümSecme.active == true)
        {
            BölümSecme.SetActive(false);
            BölümBildirimleri.SetActive(true);
            Bölüm1Bildirim1.SetActive(true);
        }
        else if (Bölüm1Bildirim1.active == true)
        {
            Bölüm1Bildirim1.SetActive(false);
            Bölüm1Bildirim2.SetActive(true);
        }
        else if(Bölüm1Bildirim2.active == true)
        {
            Bölüm1Bildirim2.SetActive (false);
            Bölüm1Bildirim3.SetActive(true);
        }
        else if(Bölüm1Bildirim3.active == true)
        {
            Bölüm1Bildirim3.SetActive (false);
            SceneManager.LoadScene("3");
        }
    }
    
}
