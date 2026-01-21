using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyScore;

    private int ScoreNumber;

    void Start()
    {
        ScoreNumber=0;

        MyScore.text="Score: "+ScoreNumber;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Star") 
        {
            
           ScoreNumber++;
           Destroy(collision.gameObject);

           MyScore.text="Score: "+ScoreNumber;
        }

                
        

        Debug.Log(collision.tag); 
    }
    



}
