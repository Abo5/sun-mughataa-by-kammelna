using System;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Sfs2X.Entities;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.UI;

namespace Kammelna.Server;

public static class VariableBinderExtensions
{
	private sealed class <>c__DisplayClass2_0
	{
		public TextMeshProUGUI tm;

		public User user;

		public string varName;

		public string defaultValue;

		internal void <Bind>b__0()
		{
			string variable = SFSExtensions.GetVariable(user, varName, defaultValue);
			TextMeshProExtensions.FixArabic(tm, variable);
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public TextMeshProUGUI tm;

		public Room room;

		public string varName;

		public string defaultValue;

		internal void <Bind>b__0()
		{
			string variable = SFSExtensions.GetVariable(room, varName, defaultValue);
			TextMeshProExtensions.FixArabic(tm, variable);
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public RankSetter rankSetter;

		public User user;

		internal void <Bind>b__0()
		{
			//IL_0026: Expected I, but got O
			//IL_0036: Expected O, but got I
			//IL_0046: Expected O, but got I
			RankSetter rankSetter = this.rankSetter;
			PlayerRank rank = SFSKammelnaUserExtensions.GetRank(user);
			nint num = (nint)rankSetter;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1 (Il2CppClass<RankSetter>)+1A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1 (Il2CppClass<RankSetter>)+1B0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v18 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public static void Bind(GameObject go, User user, string varName, Action action, object owner = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I
		//IL_00d9: Expected O, but got I
		//IL_00e9: Expected O, but got I
		//IL_00f9: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = go;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 32;
		obj5 = owner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		VariableBinder binder = SFS.Binder;
		if (user != null)
		{
			string bindID = binder.GetBindID(user);
			binder.Bind((BindAction)obj2, bindID, varName);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Object)+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v4+18]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v4+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v4+28]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v109 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	public static void Bind(GameObject go, Room room, string varName, Action action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_00c5: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_00fa: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = go;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 32;
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		VariableBinder binder = SFS.Binder;
		if (room != null)
		{
			string bindID = binder.GetBindID(room);
			binder.Bind((BindAction)obj2, bindID, varName);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v4+18]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v4+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v4+28]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v100 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	public static void Bind(TextMeshProUGUI tm, User user, string varName, string defaultValue = "NO VALUE")
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I
		//IL_00f0: Expected I, but got O
		//IL_0116: Expected O, but got I
		//IL_0116: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = tm;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = user;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 32;
		obj5 = varName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 40;
		obj6 = defaultValue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)2496;
		GameObject gameObject = ((Component)obj3).gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+20]");
		Bind(gameObject, (User)num, (string)0, action);
	}

	public static void Bind(TextMeshProUGUI tm, Room room, string varName, string defaultValue = "NO VALUE")
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I
		//IL_00f0: Expected I, but got O
		//IL_0115: Expected O, but got I
		//IL_0115: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 1704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = tm;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 32;
		obj5 = varName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 40;
		obj6 = defaultValue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)2504;
		GameObject gameObject = ((Component)obj3).gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+20]");
		Bind(gameObject, (Room)num, (string)0, action);
	}

	public static void Bind(RankSetter rankSetter, User user)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_007e: Expected O, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00ba: Expected I, but got O
		//IL_00d8: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 1712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = rankSetter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = user;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)2512;
		object varName = "placementId" + 1552;
		GameObject gameObject = ((Component)obj3).gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
		Bind(gameObject, (User)0, (string)varName, action);
	}

	public static void Unbind(GameObject go)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_005a: Expected O, but got I
		VariableBinder binder = SFS.Binder;
		binder.Unbind(go);
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3160;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4+B8]");
		object obj3 = 0;
		((CoordinatorVariableBinder)obj3).Unbind(go);
	}
}
