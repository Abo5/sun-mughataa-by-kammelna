using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PredictAndWinGameControls : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static UnityAction<bool> <>9__1_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Start>b__1_0(bool isOn)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_018b: Expected O, but got I4
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_0099: Expected O, but got I
			//IL_00b3: Expected O, but got I4
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Expected O, but got Unknown
			//IL_01c8: Expected O, but got I
			//IL_0214: Expected O, but got I
			//IL_0224: Expected O, but got I
			//IL_0246: Expected O, but got I4
			//IL_0131: Expected O, but got I
			//IL_0141: Expected O, but got I
			//IL_0151: Expected O, but got I
			//IL_00ec: Expected O, but got I
			//IL_00fc: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E2]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 == null)
			{
				goto IL_015b;
			}
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
			goto IL_0199;
			IL_0199:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj4 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E9]");
			object obj5 = (nint)0 & (nint)1;
			if (obj5 == null)
			{
				goto IL_00c9;
			}
			object key = obj4;
			goto IL_0255;
			IL_0074:
			obj4 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E9]");
			object obj6 = (nint)0 & (nint)1;
			bool flag = obj6 == null;
			object obj7 = !flag;
			key = obj4;
			if (obj7 == null)
			{
				goto IL_00c9;
			}
			goto IL_0255;
			IL_00c9:
			_ = 1;
			key = obj4;
			goto IL_0255;
			IL_0255:
			Prefs.SetBool((string)key, isOn);
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v3+B8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v8+20]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v8+20]");
				if ((nint)0 == 0)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v6+B8]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v5+20]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v5+20]");
				bool flag2 = (nint)0 == 0;
				object obj13 = !flag2;
				if (obj13 == null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7+18]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7+40]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7+28]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v100 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_015b;
			IL_015b:
			_ = 1;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 != null)
			{
				goto IL_0074;
			}
			goto IL_0199;
		}
	}

	private Toggle showAvatarInTweet;

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01b2: Expected O, but got I
		//IL_01d4: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_021f: Expected O, but got I4
		//IL_0228: Expected O, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_026b: Expected O, but got I
		//IL_0285: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_012c: Expected O, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02f6: Expected O, but got I
		//IL_0304: Expected I, but got O
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_03dd: Expected O, but got I
		//IL_03ed: Expected O, but got I
		//IL_040f: Expected O, but got I4
		//IL_0372: Expected O, but got I
		//IL_0382: Expected O, but got I
		//IL_043f: Expected O, but got I4
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_04da: Expected O, but got I
		//IL_04eb: Expected I, but got O
		//IL_0509: Expected O, but got I
		//IL_0493: Expected O, but got I4
		//IL_046f: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E0]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = showAvatarInTweet;
			obj6 = showAvatarInTweet;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = showAvatarInTweet;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6000]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = showAvatarInTweet;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c6;
		IL_0151:
		object obj11;
		bool isOn = Prefs.GetBool((string)obj11, defaultValue: true);
		bool flag5 = (object)showAvatarInTweet == null;
		object obj12 = !flag5;
		if (obj12 != null)
		{
			goto IL_02b8;
		}
		goto IL_04a9;
		IL_02b8:
		showAvatarInTweet.isOn = isOn;
		object obj13 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1616;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj14);
		PredictAndWinManager.OnSendAvatarWithScreenshotChanged += action;
		Toggle toggle = showAvatarInTweet;
		object obj15 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3032;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v41+E4]");
		object obj17;
		UnityAction<bool> call;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v41+B8]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v19+8]");
			call = (UnityAction<bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v19+8]");
			if ((nint)0 != 0)
			{
				goto IL_03a7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v41+B8]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v19+8]");
			call = (UnityAction<bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v19+8]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 != null)
			{
				goto IL_03a7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v41+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj20 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v25+B8]");
			obj17 = 0;
		}
		object obj21 = typeof(TypeConverter<ushort, char>) + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)1600;
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor(obj17, (IntPtr)obj22);
		object obj23 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v24+B8]");
		object obj24 = (nint)0 + (nint)8;
		obj24 = unityAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag8 = toggle.onValueChanged == null;
		object obj25 = !flag8;
		call = unityAction;
		if (obj25 != null)
		{
			goto IL_03a7;
		}
		goto IL_04a9;
		IL_03a7:
		toggle.onValueChanged.AddListener(call);
		return;
		IL_0091:
		bool flag9 = obj5 != null;
		bool flag10 = !flag9;
		obj9 = 0;
		obj10 = null;
		if (!flag10)
		{
			goto IL_00c6;
		}
		return;
		IL_00c6:
		object obj26 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v32+E4]");
		object key;
		if ((nint)0 != 0)
		{
			obj11 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E8]");
			object obj28 = (nint)0 & (nint)1;
			bool flag11 = obj28 == null;
			key = obj11;
			if (!flag11)
			{
				goto IL_0151;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E8]");
			object obj29 = (nint)0 & (nint)1;
			bool flag12 = obj29 == null;
			object obj30 = !flag12;
			key = obj11;
			if (obj30 != null)
			{
				goto IL_0151;
			}
		}
		_ = 1;
		isOn = Prefs.GetBool((string)key, defaultValue: true);
		goto IL_02b8;
		IL_04a9:
		throw new NullReferenceException();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1616;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			PredictAndWinManager.OnSendAvatarWithScreenshotChanged -= action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PredictAndWinManager.OnSendAvatarWithScreenshotChanged -= action;
	}

	private void OnShowAvatar()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0142: Expected O, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0189: Expected O, but got I
		//IL_01a3: Expected O, but got I4
		//IL_01f8: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E1]");
		object obj3 = (nint)0 & (nint)1;
		Toggle toggle;
		Toggle toggle2;
		if (obj3 != null)
		{
			toggle = showAvatarInTweet;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			toggle2 = showAvatarInTweet;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			toggle = showAvatarInTweet;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			toggle2 = showAvatarInTweet;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E8]");
		object obj7 = (nint)0 & (nint)1;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		toggle = toggle2;
		object key = obj6;
		if (obj8 != null)
		{
			goto IL_00e3;
		}
		goto IL_01c1;
		IL_00e3:
		bool isOn = Prefs.GetBool((string)obj6, defaultValue: true);
		goto IL_00fa;
		IL_00fa:
		toggle.isOn = isOn;
		return;
		IL_01c1:
		_ = 1;
		isOn = Prefs.GetBool((string)key, defaultValue: true);
		bool flag4 = (object)toggle2 == null;
		object obj9 = !flag4;
		toggle = toggle2;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00fa;
		IL_0091:
		obj6 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E8]");
		object obj10 = (nint)0 & (nint)1;
		bool flag5 = obj10 == null;
		key = obj6;
		toggle2 = toggle;
		if (!flag5)
		{
			goto IL_00e3;
		}
		goto IL_01c1;
	}
}
