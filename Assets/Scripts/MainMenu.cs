using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

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

  public void PlayGame()
    {
        Debug.Log("Clicked");

        if (audioManager.tap != null)
        {
          audioManager.PlaySFX(audioManager.tap);
        }

        else
        {
          Debug.LogError("ColorPart: 'tap' AudioClip nije dodeljen u AudioManager Inspectoru!"); 
        }



        SceneManager.LoadSceneAsync(1);
        
    }

    
}
