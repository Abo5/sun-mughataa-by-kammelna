using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Spine;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentsWinnerPopup : MonoBehaviour
{
	private class Winner
	{
		public int Place;

		public List<PlayerInfo> Players;
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<MatchData, bool> <>9__14_0;

		public static Func<PlayerInfo, bool> <>9__14_1;

		public static Func<PlayerInfo, bool> <>9__14_2;

		public static Func<PlayerInfo, bool> <>9__14_3;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 4056;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <ComputeWinners>b__14_0(MatchData m)
		{
			//IL_003d: Expected I4, but got O
			if (m != null)
			{
				return m.HasPlayers();
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ComputeWinners>b__14_1(PlayerInfo p)
		{
			//IL_003d: Expected I4, but got O
			if (p != null)
			{
				return p.IsHuman;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ComputeWinners>b__14_2(PlayerInfo p)
		{
			//IL_003d: Expected I4, but got O
			if (p != null)
			{
				return p.IsHuman;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ComputeWinners>b__14_3(PlayerInfo p)
		{
			//IL_003d: Expected I4, but got O
			if (p != null)
			{
				return p.IsHuman;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private PopupUI popup;

	private RectTransform panelsContainer;

	private GameObject winningPanelPrefab;

	private AvatarInitializer avatarPrefab;

	private TournamentPrizeInitializer prizeInitializerPrefab;

	private Image tournamentTypeLogo;

	private TournamentTypeIcons icons;

	private TournamentViewConnector Connector
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			return (TournamentViewConnector)0;
		}
	}

	private Room TournamentRoom
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00dc: Expected O, but got I
			//IL_0106: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_014f: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EE7]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_015d;
			IL_00b8:
			return sessionModel.CurrentRoom;
			IL_015d:
			return (Room)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_015d;
		}
	}

	private void Start()
	{
		//IL_0016: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_017a: Expected O, but got I
		//IL_0192: Expected I, but got O
		//IL_014d: Expected O, but got I
		//IL_01ac: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EA1]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45BD]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45BD]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		goto IL_015a;
		IL_015a:
		object obj10 = typeof(SqlSingle[]) + 2376;
		object obj11 = (nint)0 + (nint)1720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3+20]");
		((OneShotEvent)0).CallWhenReady(action);
		return;
		IL_0082:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v12+B8]");
		object obj13 = 0;
		obj9 = obj13;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_015a;
	}

	private void Init()
	{
		//IL_0176: Expected O, but got I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01a0: Expected O, but got I
		//IL_00db: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0075: Expected O, but got I
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00ae: Expected I, but got O
		//IL_014e: Expected O, but got I4
		GameObject go = base.gameObject;
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EE7]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0046;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0046;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0055;
		IL_0046:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0055;
		IL_0055:
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)1728;
		object varName = "startPosition" + 104;
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj10);
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
	}

	private void OnStatusChanged()
	{
		//IL_0ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Expected O, but got Unknown
		//IL_0d02: Expected O, but got I
		//IL_0099: Expected O, but got I
		//IL_00a1: Expected I, but got O
		//IL_00c3: Expected O, but got I4
		//IL_006a: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_0019: Expected I, but got O
		//IL_0082: Expected O, but got I4
		//IL_0113: Expected O, but got I4
		//IL_017c: Expected O, but got I4
		//IL_01a0: Expected O, but got I
		//IL_023e: Expected I, but got O
		//IL_0260: Expected O, but got I4
		//IL_0c68: Expected O, but got I
		//IL_0c70: Expected I, but got O
		//IL_020e: Expected O, but got I4
		//IL_01c5: Expected I, but got O
		//IL_0226: Expected O, but got I4
		//IL_022b: Expected I, but got O
		//IL_02a0: Expected O, but got I4
		//IL_02a5: Expected I, but got O
		//IL_0306: Expected O, but got I
		//IL_030e: Expected I4, but got O
		//IL_031e: Expected O, but got I
		//IL_0a09: Expected O, but got I
		//IL_0a19: Expected O, but got I
		//IL_0a2f: Expected O, but got I
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3d: Expected O, but got Unknown
		//IL_0a57: Expected O, but got I4
		//IL_0a6f: Expected O, but got I
		//IL_0353: Expected O, but got I
		//IL_0369: Expected O, but got I
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_039e: Expected O, but got I
		//IL_0ae1: Expected O, but got I
		//IL_0af1: Expected O, but got I
		//IL_0b07: Expected O, but got I
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Expected O, but got Unknown
		//IL_0ab1: Expected O, but got I4
		//IL_03f1: Expected O, but got I
		//IL_0401: Expected O, but got I
		//IL_0417: Expected O, but got I
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_043f: Expected O, but got I4
		//IL_044f: Expected O, but got I
		//IL_048c: Expected O, but got I
		//IL_04b6: Expected O, but got I4
		//IL_04d1: Expected I, but got O
		//IL_04d9: Expected O, but got I4
		//IL_0b4a: Expected O, but got I
		//IL_051a: Expected O, but got I4
		//IL_0538: Expected O, but got I4
		//IL_0582: Expected O, but got I4
		//IL_0593: Expected I, but got O
		//IL_059b: Expected O, but got I4
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected O, but got Unknown
		//IL_05d7: Expected O, but got I
		//IL_05e3: Expected O, but got I
		//IL_0d5d: Expected O, but got I
		//IL_098f: Expected O, but got I
		//IL_0997: Expected I, but got O
		//IL_09ba: Expected O, but got I4
		//IL_061b: Expected O, but got I4
		//IL_0644: Expected O, but got I
		//IL_0b98: Expected I, but got O
		//IL_0c16: Expected O, but got I4
		//IL_067f: Expected O, but got I
		//IL_0687: Expected I, but got O
		//IL_06e9: Expected O, but got I
		//IL_0711: Expected I, but got O
		//IL_08a0: Expected O, but got I4
		//IL_08c9: Expected O, but got I
		//IL_0747: Expected I4, but got O
		//IL_0bf6: Expected I, but got O
		//IL_0787: Expected O, but got I4
		//IL_0bd7: Expected I, but got O
		//IL_0b77: Expected I, but got O
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected O, but got Unknown
		//IL_0810: Expected O, but got I
		//IL_0832: Expected O, but got I4
		//IL_085a: Expected I, but got O
		Image image = (Image)(typeof(Queue<string>) + 848);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EE7]");
		object obj = (nint)0 & (nint)1;
		TournamentsWinnerPopup tournamentsWinnerPopup;
		TournamentsWinnerPopup tournamentsWinnerPopup2;
		if (obj != null)
		{
			tournamentsWinnerPopup = (TournamentsWinnerPopup)((nint)0 + (nint)2200);
			nint num = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v108 (Il2CppClass<UnityEngine.UI.Image>)+E4]");
			bool flag = (nint)0 == 0;
			tournamentsWinnerPopup2 = tournamentsWinnerPopup;
			if (!flag)
			{
				goto IL_0046;
			}
		}
		else
		{
			_ = 1;
			tournamentsWinnerPopup = (TournamentsWinnerPopup)((nint)0 + (nint)2200);
			nint num = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v108 (Il2CppClass<UnityEngine.UI.Image>)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj2 = !flag2;
			tournamentsWinnerPopup2 = tournamentsWinnerPopup;
			if (obj2 != null)
			{
				goto IL_0046;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		tournamentsWinnerPopup = tournamentsWinnerPopup2;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		if (!flag3)
		{
			goto IL_0121;
		}
		goto IL_0d1f;
		IL_0d1f:
		NullReferenceException ex = new NullReferenceException();
		nint num2 = default(nint);
		bool flag4 = num2 != 1;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj3 = (nint)0 + (nint)624;
			num2 = (nint)obj3;
			enumerator.Dispose();
			object obj4 = default(object);
			bool flag5 = obj4 == null;
			List<object>.Enumerator enumerator2 = (List<object>.Enumerator)obj4;
			if (flag5)
			{
				goto IL_09bf;
			}
			ex2 = new OutOfMemoryException();
			enumerator2 = (List<object>.Enumerator)obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2239424");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_047c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v32+B8]");
		object obj5 = 0;
		UIExtensions.DestroyAllChildren(panelsContainer, (GameObject[])obj5);
		bool flag6 = (object)icons == null;
		enumerator = (List<object>.Enumerator)0;
		PrizeLevel prizeLevel = PrizeLevel.Total;
		image = (Image)(object)panelsContainer;
		num2 = (nint)obj5;
		PrizeLevel prizeLevel2;
		tournamentsWinnerPopup2 = (TournamentsWinnerPopup)prizeLevel2;
		TournamentData tournamentData;
		TournamentData tournamentInfo;
		if (!flag6)
		{
			Sprite sprite = icons.GetSprite(tournamentData.<Type>k__BackingField);
			bool flag7 = (object)tournamentTypeLogo == null;
			enumerator = (List<object>.Enumerator)0;
			prizeLevel = PrizeLevel.Total;
			num2 = (nint)tournamentData.<Type>k__BackingField;
			tournamentsWinnerPopup2 = (TournamentsWinnerPopup)prizeLevel2;
			if (!flag7)
			{
				tournamentTypeLogo.sprite = sprite;
				List<Winner> list = ((TournamentsWinnerPopup)(object)tournamentTypeLogo).ComputeWinners();
				bool flag8 = list == null;
				enumerator = (List<object>.Enumerator)0;
				prizeLevel = PrizeLevel.Total;
				num2 = (nint)sprite;
				tournamentsWinnerPopup2 = (TournamentsWinnerPopup)prizeLevel2;
				if (!flag8)
				{
					List<object>.Enumerator enumerator3 = ((List<object>)(object)list).GetEnumerator();
					object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj7 = (nint)0 + (nint)1968;
					object obj8 = (nint)0 + (nint)872;
					prizeLevel = PrizeLevel.Total;
					List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
					Image image2 = default(Image);
					object obj14 = default(object);
					TournamentsWinnerPopup tournamentsWinnerPopup3 = default(TournamentsWinnerPopup);
					AvatarInitializer avatarInitializer = default(AvatarInitializer);
					Image image3 = default(Image);
					List<object>.Enumerator enumerator5;
					List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
					while (true)
					{
						object obj9 = (nint)0 + (nint)632;
						if (!enumerator4.MoveNext())
						{
							break;
						}
						object obj10 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X0_v43+E4]");
						bool flag9 = (nint)0 == 0;
						object obj11 = !flag9;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj12 = (nint)0 + (nint)920;
						Action action = (Action)obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
						AvatarData avatarData;
						if ((object)image2 != null)
						{
							object obj13 = (nint)0 + (nint)1560;
							num2 = (nint)obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E331E4");
							if (obj14 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ stack_-88+10]");
								LocalizableText placeText = tournamentsWinnerPopup3.GetPlaceText(0);
								TextMeshProExtensions.Localize((TextMeshProUGUI)(object)tournamentsWinnerPopup3, placeText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ stack_-88+18]");
								List<object> list2 = (List<object>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ stack_-88+18]");
								bool flag10 = (nint)0 == 0;
								prizeLevel = PrizeLevel.Total;
								num2 = (nint)placeText;
								tournamentsWinnerPopup2 = tournamentsWinnerPopup3;
								if (flag10)
								{
									goto IL_0b4f;
								}
								PrizeLevel prizeLevel3 = PrizeLevel.Total;
								tournamentsWinnerPopup2 = null;
								while ((nint)tournamentsWinnerPopup2 < list2._size)
								{
									object obj15 = list2.get_Item((int)tournamentsWinnerPopup2);
									Transform transform = ((GameObject)(object)image2).transform;
									object obj16 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v76+E4]");
									bool flag11 = (nint)0 == 0;
									object obj17 = !flag11;
									if (obj17 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									action = (Action)obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
									avatarData = (PlayerInfo)obj15;
									if ((object)avatarInitializer != null)
									{
										avatarInitializer.Initialize(avatarData);
										tournamentsWinnerPopup2 = (TournamentsWinnerPopup)(tournamentsWinnerPopup2 + 1);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ stack_-88+18]");
										list2 = (List<object>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ stack_-88+18]");
										bool flag12 = (nint)0 == 0;
										object obj18 = !flag12;
										prizeLevel3 = PrizeLevel.Total;
										if (obj18 != null)
										{
											continue;
										}
										goto IL_0849;
									}
									goto IL_0b5d;
								}
								tournamentsWinnerPopup2 = (TournamentsWinnerPopup)(object)prizeInitializerPrefab;
								Transform transform2 = ((GameObject)(object)image2).transform;
								object obj19 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v60+E4]");
								bool flag13 = (nint)0 == 0;
								object obj20 = !flag13;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj21 = (nint)0 + (nint)1064;
								action = (Action)obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
								if ((object)image3 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ stack_-88+10]");
									bool flag14 = ((TournamentPrizeInitializer)(object)image3).InitializeTrophyImage(tournamentInfo, PrizeLevel.Total, (Action)null);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ stack_-88+10]");
									bool flag15 = ((TournamentPrizeInitializer)(object)image3).InitializePrizeText(tournamentInfo, PrizeLevel.Total);
									Transform transform3 = image3.transform;
									if ((object)transform3 != null)
									{
										transform3.SetSiblingIndex(2);
										action = null;
										prizeLevel = PrizeLevel.Total;
										continue;
									}
									NullReferenceException ex3 = new NullReferenceException();
									action = null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ stack_-88+10]");
									prizeLevel = PrizeLevel.Total;
									num2 = unchecked((nint)null);
								}
								else
								{
									NullReferenceException ex4 = new NullReferenceException();
									prizeLevel = PrizeLevel.Total;
									num2 = (nint)transform2;
								}
							}
							else
							{
								NullReferenceException ex5 = new NullReferenceException();
								prizeLevel = PrizeLevel.Total;
							}
						}
						else
						{
							NullReferenceException ex6 = new NullReferenceException();
							prizeLevel = PrizeLevel.Total;
							num2 = (nint)panelsContainer;
						}
						goto IL_0bfb;
						IL_0b5d:
						NullReferenceException ex7 = new NullReferenceException();
						prizeLevel = PrizeLevel.Total;
						num2 = (nint)avatarData;
						goto IL_0bfb;
						IL_0b4f:
						NullReferenceException ex8 = new NullReferenceException();
						goto IL_0bfb;
						IL_0bfb:
						enumerator = enumerator2;
						enumerator5 = enumerator2;
						enumerator2 = (List<object>.Enumerator)0;
						goto IL_0d1f;
						IL_0849:
						prizeLevel = PrizeLevel.Total;
						num2 = (nint)avatarData;
						goto IL_0b4f;
					}
					object obj22 = (nint)0 + (nint)624;
					num2 = (nint)obj22;
					enumerator4.Dispose();
					enumerator = enumerator2;
					enumerator5 = enumerator2;
					enumerator2 = (List<object>.Enumerator)0;
					goto IL_09bf;
				}
			}
		}
		goto IL_0d1f;
		IL_02bb:
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom = sessionModel2.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom);
		if (tournamentStatus != TournamentStatus.Finished)
		{
			return;
		}
		object obj23 = (nint)0 + (nint)3120;
		prizeLevel2 = (PrizeLevel)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X22_v7 (PrizeLevel)+38]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X22_v7 (PrizeLevel)+38]");
		TournamentData tournamentData2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v16+10]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v16+10]");
			object obj26 = (nint)0 + (nint)309;
			object obj27 = obj26 & 1;
			bool flag16 = obj27 == null;
			tournamentData2 = tournamentInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v16+10]");
			object obj28 = 0;
			tournamentData = tournamentInfo;
			if (!flag16)
			{
				goto IL_03b4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X22_v7 (PrizeLevel)+38]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v23+10]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v23+10]");
			object obj30 = (nint)0 + (nint)309;
			object obj31 = obj30 & 1;
			bool flag17 = obj31 == null;
			object obj32 = !flag17;
			tournamentData2 = tournamentInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v23+10]");
			object obj28 = 0;
			tournamentData = tournamentInfo;
			if (obj32 != null)
			{
				goto IL_03b4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v24+E4]");
		bool flag18 = (nint)0 == 0;
		object obj33 = !flag18;
		tournamentData2 = tournamentData;
		if (obj33 != null)
		{
			goto IL_03e1;
		}
		goto IL_0ac7;
		IL_0046:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag19 = (object)sessionModel == null;
		object obj34 = !flag19;
		if (obj34 != null)
		{
			goto IL_0121;
		}
		enumerator = (List<object>.Enumerator)0;
		goto IL_0d1f;
		IL_0121:
		Room currentRoom2 = sessionModel.CurrentRoom;
		tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom2);
		if (tournamentInfo == null)
		{
			return;
		}
		bool flag20 = !tournamentInfo.<IsCluster>k__BackingField;
		object obj35 = !flag20;
		if (obj35 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EE7]");
		object obj36 = (nint)0 & (nint)1;
		if (obj36 != null)
		{
			nint num3 = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v93 (Il2CppClass<UnityEngine.UI.Image>)+E4]");
			if ((nint)0 != 0)
			{
				goto IL_01ea;
			}
		}
		else
		{
			_ = 1;
			nint num3 = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v93 (Il2CppClass<UnityEngine.UI.Image>)+E4]");
			bool flag21 = (nint)0 == 0;
			object obj37 = !flag21;
			if (obj37 != null)
			{
				goto IL_01ea;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag22 = (object)sessionModel2 == null;
		enumerator = (List<object>.Enumerator)0;
		num2 = unchecked((nint)null);
		tournamentsWinnerPopup2 = tournamentsWinnerPopup;
		if (!flag22)
		{
			goto IL_02bb;
		}
		goto IL_0d1f;
		IL_0465:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		tournamentData = tournamentData2;
		goto IL_047c;
		IL_03b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v24+E4]");
		bool flag23 = (nint)0 == 0;
		tournamentData = tournamentData2;
		if (!flag23)
		{
			goto IL_03e1;
		}
		goto IL_0ac7;
		IL_03e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X22_v7 (PrizeLevel)+38]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v53+10]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v53+10]");
		object obj40 = (nint)0 + (nint)309;
		object obj41 = obj40 & 1;
		bool flag24 = obj41 == null;
		object obj42 = !flag24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v53+10]");
		object obj43 = 0;
		tournamentData = tournamentData2;
		if (obj42 == null)
		{
			goto IL_0465;
		}
		goto IL_047c;
		IL_09bf:
		if ((object)popup != null)
		{
			popup.PopFromCenter();
			return;
		}
		goto IL_0d1f;
		IL_0ac7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X22_v7 (PrizeLevel)+38]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v18+10]");
		obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v18+10]");
		object obj45 = (nint)0 + (nint)309;
		object obj46 = obj45 & 1;
		bool flag25 = obj46 == null;
		tournamentData2 = tournamentData;
		if (flag25)
		{
			goto IL_0465;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v18+10]");
		obj43 = 0;
		goto IL_047c;
		IL_01ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag26 = (object)sessionModel2 == null;
		object obj47 = !flag26;
		if (obj47 != null)
		{
			goto IL_02bb;
		}
		enumerator = (List<object>.Enumerator)0;
		num2 = unchecked((nint)null);
		goto IL_0d1f;
	}

	private List<Winner> ComputeWinners()
	{
		//IL_0016: Expected O, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0132: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_008e: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_00ef: Expected O, but got I4
		//IL_0254: Expected O, but got I
		//IL_030f: Expected O, but got I4
		//IL_02c2: Expected O, but got I4
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_043a: Expected O, but got I
		//IL_044a: Expected O, but got I
		//IL_045a: Expected O, but got I
		//IL_047c: Expected O, but got I4
		//IL_0509: Expected O, but got I
		//IL_03bf: Expected O, but got I
		//IL_03cf: Expected O, but got I
		//IL_03df: Expected O, but got I
		//IL_0401: Expected O, but got I4
		//IL_05ba: Expected O, but got I4
		//IL_04b4: Expected O, but got I4
		//IL_0577: Expected O, but got I4
		//IL_0dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc2: Expected O, but got Unknown
		//IL_0dd8: Expected O, but got I
		//IL_0de9: Expected I, but got O
		//IL_0e07: Expected O, but got I
		//IL_04e4: Expected O, but got I
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_0648: Expected O, but got I
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected O, but got Unknown
		//IL_06df: Expected O, but got I4
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected I4, but got Unknown
		//IL_075b: Expected O, but got I4
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected O, but got Unknown
		//IL_0e6f: Expected O, but got I4
		//IL_0e91: Expected O, but got I
		//IL_0ea2: Expected O, but got I
		//IL_0eb2: Expected O, but got I
		//IL_0ed4: Expected O, but got I4
		//IL_1063: Unknown result type (might be due to invalid IL or missing references)
		//IL_1068: Expected O, but got Unknown
		//IL_07e2: Expected O, but got I4
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef6: Expected O, but got Unknown
		//IL_0f0c: Expected O, but got I
		//IL_0f1d: Expected I, but got O
		//IL_0f3b: Expected O, but got I
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected O, but got Unknown
		//IL_0838: Expected O, but got I
		//IL_0812: Expected O, but got I
		//IL_08d3: Expected O, but got I4
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected O, but got Unknown
		//IL_09a9: Expected O, but got I4
		//IL_09fb: Expected O, but got I4
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected I4, but got Unknown
		//IL_0a77: Expected O, but got I4
		//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected O, but got Unknown
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Expected O, but got Unknown
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Expected O, but got Unknown
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected O, but got Unknown
		//IL_0b54: Expected O, but got I
		//IL_0b64: Expected O, but got I
		//IL_0b86: Expected O, but got I4
		//IL_0ba6: Expected O, but got I
		//IL_0fba: Expected O, but got I
		//IL_0acd: Expected O, but got I
		//IL_0add: Expected O, but got I
		//IL_0aff: Expected O, but got I4
		//IL_0bd6: Expected O, but got I4
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Expected O, but got Unknown
		//IL_0ff6: Expected O, but got I
		//IL_1007: Expected I, but got O
		//IL_1025: Expected O, but got I
		//IL_0b2d: Expected O, but got I
		//IL_0c06: Expected O, but got I
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected O, but got Unknown
		//IL_0d0d: Expected O, but got I4
		//IL_0d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d52: Expected O, but got Unknown
		//IL_0d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d60: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EEA]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EE7]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EE7]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = (nint)0 + (nint)2200;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v115+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj2 = obj4;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00cb;
		}
		goto IL_01bc;
		IL_0d9b:
		List<Winner> result;
		return result;
		IL_0492:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v90+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		object obj13;
		object obj14;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v69+B8]");
			obj14 = 0;
		}
		object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)608;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj14, (IntPtr)obj16);
		object obj17 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v68+B8]");
		object obj18 = (nint)0 + (nint)8;
		obj18 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Func<object, bool> func2 = func;
		object obj20;
		object obj19 = obj20;
		goto IL_04e9;
		IL_0bb4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v51+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		object obj23;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj22 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X8_v38+B8]");
			obj23 = 0;
		}
		object obj24 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)624;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj23, (IntPtr)obj25);
		object obj26 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X8_v37+B8]");
		object obj27 = (nint)0 + (nint)24;
		obj27 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PlayerInfo[] array;
		PlayerInfo[] source = array;
		Func<object, bool> predicate = func3;
		goto IL_0f90;
		IL_0082:
		obj7 = (nint)0 + (nint)2200;
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v115+E4]");
		bool flag6 = (nint)0 == 0;
		obj10 = obj7;
		obj4 = obj2;
		if (!flag6)
		{
			goto IL_00cb;
		}
		goto IL_01bc;
		IL_01bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag7 = (object)sessionModel == null;
		obj7 = obj10;
		obj2 = obj4;
		if (!flag7)
		{
			goto IL_0202;
		}
		goto IL_0da0;
		IL_00cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag8 = (object)sessionModel == null;
		object obj28 = !flag8;
		if (obj28 != null)
		{
			goto IL_0202;
		}
		goto IL_0da0;
		IL_0202:
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom);
		SessionModel sessionModel2 = default(SessionModel);
		if (tournamentInfo != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EE7]");
			object obj29 = (nint)0 & (nint)1;
			if (obj29 != null)
			{
				object obj30 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v100+E4]");
				if ((nint)0 != 0)
				{
					goto IL_029e;
				}
			}
			else
			{
				_ = 1;
				object obj30 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v100+E4]");
				bool flag9 = (nint)0 == 0;
				object obj31 = !flag9;
				if (obj31 != null)
				{
					goto IL_029e;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel2 != null)
			{
				goto IL_0353;
			}
			goto IL_0da0;
		}
		result = null;
		goto IL_0d9b;
		IL_04e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC848C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EE7]");
		object obj32 = (nint)0 & (nint)1;
		if (obj32 != null)
		{
			object obj33 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v75+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0553;
			}
		}
		else
		{
			_ = 1;
			object obj33 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v75+E4]");
			bool flag10 = (nint)0 == 0;
			object obj34 = !flag10;
			if (obj34 != null)
			{
				goto IL_0553;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		if ((object)sessionModel3 != null)
		{
			goto IL_05fe;
		}
		goto IL_0da0;
		IL_0da0:
		return (List<Winner>)(object)new NullReferenceException();
		IL_09b7:
		bool flag11 = tournamentInfo.<Type>k__BackingField != TournamentType.Private;
		List<object> list = default(List<object>);
		result = (List<Winner>)(object)list;
		if (!flag11)
		{
			goto IL_09e4;
		}
		goto IL_0d9b;
		IL_09e4:
		MatchData matchData = default(MatchData);
		object obj35 = matchData.<team1Score>k__BackingField - matchData.<team2Score>k__BackingField;
		bool flag12 = (nint)obj35 < 0;
		bool flag13 = obj35 == null;
		int num = matchData.<team1Score>k__BackingField ^ matchData.<team2Score>k__BackingField;
		int num2 = matchData.<team1Score>k__BackingField ^ obj35;
		int num3 = num & num2;
		bool flag14 = num3 < 0;
		bool flag15 = flag12 == flag14;
		object obj36 = !flag13;
		object obj37 = flag15 & obj36;
		object obj38 = ~obj37;
		int team = ((obj38 != null) ? 1 : (1 + 1));
		PlayerInfo[] teamPlayers = matchData.GetTeamPlayers(team);
		object obj39 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v51+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v51+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v32+18]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v32+18]");
			bool flag16 = (nint)0 == 0;
			object obj40 = !flag16;
			source = teamPlayers;
			if (obj40 == null)
			{
				array = teamPlayers;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v32+18]");
				Func<object, bool> func4 = (Func<object, bool>)0;
				goto IL_0bb4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj39 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v51+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v32+18]");
			Func<object, bool> func4 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v32+18]");
			bool flag17 = (nint)0 == 0;
			object obj41 = !flag17;
			array = teamPlayers;
			source = teamPlayers;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v32+18]");
			predicate = (Func<object, bool>)0;
			if (obj41 == null)
			{
				goto IL_0bb4;
			}
		}
		goto IL_0f90;
		IL_0f90:
		IEnumerable<object> source2 = Enumerable.Where(source, predicate);
		List<object> list2 = Enumerable.ToList(source2);
		object obj42 = (nint)0 + (nint)2304;
		bool flag18 = Enumerable.Any(list2);
		bool flag19 = !flag18;
		result = (List<Winner>)(object)list;
		if (flag19)
		{
			goto IL_0d9b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj43 = default(object);
		obj43..ctor();
		if (obj43 != null)
		{
			object obj44 = obj43 + 24;
			obj44 = list2;
			_ = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			if (list._items != null)
			{
				bool flag20 = list._size < items.Length;
				object obj45 = !flag20;
				if (obj45 == null)
				{
					int size = list._size + 1;
					list._size = size;
					object obj46 = list._items + list._size;
					object obj47 = obj46 + 32;
					obj47 = obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					result = (List<Winner>)(object)list;
				}
				else
				{
					list.AddWithResize(obj43);
					result = (List<Winner>)(object)list;
				}
				goto IL_0d9b;
			}
		}
		goto IL_0da0;
		IL_029e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag21 = (object)sessionModel2 == null;
		object obj48 = !flag21;
		if (obj48 != null)
		{
			goto IL_0353;
		}
		goto IL_0da0;
		IL_0353:
		obj13 = typeof(SkeletonBinary.SkeletonInput) + 4056;
		Room currentRoom2 = sessionModel2.CurrentRoom;
		List<MatchData> tournamentMatches = SFSKammelnaRoomExtensions.GetTournamentMatches(currentRoom2);
		object obj49 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v90+E4]");
		if ((nint)0 != 0)
		{
			obj19 = (nint)0 + (nint)1768;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v90+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v63+8]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v63+8]");
			bool flag22 = (nint)0 == 0;
			object obj50 = !flag22;
			if (obj50 == null)
			{
				obj20 = obj19;
				goto IL_0492;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj49 = obj13;
			obj20 = (nint)0 + (nint)1768;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v90+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v63+8]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v63+8]");
			bool flag23 = (nint)0 == 0;
			object obj51 = !flag23;
			obj19 = obj20;
			if (obj51 == null)
			{
				goto IL_0492;
			}
		}
		goto IL_04e9;
		IL_05fe:
		Room currentRoom3 = sessionModel3.CurrentRoom;
		if (matchData != null)
		{
			object obj52 = typeof(List<Tween>) + 1472;
			object obj53 = (nint)0 + (nint)1216;
			object obj54 = typeof(SkeletonBinary.SkeletonInput) + 4064;
			List<MatchData> parentMatches = SFSKammelnaRoomExtensions.GetParentMatches(currentRoom3, matchData.<ID>k__BackingField, tournamentInfo.<Size>k__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list..ctor();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj55 = default(object);
			obj55..ctor();
			if (obj55 != null)
			{
				object obj56 = matchData.<team1Score>k__BackingField - matchData.<team2Score>k__BackingField;
				bool flag24 = (nint)obj56 < 0;
				bool flag25 = obj56 == null;
				int num4 = matchData.<team1Score>k__BackingField ^ matchData.<team2Score>k__BackingField;
				int num5 = matchData.<team1Score>k__BackingField ^ obj56;
				int num6 = num4 & num5;
				bool flag26 = num6 < 0;
				bool flag27 = flag24 == flag26;
				object obj57 = !flag27;
				object obj58 = obj57 | flag25;
				object obj59 = ~obj58;
				int team2 = ((obj59 != null) ? 1 : (1 + 1));
				_ = 1;
				PlayerInfo[] teamPlayers2 = matchData.GetTeamPlayers(team2);
				object obj60 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v25+E4]");
				bool flag28 = (nint)0 == 0;
				object obj61 = !flag28;
				PlayerInfo[] source3 = teamPlayers2;
				if (obj61 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj60 = obj13;
					source3 = teamPlayers2;
				}
				object obj62 = (nint)0 + (nint)3656;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v25+B8]");
				object obj63 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v49+10]");
				Func<object, bool> predicate2 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v49+10]");
				bool flag29 = (nint)0 == 0;
				object obj64 = !flag29;
				if (obj64 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v25+E4]");
					bool flag30 = (nint)0 == 0;
					object obj65 = !flag30;
					if (obj65 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj66 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v55+B8]");
						obj63 = 0;
					}
					object obj67 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj68 = (nint)0 + (nint)616;
					Func<object, bool> func5 = default(Func<object, bool>);
					func5..ctor(obj63, (IntPtr)obj68);
					object obj69 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v54+B8]");
					object obj70 = (nint)0 + (nint)16;
					obj70 = func5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj54 = typeof(SkeletonBinary.SkeletonInput) + 4064;
					obj62 = (nint)0 + (nint)3656;
					predicate2 = func5;
				}
				IEnumerable<object> source4 = Enumerable.Where(source3, predicate2);
				List<object> list3 = Enumerable.ToList(source4);
				object obj71 = obj55 + 24;
				obj71 = list3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (list != null)
				{
					int version2 = list._version + 1;
					list._version = version2;
					object[] items2 = list._items;
					if (list._items != null)
					{
						bool flag31 = list._size < items2.Length;
						object obj72 = !flag31;
						if (obj72 == null)
						{
							int size2 = list._size + 1;
							list._size = size2;
							object obj73 = list._items + list._size;
							object obj74 = obj73 + 32;
							obj74 = obj55;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj75 = (??)tournamentInfo.<SecondPrize>k__BackingField & 1;
							if (obj75 == null)
							{
								goto IL_09b7;
							}
						}
						else
						{
							list.AddWithResize(obj55);
							object obj76 = (??)tournamentInfo.<SecondPrize>k__BackingField & 1;
							bool flag32 = obj76 == null;
							object obj77 = !flag32;
							if (obj77 == null)
							{
								goto IL_09b7;
							}
						}
						goto IL_09e4;
					}
				}
			}
		}
		goto IL_0da0;
		IL_0553:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag33 = (object)sessionModel3 == null;
		object obj78 = !flag33;
		if (obj78 != null)
		{
			goto IL_05fe;
		}
		goto IL_0da0;
	}

	private LocalizableText GetPlaceText(int place)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02fd: Expected O, but got I
		//IL_0317: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_033f: Expected O, but got I
		//IL_0369: Expected O, but got I4
		//IL_03b2: Expected O, but got I4
		//IL_059b: Expected O, but got I
		//IL_05b3: Expected O, but got I
		//IL_07d4: Expected O, but got I
		//IL_07e4: Expected O, but got I
		//IL_07fa: Expected O, but got I
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected O, but got Unknown
		//IL_0822: Expected O, but got I4
		//IL_0832: Expected O, but got I
		//IL_05e8: Expected O, but got I
		//IL_05fe: Expected O, but got I
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected O, but got Unknown
		//IL_062b: Expected O, but got I
		//IL_03d9: Expected O, but got I
		//IL_03f1: Expected O, but got I
		//IL_086c: Expected O, but got I4
		//IL_0705: Expected O, but got I
		//IL_0715: Expected O, but got I
		//IL_072b: Expected O, but got I
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected O, but got Unknown
		//IL_0753: Expected O, but got I4
		//IL_0763: Expected O, but got I
		//IL_066e: Expected O, but got I
		//IL_067e: Expected O, but got I
		//IL_0694: Expected O, but got I
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected O, but got Unknown
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected O, but got Unknown
		//IL_0426: Expected O, but got I
		//IL_043c: Expected O, but got I
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected O, but got Unknown
		//IL_0469: Expected O, but got I
		//IL_0967: Expected O, but got I4
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected O, but got Unknown
		//IL_079d: Expected O, but got I4
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Expected O, but got Unknown
		//IL_017d: Expected O, but got I
		//IL_0195: Expected O, but got I
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		//IL_056a: Expected O, but got I
		//IL_06de: Expected O, but got I
		//IL_04ac: Expected O, but got I
		//IL_04bc: Expected O, but got I
		//IL_04d2: Expected O, but got I
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected O, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected O, but got Unknown
		//IL_0509: Expected O, but got I4
		//IL_0519: Expected O, but got I
		//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Expected O, but got Unknown
		//IL_08a3: Expected O, but got I
		//IL_08b3: Expected O, but got I
		//IL_08c9: Expected O, but got I
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected O, but got Unknown
		//IL_08f1: Expected O, but got I4
		//IL_0901: Expected O, but got I
		//IL_09fb: Expected O, but got I
		//IL_01ca: Expected O, but got I
		//IL_01e0: Expected O, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_020d: Expected O, but got I
		//IL_093b: Expected O, but got I4
		//IL_0250: Expected O, but got I
		//IL_0260: Expected O, but got I
		//IL_0276: Expected O, but got I
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_02c0: Expected O, but got I
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EEB]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EE7]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EE7]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = (nint)0 + (nint)2200;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_00cc;
		}
		goto IL_037f;
		IL_0546:
		object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v46+B8]");
		object arguments = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LocalizableText localizableText = default(LocalizableText);
		object text;
		localizableText..ctor((string)text, (object[])arguments);
		return localizableText;
		IL_065e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X19_v4+38]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v21+10]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v21+10]");
		object obj15 = (nint)0 + (nint)309;
		object obj16 = "The operation is not allowed on non-connected sockets." + 3216;
		object obj17 = obj15 & 1;
		if (obj17 == null)
		{
			goto IL_052f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v21+10]");
		object obj18 = 0;
		text = obj16;
		goto IL_0546;
		IL_087a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_065e;
		IL_008b:
		obj8 = (nint)0 + (nint)2200;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v5+E4]");
		bool flag4 = (nint)0 == 0;
		obj11 = obj8;
		if (!flag4)
		{
			goto IL_00cc;
		}
		goto IL_037f;
		IL_037f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag5 = (object)sessionModel == null;
		object obj19 = !flag5;
		if (obj19 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00db;
		IL_021b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v81+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0240;
		}
		goto IL_0949;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00db;
		IL_00db:
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom);
		if (tournamentInfo != null)
		{
			if (place != 3)
			{
				if (place != 2)
				{
					if (place == 1)
					{
						object obj20 = (nint)0 + (nint)3232;
						object obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X19_v11+38]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X19_v11+38]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v53+10]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v53+10]");
							object obj24 = (nint)0 + (nint)309;
							object obj25 = obj24 & 1;
							bool flag6 = obj25 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v53+10]");
							object obj26 = 0;
							if (!flag6)
							{
								goto IL_021b;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X19_v11+38]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v57+10]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v57+10]");
							object obj28 = (nint)0 + (nint)309;
							object obj29 = obj28 & 1;
							bool flag7 = obj29 == null;
							object obj30 = !flag7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v57+10]");
							object obj26 = 0;
							if (obj30 != null)
							{
								goto IL_021b;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v81+E4]");
						bool flag8 = (nint)0 == 0;
						object obj31 = !flag8;
						if (obj31 != null)
						{
							goto IL_0240;
						}
						goto IL_0949;
					}
					object obj32 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object obj33 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj34 = "not" + 4064;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					object obj35 = "not" + 4072;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
					string paramName = default(string);
					object actualValue = default(object);
					string message = default(string);
					ex..ctor(paramName, actualValue, message);
					object obj36 = (nint)0 + (nint)1712;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					return (LocalizableText)(object)new OutOfMemoryException();
				}
				object obj37 = (nint)0 + (nint)3232;
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X19_v9+38]");
				object obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X19_v9+38]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v34+10]");
					object obj40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v34+10]");
					object obj41 = (nint)0 + (nint)309;
					object obj42 = obj41 & 1;
					bool flag9 = obj42 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v34+10]");
					object obj43 = 0;
					if (!flag9)
					{
						goto IL_0477;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X19_v9+38]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v38+10]");
					object obj40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v38+10]");
					object obj45 = (nint)0 + (nint)309;
					object obj46 = obj45 & 1;
					bool flag10 = obj46 == null;
					object obj47 = !flag10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v38+10]");
					object obj43 = 0;
					if (obj47 != null)
					{
						goto IL_0477;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v52+E4]");
				bool flag11 = (nint)0 == 0;
				object obj48 = !flag11;
				if (obj48 != null)
				{
					goto IL_049c;
				}
				goto IL_07ab;
			}
			object obj49 = (nint)0 + (nint)3232;
			object obj50 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X19_v4+38]");
			object obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X19_v4+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+10]");
				object obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+10]");
				object obj53 = (nint)0 + (nint)309;
				object obj54 = obj53 & 1;
				bool flag12 = obj54 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+10]");
				object obj55 = 0;
				if (!flag12)
				{
					goto IL_0639;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X19_v4+38]");
				object obj56 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v17+10]");
				object obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v17+10]");
				object obj57 = (nint)0 + (nint)309;
				object obj58 = obj57 & 1;
				bool flag13 = obj58 == null;
				object obj59 = !flag13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v17+10]");
				object obj55 = 0;
				if (obj59 != null)
				{
					goto IL_0639;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v35+E4]");
			bool flag14 = (nint)0 == 0;
			object obj60 = !flag14;
			if (obj60 != null)
			{
				goto IL_065e;
			}
			goto IL_087a;
		}
		return null;
		IL_0949:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0240;
		IL_07ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_049c;
		IL_0477:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v52+E4]");
		if ((nint)0 != 0)
		{
			goto IL_049c;
		}
		goto IL_07ab;
		IL_049c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X19_v9+38]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v42+10]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v42+10]");
		object obj62 = (nint)0 + (nint)309;
		obj16 = "SERVICE_DISABLED" + 2400;
		object obj63 = obj62 & 1;
		bool flag15 = obj63 == null;
		object obj64 = !flag15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v42+10]");
		obj18 = 0;
		text = obj16;
		if (obj64 == null)
		{
			goto IL_052f;
		}
		goto IL_0546;
		IL_052f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		text = obj16;
		goto IL_0546;
		IL_0240:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X19_v11+38]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v61+10]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v61+10]");
		object obj66 = (nint)0 + (nint)309;
		obj16 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 392;
		object obj67 = obj66 & 1;
		if (obj67 == null)
		{
			goto IL_052f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v61+10]");
		obj18 = 0;
		text = obj16;
		goto IL_0546;
		IL_0639:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v35+E4]");
		if ((nint)0 != 0)
		{
			goto IL_065e;
		}
		goto IL_087a;
	}
}
