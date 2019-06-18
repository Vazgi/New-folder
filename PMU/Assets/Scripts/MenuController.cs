using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject menu;
    public GameObject EasyP;
    public GameObject NormalP;
    public GameObject EndlessP;

    void Start()
    {
        EasyP.SetActive(false);
        NormalP.SetActive(false);
        EndlessP.SetActive(false);
        menu.SetActive(true);
    }

    public void Easy()
    {
        menu.SetActive(false);
        EasyP.SetActive(true);
    }

    public void Normal()
    {
        menu.SetActive(false);
        NormalP.SetActive(true);
    }

    public void Endless()
    {
        menu.SetActive(false);
        EndlessP.SetActive(true);   
    }

    public void Back()
    {
        EasyP.SetActive(false);
        NormalP.SetActive(false);
        EndlessP.SetActive(false);
        menu.SetActive(true);
    }
}
