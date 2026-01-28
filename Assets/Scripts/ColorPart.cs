
using UnityEngine;

public class ColorPart : MonoBehaviour
{
    public GameOver gameOver;
   
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();

            if(player == null)
            {
                return;
            }

            if (player.currentColor != gameObject.tag)
            {
                Debug.Log(collision.tag);
                Debug.Log("GAME OVER");
                //(collision.gameObject); //unistava igraca

                 if (audioManager.gameOver != null)
                {
                    audioManager.PlaySFX(audioManager.gameOver);
                }

                else
                {
                   Debug.LogError("ColorPart: 'gameOver' AudioClip nije dodeljen u AudioManager Inspectoru!"); 
                }
                        

                //uzima score
                ScoreScript scoreScript = collision.GetComponent<ScoreScript>();

                int finalScore=0;
                if (scoreScript != null)
                {
                    finalScore=scoreScript.GetScore();
                }
                
                //prikazuje game over ekran
               // GameOver gameOver = Object.FindFirstObjectByType<GameOver>();

                if (gameOver != null)
                {
                   gameOver.Setup(finalScore);
                }
                else
                {
                    Debug.LogError("ColorPart:GameOver nije pronadjeno");
                }

            

            Destroy(collision.gameObject); //unistava igraca


            }
        }
    }
}
