using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class FastTrackWinsInfo : MonoBehaviour
{
	private static readonly Color CountTextColor;

	private TextMeshProUGUI countText;

	private Image countBackground;

	private Sprite zeroSprite;

	private Sprite normalSprite;

	private Image container;

	private Image Cup;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0075: Expected I, but got O
		//IL_009f: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2544;
		object obj3 = typeof(UsageHint) + 72;
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
		UserInfo.OnFastTrackRecordUpdated += action;
		UpdateInfo();
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
		object obj2 = (nint)0 + (nint)2544;
		object obj3 = typeof(UsageHint) + 72;
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
		UserInfo.OnFastTrackRecordUpdated -= action;
	}

	private void UpdateInfo()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01a9: Expected I, but got O
		//IL_03b9: Expected O, but got I
		//IL_03c7: Expected O, but got I4
		//IL_03d7: Expected O, but got I
		//IL_03ee: Expected O, but got I
		//IL_0418: Expected O, but got I4
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_023f: Expected O, but got I4
		//IL_0274: Expected O, but got I
		//IL_0284: Expected F8, but got I
		//IL_0294: Expected F8, but got I
		//IL_029c: Expected F8, but got O
		//IL_02ac: Expected F8, but got I
		//IL_02b9: Expected O, but got I
		//IL_0463: Expected O, but got I4
		//IL_02c7: Expected O, but got I4
		//IL_02d7: Expected O, but got I
		//IL_02ee: Expected O, but got I
		//IL_0318: Expected O, but got I4
		//IL_0321: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89FE]");
		object obj3 = (nint)0 & (nint)1;
		TextMeshProUGUI textMeshProUGUI;
		object obj6;
		TextMeshProUGUI textMeshProUGUI2;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			textMeshProUGUI = countText;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v38+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			textMeshProUGUI2 = countText;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			textMeshProUGUI = countText;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v38+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			textMeshProUGUI2 = countText;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		textMeshProUGUI = textMeshProUGUI2;
		goto IL_0170;
		IL_033e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int numberOfFTWon = SFSKammelnaUserExtensions.GetNumberOfFTWon(localUser);
		if (numberOfFTWon >= 1)
		{
			GameObject gameObject = container.gameObject;
			gameObject.SetActive(value: true);
		}
		else
		{
			TweenerCore<Color, Color, ColorOptions> tweenerCore = ShortcutExtensionsTMPText.DOFade(countText, 0.5f, 0f);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOFade(Cup, 0.5f, 0f);
		}
		return;
		IL_032f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_033e;
		IL_0170:
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		int numberOfFTWon2 = SFSKammelnaUserExtensions.GetNumberOfFTWon(localUser2);
		int num = default(int);
		string text = num.ToString();
		nint num2 = (nint)textMeshProUGUI;
		textMeshProUGUI.text = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		User localUser3 = sessionModel3.LocalUser;
		if (SFSKammelnaUserExtensions.GetNumberOfFTWon(localUser3) != 0)
		{
			object obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 272;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v12+B8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v13+8]");
			double num3 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v13+C]");
			double num4 = 0.0;
			double num5 = (double)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v13+4]");
			double num6 = 0.0;
			countText.color = (Color)0;
			object obj13 = 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FastTrackWinsInfo)+v263 @ X8_v15]");
			Sprite sprite = (Sprite)0;
			Image image = countBackground;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FastTrackWinsInfo)+v263 @ X8_v15]");
			image.sprite = (Sprite)0;
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v29+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			object obj16 = 0;
			if (obj15 == null)
			{
				goto IL_032f;
			}
		}
		else
		{
			countText.color = (Color)0;
			object obj17 = 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FastTrackWinsInfo)+v260 @ X8_v7]");
			Sprite sprite = (Sprite)0;
			Image image2 = countBackground;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FastTrackWinsInfo)+v260 @ X8_v7]");
			image2.sprite = (Sprite)0;
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v29+E4]");
			bool flag5 = (nint)0 == 0;
			object obj18 = !flag5;
			if (obj18 == null)
			{
				double num6 = 1.0;
				double num5 = 1.0;
				double num4 = 1.0;
				double num3 = 1.0;
				object obj16 = 0;
				goto IL_032f;
			}
		}
		goto IL_033e;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag6 = (object)sessionModel2 == null;
		object obj19 = !flag6;
		if (obj19 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0170;
	}

	static FastTrackWinsInfo()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 272;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253620]");
		obj3 = 0;
	}
}
