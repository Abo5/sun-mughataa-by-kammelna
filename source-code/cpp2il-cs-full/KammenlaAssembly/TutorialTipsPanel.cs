using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Baloot.Tutorial;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class TutorialTipsPanel : MonoBehaviour
{
	private TopbarExtraButtons movingPanel;

	private GameObject blocker;

	private TextMeshProUGUI bodyText;

	private TextMeshProUGUI titleText;

	private BalootGame game;

	public void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008b: Expected O, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)8;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2336;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 64;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		((KGame)obj7).OnGameStateUpdated += action;
	}

	public void ShowTipMessage()
	{
		//IL_0023: Expected O, but got I4
		bool isTablet = ScreenUtility.IsTablet;
		bool flag = !isTablet;
		object obj = !flag;
		if (obj == null)
		{
			blocker.SetActive(value: true);
		}
		movingPanel.Show();
	}

	private void SetUpAllText()
	{
		//IL_0154: Expected O, but got I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01b7: Expected O, but got I4
		//IL_02c3: Expected O, but got I
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_03b3: Expected O, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_047a: Expected O, but got I4
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected O, but got Unknown
		//IL_05d6: Expected O, but got I
		//IL_05f8: Expected O, but got I4
		//IL_061e: Expected O, but got I
		//IL_04c0: Expected O, but got I
		//IL_0506: Expected O, but got I4
		//IL_0529: Expected O, but got I
		//IL_0540: Expected O, but got I
		int size;
		if ((object)game != null)
		{
			bool isHokom = game.IsHokom;
			if ((object)game != null)
			{
				bool isSun = game.IsSun;
				if ((object)game != null)
				{
					BalootPlayer myPlayer = game.MyPlayer;
					if (myPlayer != null)
					{
						if (myPlayer.CanPlayCard)
						{
							bool isTablet = ScreenUtility.IsTablet;
							bool flag = !isTablet;
							object obj = !flag;
							if (obj == null)
							{
								if ((object)blocker == null)
								{
									goto IL_0541;
								}
								blocker.SetActive(value: true);
							}
							if ((object)movingPanel == null)
							{
								goto IL_0541;
							}
							movingPanel.Show();
						}
						object obj2 = isHokom || isSun;
						object obj3 = obj2 & 1;
						if (obj3 == null)
						{
							object text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1856;
							TextMeshProExtensions.Localize(titleText, (string)text);
							goto IL_0298;
						}
						object text2 = "HH:mm:ss.ffZ" + 1552;
						object obj4 = "SubscribeGroup request Error" + 200;
						bool flag2 = !isHokom;
						object obj5 = !flag2;
						object obj6 = ~obj5;
						if (obj6 != null)
						{
							text2 = obj4;
						}
						TextMeshProExtensions.Localize(titleText, (string)text2);
						if (myPlayer.IsMover)
						{
							BalootGame balootGame = game;
							if ((object)game == null || ((CardGame)balootGame).<Stage>k__BackingField == null)
							{
								goto IL_0541;
							}
							if (((CardGame)balootGame).<Stage>k__BackingField.IsWaitingForEating)
							{
								object text3 = "SubscribeGroup request Error" + 3016;
								TextMeshProExtensions.Localize(bodyText, (string)text3);
								return;
							}
						}
						bool canPlay = myPlayer.CanPlay;
						if ((object)game != null)
						{
							Room room = game.Room;
							TutorialType tutorialType = SFSKammelnaRoomExtensions.GetTutorialType(room);
							if (canPlay)
							{
								List<Card> <Cards>k__BackingField = ((CardGamePlayer)myPlayer).<Cards>k__BackingField;
								if (((CardGamePlayer)myPlayer).<Cards>k__BackingField != null)
								{
									size = <Cards>k__BackingField._size;
									object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2304;
									object obj8 = obj7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v35+E4]");
									bool flag3 = (nint)0 == 0;
									object obj9 = !flag3;
									if (obj9 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
									object obj11 = obj10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v37+B8]");
									object obj12 = 0;
									object obj13 = obj12;
									bool flag4 = obj12 == null;
									object obj14 = !flag4;
									if (obj14 != null)
									{
										goto IL_04b0;
									}
								}
							}
							else
							{
								if (!TutorialTypeExtensions.IsCatchTutorial(tutorialType))
								{
									goto IL_0298;
								}
								List<Card> <Cards>k__BackingField2 = ((CardGamePlayer)myPlayer).<Cards>k__BackingField;
								if (((CardGamePlayer)myPlayer).<Cards>k__BackingField != null)
								{
									size = <Cards>k__BackingField2._size;
									object obj15 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2304;
									object obj16 = obj15;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v28+E4]");
									bool flag5 = (nint)0 == 0;
									object obj17 = !flag5;
									if (obj17 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
									object obj19 = obj18;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v25+B8]");
									object obj20 = 0;
									object obj13 = obj20;
									if (obj20 != null)
									{
										goto IL_04b0;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0541;
		IL_054f:
		throw new IndexOutOfRangeException();
		IL_0541:
		NullReferenceException ex = new NullReferenceException();
		goto IL_054f;
		IL_04b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v16+E0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v16+E0]");
		if ((nint)0 == 0)
		{
			goto IL_0541;
		}
		int num = size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v17+18]");
		bool flag6 = (nint)num < (nint)0;
		object obj22 = !flag6;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v16+E0]");
			object obj23 = (nint)0 + (nint)size;
			TextMeshProUGUI textMesh = bodyText;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v18+20]");
			TextMeshProExtensions.Localize(textMesh, (string)0);
			return;
		}
		goto IL_054f;
		IL_0298:
		if ((object)bodyText != null)
		{
			object text4 = (nint)0 + (nint)2000;
			bodyText.SetText((string)text4);
			return;
		}
		goto IL_0541;
	}
}
