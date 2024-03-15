using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Connection
{
	[SerializeField] private Knot incomingKnot;
	[SerializeField] private Knot outgoingKnot;
	[SerializeField] private int incomingIndex;
	[SerializeField] private int outgoingIndex;



	public Connection(Knot _incoming, Knot _outgoing, int _incomingIndex, int _outgoingIndex)
	{
		incomingKnot = _incoming;
		outgoingKnot = _outgoing;
		incomingIndex = _incomingIndex;
		outgoingIndex = _outgoingIndex;
	}


}
