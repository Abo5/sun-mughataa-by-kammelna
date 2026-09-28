using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class MaintenanceNoticeUi : MonoBehaviour, IInitializable
{
	private const string NoticeTextArabic = "Maintenance scheduled for {0} after {1}";

	private TextMeshProUGUI noticeTextMeshPro;

	private DateTime dateTimeNow;

	private TimeSpan timeSpan;

	public void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_015e: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01e4: Expected O, but got I4
		//IL_018c: Expected O, but got I
		//IL_01a6: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_021c: Expected O, but got I
		//IL_022c: Expected O, but got I
		//IL_024e: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7093]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C4]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b4;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v22+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v15+10]");
		MaintenanceInfo maintenanceInfo = (MaintenanceInfo)0;
		goto IL_0101;
		IL_0101:
		if (maintenanceInfo.IsUnderMaintenance())
		{
			ShowNotice();
		}
		return;
		IL_01fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v6+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v5+10]");
		maintenanceInfo = (MaintenanceInfo)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v5+10]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0101;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C4]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b4;
		IL_01b4:
		_ = 1;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v22+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		object obj14 = obj12;
		if (obj13 != null)
		{
			goto IL_00dc;
		}
		goto IL_01fa;
		IL_00a7:
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v22+E4]");
		bool flag5 = (nint)0 == 0;
		obj14 = obj12;
		if (!flag5)
		{
			goto IL_00dc;
		}
		goto IL_01fa;
	}

	private void ShowNotice()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_0084: Expected O, but got I
		//IL_005c: Expected F4, but got I8
		object methodName = "SetRoomVariables request error" + 48;
		object obj = (nint)0 + (nint)2872;
		object obj2 = (nint)0 + (nint)2760;
		CancelInvoke((string)methodName);
		InvokeRepeating((string)methodName, 0f, 1f);
		float endValue;
		if (ScreenUtility.HasScreenCutout)
		{
			float topCutoutSize = ScreenUtility.TopCutoutSize;
			endValue = 3.2782418E+09f - topCutoutSize;
		}
		else
		{
			endValue = 3.2782418E+09f;
		}
		RectTransform target = UIExtensions.rectTransform(this);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target, endValue, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
	}

	private void HideNotice()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object methodName = "SetRoomVariables request error" + 48;
		object obj = (nint)0 + (nint)2872;
		CancelInvoke((string)methodName);
		RectTransform target = UIExtensions.rectTransform(this);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target, 45f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	private unsafe void SetText()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_01cd: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0267: Expected O, but got I4
		//IL_01fb: Expected O, but got I
		//IL_0215: Expected O, but got I4
		//IL_0108: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_0147: Expected O, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_02a7: Expected O, but got I
		//IL_02b7: Expected O, but got I
		//IL_02e1: Expected O, but got I4
		//IL_02f9: Expected O, but got I
		//IL_018a: Expected O, but got I4
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_038e: Expected O, but got I
		//IL_03a3: Expected O, but got I
		//IL_03b9: Expected I4, but got I8
		//IL_03d3: Expected O, but got I4
		//IL_045a: Expected O, but got I4
		//IL_048e: Expected O, but got I
		//IL_049b: Expected O, but got I4
		//IL_040b: Expected O, but got I4
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_04d1: Expected I8, but got O
		//IL_04cc: Expected native int or pointer, but got O
		//IL_04fb: Expected O, but got I4
		//IL_0d53: Expected O, but got I
		//IL_0d64: Expected O, but got I4
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected O, but got Unknown
		//IL_0533: Expected O, but got I
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected O, but got Unknown
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected O, but got Unknown
		//IL_055d: Expected O, but got I
		//IL_0594: Expected O, but got I4
		//IL_05cb: Expected I8, but got I4
		//IL_0608: Expected I8, but got I4
		//IL_0640: Expected I8, but got I4
		//IL_078a: Expected O, but got I4
		//IL_0793: Expected O, but got I4
		//IL_079c: Expected O, but got I4
		//IL_06b5: Expected O, but got I4
		//IL_06be: Expected O, but got I4
		//IL_07d4: Expected O, but got I4
		//IL_086e: Expected O, but got I4
		//IL_0877: Expected O, but got I4
		//IL_0730: Expected O, but got I4
		//IL_09c5: Expected O, but got I
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Expected O, but got Unknown
		//IL_0dc0: Expected O, but got I4
		//IL_0dc9: Expected O, but got I4
		//IL_0a19: Expected O, but got I4
		//IL_0747: Expected O, but got I4
		//IL_093b: Expected O, but got I4
		//IL_0944: Expected O, but got I4
		//IL_08e1: Expected O, but got I4
		//IL_0af0: Expected O, but got I4
		//IL_0a76: Expected I, but got O
		//IL_0aa8: Expected O, but got I4
		//IL_0900: Expected O, but got I4
		//IL_0b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b24: Expected O, but got Unknown
		//IL_0b34: Expected O, but got I
		//IL_0be7: Expected O, but got I8
		//IL_0bff: Expected O, but got I4
		//IL_0ca3: Expected O, but got I4
		//IL_0b73: Expected I, but got O
		//IL_0ba5: Expected O, but got I4
		//IL_0cd0: Expected O, but got I
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Expected O, but got Unknown
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Expected O, but got Unknown
		//IL_0c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c42: Expected O, but got Unknown
		//IL_0cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfd: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7096]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v116+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v116+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C4]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_0223;
		IL_0838:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		TimeSpan timeSpan;
		int hours = ((TimeSpan*)timeSpan)->Hours;
		bool flag3 = hours == 0;
		object obj7 = !flag3;
		object obj8 = 0;
		string text2;
		string text = text2;
		if (obj7 == null)
		{
			goto IL_088d;
		}
		goto IL_09b9;
		IL_0d2d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_095a:
		object obj10;
		object obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X0_v55+E4]");
		if ((nint)0 != 0)
		{
			int seconds = ((TimeSpan*)timeSpan)->Seconds;
			bool flag4 = seconds == 0;
			text = text2;
			if (!flag4)
			{
				goto IL_09b9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int seconds2 = ((TimeSpan*)timeSpan)->Seconds;
			bool flag5 = seconds2 == 0;
			object obj11 = !flag5;
			text = text2;
			if (obj11 != null)
			{
				goto IL_09b9;
			}
		}
		TextMeshProUGUI textMesh = noticeTextMeshPro;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X24_v4+20]");
		TextMeshProExtensions.FixArabic(textMesh, (string)0);
		object methodName = "SetRoomVariables request error" + 48;
		CancelInvoke((string)methodName);
		object methodName2 = "HH:mm:ss.ffZ" + 1360;
		Invoke((string)methodName2, 3f);
		return;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C4]");
		object obj12 = (nint)0 & (nint)1;
		if (obj12 != null)
		{
			goto IL_00a7;
		}
		goto IL_0223;
		IL_0223:
		_ = 1;
		object obj13 = typeof(DataRelation) + 712;
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v167+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		object obj16 = obj13;
		object obj17 = obj14;
		if (obj15 != null)
		{
			goto IL_00f8;
		}
		goto IL_0285;
		IL_00a7:
		obj13 = typeof(DataRelation) + 712;
		obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v167+E4]");
		bool flag7 = (nint)0 == 0;
		obj16 = obj13;
		obj17 = obj14;
		if (!flag7)
		{
			goto IL_00f8;
		}
		goto IL_0285;
		IL_0285:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v109+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v41+10]");
		object obj20 = 0;
		object obj21 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v103+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		obj13 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v41+10]");
		object obj23 = 0;
		if (obj22 != null)
		{
			goto IL_015d;
		}
		goto IL_0307;
		IL_00f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v167+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v52+10]");
		obj20 = 0;
		obj21 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v103+E4]");
		bool flag9 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v52+10]");
		obj23 = 0;
		obj16 = obj13;
		if (!flag9)
		{
			goto IL_015d;
		}
		goto IL_0307;
		IL_0307:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime dateTime = (dateTimeNow = DateTime.Now);
		bool flag10 = obj23 == null;
		obj20 = obj23;
		obj13 = obj16;
		if (!flag10)
		{
			goto IL_0356;
		}
		goto IL_0d11;
		IL_015d:
		dateTime = (dateTimeNow = DateTime.Now);
		bool flag11 = obj20 == null;
		object obj25 = !flag11;
		if (obj25 != null)
		{
			goto IL_0356;
		}
		goto IL_0d11;
		IL_0356:
		object obj26 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X24_v4+10]");
		DateTime dateTime2 = (DateTime)0;
		DateTime t = dateTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X24_v4+10]");
		int num = DateTime.Compare(t, (DateTime)0);
		int num2 = (int)(num & 0x80000000L);
		bool flag12 = num2 == 0;
		object obj27 = !flag12;
		TimeSpan timeSpan2;
		if (obj27 == null)
		{
			object obj28 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v99+E4]");
			bool flag13 = (nint)0 == 0;
			object obj29 = !flag13;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj28 = obj10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v99+B8]");
			object obj30 = 0;
			timeSpan2 = (TimeSpan)obj30;
			object obj31 = 0;
		}
		else
		{
			object obj32 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v93+E4]");
			bool flag14 = (nint)0 == 0;
			object obj33 = !flag14;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X24_v4+10]");
			timeSpan2 = (DateTime)0 - dateTimeNow;
			object obj31 = 0;
			dateTime2 = dateTimeNow;
		}
		object input = "alignContent" + 264;
		timeSpan = (TimeSpan)(this + 48);
		((TimeSpan*)(nint)timeSpan)->_ticks = (long)timeSpan2;
		object obj34 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v11+E4]");
		bool flag15 = (nint)0 == 0;
		object obj35 = !flag15;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object input2 = "getSecondRescanTask" + 3264;
		object obj36 = (nint)0 + (nint)3072;
		object input3 = "m_StencilDeferredPS" + 1888;
		object input4 = "rightCtrl" + 1672;
		object obj37 = (nint)0 + (nint)2000;
		string text3 = LocalizationUtil.Localize((string)input);
		object obj38 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X0_v15+E4]");
		bool flag16 = (nint)0 == 0;
		object obj39 = !flag16;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int hours2 = ((TimeSpan*)timeSpan)->Hours;
		string text4 = LocalizationUtil.Localize((string)input2, hours2);
		string text5 = text4 + (string)obj36 + text3;
		int minutes = ((TimeSpan*)timeSpan)->Minutes;
		string text6 = LocalizationUtil.Localize((string)input3, minutes);
		string text7 = text6 + (string)obj36 + text3;
		int seconds3 = ((TimeSpan*)timeSpan)->Seconds;
		string text8 = LocalizationUtil.Localize((string)input4, seconds3);
		string text9 = (string)((((TimeSpan*)timeSpan)->Hours != 0) ? text5 : obj37);
		object obj40 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v33+E4]");
		object obj41;
		if ((nint)0 != 0)
		{
			int hours3 = ((TimeSpan*)timeSpan)->Hours;
			bool flag17 = hours3 == 0;
			obj41 = 0;
			object obj42 = 0;
			if (!flag17)
			{
				goto IL_06cc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int hours4 = ((TimeSpan*)timeSpan)->Hours;
			bool flag18 = hours4 == 0;
			object obj43 = !flag18;
			obj41 = 0;
			object obj42 = 0;
			if (obj43 != null)
			{
				goto IL_06cc;
			}
		}
		object obj44 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v75+E4]");
		bool flag19 = (nint)0 == 0;
		object obj45 = !flag19;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		text = (string)((((TimeSpan*)timeSpan)->Minutes != 0) ? text7 : obj37);
		object obj46 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v70+E4]");
		bool flag20 = (nint)0 == 0;
		object obj47 = !flag20;
		obj41 = 0;
		text2 = text;
		if (obj47 != null)
		{
			goto IL_0709;
		}
		goto IL_0838;
		IL_06cc:
		obj46 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v70+E4]");
		bool flag21 = (nint)0 == 0;
		text = text7;
		text2 = text7;
		if (!flag21)
		{
			goto IL_0709;
		}
		goto IL_0838;
		IL_0709:
		int hours5 = ((TimeSpan*)timeSpan)->Hours;
		bool flag22 = hours5 == 0;
		object obj48 = !flag22;
		if (obj48 == null)
		{
			obj8 = 0;
			text2 = text;
			goto IL_088d;
		}
		goto IL_09b9;
		IL_0d1f:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0d2d;
		IL_088d:
		object obj49 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X0_v53+E4]");
		if ((nint)0 != 0)
		{
			int minutes2 = ((TimeSpan*)timeSpan)->Minutes;
			bool flag23 = minutes2 == 0;
			object obj50 = !flag23;
			text = text2;
			if (obj50 == null)
			{
				object obj51 = 0;
				goto IL_095a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int minutes3 = ((TimeSpan*)timeSpan)->Minutes;
			bool flag24 = minutes3 == 0;
			object obj52 = !flag24;
			object obj51 = 0;
			text = text2;
			if (obj52 == null)
			{
				goto IL_095a;
			}
		}
		goto IL_09b9;
		IL_09b9:
		object obj53 = (nint)0 + (nint)2336;
		object obj54 = typeof(TypeConverter<ushort, char>) + 3400;
		string text10 = (string)obj53 + text9 + text + text8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag25 = array == null;
		object obj55 = 0;
		string text11 = text8;
		string text12 = text;
		nint num3 = 2;
		if (flag25)
		{
			goto IL_0d11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X24_v4+18]");
		bool flag26 = (nint)0 == 0;
		nint num4 = 2;
		if (!flag26)
		{
			nint num5 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag27 = ex == null;
			obj55 = 0;
			text11 = text8;
			text12 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
			num3 = 0;
			if (flag27)
			{
				goto IL_0d2d;
			}
		}
		bool flag28 = array.Length == 0;
		obj55 = 0;
		text11 = text8;
		text12 = text;
		num3 = num4;
		if (!flag28)
		{
			object obj56 = array + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X24_v4+18]");
			obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag29 = text10 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X24_v4+18]");
			nint num6 = 0;
			if (!flag29)
			{
				nint num7 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
				num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag30 = ex == null;
				obj55 = 0;
				text11 = text8;
				text12 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
				num3 = 0;
				if (flag30)
				{
					goto IL_0d2d;
				}
			}
			object obj57 = array.Length & 0xFFFFFFFEL;
			bool flag31 = obj57 == null;
			obj55 = 0;
			text11 = text8;
			text12 = text;
			num3 = num6;
			if (!flag31)
			{
				object text13 = "LAK" + 3496;
				object obj58 = array + 40;
				obj58 = text10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				TextMeshProExtensions.Localize(noticeTextMeshPro, (string)text13, array);
				return;
			}
		}
		goto IL_0d1f;
		IL_0d11:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0d1f;
	}

	public void CloseButton()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object methodName = "SetRoomVariables request error" + 48;
		object obj = (nint)0 + (nint)2872;
		CancelInvoke((string)methodName);
		RectTransform target = UIExtensions.rectTransform(this);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target, 45f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	public void TestShowNotice(string message, string downTimeText, int timeInMinutes)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I4
		//IL_00e3: Expected F8, but got I4
		//IL_023d: Expected O, but got I
		//IL_0257: Expected O, but got I4
		//IL_0134: Expected O, but got I
		//IL_0295: Expected O, but got I4
		//IL_019c: Expected O, but got I
		//IL_01e4: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(DataRelation) + 712;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj5 = obj2 + 32;
		obj5 = message;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = downTimeText;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		DateTime dateTime2 = default(DateTime);
		DateTime dateTime = dateTime2.AddMinutes(timeInMinutes);
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v18+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C5]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 != null)
			{
				goto IL_0151;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C5]");
			object obj11 = (nint)0 & (nint)1;
			bool flag2 = obj11 == null;
			object obj12 = !flag2;
			if (obj12 != null)
			{
				goto IL_0151;
			}
		}
		_ = 1;
		object obj13 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v28+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		object obj15 = obj13;
		if (obj14 != null)
		{
			goto IL_0186;
		}
		goto IL_02ab;
		IL_0151:
		obj13 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v28+E4]");
		bool flag4 = (nint)0 == 0;
		obj15 = obj13;
		if (!flag4)
		{
			goto IL_0186;
		}
		goto IL_02ab;
		IL_02ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj13 = obj4;
		goto IL_0186;
		IL_0186:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v28+B8]");
		object obj16 = (nint)0 + (nint)16;
		obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = base.gameObject;
		bool activeSelf = gameObject.activeSelf;
		bool flag5 = !activeSelf;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			GameObject gameObject2 = base.gameObject;
			gameObject2.SetActive(value: true);
		}
		ShowNotice();
	}
}
