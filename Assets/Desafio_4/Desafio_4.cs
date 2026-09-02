using UnityEngine;

public class Desafio_4 : MonoBehaviour
{
    public int ladoA = 0;
    public int ladoB = 0;
    public int ladoC = 0;
    void Start()
    {
        if (ladoA == ladoB && ladoB == ladoC)
        {
            Debug.Log("Runa Perfeita encontrada! Poder mágico máximo.");
        }
        else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
        {
            Debug.Log("Runa Balanceada encontrada! Poder mágico médio.");
        }
        else
        {
            Debug.Log("Runa Instável encontrada! Poder mágico baixo.");
        }
    }
    void Update()
    {

    }
}
