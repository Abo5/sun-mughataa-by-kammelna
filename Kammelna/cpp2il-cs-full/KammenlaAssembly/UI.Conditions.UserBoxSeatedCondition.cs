using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Conditions;

[Serializable]
public class UserBoxSeatedCondition : BoolCondition
{
	private Userbox userbox;

	protected override bool ActualValue
	{
		get
		{
			//IL_0074: Expected I4, but got O
			//IL_0037: Expected I4, but got O
			//IL_0066: Expected I4, but got O
			Userbox userbox = this.userbox;
			if ((object)this.userbox != null)
			{
				if ((int)(~userbox.<player>k__BackingField) == 0)
				{
					return userbox.<player>k__BackingField.IsHuman;
				}
				return (byte)(int)userbox.<player>k__BackingField != 0;
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
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		userbox.OnUserRefreshed += action;
	}

	public UserBoxSeatedCondition()
	{
		isActive = true;
		((object)this)..ctor();
	}
}
