using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;

public class MassStagePointsWidget : MonoBehaviour
{
	private TextMeshProUGUI stagePointsTitle;

	private TextMeshProUGUI pointsTxt;

	private GameObject pointsStar;

	private GameObject massCup;

	private GameObject eligibilityInfoButton;

	public unsafe void SetWidget(int championshipPoints, int stageId, MassEventStageType stageType, int? filterValue, bool isNotLastStage, MassEventNextStageEligibility eligibility)
	{
		//IL_065b: Expected O, but got I4
		//IL_0663: Expected O, but got I4
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_03f1: Expected O, but got I4
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected O, but got Unknown
		//IL_0417: Expected O, but got I4
		//IL_041f: Expected O, but got Ref
		//IL_0a07: Expected I, but got O
		//IL_0a17: Expected O, but got I
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Expected O, but got Unknown
		//IL_0a54: Expected O, but got I4
		//IL_0a75: Expected O, but got Ref
		//IL_0444: Expected O, but got Ref
		//IL_04c2: Expected O, but got I4
		//IL_0078: Expected O, but got I
		//IL_06d8: Expected O, but got Ref
		//IL_045a: Expected I, but got O
		//IL_046a: Expected O, but got I
		//IL_048b: Expected O, but got I4
		//IL_049b: Expected O, but got I
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_00cd: Expected I, but got O
		//IL_00dd: Expected O, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_011a: Expected O, but got I4
		//IL_06ee: Expected I, but got O
		//IL_06fe: Expected O, but got I
		//IL_0727: Expected O, but got I
		//IL_0149: Expected O, but got Ref
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected O, but got Unknown
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected O, but got Unknown
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Expected O, but got Unknown
		//IL_07e9: Expected O, but got I4
		//IL_0573: Expected I, but got O
		//IL_0583: Expected O, but got I
		//IL_016e: Expected O, but got Ref
		//IL_0812: Expected O, but got I
		//IL_0184: Expected I, but got O
		//IL_0194: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_09df: Expected O, but got I4
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0291: Expected O, but got I4
		//IL_061c: Expected O, but got I4
		//IL_02ba: Expected O, but got I
		//IL_08b9: Expected O, but got I4
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected I4, but got Unknown
		//IL_08fc: Expected O, but got I4
		//IL_0361: Expected O, but got I4
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected I4, but got Unknown
		int num = default(int);
		int? num2 = default(int?);
		bool flag10;
		GameObject gameObject;
		GameObject gameObject2;
		bool active;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		string text5;
		string text3;
		MassEventStageType massEventStageType = default(MassEventStageType);
		if (massEventStageType <= MassEventStageType.ConstantPointsFilter)
		{
			if (massEventStageType == MassEventStageType.ConstantPlayersFilter)
			{
				goto IL_03c3;
			}
			if (massEventStageType != MassEventStageType.ConstantPointsFilter)
			{
				return;
			}
			TextMeshProUGUI textMeshProUGUI = pointsTxt;
			string text = num.ToString();
			string text2 = num2.ToString();
			object obj = (nint)0 + (nint)3680;
			text3 = (string)obj;
			string text4 = text + (string)obj + text2;
			bool flag = (object)pointsTxt == null;
			massEventStageType = MassEventStageType.ConstantPlayersFilter;
			text5 = text2;
			if (!flag)
			{
				nint num3 = (nint)textMeshProUGUI;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v46 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
				text5 = (string)0;
				pointsTxt.text = text4;
				object obj2 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj3 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object[] array = default(object[]);
				bool flag2 = array == null;
				massEventStageType = MassEventStageType.ConstantPlayersFilter;
				object obj4 = default(object);
				text3 = (string)(&obj4);
				if (!flag2)
				{
					object obj5 = default(object);
					bool flag3 = obj5 == null;
					string text6 = (string)(&obj4);
					if (!flag3)
					{
						nint num4 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v62 (Il2CppClass<System.Object[]>)+40]");
						text6 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag4 = ex == null;
						massEventStageType = MassEventStageType.ConstantPlayersFilter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v62 (Il2CppClass<System.Object[]>)+40]");
						text3 = (string)0;
						if (flag4)
						{
							goto IL_0981;
						}
					}
					bool flag5 = array.Length == 0;
					massEventStageType = MassEventStageType.ConstantPlayersFilter;
					text3 = text6;
					if (flag5)
					{
						goto IL_0973;
					}
					object obj6 = array + 32;
					obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj7 = "SetRoomVariables request error" + 2560;
					text3 = (string)obj7;
					TextMeshProExtensions.LocalizeArguments(stagePointsTitle, (string)obj7, array);
					object obj8 = typeof(Queue<string>) + 848;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v71+E4]");
					bool flag6 = (nint)0 == 0;
					object obj10 = !flag6;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj11 = (nint)0 + (nint)2200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel = default(SessionModel);
					bool flag7 = (object)sessionModel == null;
					massEventStageType = MassEventStageType.ConstantPlayersFilter;
					text5 = (string)(object)array;
					if (!flag7)
					{
						Room currentRoom = sessionModel.CurrentRoom;
						TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom);
						bool flag8 = TournamentStatusExtensions.IsFinished(tournamentStatus);
						bool flag9 = (object)eligibilityInfoButton == null;
						massEventStageType = MassEventStageType.ConstantPlayersFilter;
						text5 = (string)(object)array;
						text3 = null;
						if (!flag9)
						{
							object obj12 = (flag8 ? 1 : 0) ^ 1;
							flag10 = (byte)((isNotLastStage & obj12) ? 1 : 0) != 0;
							massEventStageType = MassEventStageType.ConstantPlayersFilter;
							gameObject = eligibilityInfoButton;
							goto IL_09b4;
						}
					}
				}
			}
		}
		else
		{
			if (massEventStageType != MassEventStageType.TournamentWinnersFilter)
			{
				if (massEventStageType == MassEventStageType.PlayersRatioFilter)
				{
					goto IL_03c3;
				}
				return;
			}
			TextMeshProUGUI textMeshProUGUI2 = pointsTxt;
			bool flag11 = (object)pointsTxt == null;
			text5 = (string)stageId;
			text3 = (string)championshipPoints;
			if (!flag11)
			{
				object text7 = ", stale={0}" + 3776;
				object obj13 = ", stale={0}" + 3440;
				if (eligibility != MassEventNextStageEligibility.Eligible)
				{
					text7 = obj13;
				}
				nint num5 = (nint)textMeshProUGUI2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v23 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
				text5 = (string)0;
				pointsTxt.text = (string)text7;
				object obj14 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj15 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object[] array2 = default(object[]);
				bool flag12 = array2 == null;
				text3 = (string)(&num2);
				if (!flag12)
				{
					object obj16 = default(object);
					bool flag13 = obj16 == null;
					string text8 = (string)(&num2);
					if (!flag13)
					{
						nint num6 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
						text8 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag14 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
						text3 = (string)0;
						if (flag14)
						{
							goto IL_0981;
						}
					}
					bool flag15 = array2.Length == 0;
					text3 = text8;
					if (flag15)
					{
						goto IL_0973;
					}
					object obj17 = array2 + 32;
					obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj18 = "SetRoomVariables request error" + 2560;
					text3 = (string)obj18;
					TextMeshProExtensions.Localize(stagePointsTitle, (string)obj18, array2);
					object obj19 = typeof(Queue<string>) + 848;
					object obj20 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v41+E4]");
					bool flag16 = (nint)0 == 0;
					object obj21 = !flag16;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj22 = (nint)0 + (nint)2200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel2 = default(SessionModel);
					bool flag17 = (object)sessionModel2 == null;
					massEventStageType = MassEventStageType.ConstantPlayersFilter;
					text5 = (string)(object)array2;
					if (!flag17)
					{
						Room currentRoom2 = sessionModel2.CurrentRoom;
						TournamentStatus tournamentStatus2 = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom2);
						bool flag18 = TournamentStatusExtensions.IsFinished(tournamentStatus2);
						bool flag19 = (object)eligibilityInfoButton == null;
						massEventStageType = MassEventStageType.ConstantPlayersFilter;
						text5 = (string)(object)array2;
						text3 = null;
						if (!flag19)
						{
							object obj23 = (flag18 ? 1 : 0) ^ 1;
							bool flag20 = (byte)((isNotLastStage & obj23) ? 1 : 0) != 0;
							eligibilityInfoButton.SetActive(flag20);
							bool flag21 = (object)pointsStar == null;
							massEventStageType = MassEventStageType.ConstantPlayersFilter;
							text5 = null;
							text3 = (string)flag20;
							if (!flag21)
							{
								pointsStar.SetActive(value: false);
								gameObject2 = massCup;
								bool flag22 = (object)massCup == null;
								massEventStageType = MassEventStageType.ConstantPlayersFilter;
								text5 = null;
								text3 = null;
								if (!flag22)
								{
									active = true;
									goto IL_09ed;
								}
							}
						}
					}
				}
			}
		}
		goto IL_0965;
		IL_09ed:
		gameObject2.SetActive(active);
		return;
		IL_09b4:
		gameObject.SetActive(flag10);
		bool flag23 = (object)pointsStar == null;
		text5 = null;
		text3 = (string)flag10;
		if (!flag23)
		{
			pointsStar.SetActive(value: true);
			gameObject2 = massCup;
			bool flag24 = (object)massCup == null;
			text5 = null;
			text3 = (string)1;
			if (!flag24)
			{
				active = false;
				goto IL_09ed;
			}
		}
		goto IL_0965;
		IL_0965:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0973;
		IL_0981:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0973:
		ex = new IndexOutOfRangeException();
		goto IL_0981;
		IL_03c3:
		object obj24 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj25 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array3 = default(object[]);
		bool flag25 = array3 == null;
		text5 = (string)stageId;
		text3 = (string)(&num2);
		if (!flag25)
		{
			object obj26 = default(object);
			bool flag26 = obj26 == null;
			string text9 = (string)(&num2);
			if (!flag26)
			{
				nint num7 = (nint)array3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
				text9 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag27 = ex == null;
				text5 = (string)stageId;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
				text3 = (string)0;
				if (flag27)
				{
					goto IL_0981;
				}
			}
			bool flag28 = array3.Length == 0;
			text5 = (string)stageId;
			text3 = text9;
			if (flag28)
			{
				goto IL_0973;
			}
			object obj27 = array3 + 32;
			obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object text10 = "SetRoomVariables request error" + 2552;
			TextMeshProExtensions.Localize(stagePointsTitle, (string)text10, array3);
			TextMeshProUGUI textMeshProUGUI3 = pointsTxt;
			string text11 = num.ToString();
			bool flag29 = (object)pointsTxt == null;
			massEventStageType = MassEventStageType.ConstantPlayersFilter;
			text5 = (string)(object)array3;
			text3 = null;
			if (!flag29)
			{
				nint num8 = (nint)textMeshProUGUI3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v18 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
				text5 = (string)0;
				pointsTxt.text = text11;
				gameObject = eligibilityInfoButton;
				bool flag30 = (object)eligibilityInfoButton == null;
				massEventStageType = MassEventStageType.ConstantPlayersFilter;
				text3 = text11;
				if (!flag30)
				{
					massEventStageType = MassEventStageType.ConstantPlayersFilter;
					flag10 = false;
					goto IL_09b4;
				}
			}
		}
		goto IL_0965;
	}

	private void TurnOnPointsIcon(bool isPointsIcon)
	{
		pointsStar.SetActive(isPointsIcon);
		bool active = (byte)((isPointsIcon ? 1u : 0u) ^ 1u) != 0;
		massCup.SetActive(active);
	}
}
