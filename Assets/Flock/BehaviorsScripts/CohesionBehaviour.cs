using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/Cohesion")]
public class CohesionBehaviour : FlockBehavior
{
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        // Se não tem vizinhos, não tem mudança;

        if(context.Count == 0) { 
            return Vector2.zero;
        }

        // Calcula a media entre os vizinhos;
        Vector2 cohesionMove = Vector2.zero;

        foreach(Transform item in context)
        {
            cohesionMove += (Vector2)(item.position);
        }

        cohesionMove /= context.Count;

        //Transforma em deslocamento em relação a posição atual;

        cohesionMove -= (Vector2)agent.transform.position;

        return cohesionMove;

    }


}
