using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject winScr;
    int count = 0;
    public GameObject easy;
    public GameObject menu;
    // Start is called before the first frame update
    void OnEnable()
    {
        p1.SetActive(true);
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextProblem()
    {
        count++;
        winScr.SetActive(false);
        if (count == 1)
        {
            p1.SetActive(false);
            p2.SetActive(true);
            

        }
        if (count == 2)
        {
            p2.SetActive(false);
            p3.SetActive(true);
        }
        if (count == 3)
        {
            p3.SetActive(false);
            easy.SetActive(false);
            menu.SetActive(true);
        }
    }
}
