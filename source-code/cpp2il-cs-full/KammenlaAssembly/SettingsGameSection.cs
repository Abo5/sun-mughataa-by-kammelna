using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SettingsGameSection : MonoBehaviour
{
	private Toggle cardDimmingToggle;

	private Toggle confirmSawaToggle;

	private Toggle BiddingPredeterminationToggle;

	private Toggle AllowDifferentCardElevation;

	private Toggle AllowMyTurnHandAnimation;

	private Toggle AllowVibration;

	private Toggle ShowJackarooTips;

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_017a: Expected O, but got I
		//IL_0192: Expected I, but got O
		//IL_01e2: Expected O, but got I
		//IL_01fa: Expected I, but got O
		//IL_0249: Expected O, but got I
		//IL_0261: Expected I, but got O
		//IL_02b0: Expected O, but got I
		//IL_02c8: Expected I, but got O
		//IL_0317: Expected O, but got I
		//IL_032f: Expected I, but got O
		//IL_037e: Expected O, but got I
		//IL_0396: Expected I, but got O
		//IL_03e5: Expected O, but got I
		//IL_03fd: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E68B0]");
		object obj3 = (nint)0 & (nint)1;
		Toggle toggle;
		Toggle toggle2;
		if (obj3 != null)
		{
			toggle = cardDimmingToggle;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v44+E4]");
			bool flag = (nint)0 == 0;
			toggle2 = cardDimmingToggle;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			toggle = cardDimmingToggle;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v44+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			toggle2 = cardDimmingToggle;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool cardDimming = Preferences.CardDimming;
		toggle = toggle2;
		goto IL_013e;
		IL_013e:
		toggle.isOn = cardDimming;
		Toggle toggle3 = cardDimmingToggle;
		object obj6 = typeof(TypeConverter<ushort, char>) + 360;
		object obj7 = (nint)0 + (nint)3272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor((object)this, (IntPtr)obj7);
		toggle3.onValueChanged.AddListener(unityAction);
		bool confirmSawa = Preferences.ConfirmSawa;
		confirmSawaToggle.isOn = confirmSawa;
		Toggle toggle4 = confirmSawaToggle;
		object obj8 = (nint)0 + (nint)3280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction2 = default(UnityAction<bool>);
		unityAction2..ctor((object)this, (IntPtr)obj8);
		toggle4.onValueChanged.AddListener(unityAction2);
		bool biddingPredetermination = Preferences.BiddingPredetermination;
		BiddingPredeterminationToggle.isOn = biddingPredetermination;
		Toggle biddingPredeterminationToggle = BiddingPredeterminationToggle;
		object obj9 = (nint)0 + (nint)3264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction3 = default(UnityAction<bool>);
		unityAction3..ctor((object)this, (IntPtr)obj9);
		biddingPredeterminationToggle.onValueChanged.AddListener(unityAction3);
		bool allowDifferentCardElevation = Preferences.AllowDifferentCardElevation;
		AllowDifferentCardElevation.isOn = allowDifferentCardElevation;
		Toggle allowDifferentCardElevation2 = AllowDifferentCardElevation;
		object obj10 = (nint)0 + (nint)3240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction4 = default(UnityAction<bool>);
		unityAction4..ctor((object)this, (IntPtr)obj10);
		allowDifferentCardElevation2.onValueChanged.AddListener(unityAction4);
		bool allowMyTurnHandAnimation = Preferences.AllowMyTurnHandAnimation;
		AllowMyTurnHandAnimation.isOn = allowMyTurnHandAnimation;
		Toggle allowMyTurnHandAnimation2 = AllowMyTurnHandAnimation;
		object obj11 = (nint)0 + (nint)3248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction5 = default(UnityAction<bool>);
		unityAction5..ctor((object)this, (IntPtr)obj11);
		allowMyTurnHandAnimation2.onValueChanged.AddListener(unityAction5);
		bool allowVibration = Preferences.AllowVibration;
		AllowVibration.isOn = allowVibration;
		Toggle allowVibration2 = AllowVibration;
		object obj12 = (nint)0 + (nint)3256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction6 = default(UnityAction<bool>);
		unityAction6..ctor((object)this, (IntPtr)obj12);
		allowVibration2.onValueChanged.AddListener(unityAction6);
		bool showJackarooTips = Preferences.ShowJackarooTips;
		ShowJackarooTips.isOn = showJackarooTips;
		Toggle showJackarooTips2 = ShowJackarooTips;
		object obj13 = (nint)0 + (nint)3288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction7 = default(UnityAction<bool>);
		unityAction7..ctor((object)this, (IntPtr)obj13);
		showJackarooTips2.onValueChanged.AddListener(unityAction7);
		return;
		IL_0091:
		cardDimming = Preferences.CardDimming;
		bool flag3 = (object)toggle == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_013e;
	}

	private void ConfirmSawaToggleChanged(bool val)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E68B1]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.ConfirmSawa = val;
		return;
		IL_0074:
		Preferences.ConfirmSawa = val;
	}

	private void CardDimmingToggleChanged(bool val)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E68B2]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.CardDimming = val;
		return;
		IL_0074:
		Preferences.CardDimming = val;
	}

	private void BiddingPredeterminationChanged(bool val)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E68B3]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.BiddingPredetermination = val;
		return;
		IL_0074:
		Preferences.BiddingPredetermination = val;
	}

	private void AllowDifferentCardElevationChanged(bool val)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E68B4]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.AllowDifferentCardElevation = val;
		return;
		IL_0074:
		Preferences.AllowDifferentCardElevation = val;
	}

	private void AllowMyTurnHandAnimationChanged(bool val)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E68B5]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.AllowMyTurnHandAnimation = val;
		return;
		IL_0074:
		Preferences.AllowMyTurnHandAnimation = val;
	}

	private void AllowVibrationChanged(bool val)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E68B6]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.AllowVibration = val;
		return;
		IL_0074:
		Preferences.AllowVibration = val;
	}

	private void ShowJackarooTipsChanged(bool val)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E68B7]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.ShowJackarooTips = val;
		return;
		IL_0074:
		Preferences.ShowJackarooTips = val;
	}
}
