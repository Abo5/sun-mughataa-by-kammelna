using System;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Server.Models;
using TMPro;
using Unity.Properties;
using UnityEngine;

public class ClanTopXCountLabel : MonoBehaviour
{
	private TextMeshProUGUI label;

	private bool useKeyFromLabelText;

	private string localizationKey;

	private string _key;

	private void Awake()
	{
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01b1: Expected O, but got I
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_011f: Expected I, but got O
		//IL_00e2: Expected O, but got I4
		//IL_00eb: Expected O, but got I4
		//IL_00f4: Expected O, but got I4
		//IL_006e: Expected O, but got I4
		//IL_0077: Expected O, but got I4
		object obj3;
		object obj4;
		if (useKeyFromLabelText)
		{
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				bool flag = label != null;
				bool flag2 = !flag;
				obj3 = 0;
				obj4 = 0;
				if (!flag2)
				{
					goto IL_0085;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = label != null;
				bool flag4 = !flag3;
				object obj5 = !flag4;
				obj3 = 0;
				obj4 = 0;
				if (obj5 != null)
				{
					goto IL_0085;
				}
			}
		}
		string text = localizationKey;
		goto IL_0191;
		IL_0085:
		string text2 = label.text;
		obj4 = obj3;
		text = text2;
		goto IL_0191;
		IL_0191:
		object obj6 = typeof(SqlSingle[]) + 2376;
		object obj7 = (nint)0 + (nint)1672;
		object obj8 = typeof(RegisteredWaitHandle) + 56;
		object obj9 = this + 56;
		obj9 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ApplyConfig();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj7);
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			RemoteConfig.OnChanged += action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfig.OnChanged += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1672;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
	}

	private unsafe void ApplyConfig()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_01cf: Expected O, but got I4
		//IL_01d8: Expected O, but got I4
		//IL_0187: Expected O, but got I4
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0236: Expected O, but got I4
		//IL_0297: Expected I, but got O
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E867F]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v28+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v28+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		if (current != null)
		{
			goto IL_011d;
		}
		goto IL_0340;
		IL_0340:
		NullReferenceException ex = new NullReferenceException();
		goto IL_034e;
		IL_035c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_034e:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_035c;
		IL_0074:
		current = RemoteConfig.Current;
		bool flag2 = current == null;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			goto IL_011d;
		}
		goto IL_0340;
		IL_011d:
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = label == null;
			bool flag4 = !flag3;
			object obj8 = 0;
			if (!flag4)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = label == null;
			bool flag6 = !flag5;
			object obj9 = !flag6;
			object obj8 = 0;
			if (obj9 != null)
			{
				return;
			}
		}
		if (current.<Clans>k__BackingField == null)
		{
			return;
		}
		object obj10 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj11 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		bool flag7 = array == null;
		int num2 = default(int);
		nint num = (nint)(&num2);
		if (flag7)
		{
			goto IL_0340;
		}
		object obj12 = default(object);
		bool flag8 = obj12 == null;
		nint num3 = (nint)(&num2);
		if (!flag8)
		{
			nint num4 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag9 = ex2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
			num = 0;
			if (flag9)
			{
				goto IL_035c;
			}
		}
		bool flag10 = array.Length == 0;
		num = num3;
		if (!flag10)
		{
			object obj13 = array + 32;
			obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			TextMeshProExtensions.Localize(label, _key, array);
			return;
		}
		goto IL_034e;
	}

	public ClanTopXCountLabel()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		object obj = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3712;
		object obj2 = this + 48;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
