using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeHistoryStrip : MonoBehaviour
{
	private ChallengeStateData _data;

	private List<Sprite> challengeLevelsBackgrounds;

	private Image background;

	private AvatarInitializer avatarRight;

	private AvatarInitializer avatarLeft;

	private ChallengeStateLightSwitch lightSwitch;

	private ChallengeProgressBar progressBar;

	private Button historyButton;

	private ComponentReference<ChallengeHistoryRecordPopup> historyPopup;

	private int valueForTest;

	public void Populate(ChallengeStateData data, bool interactable = true)
	{
		//IL_0010: Expected O, but got I
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0062: Expected O, but got I
		//IL_0116: Expected O, but got I
		//IL_014c: Expected O, but got I
		//IL_0199: Expected O, but got I
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01d6: Expected O, but got I4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected I4, but got Unknown
		//IL_01ff: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A16]");
		object obj = 0;
		object obj2 = this + 32;
		obj2 = data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		NullReferenceException ex;
		bool interactable2;
		Selectable selectable;
		if (data != null)
		{
			AvatarData data2 = data.Player1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X22_v3+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X22_v3+18]");
				((AvatarInitializer)0).Initialize(data2);
				AvatarData data3 = data.Player2;
				if ((object)avatarLeft != null)
				{
					avatarLeft.Initialize(data3);
					ChangeStripLevel(data.ChallengeLevel);
					ex = (NullReferenceException)(object)historyButton;
					if (!interactable)
					{
						goto IL_022e;
					}
					obj = obj2;
					if (obj2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4+28]");
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4+28]");
						if ((nint)0 == 0)
						{
							goto IL_022e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4+18]");
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4+18]");
						bool flag = (nint)0 < (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4+18]");
						bool flag2 = (nint)0 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4+18]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4+18]");
						object obj3 = num ^ 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4+18]");
						object obj4 = 0 & obj3;
						bool flag3 = (nint)obj4 < 0;
						bool flag4 = flag == flag3;
						object obj5 = !flag2;
						bool flag5 = (byte)((flag4 & obj5) ? 1 : 0) != 0;
						bool flag6 = (object)historyButton == null;
						object obj6 = !flag6;
						interactable2 = flag5;
						selectable = historyButton;
						if (obj6 != null)
						{
							goto IL_025c;
						}
					}
				}
			}
		}
		goto IL_0220;
		IL_0220:
		ex = new NullReferenceException();
		goto IL_022e;
		IL_022e:
		bool flag7 = ex == null;
		interactable2 = false;
		selectable = (Selectable)(object)ex;
		if (flag7)
		{
			goto IL_0220;
		}
		goto IL_025c;
		IL_025c:
		selectable.interactable = interactable2;
	}

	public void TestWithValue()
	{
		ChangeStripLevel(valueForTest);
	}

	public void ShowHistory()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1384;
		object obj2 = (nint)0 + (nint)3512;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)1872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void ChangeStripLevel(int challengeLevel)
	{
		int index = challengeLevel + 3;
		object sprite = ((List<object>)(object)challengeLevelsBackgrounds).get_Item(index);
		background.sprite = (Sprite)sprite;
		lightSwitch.ShowLight(challengeLevel);
		progressBar.SetProgress(challengeLevel);
	}

	private Sprite GetSpriteBasedOnLevel(int level)
	{
		if (challengeLevelsBackgrounds != null)
		{
			int index = level + 3;
			return (Sprite)((List<object>)(object)challengeLevelsBackgrounds).get_Item(index);
		}
		return (Sprite)(object)new NullReferenceException();
	}

	private int TranslateLevelToArrayPosition(int level)
	{
		return level + 3;
	}

	private void <ShowHistory>b__12_0(ChallengeHistoryRecordPopup popup)
	{
		popup.ShowFor(_data);
	}
}
