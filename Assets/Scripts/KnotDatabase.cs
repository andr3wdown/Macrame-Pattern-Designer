using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnotDatabase : MonoBehaviour
{
	private static KnotDatabase instance;
	[SerializeField]private KnotData[] database;
	private void Awake()
	{
		instance = this;

	}
	private void Start()
	{
		if(instance != this)
		{
			Destroy(gameObject);
		}
	}
	public static KnotData GetKnotByID(int id)
	{
		if (id > instance.database.Length)
		{
			Debug.LogError("id in out of range");
		}
		return instance.database[id];

	}
}
