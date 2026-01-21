using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{

public float jumpForce=10f; //visina koliko ce loptica da skoci

public Rigidbody2D rb; //fizika

public string currentColor;



public SpriteRenderer sr;
public Sprite[] planetSprites;
private int currentPlanetIndex=0;
    void Start()
    {
        sr.sprite=planetSprites[currentPlanetIndex];

     
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true) //pita unity da li je pritisnut space
        {
             rb.linearVelocity=Vector2.up * jumpForce; 
        }

        SetColor(); //postavlja neptun na plavu boju
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlanetChanger")) //kada igrac prodje prepreku i dodje do collidera poziva se metoda 
        {
            NextPlanet();     //menja se sprite
            Destroy(collision.gameObject);  //collider nestaje
        }

                
        

        Debug.Log(collision.tag);  //kada se desi kolizija ispisace se u konzoli
    }

    void NextPlanet()
    {
        currentPlanetIndex++;

        if (currentPlanetIndex>=planetSprites.Length)
        {
            currentPlanetIndex=planetSprites.Length-1;
        }

        sr.sprite = planetSprites[currentPlanetIndex]; //sprite renderer uzima planetu sa indeksa
        
        SetColor(); //azurira boje
    }
   
    void SetColor()
    {
        //da bi povezali prepreke i planete
        switch (currentPlanetIndex)
        {
            case 0:
            currentColor="Blue";
            break;

            case 1:
            currentColor="Aqua";
            break;

            case 2:
            currentColor="Pink";
            break;

            case 3:
            currentColor="Orange";
            break;

            case 4:
            currentColor="Red";
            break;

            case 5:
            currentColor="Green";
            break;

            case 6:
            currentColor="Yellow";
            break;

            case 7:
            currentColor="Grey";
            break;

            
        }
    }



}
