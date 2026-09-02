using UnityEngine;
using UnityEngine.Video;

public class Desafio1 : MonoBehaviour
{

    public int vida = 100;
    public int dano = 10;
    int dano_recebido;
    
    void Start()
    {
        dano_recebido = vida - dano;
        Debug.Log("Sua vida atual é " + vida + " e seu dano é " + dano);
        Debug.Log(vida + " de vida - " + dano + " de dano é igual a " + dano_recebido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
