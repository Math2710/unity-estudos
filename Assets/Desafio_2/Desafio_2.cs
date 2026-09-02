using UnityEngine;

public class Desafio_2 : MonoBehaviour
{
    public int danoGoblin = 10;
    public int danoEsqueleto = 20;
    public int danoOrc = 30;

    int maior_dano;
    string inimigo = "";

    void Start()
    {
        if (danoGoblin > danoEsqueleto && danoGoblin > danoOrc)
        {
            maior_dano = danoGoblin;
            inimigo = "Goblin";
        }
        else if (danoEsqueleto > danoGoblin && danoEsqueleto > danoOrc)
        {
            maior_dano = danoEsqueleto;
            inimigo = "Esqueleto";
        }
        else
        {
            maior_dano = danoOrc;
            inimigo = "Orc";
        }

        Debug.Log("O inimigo mais forte é o " + inimigo +
                  " com " + maior_dano + " de dano.");
    }

    void Update()
    {

    }
}