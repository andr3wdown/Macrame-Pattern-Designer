using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="newKnot", menuName ="Create Knot/new knot", order = 0)]
public class KnotData : ScriptableObject
{
	[SerializeField] public new string name;
	[SerializeField] public int inputCount;
	[SerializeField] public int outputCount;

}
