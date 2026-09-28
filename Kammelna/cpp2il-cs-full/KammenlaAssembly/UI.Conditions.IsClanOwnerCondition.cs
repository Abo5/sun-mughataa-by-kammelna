using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;

namespace UI.Conditions;

[Serializable]
public class IsClanOwnerCondition : BoolCondition
{
	protected override bool ActualValue
	{
		get
		{
			User mySelf = SFS.MySelf;
			if (mySelf != null)
			{
				User mySelf2 = SFS.MySelf;
				ClanUserModel clanMembership = SFSKammelnaUserExtensions.GetClanMembership(mySelf2);
				if (clanMembership != null)
				{
					return clanMembership.IsOwner;
				}
			}
			return false;
		}
	}

	public override void Setup(GameObject gm)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)560;
		object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3304;
		User mySelf = SFS.MySelf;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		VariableBinderExtensions.Bind(gm, mySelf, (string)varName, action, this);
	}

	public IsClanOwnerCondition()
	{
		isActive = true;
		((object)this)..ctor();
	}
}
