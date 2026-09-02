using UnityEngine;

public class Desafio_5 : MonoBehaviour
{
    public string jogador_1;
    public string jogador_2;
    public int mao_jogador_1;
    public int mao_jogador_2;
    public bool jogador1EscolheuPar;

    void Start()
    {
        int soma = mao_jogador_1 + mao_jogador_2;
        if (jogador1EscolheuPar == true)
        {
            if (soma % 2 == 0)
            {
                Debug.Log(soma + " é um número par, portanto o " + jogador_1 + " venceu!");
            }
            else
            {
                Debug.Log(soma + " é um número ímpar, portanto o " + jogador_2 + " venceu!");

            }
        }
        else
        {
            if (soma % 2 == 0)
            {
                Debug.Log(soma + " é um numero par, portanto o " + jogador_2 + " venceu!");
            }
            else
            {
                Debug.Log(soma + " é um numero ímpar, portanto o " + jogador_1 + " venceu!");

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
