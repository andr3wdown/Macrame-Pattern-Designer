using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knot : MonoBehaviour
{
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

			


		initialized = true;
	}

	void CalculateSpots()
	{

	}



	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;





		Gizmos.DrawWireSphere(transform.position, 0.5f);
	}
}
