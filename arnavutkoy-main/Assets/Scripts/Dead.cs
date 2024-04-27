using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    public GameObject Something;
    public GameObject Ölme, BölümGeçme;
    public GameObject BölümSecmece;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Engel")
        {      
            Time.timeScale = 0f;
            SceneManager.LoadScene("5");
        }

        if (collision.gameObject.tag == "Son")
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene("6");
        }
    }
    public void AnaEkranaAl()
    {
        SceneManager.LoadScene("1");
    }
    public void Sahne3Tekrar()
    {
        SceneManager.LoadScene("3");
    }
    public void BolümSec()
    {
        SceneManager.LoadScene("1");
        BölümSecmece.SetActive(true);

    }
 
}

