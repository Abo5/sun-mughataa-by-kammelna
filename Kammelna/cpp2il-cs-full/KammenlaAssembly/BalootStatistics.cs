using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Sfs2X.Entities.Data;
using Unity.Services.Authentication.Shared;

public class BalootStatistics : CardGameStatistics
{
	public enum BalootStat
	{
		Biddings,
		BiddingsStrength,
		WonBiddings,
		LostBiddings,
		ProjectsScores,
		Kaboot,
		Cheatings,
		Catchings,
		PictureWithAce,
		TensHunter,
		ReverseKaboot,
		PreventFourHundred,
		CheatKaboot,
		UpsideDownKaboot,
		LowSunKaboot,
		KingTrioNoAdvantage,
		WinWithEnemyHundred,
		TrumpNoJackNorNine
	}

	public override void SetStatistics(ISFSObject data)
	{
		//IL_000c: Expected O, but got I
		//IL_0167: Expected O, but got I4
		//IL_001e: Expected O, but got I
		//IL_002a: Expected O, but got I
		//IL_0036: Expected O, but got I
		//IL_0092: Expected O, but got I4
		//IL_0150: Expected O, but got I4
		object obj = (nint)0 + (nint)2696;
		ISFSObject statistics = default(ISFSObject);
		base.SetStatistics(statistics);
		object obj2 = obj;
		List<Statistic> list = Enumerable.ToList(base.<StatisticsList>k__BackingField);
		object obj5;
		List<Statistic>.Enumerator enumerator2 = default(List<Statistic>.Enumerator);
		NullReferenceException ex;
		if (list != null)
		{
			object obj3 = (nint)0 + (nint)1728;
			object obj4 = (nint)0 + (nint)2544;
			obj5 = (nint)0 + (nint)1720;
			List<Statistic>.Enumerator enumerator = list.GetEnumerator();
			obj2 = obj3;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			object obj6 = 0;
			ex = new NullReferenceException();
			object obj7 = 0;
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj5 = 152993792;
			ex = new NullReferenceException();
		}
		bool flag = (nint)obj2 != 1;
		NullReferenceException ex3 = ex;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj2 = obj5;
			enumerator2.Dispose();
			object obj8 = default(object);
			if (obj8 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj7 = obj8;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223EA7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private unsafe void AddStat(Statistic statistic)
	{
		//IL_008c: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_0102: Expected O, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0189: Expected O, but got I
		//IL_019e: Expected O, but got I
		//IL_01db: Expected O, but got I4
		//IL_0248: Expected O, but got I
		//IL_0257: Expected O, but got Ref
		//IL_026a: Expected O, but got Ref
		//IL_01ff: Expected O, but got I
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0287: Expected O, but got Ref
		//IL_02aa: Expected O, but got Ref
		IEnumerable<double> teamsStatistic = statistic.TeamsStatistic;
		if (!ArraysExtensions.IsNullOrEmpty(statistic.TeamsStatistic))
		{
			return;
		}
		List<double> playersStatistic = statistic.PlayersStatistic;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<System.Double>)+18]");
		if ((nint)0 == 4)
		{
			double num = playersStatistic.get_Item(0);
			double num2 = statistic.PlayersStatistic.get_Item(2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X21_v2 (System.Collections.Generic.IEnumerable`1<System.Double>)+1C]");
			object obj = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X21_v2 (System.Collections.Generic.IEnumerable`1<System.Double>)+10]");
			object obj2 = 0;
			double item = num + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X21_v2 (System.Collections.Generic.IEnumerable`1<System.Double>)+18]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X9_v5+18]");
			bool flag = num3 < 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X21_v2 (System.Collections.Generic.IEnumerable`1<System.Double>)+18]");
				object obj4 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X21_v2 (System.Collections.Generic.IEnumerable`1<System.Double>)+18]");
				object obj5 = obj2 + 0;
			}
			else
			{
				statistic.TeamsStatistic.AddWithResize(item);
			}
			double num4 = statistic.PlayersStatistic.get_Item(1);
			double num5 = statistic.PlayersStatistic.get_Item(3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X21_v2 (System.Collections.Generic.IEnumerable`1<System.Double>)+1C]");
			object obj6 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X21_v2 (System.Collections.Generic.IEnumerable`1<System.Double>)+10]");
			object obj7 = 0;
			double item2 = num4 + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X21_v2 (System.Collections.Generic.IEnumerable`1<System.Double>)+18]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v8+18]");
			bool flag2 = num6 < 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X21_v2 (System.Collections.Generic.IEnumerable`1<System.Double>)+18]");
				object obj9 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X21_v2 (System.Collections.Generic.IEnumerable`1<System.Double>)+18]");
				object obj10 = obj7 + 0;
			}
			else
			{
				statistic.TeamsStatistic.AddWithResize(item2);
			}
			object obj11 = (nint)0 + (nint)2656;
			int num7 = default(int);
			int index = base.<StatisticsList>k__BackingField.IndexOf((Statistic)(&num7));
			object obj13 = default(object);
			object obj12 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj13, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj13, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			base.<StatisticsList>k__BackingField.set_Item(index, (Statistic)(&num7));
		}
	}

	private string StatisticsInfo(BalootStat stat)
	{
		//IL_00f6: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0024: Expected O, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I
		bool flag = stat < (BalootStat)18;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = 139821056 + 3392;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+stat @ X1 (BalootStatistics+BalootStat)*8]");
			return (string)0;
		}
		object obj3 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = "startPosition" + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj6 = (nint)0 + (nint)2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (string)(object)new OutOfMemoryException();
	}

	private StatType GetStatisticType(BalootStat stats)
	{
		//IL_001a: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0037: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00da: Expected O, but got I
		//IL_00f7: Expected I4, but got O
		bool flag = stats < (BalootStat)18;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = 119877632 + 1748;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X8_v2+stats @ X1 (BalootStatistics+BalootStat)*4]");
			return StatType.PositiveHighest;
		}
		object obj3 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = "startPosition" + 168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj6 = (nint)0 + (nint)2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (StatType)ex2;
	}

	public override StatType GetStatisticType(Statistic stat)
	{
		return GetStatisticType((BalootStat)stat.Index);
	}

	public override string GetStatisticName(Statistic stat)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		return EnumExtensions.GetFriendlyName(enumeration);
	}

	public override string GetStatisticInfo(Statistic stat)
	{
		return StatisticsInfo((BalootStat)stat.Index);
	}

	private BalootStat GetBalootStatistics(Statistic stat)
	{
		return (BalootStat)stat.Index;
	}
}
