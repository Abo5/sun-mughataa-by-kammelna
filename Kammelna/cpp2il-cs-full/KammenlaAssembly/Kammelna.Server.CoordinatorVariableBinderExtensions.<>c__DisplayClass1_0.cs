using System;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;

namespace Kammelna.Server;

public static class CoordinatorVariableBinderExtensions
{
	private sealed class <>c__DisplayClass1_0
	{
		public string scope;

		public string variableName;

		public TextMeshProUGUI tm;

		public string defaultValue;

		internal void <Bind>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_008c: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3160;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			string current = ((CoordinatorVariableBinder)obj3).GetCurrent(scope, variableName);
			bool flag = string.IsNullOrEmpty(current);
			bool flag2 = !flag;
			string text = current;
			if (!flag2)
			{
				text = defaultValue;
			}
			TextMeshProExtensions.FixArabic(tm, text);
		}
	}

	public static void Bind(GameObject go, string scope, string variableName, Action action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_007c: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BindAction bindAction = default(BindAction);
		bindAction..ctor(go, action);
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3160;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v5+B8]");
		object obj4 = 0;
		((CoordinatorVariableBinder)obj4).Bind(bindAction, scope, variableName);
	}

	public static void Bind(TextMeshProUGUI tm, string scope, string variableName, string defaultValue = "NO VALUE")
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
		object obj = typeof(CardUtils.<>c) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = scope;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = variableName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 32;
		obj5 = tm;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 40;
		obj6 = defaultValue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)3680;
		GameObject gameObject = ((Component)obj5).gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+18]");
		Bind(gameObject, (string)num, (string)0, action);
	}
}
