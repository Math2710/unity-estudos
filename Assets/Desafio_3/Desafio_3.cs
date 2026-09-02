using UnityEngine;

public class Desafio_3 : MonoBehaviour
{
    public string runa;
    void Start()
    {
        if (runa == "A" || runa == "E" || runa == "I" || runa == "O" || runa == "U")
        {
            Debug.Log("Runa " + runa + " encontrada: magia de cura!");
        }
        else
        {
            Debug.Log("Runa " + runa + " encontrada: magia de ataque!");
        }
    }

    void Update()
    {
        
    }
}
