using System;
using DG.Tweening;
using Jackaroo;
using UnityEngine;

public abstract class ICustomMarbleMove : MonoBehaviour
{
	private GameAction <GameAction>k__BackingField;

	private bool <UseDefaultSound>k__BackingField;

	public GameAction GameAction
	{
		get
		{
			return <GameAction>k__BackingField;
		}
		protected set
		{
			<GameAction>k__BackingField = value;
		}
	}

	public bool UseDefaultSound
	{
		get
		{
			return <UseDefaultSound>k__BackingField;
		}
		protected set
		{
			<UseDefaultSound>k__BackingField = value;
		}
	}

	public abstract (Sequence, bool, AudioClip, Action<JackarooMarble, JackarooNode>, AudioClip) Move(JackarooMarble target, float duration, JackarooNodeMono[] nodes, int index, Transform board, Transform playGround, Transform effectsLayer);
}
