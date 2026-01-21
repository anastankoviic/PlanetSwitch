using UnityEngine;

public class Finish : MonoBehaviour
{
    

    // Update is called once per frame
    
        void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) //kada igrac prodje prepreku i dodje do collidera poziva se metoda 
        {
            Destroy(collision.gameObject);  //collider nestaje
        }

                
        

        Debug.Log(collision.tag);  //kada se desi kolizija ispisace se u konzoli
    }
    
}
