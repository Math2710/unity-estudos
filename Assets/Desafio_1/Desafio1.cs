using UnityEngine;
using UnityEngine.Video;

public class Desafio_1 : MonoBehaviour
{

    public int vida = 100;
    public int dano = 10;
    int vida_restante;
    
    void Start()
    {
        vida_restante = vida - dano;
        Debug.Log("Sua vida atual é " + vida + " e seu dano é " + dano);
        Debug.Log(vida + " de vida - " + dano + " de dano é igual a " + vida_restante);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
