using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;

namespace UI.Conditions;

[Serializable]
public class ClanPermissionsCondition : FlagsCondition<ClanPermissions>
{
	protected override ClanPermissions ActualValue
	{
		get
		{
			//IL_0020: Expected I4, but got O
			//IL_0060: Expected I4, but got O
			User mySelf = SFS.MySelf;
			bool flag = mySelf == null;
			ClanPermissions result = (ClanPermissions)mySelf;
			if (!flag)
			{
				User mySelf2 = SFS.MySelf;
				ClanUserModel clanMembership = SFSKammelnaUserExtensions.GetClanMembership(mySelf2);
				bool flag2 = clanMembership == null;
				result = (ClanPermissions)clanMembership;
				if (!flag2)
				{
					result = clanMembership.Permissions;
				}
			}
			return result;
		}
	}

	public override void Setup(GameObject gm)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002c: Expected O, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_004e: Expected I, but got O
		object obj = (nint)0 + (nint)3328;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)3336;
		object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4AD859C");
		User mySelf = SFS.MySelf;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		VariableBinderExtensions.Bind(gm, mySelf, (string)varName, action, this);
	}

	public ClanPermissionsCondition()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)3320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4AD85B0");
	}
}
