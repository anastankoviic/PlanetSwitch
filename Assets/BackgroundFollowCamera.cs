using UnityEngine;

public class BackgroundFollowCamera : MonoBehaviour
{
    public Transform cam;
    public float speed = 1f; // 1f ide brzinom kamere
    private Vector3 startPos; //pamti pocetnu poziciju pozadine

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!cam) {
          cam = Camera.main.transform; //ako kamera nije dodeljenja uzima glavnu
        }

        startPos = transform.position; //postavlja trenutnu poziciju na start
    }

    // Update is called once per frame
    void LateUpdate() //pozadina se pomera posle kamere
    {
        Vector3 p = transform.position;  //trenutna pozicija
        p.y = startPos.y + cam.position.y * speed;  //racuna novu y poziciju
        transform.position = p; //pomera pozadinu na novu poziciju
    }
}
