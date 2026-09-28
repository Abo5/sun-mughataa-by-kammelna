using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using Server.Models;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class CreateClanPopup : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<ClanRulesHelpPopup> <>9__24_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <OpenClanRulesHelp>b__24_0(ClanRulesHelpPopup popup)
		{
			popup.Show();
		}
	}

	private InputFieldTMProUGUI titleField;

	private InputFieldTMProUGUI descField;

	private InputFieldTMProUGUI rulesField;

	private TextMeshProUGUI priceTag;

	private TextMeshProUGUI validityDurationLabel;

	private ComponentReference<ClanLogoBuilder> logoEditorReference;

	private ClanLogoPreviewer logoPreviewer;

	private Button createClanButton;

	private Button clanRulesHelpButton;

	private ComponentReference<ClanRulesHelpPopup> clanRulesHelpPopupReference;

	private ClanLogoBuilder logoEditor;

	private ClanLogoModel savedLogo;

	private ClanModel initialModel;

	private int creationCost;

	private SlideAnimationHelper slideAnim;

	private ClanCreationModel model
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected O, but got Unknown
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if ((object)titleField != null)
			{
				string text = titleField.Text;
				if (obj2 != null)
				{
					object obj3 = obj2 + 16;
					obj3 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if ((object)descField != null)
					{
						string text2 = descField.Text;
						object obj4 = obj2 + 24;
						obj4 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						if ((object)rulesField != null)
						{
							string text3 = rulesField.Text;
							object obj5 = obj2 + 32;
							obj5 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							if ((object)logoEditor != null)
							{
								ClanLogoModel clanLogoModel = logoEditor.LayersToModel();
								object obj6 = obj2 + 40;
								obj6 = clanLogoModel;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								return (ClanCreationModel)obj2;
							}
						}
					}
				}
			}
			return (ClanCreationModel)(object)new NullReferenceException();
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)520;
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
		RemoteConfig.OnChanged += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_033b: Expected I, but got O
		//IL_0349: Expected I, but got O
		//IL_0373: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_00e3: Expected O, but got I4
		//IL_00f6: Expected O, but got I4
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_021e: Expected O, but got I
		//IL_022c: Expected I, but got O
		//IL_02ed: Expected O, but got I4
		//IL_02fe: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		//IL_0277: Expected O, but got I4
		//IL_0280: Expected O, but got I4
		//IL_0292: Expected O, but got I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_017e: Expected O, but got I
		//IL_018c: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)520;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)obj2;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+E4]");
		UnityAction unityAction;
		if ((nint)0 != 0)
		{
			bool flag2 = createClanButton;
			bool flag3 = !flag2;
			object obj8 = !flag3;
			unityAction = null;
			UnityAction unityAction2 = null;
			if (obj8 == null)
			{
				goto IL_00bb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = createClanButton;
			bool flag5 = !flag4;
			unityAction = null;
			UnityAction unityAction2 = null;
			if (flag5)
			{
				goto IL_00bb;
			}
		}
		Button button = createClanButton;
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)528;
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj10);
		button.m_OnClick.RemoveListener(unityAction3);
		UnityEngine.Object obj11 = clanRulesHelpButton;
		object obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		object obj14 = 0;
		num = 0;
		object obj15 = 0;
		unityAction = unityAction3;
		nint num2 = 0;
		UnityEngine.Object obj16 = clanRulesHelpButton;
		if (obj13 != null)
		{
			goto IL_0116;
		}
		goto IL_02bb;
		IL_00bb:
		obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		obj14 = 0;
		obj11 = clanRulesHelpButton;
		obj15 = 0;
		num2 = num;
		obj16 = clanRulesHelpButton;
		if (!flag7)
		{
			goto IL_0116;
		}
		goto IL_02bb;
		IL_02bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag8 = obj16;
		bool flag9 = !flag8;
		object obj17 = !flag9;
		obj14 = obj15;
		object obj18 = 0;
		num = num2;
		if (obj17 == null)
		{
			return;
		}
		goto IL_0145;
		IL_0145:
		Button button2 = clanRulesHelpButton;
		object obj19 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)544;
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj20);
		button2.m_OnClick.RemoveListener(unityAction4);
		return;
		IL_0116:
		bool flag10 = obj11;
		bool flag11 = !flag10;
		obj18 = 0;
		if (!flag11)
		{
			goto IL_0145;
		}
	}

	public void Initialize(ClanModel clan = null)
	{
		//IL_000c: Expected O, but got I
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0080: Expected O, but got I4
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_03db: Expected O, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02df: Expected O, but got I
		//IL_02ed: Expected I, but got O
		//IL_04c1: Expected O, but got I4
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_01ba: Expected O, but got I4
		//IL_0107: Expected O, but got I
		//IL_032b: Expected I, but got O
		//IL_042a: Expected O, but got I4
		//IL_0443: Expected O, but got I4
		//IL_017c: Expected I, but got O
		//IL_0181: Expected I, but got O
		//IL_0367: Expected O, but got I4
		//IL_0370: Expected O, but got I4
		//IL_0379: Expected O, but got I4
		//IL_037e: Expected I, but got O
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_0201: Expected O, but got I
		//IL_020f: Expected I, but got O
		//IL_024d: Expected I, but got O
		object obj = (nint)0 + (nint)56;
		ResetState();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 144;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		((SlideAnimationHelper)obj2).SlideIn();
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v10+E4]");
		UnityAction unityAction;
		if ((nint)0 != 0)
		{
			bool flag = clanRulesHelpButton;
			bool flag2 = !flag;
			object obj6 = !flag2;
			unityAction = null;
			UnityAction unityAction2 = null;
			if (obj6 == null)
			{
				goto IL_0098;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = clanRulesHelpButton;
			bool flag4 = !flag3;
			unityAction = null;
			UnityAction unityAction2 = null;
			if (flag4)
			{
				goto IL_0098;
			}
		}
		Button button = clanRulesHelpButton;
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)544;
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj8);
		button.m_OnClick.RemoveListener(unityAction3);
		Button button2 = clanRulesHelpButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj8);
		button2.m_OnClick.AddListener(unityAction4);
		ApplyConfigs();
		bool flag5 = clan == null;
		object obj9 = !flag5;
		object obj10 = 0;
		object obj11 = 0;
		nint num = unchecked((nint)null);
		unityAction = unityAction4;
		if (obj9 != null)
		{
			goto IL_00cb;
		}
		goto IL_0394;
		IL_03f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj12;
		bool flag6 = obj12;
		bool flag7 = !flag6;
		object obj13 = !flag7;
		obj11 = obj10;
		nint num2;
		num = num2;
		object obj14 = 0;
		if (obj13 == null)
		{
			return;
		}
		goto IL_01c8;
		IL_00cb:
		object obj15 = this + 128;
		obj15 = clan;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X21_v20-60]");
		((InputFieldTMProUGUI)0).Text = clan.Name;
		descField.Text = clan.Description;
		string rules = clan.Rules;
		rulesField.Text = clan.Rules;
		UnityEngine.Object obj16 = createClanButton;
		object obj17 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v6+E4]");
		bool flag8 = (nint)0 == 0;
		obj11 = obj10;
		num = unchecked((nint)null);
		num2 = unchecked((nint)null);
		obj12 = createClanButton;
		if (!flag8)
		{
			goto IL_0199;
		}
		goto IL_03f8;
		IL_0199:
		bool flag9 = obj16;
		bool flag10 = !flag9;
		obj14 = 0;
		if (!flag10)
		{
			goto IL_01c8;
		}
		return;
		IL_0098:
		ApplyConfigs();
		bool flag11 = clan == null;
		obj11 = obj10;
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		if (!flag11)
		{
			goto IL_00cb;
		}
		goto IL_0394;
		IL_0394:
		ITrackEvent trackEvent = TrackerLibrary.ClanCreateViewed();
		object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v10+E4]");
		bool flag12 = (nint)0 == 0;
		object obj20 = !flag12;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		obj16 = createClanButton;
		obj17 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v6+E4]");
		bool flag13 = (nint)0 == 0;
		object obj21 = !flag13;
		obj10 = obj11;
		num2 = num;
		rules = null;
		obj12 = createClanButton;
		if (obj21 != null)
		{
			goto IL_0199;
		}
		goto IL_03f8;
		IL_01c8:
		Button button3 = createClanButton;
		object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)528;
		UnityAction unityAction5 = default(UnityAction);
		unityAction5..ctor(this, (IntPtr)obj23);
		button3.m_OnClick.RemoveListener(unityAction5);
		Button button4 = createClanButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction6 = default(UnityAction);
		unityAction6..ctor(this, (IntPtr)obj23);
		button4.m_OnClick.AddListener(unityAction6);
	}

	private void ApplyConfigs()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01e3: Expected O, but got I4
		//IL_0223: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00fc: Expected O, but got I
		//IL_026d: Expected O, but got I4
		//IL_02c1: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88D2]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		bool flag2 = current == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_008b;
		IL_01a3:
		ClanConfigsResponse <Clans>k__BackingField;
		SetValidityDuration(<Clans>k__BackingField.CreationPeriodDays);
		return;
		IL_015a:
		UnityEngine.Object obj7;
		if ((bool)obj7)
		{
			goto IL_0180;
		}
		goto IL_01a3;
		IL_008b:
		<Clans>k__BackingField = current.<Clans>k__BackingField;
		if (current.<Clans>k__BackingField == null)
		{
			return;
		}
		creationCost = <Clans>k__BackingField.CreationCost;
		object obj8 = 152993792;
		object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88D3]");
		object obj10 = (nint)0 & (nint)1;
		UnityEngine.Object obj12;
		if (obj10 != null)
		{
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			obj7 = priceTag;
			obj12 = priceTag;
			if (!flag3)
			{
				goto IL_015a;
			}
		}
		else
		{
			_ = 1;
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			obj7 = priceTag;
			obj12 = priceTag;
			if (obj13 != null)
			{
				goto IL_015a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag5 = obj12;
		bool flag6 = !flag5;
		object obj14 = !flag6;
		if (obj14 != null)
		{
			goto IL_0180;
		}
		goto IL_01a3;
		IL_0180:
		TextMeshProExtensions.SetPriceText(priceTag, <Clans>k__BackingField.CreationCost);
		goto IL_01a3;
		IL_007d:
		current = RemoteConfig.Current;
		goto IL_008b;
	}

	private void ResetState()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected O, but got Unknown
		//IL_063a: Expected O, but got I4
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected O, but got Unknown
		//IL_0658: Expected O, but got I4
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected O, but got Unknown
		//IL_0676: Expected O, but got I4
		//IL_02a0: Expected O, but got I
		//IL_0057: Expected O, but got I
		//IL_0071: Expected O, but got I4
		//IL_02d6: Expected O, but got I4
		//IL_02e6: Expected O, but got I
		//IL_02f6: Expected O, but got I
		//IL_0341: Expected O, but got I4
		//IL_034a: Expected O, but got I4
		//IL_0353: Expected O, but got I4
		//IL_00f0: Expected O, but got I4
		//IL_03bc: Expected O, but got I4
		//IL_03cc: Expected O, but got I
		//IL_03dc: Expected O, but got I
		//IL_0427: Expected O, but got I4
		//IL_0430: Expected O, but got I4
		//IL_0439: Expected O, but got I4
		//IL_016f: Expected O, but got I4
		//IL_04a2: Expected O, but got I4
		//IL_04b2: Expected O, but got I
		//IL_04c2: Expected O, but got I
		//IL_050d: Expected O, but got I4
		//IL_0516: Expected O, but got I4
		//IL_051f: Expected O, but got I4
		//IL_01ee: Expected O, but got I4
		//IL_01f7: Expected O, but got I4
		//IL_05bc: Expected O, but got I4
		//IL_05cd: Expected O, but got I4
		//IL_056f: Expected O, but got I4
		//IL_0617: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 128;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 120;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 112;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v10+E4]");
		string text;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v3-50]");
			bool flag = (UnityEngine.Object)0;
			bool flag2 = !flag;
			object obj6 = !flag2;
			text = null;
			if (obj6 == null)
			{
				goto IL_0084;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v3-50]");
			bool flag3 = (UnityEngine.Object)0;
			bool flag4 = !flag3;
			text = null;
			if (flag4)
			{
				goto IL_0084;
			}
		}
		object obj7 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v25+90]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v26+B8]");
		object obj9 = 0;
		text = (string)obj9;
		titleField.Text = (string)obj9;
		UnityEngine.Object obj10 = descField;
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v37+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		object obj13 = 0;
		object obj14 = 0;
		UnityEngine.Object obj15 = descField;
		if (obj12 != null)
		{
			goto IL_00cd;
		}
		goto IL_036b;
		IL_0274:
		createClanButton.interactable = true;
		return;
		IL_024e:
		UnityEngine.Object obj16;
		if ((bool)obj16)
		{
			goto IL_0274;
		}
		return;
		IL_05e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj17;
		bool flag6 = obj17;
		bool flag7 = !flag6;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			return;
		}
		goto IL_0274;
		IL_0084:
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v37+E4]");
		bool flag8 = (nint)0 == 0;
		obj10 = descField;
		obj14 = obj13;
		obj15 = descField;
		if (!flag8)
		{
			goto IL_00cd;
		}
		goto IL_036b;
		IL_036b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag9 = obj15;
		bool flag10 = !flag9;
		obj13 = obj14;
		string text2 = null;
		if (flag10)
		{
			goto IL_0103;
		}
		goto IL_03ad;
		IL_00cd:
		bool flag11 = obj10;
		bool flag12 = !flag11;
		object obj19 = !flag12;
		text2 = null;
		if (obj19 == null)
		{
			goto IL_0103;
		}
		goto IL_03ad;
		IL_03ad:
		object obj20 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v19+90]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v20+B8]");
		object obj22 = 0;
		text2 = (string)obj22;
		descField.Text = (string)obj22;
		UnityEngine.Object obj23 = rulesField;
		object obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v30+E4]");
		bool flag13 = (nint)0 == 0;
		object obj25 = !flag13;
		obj13 = 0;
		object obj26 = 0;
		UnityEngine.Object obj27 = rulesField;
		if (obj25 != null)
		{
			goto IL_014c;
		}
		goto IL_0451;
		IL_0103:
		obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v30+E4]");
		bool flag14 = (nint)0 == 0;
		obj23 = rulesField;
		obj26 = obj13;
		obj27 = rulesField;
		if (!flag14)
		{
			goto IL_014c;
		}
		goto IL_0451;
		IL_0451:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = obj27;
		bool flag16 = !flag15;
		obj13 = obj26;
		string text3 = null;
		if (flag16)
		{
			goto IL_0182;
		}
		goto IL_0493;
		IL_014c:
		bool flag17 = obj23;
		bool flag18 = !flag17;
		object obj28 = !flag18;
		text3 = null;
		if (obj28 == null)
		{
			goto IL_0182;
		}
		goto IL_0493;
		IL_0493:
		object obj29 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v12+90]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v13+B8]");
		object obj31 = 0;
		text3 = (string)obj31;
		rulesField.Text = (string)obj31;
		UnityEngine.Object obj32 = logoPreviewer;
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v9+E4]");
		bool flag19 = (nint)0 == 0;
		object obj34 = !flag19;
		obj13 = 0;
		object obj35 = 0;
		UnityEngine.Object obj36 = logoPreviewer;
		if (obj34 != null)
		{
			goto IL_01cb;
		}
		goto IL_0537;
		IL_0182:
		obj32 = logoPreviewer;
		obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v9+E4]");
		bool flag20 = (nint)0 == 0;
		obj35 = obj13;
		obj36 = logoPreviewer;
		if (!flag20)
		{
			goto IL_01cb;
		}
		goto IL_0537;
		IL_0537:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag21 = obj36;
		bool flag22 = !flag21;
		obj13 = obj35;
		object obj37 = 0;
		if (flag22)
		{
			goto IL_020d;
		}
		goto IL_057d;
		IL_01cb:
		bool flag23 = obj32;
		bool flag24 = !flag23;
		object obj38 = !flag24;
		obj37 = 0;
		obj35 = obj13;
		if (obj38 == null)
		{
			goto IL_020d;
		}
		goto IL_057d;
		IL_057d:
		logoPreviewer.ResetToDefault();
		obj16 = createClanButton;
		object obj39 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v6+E4]");
		bool flag25 = (nint)0 == 0;
		object obj40 = !flag25;
		obj13 = obj35;
		obj37 = 0;
		obj17 = createClanButton;
		if (obj40 != null)
		{
			goto IL_024e;
		}
		goto IL_05e5;
		IL_020d:
		obj16 = createClanButton;
		obj39 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v6+E4]");
		bool flag26 = (nint)0 == 0;
		obj17 = createClanButton;
		if (!flag26)
		{
			goto IL_024e;
		}
		goto IL_05e5;
	}

	public void CreateClan()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_013c: Expected O, but got I4
		//IL_0145: Expected O, but got I4
		//IL_009e: Expected O, but got I4
		//IL_00d9: Expected O, but got I4
		if (!ValidateFields())
		{
			return;
		}
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		ITrackEvent trackEvent = TrackerLibrary.ClanCreateClicked();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v3+E4]");
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			obj5 = createClanButton;
			object obj6 = 0;
			obj7 = createClanButton;
			if (!flag)
			{
				goto IL_00b6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			obj5 = createClanButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = 0;
			obj7 = createClanButton;
			if (obj8 != null)
			{
				goto IL_00b6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!obj7)
		{
			goto IL_00e8;
		}
		goto IL_0193;
		IL_00b6:
		bool flag3 = obj5;
		bool flag4 = !flag3;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			goto IL_00e8;
		}
		goto IL_0193;
		IL_00e8:
		SubmitCreate();
		return;
		IL_0193:
		createClanButton.interactable = false;
		SubmitCreate();
	}

	public void EditClan()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_006f: Expected O, but got I4
		//IL_00bd: Expected I, but got O
		if (initialModel != null)
		{
			object obj = typeof(Queue<string>) + 728;
			object obj2 = (nint)0 + (nint)1976;
			object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj4 = (nint)0 + (nint)496;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			ClanCreationModel clanCreationModel = model;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<bool> action = default(Action<bool>);
			action..ctor((object)this, (IntPtr)obj4);
			ClanServerConnector clanServerConnector = default(ClanServerConnector);
			clanServerConnector.SendEditClan(clanCreationModel, action);
		}
	}

	public void OpenClanRulesHelp()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0260: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_034a: Expected O, but got I
		//IL_035b: Expected I, but got O
		//IL_0379: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_02cb: Expected O, but got I4
		//IL_0290: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(CardUtils.<>c) + 2816;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8819]");
		object obj3 = (nint)0 & (nint)1;
		ComponentReference<ClanRulesHelpPopup> componentReference2;
		object obj4;
		ComponentReference<ClanRulesHelpPopup> componentReference;
		if (obj3 != null)
		{
			componentReference = clanRulesHelpPopupReference;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			componentReference2 = clanRulesHelpPopupReference;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			componentReference = clanRulesHelpPopupReference;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			componentReference2 = clanRulesHelpPopupReference;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_0102:
		object obj11 = (nint)0 + (nint)1968;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = obj11;
		Action<object> action2 = action;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0153;
		}
		goto IL_02f9;
		IL_02f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj13;
		action = action2;
		componentReference = componentReference2;
		goto IL_0153;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0099:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_023e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)3920;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)1968;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action = action3;
		componentReference = componentReference2;
		obj13 = obj11;
		action2 = action3;
		if (obj20 != null)
		{
			goto IL_0153;
		}
		goto IL_02f9;
	}

	public void OpenLogoEditor()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_009a: Expected O, but got I
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00e1: Expected O, but got I4
		//IL_00fb: Expected O, but got I
		//IL_011c: Expected I, but got O
		//IL_0052: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1520;
		object obj3 = (nint)0 + (nint)504;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		ITrackEvent trackEvent = TrackerLibrary.ClanLogoEditorOpened();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = (nint)0 + (nint)1936;
		Tracker.DesignEvent(trackEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void SubmitCreate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007c: Expected O, but got I
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_009c: Expected O, but got I
		//IL_00c6: Expected O, but got I4
		//IL_0059: Expected I, but got O
		object obj = typeof(Queue<string>) + 728;
		object obj2 = (nint)0 + (nint)1976;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 552;
		object obj4 = (nint)0 + (nint)512;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		ClanCreationModel clanCreationModel = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.SendCreateClan(clanCreationModel, action);
	}

	private void SetPriceTag(int price)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_0155: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88D3]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = priceTag;
			obj6 = priceTag;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = priceTag;
			obj6 = priceTag;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		TextMeshProExtensions.SetPriceText(priceTag, price);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private unsafe void SetValidityDuration(int days)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0177: Expected O, but got I4
		//IL_028f: Expected O, but got Ref
		//IL_01ba: Expected O, but got Ref
		//IL_01d0: Expected I, but got O
		//IL_01e0: Expected O, but got I
		//IL_0209: Expected O, but got I
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E881C]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			obj5 = validityDurationLabel;
			obj6 = validityDurationLabel;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = validityDurationLabel;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = validityDurationLabel;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!obj6)
		{
			return;
		}
		goto IL_014a;
		IL_02aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_014a:
		object obj8 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj9 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		object obj11;
		int num = default(int);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj12;
		if (array != null)
		{
			object obj10 = default(object);
			bool flag3 = obj10 == null;
			obj11 = (object)(&num);
			if (!flag3)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
				obj12 = 0;
				if (flag4)
				{
					goto IL_02aa;
				}
			}
			if (array.Length != 0)
			{
				object obj13 = array + 32;
				obj13 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 4000;
				TextMeshProExtensions.Localize(validityDurationLabel, (string)text, array);
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj11 = (object)(&num);
		}
		ex = new IndexOutOfRangeException();
		obj12 = obj11;
		goto IL_02aa;
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			return;
		}
		goto IL_014a;
	}

	private bool ValidateFields()
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_012b: Expected O, but got I4
		//IL_013f: Expected I4, but got O
		if (savedLogo != null)
		{
			if ((object)titleField != null)
			{
				string text = titleField.Text;
				if ((object)descField != null)
				{
					string text2 = descField.Text;
					if ((object)rulesField != null)
					{
						string text3 = rulesField.Text;
						return ClanFieldValidator.Validate(text, text2, text3);
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3496;
		Toast.Show((string)message, (Vector2)0, 0f);
		return false;
	}

	private void OnLogoSaved(ClanLogoModel logo)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_016d: Expected O, but got I4
		//IL_0176: Expected O, but got I4
		//IL_0054: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		//IL_023a: Expected O, but got I4
		//IL_0285: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = this + 120;
		ClanLogoModel clanLogoModel = default(ClanLogoModel);
		obj3 = clanLogoModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ITrackEvent trackEvent = TrackerLibrary.ClanLogoSaved();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+E4]");
		UnityEngine.Object obj6;
		UnityEngine.Object obj8;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			obj6 = logoPreviewer;
			object obj7 = 0;
			obj8 = logoPreviewer;
			if (!flag)
			{
				goto IL_006c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			obj6 = logoPreviewer;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			object obj7 = 0;
			obj8 = logoPreviewer;
			if (obj9 != null)
			{
				goto IL_006c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj8 != null;
		bool flag4 = !flag3;
		int num = 0;
		UnityEngine.Object obj10 = null;
		if (flag4)
		{
			goto IL_00ac;
		}
		goto IL_01d2;
		IL_0115:
		logoEditor.Close();
		return;
		IL_00ed:
		UnityEngine.Object obj11;
		if (obj11 != null)
		{
			goto IL_0115;
		}
		return;
		IL_0252:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj12;
		bool flag5 = obj12 != null;
		bool flag6 = !flag5;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			return;
		}
		goto IL_0115;
		IL_006c:
		bool flag7 = obj6 != null;
		bool flag8 = !flag7;
		object obj14 = !flag8;
		num = 0;
		obj10 = null;
		if (obj14 == null)
		{
			goto IL_00ac;
		}
		goto IL_01d2;
		IL_01d2:
		ClanLogoBuilder clanLogoBuilder = logoEditor;
		num = clanLogoBuilder.Tier;
		logoPreviewer.Initialize(clanLogoModel, clanLogoBuilder.Tier);
		obj11 = logoEditor;
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
		bool flag9 = (nint)0 == 0;
		object obj16 = !flag9;
		obj12 = logoEditor;
		if (obj16 != null)
		{
			goto IL_00ed;
		}
		goto IL_0252;
		IL_00ac:
		obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
		bool flag10 = (nint)0 == 0;
		obj11 = logoEditor;
		obj12 = logoEditor;
		if (!flag10)
		{
			goto IL_00ed;
		}
		goto IL_0252;
	}

	private void <EditClan>b__23_0(bool b)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected I, but got Unknown
		//IL_0075: Expected O, but got I
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_0336: Expected O, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I
		//IL_00f1: Expected I, but got O
		//IL_0101: Expected O, but got I
		//IL_013c: Expected O, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01da: Expected I, but got O
		//IL_01ea: Expected O, but got I
		//IL_0288: Expected O, but got I
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected I, but got Unknown
		//IL_02d1: Expected O, but got I4
		//IL_0225: Expected O, but got I
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E881F]");
		nint num = 0;
		object obj4 = default(object);
		object obj5 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		IntPtr intPtr = default(IntPtr);
		object obj14 = default(object);
		while (true)
		{
			nint num2;
			if (b)
			{
				if ((object)slideAnim != null)
				{
					break;
				}
			}
			else
			{
				object buttonText = "Network Authentication Required" + 3128;
				PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(null, (string)buttonText);
				num = (nint)("Error reading data from socket: " + 2976);
				LocalizableText title = TextMeshProExtensions.Localize((string)num);
				if (popupWindowBuilder != null)
				{
					IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled(title);
					if (popupWindowBuilderNeedsBody != null)
					{
						object obj = typeof(System.IOAsyncCallback) + 384;
						object obj2 = (nint)0 + (nint)2000;
						num2 = (nint)popupWindowBuilderNeedsBody;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v15 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v15 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0185;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v15 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
						obj4 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X10_v12-8]");
							if (0 == (nint)obj)
							{
								break;
							}
							obj5 = obj4 + 16;
							obj3--;
							bool flag = (nint)obj3 != 1;
							obj4 = obj5;
							if (flag)
							{
								continue;
							}
							goto IL_0185;
						}
						goto IL_0292;
					}
				}
			}
			goto IL_02e7;
			IL_0185:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v268 @ X0_v14 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag2 = ex == null;
			num = intPtr;
			if (!flag2)
			{
				goto IL_01be;
			}
			goto IL_02e7;
			IL_01be:
			object obj6 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X10_v9-8]");
					if (0 == (nint)obj6)
					{
						break;
					}
					obj5 += 16;
					obj7--;
					if ((nint)obj7 != 1)
					{
						continue;
					}
					goto IL_0266;
				}
				goto IL_02f5;
			}
			goto IL_0266;
			IL_02e7:
			ex = new NullReferenceException();
			goto IL_02f5;
			IL_02f5:
			object obj8 = obj5 + 9;
			object obj9 = num + obj8;
			object obj10 = obj9 + 312;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v5+8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v189 @ X2_v2 (should have been resolved before IL gen)");
			continue;
			IL_0266:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v12+8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v224 @ X2_v8 (should have been resolved before IL gen)");
			goto IL_0292;
			IL_0292:
			object obj16 = num2 + obj4;
			num = (nint)(obj16 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v180 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag3 = ex == null;
			object obj17 = !flag3;
			obj5 = obj4;
			if (obj17 != null)
			{
				goto IL_01be;
			}
			goto IL_02e7;
		}
		slideAnim.SlideOut();
	}

	private void <OpenLogoEditor>b__25_0(ClanLogoBuilder builder)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_02bb: Expected I, but got O
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_008b: Expected O, but got I4
		//IL_00cc: Expected I, but got O
		//IL_00aa: Expected O, but got I4
		//IL_00df: Expected O, but got I4
		//IL_033f: Expected O, but got I4
		//IL_0136: Expected O, but got I4
		//IL_013f: Expected O, but got I4
		//IL_024b: Expected O, but got I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1528;
		object obj2 = (nint)0 + (nint)536;
		object obj3 = this + 112;
		obj3 = builder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = builder + 32;
		Delegate obj5 = (Delegate)obj4;
		object obj8 = default(object);
		Delegate obj12 = default(Delegate);
		Action<object> action2 = default(Action<object>);
		object obj16 = default(object);
		Delegate obj18 = default(Delegate);
		while (true)
		{
			Delegate obj6 = Delegate.Remove(obj5, action);
			if ((object)obj6 == null)
			{
				object obj7 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag = obj8 == null;
				object obj9 = !flag;
				object obj7 = obj8;
				if (obj9 == null)
				{
					object obj10 = 0;
					Delegate obj11 = null;
					break;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			bool flag2 = (object)obj12 == obj5;
			obj5 = obj12;
			if (!flag2)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action2..ctor((object)this, (IntPtr)obj2);
			Delegate obj13 = (Delegate)obj4;
			while (true)
			{
				Delegate obj14 = Delegate.Combine(obj13, action2);
				object obj10;
				Delegate obj11;
				if ((object)obj14 == null)
				{
					object obj15 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag3 = obj16 == null;
					object obj17 = !flag3;
					obj10 = 0;
					obj11 = null;
					object obj15 = obj16;
					if (obj17 == null)
					{
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj18 == obj13;
				obj13 = obj18;
				obj10 = 0;
				obj11 = obj18;
				if (!flag4)
				{
					continue;
				}
				ClanLogoModel logo = savedLogo;
				if (savedLogo != null)
				{
					goto IL_018e;
				}
				ClanModel clanModel = initialModel;
				bool flag5 = initialModel == null;
				ClanLogoModel logo2 = savedLogo;
				if (!flag5)
				{
					logo = clanModel.Logo;
					bool flag6 = clanModel.Logo == null;
					object obj19 = !flag6;
					logo2 = clanModel.Logo;
					if (obj19 != null)
					{
						goto IL_018e;
					}
				}
				builder.ResetToDefault();
				logo = logo2;
				goto IL_027c;
				IL_027c:
				builder.Open();
				return;
				IL_018e:
				if (builder._selectorsReady)
				{
					builder.ApplyModel(logo);
				}
				else
				{
					builder._pendingModel = logo;
					object obj20 = builder + 264;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				goto IL_027c;
			}
			break;
		}
		throw new InvalidCastException();
	}

	private void <SubmitCreate>b__26_0(KammelnaResponseModel<int> response)
	{
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected O, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_0021: Expected O, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0095: Expected O, but got I4
		//IL_020b: Expected O, but got I4
		//IL_00e8: Expected F8, but got I4
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected I, but got Unknown
		//IL_02be: Expected O, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0155: Expected O, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0194: Expected O, but got I4
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_034c: Expected I, but got O
		//IL_035c: Expected O, but got I
		//IL_03f2: Expected I, but got O
		//IL_0397: Expected O, but got I
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_0435: Expected I, but got O
		//IL_0445: Expected O, but got I
		//IL_04e3: Expected O, but got I
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected O, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected O, but got Unknown
		//IL_0510: Expected I, but got O
		//IL_0534: Expected O, but got I4
		//IL_0480: Expected O, but got I
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8820]");
		nint num = 0;
		NullReferenceException ex = default(NullReferenceException);
		object obj10 = default(object);
		object obj13 = default(object);
		object obj15 = default(object);
		object obj23 = default(object);
		while (true)
		{
			if (response != null)
			{
				object obj = (nint)0 + (nint)1240;
				if (!response.Succeeded)
				{
					object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v7+E4]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v7+E4]");
					if ((nint)0 != 0)
					{
						bool flag = createClanButton;
						bool flag2 = !flag;
						object obj4 = !flag2;
						if (obj4 != null)
						{
							goto IL_0255;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						if ((bool)createClanButton)
						{
							goto IL_0255;
						}
					}
					goto IL_0289;
				}
				object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v34+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v34+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string itemId = Tracker.ItemId(ResourceItemId.ClanCreate);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Access, itemId, creationCost, ResourceCurrency.Aces);
				if ((object)slideAnim != null)
				{
					break;
				}
			}
			goto IL_054a;
			IL_0419:
			object obj8 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj10 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v9-8]");
					if (0 == (nint)obj8)
					{
						break;
					}
					obj10 += 16;
					obj9--;
					if ((nint)obj9 != 1)
					{
						continue;
					}
					goto IL_04c1;
				}
				goto IL_0558;
			}
			goto IL_04c1;
			IL_0289:
			object buttonText = "Network Authentication Required" + 3128;
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(null, (string)buttonText);
			num = (nint)("Error reading data from socket: " + 2976);
			LocalizableText title = TextMeshProExtensions.Localize((string)num);
			nint num2;
			if (popupWindowBuilder != null)
			{
				IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled(title);
				num = (nint)0 + (nint)1224;
				string errorMessage = response.ErrorMessage;
				if (popupWindowBuilderNeedsBody != null)
				{
					object obj11 = typeof(System.IOAsyncCallback) + 384;
					num2 = (nint)popupWindowBuilderNeedsBody;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v20 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v20 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_03e0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v20 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
					obj13 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v12-8]");
						if (0 == (nint)obj11)
						{
							break;
						}
						obj10 = obj13 + 16;
						obj12--;
						bool flag4 = (nint)obj12 != 1;
						obj13 = obj10;
						if (flag4)
						{
							continue;
						}
						goto IL_03e0;
					}
					goto IL_04ed;
				}
			}
			goto IL_054a;
			IL_04c1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj14 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X0_v18+8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v256 @ X2_v9 (should have been resolved before IL gen)");
			goto IL_04ed;
			IL_0558:
			object obj17 = obj10 + 9;
			object obj18 = num + obj17;
			object obj19 = obj18 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v196 @ X8_v5] (should have been resolved before IL gen)");
			continue;
			IL_054a:
			ex = new NullReferenceException();
			goto IL_0558;
			IL_04ed:
			object obj20 = num2 + obj13;
			object obj21 = obj20 + 312;
			num = (nint)obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v379 @ X0_v24] (should have been resolved before IL gen)");
			bool flag5 = ex == null;
			object obj22 = !flag5;
			obj10 = obj13;
			if (obj22 != null)
			{
				goto IL_0419;
			}
			goto IL_054a;
			IL_03e0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v364 @ X0_v21] (should have been resolved before IL gen)");
			if (ex != null)
			{
				goto IL_0419;
			}
			goto IL_054a;
			IL_0255:
			if ((object)createClanButton != null)
			{
				createClanButton.interactable = true;
				goto IL_0289;
			}
			goto IL_054a;
		}
		slideAnim.SlideOut();
		object obj24 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v40+E4]");
		bool flag6 = (nint)0 == 0;
		object obj26 = !flag6;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "WhiteSmoke" + 2176;
		Toast.Show((string)message, (Vector2)0, 0f);
	}
}
