using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Spine;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class StatisticsPopup : PopupUI
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<StatisticStrip> <>9__17_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <ResetStatPopup>b__17_0(StatisticStrip ss)
		{
			ss.ResetStatStrip();
		}
	}

	private sealed class <>c__DisplayClass15_0
	{
		public StatisticsPopup <>4__this;

		public StatisticStrip item;

		internal void <SetUpStatStrip>b__0()
		{
			<>4__this.fixDetails(item);
		}
	}

	private sealed class <>c__DisplayClass18_0
	{
		public StatisticStrip item;

		internal bool <fixDetails>b__0(StatisticStrip i)
		{
			//IL_010f: Expected I4, but got O
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			if ((object)i != null && (object)i.details != null)
			{
				GameObject gameObject = i.details.gameObject;
				if ((object)gameObject != null)
				{
					bool activeSelf = gameObject.activeSelf;
					if (activeSelf)
					{
						object obj = typeof(MemberAchievementClanFeedData) + 2976;
						object obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v7+E4]");
						if ((nint)0 != 0)
						{
							return i != item;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						return i != item;
					}
					return activeSelf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public ScrollRect scroll;

	public RectTransform itemsContainer;

	private Sprite subscriptionWallSprite;

	public StatisticStrip statisticStripPrefab;

	private CardGame _game;

	private CardGameEndScores _endGame;

	private CardGameStatistics _statistics;

	private List<StatisticStrip> _statisticStrip;

	private bool _isCurrentUsage;

	private int _existingStripsCount
	{
		get
		{
			List<StatisticStrip> statisticStrip = _statisticStrip;
			if (_statisticStrip != null)
			{
				return statisticStrip._size;
			}
			return 0;
		}
	}

	private static bool StatisticShownToday
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_008e: Expected O, but got I4
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			//IL_00d5: Expected O, but got I4
			//IL_00f3: Expected O, but got I
			//IL_0108: Expected O, but got I
			object obj = typeof(DataRelation) + 712;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime today = DateTime.Today;
			DateTime dateTime = default(DateTime);
			DateTime date = dateTime.Date;
			object key = "LAK" + 496;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v10+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7+10]");
			DateTime date2 = Prefs.GetDate((string)key, (DateTime)0);
			DateTime date3 = dateTime.Date;
			return date == date3;
		}
	}

	private static bool ShowSubscriptionWall
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0112: Expected O, but got I
			//IL_013c: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0185: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67E1]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
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
			goto IL_0193;
			IL_01a1:
			return StatisticShownToday;
			IL_00b8:
			User localUser = sessionModel.LocalUser;
			if (SFSKammelnaUserExtensions.IsSubscribed(localUser))
			{
				return false;
			}
			goto IL_01a1;
			IL_0193:
			NullReferenceException ex = new NullReferenceException();
			goto IL_01a1;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_0193;
		}
	}

	private static DateTime LastDateStatisticShown
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_0069: Expected O, but got I4
			//IL_0087: Expected O, but got I
			//IL_009c: Expected O, but got I
			object obj = typeof(DataRelation) + 712;
			object key = "LAK" + 496;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+10]");
			return Prefs.GetDate((string)key, (DateTime)0);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "LAK" + 496;
			Prefs.SetDate((string)key, value);
		}
	}

	public void ShowStatisticsPopup()
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0149: Expected O, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01e5: Expected O, but got I4
		//IL_01ee: Expected O, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I4
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (!ShowSubscriptionWall || _isCurrentUsage)
		{
			CardGameStatistics statistics = _statistics;
			if (ArraysExtensions.IsNullOrEmpty(statistics.<StatisticsList>k__BackingField))
			{
				return;
			}
			_isCurrentUsage = true;
			GameObject gameObject = base.gameObject;
			gameObject.SetActive(value: true);
			PopFromCenter();
			UpdateLastDateStatisticShown();
			trackEvent = TrackerLibrary.EndGameStatisticsShown();
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			string text = null;
			object obj3 = 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_0101;
			}
		}
		else
		{
			object obj4 = typeof(MemberAchievementClanFeedData) + 3448;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = "WhiteSmoke" + 1944;
			string text = (string)obj7;
			OnlyForSubscribersPopup.Show(TrackingFeature.GameStatistics, subscriptionWallSprite, (string)obj7);
			trackEvent = TrackerLibrary.OnlySubsPopupViewed(TrackingFeature.GameStatistics);
			object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj2 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			object obj3 = 0;
			trackEvent2 = trackEvent;
			if (obj9 != null)
			{
				goto IL_0101;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_0101:
		Tracker.DesignEvent(trackEvent);
	}

	public void SetUp(CardGame game, CardGameEndScores endGame)
	{
		//IL_01ca: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0155: Expected O, but got I
		//IL_017e: Expected O, but got I
		bool showSubscriptionWall = ShowSubscriptionWall;
		bool flag = !showSubscriptionWall;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = this + 152;
		obj3 = game;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 160;
		obj4 = endGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = (UnityEngine.Object)obj3;
			bool flag3 = !flag2;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(UnityEngine.Object)obj3)
			{
				return;
			}
		}
		object obj7 = obj4;
		if (obj4 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+48]");
		if ((nint)0 != 0)
		{
			object obj8 = this + 168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+48]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v6+10]");
			if (!ArraysExtensions.IsNullOrEmpty((IEnumerable<Statistic>)0))
			{
				SetStatisticsStrips();
			}
		}
	}

	private unsafe void SetStatisticsStrips()
	{
		//IL_000c: Expected O, but got I
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected O, but got Unknown
		//IL_065d: Expected O, but got I
		//IL_00c8: Expected O, but got I
		//IL_00d6: Expected O, but got I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_020b: Expected O, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_006e: Expected I, but got O
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_007f: Expected O, but got I
		//IL_0094: Expected O, but got I
		//IL_027d: Expected O, but got I
		//IL_03bd: Expected O, but got I
		//IL_03d7: Expected O, but got I4
		//IL_0309: Expected O, but got I
		//IL_0323: Expected O, but got I4
		//IL_034f: Expected O, but got I4
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_0376: Expected O, but got I4
		//IL_05dc: Expected O, but got Ref
		//IL_04ad: Expected O, but got Ref
		//IL_0620: Expected O, but got I4
		//IL_050a: Expected O, but got I4
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2784;
		object obj2 = this + 176;
		bool flag = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X20_v3-8]");
		object obj3 = 0;
		int val;
		int num;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+10]");
			List<object> list2;
			if ((nint)0 != 0)
			{
				object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj5 = (nint)0 + (nint)3896;
				Func<Statistic, object> func = default(Func<Statistic, object>);
				func..ctor((object)this, (IntPtr)obj5);
				object obj6 = (nint)0 + (nint)4056;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+10]");
				IEnumerable<object> source = Enumerable.Select((IEnumerable<Statistic>)0, func);
				List<object> list = Enumerable.ToList(source);
				list2 = list;
			}
			else
			{
				list2 = null;
			}
			obj2 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+10]");
			object obj7 = 0;
			object obj8 = 152985600;
			object obj9 = obj2;
			int val2;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v11+18]");
				val = 0;
				object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v41+E4]");
				bool flag2 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v11+18]");
				val2 = 0;
				if (!flag2)
				{
					goto IL_013c;
				}
			}
			else
			{
				object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
				object obj11 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v41+E4]");
				bool flag3 = (nint)0 == 0;
				object obj13 = !flag3;
				val = 0;
				val2 = 0;
				if (obj13 != null)
				{
					goto IL_013c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v8+18]");
			num = Math.Max(0, val2);
			if (num >= 1)
			{
				goto IL_0271;
			}
		}
		goto IL_0185;
		IL_013c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v8+18]");
		num = Math.Max(0, val);
		if (num < 1)
		{
			goto IL_0185;
		}
		goto IL_0271;
		IL_0271:
		object obj14 = (nint)0 + (nint)2680;
		int num2 = 0;
		object obj19 = default(object);
		object obj24 = default(object);
		do
		{
			int num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v8+18]");
			List<object> list3;
			object obj20;
			List<object> list4;
			if ((nint)num3 < (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X26_v4+849]");
				object obj15 = (nint)0 & (nint)1;
				bool flag4 = obj15 == null;
				object obj16 = !flag4;
				if (obj16 == null)
				{
					_ = 1;
				}
				list3 = (List<object>)obj2;
				if (obj2 != null)
				{
					object obj17 = list3._size - 1;
					object obj18 = num2 - obj17;
					bool flag5 = obj18 == null;
					obj19 = !flag5;
					if (num2 > (nint)obj17)
					{
						goto IL_047e;
					}
					obj20 = obj19;
					list4 = (List<object>)obj2;
				}
				else
				{
					bool flag6 = num2 <= 4294967295L;
					obj20 = obj19;
					list4 = (List<object>)obj2;
					if (!flag6)
					{
						goto IL_047e;
					}
				}
				goto IL_0598;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X26_v4+849]");
			object obj21 = (nint)0 & (nint)1;
			bool flag7 = obj21 == null;
			object obj22 = !flag7;
			if (obj22 == null)
			{
				_ = 1;
			}
			List<object> list5 = (List<object>)obj2;
			if (obj2 == null || num2 >= list5._size)
			{
				goto IL_02a2;
			}
			object obj23 = ((List<object>)obj2).get_Item(num2);
			GameObject gameObject = ((Component)obj23).gameObject;
			bool active = false;
			goto IL_06fc;
			IL_0598:
			object item = list4.get_Item(num2);
			CardGameStatistics statistics = _statistics;
			Statistic statistic = statistics.<StatisticsList>k__BackingField.get_Item(num2);
			SetUpStatStrip((StatisticStrip)item, (Statistic)(&obj24));
			object obj25 = ((List<object>)(object)_statisticStrip).get_Item(num2);
			gameObject = ((Component)obj25).gameObject;
			bool flag8 = (object)gameObject == null;
			object obj26 = !flag8;
			if (obj26 != null)
			{
				obj19 = obj20;
				active = true;
				goto IL_06fc;
			}
			throw new NullReferenceException();
			IL_06fc:
			gameObject.SetActive(active);
			goto IL_02a2;
			IL_047e:
			CardGameStatistics statistics2 = _statistics;
			Statistic statistic2 = statistics2.<StatisticsList>k__BackingField.get_Item(num2);
			StatisticStrip statisticStrip = CreateStatStrip((Statistic)(&obj24));
			int version = list3._version + 1;
			list3._version = version;
			object[] items = list3._items;
			bool flag9 = list3._size < items.Length;
			object obj27 = !flag9;
			if (obj27 == null)
			{
				int size = list3._size + 1;
				list3._size = size;
				object obj28 = items + list3._size;
				object obj29 = obj28 + 32;
				obj29 = statisticStrip;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				((List<object>)obj2).AddWithResize((object)statisticStrip);
			}
			list4 = (List<object>)obj2;
			obj20 = obj19;
			goto IL_0598;
			IL_02a2:
			num2++;
		}
		while (num != num2);
		goto IL_0185;
		IL_0185:
		object obj30 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v6+18]");
		if ((nint)0 >= (nint)11)
		{
			scroll.enabled = true;
		}
	}

	private unsafe StatisticStrip CreateStatStrip(Statistic stats)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I
		//IL_00df: Expected O, but got I4
		//IL_0091: Expected O, but got Ref
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)712;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		Component component = default(Component);
		if ((object)component != null)
		{
			Transform transform = component.transform;
			if ((object)transform != null)
			{
				transform.SetAsFirstSibling();
				int num = default(int);
				SetUpStatStrip((StatisticStrip)component, (Statistic)(&num));
				return (StatisticStrip)component;
			}
		}
		return (StatisticStrip)(object)new NullReferenceException();
	}

	private unsafe void SetUpStatStrip(StatisticStrip item, Statistic stats)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0071: Expected O, but got Ref
		//IL_0089: Expected O, but got Ref
		//IL_009e: Expected O, but got I
		//IL_00bf: Expected O, but got Ref
		//IL_019c: Expected O, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01cb: Expected O, but got I
		//IL_01dc: Expected I, but got O
		//IL_0108: Expected O, but got I
		//IL_01f6: Expected O, but got I
		//IL_013c: Expected O, but got I
		//IL_0152: Expected O, but got I
		//IL_0170: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = default(int);
		string statisticInfo = _statistics.GetStatisticInfo((Statistic)(&num));
		StatType statisticType = _statistics.GetStatisticType((Statistic)(&num));
		object obj5 = (nint)0 + (nint)2544;
		int num2 = default(int);
		((StatisticStrip)obj4).SetUp(_game, _endGame, (Statistic)(&num2), statisticInfo, statisticType);
		bool flag = ArraysExtensions.IsNullOrEmpty(stats.PlayersStatistic);
		object obj6 = obj4;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v7+38]");
			GameObject gameObject = ((Component)0).gameObject;
			gameObject.SetActive(value: false);
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v14+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v15+100]");
			((UnityEventBase)0).RemoveAllListeners();
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v16+48]");
			GameObject gameObject2 = ((Component)0).gameObject;
			gameObject2.SetActive(value: false);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v7+40]");
			object obj10 = 0;
			object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)1144;
			UnityAction unityAction = default(UnityAction);
			unityAction..ctor(obj2, (IntPtr)obj12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v9+100]");
			((UnityEvent)0).AddListener(unityAction);
		}
		GameObject gameObject3 = ((Component)obj4).gameObject;
		gameObject3.SetActive(value: true);
	}

	public void Close()
	{
		ShrinkToParent();
	}

	public void ResetStatPopup()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00ce: Expected O, but got I
		//IL_00de: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_0148: Expected O, but got I4
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01d6: Expected O, but got I
		//IL_01e7: Expected I, but got O
		//IL_0205: Expected O, but got I
		//IL_0178: Expected O, but got I
		if (_statisticStrip == null)
		{
			return;
		}
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1200;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v5+E4]");
		object obj4;
		Action<object> action;
		object obj6;
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)2704;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v5+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v6+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v6+8]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				obj6 = obj3;
				goto IL_0126;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = (nint)0 + (nint)2704;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v5+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v6+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_0126;
			}
		}
		goto IL_017d;
		IL_017d:
		((List<object>)(object)_statisticStrip).ForEach(action);
		return;
		IL_0126:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v12+B8]");
			obj4 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)1136;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj4, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v11+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj3 = obj6;
		action = action2;
		goto IL_017d;
	}

	private void fixDetails(StatisticStrip item)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009e: Expected O, but got I
		//IL_00aa: Expected O, but got I
		//IL_00c5: Expected I, but got O
		//IL_0157: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = _statisticStrip == null;
		Func<object, bool> func = (Func<object, bool>)(object)item;
		UnityEngine.Object obj5 = (UnityEngine.Object)(object)_statisticStrip;
		if (!flag)
		{
			object obj6 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3408;
			object obj7 = (nint)0 + (nint)1152;
			object obj8 = (nint)0 + (nint)1248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj2, (IntPtr)obj7);
			object obj9 = Enumerable.FirstOrDefault(_statisticStrip, func2);
			func = func2;
			obj5 = (UnityEngine.Object)obj9;
		}
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			if (!(obj5 != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = obj5 != null;
			bool flag3 = !flag2;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				return;
			}
		}
		((StatisticStrip)obj5).CloseDetails();
	}

	private static void UpdateLastDateStatisticShown()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0081: Expected O, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime today = DateTime.Today;
		DateTime dateTime = default(DateTime);
		DateTime date = dateTime.Date;
		object key = "LAK" + 496;
		Prefs.SetDate((string)key, date);
	}

	private unsafe StatisticStrip <SetStatisticsStrips>b__13_0(Statistic statistic)
	{
		//IL_000b: Expected O, but got Ref
		int num = default(int);
		return CreateStatStrip((Statistic)(&num));
	}
}
