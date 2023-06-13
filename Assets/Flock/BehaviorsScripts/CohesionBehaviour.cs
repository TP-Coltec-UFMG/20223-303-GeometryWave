using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/Cohesion")]
public class CohesionBehaviour : FlockBehavior
{
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        // Se n�o tem vizinhos, n�o tem mudan�a;

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

        //Transforma em deslocamento em rela��o a posi��o atual;

        cohesionMove -= (Vector2)agent.transform.position;

        return cohesionMove;

    }


}
