using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public bool isSolution = false;
    public AudioClip CorrectAnswer;
    public AudioClip WrongAnswer;
    public AudioSource musicSource;
    public GameObject winScr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
  public void OnClick()
    {
    
        if (isSolution == true)
        {
            musicSource.clip = CorrectAnswer;
            musicSource.Play(0);
            winScr.SetActive(true);
        }
        else
        {
            musicSource.clip = WrongAnswer;
            musicSource.Play(0);
            Destroy(gameObject, musicSource.clip.length);
        }
    }
}
