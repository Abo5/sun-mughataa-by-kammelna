using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using ListView;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TeamUi : ListViewItem<QueueTeam, int>
{
	private TeamPlayerUi[] playerUis;

	private GameObject[] teamObjects;

	private GameObject[] highlight;

	private Button breakButton;

	private Button selectButton;

	private TournamentSceneEventsChannel tournamentEventsChannel;

	private bool isOwner;

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01a7: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0237: Expected O, but got I
		//IL_0245: Expected I, but got O
		//IL_0290: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_02ab: Expected O, but got I4
		//IL_02b4: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03c0: Expected O, but got I
		//IL_03ea: Expected O, but got I4
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_035c: Expected O, but got I
		//IL_036a: Expected I, but got O
		//IL_038a: Expected O, but got I4
		//IL_0393: Expected O, but got I4
		//IL_0470: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DA1]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v28+E4]");
			bool flag = (nint)0 == 0;
			obj5 = breakButton;
			obj6 = breakButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = breakButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v28+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = breakButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		UnityAction unityAction = null;
		UnityAction unityAction2 = null;
		if (flag4)
		{
			goto IL_00cc;
		}
		goto IL_01fe;
		IL_03a0:
		object obj8 = typeof(Queue<string>) + 848;
		object obj9 = (nint)0 + (nint)2200;
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v4+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		int originalOwnerId = SFSKammelnaRoomExtensions.GetOriginalOwnerId(currentRoom);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser = sessionModel2.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		object obj12 = originalOwnerId - intDbId;
		bool flag6 = obj12 == null;
		isOwner = flag6;
		return;
		IL_0323:
		Button button = selectButton;
		object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1344;
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj14);
		button.m_OnClick.AddListener(unityAction3);
		object obj15 = 0;
		object obj16 = 0;
		UnityAction unityAction4 = unityAction3;
		goto IL_03a0;
		IL_011d:
		UnityEngine.Object obj17;
		bool flag7 = obj17;
		bool flag8 = !flag7;
		object obj18 = !flag8;
		UnityAction unityAction5 = null;
		if (obj18 != null)
		{
			goto IL_0323;
		}
		object obj19 = default(object);
		obj15 = obj19;
		object obj20 = default(object);
		obj16 = obj20;
		unityAction4 = null;
		goto IL_03a0;
		IL_0091:
		bool flag9 = obj5;
		bool flag10 = !flag9;
		object obj21 = !flag10;
		unityAction = null;
		unityAction2 = null;
		if (obj21 == null)
		{
			goto IL_00cc;
		}
		goto IL_01fe;
		IL_01fe:
		Button button2 = breakButton;
		object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)1336;
		UnityAction unityAction6 = default(UnityAction);
		unityAction6..ctor(this, (IntPtr)obj23);
		button2.m_OnClick.AddListener(unityAction6);
		obj17 = selectButton;
		object obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v19+E4]");
		bool flag11 = (nint)0 == 0;
		object obj25 = !flag11;
		obj19 = 0;
		obj20 = 0;
		obj15 = 0;
		obj16 = 0;
		unityAction = unityAction6;
		UnityEngine.Object obj26 = selectButton;
		if (obj25 != null)
		{
			goto IL_011d;
		}
		goto IL_02d4;
		IL_00cc:
		obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v19+E4]");
		bool flag12 = (nint)0 == 0;
		obj17 = selectButton;
		obj15 = obj19;
		obj16 = obj20;
		obj26 = selectButton;
		if (!flag12)
		{
			goto IL_011d;
		}
		goto IL_02d4;
		IL_02d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag13 = obj26;
		bool flag14 = !flag13;
		obj19 = obj15;
		obj20 = obj16;
		unityAction5 = null;
		unityAction4 = null;
		if (!flag14)
		{
			goto IL_0323;
		}
		goto IL_03a0;
	}

	public override void Setup(QueueTeam team, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Expected O, but got I
		//IL_0068: Expected O, but got I
		//IL_008a: Expected O, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I4
		//IL_0103: Expected I, but got O
		//IL_07bc: Expected O, but got I
		//IL_0157: Expected O, but got I
		//IL_01ba: Expected O, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_0206: Expected O, but got I4
		//IL_0233: Expected I, but got O
		//IL_024e: Expected O, but got I4
		//IL_0800: Expected O, but got I
		//IL_0808: Expected I4, but got O
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02af: Expected O, but got I4
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_03a1: Expected O, but got I4
		//IL_02c5: Expected O, but got I
		//IL_0498: Expected O, but got I4
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_0311: Expected O, but got I
		//IL_03b7: Expected O, but got I
		//IL_070e: Expected O, but got I4
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_0403: Expected O, but got I
		//IL_0651: Expected O, but got I
		//IL_06b3: Expected O, but got I4
		//IL_059c: Expected O, but got I
		object obj = (nint)0 + (nint)1944;
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)team, firstTime2);
		TeamPlayerUi[] array = playerUis;
		if (playerUis != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamUi)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamUi)+40]");
			if ((nint)0 != 0)
			{
				TeamPlayerUi teamPlayerUi = array[0];
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X9_v4+10]");
				QueuePlayer datum = (QueuePlayer)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X9_v4+10]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 2760;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v32+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj5 = obj4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v32+B8]");
					object obj7 = 0;
					datum = (QueuePlayer)obj7;
				}
				if ((object)array[0] != null)
				{
					nint num = (nint)teamPlayerUi;
					array[0].Setup(datum, firstTime2);
					TeamPlayerUi[] array2 = playerUis;
					if (playerUis != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamUi)+40]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamUi)+40]");
						if ((nint)0 != 0)
						{
							TeamPlayerUi teamPlayerUi2 = array2[1];
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v8+18]");
							bool flag3 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v8+18]");
							bool flag4 = (byte)(~(nuint)0u) != 0;
							object obj9 = !flag4;
							if (obj9 == null)
							{
								object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 2760;
								object obj11 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v28+E4]");
								bool flag5 = (nint)0 == 0;
								object obj12 = !flag5;
								if (obj12 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj11 = obj10;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v28+B8]");
								object obj13 = 0;
								flag3 = (byte)(int)obj13 != 0;
							}
							if ((object)array2[1] != null)
							{
								nint num2 = (nint)teamPlayerUi2;
								array2[1].Setup((QueuePlayer)flag3, firstTime2);
								GameObject[] array3 = teamObjects;
								if (teamObjects != null)
								{
									if (array3.Length < 1)
									{
										goto IL_0340;
									}
									object obj14 = teamObjects + 32;
									object obj15 = 0;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamUi)+40]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamUi)+40]");
										bool isTeam = ((QueueTeam)0).IsTeam;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X23_v9+v210 @ X22_v15*8]");
										if ((nint)0 == 0)
										{
											break;
										}
										obj15++;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X23_v9+v210 @ X22_v15*8]");
										((GameObject)0).SetActive(isTeam);
										bool flag6 = (nint)obj15 < array3.Length;
										firstTime2 = false;
										flag3 = isTeam;
										if (flag6)
										{
											continue;
										}
										goto IL_0340;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0739;
		IL_0432:
		object obj16 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = breakButton;
			bool flag8 = !flag7;
			object obj18 = !flag8;
			bool flag9 = false;
			if (obj18 == null)
			{
				goto IL_04af;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag10 = breakButton;
			bool flag11 = !flag10;
			bool flag9 = false;
			if (flag11)
			{
				goto IL_04af;
			}
		}
		UnityEngine.Object obj19;
		UnityEngine.Object obj22;
		object obj20;
		if ((object)breakButton != null)
		{
			GameObject gameObject = breakButton.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamUi)+40]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamUi)+40]");
				bool isSelected = ((QueueTeam)0).IsSelected;
				if ((object)gameObject != null)
				{
					gameObject.SetActive(isSelected);
					obj19 = selectButton;
					obj20 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v17+E4]");
					bool flag12 = (nint)0 == 0;
					object obj21 = !flag12;
					firstTime2 = false;
					bool flag9 = isSelected;
					obj22 = selectButton;
					if (obj21 != null)
					{
						goto IL_04f0;
					}
					goto IL_06dc;
				}
			}
		}
		goto IL_0739;
		IL_04af:
		obj19 = selectButton;
		obj20 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v17+E4]");
		bool flag13 = (nint)0 == 0;
		obj22 = selectButton;
		if (!flag13)
		{
			goto IL_04f0;
		}
		goto IL_06dc;
		IL_0340:
		GameObject[] array4 = highlight;
		if (highlight != null)
		{
			if (array4.Length < 1)
			{
				goto IL_0432;
			}
			object obj23 = highlight + 32;
			object obj24 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamUi)+40]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamUi)+40]");
				bool isSelected2 = ((QueueTeam)0).IsSelected;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X23_v8+v212 @ X22_v12*8]");
				if ((nint)0 == 0)
				{
					break;
				}
				obj24++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X23_v8+v212 @ X22_v12*8]");
				((GameObject)0).SetActive(isSelected2);
				bool flag14 = (nint)obj24 < array4.Length;
				firstTime2 = false;
				bool flag3 = isSelected2;
				if (flag14)
				{
					continue;
				}
				goto IL_0432;
			}
		}
		goto IL_0739;
		IL_0516:
		if ((object)selectButton != null)
		{
			GameObject gameObject2 = selectButton.gameObject;
			bool active;
			if (isOwner)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamUi)+40]");
				if ((nint)0 == 0)
				{
					goto IL_0739;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamUi)+40]");
				bool isTeam2 = ((QueueTeam)0).IsTeam;
				active = isTeam2;
			}
			else
			{
				active = false;
			}
			if ((object)gameObject2 != null)
			{
				gameObject2.SetActive(active);
				return;
			}
		}
		goto IL_0739;
		IL_06dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = obj22;
		bool flag16 = !flag15;
		object obj25 = !flag16;
		if (obj25 == null)
		{
			return;
		}
		goto IL_0516;
		IL_04f0:
		if ((bool)obj19)
		{
			goto IL_0516;
		}
		return;
		IL_0739:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void BreakTeam()
	{
		//IL_0042: Expected O, but got I
		//IL_0015: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamUi)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
		object obj2 = 0;
		TournamentSceneEventsChannel tournamentSceneEventsChannel = tournamentEventsChannel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v5+1C]");
		tournamentSceneEventsChannel.TriggerBreakTeam(0);
	}

	private void SelectTeam()
	{
		//IL_0039: Expected O, but got I
		//IL_0028: Expected O, but got I
		//IL_0028: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamUi)+40]");
		object obj = 0;
		TournamentSceneEventsChannel tournamentSceneEventsChannel = tournamentEventsChannel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+18]");
		tournamentSceneEventsChannel.TriggerSelectingTeam((QueuePlayer)num, (QueuePlayer)0);
	}

	public TeamUi()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
