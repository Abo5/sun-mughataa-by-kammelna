using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TopbarFTInfoPanel : FastTrackInfoPanel
{
	public Sprite currentStage;

	public TextMeshProUGUI LevelText;

	private GameEventsChannel gameEventsChannel;

	private void InitMainMenuItems()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0146: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A07]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object levelText;
		UnityEngine.Object levelText2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			levelText = LevelText;
			levelText2 = LevelText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			levelText = LevelText;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			levelText2 = LevelText;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = levelText2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0154;
		IL_0154:
		object text = "SERVICE_DISABLED" + 2392;
		object obj7 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 384;
		if (FTLevel != 2)
		{
			text = obj7;
		}
		TextMeshProExtensions.Localize(LevelText, (string)text);
		return;
		IL_0091:
		if (levelText == null)
		{
			return;
		}
		goto IL_0154;
	}

	protected override void InitFT()
	{
		base.InitFT();
		InitMainMenuItems();
	}

	protected override void InitLevelRanks()
	{
		//IL_03de: Expected O, but got I4
		//IL_03e7: Expected O, but got I4
		//IL_03f0: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_0310: Expected O, but got I4
		//IL_01a1: Expected O, but got I
		//IL_01de: Expected O, but got I
		//IL_00a8: Expected O, but got I
		//IL_021e: Expected O, but got I
		//IL_02aa: Expected O, but got I4
		//IL_00e5: Expected O, but got I
		//IL_024d: Expected O, but got I4
		//IL_0256: Expected O, but got I4
		//IL_025f: Expected O, but got I4
		//IL_0268: Expected O, but got I4
		//IL_0125: Expected O, but got I
		//IL_02f9: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0166: Expected O, but got I4
		//IL_016f: Expected O, but got I4
		base.InitLevelRanks();
		bool flag = levelRanks == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		object obj = 0;
		object obj2 = 152993792;
		if (!flag)
		{
			object obj3 = (nint)0 + (nint)456;
			obj2 = (nint)0 + (nint)448;
			List<object>.Enumerator enumerator2 = ((List<object>)(object)levelRanks).GetEnumerator();
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			List<object>.Enumerator enumerator3 = enumerator4;
			List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
			object obj4 = default(object);
			while (true)
			{
				obj = obj3;
				if (enumerator5.MoveNext())
				{
					if (FTLevel != 2)
					{
						if (FTLevel == 1)
						{
							if (obj4 == null)
							{
								NullReferenceException ex = new NullReferenceException();
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-68+48]");
							object obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-68+48]");
							if ((nint)0 == 0)
							{
								NullReferenceException ex2 = new NullReferenceException();
								break;
							}
							object obj6 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v14+410]");
							obj = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v191 @ X8_v14+408] (should have been resolved before IL gen)");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-68+48]");
							if ((nint)0 == 0)
							{
								NullReferenceException ex3 = new NullReferenceException();
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-68+48]");
							Transform transform = ((Component)0).transform;
							if ((object)transform == null)
							{
								NullReferenceException ex4 = new NullReferenceException();
								obj = 0;
								break;
							}
							transform.localScale = (Vector3)0;
							List<object>.Enumerator enumerator6 = (List<object>.Enumerator)1067869798;
							List<object>.Enumerator enumerator7 = (List<object>.Enumerator)1067869798;
							enumerator3 = (List<object>.Enumerator)1067869798;
						}
					}
					else
					{
						if (obj4 == null)
						{
							NullReferenceException ex5 = new NullReferenceException();
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-68+48]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-68+48]");
						if ((nint)0 == 0)
						{
							NullReferenceException ex6 = new NullReferenceException();
							break;
						}
						object obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v13+410]");
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v192 @ X8_v13+408] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-68+48]");
						if ((nint)0 == 0)
						{
							NullReferenceException ex7 = new NullReferenceException();
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-68+48]");
						Transform transform2 = ((Component)0).transform;
						if ((object)transform2 == null)
						{
							NullReferenceException ex8 = new NullReferenceException();
							obj = 0;
							break;
						}
						transform2.localScale = (Vector3)0;
						List<object>.Enumerator enumerator6 = (List<object>.Enumerator)1066192077;
						List<object>.Enumerator enumerator7 = (List<object>.Enumerator)1066192077;
						enumerator3 = (List<object>.Enumerator)1066192077;
					}
					continue;
				}
				enumerator5.Dispose();
				return;
			}
			enumerator = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
		}
		NullReferenceException ex9 = new NullReferenceException();
		bool flag2 = (nint)obj != 1;
		OutOfMemoryException ex10 = (OutOfMemoryException)(object)ex9;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj = obj2;
			enumerator.Dispose();
			object obj9 = default(object);
			if (obj9 == null)
			{
				return;
			}
			ex10 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E6C0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	protected override void InitCurrentStage()
	{
		base.InitCurrentStage();
		int fTStage;
		if (FTLevel != 2)
		{
			if (FTLevel != 1)
			{
				return;
			}
			horizontalLayout.spacing = 24f;
			horizontalLayout.childAlignment = TextAnchor.MiddleCenter;
			fTStage = FTStage;
			if (FTStage != 6)
			{
				goto IL_0099;
			}
		}
		else
		{
			horizontalLayout.spacing = 7f;
			horizontalLayout.childAlignment = TextAnchor.MiddleCenter;
			fTStage = FTStage;
			if (FTStage != 8)
			{
				goto IL_0099;
			}
		}
		horizontalLayout.childAlignment = TextAnchor.MiddleLeft;
		return;
		IL_0099:
		if (fTStage == 1)
		{
			horizontalLayout.childAlignment = TextAnchor.MiddleRight;
		}
	}

	protected override void InitProgressBreadCrumps()
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_01a6: Expected I, but got O
		//IL_00d6: Expected I, but got O
		//IL_0232: Expected O, but got I4
		//IL_0171: Expected O, but got I4
		//IL_0087: Expected O, but got I4
		base.InitProgressBreadCrumps();
		List<object> fTRoundsBreadCrumps = (List<object>)(object)FTRoundsBreadCrumps;
		object obj = (nint)0 + (nint)872;
		object obj2 = typeof(SqlSingle[]) + 3912;
		int num = 0;
		while (true)
		{
			if (num < fTRoundsBreadCrumps._size)
			{
				object obj3 = fTRoundsBreadCrumps.get_Item(num);
				if (num == FTRoundsWon)
				{
					nint num2 = (nint)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ X8_v11 (Il2CppClass<System.Object>)+2A8] (should have been resolved before IL gen)");
					object obj4 = ((List<object>)(object)FTRoundsBreadCrumps).get_Item(num);
					GameObject gameObject = ((Component)obj4).gameObject;
					gameObject.SetActive(value: true);
					object obj5 = ((List<object>)(object)FTRoundsBreadCrumps).get_Item(num);
					RectTransform rectTransform = ((Graphic)obj5).rectTransform;
					object obj6 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v12+E4]");
					bool flag = (nint)0 == 0;
					object obj7 = !flag;
					Transform rect = rectTransform;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						rect = rectTransform;
					}
					AnimationExtensions.AnimHeartGain(rect, num);
					num++;
					fTRoundsBreadCrumps = (List<object>)(object)FTRoundsBreadCrumps;
					bool flag2 = FTRoundsBreadCrumps == null;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						break;
					}
				}
				else
				{
					nint num3 = (nint)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v202 @ X8_v10 (Il2CppClass<System.Object>)+2A8] (should have been resolved before IL gen)");
					num++;
					fTRoundsBreadCrumps = (List<object>)(object)FTRoundsBreadCrumps;
				}
				continue;
			}
			RankUI fTAwardRank = FTAwardRank;
			fTAwardRank.rankImage.SetNativeSize();
			Transform transform = FTAwardRank.transform;
			transform.localScale = (Vector3)0;
			return;
		}
		throw new NullReferenceException();
	}

	public void ExitGame()
	{
		gameEventsChannel.TriggerExitGame();
	}
}
