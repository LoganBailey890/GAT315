using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Intergrater
{
    public static void ExplicitEuler(Body body, float dt)
    {

        body.position += body.velocity * dt;
        body.velocity += body.acceleration * dt;
    }

    public static void SemiImplicitEuler(Body body,float dt)
    {
        body.velocity += body.velocity * dt;
        body.position += body.position * dt;
    }
}
