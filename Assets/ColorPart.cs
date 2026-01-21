using UnityEngine;

public class ColorPart : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();

            if (player.currentColor != gameObject.tag)
            {
                Debug.Log(collision.tag);
                Debug.Log("GAME OVER");
                Destroy(collision.gameObject); //unistava igraca
            }
        }
    }
}
