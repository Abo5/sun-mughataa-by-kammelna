using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class LobbyEventAnnouncer : MonoBehaviour
{
	private KGame _game;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_008b: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 32;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_004f: Expected I, but got O
		//IL_0060: Expected O, but got I
		//IL_0094: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
		object obj4 = (nint)0 + (nint)1480;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		object obj7 = (nint)0 + (nint)1488;
		SessionModel sessionModel = default(SessionModel);
		sessionModel.OnUserJoinedRoom += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj7);
		SessionModel sessionModel2 = default(SessionModel);
		sessionModel2.OnUserLeftRoom += action2;
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_004f: Expected I, but got O
		//IL_0060: Expected O, but got I
		//IL_0094: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
		object obj4 = (nint)0 + (nint)1480;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		object obj7 = (nint)0 + (nint)1488;
		SessionModel sessionModel = default(SessionModel);
		sessionModel.OnUserJoinedRoom -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj7);
		SessionModel sessionModel2 = default(SessionModel);
		sessionModel2.OnUserLeftRoom -= action2;
	}

	private void UserJoined(User u)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		KGame game = _game;
		if (!game.<GamePhase>k__BackingField.IsGameStarted)
		{
			object announcement = "utf-32" + 3936;
			ShowAnnouncement(u, (string)announcement);
		}
	}

	private void UserLeft(User u)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		KGame game = _game;
		if (!game.<GamePhase>k__BackingField.IsGameStarted)
		{
			object announcement = "utf-32" + 3944;
			ShowAnnouncement(u, (string)announcement);
		}
	}

	private static void ShowAnnouncement(User u, string announcement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0150: Expected O, but got I4
		//IL_0031: Expected O, but got I4
		//IL_0047: Expected I, but got O
		//IL_0057: Expected O, but got I
		//IL_0080: Expected O, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0121: Expected O, but got I4
		//IL_01c8: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string userName = SFSKammelnaUserExtensions.GetUserName(u);
		object[] array = default(object[]);
		object obj2;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj3;
		if (array != null)
		{
			bool flag = userName == null;
			obj2 = 0;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v8 (Il2CppClass<System.Object[]>)+40]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v8 (Il2CppClass<System.Object[]>)+40]");
				obj3 = 0;
				if (flag2)
				{
					goto IL_016b;
				}
			}
			if (array.Length != 0)
			{
				object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
				object obj5 = array + 32;
				obj5 = userName;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				LocalizableText text = TextMeshProExtensions.LocalizeWith(announcement, array);
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Toast.Show(text, (Vector2)0, 0f);
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj2 = 0;
		}
		ex = new IndexOutOfRangeException();
		obj3 = obj2;
		goto IL_016b;
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}
}
