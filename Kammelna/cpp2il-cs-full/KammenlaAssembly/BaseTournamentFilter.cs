using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;

public class BaseTournamentFilter : ITournamentFilter
{
	private sealed class <>c__DisplayClass4_0
	{
		public BaseTournamentFilter <>4__this;

		public int myId;

		internal bool <ApplyFilter>b__0(TournamentModel tournament)
		{
			//IL_0080: Expected I4, but got O
			BaseTournamentFilter baseTournamentFilter = <>4__this;
			if (<>4__this != null && tournament != null)
			{
				TournamentData <Info>k__BackingField = tournament.<Info>k__BackingField;
				if (tournament.<Info>k__BackingField != null)
				{
					return Enumerable.Contains((IEnumerable<System.Int32Enum>)(object)baseTournamentFilter.<Types>k__BackingField, (System.Int32Enum)<Info>k__BackingField.<Type>k__BackingField);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ApplyFilter>b__1(TournamentModel tournament)
		{
			//IL_00c2: Expected I4, but got O
			if (tournament != null)
			{
				TournamentData <Info>k__BackingField = tournament.<Info>k__BackingField;
				if (tournament.<Info>k__BackingField != null)
				{
					if (!<Info>k__BackingField.<IsHidden>k__BackingField)
					{
						return true;
					}
					if (<>4__this != null)
					{
						return <>4__this.CanSeeEvenIfHidden(tournament, myId);
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private readonly TournamentType[] <Types>k__BackingField;

	public TournamentType[] Types => <Types>k__BackingField;

	public BaseTournamentFilter(TournamentType[] types)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = types;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public virtual IEnumerable<TournamentModel> ApplyFilter(IEnumerable<TournamentModel> tournaments)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0080: Expected O, but got I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I
		//IL_00f0: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_0108: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_0158: Expected I, but got O
		//IL_018b: Expected I, but got O
		//IL_01bc: Expected I, but got O
		//IL_01f2: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass4_0 <>c__DisplayClass4_ = default(<>c__DisplayClass4_0);
		<>c__DisplayClass4_..ctor();
		if (<>c__DisplayClass4_ != null)
		{
			object obj2 = typeof(Queue<string>) + 848;
			object obj3 = (nint)0 + (nint)2200;
			object obj4 = <>c__DisplayClass4_ + 16;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3920;
				object obj8 = (nint)0 + (nint)2936;
				object obj9 = (nint)0 + (nint)3808;
				object obj10 = (nint)0 + (nint)2928;
				object obj11 = (nint)0 + (nint)1088;
				object obj12 = (nint)0 + (nint)1096;
				User localUser = sessionModel.LocalUser;
				int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
				<>c__DisplayClass4_.myId = intDbId;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor((object)this, (IntPtr)obj8);
				IEnumerable<object> source = Enumerable.Where(tournaments, func);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func2 = default(Func<object, bool>);
				func2..ctor((object)this, (IntPtr)obj10);
				IEnumerable<object> source2 = Enumerable.Where(source, func2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func3 = default(Func<object, bool>);
				func3..ctor((object)<>c__DisplayClass4_, (IntPtr)obj11);
				IEnumerable<object> source3 = Enumerable.Where(source2, func3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func4 = default(Func<object, bool>);
				func4..ctor((object)<>c__DisplayClass4_, (IntPtr)obj12);
				return (IEnumerable<TournamentModel>)Enumerable.Where(source3, func4);
			}
		}
		return (IEnumerable<TournamentModel>)new NullReferenceException();
	}

	public virtual List<TournamentListGroup> CreateGrouping(List<TournamentModel> tournaments)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 4008;
		object obj2 = (nint)0 + (nint)1416;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentListGroup tournamentListGroup = default(TournamentListGroup);
		tournamentListGroup..ctor(tournaments);
		if (list != null)
		{
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			if (list._items != null)
			{
				bool flag = list._size < items.Length;
				object obj4 = !flag;
				if (obj4 == null)
				{
					int size = list._size + 1;
					list._size = size;
					object obj5 = list._items + list._size;
					object obj6 = obj5 + 32;
					obj6 = tournamentListGroup;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return (List<TournamentListGroup>)(object)list;
				}
				list.AddWithResize((object)tournamentListGroup);
				return (List<TournamentListGroup>)(object)list;
			}
		}
		return (List<TournamentListGroup>)(object)new NullReferenceException();
	}

	private bool CanSeeEvenIfHidden(TournamentModel model, int myId)
	{
		//IL_0456: Expected I4, but got O
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0118: Expected O, but got I4
		//IL_0121: Expected I8, but got I4
		//IL_012a: Expected I8, but got I4
		//IL_0084: Expected I8, but got I4
		//IL_00b0: Expected I8, but got I4
		//IL_016e: Expected O, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c7: Expected I, but got O
		//IL_01d7: Expected O, but got I
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected O, but got Unknown
		//IL_0212: Expected O, but got I
		//IL_02f1: Expected O, but got I4
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_03cf: Expected O, but got I4
		//IL_0369: Expected O, but got I
		//IL_0371: Expected I4, but got O
		//IL_03f8: Expected O, but got I
		long userId;
		if (model != null)
		{
			TournamentData <Info>k__BackingField = model.<Info>k__BackingField;
			if (model.<Info>k__BackingField != null)
			{
				object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
				PlayerInfo <Creator>k__BackingField = <Info>k__BackingField.<Creator>k__BackingField;
				long userId2;
				if (<Info>k__BackingField.<Creator>k__BackingField != null)
				{
					userId = <Creator>k__BackingField.<DBID>k__BackingField;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v29+E4]");
					bool flag = (nint)0 == 0;
					userId2 = <Creator>k__BackingField.<DBID>k__BackingField;
					if (!flag)
					{
						goto IL_00be;
					}
				}
				else
				{
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v29+E4]");
					bool flag2 = (nint)0 == 0;
					object obj3 = !flag2;
					userId = 0L;
					userId2 = 0L;
					if (obj3 != null)
					{
						goto IL_00be;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = FriendsManager.IsFriend(userId2);
				bool flag4 = !flag3;
				object obj4 = !flag4;
				if (obj4 != null)
				{
					goto IL_00e8;
				}
				goto IL_017c;
			}
		}
		goto IL_0448;
		IL_0253:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		int num = 0;
		goto IL_0497;
		IL_0497:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v275 @ X0_v5] (should have been resolved before IL gen)");
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v14+E4]");
		int roomId = default(int);
		if ((nint)0 != 0)
		{
			if (SfsTournamentConnector.IsParticipating(roomId))
			{
				goto IL_02b5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = SfsTournamentConnector.IsParticipating(roomId);
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 != null)
			{
				goto IL_02b5;
			}
		}
		TournamentData <Info>k__BackingField2 = model.<Info>k__BackingField;
		if (model.<Info>k__BackingField != null)
		{
			int? <Creator>k__BackingField2 = (int?)<Info>k__BackingField2.<Creator>k__BackingField;
			if (<Info>k__BackingField2.<Creator>k__BackingField != null)
			{
				object obj8 = (nint)0 + (nint)3136;
				num = (int)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v17 (System.Nullable`1<System.Int32>)+10]");
				int? num2 = 0;
			}
			object obj9 = typeof(List<Tween>) + 2432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			int num3 = default(int);
			object obj10 = default(object);
			if (num3.Equals(obj10))
			{
				return true;
			}
			object obj11 = typeof(Queue<string>) + 848;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v14+E4]");
			bool flag7 = (nint)0 == 0;
			object obj13 = !flag7;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj14 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				return SFSKammelnaUserExtensions.Can(localUser, UserPermission.AccessHiddenTournaments);
			}
		}
		goto IL_0448;
		IL_00e8:
		return true;
		IL_0448:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_02b5:
		return true;
		IL_00be:
		if (FriendsManager.IsFriend(userId))
		{
			goto IL_00e8;
		}
		goto IL_017c;
		IL_017c:
		Room <Room>k__BackingField = model.<Room>k__BackingField;
		if (model.<Room>k__BackingField == null)
		{
			goto IL_0448;
		}
		object obj15 = typeof(RegisteredWaitHandle) + 1376;
		nint num4 = (nint)<Room>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0253;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj17 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X10_v6-8]");
			if (0 == (nint)obj15)
			{
				break;
			}
			obj17 += 16;
			obj16--;
			if ((nint)obj16 != 1)
			{
				continue;
			}
			goto IL_0253;
		}
		object obj18 = num4 + obj17;
		object obj19 = obj18 + 312;
		goto IL_0497;
	}

	private bool IsNotFinished(TournamentModel model)
	{
		//IL_00bc: Expected I4, but got O
		if (model != null)
		{
			TournamentData <Info>k__BackingField = model.<Info>k__BackingField;
			if (model.<Info>k__BackingField != null)
			{
				if (<Info>k__BackingField.<Type>k__BackingField == TournamentType.OfficialMonthly)
				{
					return true;
				}
				TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(model.<Room>k__BackingField);
				bool flag = TournamentStatusExtensions.IsFinished(tournamentStatus);
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool IsNotJoined(TournamentModel model)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_03af: Expected I4, but got O
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_0196: Expected I, but got O
		//IL_01a6: Expected O, but got I
		//IL_0250: Expected O, but got I4
		//IL_0255: Expected I, but got O
		//IL_01e1: Expected O, but got I
		//IL_02e1: Expected I, but got O
		//IL_02f1: Expected O, but got I
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_037c: Expected I, but got O
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_032c: Expected O, but got I
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A83]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v17+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v17+E4]");
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
		if ((object)sessionModel != null)
		{
			goto IL_0150;
		}
		goto IL_03a1;
		IL_03f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v317 @ X0_v6] (should have been resolved before IL gen)");
		object obj9 = default(object);
		object obj10 = default(object);
		object obj8 = obj9 - obj10;
		bool flag3 = obj8 == null;
		return !flag3;
		IL_036d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		nint num = unchecked((nint)null);
		goto IL_03f7;
		IL_03a1:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj11 = !flag4;
		if (obj11 != null)
		{
			goto IL_0150;
		}
		goto IL_03a1;
		IL_0150:
		Room currentRoom = sessionModel.CurrentRoom;
		object obj12;
		if (currentRoom != null)
		{
			obj12 = typeof(RegisteredWaitHandle) + 1376;
			nint num2 = (nint)currentRoom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0222;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj14 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X10_v12-8]");
				if (0 == (nint)obj12)
				{
					break;
				}
				obj14 += 16;
				obj13--;
				if ((nint)obj13 != 1)
				{
					continue;
				}
				goto IL_0222;
			}
			object obj15 = num2 + obj14;
			object obj16 = obj15 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ X8_v12] (should have been resolved before IL gen)");
			if (model != null)
			{
				goto IL_02aa;
			}
		}
		goto IL_03a1;
		IL_0222:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v232 @ X0_v13] (should have been resolved before IL gen)");
		bool flag5 = model == null;
		object obj17 = !flag5;
		num = unchecked((nint)null);
		if (obj17 != null)
		{
			goto IL_02aa;
		}
		goto IL_03a1;
		IL_02aa:
		Room <Room>k__BackingField = model.<Room>k__BackingField;
		if (model.<Room>k__BackingField == null)
		{
			goto IL_03a1;
		}
		nint num3 = (nint)<Room>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_036d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj19 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X10_v7-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj19 += 16;
			obj18--;
			if ((nint)obj18 != 1)
			{
				continue;
			}
			goto IL_036d;
		}
		object obj20 = num3 + obj19;
		object obj21 = obj20 + 312;
		goto IL_03f7;
	}
}
