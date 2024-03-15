using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knot : MonoBehaviour
{
	[Range(0f, 45f)]
	[SerializeField] private float angle;
	[Range(0, 2f)]
	[SerializeField] private float circleRadius;
	[SerializeField] private int id;
	[SerializeField] private Connection[] inputs;
	[SerializeField] private Connection[] outputs;
	private Vector2[] inputSpot;
	private Vector2[] outputSpot;
	private bool initialized = false;

	private void Start()
	{
		Setup();
	}
	void Setup()
	{
		KnotData data = KnotDatabase.GetKnotByID(id);
		inputs = new Connection[data.inputCount];
		outputs = new Connection[data.outputCount];
		inputSpot = data.inputCount > 0 ? CalculateSpots(true, data.inputCount) : new Vector2[0];
		outputSpot = data.outputCount > 0 ? CalculateSpots(false, data.outputCount) : new Vector2[0];

		initialized = true;
	}

	Vector2[] CalculateSpots(bool input, int amount)
	{
		Vector2[] spots = new Vector2[amount];

		float initialAngle = input ? 90f : -90f; 
		float workingAngle = initialAngle - ((amount/2f) * angle) + (angle * 0.5f);

		for(int i = 0; i < spots.Length; i++)
		{
			float currentAngle = workingAngle + i * angle;
			Vector2 spot = UnitCircleSpotFromAngle(currentAngle);
			spots[i] = spot;
		}
		return spots;
	}
	Vector2 UnitCircleSpotFromAngle(float angle)
	{
		float rad = angle * Mathf.Deg2Rad;
		return new Vector2(Mathf.Cos(rad), Mathf.Sin(rad)) * circleRadius;
	}


	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, 0.5f);
		if (initialized)
		{
			Gizmos.color = Color.green;
			for (int i = 0; i < inputSpot.Length; i++)
			{
				Gizmos.DrawWireSphere((Vector2)transform.position + inputSpot[i], 0.1f);
			}
			Gizmos.color = Color.blue;
			Debug.Log(outputSpot.Length);
			for (int i = 0; i < outputSpot.Length; i++)
			{
				Gizmos.DrawWireSphere((Vector2)transform.position + outputSpot[i], 0.1f);
			}
		}
		

	}
}
