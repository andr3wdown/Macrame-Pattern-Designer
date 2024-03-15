using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern : MonoBehaviour
{

	[SerializeField] private float distance = 14f;
	[Range(0f, 2f)]
	[SerializeField] private float thickness = 0.1f;
	[SerializeField] private Transform barGraphic;
	private Vector2 start;
	private Vector2 end;
	bool initialized = false;


	
	void Setup()
	{
		start = (Vector2)transform.position + new Vector2(-distance / 2f, 0);
		end = (Vector2)transform.position + new Vector2(distance / 2, 0);
		barGraphic.localScale = new Vector3(distance, thickness, 1f);
		initialized = true;
	}
    void Start()
    {
		if (!initialized)
		{
			Setup();
		}
    }
    void Update()
    {
		Setup();
	}
	private void OnDrawGizmos()
	{
		if (!initialized)
		{
			Setup();
		}
		
		Gizmos.color = Color.magenta;


		Gizmos.DrawWireSphere(start, 0.3f);
		Gizmos.DrawWireSphere(end, 0.3f);
	}
}
