using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ClanLogoSetter : AvatarComponent
{
	private sealed class <>c__DisplayClass13_0
	{
		public ClanLogoSetter <>4__this;

		public int clanId;

		internal void <SetClan>b__0(ClanModel clan)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ff: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_0158: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_01cf: Expected O, but got I4
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Expected O, but got Unknown
			//IL_01f9: Expected O, but got I
			//IL_0304: Expected O, but got I4
			//IL_0297: Expected O, but got I4
			//IL_02a7: Expected O, but got I
			//IL_02b7: Expected O, but got I
			//IL_0356: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73A1]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v25+E4]");
				bool flag = (nint)0 == 0;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v25+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj9 = 0;
			UnityEngine.Object obj10 = null;
			if (obj8 == null)
			{
				goto IL_0174;
			}
			return;
			IL_0388:
			ClanLogoSetter clanLogoSetter = <>4__this;
			clanLogoSetter.clanLogo.Load(clan);
			return;
			IL_0371:
			TextMeshProUGUI clanNameLabel;
			TextMeshProExtensions.FixArabic(clanNameLabel, clan.Name);
			goto IL_0388;
			IL_0243:
			bool flag5 = StringsExtensions.IsNullOrEmpty(clan.Name);
			ClanLogoSetter clanLogoSetter2;
			TextMeshProUGUI clanNameLabel2 = clanLogoSetter2.clanNameLabel;
			bool flag6 = !flag5;
			clanNameLabel = clanLogoSetter2.clanNameLabel;
			if (!flag6)
			{
				goto IL_0288;
			}
			goto IL_0371;
			IL_0091:
			bool flag7 = obj5 == null;
			bool flag8 = !flag7;
			obj9 = 0;
			obj10 = null;
			if (!flag8)
			{
				return;
			}
			goto IL_0174;
			IL_0174:
			clanLogoSetter2 = <>4__this;
			if (clanLogoSetter2._clanId != clanId)
			{
				return;
			}
			if (clan != null)
			{
				object obj11 = 152989696;
				object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E739F]");
				object obj13 = (nint)0 & (nint)1;
				if (obj13 != null)
				{
					object obj14 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v9+E4]");
					if ((nint)0 != 0)
					{
						goto IL_0243;
					}
				}
				else
				{
					_ = 1;
					object obj14 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v9+E4]");
					bool flag9 = (nint)0 == 0;
					object obj15 = !flag9;
					if (obj15 != null)
					{
						goto IL_0243;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag10 = StringsExtensions.IsNullOrEmpty(clan.Name);
				clanNameLabel2 = clanLogoSetter2.clanNameLabel;
				bool flag11 = !flag10;
				object obj16 = !flag11;
				clanNameLabel = clanLogoSetter2.clanNameLabel;
				if (obj16 != null)
				{
					goto IL_0288;
				}
				goto IL_0371;
			}
			clanLogoSetter2.ClearClan();
			return;
			IL_0288:
			object obj17 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v16+90]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v17+B8]");
			object text = 0;
			clanNameLabel2.text = (string)text;
			goto IL_0388;
		}
	}

	private ClanEmblemLoader clanLogo;

	private TextMeshProUGUI clanNameLabel;

	private Button clanButton;

	private ClansSerializedUtils clanUtils;

	private int _clanId = -1;

	public int ClanId => _clanId;

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0159: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_01a3: Expected O, but got I4
		//IL_01ac: Expected O, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I
		//IL_0107: Expected I, but got O
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7362]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = clanButton;
			obj6 = clanButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = clanButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = clanButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c0;
		IL_00c0:
		Button button = clanButton;
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)1320;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj11);
		button.m_OnClick.AddListener(unityAction);
		return;
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		obj9 = 0;
		if (!flag6)
		{
			goto IL_00c0;
		}
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0159: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_01a3: Expected O, but got I4
		//IL_01ac: Expected O, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I
		//IL_0107: Expected I, but got O
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7363]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = clanButton;
			obj6 = clanButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = clanButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = clanButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c0;
		IL_00c0:
		Button button = clanButton;
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)1320;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj11);
		button.m_OnClick.RemoveListener(unityAction);
		return;
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		obj9 = 0;
		if (!flag6)
		{
			goto IL_00c0;
		}
	}

	public override void Initialize(AvatarData avatarData)
	{
		SetClan(avatarData.<ClanId>k__BackingField, avatarData.<ClanName>k__BackingField);
	}

	public override void Initialize(User userData)
	{
		int clanId = SFSKammelnaUserExtensions.GetClanId(userData);
		string clanName = SFSKammelnaUserExtensions.GetClanName(userData);
		SetClan(clanId, clanName);
	}

	public override void Clear()
	{
		//IL_0010: Expected I4, but got I8
		SetClan(-1, null);
	}

	public void OpenClanProfile()
	{
		if (_clanId >= 1)
		{
			clanUtils.OpenClanInfoPopup(_clanId);
		}
	}

	private void SetClan(int clanId, string clanName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_0289: Expected O, but got I4
		//IL_00f9: Expected O, but got I4
		//IL_0349: Expected O, but got I4
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected I4, but got Unknown
		//IL_014a: Expected O, but got I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0174: Expected O, but got I
		//IL_03cf: Expected O, but got I4
		//IL_0447: Expected O, but got I4
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_0474: Expected O, but got I
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_0494: Expected O, but got I
		//IL_04be: Expected O, but got I4
		//IL_0207: Expected O, but got I4
		//IL_0217: Expected O, but got I
		//IL_0227: Expected O, but got I
		//IL_0237: Expected I, but got O
		//IL_0247: Expected O, but got I
		//IL_0419: Expected O, but got I4
		//IL_0505: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_clanId = clanId;
		object obj4 = 152989696;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73A0]");
		object obj6 = (nint)0 & (nint)1;
		UnityEngine.Object obj8;
		UnityEngine.Object obj9;
		if (obj6 != null)
		{
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			obj8 = clanButton;
			obj9 = clanButton;
			if (!flag)
			{
				goto IL_00d6;
			}
		}
		else
		{
			_ = 1;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			obj8 = clanButton;
			obj9 = clanButton;
			if (obj10 != null)
			{
				goto IL_00d6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj9;
		bool flag4 = !flag3;
		bool flag5 = false;
		if (flag4)
		{
			goto IL_0110;
		}
		goto IL_02e9;
		IL_01be:
		bool flag6 = StringsExtensions.IsNullOrEmpty(clanName);
		TextMeshProUGUI textMeshProUGUI = clanNameLabel;
		bool flag7 = !flag6;
		TextMeshProUGUI textMesh = clanNameLabel;
		if (!flag7)
		{
			goto IL_01f8;
		}
		goto IL_0431;
		IL_0431:
		TextMeshProExtensions.FixArabic(textMesh, clanName);
		object obj11 = 0;
		string text = clanName;
		goto IL_0454;
		IL_01f8:
		object obj12 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v24+90]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v25+B8]");
		object obj14 = 0;
		text = (string)obj14;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v27 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		obj11 = 0;
		textMeshProUGUI.text = (string)obj14;
		goto IL_0454;
		IL_00d6:
		bool flag8 = obj8;
		bool flag9 = !flag8;
		object obj15 = !flag9;
		flag5 = false;
		if (obj15 == null)
		{
			goto IL_0110;
		}
		goto IL_02e9;
		IL_02e9:
		bool flag10 = clanId < 0;
		bool flag11 = clanId == 0;
		int num2 = clanId ^ clanId;
		int num3 = clanId & num2;
		bool flag12 = num3 < 0;
		bool flag13 = flag10 == flag12;
		object obj16 = !flag11;
		bool flag14 = (byte)((flag13 & obj16) ? 1 : 0) != 0;
		clanButton.interactable = flag14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
		bool flag15 = (nint)0 > (nint)0;
		string text2 = null;
		flag5 = flag14;
		if (flag15)
		{
			goto IL_0141;
		}
		goto IL_0398;
		IL_0110:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
		bool flag16 = (nint)0 <= (nint)0;
		text2 = clanName;
		if (!flag16)
		{
			goto IL_0141;
		}
		goto IL_0398;
		IL_0398:
		ClearClan();
		return;
		IL_0141:
		object obj17 = 152989696;
		object obj18 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E739F]");
		object obj19 = (nint)0 & (nint)1;
		if (obj19 != null)
		{
			object obj20 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v31+E4]");
			if ((nint)0 != 0)
			{
				goto IL_01be;
			}
		}
		else
		{
			_ = 1;
			object obj20 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v31+E4]");
			bool flag17 = (nint)0 == 0;
			object obj21 = !flag17;
			if (obj21 != null)
			{
				goto IL_01be;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag18 = StringsExtensions.IsNullOrEmpty(clanName);
		textMeshProUGUI = clanNameLabel;
		bool flag19 = !flag18;
		object obj22 = !flag19;
		textMesh = clanNameLabel;
		if (obj22 != null)
		{
			goto IL_01f8;
		}
		goto IL_0431;
		IL_0454:
		object obj23 = typeof(Queue<string>) + 728;
		object obj24 = (nint)0 + (nint)1976;
		object obj25 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj26 = (nint)0 + (nint)352;
		object obj27 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v22+E4]");
		bool flag20 = (nint)0 == 0;
		object obj28 = !flag20;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj26);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetClan(0, action);
	}

	private void SetClanName(string clanName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0147: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_00cd: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_00ed: Expected I, but got O
		//IL_00fd: Expected O, but got I
		//IL_010d: Expected O, but got I
		//IL_0191: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E739F]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_0117;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0074;
		}
		goto IL_0155;
		IL_01a9:
		TextMeshProUGUI textMesh;
		TextMeshProExtensions.FixArabic(textMesh, clanName);
		return;
		IL_0074:
		bool flag = StringsExtensions.IsNullOrEmpty(clanName);
		TextMeshProUGUI textMeshProUGUI = clanNameLabel;
		bool flag2 = !flag;
		textMesh = clanNameLabel;
		if (!flag2)
		{
			goto IL_00ae;
		}
		goto IL_01a9;
		IL_00ae:
		object obj4 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v9+90]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v10+B8]");
		object obj6 = 0;
		object obj7 = obj6;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v12 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v12 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v92 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_0117;
		IL_0117:
		_ = 1;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_0074;
		}
		goto IL_0155;
		IL_0155:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag4 = StringsExtensions.IsNullOrEmpty(clanName);
		textMeshProUGUI = clanNameLabel;
		bool flag5 = !flag4;
		object obj11 = !flag5;
		textMesh = clanNameLabel;
		if (obj11 != null)
		{
			goto IL_00ae;
		}
		goto IL_01a9;
	}

	private void SetClickable(bool clickable)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73A0]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = clanButton;
			obj6 = clanButton;
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
			obj5 = clanButton;
			obj6 = clanButton;
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
		clanButton.interactable = clickable;
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void ClearClan()
	{
		//IL_0015: Expected I4, but got I8
		//IL_001e: Expected O, but got I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_0162: Expected O, but got I4
		//IL_00d8: Expected O, but got I4
		//IL_00e8: Expected O, but got I
		//IL_00f8: Expected O, but got I
		//IL_0108: Expected I, but got O
		//IL_0118: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_01a9: Expected O, but got I4
		clanLogo.Load(-1, null);
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E739F]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0132;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0092;
		}
		goto IL_0170;
		IL_01c1:
		TextMeshProUGUI textMesh;
		TextMeshProExtensions.FixArabic(textMesh, null);
		return;
		IL_0092:
		bool flag = StringsExtensions.IsNullOrEmpty(null);
		TextMeshProUGUI textMeshProUGUI = clanNameLabel;
		bool flag2 = !flag;
		textMesh = clanNameLabel;
		if (!flag2)
		{
			goto IL_00c9;
		}
		goto IL_01c1;
		IL_00c9:
		object obj5 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v10+90]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v11+B8]");
		object obj7 = 0;
		object obj8 = obj7;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v13 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v13 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v78 @ X3_v3 (should have been resolved before IL gen)");
		goto IL_0132;
		IL_0132:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 != null)
		{
			goto IL_0092;
		}
		goto IL_0170;
		IL_0170:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag4 = StringsExtensions.IsNullOrEmpty(null);
		textMeshProUGUI = clanNameLabel;
		bool flag5 = !flag4;
		object obj12 = !flag5;
		textMesh = clanNameLabel;
		if (obj12 != null)
		{
			goto IL_00c9;
		}
		goto IL_01c1;
	}
}
