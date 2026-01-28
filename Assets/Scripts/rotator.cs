using UnityEngine;

public class rotator : MonoBehaviour
{

public float rotationSpeed=100f;  //brzina rotacije prepreke 100 stepeni svake sekunde

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime); //rotiramo 0 po x i y i po z rS
    }
}
