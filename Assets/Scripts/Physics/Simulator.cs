using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulator : Singleton<Simulator>
{
	Camera activeCamera;

	public List<Body> bodies = new List<Body>();

	private void Update()
    {
        foreach (var body in bodies)
        {
			Intergrater.SemiImplicitEuler(body, Time.deltaTime);
        }
    }
    private void Start()
	{
		activeCamera = Camera.main;
	}

	public Vector3 GetScreenToWorldPosition(Vector2 screen)
	{
		Vector3 world = activeCamera.ScreenToWorldPoint(screen);
		return new Vector3(world.x, world.y, 0);
	}
}
