using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/Alignment")]
public class AlignmentBehaviour : FlockBehavior
{

    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        // Se n�o tem vizinhos, n�o tem mudan�a e retorna o alinhamento atual;

        if (context.Count == 0)
        {
            return agent.transform.up;
        }

        // Calcula a media entre os vizinhos;
        Vector2 alignmentMove = Vector2.zero;

        foreach (Transform item in context)
        {
            alignmentMove += (Vector2)(item.transform.up);
        }

        alignmentMove /= context.Count;

        return alignmentMove;

    }

}
