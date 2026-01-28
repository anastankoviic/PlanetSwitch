using UnityEngine;

public class AudioManager : MonoBehaviour
{
   [SerializeField] AudioSource soundSource;



   public AudioClip gameOver;
   public AudioClip victory;
   public AudioClip stars;
   public AudioClip tap;



   public void PlaySFX(AudioClip clip)
    {
        soundSource.PlayOneShot(clip);
    }

}
