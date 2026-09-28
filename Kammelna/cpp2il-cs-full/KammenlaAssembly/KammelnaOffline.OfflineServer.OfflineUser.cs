using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Sfs2X.Entities.Managers;
using Sfs2X.Entities.Variables;
using UnityEngine.InputSystem.XR;
using Util;

namespace KammelnaOffline.OfflineServer;

public class OfflineUser : User
{
	private readonly int <Id>k__BackingField;

	private readonly string <Name>k__BackingField;

	private readonly Dictionary<string, UserVariable> _variables;

	private readonly bool <IsPlayer>k__BackingField;

	private Dictionary<string, object> <Properties>k__BackingField;

	public int Id => <Id>k__BackingField;

	public string Name => <Name>k__BackingField;

	public int PlayerId => 1;

	public bool IsPlayer => <IsPlayer>k__BackingField;

	public bool IsSpectator
	{
		get
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected I4, but got Unknown
			object obj = ~(<IsPlayer>k__BackingField ? 1 : 0);
			return (byte)(1 & obj) != 0;
		}
	}

	public bool IsItMe
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_009e: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0092: Expected I4, but got O
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			string dbId = SFSKammelnaUserExtensions.GetDbId(this);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				string dbId2 = SFSKammelnaUserExtensions.GetDbId(localUser);
				return dbId == dbId2;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public Dictionary<string, object> Properties
	{
		get
		{
			return <Properties>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int PrivilegeId
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			//IL_005f: Expected I4, but got O
			object obj = typeof(MemberAchievementClanFeedData) + 2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotImplementedException ex = default(NotImplementedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1960;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			OutOfMemoryException ex2 = new OutOfMemoryException();
			return (int)ex2;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotImplementedException ex = default(NotImplementedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1984;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	public IUserManager UserManager
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotImplementedException ex = default(NotImplementedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1968;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return (IUserManager)new OutOfMemoryException();
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotImplementedException ex = default(NotImplementedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	public Vec3D AOIEntryPoint
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotImplementedException ex = default(NotImplementedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1952;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return (Vec3D)(object)new OutOfMemoryException();
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotImplementedException ex = default(NotImplementedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	public OfflineUser(int id, string DBId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj2 = this + 32;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<IsPlayer>k__BackingField = true;
		base..ctor();
		object obj3 = this + 24;
		obj3 = DBId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public OfflineUser(int id, string DBId, bool isPlayer)
		: this(id, DBId)
	{
		<IsPlayer>k__BackingField = isPlayer;
	}

	public unsafe OfflineUser(CachedUserInfoModel userModel)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0181: Expected O, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_0340: Expected O, but got I
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_038b: Expected O, but got I4
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_0475: Expected O, but got I4
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 3280;
		object obj2 = "m_StencilDeferredPS" + 2848;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3064;
		object obj4 = "setMimeType" + 3808;
		object obj5 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1976;
		object obj6 = "placementId" + 1552;
		this..ctor(1, userModel.DbId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = default(object);
		obj7..ctor();
		object obj8 = obj7 + 24;
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 4;
		object obj9 = obj7 + 32;
		obj9 = userModel.UserName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AddVariable((UserVariable)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = default(object);
		obj10..ctor();
		object obj11 = obj10 + 24;
		obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 2;
		object obj12 = obj10 + 32;
		object obj13 = default(object);
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AddVariable((UserVariable)obj10);
		object obj14 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = default(object);
		obj15..ctor();
		object obj16 = obj15 + 24;
		obj16 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 2;
		object obj17 = obj15 + 32;
		object obj18 = default(object);
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AddVariable((UserVariable)obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = default(object);
		obj19..ctor();
		object obj20 = obj19 + 24;
		obj20 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 2;
		object obj21 = obj19 + 32;
		object obj22 = default(object);
		obj21 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AddVariable((UserVariable)obj19);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = "https://www.kammelna.com/Home/Terms" + 3000;
		object obj24 = default(object);
		obj24..ctor();
		object obj25 = obj24 + 24;
		obj25 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 1;
		object obj26 = obj24 + 32;
		object obj27 = default(object);
		obj26 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AddVariable((UserVariable)obj24);
		DateTime? dateTime = (DateTime?)(object)(userModel + 64);
		if ((nint)dateTime == 1)
		{
			object obj28 = (nint)0 + (nint)2296;
			DateTime value = ((DateTime?*)dateTime)->Value;
			object obj29 = typeof(DataRelation) + 824;
			object obj30 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj31 = !flag;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long value2 = DateTimeUtil.ToEpochMilli(value);
			object obj32 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			object obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v20+E4]");
			bool flag2 = (nint)0 == 0;
			object obj34 = !flag2;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num = Convert.ToDouble(value2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj35 = "___# Content push apply failed [{0}]: {1}" + 3224;
			object obj36 = default(object);
			obj36..ctor();
			object obj37 = obj36 + 24;
			obj37 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 3;
			object obj38 = obj36 + 32;
			object obj39 = default(object);
			obj38 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			AddVariable((UserVariable)obj36);
		}
	}

	private void AddVariable(UserVariable variable)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_011c: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 664;
		nint num = (nint)variable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Variables.UserVariable>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Variables.UserVariable>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Variables.UserVariable>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v6-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj4 = num + obj3;
		object obj5 = obj4 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v195 @ X0_v10] (should have been resolved before IL gen)");
		bool flag = _variables == null;
		object obj6 = !flag;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00c6;
		IL_00c6:
		object key = default(object);
		((Dictionary<object, object>)(object)_variables).Add(key, (object)variable);
		return;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v132 @ X0_v7] (should have been resolved before IL gen)");
		goto IL_00c6;
	}

	public bool ContainsVariable(string name)
	{
		//IL_002c: Expected I4, but got O
		if (_variables != null)
		{
			return ((Dictionary<object, object>)(object)_variables).ContainsKey((object)name);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public int GetPlayerId(Room room)
	{
		if (<IsPlayer>k__BackingField)
		{
			return <Id>k__BackingField;
		}
		return 1;
	}

	public UserVariable GetVariable(string varName)
	{
		//IL_0037: Expected O, but got I4
		if (_variables != null)
		{
			object value;
			bool flag = ((Dictionary<object, object>)(object)_variables).TryGetValue((object)varName, out value);
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				return (UserVariable)value;
			}
			return null;
		}
		return (UserVariable)new NullReferenceException();
	}

	public List<UserVariable> GetVariables()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (List<UserVariable>)(object)new OutOfMemoryException();
	}

	public bool IsAdmin()
	{
		return false;
	}

	public bool IsGuest()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_005f: Expected I4, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (byte)(int)ex2 != 0;
	}

	public bool IsJoinedInRoom(Room room)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_005f: Expected I4, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (byte)(int)ex2 != 0;
	}

	public bool IsModerator()
	{
		return false;
	}

	public bool IsPlayerInRoom(Room room)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_005f: Expected I4, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (byte)(int)ex2 != 0;
	}

	public bool IsSpectatorInRoom(Room room)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_005f: Expected I4, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (byte)(int)ex2 != 0;
	}

	public bool IsStandardUser()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_005f: Expected I4, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (byte)(int)ex2 != 0;
	}

	public void RemovePlayerId(Room room)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public void SetPlayerId(int id, Room room)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public void SetVariable(UserVariable userVariable)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public void SetVariables(ICollection<UserVariable> userVariables)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}
}
