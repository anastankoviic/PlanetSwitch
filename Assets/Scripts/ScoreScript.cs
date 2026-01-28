using NUnit.Framework.Internal;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyScore;

    private int ScoreNumber;

    AudioManager audioManager;


    private void Awake()
    {
      var amObj = GameObject.FindGameObjectWithTag("AudioManager");
        if (amObj != null)
        {
            audioManager = amObj.GetComponent<AudioManager>();
        }
        else
        {
            Debug.LogError("ColorPart: Nema objekta sa tagom 'AudioManager' u sceni!");
        }
    }

    void Start()
    {
        ScoreNumber=0;

        MyScore.text="Score: "+ScoreNumber;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Star") 
        {
               
                if (audioManager.stars != null)
                {
                    audioManager.PlaySFX(audioManager.stars);
                }

                else
                {
                   Debug.LogError("ColorPart: 'stars' AudioClip nije dodeljen u AudioManager Inspectoru!"); 
                }




           ScoreNumber++;
           Destroy(collision.gameObject);

           MyScore.text="Score: "+ScoreNumber;
        }

                
        

        Debug.Log(collision.tag); 
    }
    
     public int GetScore()
    {
        return ScoreNumber;
    }


}
