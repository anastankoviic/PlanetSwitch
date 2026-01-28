using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject panel;
    public Text scoreText;

    AudioManager audioManager;

    private void Awake(){
        if (panel != null)
        {
            panel.SetActive(false);

        }

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

        public void Setup(int finalScore)
    {
        if (panel != null)
        {
          panel.SetActive(true);
        }
        else
        {
            Debug.LogError("Nema game over panela");
        }
       

        scoreText.text = "Score: " + finalScore;

    }

    public void RestartButton()
    {
        if (audioManager.tap != null)
        {
          audioManager.PlaySFX(audioManager.tap);
        }

        else
        {
          Debug.LogError("ColorPart: 'tap' AudioClip nije dodeljen u AudioManager Inspectoru!"); 
        }

        SceneManager.LoadScene("MainScene");
        
    }

    public void ExitButton()
    {

        if (audioManager.tap != null)
        {
          audioManager.PlaySFX(audioManager.tap);
        }

        else
        {
          Debug.LogError("ColorPart: 'tap' AudioClip nije dodeljen u AudioManager Inspectoru!"); 
        }

        SceneManager.LoadScene("MainMenu");
    }
}
