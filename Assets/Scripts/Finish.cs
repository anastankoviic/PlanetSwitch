using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    
    
       public GameObject panel;

       AudioManager audioManager;
    
       private void Awake(){
        if (panel != null)
        {
            panel.SetActive(false);

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
     }
   
    
        void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("SUNCE TRIGGER HIT: " + collision.name);
        if (collision.CompareTag("Player")) 
        {
           // Destroy(collision.gameObject);
               if (audioManager.victory != null)
                {
                    audioManager.PlaySFX(audioManager.victory);
                }

                else
                {
                   Debug.LogError("ColorPart: 'victory' AudioClip nije dodeljen u AudioManager Inspectoru!"); 
                }

        
          if (panel != null)
          {
          panel.SetActive(true);
          Time.timeScale = 0f;
          }
           else
          {
            Debug.LogError("Nema victory panela");
           }
        }

                
        

        Debug.Log(collision.tag);  
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("MainScene");
        
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
