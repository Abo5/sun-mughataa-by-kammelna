using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using TMPro;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class NewVersionPopup : MonoBehaviour, IInitializable
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<NewVersionPopup> <>9__4_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 784;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Show>b__4_0(NewVersionPopup versionPopup)
		{
			versionPopup.Initialize();
		}
	}

	private static readonly AddressReference<NewVersionPopup> MainPrefabAddress;

	private const string VersionDifferenceMessage = "Current version: {0} - New Version: {1}";

	private PopupUI popup;

	private TextMeshProUGUI version;

	public static void Show()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_0207: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02d5: Expected O, but got I
		//IL_02e5: Expected O, but got I
		//IL_0307: Expected O, but got I4
		//IL_0247: Expected O, but got I
		//IL_0279: Expected O, but got I4
		//IL_0173: Expected O, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0122: Expected O, but got I
		//IL_0132: Expected O, but got I
		//IL_034f: Expected O, but got I4
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_0439: Expected O, but got I
		//IL_044a: Expected I, but got O
		//IL_0468: Expected O, but got I
		//IL_0390: Expected O, but got I
		//IL_03ba: Expected O, but got I4
		//IL_037f: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77AD]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 784;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v43+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			obj7 = obj4;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 784;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v43+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v17+B8]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		obj4 = obj7;
		object obj14 = obj12;
		object obj15 = obj10;
		if (obj13 != null)
		{
			goto IL_00fe;
		}
		goto IL_029f;
		IL_0167:
		object obj16 = (nint)0 + (nint)2168;
		object obj18;
		object obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj19 = obj16;
		obj15 = obj11;
		Action<object> action2;
		Action<object> action = action2;
		if (!flag4)
		{
			goto IL_01b8;
		}
		goto IL_03e8;
		IL_03e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj16 = obj19;
		obj11 = obj15;
		action2 = action;
		goto IL_01b8;
		IL_01b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
		return;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v43+B8]");
		object obj20 = 0;
		obj11 = obj20;
		obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+E4]");
		bool flag5 = (nint)0 == 0;
		obj14 = obj12;
		obj7 = obj4;
		obj15 = obj20;
		if (!flag5)
		{
			goto IL_00fe;
		}
		goto IL_029f;
		IL_029f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj12 = obj7;
		obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v4+8]");
		action2 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v4+8]");
		bool flag6 = (nint)0 == 0;
		object obj22 = !flag6;
		obj11 = obj15;
		object obj23 = obj18;
		obj4 = obj7;
		if (obj22 != null)
		{
			goto IL_0167;
		}
		goto IL_032d;
		IL_00fe:
		obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+B8]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v4+8]");
		action2 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v4+8]");
		bool flag7 = (nint)0 == 0;
		obj23 = obj18;
		obj15 = obj11;
		if (!flag7)
		{
			goto IL_0167;
		}
		goto IL_032d;
		IL_032d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v11+B8]");
			obj21 = 0;
		}
		object obj26 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)2576;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj21, (IntPtr)obj27);
		object obj28 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v9+B8]");
		object obj29 = (nint)0 + (nint)8;
		obj29 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj16 = (nint)0 + (nint)2168;
		obj17 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v1+E4]");
		bool flag9 = (nint)0 == 0;
		object obj30 = !flag9;
		obj11 = obj15;
		action2 = action3;
		obj19 = obj16;
		action = action3;
		if (obj30 != null)
		{
			goto IL_01b8;
		}
		goto IL_03e8;
	}

	public void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0374: Expected O, but got I4
		//IL_005d: Expected O, but got I4
		//IL_0083: Expected O, but got I4
		//IL_0099: Expected I, but got O
		//IL_00a9: Expected O, but got I
		//IL_00d2: Expected O, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0183: Expected O, but got I4
		//IL_0266: Expected O, but got I8
		//IL_0203: Expected I, but got O
		//IL_0213: Expected O, but got I
		//IL_0244: Expected O, but got I
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = Application.version;
		object[] array = default(object[]);
		bool flag2 = array == null;
		string text2 = (string)2;
		if (flag2)
		{
			goto IL_0306;
		}
		bool flag3 = text == null;
		text2 = (string)2;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		string text3;
		if (!flag3)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
			text2 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag4 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
			text3 = (string)0;
			if (flag4)
			{
				goto IL_032a;
			}
		}
		string text4;
		string text5;
		if (array.Length != 0)
		{
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj6 = array + 32;
			obj6 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v19+E4]");
			if ((nint)0 != 0)
			{
				string newVersion = Config.NewVersion;
				bool flag5 = newVersion == null;
				object obj8 = !flag5;
				text4 = newVersion;
				if (obj8 != null)
				{
					goto IL_01fb;
				}
				text2 = text;
				text5 = newVersion;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				string newVersion2 = Config.NewVersion;
				bool flag6 = newVersion2 == null;
				text4 = newVersion2;
				text2 = text;
				text5 = newVersion2;
				if (!flag6)
				{
					goto IL_01fb;
				}
			}
			goto IL_0252;
		}
		goto IL_0314;
		IL_0306:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0314;
		IL_0252:
		object obj9 = array.Length & 0xFFFFFFFEL;
		if (obj9 != null)
		{
			object obj10 = "Complete" + 3472;
			object obj11 = array + 40;
			obj11 = text5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			text2 = (string)obj10;
			TextMeshProExtensions.Localize(version, (string)obj10, array);
			if ((object)popup != null)
			{
				popup.PopFromCenter(1f);
				return;
			}
			goto IL_0306;
		}
		goto IL_0314;
		IL_032a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0314:
		ex = new IndexOutOfRangeException();
		text3 = text2;
		goto IL_032a;
		IL_01fb:
		nint num2 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
		text2 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag7 = ex == null;
		text5 = text4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
		text3 = (string)0;
		if (!flag7)
		{
			goto IL_0252;
		}
		goto IL_032a;
	}

	public void OnButtonDownloadClick()
	{
		KammelnaURL.OpenUpdatePage();
	}

	static NewVersionPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "Network Authentication Required" + 128;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3080;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
