using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Conditions;

[Serializable]
public class FireModeCondition : BoolCondition
{
	private GameEventsChannel _gameEventsChannel;

	protected override bool ActualValue
	{
		get
		{
			//IL_0041: Expected I4, but got O
			GameEventsChannel gameEventsChannel = _gameEventsChannel;
			if ((object)_gameEventsChannel != null)
			{
				return gameEventsChannel.isFireModeActive;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public override void Setup(GameObject gm)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_007e: Expected I, but got O
		//IL_0051: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		_gameEventsChannel.OnActivateFireMode += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj2);
		_gameEventsChannel.OnDeactivateFireMode += action2;
	}

	public override void Teardown()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_007e: Expected I, but got O
		//IL_0051: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		_gameEventsChannel.OnActivateFireMode -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj2);
		_gameEventsChannel.OnDeactivateFireMode -= action2;
	}

	public FireModeCondition()
	{
		isActive = true;
		((object)this)..ctor();
	}
}
