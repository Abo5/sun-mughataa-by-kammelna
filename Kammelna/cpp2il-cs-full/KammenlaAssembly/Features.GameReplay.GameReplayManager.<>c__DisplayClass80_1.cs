using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.OfflineServer;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Networking;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

namespace Features.GameReplay;

public class GameReplayManager : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<OnlyForSubscribersReq> <>9__95_0;

		public static Comparison<GameReplay> <>9__108_1;

		public static Comparison<GameReplay> <>9__112_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <SaveGameReplayGame>b__95_0(OnlyForSubscribersReq req)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 3448;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			OnlyForSubscribersPopup.Show(TrackingFeature.GameReplay, req.featureIcon, req.featureText);
		}

		internal int <GetAllSavedGames>b__108_1(GameReplay replay, GameReplay gameReplay)
		{
			//IL_0064: Expected I4, but got O
			long num = default(long);
			if (gameReplay != null && replay != null)
			{
				return num.CompareTo(replay.<PlayTime>k__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal int <GetAllSavedGamesWeb>b__112_0(GameReplay replay, GameReplay gameReplay)
		{
			//IL_0064: Expected I4, but got O
			long num = default(long);
			if (gameReplay != null && replay != null)
			{
				return num.CompareTo(replay.<PlayTime>k__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass108_0
	{
		public string savingPath;

		public List<GameReplay> gameReplays;

		internal List<GameReplay> <GetAllSavedGames>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0156: Expected O, but got I4
			//IL_00d8: Expected O, but got I4
			//IL_00e1: Expected O, but got I4
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got Unknown
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Expected O, but got Unknown
			//IL_01fc: Expected O, but got I
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Expected O, but got Unknown
			//IL_0224: Expected O, but got I
			//IL_01b3: Expected O, but got I4
			//IL_044b: Expected O, but got I
			//IL_0465: Expected O, but got I4
			//IL_0479: Unknown result type (might be due to invalid IL or missing references)
			//IL_047e: Expected O, but got Unknown
			//IL_0486: Expected I, but got O
			//IL_0550: Expected I, but got O
			//IL_0570: Expected O, but got I
			//IL_0592: Expected O, but got I4
			//IL_06fe: Expected I4, but got O
			//IL_04cb: Expected O, but got I
			//IL_05c2: Expected O, but got I4
			//IL_02c6: Expected O, but got I4
			//IL_0793: Unknown result type (might be due to invalid IL or missing references)
			//IL_0798: Expected O, but got Unknown
			//IL_07ae: Expected O, but got I
			//IL_07b6: Expected I, but got O
			//IL_07c8: Expected I, but got O
			//IL_07d0: Expected I, but got O
			//IL_07e6: Expected O, but got I
			//IL_0738: Expected O, but got I
			//IL_0747: Unknown result type (might be due to invalid IL or missing references)
			//IL_074c: Expected O, but got Unknown
			//IL_0776: Expected O, but got I4
			//IL_05fb: Expected O, but got I4
			//IL_060c: Expected O, but got I4
			//IL_0306: Expected O, but got I
			//IL_030e: Expected I4, but got O
			//IL_0323: Expected O, but got I
			//IL_065e: Expected O, but got I4
			//IL_03c7: Expected O, but got I4
			//IL_0239: Expected O, but got I
			//IL_0249: Expected O, but got I
			//IL_0407: Unknown result type (might be due to invalid IL or missing references)
			//IL_040c: Expected O, but got Unknown
			//IL_0415: Unknown result type (might be due to invalid IL or missing references)
			//IL_041a: Expected O, but got Unknown
			//IL_0698: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81E8]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			string path;
			object fileTypeExtension;
			string path2;
			if (obj3 != null)
			{
				obj4 = ", stale={0}" + 2488;
				path = savingPath;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v61+E4]");
				bool flag = (nint)0 == 0;
				fileTypeExtension = obj4;
				path2 = savingPath;
				if (!flag)
				{
					goto IL_00a8;
				}
			}
			else
			{
				_ = 1;
				obj4 = ", stale={0}" + 2488;
				path = savingPath;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v61+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				fileTypeExtension = obj4;
				path2 = savingPath;
				if (obj6 != null)
				{
					goto IL_00a8;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			List<string> list = FileUtils.ReadFiles(path2, (string)fileTypeExtension);
			bool flag3 = list == null;
			object obj7 = 0;
			bool flag4 = false;
			List<object> list2 = (List<object>)(object)list;
			List<GameReplay> result = (List<GameReplay>)(object)list;
			if (!flag3)
			{
				goto IL_01da;
			}
			goto IL_06f1;
			IL_0622:
			throw new NullReferenceException();
			IL_06f1:
			return result;
			IL_051f:
			Comparison<object> comparison;
			((List<object>)(object)gameReplays).Sort(comparison);
			result = gameReplays;
			goto IL_06f1;
			IL_00a8:
			List<string> list3 = FileUtils.ReadFiles(path, (string)obj4);
			bool flag5 = list3 == null;
			object obj8 = !flag5;
			obj7 = 0;
			flag4 = false;
			list2 = (List<object>)(object)list3;
			if (obj8 != null)
			{
				goto IL_01da;
			}
			result = (List<GameReplay>)(object)list3;
			goto IL_06f1;
			IL_01da:
			object obj9 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			object obj10 = (nint)0 + (nint)2608;
			List<object>.Enumerator enumerator = list2.GetEnumerator();
			object obj11 = "utf-32" + 168;
			object obj12 = (nint)0 + (nint)2368;
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			object obj15 = default(object);
			string value = default(string);
			object obj32 = default(object);
			List<GameReplay> result2 = default(List<GameReplay>);
			NullReferenceException ex2;
			object obj14;
			while (true)
			{
				List<object>.Enumerator enumerator3;
				if (!enumerator2.MoveNext())
				{
					object obj13 = (nint)0 + (nint)1864;
					obj14 = obj13;
					enumerator2.Dispose();
					enumerator3 = (List<object>.Enumerator)0;
					break;
				}
				flag4 = (byte)(int)obj12 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E354B8");
				if ((nint)obj15 != 1)
				{
					continue;
				}
				object obj16 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v43+E4]");
				bool flag6 = (nint)0 == 0;
				object obj17 = !flag6;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj16 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v43+B8]");
				object obj18 = 0;
				object obj19 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v44+E4]");
				bool flag7 = (nint)0 == 0;
				object obj21 = !flag7;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj22 = (nint)0 + (nint)64;
				flag4 = (byte)(int)obj22 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v36+38]");
				object obj23 = JsonConvert.DeserializeObject<object>(value, (JsonSerializerSettings)0);
				List<object> list4 = (List<object>)(object)gameReplays;
				if (gameReplays != null)
				{
					object obj24 = obj10;
					int version = list4._version + 1;
					list4._version = version;
					object[] items = list4._items;
					if (list4._items != null)
					{
						bool flag8 = list4._size < items.Length;
						object obj25 = !flag8;
						if (obj25 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v43+20]");
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v45+C0]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v46+70]");
							flag4 = false;
							((List<object>)(object)gameReplays).AddWithResize(obj23);
						}
						else
						{
							int size = list4._size + 1;
							list4._size = size;
							object obj28 = list4._items + list4._size;
							object obj29 = obj28 + 32;
							obj29 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
						continue;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				ex2 = ex;
				enumerator3 = (List<object>.Enumerator)0;
				obj14 = obj23;
				object obj30 = obj23;
				bool flag9 = (nint)obj30 != 1;
				OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					object obj31 = (nint)0 + (nint)1864;
					obj14 = obj31;
					enumerator2.Dispose();
					bool flag10 = obj32 == null;
					enumerator3 = (List<object>.Enumerator)obj32;
					if (flag10)
					{
						break;
					}
					OutOfMemoryException ex4 = new OutOfMemoryException();
					ex3 = ex4;
					enumerator3 = (List<object>.Enumerator)obj32;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99AE8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return result2;
			}
			ex2 = (NullReferenceException)(typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 48);
			nint num = (nint)ex2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v21 (Il2CppClass<System.NullReferenceException>)+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v21 (Il2CppClass<System.NullReferenceException>)+B8]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v31 (Il2CppStaticFields<System.NullReferenceException>)+10]");
				comparison = (Comparison<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v31 (Il2CppStaticFields<System.NullReferenceException>)+10]");
				bool flag11 = (nint)0 == 0;
				nint num3 = num;
				if (!flag11)
				{
					goto IL_04f8;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				nint num3 = (nint)ex2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v24 (Il2CppClass<System.NullReferenceException>)+B8]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v26 (Il2CppStaticFields<System.NullReferenceException>)+10]");
				comparison = (Comparison<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v26 (Il2CppStaticFields<System.NullReferenceException>)+10]");
				bool flag12 = (nint)0 == 0;
				object obj33 = !flag12;
				if (obj33 != null)
				{
					goto IL_04f8;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v24 (Il2CppClass<System.NullReferenceException>)+E4]");
			bool flag13 = (nint)0 == 0;
			object obj34 = !flag13;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj35 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3328;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj36 = (nint)0 + (nint)1824;
			nint num5 = (nint)obj36;
			Comparison<object> comparison2 = default(Comparison<object>);
			comparison2..ctor(Exception.s_EDILock, (IntPtr)obj36);
			nint num6 = (nint)ex2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v23 (Il2CppClass<System.NullReferenceException>)+B8]");
			object obj37 = (nint)0 + (nint)16;
			obj37 = comparison2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag14 = gameReplays == null;
			object obj38 = !flag14;
			comparison = comparison2;
			obj7 = 0;
			obj14 = comparison2;
			if (obj38 != null)
			{
				goto IL_051f;
			}
			goto IL_0622;
			IL_04f8:
			bool flag15 = gameReplays == null;
			num5 = (flag4 ? 1 : 0);
			if (!flag15)
			{
				goto IL_051f;
			}
			goto IL_0622;
		}
	}

	private sealed class <>c__DisplayClass80_0
	{
		public Room room;

		internal bool <AddWatchersFromLobby>b__0(User user)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_017b: Expected I4, but got O
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			//IL_0096: Expected O, but got I
			//IL_009f: Expected I, but got O
			//IL_00af: Expected O, but got I
			//IL_01f4: Expected I, but got O
			//IL_00ea: Expected O, but got I
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Expected O, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected O, but got Unknown
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected O, but got Unknown
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj6;
			if (obj2 != null)
			{
				object obj3 = obj2 + 16;
				obj3 = user;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Room room = this.room;
				if (this.room != null)
				{
					object obj4 = typeof(RegisteredWaitHandle) + 1376;
					object obj5 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 56;
					obj6 = (nint)0 + (nint)1864;
					nint num = (nint)room;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_012b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj8 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X10_v5-8]");
						if (0 == (nint)obj4)
						{
							break;
						}
						obj8 += 16;
						obj7--;
						if ((nint)obj7 != 1)
						{
							continue;
						}
						goto IL_012b;
					}
					object obj9 = obj8 + 29;
					object obj10 = num + obj9;
					object obj11 = obj10 + 312;
					goto IL_01cf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_012b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_01cf;
			IL_01cf:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ X0_v9] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj6);
			IEnumerable<object> source = default(IEnumerable<object>);
			return Enumerable.All(source, func);
		}
	}

	private sealed class <>c__DisplayClass80_1
	{
		public User user;

		internal bool <AddWatchersFromLobby>b__1(User player)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_0031: Expected I, but got O
			//IL_0041: Expected O, but got I
			//IL_00d7: Expected I, but got O
			//IL_00f5: Expected I, but got O
			//IL_00fa: Expected I, but got O
			//IL_007c: Expected O, but got I
			//IL_0110: Expected I, but got O
			//IL_0120: Expected O, but got I
			//IL_01ab: Expected I, but got O
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Expected O, but got Unknown
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected O, but got Unknown
			//IL_01db: Expected I, but got O
			//IL_01ff: Expected O, but got I4
			//IL_015b: Expected O, but got I
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0243: Expected O, but got Unknown
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected O, but got Unknown
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Expected O, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E818E]");
			nint num = 0;
			User user = this.user;
			object obj;
			nint num3;
			object obj4;
			nint num4 = default(nint);
			if (this.user != null)
			{
				obj = typeof(UsageHint) + 8;
				nint num2 = (nint)user;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v8 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v8 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00c5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v8 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v13-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj4 = obj3 + 16;
					obj2--;
					bool flag = (nint)obj2 != 1;
					obj3 = obj4;
					if (flag)
					{
						continue;
					}
					goto IL_00c5;
				}
				object obj5 = num2 + obj3;
				object obj6 = obj5 + 312;
				num = (nint)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v238 @ X0_v17] (should have been resolved before IL gen)");
				bool flag2 = player == null;
				object obj7 = !flag2;
				num3 = num4;
				obj4 = obj3;
				if (obj7 != null)
				{
					goto IL_0108;
				}
			}
			goto IL_021d;
			IL_00c5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj8 = default(object);
			num = (nint)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ X0_v14] (should have been resolved before IL gen)");
			bool flag3 = player == null;
			num3 = unchecked((nint)null);
			num4 = unchecked((nint)null);
			if (!flag3)
			{
				goto IL_0108;
			}
			goto IL_021d;
			IL_021d:
			throw new NullReferenceException();
			IL_0108:
			num = (nint)player;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_019c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			obj4 = (nint)0 + (nint)8;
			User user2 = default(User);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X10_v2-8]");
				bool flag4 = 0 == (nint)obj;
				num4 = num3;
				user = user2;
				if (flag4)
				{
					break;
				}
				obj4 += 16;
				obj9--;
				if ((nint)obj9 != 1)
				{
					continue;
				}
				goto IL_019c;
			}
			object obj10 = num + obj4;
			object obj11 = obj10 + 312;
			goto IL_02c9;
			IL_02c9:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v209 @ X0_v2] (should have been resolved before IL gen)");
			object obj13 = default(object);
			object obj12 = (object)user - obj13;
			bool flag5 = obj12 == null;
			return !flag5;
			IL_019c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = unchecked((nint)null);
			user = user2;
			goto IL_02c9;
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <GetAllSavedGames>d__108 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<List<GameReplayCardData>> <>t__builder;

		public CancellationToken cancellationToken;

		private <>c__DisplayClass108_0 <>8__1;

		private Task<List<GameReplay>> <task>5__2;

		private TaskAwaiter<List<GameReplay>> <>u__1;

		private unsafe void MoveNext()
		{
			//IL_0727: Unknown result type (might be due to invalid IL or missing references)
			//IL_072c: Expected O, but got Unknown
			//IL_037b: Expected O, but got I4
			//IL_038a: Expected I4, but got I8
			//IL_0757: Expected O, but got I
			//IL_0777: Expected O, but got Ref
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_003c: Expected O, but got Ref
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			//IL_03a9: Expected O, but got I
			//IL_007d: Expected O, but got I
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			//IL_0109: Expected O, but got I4
			//IL_054e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0553: Expected O, but got Unknown
			//IL_07ac: Expected I4, but got I8
			//IL_07c8: Expected O, but got Ref
			//IL_07d1: Expected O, but got I4
			//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e9: Expected O, but got Unknown
			//IL_0813: Expected O, but got I4
			//IL_0402: Unknown result type (might be due to invalid IL or missing references)
			//IL_0407: Expected O, but got Unknown
			//IL_041d: Expected O, but got I
			//IL_042b: Expected I, but got O
			//IL_06a5: Expected O, but got I4
			//IL_06b8: Expected O, but got I4
			//IL_043c: Expected O, but got I
			//IL_0451: Expected O, but got I
			//IL_0464: Unknown result type (might be due to invalid IL or missing references)
			//IL_0469: Expected O, but got Unknown
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected O, but got Unknown
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Expected O, but got Unknown
			//IL_05aa: Expected I4, but got I8
			//IL_05b5: Expected O, but got Ref
			//IL_05be: Expected O, but got I4
			//IL_0484: Expected O, but got I
			//IL_04a2: Expected O, but got I4
			//IL_019b: Expected O, but got I
			//IL_01ac: Expected I, but got O
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Expected O, but got Unknown
			//IL_01ea: Expected O, but got I4
			//IL_05d8: Expected O, but got Ref
			//IL_05e1: Expected O, but got I4
			//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f9: Expected O, but got Unknown
			//IL_0608: Unknown result type (might be due to invalid IL or missing references)
			//IL_060d: Expected O, but got Unknown
			//IL_0213: Expected O, but got I
			//IL_0230: Expected O, but got Ref
			//IL_063e: Expected O, but got I4
			//IL_0261: Expected O, but got I4
			//IL_0667: Expected O, but got I
			//IL_0528: Expected O, but got I4
			//IL_02c7: Expected O, but got I4
			//IL_02d8: Expected O, but got I4
			//IL_02fc: Expected O, but got Ref
			//IL_0338: Expected O, but got I4
			//IL_0361: Expected O, but got Ref
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1416;
			if (<>1__state == 0)
			{
				goto IL_0370;
			}
			object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = default(object);
			obj3..ctor();
			object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = typeof(List<AdaptivePerformanceScaler>) + 1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)2600;
			string text = (string)obj6;
			List<object> list = default(List<object>);
			list..ctor();
			TaskAwaiter<object> taskAwaiter;
			NullReferenceException ex;
			if (obj4 != null)
			{
				object obj7 = obj4 + 24;
				obj7 = list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v63+E4]");
				bool flag = (nint)0 == 0;
				object obj10 = !flag;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string savingPath = SavingPath;
				if (obj4 != null)
				{
					object obj11 = obj4 + 16;
					obj11 = savingPath;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj12 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1920;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj13 = (nint)0 + (nint)1848;
					Func<object> func = default(Func<object>);
					func..ctor(obj4, (IntPtr)obj13);
					object obj14 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v70+E4]");
					bool flag2 = (nint)0 == 0;
					object obj16 = !flag2;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj17 = (nint)0 + (nint)696;
					object obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3043CC0");
					object obj19 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 48));
					string text2 = default(string);
					obj19 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag3 = <>1__state == 0;
					object obj20 = 0;
					if (flag3)
					{
						goto IL_0370;
					}
					if (obj19 != null)
					{
						TaskAwaiter<object> awaiter = ((Task<object>)obj19).GetAwaiter();
						TaskAwaiter<object> awaiter2 = default(TaskAwaiter<object>);
						bool isCompleted = awaiter2.IsCompleted;
						bool flag4 = !isCompleted;
						object obj21 = !flag4;
						taskAwaiter = awaiter2;
						obj20 = 0;
						if (obj21 == null)
						{
							<>1__state = 0;
							object obj22 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
							obj22 = awaiter2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj23 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X0_v84+E4]");
							bool flag5 = (nint)0 == 0;
							object obj24 = !flag5;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder = (AsyncTaskMethodBuilder<object>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
							((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_074b;
					}
					ex = new NullReferenceException();
					obj20 = 0;
					text = text2;
				}
				else
				{
					ex = new NullReferenceException();
					text = savingPath;
				}
			}
			else
			{
				ex = new NullReferenceException();
			}
			goto IL_06bd;
			IL_06bd:
			NullReferenceException ex3 = default(NullReferenceException);
			object obj27 = default(object);
			object obj28 = default(object);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				NullReferenceException ex2 = ex;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
					if ((nint)text == 1)
					{
						break;
					}
					ex2 = ex3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				object obj25 = typeof(DataRelation) + 3808;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				object obj26 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F90");
				if (obj28 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B68");
				object obj29 = obj27;
				text = (string)(139026432 + 4064);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0C04");
				object obj18 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			<>1__state = -2;
			object obj30 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj31 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 48));
			obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder<object>)(obj31 - 40);
			object obj32 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1416;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v45+E4]");
			bool flag6 = (nint)0 == 0;
			object obj33 = !flag6;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj34 = (nint)0 + (nint)1560;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder2)->SetException((Exception)obj27);
			return;
			IL_0370:
			<>u__1 = (TaskAwaiter<List<GameReplay>>)0;
			<>1__state = -1;
			taskAwaiter = (TaskAwaiter<object>)<>u__1;
			goto IL_074b;
			IL_074b:
			object obj35 = (nint)0 + (nint)3280;
			text = (string)obj35;
			object result = taskAwaiter.GetResult();
			object obj36 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
			object obj37 = obj36;
			if (obj36 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v7+18]");
				IEnumerable<object> enumerable = (IEnumerable<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v7+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X21_v2 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
					object result2;
					if ((nint)0 != 0)
					{
						object obj38 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj39 = (nint)0 + (nint)2040;
						Func<object, object> func2 = default(Func<object, object>);
						func2..ctor((object)null, (IntPtr)obj39);
						object obj40 = (nint)0 + (nint)3360;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v7+18]");
						IEnumerable<object> collection = Enumerable.Select((IEnumerable<object>)0, func2);
						object obj41 = typeof(List<AdaptivePerformanceScaler>) + 1184;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj42 = (nint)0 + (nint)2640;
						object obj18 = obj42;
						List<object> list2 = default(List<object>);
						list2..ctor(collection);
						object obj20 = 0;
						result2 = list2;
					}
					else
					{
						result2 = null;
					}
					<>1__state = -2;
					<>8__1 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj43 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 48));
					obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder<object>)(obj43 - 40);
					object obj44 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v12+E4]");
					bool flag7 = (nint)0 == 0;
					object obj45 = !flag7;
					if (obj45 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder3)->SetResult(result2);
					return;
				}
				ex = new NullReferenceException();
			}
			else
			{
				ex = new NullReferenceException();
			}
			goto IL_06bd;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_006c: Expected O, but got I4
			//IL_0033: Expected O, but got Ref
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1416;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder = (AsyncTaskMethodBuilder<object>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private sealed class <GetAllSavedGamesWeb>d__112 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <GetAllSavedGamesWeb>d__112(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0d15: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0030: Expected I, but got O
			//IL_013c: Expected O, but got I
			//IL_0156: Expected O, but got I4
			//IL_0090: Expected I, but got O
			//IL_006b: Expected O, but got I
			//IL_01bc: Expected I, but got O
			//IL_01dc: Expected O, but got I
			//IL_01fd: Expected O, but got I4
			//IL_0172: Expected I, but got O
			//IL_0194: Expected O, but got I4
			//IL_00dd: Expected O, but got I
			//IL_00ff: Expected O, but got I4
			//IL_0221: Expected O, but got I
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Expected O, but got Unknown
			//IL_02bc: Expected O, but got I
			//IL_0117: Expected O, but got I4
			//IL_0bca: Expected O, but got I4
			//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e7: Expected O, but got Unknown
			//IL_02ff: Expected O, but got I
			//IL_0321: Expected O, but got I4
			//IL_027b: Expected O, but got I
			//IL_0284: Expected O, but got I4
			//IL_0d2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d32: Expected O, but got Unknown
			//IL_0ca0: Expected O, but got I
			//IL_0ca8: Expected I, but got O
			//IL_0759: Unknown result type (might be due to invalid IL or missing references)
			//IL_075e: Expected O, but got Unknown
			//IL_082f: Expected O, but got I
			//IL_083f: Expected O, but got I
			//IL_0861: Expected O, but got I4
			//IL_05c4: Expected O, but got I
			//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d3: Expected O, but got Unknown
			//IL_05df: Expected O, but got I
			//IL_07ea: Expected O, but got I4
			//IL_079b: Expected O, but got I
			//IL_07ab: Expected O, but got I
			//IL_0e57: Expected O, but got I4
			//IL_0374: Unknown result type (might be due to invalid IL or missing references)
			//IL_0379: Expected O, but got Unknown
			//IL_0385: Expected O, but got I
			//IL_0391: Expected O, but got I
			//IL_039d: Expected O, but got I
			//IL_0929: Expected O, but got I
			//IL_0945: Unknown result type (might be due to invalid IL or missing references)
			//IL_094a: Expected O, but got Unknown
			//IL_095b: Expected O, but got I4
			//IL_087f: Expected O, but got I
			//IL_08a1: Expected O, but got I4
			//IL_0709: Expected O, but got I
			//IL_0711: Expected I, but got O
			//IL_0734: Expected O, but got I4
			//IL_073d: Expected O, but got I4
			//IL_0ad9: Expected O, but got I
			//IL_0af3: Expected O, but got I4
			//IL_0ed8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0edd: Expected O, but got Unknown
			//IL_0ef3: Expected O, but got I
			//IL_0efb: Expected I, but got O
			//IL_0f0c: Expected I, but got O
			//IL_0f2a: Expected O, but got I
			//IL_0996: Expected O, but got I
			//IL_08ee: Expected O, but got I4
			//IL_08ff: Expected O, but got I4
			//IL_0907: Expected I, but got O
			//IL_08d1: Expected O, but got I
			//IL_0e0b: Expected I4, but got O
			//IL_0b31: Expected O, but got I4
			//IL_0d6d: Expected I4, but got O
			//IL_09f8: Expected O, but got I
			//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0c: Expected O, but got Unknown
			//IL_0a22: Expected O, but got I
			//IL_0a30: Expected I, but got O
			//IL_0601: Unknown result type (might be due to invalid IL or missing references)
			//IL_0606: Expected O, but got Unknown
			//IL_0630: Expected O, but got I4
			//IL_0a41: Expected O, but got I
			//IL_0a49: Expected I, but got O
			//IL_0a7a: Expected O, but got I4
			//IL_0a82: Expected I, but got O
			//IL_0e7d: Expected O, but got I
			//IL_0e8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e91: Expected O, but got Unknown
			//IL_0ebb: Expected O, but got I4
			//IL_0435: Unknown result type (might be due to invalid IL or missing references)
			//IL_043a: Expected O, but got Unknown
			//IL_0464: Expected O, but got I4
			//IL_0684: Expected O, but got I
			//IL_068c: Expected I, but got O
			//IL_06a1: Expected O, but got I
			//IL_06af: Expected O, but got I4
			//IL_0657: Unknown result type (might be due to invalid IL or missing references)
			//IL_065c: Expected O, but got Unknown
			//IL_0da7: Expected O, but got I
			//IL_0db7: Expected O, but got I
			//IL_0dc6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dcb: Expected O, but got Unknown
			//IL_0df5: Expected O, but got I4
			//IL_0aae: Expected O, but got I
			//IL_06e7: Expected O, but got I4
			//IL_06f0: Expected O, but got I4
			//IL_04b4: Expected I4, but got O
			//IL_0518: Expected I, but got O
			//IL_0520: Expected I, but got O
			//IL_048b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0490: Expected O, but got Unknown
			//IL_054e: Expected O, but got I4
			//IL_03bb: Expected O, but got I
			//IL_03cb: Expected O, but got I
			//IL_058e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0593: Expected O, but got Unknown
			//IL_059c: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a1: Expected O, but got Unknown
			bool flag = <>1__state == 0;
			object obj = !flag;
			List<object> list;
			nint num3;
			nint num2;
			if (obj == null)
			{
				<>1__state = -1;
				list = (List<object>)(typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160);
				nint num = (nint)list;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EF]");
					object obj2 = (nint)0 & (nint)1;
					if (obj2 != null)
					{
						goto IL_0088;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EF]");
					object obj3 = (nint)0 & (nint)1;
					bool flag2 = obj3 == null;
					object obj4 = !flag2;
					if (obj4 != null)
					{
						goto IL_0088;
					}
				}
				_ = 1;
				num2 = (nint)list;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v121 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+E4]");
				bool flag3 = (nint)0 == 0;
				object obj5 = !flag3;
				num3 = num2;
				if (obj5 != null)
				{
					goto IL_00bd;
				}
				goto IL_01aa;
			}
			goto IL_0ab3;
			IL_05f2:
			object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X0_v82+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
				obj7 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X0_v82+B8]");
			object obj10 = 0;
			object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X0_v83+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj14 = (nint)0 + (nint)64;
			nint num4 = (nint)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X8_v80+38]");
			string value = default(string);
			object obj15 = JsonConvert.DeserializeObject<object>(value, (JsonSerializerSettings)0);
			object obj16 = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X8_v80+38]");
			nint num5 = 0;
			goto IL_06c4;
			IL_074a:
			object obj17 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 48;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v52+E4]");
			object obj19;
			Comparison<object> comparison;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v52+B8]");
				obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v44+18]");
				comparison = (Comparison<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v44+18]");
				if ((nint)0 != 0)
				{
					goto IL_07d0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v52+B8]");
				obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v44+18]");
				comparison = (Comparison<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v44+18]");
				bool flag6 = (nint)0 == 0;
				object obj20 = !flag6;
				if (obj20 != null)
				{
					goto IL_07d0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v52+E4]");
			object[] array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v52+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj22 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v50+B8]");
				obj19 = 0;
			}
			object obj23 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3328;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj24 = (nint)0 + (nint)1832;
			num4 = (nint)obj24;
			Comparison<object> comparison2 = default(Comparison<object>);
			comparison2..ctor(obj19, (IntPtr)obj24);
			object obj25 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v49+B8]");
			object obj26 = (nint)0 + (nint)24;
			obj26 = comparison2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag8 = list == null;
			object obj27 = 0;
			comparison = comparison2;
			object obj28 = 0;
			num5 = (nint)comparison2;
			object[] array2 = array;
			if (!flag8)
			{
				goto IL_091d;
			}
			goto IL_0b5e;
			IL_09b3:
			object obj30;
			object obj29 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X0_v44+E4]");
			bool flag9 = (nint)0 == 0;
			object obj31 = obj29;
			if (!flag9)
			{
				goto IL_09e8;
			}
			goto IL_0b47;
			IL_07d0:
			bool flag10 = list == null;
			object obj32 = !flag10;
			obj27 = obj28;
			array = array2;
			if (obj32 != null)
			{
				goto IL_091d;
			}
			goto IL_0b5e;
			IL_0088:
			num3 = (nint)list;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v130 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+E4]");
			bool flag11 = (nint)0 == 0;
			num2 = num3;
			if (!flag11)
			{
				goto IL_00bd;
			}
			goto IL_01aa;
			IL_01aa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num6 = (nint)list;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v123 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+B8]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v105 (Il2CppStaticFields<System.Collections.Generic.List`1<System.Object>>)+58]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v105 (Il2CppStaticFields<System.Collections.Generic.List`1<System.Object>>)+58]");
			bool flag12 = (nint)0 == 0;
			List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
			if (!flag12)
			{
				goto IL_020b;
			}
			goto IL_0b5e;
			IL_00bd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v130 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+B8]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v112 (Il2CppStaticFields<System.Collections.Generic.List`1<System.Object>>)+58]");
			obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v112 (Il2CppStaticFields<System.Collections.Generic.List`1<System.Object>>)+58]");
			bool flag13 = (nint)0 == 0;
			object obj34 = !flag13;
			if (obj34 != null)
			{
				goto IL_020b;
			}
			enumerator = (List<object>.Enumerator)0;
			goto IL_0b5e;
			IL_020b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v55+1C]");
			object obj35 = (nint)0 + (nint)1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v55+18]");
			bool flag14 = (nint)0 < (nint)1;
			int num9 = (int)num5;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v55+10]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v55+18]");
				Array.Clear((Array)num10, 0, 0);
				obj28 = 0;
				num9 = 0;
			}
			object obj36 = typeof(List<AdaptivePerformanceScaler>) + 1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj37 = (nint)0 + (nint)2600;
			List<object> list2 = default(List<object>);
			list2..ctor();
			string savingPath = SavingPath;
			object obj38 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			object obj39 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v62+E4]");
			array2 = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v62+E4]");
			bool flag15 = (nint)0 == 0;
			object obj40 = !flag15;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object fileTypeExtension = ", stale={0}" + 2488;
			List<string> list3 = FileUtils.ReadFiles(savingPath, (string)fileTypeExtension);
			List<object>.Enumerator enumerator5;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			if (list3 != null)
			{
				List<object>.Enumerator enumerator2 = ((List<object>)(object)list3).GetEnumerator();
				List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
				if (list2 != null)
				{
					object obj41 = "utf-32" + 168;
					object obj42 = (nint)0 + (nint)2368;
					obj16 = (nint)0 + (nint)64;
					object obj43 = (nint)0 + (nint)2608;
					bool flag16 = false;
					object obj44 = default(object);
					while (true)
					{
						bool flag17 = enumerator3.MoveNext();
						bool flag18 = !flag17;
						num4 = (flag16 ? 1 : 0);
						if (flag18)
						{
							break;
						}
						flag16 = (byte)(int)obj42 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E354B8");
						if ((nint)obj44 != 1)
						{
							continue;
						}
						object obj45 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
						object obj46 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X0_v101+E4]");
						bool flag19 = (nint)0 == 0;
						object obj47 = !flag19;
						if (obj47 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj48 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
							obj46 = obj48;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X0_v101+B8]");
						object obj49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X8_v94+38]");
						JsonSerializerSettings settings = (JsonSerializerSettings)0;
						object obj50 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
						object obj51 = obj50;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X0_v102+E4]");
						bool flag20 = (nint)0 == 0;
						object obj52 = !flag20;
						if (obj52 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						flag16 = (byte)(int)obj16 != 0;
						object obj53 = JsonConvert.DeserializeObject<object>(value, settings);
						object obj54 = obj43;
						int version = list2._version + 1;
						list2._version = version;
						array2 = list2._items;
						bool flag21 = list2._items == null;
						num5 = (nint)obj53;
						num4 = (nint)obj16;
						if (!flag21)
						{
							bool flag22 = list2._size < array2.Length;
							object obj55 = !flag22;
							if (obj55 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v98+20]");
								object obj56 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X8_v100+C0]");
								object obj57 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v101+70]");
								flag16 = false;
								list2.AddWithResize(obj53);
							}
							else
							{
								int size = list2._size + 1;
								list2._size = size;
								object obj58 = list2._items + list2._size;
								object obj59 = obj58 + 32;
								obj59 = obj53;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							continue;
						}
						goto IL_06c4;
					}
				}
				else
				{
					JsonSerializerSettings settings = (JsonSerializerSettings)((nint)0 + (nint)1872);
					object obj60 = "utf-32" + 168;
					object obj61 = (nint)0 + (nint)2368;
					bool flag23 = false;
					object obj62 = default(object);
					while (true)
					{
						bool flag24 = enumerator3.MoveNext();
						bool flag25 = !flag24;
						obj16 = 1;
						num4 = (flag23 ? 1 : 0);
						if (flag25)
						{
							break;
						}
						flag23 = (byte)(int)obj61 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E354B8");
						if ((nint)obj62 != 1)
						{
							continue;
						}
						goto IL_05f2;
					}
				}
				object obj63 = (nint)0 + (nint)1864;
				num5 = (nint)obj63;
				enumerator3.Dispose();
				enumerator = enumerator4;
				enumerator5 = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				obj28 = 0;
				list = list2;
				goto IL_074a;
			}
			goto IL_0ab3;
			IL_0b47:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj29 = obj30;
			goto IL_09e8;
			IL_091d:
			object obj64 = (nint)0 + (nint)2616;
			list.Sort(comparison);
			obj30 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			object obj65 = obj30;
			object obj66 = 146685952;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X0_v34+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EF]");
				object obj67 = (nint)0 & (nint)1;
				if (obj67 != null)
				{
					goto IL_09b3;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X21_v10+5EF]");
				object obj68 = (nint)0 & (nint)1;
				bool flag26 = obj68 == null;
				object obj69 = !flag26;
				if (obj69 != null)
				{
					goto IL_09b3;
				}
			}
			_ = 1;
			obj29 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X0_v44+E4]");
			bool flag27 = (nint)0 == 0;
			object obj70 = !flag27;
			obj31 = obj29;
			if (obj70 != null)
			{
				goto IL_09e8;
			}
			goto IL_0b47;
			IL_0b5e:
			NullReferenceException ex = new NullReferenceException();
			bool flag28 = num5 != 1;
			IntPtr intPtr = num5;
			NullReferenceException ex2 = ex;
			if (!flag28)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				object obj71 = 153100288 + 1024;
				object obj73 = default(object);
				object obj72 = obj73;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F90");
				object obj74 = default(object);
				if (obj74 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					enumerator.Dispose();
					goto IL_0ab3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B68");
				object obj75 = obj73;
				num5 = 139030496;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0C04");
				num4 = 0;
				goto IL_0b6c;
			}
			goto IL_0c5b;
			IL_0c5b:
			if (intPtr == (IntPtr)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj76 = (nint)0 + (nint)1864;
				num5 = (nint)obj76;
				enumerator.Dispose();
				object obj77 = default(object);
				bool flag29 = obj77 == null;
				enumerator4 = (List<object>.Enumerator)obj77;
				if (flag29)
				{
					goto IL_074a;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				enumerator4 = (List<object>.Enumerator)obj77;
				ex2 = (NullReferenceException)(object)ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99AE8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			bool result = default(bool);
			return result;
			IL_0b6c:
			intPtr = num5;
			NullReferenceException ex4 = default(NullReferenceException);
			ex2 = ex4;
			goto IL_0c5b;
			IL_09e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X0_v44+B8]");
			object obj78 = 0;
			object obj79 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj80 = (nint)0 + (nint)2040;
			Func<object, object> func = default(Func<object, object>);
			func..ctor((object)null, (IntPtr)obj80);
			object obj81 = (nint)0 + (nint)3360;
			num4 = (nint)obj81;
			IEnumerable<object> collection = Enumerable.Select(list, func);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v31+58]");
			bool flag30 = (nint)0 == 0;
			obj28 = 0;
			num5 = (nint)func;
			array2 = array;
			if (!flag30)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v31+58]");
				((List<object>)0).AddRange(collection);
				goto IL_0ab3;
			}
			goto IL_0b5e;
			IL_06c4:
			ex4 = new NullReferenceException();
			enumerator = enumerator4;
			enumerator5 = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
			obj28 = 0;
			list = list2;
			goto IL_0b6c;
			IL_0ab3:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	protected GameEventsChannel _gameEventsChannel;

	private bool _gameInitialized;

	private bool _roundInitialized;

	private bool _isFirstRound;

	private static GameReplay <_gameReplay>k__BackingField;

	private static BalootGame <Game>k__BackingField;

	private static CardGameVisualControls _gameVisual;

	private bool _isRecording;

	private static GameReplayController <GameReplayController>k__BackingField;

	private Room <Room>k__BackingField;

	private static bool SubscribeForReplay;

	private int _catcherIndex;

	private const string JsonEx = ".json";

	private const string SavedGamesString = "savedGames";

	private static readonly JsonSerializerSettings SerializerSettings;

	private static bool <GameSaved>k__BackingField;

	private static ReplayPlayer _replayPlayer;

	private static readonly List<GameReplayCardData> <GameReplays>k__BackingField;

	private static GameReplay _gameReplay
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ca: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_0102: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8144]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			return (GameReplay)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			return (GameReplay)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static bool SaveExists
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0144: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_01ca: Expected O, but got I4
			//IL_0172: Expected O, but got I
			//IL_018c: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8146]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_019a;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+B8]");
			object obj8 = 0;
			bool flag3 = obj8 == null;
			return !flag3;
			IL_01e0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			goto IL_00e5;
			IL_00b0:
			obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = obj9;
			if (!flag4)
			{
				goto IL_00e5;
			}
			goto IL_01e0;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				goto IL_00b0;
			}
			goto IL_019a;
			IL_019a:
			_ = 1;
			obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			obj10 = obj9;
			if (obj12 != null)
			{
				goto IL_00e5;
			}
			goto IL_01e0;
		}
	}

	public static BalootGame Game
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8147]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+8]");
			return (BalootGame)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+8]");
			return (BalootGame)0;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
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
			object obj4 = (nint)0 + (nint)8;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static GameReplayController GameReplayController
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8149]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+18]");
			return (GameReplayController)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+18]");
			return (GameReplayController)0;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
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
			object obj4 = (nint)0 + (nint)24;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private Room Room
	{
		get
		{
			return <Room>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static bool IsPaused
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_017f: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_0205: Expected O, but got I4
			//IL_01ad: Expected O, but got I
			//IL_01c7: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0105: Expected O, but got I
			//IL_012c: Expected O, but got I
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected I4, but got Unknown
			//IL_023d: Expected O, but got I
			//IL_024d: Expected O, but got I
			//IL_026f: Expected O, but got I4
			//IL_014a: Expected O, but got I
			//IL_028d: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E814C]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_01d5;
			IL_013a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v13+BC]");
			object obj8 = 0;
			goto IL_0292;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v16+18]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v16+18]");
			bool flag3 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v16+18]");
			obj8 = 0;
			if (!flag3)
			{
				goto IL_013a;
			}
			goto IL_0292;
			IL_0292:
			return (byte)(obj8 & 1) != 0;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				goto IL_00b0;
			}
			goto IL_01d5;
			IL_01d5:
			_ = 1;
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			object obj14 = obj12;
			if (obj13 != null)
			{
				goto IL_00e5;
			}
			goto IL_021b;
			IL_00b0:
			obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			obj14 = obj12;
			if (!flag5)
			{
				goto IL_00e5;
			}
			goto IL_021b;
			IL_021b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+B8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4+18]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4+18]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			if (obj17 != null)
			{
				goto IL_013a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4+18]");
			obj8 = 0;
			goto IL_0292;
		}
	}

	public static bool SpeedMultiplied
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_017f: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_0205: Expected O, but got I4
			//IL_01ad: Expected O, but got I
			//IL_01c7: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0105: Expected O, but got I
			//IL_012c: Expected O, but got I
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected I4, but got Unknown
			//IL_023d: Expected O, but got I
			//IL_024d: Expected O, but got I
			//IL_026f: Expected O, but got I4
			//IL_014a: Expected O, but got I
			//IL_028d: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8151]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_01d5;
			IL_013a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v13+B4]");
			object obj8 = 0;
			goto IL_0292;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v16+18]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v16+18]");
			bool flag3 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v16+18]");
			obj8 = 0;
			if (!flag3)
			{
				goto IL_013a;
			}
			goto IL_0292;
			IL_0292:
			return (byte)(obj8 & 1) != 0;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				goto IL_00b0;
			}
			goto IL_01d5;
			IL_01d5:
			_ = 1;
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			object obj14 = obj12;
			if (obj13 != null)
			{
				goto IL_00e5;
			}
			goto IL_021b;
			IL_00b0:
			obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			obj14 = obj12;
			if (!flag5)
			{
				goto IL_00e5;
			}
			goto IL_021b;
			IL_021b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+B8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4+18]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4+18]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			if (obj17 != null)
			{
				goto IL_013a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4+18]");
			obj8 = 0;
			goto IL_0292;
		}
	}

	public static bool IsFirstRound
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0176: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_01fc: Expected O, but got I4
			//IL_01a4: Expected O, but got I
			//IL_01be: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0105: Expected O, but got I
			//IL_0282: Expected I4, but got O
			//IL_0234: Expected O, but got I
			//IL_0244: Expected O, but got I
			//IL_0266: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8155]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_01cc;
			IL_012a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v13+B8]");
			return (nint)0 == 0;
			IL_0274:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v16+18]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v16+18]");
			if ((nint)0 != 0)
			{
				goto IL_012a;
			}
			goto IL_0274;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 != null)
			{
				goto IL_00b0;
			}
			goto IL_01cc;
			IL_01cc:
			_ = 1;
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			object obj13 = obj11;
			if (obj12 != null)
			{
				goto IL_00e5;
			}
			goto IL_0212;
			IL_00b0:
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
			bool flag4 = (nint)0 == 0;
			obj13 = obj11;
			if (!flag4)
			{
				goto IL_00e5;
			}
			goto IL_0212;
			IL_0212:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v4+18]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v4+18]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 != null)
			{
				goto IL_012a;
			}
			goto IL_0274;
		}
	}

	public static bool IsLastRound
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_016a: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_01f0: Expected O, but got I4
			//IL_0198: Expected O, but got I
			//IL_01b2: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0105: Expected O, but got I
			//IL_0127: Expected O, but got I4
			//IL_0228: Expected O, but got I
			//IL_0238: Expected O, but got I
			//IL_02f4: Expected O, but got I
			//IL_02e4: Expected I4, but got O
			//IL_0272: Expected O, but got I
			//IL_02ad: Expected O, but got I
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Expected O, but got Unknown
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81E3]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v17+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v17+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_01c0;
			IL_02d6:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_02e4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X20_v3+98]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X20_v3+98]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v6+98]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v6+98]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X20_v3+B8]");
					object obj10 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v7+18]");
					object obj11 = obj10 - 0;
					return obj11 == null;
				}
			}
			goto IL_02d6;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v23+B8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v20+18]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v20+18]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				goto IL_02d6;
			}
			goto IL_02e4;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj15 = (nint)0 & (nint)1;
			if (obj15 != null)
			{
				goto IL_00b0;
			}
			goto IL_01c0;
			IL_01c0:
			_ = 1;
			object obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v23+E4]");
			bool flag4 = (nint)0 == 0;
			object obj17 = !flag4;
			object obj18 = obj16;
			if (obj17 != null)
			{
				goto IL_00e5;
			}
			goto IL_0206;
			IL_00b0:
			obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v23+E4]");
			bool flag5 = (nint)0 == 0;
			obj18 = obj16;
			if (!flag5)
			{
				goto IL_00e5;
			}
			goto IL_0206;
			IL_0206:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj19 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v11+B8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v11+18]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v11+18]");
			if ((nint)0 == 0)
			{
				goto IL_02d6;
			}
			goto IL_02e4;
		}
	}

	public static bool IsLastAkla
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0161: Expected O, but got I4
			//IL_008a: Expected O, but got I
			//IL_01e7: Expected O, but got I4
			//IL_018f: Expected O, but got I
			//IL_01a9: Expected O, but got I4
			//IL_00ec: Expected O, but got I
			//IL_00fc: Expected O, but got I
			//IL_011e: Expected O, but got I4
			//IL_021f: Expected O, but got I
			//IL_022f: Expected O, but got I
			//IL_02e1: Expected O, but got I
			//IL_02d1: Expected I4, but got O
			//IL_0294: Expected O, but got I
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a9: Expected O, but got Unknown
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81E4]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v18+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v18+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_00a7;
			}
			goto IL_01b7;
			IL_02c3:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_02d1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X19_v4+C0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X19_v4+C0]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+18]");
					object obj8 = -2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X19_v4+C8]");
					object obj9 = 0 - obj8;
					return obj9 == null;
				}
				return true;
			}
			goto IL_02c3;
			IL_00dc:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v24+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v20+18]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v20+18]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				goto IL_02c3;
			}
			goto IL_02d1;
			IL_0074:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				goto IL_00a7;
			}
			goto IL_01b7;
			IL_01b7:
			_ = 1;
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v24+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			object obj16 = obj14;
			if (obj15 != null)
			{
				goto IL_00dc;
			}
			goto IL_01fd;
			IL_00a7:
			obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v24+E4]");
			bool flag5 = (nint)0 == 0;
			obj16 = obj14;
			if (!flag5)
			{
				goto IL_00dc;
			}
			goto IL_01fd;
			IL_01fd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v12+B8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11+18]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11+18]");
			if ((nint)0 == 0)
			{
				goto IL_02c3;
			}
			goto IL_02d1;
		}
	}

	public static bool IsFirstCardPlayed
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0167: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_01ed: Expected O, but got I4
			//IL_0195: Expected O, but got I
			//IL_01af: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0105: Expected O, but got I
			//IL_0273: Expected I4, but got O
			//IL_0225: Expected O, but got I
			//IL_0235: Expected O, but got I
			//IL_0257: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8156]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_01bd;
			IL_012a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v13+110]");
			return false;
			IL_0265:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v15+18]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v15+18]");
			if ((nint)0 != 0)
			{
				goto IL_012a;
			}
			goto IL_0265;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 != null)
			{
				goto IL_00b0;
			}
			goto IL_01bd;
			IL_01bd:
			_ = 1;
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			object obj13 = obj11;
			if (obj12 != null)
			{
				goto IL_00e5;
			}
			goto IL_0203;
			IL_00b0:
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
			bool flag4 = (nint)0 == 0;
			obj13 = obj11;
			if (!flag4)
			{
				goto IL_00e5;
			}
			goto IL_0203;
			IL_0203:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4+18]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4+18]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 != null)
			{
				goto IL_012a;
			}
			goto IL_0265;
		}
	}

	public static bool IsFirstBidDone
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0167: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_01ed: Expected O, but got I4
			//IL_0195: Expected O, but got I
			//IL_01af: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0105: Expected O, but got I
			//IL_0273: Expected I4, but got O
			//IL_0225: Expected O, but got I
			//IL_0235: Expected O, but got I
			//IL_0257: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8157]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_01bd;
			IL_012a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v13+111]");
			return false;
			IL_0265:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v15+18]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v15+18]");
			if ((nint)0 != 0)
			{
				goto IL_012a;
			}
			goto IL_0265;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 != null)
			{
				goto IL_00b0;
			}
			goto IL_01bd;
			IL_01bd:
			_ = 1;
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			object obj13 = obj11;
			if (obj12 != null)
			{
				goto IL_00e5;
			}
			goto IL_0203;
			IL_00b0:
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
			bool flag4 = (nint)0 == 0;
			obj13 = obj11;
			if (!flag4)
			{
				goto IL_00e5;
			}
			goto IL_0203;
			IL_0203:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4+18]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4+18]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 != null)
			{
				goto IL_012a;
			}
			goto IL_0265;
		}
	}

	public static bool IsInBiddingState
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0184: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_020a: Expected O, but got I4
			//IL_01b2: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0105: Expected O, but got I
			//IL_0290: Expected I4, but got O
			//IL_0242: Expected O, but got I
			//IL_0252: Expected O, but got I
			//IL_0274: Expected O, but got I4
			//IL_0140: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8158]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_01da;
			IL_012a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v13+24]");
			object obj8 = -1;
			return obj8 == null;
			IL_0282:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v16+18]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v16+18]");
			if ((nint)0 != 0)
			{
				goto IL_012a;
			}
			goto IL_0282;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				goto IL_00b0;
			}
			goto IL_01da;
			IL_01da:
			_ = 1;
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			object obj14 = obj12;
			if (obj13 != null)
			{
				goto IL_00e5;
			}
			goto IL_0220;
			IL_00b0:
			obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
			bool flag4 = (nint)0 == 0;
			obj14 = obj12;
			if (!flag4)
			{
				goto IL_00e5;
			}
			goto IL_0220;
			IL_0220:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+B8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v4+18]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v4+18]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			if (obj17 != null)
			{
				goto IL_012a;
			}
			goto IL_0282;
		}
	}

	public static bool IsInPlayingState
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0184: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_020a: Expected O, but got I4
			//IL_01b2: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0105: Expected O, but got I
			//IL_0290: Expected I4, but got O
			//IL_0242: Expected O, but got I
			//IL_0252: Expected O, but got I
			//IL_0274: Expected O, but got I4
			//IL_0140: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8159]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_01da;
			IL_012a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v13+24]");
			object obj8 = -2;
			return obj8 == null;
			IL_0282:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v16+18]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v16+18]");
			if ((nint)0 != 0)
			{
				goto IL_012a;
			}
			goto IL_0282;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				goto IL_00b0;
			}
			goto IL_01da;
			IL_01da:
			_ = 1;
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			object obj14 = obj12;
			if (obj13 != null)
			{
				goto IL_00e5;
			}
			goto IL_0220;
			IL_00b0:
			obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
			bool flag4 = (nint)0 == 0;
			obj14 = obj12;
			if (!flag4)
			{
				goto IL_00e5;
			}
			goto IL_0220;
			IL_0220:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+B8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v4+18]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v4+18]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			if (obj17 != null)
			{
				goto IL_012a;
			}
			goto IL_0282;
		}
	}

	private unsafe static string SavingPath
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Expected O, but got Unknown
			//IL_0157: Expected O, but got I4
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			//IL_0070: Expected O, but got I4
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_00af: Expected O, but got Ref
			//IL_00e2: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 72;
			string cachePath = Config.CachePath;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object path = "rightCtrl" + 1024;
			Games currentGame = Preferences.CurrentGame;
			object obj8 = default(object);
			string path2 = ((Enum)(&obj8)).ToString();
			object obj9 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Path.Combine(cachePath, (string)path, path2);
		}
	}

	public static bool GameSaved
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_010a: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8175]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+40]");
			return false;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+40]");
			return false;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00c2: Expected O, but got I4
			//IL_008c: Expected O, but got I
			//IL_00fa: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8176]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+B8]");
			object obj7 = 0;
			return;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+B8]");
			object obj8 = 0;
		}
	}

	public static List<GameReplayCardData> GameReplays
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8183]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+58]");
			return (List<GameReplayCardData>)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+58]");
			return (List<GameReplayCardData>)0;
		}
	}

	public static event Action OnPause
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+20]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+20]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action OnSpeedToggled
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+28]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+28]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action OnGameSaved
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+48]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+48]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static void ResetGameVisuals()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e4: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_011c: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_014e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81E2]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+10]");
		CardGameVisualControls cardGameVisualControls = (CardGameVisualControls)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+10]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00aa;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v9+10]");
		cardGameVisualControls = (CardGameVisualControls)0;
		goto IL_00aa;
		IL_00aa:
		cardGameVisualControls.ResetGameGround();
	}

	private static T SetGameReplayController<T>(Room room) where T : IRoomExtension
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003d: Expected I, but got O
		//IL_0066: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 3240;
		object obj2 = obj;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X1_v4+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X1_v4+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v10-8]");
			if (0 == (nint)obj2)
			{
				object obj6 = (nint)0 + (nint)309;
				object obj7 = obj6 & 1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				nint num4 = 0;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					IntPtr intPtr = default(IntPtr);
					num4 = intPtr;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [room @ X0 (Sfs2X.Entities.Room)+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					T val = default(T);
					if (val != null)
					{
						return val;
					}
					return (T)new InvalidCastException();
				}
				return (T)null;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0643: Expected O, but got I
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_0543: Expected O, but got I4
		//IL_0076: Expected O, but got I
		//IL_0581: Expected O, but got I
		//IL_059b: Expected O, but got I4
		//IL_05e1: Expected O, but got I4
		//IL_00ee: Expected O, but got I
		//IL_0116: Expected O, but got I
		//IL_01ed: Expected O, but got I4
		//IL_0178: Expected O, but got I
		//IL_0188: Expected O, but got I
		//IL_01aa: Expected O, but got I4
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0225: Expected O, but got I
		//IL_0235: Expected O, but got I
		//IL_06ae: Expected O, but got I4
		//IL_0740: Expected O, but got I4
		//IL_0762: Expected O, but got I
		//IL_077e: Expected O, but got I
		//IL_0337: Expected O, but got I4
		//IL_02c2: Expected O, but got I
		//IL_02d2: Expected O, but got I
		//IL_02f4: Expected O, but got I4
		//IL_036f: Expected O, but got I
		//IL_037f: Expected O, but got I
		//IL_03d4: Expected O, but got I4
		//IL_03fd: Expected O, but got I
		//IL_0431: Expected O, but got I4
		//IL_06d2: Expected O, but got I
		//IL_06f0: Expected O, but got I
		//IL_0729: Expected O, but got I4
		//IL_07b1: Expected O, but got I
		//IL_07db: Expected O, but got I
		//IL_0483: Expected O, but got I
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_04b2: Expected O, but got I
		//IL_04c0: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)8;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		object obj6;
		object obj8;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = default(object);
			obj6 = obj7;
			obj8 = obj7;
			if (!flag)
			{
				goto IL_0060;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			object obj10 = default(object);
			obj6 = obj10;
			obj8 = obj10;
			if (obj9 != null)
			{
				goto IL_0060;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EA]");
		object obj11 = (nint)0 & (nint)1;
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		obj6 = obj8;
		if (obj12 != null)
		{
			goto IL_009b;
		}
		goto IL_05b1;
		IL_023a:
		KGame kGame;
		Room room = kGame.Room;
		object obj13 = this + 48;
		obj13 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v29+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj3;
		}
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v74+B8]");
		object obj18 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj19 = (nint)0 & (nint)1;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v74+E4]");
			bool flag5 = (nint)0 == 0;
			object obj20 = obj17;
			if (!flag5)
			{
				goto IL_02b2;
			}
		}
		else
		{
			_ = 1;
			obj17 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v74+E4]");
			bool flag6 = (nint)0 == 0;
			object obj21 = !flag6;
			object obj20 = obj17;
			if (obj21 != null)
			{
				goto IL_02b2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v69+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v39+8]");
		KGame kGame2 = (KGame)0;
		goto IL_0384;
		IL_0168:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v89+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v51+8]");
		kGame = (KGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v51+8]");
		bool flag7 = (nint)0 == 0;
		object obj25 = !flag7;
		if (obj25 != null)
		{
			goto IL_023a;
		}
		goto IL_0630;
		IL_02b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v74+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v43+8]");
		kGame2 = (KGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v43+8]");
		bool flag8 = (nint)0 == 0;
		object obj27 = !flag8;
		if (obj27 != null)
		{
			goto IL_0384;
		}
		goto IL_0630;
		IL_0060:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EA]");
		object obj28 = (nint)0 & (nint)1;
		bool flag9 = obj28 == null;
		obj8 = obj6;
		if (!flag9)
		{
			goto IL_009b;
		}
		goto IL_05b1;
		IL_05b1:
		_ = 1;
		object obj29 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v17+E4]");
		bool flag10 = (nint)0 == 0;
		object obj30 = !flag10;
		obj6 = obj8;
		object obj31 = obj29;
		if (obj30 != null)
		{
			goto IL_00d8;
		}
		goto IL_05ff;
		IL_009b:
		obj29 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v17+E4]");
		bool flag11 = (nint)0 == 0;
		obj8 = obj6;
		obj31 = obj29;
		if (!flag11)
		{
			goto IL_00d8;
		}
		goto IL_05ff;
		IL_05ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj29 = obj3;
		obj6 = obj8;
		goto IL_00d8;
		IL_00d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v17+B8]");
		object obj32 = (nint)0 + (nint)8;
		obj32 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj33 = (nint)0 & (nint)1;
		if (obj33 != null)
		{
			object obj34 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v89+E4]");
			bool flag12 = (nint)0 == 0;
			object obj35 = obj34;
			if (!flag12)
			{
				goto IL_0168;
			}
		}
		else
		{
			_ = 1;
			object obj34 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v89+E4]");
			bool flag13 = (nint)0 == 0;
			object obj36 = !flag13;
			object obj35 = obj34;
			if (obj36 != null)
			{
				goto IL_0168;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj37 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v83+B8]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v47+8]");
		kGame = (KGame)0;
		goto IL_023a;
		IL_0630:
		throw new NullReferenceException();
		IL_0384:
		if (kGame2.IsReplay)
		{
			object obj39 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v38+E4]");
			bool flag14 = (nint)0 == 0;
			object obj40 = !flag14;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj41 = (nint)0 + (nint)32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			object obj42 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v43+E4]");
			bool flag15 = (nint)0 == 0;
			object obj43 = !flag15;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj42 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v43+B8]");
			object obj44 = (nint)0 + (nint)16;
			object obj45 = default(object);
			obj44 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj46 = (nint)0 + (nint)2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E352B8");
			object obj47 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v51+E4]");
			bool flag16 = (nint)0 == 0;
			object obj48 = !flag16;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj47 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v51+B8]");
			object obj49 = (nint)0 + (nint)24;
			object obj50 = default(object);
			obj49 = obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj51 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v31+B8]");
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v32+10]");
			((CardGameVisualControls)0).ShowOthersCards();
			object obj53 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj54 = (nint)0 + (nint)2184;
			Action action = default(Action);
			action..ctor(null, (IntPtr)obj54);
			_gameEventsChannel.CloseEndRoundPopup += action;
		}
		else if (!SFSKammelnaRoomExtensions.IsOffline((Room)obj13))
		{
			_isRecording = true;
			RegisterEvents();
		}
	}

	private bool SaveAllowed(Room room)
	{
		bool flag = SFSKammelnaRoomExtensions.IsOffline(room);
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	public static void TogglePause()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_017b: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_00a2: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_0213: Expected O, but got I4
		//IL_01a9: Expected O, but got I
		//IL_01c3: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_0106: Expected O, but got I
		//IL_0116: Expected O, but got I
		//IL_0138: Expected O, but got I4
		//IL_0286: Expected O, but got I
		//IL_0253: Expected O, but got I
		//IL_0263: Expected O, but got I
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		//IL_04d4: Expected O, but got I4
		//IL_04dd: Expected O, but got I4
		//IL_04e6: Expected O, but got I4
		//IL_046c: Expected O, but got I4
		//IL_0475: Expected O, but got I4
		//IL_0514: Expected O, but got I
		//IL_052e: Expected O, but got I4
		//IL_02e6: Expected O, but got I
		//IL_0574: Expected O, but got I4
		//IL_048c: Expected O, but got I4
		//IL_05b4: Expected O, but got I
		//IL_05c4: Expected O, but got I
		//IL_05e6: Expected O, but got I4
		//IL_0350: Expected O, but got I
		//IL_0360: Expected O, but got I
		//IL_037b: Expected O, but got I
		//IL_0390: Expected O, but got I
		//IL_03c5: Expected O, but got I
		//IL_03d5: Expected O, but got I
		//IL_03e5: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E814F]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v35+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v35+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		object obj7 = 146685952;
		object obj8 = 146685952;
		if (obj6 != null)
		{
			goto IL_00b9;
		}
		goto IL_01e3;
		IL_04f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X20_v3+5ED]");
		object obj9 = (nint)0 & (nint)1;
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		object obj12;
		object obj11 = obj12;
		if (obj10 != null)
		{
			goto IL_030b;
		}
		goto IL_0544;
		IL_0544:
		_ = 1;
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v23+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		obj11 = obj12;
		object obj15 = obj13;
		if (obj14 != null)
		{
			goto IL_0340;
		}
		goto IL_0592;
		IL_03ef:
		ITrackEvent trackEvent = TrackerLibrary.PauseClicked();
		object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v14+E4]");
		object obj18;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v12+E4]");
			bool flag5 = (nint)0 == 0;
			object obj19 = !flag5;
			obj11 = 0;
			if (obj19 != null)
			{
				goto IL_02d0;
			}
			obj12 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v12+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			obj11 = 0;
			obj12 = 0;
			if (obj20 != null)
			{
				goto IL_02d0;
			}
		}
		goto IL_04f4;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj21 = (nint)0 & (nint)1;
		bool flag7 = obj21 == null;
		obj7 = 146685952;
		obj8 = 146685952;
		if (!flag7)
		{
			goto IL_00b9;
		}
		goto IL_01e3;
		IL_01e3:
		_ = 1;
		obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v12+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		obj7 = obj8;
		object obj23 = obj18;
		if (obj22 != null)
		{
			goto IL_00f6;
		}
		goto IL_0231;
		IL_00b9:
		obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v12+E4]");
		bool flag9 = (nint)0 == 0;
		obj23 = obj18;
		obj8 = obj7;
		if (!flag9)
		{
			goto IL_00f6;
		}
		goto IL_0231;
		IL_0231:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v12+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v27+18]");
		object obj25 = 0;
		obj7 = obj8;
		goto IL_0270;
		IL_00f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v12+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v37+18]");
		obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v37+18]");
		bool flag10 = (nint)0 == 0;
		object obj27 = !flag10;
		if (obj27 != null)
		{
			goto IL_0270;
		}
		goto IL_05f4;
		IL_0270:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v3+BC]");
		object obj28 = (nint)0 & (nint)1;
		if (obj28 == null)
		{
			goto IL_03ef;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v12+E4]");
		bool flag11 = (nint)0 == 0;
		obj12 = obj11;
		if (!flag11)
		{
			goto IL_02d0;
		}
		goto IL_04f4;
		IL_0592:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v6+B8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v17+18]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v17+18]");
		bool flag12 = (nint)0 == 0;
		object obj32 = !flag12;
		if (obj32 != null)
		{
			goto IL_0365;
		}
		goto IL_05f4;
		IL_02d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj33 = (nint)0 & (nint)1;
		bool flag13 = obj33 == null;
		obj12 = obj11;
		if (!flag13)
		{
			goto IL_030b;
		}
		goto IL_0544;
		IL_030b:
		obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v23+E4]");
		bool flag14 = (nint)0 == 0;
		obj15 = obj13;
		if (!flag14)
		{
			goto IL_0340;
		}
		goto IL_0592;
		IL_0340:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v23+B8]");
		obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v17+18]");
		obj31 = 0;
		goto IL_0365;
		IL_0365:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X9_v7+BC]");
		object obj34 = (nint)0 ^ (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v17+20]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v17+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v18+18]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v18+40]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v18+28]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v176 @ X2_v1 (should have been resolved before IL gen)");
			goto IL_03ef;
		}
		return;
		IL_05f4:
		throw new NullReferenceException();
	}

	public static void Pause(bool pause)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_01a5: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_022b: Expected O, but got I4
		//IL_01d3: Expected O, but got I
		//IL_01ed: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_0116: Expected O, but got I
		//IL_0263: Expected O, but got I
		//IL_0285: Expected O, but got I4
		//IL_014b: Expected O, but got I
		//IL_015b: Expected O, but got I
		//IL_016b: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8150]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_0175;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0074;
		}
		goto IL_01b3;
		IL_01fb:
		_ = 1;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v20+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		object obj6 = obj4;
		if (obj5 != null)
		{
			goto IL_00dc;
		}
		goto IL_0241;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj7 = (nint)0 & (nint)1;
		if (obj7 != null)
		{
			goto IL_00a7;
		}
		goto IL_01fb;
		IL_00a7:
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		obj6 = obj4;
		if (!flag2)
		{
			goto IL_00dc;
		}
		goto IL_0241;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v20+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v13+18]");
		object obj9 = 0;
		goto IL_0101;
		IL_0101:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v13+20]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v13+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v14+18]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v14+40]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v14+28]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v113 @ X2_v1 (should have been resolved before IL gen)");
			goto IL_0175;
		}
		return;
		IL_0241:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v6+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v13+18]");
		bool flag3 = (nint)0 == 0;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0101;
		IL_0175:
		_ = 1;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 != null)
		{
			goto IL_0074;
		}
		goto IL_01b3;
		IL_01b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj17 = (nint)0 & (nint)1;
		bool flag5 = obj17 == null;
		object obj18 = !flag5;
		if (obj18 != null)
		{
			goto IL_00a7;
		}
		goto IL_01fb;
	}

	public static void ToggleSpeedMultiplier()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_017b: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_00a2: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_0213: Expected O, but got I4
		//IL_01a9: Expected O, but got I
		//IL_01c3: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_0106: Expected O, but got I
		//IL_0116: Expected O, but got I
		//IL_0138: Expected O, but got I4
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_02a6: Expected O, but got I4
		//IL_0253: Expected O, but got I
		//IL_0263: Expected O, but got I
		//IL_02c6: Expected F4, but got I4
		//IL_043d: Expected O, but got I
		//IL_0457: Expected O, but got I4
		//IL_0460: Expected O, but got I4
		//IL_0469: Expected O, but got I4
		//IL_02fc: Expected O, but got I
		//IL_0314: Expected O, but got I4
		//IL_031d: Expected O, but got I4
		//IL_04a7: Expected O, but got I4
		//IL_04e7: Expected O, but got I
		//IL_04f7: Expected O, but got I
		//IL_0519: Expected O, but got I4
		//IL_0370: Expected O, but got I
		//IL_0380: Expected O, but got I
		//IL_039b: Expected O, but got I
		//IL_03b0: Expected O, but got I
		//IL_03e5: Expected O, but got I
		//IL_03f5: Expected O, but got I
		//IL_0405: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8154]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v31+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v31+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		object obj7 = 146685952;
		object obj8 = 146685952;
		if (obj6 != null)
		{
			goto IL_00b9;
		}
		goto IL_01e3;
		IL_0385:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X9_v5+B4]");
		object obj9 = (nint)0 ^ (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v15+28]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v15+28]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v16+18]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v16+40]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v16+28]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v210 @ X2_v1 (should have been resolved before IL gen)");
			goto IL_040f;
		}
		return;
		IL_0360:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v20+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v15+18]");
		object obj15 = 0;
		goto IL_0385;
		IL_032b:
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj17 = obj16;
		if (!flag3)
		{
			goto IL_0360;
		}
		goto IL_04c5;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj18 = (nint)0 & (nint)1;
		bool flag4 = obj18 == null;
		obj7 = 146685952;
		obj8 = 146685952;
		if (!flag4)
		{
			goto IL_00b9;
		}
		goto IL_01e3;
		IL_01e3:
		_ = 1;
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v40+E4]");
		bool flag5 = (nint)0 == 0;
		object obj20 = !flag5;
		obj7 = obj8;
		object obj21 = obj19;
		if (obj20 != null)
		{
			goto IL_00f6;
		}
		goto IL_0231;
		IL_00b9:
		obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v40+E4]");
		bool flag6 = (nint)0 == 0;
		obj21 = obj19;
		obj8 = obj7;
		if (!flag6)
		{
			goto IL_00f6;
		}
		goto IL_0231;
		IL_0231:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v25+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v23+18]");
		object obj24 = 0;
		obj7 = obj8;
		goto IL_0270;
		IL_00f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v40+B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v33+18]");
		obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v33+18]");
		bool flag7 = (nint)0 == 0;
		object obj26 = !flag7;
		if (obj26 != null)
		{
			goto IL_0270;
		}
		goto IL_0527;
		IL_0270:
		object obj27 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v4+B4]");
		bool flag8 = (nint)0 == 0;
		object obj28 = !flag8;
		object obj29 = ~obj28;
		float multiplier = ((obj29 != null) ? 1f : 1.058163E+09f);
		ITrackEvent trackEvent = TrackerLibrary.SpeedChanged(multiplier);
		object obj30 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v8+E4]");
		if ((nint)0 == 0)
		{
			goto IL_040f;
		}
		Tracker.DesignEvent(trackEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj31 = (nint)0 & (nint)1;
		bool flag9 = obj31 == null;
		object obj32 = 0;
		object obj33 = 0;
		if (!flag9)
		{
			goto IL_032b;
		}
		goto IL_0477;
		IL_0477:
		_ = 1;
		obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v20+E4]");
		bool flag10 = (nint)0 == 0;
		object obj34 = !flag10;
		obj32 = obj33;
		obj17 = obj16;
		if (obj34 != null)
		{
			goto IL_0360;
		}
		goto IL_04c5;
		IL_040f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X20_v5+5ED]");
		object obj35 = (nint)0 & (nint)1;
		bool flag11 = obj35 == null;
		object obj36 = !flag11;
		obj32 = 0;
		obj33 = 0;
		if (obj36 != null)
		{
			goto IL_032b;
		}
		goto IL_0477;
		IL_0527:
		throw new NullReferenceException();
		IL_04c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v9+B8]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v15+18]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v15+18]");
		bool flag12 = (nint)0 == 0;
		object obj38 = !flag12;
		if (obj38 != null)
		{
			goto IL_0385;
		}
		goto IL_0527;
	}

	public static void GoToNextAkla()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_014a: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		//IL_0077: Expected O, but got I
		//IL_018a: Expected O, but got I
		//IL_01a4: Expected O, but got I4
		//IL_01ea: Expected O, but got I4
		//IL_00e9: Expected O, but got I
		//IL_00f9: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_023a: Expected O, but got I
		//IL_025c: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		ITrackEvent trackEvent = TrackerLibrary.NextAklahClicked();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+E4]");
		object obj6;
		object obj5;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = 0;
			if (!flag)
			{
				goto IL_0061;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = 0;
			obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0061;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj8 = (nint)0 & (nint)1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		obj5 = obj6;
		if (obj9 != null)
		{
			goto IL_009c;
		}
		goto IL_01ba;
		IL_00d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v22+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v15+18]");
		GameReplayController gameReplayController = (GameReplayController)0;
		goto IL_00fe;
		IL_00fe:
		gameReplayController.GoToNextAkla();
		return;
		IL_0208:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v8+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v6+18]");
		gameReplayController = (GameReplayController)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v6+18]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		obj5 = obj6;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00fe;
		IL_0061:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj14 = (nint)0 & (nint)1;
		bool flag5 = obj14 == null;
		obj6 = obj5;
		if (!flag5)
		{
			goto IL_009c;
		}
		goto IL_01ba;
		IL_01ba:
		_ = 1;
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v22+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		obj5 = obj6;
		object obj17 = obj15;
		if (obj16 != null)
		{
			goto IL_00d9;
		}
		goto IL_0208;
		IL_009c:
		obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		obj6 = obj5;
		obj17 = obj15;
		if (!flag7)
		{
			goto IL_00d9;
		}
		goto IL_0208;
	}

	public static void GoToPreviousAkla()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_014a: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		//IL_0077: Expected O, but got I
		//IL_018a: Expected O, but got I
		//IL_01a4: Expected O, but got I4
		//IL_01ea: Expected O, but got I4
		//IL_00e9: Expected O, but got I
		//IL_00f9: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_023a: Expected O, but got I
		//IL_025c: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		ITrackEvent trackEvent = TrackerLibrary.PreviousAklahClicked();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+E4]");
		object obj6;
		object obj5;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = 0;
			if (!flag)
			{
				goto IL_0061;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = 0;
			obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0061;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj8 = (nint)0 & (nint)1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		obj5 = obj6;
		if (obj9 != null)
		{
			goto IL_009c;
		}
		goto IL_01ba;
		IL_00d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v22+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v15+18]");
		GameReplayController gameReplayController = (GameReplayController)0;
		goto IL_00fe;
		IL_00fe:
		gameReplayController.GoToPreviousAkla();
		return;
		IL_0208:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v8+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v6+18]");
		gameReplayController = (GameReplayController)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v6+18]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		obj5 = obj6;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00fe;
		IL_0061:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj14 = (nint)0 & (nint)1;
		bool flag5 = obj14 == null;
		obj6 = obj5;
		if (!flag5)
		{
			goto IL_009c;
		}
		goto IL_01ba;
		IL_01ba:
		_ = 1;
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v22+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		obj5 = obj6;
		object obj17 = obj15;
		if (obj16 != null)
		{
			goto IL_00d9;
		}
		goto IL_0208;
		IL_009c:
		obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		obj6 = obj5;
		obj17 = obj15;
		if (!flag7)
		{
			goto IL_00d9;
		}
		goto IL_0208;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_073b: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0082: Expected O, but got I4
		//IL_05a7: Expected O, but got I
		//IL_05c1: Expected O, but got I4
		//IL_01a0: Expected O, but got I
		//IL_03d7: Expected O, but got I
		//IL_03f1: Expected O, but got I4
		//IL_05ff: Expected O, but got I4
		//IL_00cb: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_0211: Expected O, but got I4
		//IL_0231: Expected O, but got I
		//IL_0467: Expected O, but got I
		//IL_042f: Expected O, but got I4
		//IL_0338: Expected O, but got I4
		//IL_012d: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_0293: Expected O, but got I
		//IL_02a9: Expected O, but got I
		//IL_0370: Expected O, but got I
		//IL_0386: Expected O, but got I
		//IL_03a8: Expected O, but got I4
		//IL_064c: Expected O, but got I
		//IL_0666: Expected O, but got I4
		//IL_02de: Expected O, but got I
		//IL_02ee: Expected O, but got I
		//IL_02fe: Expected O, but got I
		//IL_04cf: Expected O, but got I
		//IL_06dc: Expected O, but got I
		//IL_06ec: Expected O, but got I
		//IL_070e: Expected O, but got I4
		//IL_06a4: Expected O, but got I4
		//IL_0579: Expected O, but got I4
		//IL_0531: Expected O, but got I
		//IL_0541: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		_gameEventsChannel.CloseEndRoundPopup -= action;
		UnregisterEvents();
		_gameInitialized = false;
		object obj4 = obj3;
		bool flag = !_isRecording;
		object obj5 = !flag;
		if (obj5 != null)
		{
			goto IL_0165;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj6 = (nint)0 & (nint)1;
			if (obj6 != null)
			{
				goto IL_00e8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			if (obj8 != null)
			{
				goto IL_00e8;
			}
		}
		_ = 1;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj4;
		if (obj9 != null)
		{
			goto IL_011d;
		}
		goto IL_0445;
		IL_05cf:
		_ = 1;
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		object obj13 = obj11;
		if (obj12 != null)
		{
			goto IL_01f2;
		}
		goto IL_0615;
		IL_01f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v19+B8]");
		object obj14 = (nint)0 + (nint)24;
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EE]");
		object obj15 = (nint)0 & (nint)1;
		if (obj15 == null)
		{
			goto IL_0308;
		}
		object obj16 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v33+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = obj16;
		if (!flag5)
		{
			goto IL_0283;
		}
		goto IL_034e;
		IL_0615:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj3;
		goto IL_01f2;
		IL_01bd:
		obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v19+E4]");
		bool flag6 = (nint)0 == 0;
		obj13 = obj11;
		if (!flag6)
		{
			goto IL_01f2;
		}
		goto IL_0615;
		IL_00e8:
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v17+E4]");
		bool flag7 = (nint)0 == 0;
		obj10 = obj4;
		if (!flag7)
		{
			goto IL_011d;
		}
		goto IL_0445;
		IL_0445:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v17+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v47+18]");
		bool flag8 = (nint)0 == 0;
		object obj19 = obj4;
		if (flag8)
		{
			goto IL_0165;
		}
		goto IL_0494;
		IL_011d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v17+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v54+18]");
		bool flag9 = (nint)0 == 0;
		object obj21 = !flag9;
		obj19 = obj4;
		if (obj21 == null)
		{
			goto IL_0165;
		}
		goto IL_0494;
		IL_0494:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v39+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj22 = (nint)0 & (nint)1;
			if (obj22 != null)
			{
				goto IL_04ec;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj23 = (nint)0 & (nint)1;
			bool flag10 = obj23 == null;
			object obj24 = !flag10;
			if (obj24 != null)
			{
				goto IL_04ec;
			}
		}
		_ = 1;
		object obj25 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v52+E4]");
		bool flag11 = (nint)0 == 0;
		object obj26 = !flag11;
		object obj27 = obj25;
		if (obj26 != null)
		{
			goto IL_0521;
		}
		goto IL_06ba;
		IL_02ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v19+18]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v19+40]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v19+28]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v93 @ X2_v4 (should have been resolved before IL gen)");
		goto IL_0308;
		IL_0283:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v33+B8]");
		object obj31 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v21+48]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v21+48]");
		if ((nint)0 != 0)
		{
			goto IL_02ce;
		}
		return;
		IL_034e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj33 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v26+B8]");
		object obj34 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v15+48]");
		obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v15+48]");
		bool flag12 = (nint)0 == 0;
		object obj35 = !flag12;
		if (obj35 == null)
		{
			return;
		}
		goto IL_02ce;
		IL_04ec:
		obj25 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v52+E4]");
		bool flag13 = (nint)0 == 0;
		obj27 = obj25;
		if (!flag13)
		{
			goto IL_0521;
		}
		goto IL_06ba;
		IL_06ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj36 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v42+B8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v34+18]");
		GameReplayController gameReplayController = (GameReplayController)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v34+18]");
		bool flag14 = (nint)0 == 0;
		object obj38 = !flag14;
		if (obj38 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0546;
		IL_0308:
		_ = 1;
		obj16 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v33+E4]");
		bool flag15 = (nint)0 == 0;
		object obj39 = !flag15;
		obj17 = obj16;
		if (obj39 != null)
		{
			goto IL_0283;
		}
		goto IL_034e;
		IL_0521:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v52+B8]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v42+18]");
		gameReplayController = (GameReplayController)0;
		goto IL_0546;
		IL_0546:
		gameReplayController.StopCoroutines();
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v17+E4]");
		bool flag16 = (nint)0 == 0;
		object obj41 = !flag16;
		if (obj41 != null)
		{
			goto IL_018a;
		}
		goto IL_0587;
		IL_0165:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			goto IL_018a;
		}
		goto IL_0587;
		IL_0587:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EC]");
		object obj42 = (nint)0 & (nint)1;
		bool flag17 = obj42 == null;
		object obj43 = !flag17;
		if (obj43 != null)
		{
			goto IL_01bd;
		}
		goto IL_05cf;
		IL_018a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EC]");
		object obj44 = (nint)0 & (nint)1;
		if (obj44 != null)
		{
			goto IL_01bd;
		}
		goto IL_05cf;
	}

	private void RegisterEvents()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_03ef: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_00ad: Expected O, but got I4
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_04a6: Expected O, but got I
		//IL_04d0: Expected O, but got I4
		//IL_041d: Expected O, but got I
		//IL_07be: Expected O, but got I
		//IL_07d6: Expected I, but got O
		//IL_00f2: Expected O, but got I
		//IL_0508: Expected O, but got I4
		//IL_07eb: Expected O, but got I
		//IL_0803: Expected I, but got O
		//IL_0123: Expected O, but got I
		//IL_0522: Expected O, but got I
		//IL_054c: Expected O, but got I4
		//IL_0818: Expected O, but got I
		//IL_0830: Expected I, but got O
		//IL_0154: Expected O, but got I
		//IL_0566: Expected O, but got I
		//IL_0590: Expected O, but got I4
		//IL_0845: Expected O, but got I
		//IL_085d: Expected I, but got O
		//IL_0185: Expected O, but got I
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_05be: Expected O, but got I
		//IL_05e8: Expected O, but got I4
		//IL_0872: Expected O, but got I
		//IL_088a: Expected I, but got O
		//IL_01b6: Expected O, but got I
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected O, but got Unknown
		//IL_0616: Expected O, but got I
		//IL_0640: Expected O, but got I4
		//IL_089f: Expected O, but got I
		//IL_08b7: Expected I, but got O
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01f2: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0213: Expected O, but got I
		//IL_0230: Expected I, but got O
		//IL_0256: Expected I, but got O
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected O, but got Unknown
		//IL_066e: Expected O, but got I
		//IL_0698: Expected O, but got I4
		//IL_08cc: Expected O, but got I
		//IL_08e4: Expected I, but got O
		//IL_0295: Expected O, but got I
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected O, but got Unknown
		//IL_06c6: Expected O, but got I
		//IL_06f0: Expected O, but got I4
		//IL_08f9: Expected O, but got I
		//IL_0911: Expected I, but got O
		//IL_02c6: Expected O, but got I
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		//IL_071e: Expected O, but got I
		//IL_0748: Expected O, but got I4
		//IL_0926: Expected O, but got I
		//IL_093e: Expected I, but got O
		//IL_02f7: Expected O, but got I
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected O, but got Unknown
		//IL_0776: Expected O, but got I
		//IL_07a0: Expected O, but got I4
		//IL_0953: Expected O, but got I
		//IL_096b: Expected I, but got O
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0333: Expected O, but got I
		//IL_0348: Expected O, but got I
		//IL_0365: Expected I, but got O
		//IL_038b: Expected O, but got I
		//IL_03a1: Expected O, but got I
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_0469: Expected O, but got I
		//IL_0477: Expected I, but got O
		object obj = 152993792;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E815D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v123+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v123+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj6 = (nint)0 & (nint)1;
		if (obj6 == null)
		{
			goto IL_00bb;
		}
		goto IL_0486;
		IL_0486:
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)2208;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+8]");
		((KGame)0).OnGameInitialized += action;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v9+8]");
		((KGame)0).OnRoundStart += action2;
		object obj15 = (nint)0 + (nint)2248;
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v17+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v17+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v13+8]");
		((KGame)0).OnRoundStart += action3;
		object obj19 = (nint)0 + (nint)2240;
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v23+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v23+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj19);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v17+8]");
		((KGame)0).OnRoundEnd += action4;
		object obj23 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj24 = (nint)0 + (nint)2200;
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v29+E4]");
		bool flag6 = (nint)0 == 0;
		object obj26 = !flag6;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v29+B8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v21+8]");
		((KGame)0).OnGameEnd += action5;
		object obj28 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1376;
		object obj29 = (nint)0 + (nint)2168;
		object obj30 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v35+E4]");
		bool flag7 = (nint)0 == 0;
		object obj31 = !flag7;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v35+B8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj29);
		object obj33 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
		object obj34 = (nint)0 + (nint)2264;
		object obj35 = (nint)0 + (nint)2272;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v25+8]");
		((CardGame)0).OnCardGameEnd += action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action7 = default(Action<object>);
		action7..ctor((object)this, (IntPtr)obj34);
		SFS.OnUserJoinRoom += action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action8 = default(Action<object>);
		action8..ctor((object)this, (IntPtr)obj35);
		SFS.OnUserLeaveRoom += action8;
		object obj36 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3368;
		object obj37 = (nint)0 + (nint)2256;
		object obj38 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v47+E4]");
		bool flag8 = (nint)0 == 0;
		object obj39 = !flag8;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v47+B8]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action9 = default(Action<object>);
		action9..ctor((object)this, (IntPtr)obj37);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v29+8]");
		((KGame)0).OnSawa += action9;
		object obj41 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2512;
		object obj42 = (nint)0 + (nint)2224;
		object obj43 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v53+E4]");
		bool flag9 = (nint)0 == 0;
		object obj44 = !flag9;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj43 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v53+B8]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action10 = default(Action<object>);
		action10..ctor((object)this, (IntPtr)obj42);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v33+8]");
		((KGame)0).OnKasho += action10;
		object obj46 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1408;
		object obj47 = (nint)0 + (nint)2176;
		object obj48 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X0_v59+E4]");
		bool flag10 = (nint)0 == 0;
		object obj49 = !flag10;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj48 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X0_v59+B8]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action11 = default(Action<object>);
		action11..ctor((object)this, (IntPtr)obj47);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v37+8]");
		((KGame)0).OnCheating += action11;
		object obj51 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2136;
		object obj52 = (nint)0 + (nint)2216;
		object obj53 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v65+E4]");
		bool flag11 = (nint)0 == 0;
		object obj54 = !flag11;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj53 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v65+B8]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action12 = default(Action<object>);
		action12..ctor((object)this, (IntPtr)obj52);
		object obj56 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
		object obj57 = (nint)0 + (nint)2232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v41+8]");
		((KGame)0).OnGiftSent += action12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action13 = default(Action<object>);
		action13..ctor((object)this, (IntPtr)obj57);
		SFS.OnPublicMessage += action13;
		object obj58 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v42+B8]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v43+30]");
		object obj60 = (nint)0 & (nint)1;
		if (obj60 == null)
		{
			object obj61 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj62 = (nint)0 + (nint)2280;
			Action<object> action14 = default(Action<object>);
			action14..ctor((object)null, (IntPtr)obj62);
			SFS.OnMyUserVariableUpdate += action14;
		}
		return;
		IL_00bb:
		_ = 1;
		goto IL_0486;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj63 = (nint)0 & (nint)1;
		bool flag12 = obj63 == null;
		object obj64 = !flag12;
		if (obj64 == null)
		{
			goto IL_00bb;
		}
		goto IL_0486;
	}

	private static void OnCloseEndRoundPopup()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_01c7: Expected O, but got I4
		//IL_016f: Expected O, but got I
		//IL_0189: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_01ff: Expected O, but got I
		//IL_0221: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E815E]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_0197;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v15+18]");
		object obj9 = 0;
		goto IL_010a;
		IL_010a:
		_ = 0;
		return;
		IL_01dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v4+18]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_010a;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			goto IL_00b0;
		}
		goto IL_0197;
		IL_0197:
		_ = 1;
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		object obj16 = obj14;
		if (obj15 != null)
		{
			goto IL_00e5;
		}
		goto IL_01dd;
		IL_00b0:
		obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+E4]");
		bool flag5 = (nint)0 == 0;
		obj16 = obj14;
		if (!flag5)
		{
			goto IL_00e5;
		}
		goto IL_01dd;
	}

	private static void OnUserVariableUpdate(List<string> obj)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_01cc: Expected O, but got I
		//IL_0113: Expected O, but got I4
		//IL_00c9: Expected O, but got I
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0244: Expected O, but got I
		//IL_0252: Expected I, but got O
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		object item = "setMimeType" + 3808;
		if (!((List<object>)(object)obj).Contains(item))
		{
			return;
		}
		User mySelf = SFS.MySelf;
		if (!SFSKammelnaUserExtensions.IsSubscribed(mySelf))
		{
			return;
		}
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v11+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v9+30]");
			if ((nint)0 != 1)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v11+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v9+30]");
			if ((nint)0 != 1)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v17+B8]");
			object obj4 = 0;
		}
		_ = 0;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)2280;
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj8);
		SFS.OnMyUserVariableUpdate -= action;
		ITrackEvent trackEvent = TrackerLibrary.SubscribedToWatchReplay();
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v16+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			bool flag2 = SaveGameReplayGame();
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			bool flag3 = SaveGameReplayGame();
		}
	}

	private void UnregisterEvents()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_03ef: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_00ad: Expected O, but got I4
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_04a6: Expected O, but got I
		//IL_04d0: Expected O, but got I4
		//IL_041d: Expected O, but got I
		//IL_07be: Expected O, but got I
		//IL_07d6: Expected I, but got O
		//IL_00f2: Expected O, but got I
		//IL_0508: Expected O, but got I4
		//IL_07eb: Expected O, but got I
		//IL_0803: Expected I, but got O
		//IL_0123: Expected O, but got I
		//IL_0522: Expected O, but got I
		//IL_054c: Expected O, but got I4
		//IL_0818: Expected O, but got I
		//IL_0830: Expected I, but got O
		//IL_0154: Expected O, but got I
		//IL_0566: Expected O, but got I
		//IL_0590: Expected O, but got I4
		//IL_0845: Expected O, but got I
		//IL_085d: Expected I, but got O
		//IL_0185: Expected O, but got I
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_05be: Expected O, but got I
		//IL_05e8: Expected O, but got I4
		//IL_0872: Expected O, but got I
		//IL_088a: Expected I, but got O
		//IL_01b6: Expected O, but got I
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected O, but got Unknown
		//IL_0616: Expected O, but got I
		//IL_0640: Expected O, but got I4
		//IL_089f: Expected O, but got I
		//IL_08b7: Expected I, but got O
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01f2: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0213: Expected O, but got I
		//IL_0230: Expected I, but got O
		//IL_0256: Expected I, but got O
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected O, but got Unknown
		//IL_066e: Expected O, but got I
		//IL_0698: Expected O, but got I4
		//IL_08cc: Expected O, but got I
		//IL_08e4: Expected I, but got O
		//IL_0295: Expected O, but got I
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected O, but got Unknown
		//IL_06c6: Expected O, but got I
		//IL_06f0: Expected O, but got I4
		//IL_08f9: Expected O, but got I
		//IL_0911: Expected I, but got O
		//IL_02c6: Expected O, but got I
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		//IL_071e: Expected O, but got I
		//IL_0748: Expected O, but got I4
		//IL_0926: Expected O, but got I
		//IL_093e: Expected I, but got O
		//IL_02f7: Expected O, but got I
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected O, but got Unknown
		//IL_0776: Expected O, but got I
		//IL_07a0: Expected O, but got I4
		//IL_0953: Expected O, but got I
		//IL_096b: Expected I, but got O
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0333: Expected O, but got I
		//IL_0348: Expected O, but got I
		//IL_0365: Expected I, but got O
		//IL_038b: Expected O, but got I
		//IL_03a1: Expected O, but got I
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_0469: Expected O, but got I
		//IL_0477: Expected I, but got O
		object obj = 152993792;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8160]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v123+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v123+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj6 = (nint)0 & (nint)1;
		if (obj6 == null)
		{
			goto IL_00bb;
		}
		goto IL_0486;
		IL_0486:
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)2208;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+8]");
		((KGame)0).OnGameInitialized -= action;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v9+8]");
		((KGame)0).OnRoundStart -= action2;
		object obj15 = (nint)0 + (nint)2248;
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v17+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v17+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v13+8]");
		((KGame)0).OnRoundStart -= action3;
		object obj19 = (nint)0 + (nint)2240;
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v23+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v23+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj19);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v17+8]");
		((KGame)0).OnRoundEnd -= action4;
		object obj23 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj24 = (nint)0 + (nint)2200;
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v29+E4]");
		bool flag6 = (nint)0 == 0;
		object obj26 = !flag6;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v29+B8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v21+8]");
		((KGame)0).OnGameEnd -= action5;
		object obj28 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1376;
		object obj29 = (nint)0 + (nint)2168;
		object obj30 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v35+E4]");
		bool flag7 = (nint)0 == 0;
		object obj31 = !flag7;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v35+B8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj29);
		object obj33 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
		object obj34 = (nint)0 + (nint)2264;
		object obj35 = (nint)0 + (nint)2272;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v25+8]");
		((CardGame)0).OnCardGameEnd -= action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action7 = default(Action<object>);
		action7..ctor((object)this, (IntPtr)obj34);
		SFS.OnUserJoinRoom -= action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action8 = default(Action<object>);
		action8..ctor((object)this, (IntPtr)obj35);
		SFS.OnUserLeaveRoom -= action8;
		object obj36 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3368;
		object obj37 = (nint)0 + (nint)2256;
		object obj38 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v47+E4]");
		bool flag8 = (nint)0 == 0;
		object obj39 = !flag8;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v47+B8]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action9 = default(Action<object>);
		action9..ctor((object)this, (IntPtr)obj37);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v29+8]");
		((KGame)0).OnSawa -= action9;
		object obj41 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2512;
		object obj42 = (nint)0 + (nint)2224;
		object obj43 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v53+E4]");
		bool flag9 = (nint)0 == 0;
		object obj44 = !flag9;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj43 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v53+B8]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action10 = default(Action<object>);
		action10..ctor((object)this, (IntPtr)obj42);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v33+8]");
		((KGame)0).OnKasho -= action10;
		object obj46 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1408;
		object obj47 = (nint)0 + (nint)2176;
		object obj48 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X0_v59+E4]");
		bool flag10 = (nint)0 == 0;
		object obj49 = !flag10;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj48 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X0_v59+B8]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action11 = default(Action<object>);
		action11..ctor((object)this, (IntPtr)obj47);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v37+8]");
		((KGame)0).OnCheating -= action11;
		object obj51 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2136;
		object obj52 = (nint)0 + (nint)2216;
		object obj53 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v65+E4]");
		bool flag11 = (nint)0 == 0;
		object obj54 = !flag11;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj53 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v65+B8]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action12 = default(Action<object>);
		action12..ctor((object)this, (IntPtr)obj52);
		object obj56 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
		object obj57 = (nint)0 + (nint)2232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v41+8]");
		((KGame)0).OnGiftSent -= action12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action13 = default(Action<object>);
		action13..ctor((object)this, (IntPtr)obj57);
		SFS.OnPublicMessage -= action13;
		object obj58 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v42+B8]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v43+30]");
		object obj60 = (nint)0 & (nint)1;
		if (obj60 == null)
		{
			object obj61 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj62 = (nint)0 + (nint)2280;
			Action<object> action14 = default(Action<object>);
			action14..ctor((object)null, (IntPtr)obj62);
			SFS.OnMyUserVariableUpdate -= action14;
		}
		return;
		IL_00bb:
		_ = 1;
		goto IL_0486;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj63 = (nint)0 & (nint)1;
		bool flag12 = obj63 == null;
		object obj64 = !flag12;
		if (obj64 == null)
		{
			goto IL_00bb;
		}
		goto IL_0486;
	}

	private void OnGameInitialized()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0124: Expected O, but got I
		//IL_0073: Expected O, but got I
		//IL_008d: Expected O, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0185: Expected O, but got I
		//IL_01af: Expected O, but got I4
		//IL_0205: Expected O, but got I
		//IL_021d: Expected I, but got O
		//IL_00d2: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_0232: Expected O, but got I
		//IL_024a: Expected I, but got O
		//IL_0103: Expected O, but got I
		if (_gameInitialized)
		{
			return;
		}
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		_gameInitialized = true;
		_isFirstRound = false;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				goto IL_009b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
			object obj5 = (nint)0 & (nint)1;
			if (obj5 == null)
			{
				goto IL_009b;
			}
		}
		goto IL_0165;
		IL_009b:
		_ = 1;
		goto IL_0165;
		IL_0165:
		object obj6 = typeof(SqlSingle[]) + 2376;
		object obj7 = (nint)0 + (nint)2208;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v5+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v8+8]");
		((KGame)0).OnRoundStart -= action;
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v13+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v13+8]");
		((KGame)0).OnGameInitialized -= action2;
	}

	private void OnRoundStart()
	{
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected I4, but got Unknown
		//IL_0657: Expected O, but got I
		//IL_0671: Expected O, but got I4
		//IL_0519: Expected O, but got I
		//IL_0533: Expected O, but got I4
		//IL_013e: Expected O, but got I
		//IL_0048: Expected O, but got I
		//IL_06b1: Expected O, but got I4
		//IL_0571: Expected O, but got I4
		//IL_01ba: Expected O, but got I
		//IL_02a4: Expected O, but got I4
		//IL_021c: Expected O, but got I
		//IL_022c: Expected O, but got I
		//IL_024e: Expected O, but got I4
		//IL_034a: Expected O, but got I4
		//IL_02dc: Expected O, but got I
		//IL_02ec: Expected O, but got I
		//IL_030d: Expected O, but got I4
		//IL_05ed: Expected O, but got I
		//IL_0606: Expected O, but got I4
		//IL_060e: Expected O, but got I
		//IL_0266: Expected O, but got I4
		//IL_0378: Expected O, but got I
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_0398: Expected O, but got I
		//IL_040f: Expected O, but got I
		//IL_043a: Expected O, but got I4
		//IL_089e: Expected O, but got I
		//IL_03af: Expected I, but got O
		//IL_03bd: Expected I, but got O
		//IL_06fe: Expected O, but got I
		//IL_0718: Expected O, but got I4
		//IL_0483: Expected O, but got I
		//IL_082c: Expected O, but got I4
		//IL_0846: Expected O, but got I4
		//IL_0756: Expected O, but got I4
		//IL_03f5: Expected O, but got I4
		//IL_099d: Expected O, but got I4
		//IL_09de: Expected O, but got I
		//IL_09f0: Expected O, but got I
		//IL_07d2: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		_roundInitialized = true;
		bool isFirstRound = _isFirstRound;
		object obj8;
		object obj6;
		if (_isFirstRound)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v82+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
				object obj3 = (nint)0 & (nint)1;
				if (obj3 != null)
				{
					goto IL_0065;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_0065;
				}
			}
			_ = 1;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v85+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj8 = obj6;
			if (obj7 != null)
			{
				goto IL_009a;
			}
			goto IL_0587;
		}
		isFirstRound = (byte)(typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2120) != 0;
		_isFirstRound = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GameReplay gameReplay = default(GameReplay);
		gameReplay..ctor(<Room>k__BackingField);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v45+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EB]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 != null)
			{
				goto IL_015d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EB]");
			object obj11 = (nint)0 & (nint)1;
			bool flag3 = obj11 == null;
			object obj12 = !flag3;
			if (obj12 != null)
			{
				goto IL_015d;
			}
		}
		_ = 1;
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v55+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		object obj15 = obj13;
		if (obj14 != null)
		{
			goto IL_0192;
		}
		goto IL_06c7;
		IL_0973:
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X0_v21+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X0_v21+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v14+8]");
		AddWatchersFromLobby((BalootGame)0);
		AddWaraqEvent(<Room>k__BackingField);
		return;
		IL_0065:
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v85+E4]");
		bool flag6 = (nint)0 == 0;
		obj8 = obj6;
		if (!flag6)
		{
			goto IL_009a;
		}
		goto IL_0587;
		IL_05bb:
		List<object>.Enumerator enumerator;
		object obj20;
		if (_gameInitialized)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v85+B8]");
			object obj19 = 0;
			bool flag7 = obj19 == null;
			enumerator = (List<object>.Enumerator)0;
			IntPtr intPtr = default(IntPtr);
			obj20 = (nint)intPtr;
			if (flag7)
			{
				goto IL_093b;
			}
			((GameReplay)obj19).AddRoundEvent();
		}
		goto IL_062a;
		IL_009a:
		if (_isRecording)
		{
			goto IL_05bb;
		}
		goto IL_062a;
		IL_015d:
		obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v55+E4]");
		bool flag8 = (nint)0 == 0;
		obj15 = obj13;
		if (!flag8)
		{
			goto IL_0192;
		}
		goto IL_06c7;
		IL_06c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj13 = obj;
		goto IL_0192;
		IL_0192:
		object obj21 = gameReplay;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj22 = (nint)0 & (nint)1;
		if (obj22 != null)
		{
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v77+E4]");
			bool flag9 = (nint)0 == 0;
			object obj24 = obj23;
			if (!flag9)
			{
				goto IL_020c;
			}
		}
		else
		{
			_ = 1;
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v77+E4]");
			bool flag10 = (nint)0 == 0;
			object obj25 = !flag10;
			object obj24 = obj23;
			if (obj25 != null)
			{
				goto IL_020c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v71+B8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v47+8]");
		KGame kGame = (KGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v47+8]");
		bool flag11 = (nint)0 == 0;
		enumerator = (List<object>.Enumerator)0;
		obj20 = gameReplay;
		if (!flag11)
		{
			goto IL_0324;
		}
		goto IL_093b;
		IL_0440:
		object obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
			object obj29 = (nint)0 & (nint)1;
			if (obj29 != null)
			{
				goto IL_04a0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
			object obj30 = (nint)0 & (nint)1;
			bool flag12 = obj30 == null;
			object obj31 = !flag12;
			if (obj31 != null)
			{
				goto IL_04a0;
			}
		}
		_ = 1;
		object obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v29+E4]");
		bool flag13 = (nint)0 == 0;
		object obj33 = !flag13;
		object obj34 = obj32;
		if (obj33 != null)
		{
			goto IL_04d5;
		}
		goto IL_076c;
		IL_04d5:
		if (_isRecording)
		{
			goto IL_07a0;
		}
		goto IL_0973;
		IL_093b:
		NullReferenceException ex = new NullReferenceException();
		bool flag14 = (nint)obj20 != 1;
		NullReferenceException ex2 = ex;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag14)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj35 = (nint)0 + (nint)2936;
			obj20 = obj35;
			enumerator.Dispose();
			object obj36 = default(object);
			bool flag15 = obj36 == null;
			enumerator2 = (List<object>.Enumerator)obj36;
			if (flag15)
			{
				goto IL_0440;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			enumerator2 = (List<object>.Enumerator)obj36;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BE88");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_020c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v77+B8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v51+8]");
		kGame = (KGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v51+8]");
		bool flag16 = (nint)0 == 0;
		object obj38 = !flag16;
		if (obj38 != null)
		{
			goto IL_0324;
		}
		enumerator = (List<object>.Enumerator)0;
		obj20 = gameReplay;
		goto IL_093b;
		IL_0324:
		List<KPlayer> players = kGame.Players;
		bool flag17 = players == null;
		enumerator = (List<object>.Enumerator)0;
		obj20 = null;
		object obj42;
		List<object>.Enumerator enumerator5;
		if (!flag17)
		{
			List<object>.Enumerator enumerator3 = ((List<object>)(object)players).GetEnumerator();
			object obj39 = (nint)0 + (nint)2944;
			object obj40 = typeof(SqlSingle[]) + 2376;
			object obj41 = (nint)0 + (nint)2192;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			Action action = default(Action);
			KPlayer kPlayer = default(KPlayer);
			while (enumerator4.MoveNext())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num = (nint)obj41;
				action..ctor(this, (IntPtr)obj41);
				if (kPlayer != null)
				{
					kPlayer.OnDidLastAction += action;
					obj42 = 0;
					num = 0;
					continue;
				}
				goto IL_0819;
			}
			object obj43 = (nint)0 + (nint)2936;
			obj20 = obj43;
			enumerator4.Dispose();
			enumerator = enumerator2;
			enumerator5 = enumerator2;
			enumerator2 = (List<object>.Enumerator)0;
			goto IL_0440;
		}
		goto IL_093b;
		IL_07a0:
		if (_gameInitialized)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v29+B8]");
			object obj44 = 0;
			if (obj44 == null)
			{
				goto IL_093b;
			}
			((GameReplay)obj44).AddRoundEvent();
		}
		goto IL_0973;
		IL_076c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj32 = obj;
		if (_isRecording)
		{
			goto IL_07a0;
		}
		goto IL_0973;
		IL_04a0:
		obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v29+E4]");
		bool flag18 = (nint)0 == 0;
		obj34 = obj32;
		if (!flag18)
		{
			goto IL_04d5;
		}
		goto IL_076c;
		IL_062a:
		AddWaraqEvent(<Room>k__BackingField);
		return;
		IL_0819:
		NullReferenceException ex4 = new NullReferenceException();
		obj42 = 0;
		enumerator = enumerator2;
		enumerator5 = enumerator2;
		enumerator2 = (List<object>.Enumerator)0;
		obj20 = this;
		goto IL_093b;
		IL_0587:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj;
		if (_isRecording)
		{
			goto IL_05bb;
		}
		goto IL_062a;
	}

	private void AddWaraqEvent(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01e4: Expected O, but got I4
		//IL_00b9: Expected O, but got I
		//IL_00d1: Expected O, but got I4
		//IL_022a: Expected O, but got I
		//IL_0244: Expected O, but got I4
		//IL_0255: Expected O, but got I4
		//IL_029c: Expected O, but got I4
		//IL_0145: Expected O, but got I
		//IL_0155: Expected O, but got I
		//IL_0177: Expected O, but got I4
		//IL_02e4: Expected O, but got I
		//IL_02f4: Expected O, but got I
		//IL_031f: Expected O, but got I
		//IL_043a: Expected O, but got I4
		//IL_0379: Expected O, but got I
		//IL_0389: Expected O, but got I
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_0472: Expected O, but got I
		//IL_0482: Expected O, but got I
		//IL_04a4: Expected O, but got I4
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_03eb: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8163]");
		object obj3 = (nint)0 & (nint)1;
		Room room3;
		(int, int) tuple2;
		Room room2 = default(Room);
		(int, int) tuple;
		if (obj3 != null)
		{
			(int, int) scores = GetScores(room2);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			tuple = scores;
			room3 = room2;
			tuple2 = scores;
			if (!flag)
			{
				goto IL_00a3;
			}
		}
		else
		{
			object obj5 = typeof(UsageHint) + 1696;
			_ = 1;
			(int, int) scores2 = ((GameReplayManager)obj5).GetScores(room2);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v26+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			tuple = scores2;
			room3 = room2;
			tuple2 = scores2;
			if (obj6 != null)
			{
				goto IL_00a3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj7 = (nint)0 & (nint)1;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		room2 = room3;
		object obj9 = 146685952;
		tuple = tuple2;
		if (obj8 != null)
		{
			goto IL_00f0;
		}
		goto IL_026c;
		IL_0369:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v17+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v13+8]");
		object obj11 = 0;
		goto IL_038e;
		IL_038e:
		object obj12 = typeof(UsageHint) + 1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = default(object);
		obj13..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v3+158]");
		_ = 0;
		_ = 1;
		object obj14 = obj13 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v10+188]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AddReplayEvent((ReplayEvent)obj13);
		return;
		IL_04b2:
		throw new NullReferenceException();
		IL_00a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj15 = (nint)0 & (nint)1;
		bool flag4 = obj15 == null;
		obj9 = 146685952;
		room3 = room2;
		tuple2 = tuple;
		if (!flag4)
		{
			goto IL_00f0;
		}
		goto IL_026c;
		IL_026c:
		_ = 1;
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		room2 = room3;
		tuple = tuple2;
		object obj18 = obj16;
		if (obj17 != null)
		{
			goto IL_0135;
		}
		goto IL_02c2;
		IL_00f0:
		obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v17+E4]");
		bool flag6 = (nint)0 == 0;
		room3 = room2;
		obj18 = obj16;
		tuple2 = tuple;
		if (!flag6)
		{
			goto IL_0135;
		}
		goto IL_02c2;
		IL_02c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v17+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v17+8]");
		object obj20 = 0;
		room2 = room3;
		tuple = tuple2;
		goto IL_0309;
		IL_0135:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v17+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v27+8]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v27+8]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		if (obj22 != null)
		{
			goto IL_0309;
		}
		goto IL_04b2;
		IL_0309:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj23 = (nint)0 & (nint)1;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v17+E4]");
			bool flag8 = (nint)0 == 0;
			object obj24 = obj16;
			if (!flag8)
			{
				goto IL_0369;
			}
		}
		else
		{
			_ = 1;
			obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v17+E4]");
			bool flag9 = (nint)0 == 0;
			object obj25 = !flag9;
			object obj24 = obj16;
			if (obj25 != null)
			{
				goto IL_0369;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v6+B8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v6+8]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v6+8]");
		bool flag10 = (nint)0 == 0;
		object obj28 = !flag10;
		if (obj28 != null)
		{
			goto IL_038e;
		}
		goto IL_04b2;
	}

	private (int, int) GetScores(Room room)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object varName = "startPosition" + 2144;
		object varName2 = "startPosition" + 2160;
		int variable = SFSExtensions.GetVariable(room, (string)varName, 0);
		int variable2 = SFSExtensions.GetVariable(room, (string)varName2, 0);
		return (variable, variable2);
	}

	private void OnDidLastAction()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_01e2: Expected I, but got O
		//IL_0204: Expected O, but got I4
		//IL_020d: Expected O, but got I4
		//IL_0216: Expected O, but got I4
		//IL_021f: Expected O, but got I4
		//IL_0228: Expected O, but got I4
		//IL_0231: Expected O, but got I4
		//IL_023a: Expected O, but got I4
		//IL_0243: Expected O, but got I4
		//IL_024c: Expected O, but got I4
		//IL_00da: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_00fb: Expected O, but got I4
		//IL_004f: Expected I, but got O
		//IL_006f: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_0081: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_00a4: Expected O, but got I4
		//IL_00ad: Expected O, but got I4
		//IL_00b6: Expected O, but got I4
		//IL_02d2: Expected I, but got O
		//IL_02f4: Expected O, but got I4
		//IL_027a: Expected O, but got I
		//IL_0294: Expected O, but got I4
		//IL_029d: Expected O, but got I4
		//IL_02b6: Expected O, but got I4
		//IL_0186: Expected O, but got I
		//IL_01a8: Expected O, but got I4
		//IL_0121: Expected I, but got O
		//IL_03b3: Expected I, but got O
		//IL_03cc: Expected O, but got I4
		//IL_032c: Expected I, but got O
		//IL_034c: Expected O, but got I
		//IL_0384: Expected O, but got I4
		//IL_01cf: Expected O, but got I4
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected O, but got Unknown
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected O, but got Unknown
		//IL_0431: Expected I, but got O
		//IL_16d0: Expected O, but got I
		//IL_16d8: Expected I, but got O
		//IL_0586: Expected I, but got O
		//IL_073d: Expected O, but got I
		//IL_0757: Expected O, but got I4
		//IL_14fb: Expected O, but got I
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected O, but got Unknown
		//IL_1117: Expected O, but got I
		//IL_1131: Expected O, but got I4
		//IL_0491: Expected I, but got O
		//IL_046c: Expected O, but got I
		//IL_05e6: Expected I, but got O
		//IL_05c1: Expected O, but got I
		//IL_07bd: Expected I, but got O
		//IL_07dd: Expected O, but got I
		//IL_07fd: Expected O, but got I4
		//IL_0805: Expected I, but got O
		//IL_0773: Expected I, but got O
		//IL_0795: Expected O, but got I4
		//IL_153f: Expected O, but got I
		//IL_1197: Expected I, but got O
		//IL_11b7: Expected O, but got I
		//IL_11d7: Expected O, but got I4
		//IL_11df: Expected I, but got O
		//IL_114d: Expected I, but got O
		//IL_116f: Expected O, but got I4
		//IL_04de: Expected O, but got I
		//IL_0500: Expected O, but got I4
		//IL_1610: Unknown result type (might be due to invalid IL or missing references)
		//IL_1615: Expected O, but got Unknown
		//IL_0633: Expected O, but got I
		//IL_0655: Expected O, but got I4
		//IL_0833: Expected O, but got I
		//IL_0849: Expected O, but got I
		//IL_1646: Unknown result type (might be due to invalid IL or missing references)
		//IL_164b: Expected O, but got Unknown
		//IL_165b: Expected O, but got I
		//IL_155c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1561: Expected O, but got Unknown
		//IL_158b: Expected O, but got I4
		//IL_1233: Expected O, but got I4
		//IL_091f: Expected I, but got O
		//IL_0941: Expected O, but got I4
		//IL_051f: Expected O, but got I4
		//IL_0527: Expected I, but got O
		//IL_15b9: Expected O, but got I
		//IL_066c: Expected O, but got I4
		//IL_0674: Expected I, but got O
		//IL_08b3: Expected O, but got I
		//IL_08d5: Expected O, but got I4
		//IL_1275: Unknown result type (might be due to invalid IL or missing references)
		//IL_127a: Expected O, but got Unknown
		//IL_128a: Expected I, but got O
		//IL_12b3: Expected O, but got I4
		//IL_12c5: Expected O, but got I4
		//IL_09df: Expected O, but got I
		//IL_09f5: Expected O, but got I
		//IL_0969: Expected I, but got O
		//IL_0989: Expected O, but got I
		//IL_09a9: Expected O, but got I4
		//IL_09b1: Expected I, but got O
		//IL_0acb: Expected I, but got O
		//IL_0aed: Expected O, but got I4
		//IL_08f4: Expected O, but got I4
		//IL_08fc: Expected I, but got O
		//IL_131d: Expected O, but got I
		//IL_133f: Expected O, but got I4
		//IL_0a5f: Expected O, but got I
		//IL_0a81: Expected O, but got I4
		//IL_0b8b: Expected O, but got I
		//IL_0ba1: Expected O, but got I
		//IL_0b15: Expected I, but got O
		//IL_0b35: Expected O, but got I
		//IL_0b55: Expected O, but got I4
		//IL_0b5d: Expected I, but got O
		//IL_139a: Expected O, but got I4
		//IL_0c77: Expected I, but got O
		//IL_0c99: Expected O, but got I4
		//IL_0aa0: Expected O, but got I4
		//IL_0aa8: Expected I, but got O
		//IL_0c0b: Expected O, but got I
		//IL_0c2d: Expected O, but got I4
		//IL_13e7: Expected O, but got I
		//IL_13f7: Expected O, but got I
		//IL_1403: Expected O, but got I
		//IL_1412: Unknown result type (might be due to invalid IL or missing references)
		//IL_1417: Expected O, but got Unknown
		//IL_1420: Expected O, but got I4
		//IL_0d3d: Expected O, but got I
		//IL_0cc1: Expected I, but got O
		//IL_0ce1: Expected O, but got I
		//IL_0d01: Expected O, but got I4
		//IL_0d09: Expected I, but got O
		//IL_0e13: Expected I, but got O
		//IL_0e35: Expected O, but got I4
		//IL_0c4c: Expected O, but got I4
		//IL_0c54: Expected I, but got O
		//IL_14aa: Expected O, but got I
		//IL_14b2: Expected I, but got O
		//IL_14c5: Expected O, but got I4
		//IL_14ce: Expected O, but got I4
		//IL_0da7: Expected O, but got I
		//IL_0dc9: Expected O, but got I4
		//IL_1440: Unknown result type (might be due to invalid IL or missing references)
		//IL_1445: Expected O, but got Unknown
		//IL_0ed9: Expected O, but got I
		//IL_0e5d: Expected I, but got O
		//IL_0e7d: Expected O, but got I
		//IL_0e9d: Expected O, but got I4
		//IL_0ea5: Expected I, but got O
		//IL_0fa7: Expected I, but got O
		//IL_0fc9: Expected O, but got I4
		//IL_0de8: Expected O, but got I4
		//IL_0df0: Expected I, but got O
		//IL_0f43: Expected O, but got I
		//IL_0f65: Expected O, but got I4
		//IL_1066: Unknown result type (might be due to invalid IL or missing references)
		//IL_106b: Expected O, but got Unknown
		//IL_0ff1: Expected I, but got O
		//IL_1011: Expected O, but got I
		//IL_1031: Expected O, but got I4
		//IL_1039: Expected I, but got O
		//IL_109c: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a1: Expected O, but got Unknown
		//IL_0f7c: Expected O, but got I4
		//IL_0f84: Expected I, but got O
		KPlayer kPlayer = (KPlayer)(typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8165]");
		object obj = (nint)0 & (nint)1;
		object obj4;
		object obj5;
		List<object>.Enumerator enumerator;
		object obj6;
		object obj3;
		if (obj != null)
		{
			nint num = (nint)kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v196 (Il2CppClass<KPlayer>)+E4]");
			bool flag = (nint)0 == 0;
			object obj2 = 0;
			obj3 = 0;
			obj4 = 0;
			enumerator = (List<object>.Enumerator)0;
			nint num2 = num;
			obj2 = 0;
			obj5 = 0;
			obj6 = 0;
			enumerator = (List<object>.Enumerator)0;
			if (!flag)
			{
				goto IL_00c4;
			}
		}
		else
		{
			_ = 1;
			nint num2 = (nint)kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v140 (Il2CppClass<KPlayer>)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj2 = 0;
			obj3 = 0;
			obj4 = 0;
			enumerator = (List<object>.Enumerator)0;
			obj2 = 0;
			obj5 = 0;
			obj6 = 0;
			enumerator = (List<object>.Enumerator)0;
			if (obj7 != null)
			{
				goto IL_00c4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj8 = (nint)0 & (nint)1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		object obj10 = 146685952;
		obj3 = obj5;
		obj4 = obj6;
		object obj11 = 146685952;
		if (obj9 != null)
		{
			goto IL_0119;
		}
		goto IL_02c4;
		IL_1725:
		object replayEvent;
		AddReplayEvent((ReplayEvent)replayEvent);
		return;
		IL_14eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X20_v6 (KPlayer)+78]");
		IEnumerable<Card> enumerable = (IEnumerable<Card>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X20_v6 (KPlayer)+78]");
		nint num3 = default(nint);
		CardGameLastActionInfo cardGameLastActionInfo;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X22_v9 (System.Collections.Generic.IEnumerable`1<Card>)+18]");
			bool flag4 = (nint)0 < (nint)1;
			ReplayEvent replayEvent2 = (ReplayEvent)num3;
			if (!flag4)
			{
				object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X0_v24+E4]");
				bool flag5 = (nint)0 == 0;
				object obj14 = !flag5;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X20_v6 (KPlayer)+78]");
				long num4 = CardUtils.EncodeBinaryLongCards((IEnumerable<Card>)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj15 = default(object);
				obj15..ctor();
				_ = kPlayer.<Index>k__BackingField;
				_ = 3;
				AddReplayEvent((ReplayEvent)obj15);
				replayEvent2 = (ReplayEvent)obj15;
			}
			object obj16 = typeof(System.Buffers.Text.ParserHelpers) + 792;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = default(object);
			obj17..ctor();
			_ = ((LastActionInfo)cardGameLastActionInfo).<ActionPlayer>k__BackingField;
			_ = 4;
			object obj18 = obj17 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X20_v6 (KPlayer)+40]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			AddReplayEvent((ReplayEvent)obj17);
			return;
		}
		goto IL_1675;
		IL_1675:
		NullReferenceException ex = new NullReferenceException();
		bool flag6 = num3 != 1;
		NullReferenceException ex2 = ex;
		List<object>.Enumerator enumerator2;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj19 = (nint)0 + (nint)1864;
			num3 = (nint)obj19;
			enumerator2.Dispose();
			object obj20 = default(object);
			bool flag7 = obj20 == null;
			object obj21 = obj20;
			if (flag7)
			{
				goto IL_14eb;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			obj21 = obj20;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99AE8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj22 = (nint)0 & (nint)1;
		bool flag8 = obj22 == null;
		obj10 = 146685952;
		obj11 = 146685952;
		obj5 = obj3;
		obj6 = obj4;
		if (!flag8)
		{
			goto IL_0119;
		}
		goto IL_02c4;
		IL_02c4:
		_ = 1;
		nint num5 = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v131 (Il2CppClass<KPlayer>)+E4]");
		bool flag9 = (nint)0 == 0;
		object obj23 = !flag9;
		obj10 = obj11;
		nint num6 = num5;
		obj3 = obj5;
		if (obj23 != null)
		{
			goto IL_0166;
		}
		goto IL_031a;
		IL_0119:
		num6 = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v191 (Il2CppClass<KPlayer>)+E4]");
		bool flag10 = (nint)0 == 0;
		obj11 = obj10;
		num5 = num6;
		obj5 = obj3;
		obj6 = obj4;
		if (!flag10)
		{
			goto IL_0166;
		}
		goto IL_031a;
		IL_031a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num7 = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v133 (Il2CppClass<KPlayer>)+B8]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v123 (Il2CppStaticFields<KPlayer>)+8]");
		CardGame cardGame = (CardGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v123 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag11 = (nint)0 == 0;
		obj10 = obj11;
		obj3 = obj5;
		enumerator2 = enumerator;
		cardGameLastActionInfo = (CardGameLastActionInfo)152993792;
		if (!flag11)
		{
			goto IL_0392;
		}
		goto IL_1675;
		IL_0166:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v191 (Il2CppClass<KPlayer>)+B8]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v132 (Il2CppStaticFields<KPlayer>)+8]");
		cardGame = (CardGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v132 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag12 = (nint)0 == 0;
		object obj24 = !flag12;
		if (obj24 != null)
		{
			goto IL_0392;
		}
		obj11 = obj10;
		enumerator2 = enumerator;
		cardGameLastActionInfo = (CardGameLastActionInfo)152993792;
		goto IL_1675;
		IL_0392:
		CardGameLastActionInfo lastAction = cardGame.LastAction;
		bool flag13 = lastAction == null;
		num3 = unchecked((nint)null);
		obj11 = obj10;
		enumerator2 = enumerator;
		cardGameLastActionInfo = (CardGameLastActionInfo)152993792;
		if (flag13)
		{
			goto IL_1675;
		}
		object obj25 = "___# Content push apply failed [{0}]: {1}" + 2656;
		nint num12;
		nint num11;
		if (((LastActionInfo)lastAction).<Action>k__BackingField == (string)obj25)
		{
			cardGameLastActionInfo = (CardGameLastActionInfo)(object)lastAction.<BidType>k__BackingField;
			nint num10 = (nint)kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v72 (Il2CppClass<KPlayer>)+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
				object obj26 = (nint)0 & (nint)1;
				if (obj26 != null)
				{
					goto IL_0489;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
				object obj27 = (nint)0 & (nint)1;
				bool flag14 = obj27 == null;
				object obj28 = !flag14;
				if (obj28 != null)
				{
					goto IL_0489;
				}
			}
			_ = 1;
			num11 = (nint)kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v119 (Il2CppClass<KPlayer>)+E4]");
			bool flag15 = (nint)0 == 0;
			object obj29 = !flag15;
			num12 = num11;
			if (obj29 != null)
			{
				goto IL_04be;
			}
			goto IL_07ab;
		}
		object obj30 = "___# Content push apply failed [{0}]: {1}" + 2664;
		nint num15;
		nint num14;
		if (((LastActionInfo)lastAction).<Action>k__BackingField == (string)obj30)
		{
			nint num13 = (nint)kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v44 (Il2CppClass<KPlayer>)+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
				object obj31 = (nint)0 & (nint)1;
				if (obj31 != null)
				{
					goto IL_05de;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X23_v7+5E8]");
				object obj32 = (nint)0 & (nint)1;
				bool flag16 = obj32 == null;
				object obj33 = !flag16;
				if (obj33 != null)
				{
					goto IL_05de;
				}
			}
			_ = 1;
			num14 = (nint)kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v58 (Il2CppClass<KPlayer>)+E4]");
			bool flag17 = (nint)0 == 0;
			object obj34 = !flag17;
			num15 = num14;
			if (obj34 != null)
			{
				goto IL_0613;
			}
			goto IL_1185;
		}
		object obj35 = "___# Content push apply failed [{0}]: {1}" + 2680;
		if (((LastActionInfo)lastAction).<Action>k__BackingField == (string)obj35)
		{
			object obj36 = typeof(DataRelation) + 2888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj37 = default(object);
			obj37..ctor();
			_ = ((LastActionInfo)lastAction).<ActionPlayer>k__BackingField;
			_ = 6;
			replayEvent = obj37;
			goto IL_1725;
		}
		return;
		IL_04be:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v128 (Il2CppClass<KPlayer>)+B8]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v117 (Il2CppStaticFields<KPlayer>)+8]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v117 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag18 = (nint)0 == 0;
		object obj39 = !flag18;
		nint num17 = num12;
		if (obj39 != null)
		{
			goto IL_0823;
		}
		object obj40 = 0;
		num3 = (nint)obj25;
		obj11 = obj10;
		enumerator2 = enumerator;
		goto IL_1675;
		IL_0489:
		num12 = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v128 (Il2CppClass<KPlayer>)+E4]");
		bool flag19 = (nint)0 == 0;
		num11 = num12;
		if (!flag19)
		{
			goto IL_04be;
		}
		goto IL_07ab;
		IL_0a3f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v111 (Il2CppClass<KPlayer>)+B8]");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v97 (Il2CppStaticFields<KPlayer>)+8]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v97 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag20 = (nint)0 == 0;
		object obj42 = !flag20;
		nint num20;
		nint num19 = num20;
		if (obj42 != null)
		{
			goto IL_0b7b;
		}
		obj40 = 0;
		num3 = (nint)obj25;
		obj11 = obj10;
		enumerator2 = enumerator;
		goto IL_1675;
		IL_07ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num17 = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v118 (Il2CppClass<KPlayer>)+B8]");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v110 (Il2CppStaticFields<KPlayer>)+8]");
		obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v110 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag21 = (nint)0 == 0;
		obj40 = 0;
		num3 = (nint)obj25;
		obj11 = obj10;
		enumerator2 = enumerator;
		if (!flag21)
		{
			goto IL_0823;
		}
		goto IL_1675;
		IL_0d87:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v97 (Il2CppClass<KPlayer>)+B8]");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X8_v79 (Il2CppStaticFields<KPlayer>)+8]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X8_v79 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag22 = (nint)0 == 0;
		object obj44 = !flag22;
		nint num24;
		nint num23 = num24;
		if (obj44 != null)
		{
			goto IL_0ec3;
		}
		obj40 = 0;
		num3 = (nint)obj25;
		obj11 = obj10;
		enumerator2 = enumerator;
		goto IL_1675;
		IL_1057:
		object obj45 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj46 = default(object);
		obj46..ctor();
		_ = ((LastActionInfo)lastAction).<ActionPlayer>k__BackingField;
		_ = 2;
		object obj47 = obj46 + 24;
		obj47 = cardGameLastActionInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v56+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X8_v58+150]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v60+184]");
		_ = 0;
		replayEvent = obj46;
		goto IL_1725;
		IL_0f23:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v90 (Il2CppClass<KPlayer>)+B8]");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X8_v70 (Il2CppStaticFields<KPlayer>)+8]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X8_v70 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag23 = (nint)0 == 0;
		object obj49 = !flag23;
		if (obj49 != null)
		{
			goto IL_1057;
		}
		obj40 = 0;
		num3 = (nint)obj25;
		obj11 = obj10;
		enumerator2 = enumerator;
		goto IL_1675;
		IL_0beb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v104 (Il2CppClass<KPlayer>)+B8]");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v88 (Il2CppStaticFields<KPlayer>)+8]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v88 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag24 = (nint)0 == 0;
		object obj51 = !flag24;
		num24 = num19;
		if (obj51 != null)
		{
			goto IL_0d27;
		}
		obj40 = 0;
		num3 = (nint)obj25;
		obj11 = obj10;
		enumerator2 = enumerator;
		goto IL_1675;
		IL_05de:
		num15 = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v68 (Il2CppClass<KPlayer>)+E4]");
		bool flag25 = (nint)0 == 0;
		num14 = num15;
		if (!flag25)
		{
			goto IL_0613;
		}
		goto IL_1185;
		IL_1185:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num27 = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X0_v60 (Il2CppClass<KPlayer>)+B8]");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v39 (Il2CppStaticFields<KPlayer>)+8]");
		KGame kGame = (KGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v39 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag26 = (nint)0 == 0;
		obj40 = 0;
		num3 = (nint)obj30;
		obj11 = obj10;
		enumerator2 = enumerator;
		cardGameLastActionInfo = lastAction;
		if (!flag26)
		{
			goto IL_1205;
		}
		goto IL_1675;
		IL_0613:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v68 (Il2CppClass<KPlayer>)+B8]");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v45 (Il2CppStaticFields<KPlayer>)+8]");
		kGame = (KGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v45 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag27 = (nint)0 == 0;
		object obj52 = !flag27;
		if (obj52 != null)
		{
			goto IL_1205;
		}
		obj40 = 0;
		num3 = (nint)obj30;
		obj11 = obj10;
		enumerator2 = enumerator;
		cardGameLastActionInfo = lastAction;
		goto IL_1675;
		IL_1205:
		KPlayer playerByIndex = kGame.GetPlayerByIndex(((LastActionInfo)lastAction).<ActionPlayer>k__BackingField);
		bool flag28 = playerByIndex == null;
		obj40 = 0;
		num3 = ((LastActionInfo)lastAction).<ActionPlayer>k__BackingField;
		obj11 = obj10;
		enumerator2 = enumerator;
		cardGameLastActionInfo = lastAction;
		object obj64;
		object obj59;
		object obj58;
		if (!flag28)
		{
			object obj53 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2016;
			object obj54 = obj53;
			nint num30 = (nint)playerByIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X9_v3 (Il2CppClass<KPlayer>)+130]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v32+130]");
			bool flag29 = num31 < 0;
			object obj55 = !flag29;
			object obj56 = ~obj55;
			obj40 = 0;
			num3 = ((LastActionInfo)lastAction).<ActionPlayer>k__BackingField;
			obj11 = obj10;
			enumerator2 = enumerator;
			kPlayer = playerByIndex;
			cardGameLastActionInfo = lastAction;
			if (obj56 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X9_v3 (Il2CppClass<KPlayer>)+C8]");
				nint num32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v32+130]");
				object obj57 = num32 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X9_v6-8]");
				bool flag30 = 0 != (nint)obj54;
				obj40 = 0;
				num3 = ((LastActionInfo)lastAction).<ActionPlayer>k__BackingField;
				obj11 = obj10;
				enumerator2 = enumerator;
				kPlayer = playerByIndex;
				cardGameLastActionInfo = lastAction;
				if (!flag30)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v46 (KPlayer)+70]");
					bool flag31 = (nint)0 == 0;
					obj40 = 0;
					num3 = ((LastActionInfo)lastAction).<ActionPlayer>k__BackingField;
					obj11 = obj10;
					enumerator2 = enumerator;
					kPlayer = playerByIndex;
					cardGameLastActionInfo = lastAction;
					if (!flag31)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v46 (KPlayer)+70]");
						List<object>.Enumerator enumerator3 = ((List<object>)0).GetEnumerator();
						obj58 = (nint)0 + (nint)1872;
						obj59 = (nint)0 + (nint)1712;
						obj11 = typeof(DataRelation) + 1392;
						obj40 = 0;
						object obj61 = default(object);
						object obj62 = default(object);
						while (enumerator.MoveNext())
						{
							obj40 = obj59;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72A08");
							object obj60 = obj61 & 1;
							if (obj60 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								obj62..ctor();
								_ = playerByIndex.<Index>k__BackingField;
								_ = 3;
								AddReplayEvent((ReplayEvent)obj62);
							}
						}
						object obj63 = (nint)0 + (nint)1864;
						num3 = (nint)obj63;
						enumerator.Dispose();
						object obj21 = 0;
						obj64 = 3;
						enumerator2 = enumerator;
						kPlayer = playerByIndex;
						cardGameLastActionInfo = lastAction;
						goto IL_14eb;
					}
				}
			}
		}
		goto IL_1675;
		IL_0ec3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj65 = (nint)0 & (nint)1;
		if (obj65 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v90 (Il2CppClass<KPlayer>)+E4]");
			bool flag32 = (nint)0 == 0;
			nint num33 = num23;
			if (!flag32)
			{
				goto IL_0f23;
			}
		}
		else
		{
			_ = 1;
			nint num33 = (nint)kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X0_v84 (Il2CppClass<KPlayer>)+E4]");
			bool flag33 = (nint)0 == 0;
			object obj66 = !flag33;
			num23 = num33;
			if (obj66 != null)
			{
				goto IL_0f23;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num34 = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v86 (Il2CppClass<KPlayer>)+B8]");
		nint num35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X8_v65 (Il2CppStaticFields<KPlayer>)+8]");
		obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X8_v65 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag34 = (nint)0 == 0;
		obj40 = 0;
		num3 = (nint)obj25;
		obj11 = obj10;
		enumerator2 = enumerator;
		if (!flag34)
		{
			goto IL_1057;
		}
		goto IL_1675;
		IL_0d27:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj67 = (nint)0 & (nint)1;
		if (obj67 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v97 (Il2CppClass<KPlayer>)+E4]");
			bool flag35 = (nint)0 == 0;
			nint num36 = num24;
			if (!flag35)
			{
				goto IL_0d87;
			}
		}
		else
		{
			_ = 1;
			nint num36 = (nint)kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v91 (Il2CppClass<KPlayer>)+E4]");
			bool flag36 = (nint)0 == 0;
			object obj68 = !flag36;
			num24 = num36;
			if (obj68 != null)
			{
				goto IL_0d87;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num23 = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v90 (Il2CppClass<KPlayer>)+B8]");
		nint num37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v74 (Il2CppStaticFields<KPlayer>)+8]");
		obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v74 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag37 = (nint)0 == 0;
		obj40 = 0;
		num3 = (nint)obj25;
		obj11 = obj10;
		enumerator2 = enumerator;
		if (!flag37)
		{
			goto IL_0ec3;
		}
		goto IL_1675;
		IL_0b7b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v54+180]");
		obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj69 = (nint)0 & (nint)1;
		if (obj69 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v104 (Il2CppClass<KPlayer>)+E4]");
			bool flag38 = (nint)0 == 0;
			nint num38 = num19;
			if (!flag38)
			{
				goto IL_0beb;
			}
		}
		else
		{
			_ = 1;
			nint num38 = (nint)kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X0_v98 (Il2CppClass<KPlayer>)+E4]");
			bool flag39 = (nint)0 == 0;
			object obj70 = !flag39;
			num19 = num38;
			if (obj70 != null)
			{
				goto IL_0beb;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num24 = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v97 (Il2CppClass<KPlayer>)+B8]");
		nint num39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v83 (Il2CppStaticFields<KPlayer>)+8]");
		obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v83 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag40 = (nint)0 == 0;
		obj40 = 0;
		num3 = (nint)obj25;
		obj11 = obj10;
		enumerator2 = enumerator;
		if (!flag40)
		{
			goto IL_0d27;
		}
		goto IL_1675;
		IL_09cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v52+17C]");
		obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj71 = (nint)0 & (nint)1;
		if (obj71 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v111 (Il2CppClass<KPlayer>)+E4]");
			bool flag41 = (nint)0 == 0;
			nint num40 = num20;
			if (!flag41)
			{
				goto IL_0a3f;
			}
		}
		else
		{
			_ = 1;
			nint num40 = (nint)kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v105 (Il2CppClass<KPlayer>)+E4]");
			bool flag42 = (nint)0 == 0;
			object obj72 = !flag42;
			num20 = num40;
			if (obj72 != null)
			{
				goto IL_0a3f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num19 = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v104 (Il2CppClass<KPlayer>)+B8]");
		nint num41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v92 (Il2CppStaticFields<KPlayer>)+8]");
		obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v92 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag43 = (nint)0 == 0;
		obj40 = 0;
		num3 = (nint)obj25;
		obj11 = obj10;
		enumerator2 = enumerator;
		if (!flag43)
		{
			goto IL_0b7b;
		}
		goto IL_1675;
		IL_0893:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v118 (Il2CppClass<KPlayer>)+B8]");
		nint num42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v106 (Il2CppStaticFields<KPlayer>)+8]");
		object obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v106 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag44 = (nint)0 == 0;
		object obj74 = !flag44;
		num20 = num17;
		if (obj74 != null)
		{
			goto IL_09cf;
		}
		obj40 = 0;
		num3 = (nint)obj25;
		obj11 = obj10;
		enumerator2 = enumerator;
		goto IL_1675;
		IL_0823:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v50+178]");
		obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj75 = (nint)0 & (nint)1;
		if (obj75 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v118 (Il2CppClass<KPlayer>)+E4]");
			bool flag45 = (nint)0 == 0;
			nint num43 = num17;
			if (!flag45)
			{
				goto IL_0893;
			}
		}
		else
		{
			_ = 1;
			nint num43 = (nint)kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v112 (Il2CppClass<KPlayer>)+E4]");
			bool flag46 = (nint)0 == 0;
			object obj76 = !flag46;
			num17 = num43;
			if (obj76 != null)
			{
				goto IL_0893;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num20 = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v111 (Il2CppClass<KPlayer>)+B8]");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v101 (Il2CppStaticFields<KPlayer>)+8]");
		obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v101 (Il2CppStaticFields<KPlayer>)+8]");
		bool flag47 = (nint)0 == 0;
		obj40 = 0;
		num3 = (nint)obj25;
		obj11 = obj10;
		enumerator2 = enumerator;
		if (!flag47)
		{
			goto IL_09cf;
		}
		goto IL_1675;
	}

	private void OnGiftSent(GiftNotification giftNotification)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253548]");
		_ = 0;
		_ = giftNotification.<SenderId>k__BackingField;
		_ = giftNotification.<ItemId>k__BackingField;
		object obj3 = obj2 + 40;
		obj3 = giftNotification.<Recipients>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AddReplayEvent((ReplayEvent)obj2);
	}

	private void OnSawa(SawaInfo sawaInfo)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2800;
		int sawaPlayer = sawaInfo.SawaPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 5;
		AddReplayEvent((ReplayEvent)obj2);
	}

	private void OnKasho(KashoInfo kashoInfo)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1192;
		int kashoPlayer = kashoInfo.KashoPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 16;
		AddReplayEvent((ReplayEvent)obj2);
	}

	private unsafe void OnCheating(CheatingInfo cheatingInfo)
	{
		//IL_014c: Expected O, but got I
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0186: Expected O, but got I4
		//IL_018e: Expected O, but got Ref
		//IL_0233: Expected O, but got Ref
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0297: Expected I4, but got O
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01da: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_008b: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_00e3: Expected O, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_011d: Expected O, but got I4
		//IL_0125: Expected O, but got Ref
		//IL_012d: Expected O, but got Ref
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		object obj9;
		if (cheatingInfo.IsFirstPhase)
		{
			KPlayer <CurrentCatcher>k__BackingField = cheatingInfo.<CurrentCatcher>k__BackingField;
			_catcherIndex = <CurrentCatcher>k__BackingField.<Index>k__BackingField;
			object obj = "utf-32" + 1696;
			bool flag = cheatingInfo.<CatchCheatMode>k__BackingField == (string)obj;
			bool flag2 = !flag;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				object obj3 = "utf-32" + 1704;
				if (!(cheatingInfo.<CatchCheatMode>k__BackingField == (string)obj3))
				{
					return;
				}
			}
			object obj4 = (nint)0 + (nint)1720;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72A08");
			object obj7 = default(object);
			object obj6 = obj7 & 1;
			bool flag3 = obj6 == null;
			object obj8 = !flag3;
			object obj10 = default(object);
			obj9 = (object)(&obj10);
			object obj11 = (object)(&obj10);
			if (obj8 == null)
			{
				return;
			}
		}
		else
		{
			object obj12 = (nint)0 + (nint)1720;
			object obj5 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72A08");
			object obj14 = default(object);
			object obj13 = obj14 & 1;
			bool flag4 = obj13 == null;
			object obj15 = !flag4;
			object obj16 = default(object);
			object obj11 = (object)(&obj16);
			if (obj15 == null)
			{
				object obj17 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v14+E4]");
				bool flag5 = (nint)0 == 0;
				object obj19 = !flag5;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = StringsExtensions.IsNullOrEmpty(cheatingInfo.<CatchCheatMode>k__BackingField);
				bool flag7 = !flag6;
				obj11 = 0;
				if (flag7)
				{
					return;
				}
			}
			obj9 = (object)(&obj16);
		}
		object obj20 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CatchCheatEvent catchCheatEvent = default(CatchCheatEvent);
		catchCheatEvent..ctor(_catcherIndex, (CheatingOption)obj9, cheatingInfo.<WrongCard>k__BackingField, cheatingInfo.<AllowedCard>k__BackingField, cheatingInfo.<CardsInHands>k__BackingField, cheatingInfo.<Eatings>k__BackingField, cheatingInfo.<Correct>k__BackingField);
		AddReplayEvent(catchCheatEvent);
	}

	private void OnPublicMessage(ChatMessageData chatMessageData)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_019f: Expected O, but got I
		//IL_01b9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_022f: Expected O, but got I
		//IL_023f: Expected O, but got I
		//IL_0261: Expected O, but got I4
		//IL_01f7: Expected O, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00be: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				goto IL_0079;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_0079;
			}
		}
		_ = 1;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v26+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		object obj8 = obj6;
		if (obj7 != null)
		{
			goto IL_00ae;
		}
		goto IL_020d;
		IL_00ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v26+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v14+8]");
		KGame kGame = (KGame)0;
		goto IL_00d3;
		IL_00d3:
		object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 848;
		int playerIndexByUserDbId = kGame.GetPlayerIndexByUserDbId(chatMessageData.<UserId>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = default(object);
		obj11..ctor();
		_ = 8;
		object obj12 = obj11 + 24;
		obj12 = chatMessageData.<UserId>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj13 = obj11 + 32;
		obj13 = chatMessageData.<Message>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AddReplayEvent((ReplayEvent)obj11);
		return;
		IL_020d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v7+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v6+8]");
		kGame = (KGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v6+8]");
		bool flag3 = (nint)0 == 0;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00d3;
		IL_0079:
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v26+E4]");
		bool flag4 = (nint)0 == 0;
		obj8 = obj6;
		if (!flag4)
		{
			goto IL_00ae;
		}
		goto IL_020d;
	}

	private void OnRoundEnd()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_018f: Expected O, but got I
		//IL_01a9: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_021f: Expected O, but got I
		//IL_022f: Expected O, but got I
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_026f: Expected I, but got O
		//IL_0298: Expected O, but got I4
		//IL_02cc: Expected O, but got I
		//IL_0318: Expected O, but got I4
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_034a: Expected I, but got O
		//IL_0373: Expected O, but got I4
		//IL_03a7: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E816B]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v25+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_03ce:
		object obj7 = typeof(DataRelation) + 3208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = default(object);
		obj8..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253538]");
		_ = 0;
		object obj9 = obj8 + 24;
		ICardGameRoundScore lastCardGameRoundScore;
		obj9 = lastCardGameRoundScore;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AddReplayEvent((ReplayEvent)obj8);
		return;
		IL_0234:
		object obj11;
		object obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ X8_v6+178] (should have been resolved before IL gen)");
		object obj12 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2064;
		object obj13 = obj12;
		CardGameScores cardGameScores = default(CardGameScores);
		nint num = (nint)cardGameScores;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v9 (Il2CppClass<CardGameScores>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X1_v5+130]");
		bool flag3 = num2 < 0;
		object obj14 = !flag3;
		object obj15 = ~obj14;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v9 (Il2CppClass<CardGameScores>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X1_v5+130]");
			object obj16 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v11-8]");
			if (0 == (nint)obj13)
			{
				lastCardGameRoundScore = cardGameScores.LastCardGameRoundScore;
				bool flag4 = lastCardGameRoundScore == null;
				object obj17 = 0;
				if (flag4)
				{
					goto IL_03ce;
				}
				object obj18 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2056;
				obj17 = obj18;
				nint num4 = (nint)lastCardGameRoundScore;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v19 (Il2CppClass<ICardGameRoundScore>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X1_v7+130]");
				bool flag5 = num5 < 0;
				object obj19 = !flag5;
				object obj20 = ~obj19;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v19 (Il2CppClass<ICardGameRoundScore>)+C8]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X1_v7+130]");
					object obj21 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v21-8]");
					if (0 == (nint)obj17)
					{
						goto IL_03ce;
					}
				}
			}
		}
		throw new InvalidCastException();
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v40+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v33+8]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v33+8]");
		bool flag6 = (nint)0 == 0;
		object obj23 = !flag6;
		if (obj23 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0234;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj24 = (nint)0 & (nint)1;
		if (obj24 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_01b7:
		_ = 1;
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v40+E4]");
		bool flag7 = (nint)0 == 0;
		object obj26 = !flag7;
		object obj27 = obj25;
		if (obj26 != null)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
		IL_00a7:
		obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v40+E4]");
		bool flag8 = (nint)0 == 0;
		obj27 = obj25;
		if (!flag8)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
		IL_01fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v18+B8]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v24+8]");
		obj11 = 0;
		goto IL_0234;
	}

	private void OnGameEnd(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0149: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01cf: Expected O, but got I4
		//IL_0177: Expected O, but got I
		//IL_0191: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_0207: Expected O, but got I
		//IL_036b: Expected O, but got I
		//IL_0385: Expected O, but got I4
		//IL_0274: Expected O, but got I
		//IL_03fb: Expected O, but got I
		//IL_0411: Expected O, but got I
		//IL_0433: Expected O, but got I4
		//IL_03c3: Expected O, but got I4
		//IL_0321: Expected O, but got I
		//IL_0331: Expected O, but got I
		//IL_0341: Expected O, but got I
		//IL_02d6: Expected O, but got I
		//IL_02ec: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E816C]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v26+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_019f;
		IL_0393:
		_ = 1;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		object obj9 = obj7;
		if (obj8 != null)
		{
			goto IL_02c6;
		}
		goto IL_03d9;
		IL_034b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EE]");
		object obj10 = (nint)0 & (nint)1;
		bool flag4 = obj10 == null;
		object obj11 = !flag4;
		if (obj11 != null)
		{
			goto IL_0291;
		}
		goto IL_0393;
		IL_0311:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v12+18]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v12+40]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v12+28]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v132 @ X2_v1 (should have been resolved before IL gen)");
		goto IL_034b;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
		object obj15 = (nint)0 & (nint)1;
		if (obj15 != null)
		{
			goto IL_00a7;
		}
		goto IL_019f;
		IL_019f:
		_ = 1;
		GameReplayManager gameReplayManager = (GameReplayManager)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v2 (Features.GameReplay.GameReplayManager)+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		GameReplayManager gameReplayManager2 = gameReplayManager;
		if (obj16 != null)
		{
			goto IL_00dc;
		}
		goto IL_01e5;
		IL_00a7:
		gameReplayManager = (GameReplayManager)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v2 (Features.GameReplay.GameReplayManager)+E4]");
		bool flag6 = (nint)0 == 0;
		gameReplayManager2 = gameReplayManager;
		if (!flag6)
		{
			goto IL_00dc;
		}
		goto IL_01e5;
		IL_01e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		gameReplayManager = (GameReplayManager)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v2 (Features.GameReplay.GameReplayManager)+B8]");
		object obj17 = 0;
		if (obj17 != null)
		{
			goto IL_0224;
		}
		return;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v2 (Features.GameReplay.GameReplayManager)+B8]");
		object obj18 = 0;
		bool flag7 = obj18 == null;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			return;
		}
		goto IL_0224;
		IL_0224:
		gameReplayManager.AddDealtCardEvent(data);
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v3+E4]");
		if ((nint)0 == 0)
		{
			goto IL_034b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EE]");
		object obj21 = (nint)0 & (nint)1;
		if (obj21 != null)
		{
			goto IL_0291;
		}
		goto IL_0393;
		IL_03d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v6+B8]");
		object obj23 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v6+48]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v6+48]");
		bool flag8 = (nint)0 == 0;
		object obj25 = !flag8;
		if (obj25 == null)
		{
			return;
		}
		goto IL_0311;
		IL_0291:
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v15+E4]");
		bool flag9 = (nint)0 == 0;
		obj9 = obj7;
		if (!flag9)
		{
			goto IL_02c6;
		}
		goto IL_03d9;
		IL_02c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v15+B8]");
		object obj26 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v14+48]");
		obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v14+48]");
		if ((nint)0 != 0)
		{
			goto IL_0311;
		}
	}

	private void AddDealtCardEvent(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_0165: Expected I, but got O
		//IL_0175: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_0227: Expected O, but got I4
		//IL_1458: Expected O, but got I
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_02a1: Expected O, but got I
		//IL_01b0: Expected O, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0353: Expected O, but got I4
		//IL_148c: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_03d6: Expected O, but got I
		//IL_02dc: Expected O, but got I
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0488: Expected O, but got I4
		//IL_14c0: Expected O, but got I
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_0502: Expected O, but got I
		//IL_0411: Expected O, but got I
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_05b4: Expected O, but got I4
		//IL_14f4: Expected O, but got I
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0637: Expected O, but got I
		//IL_053d: Expected O, but got I
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_06f9: Expected O, but got I4
		//IL_1528: Expected O, but got I
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0788: Expected O, but got I
		//IL_0672: Expected O, but got I
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		//IL_155c: Expected O, but got I
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected O, but got Unknown
		//IL_15cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d2: Expected O, but got Unknown
		//IL_07c3: Expected O, but got I
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected O, but got Unknown
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected O, but got Unknown
		//IL_0927: Expected O, but got I
		//IL_0941: Expected O, but got I4
		//IL_1590: Expected O, but got I
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_0870: Expected O, but got I
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected O, but got Unknown
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Expected O, but got Unknown
		//IL_09b7: Expected O, but got I
		//IL_097f: Expected O, but got I4
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected O, but got Unknown
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e4: Expected O, but got Unknown
		//IL_09d4: Expected O, but got I
		//IL_08d2: Expected O, but got I
		//IL_08f4: Expected O, but got I4
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Expected O, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fd: Expected O, but got Unknown
		//IL_0a1d: Expected O, but got I
		//IL_0bac: Expected O, but got I
		//IL_0a82: Expected O, but got I
		//IL_0c5e: Expected O, but got I4
		//IL_160f: Expected O, but got I
		//IL_0cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Expected O, but got Unknown
		//IL_0cd8: Expected O, but got I
		//IL_0be7: Expected O, but got I
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2f: Expected O, but got Unknown
		//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Expected O, but got Unknown
		//IL_1643: Expected O, but got I
		//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Expected O, but got Unknown
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa3: Expected O, but got Unknown
		//IL_0ef2: Expected O, but got I
		//IL_0f14: Expected O, but got I4
		//IL_0f1d: Expected O, but got I4
		//IL_0d13: Expected O, but got I
		//IL_0c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7f: Expected O, but got Unknown
		//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0f95: Expected O, but got I
		//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dac: Expected O, but got Unknown
		//IL_0dc4: Expected O, but got I
		//IL_1677: Expected O, but got I
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected O, but got Unknown
		//IL_0c03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Expected O, but got Unknown
		//IL_1766: Expected O, but got I
		//IL_0f3c: Expected O, but got I4
		//IL_0e60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e65: Expected O, but got Unknown
		//IL_0e7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e80: Expected O, but got Unknown
		//IL_0ea4: Expected O, but got I4
		//IL_0ebc: Expected O, but got I
		//IL_110b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1110: Expected O, but got Unknown
		//IL_1126: Unknown result type (might be due to invalid IL or missing references)
		//IL_112b: Expected O, but got Unknown
		//IL_113b: Expected O, but got I
		//IL_115f: Expected O, but got I4
		//IL_117f: Expected O, but got I
		//IL_1010: Expected O, but got I
		//IL_1701: Expected O, but got I
		//IL_0dff: Expected O, but got I
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d26: Expected O, but got Unknown
		//IL_0d2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d34: Expected O, but got Unknown
		//IL_106f: Expected O, but got I
		//IL_0fa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa8: Expected O, but got Unknown
		//IL_0fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb6: Expected O, but got Unknown
		//IL_119e: Expected O, but got I4
		//IL_16ab: Expected O, but got I
		//IL_1814: Unknown result type (might be due to invalid IL or missing references)
		//IL_1819: Expected O, but got Unknown
		//IL_1842: Unknown result type (might be due to invalid IL or missing references)
		//IL_1847: Expected O, but got Unknown
		//IL_0f52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f57: Expected O, but got Unknown
		//IL_0f6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f72: Expected O, but got Unknown
		//IL_17ce: Expected O, but got I
		//IL_10aa: Expected O, but got I
		//IL_11e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e7: Expected O, but got Unknown
		//IL_0e0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e12: Expected O, but got Unknown
		//IL_0e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e20: Expected O, but got Unknown
		//IL_179a: Expected O, but got I
		//IL_12f3: Expected O, but got I
		//IL_130d: Expected O, but got I4
		//IL_11ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b1: Expected O, but got Unknown
		//IL_11c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cc: Expected O, but got Unknown
		//IL_123c: Expected O, but got I
		//IL_10b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bd: Expected O, but got Unknown
		//IL_10c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cb: Expected O, but got Unknown
		//IL_1383: Expected O, but got I
		//IL_134b: Expected O, but got I4
		//IL_13af: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b4: Expected O, but got Unknown
		//IL_13e2: Expected O, but got I
		//IL_1404: Expected O, but got I4
		//IL_129e: Expected O, but got I
		//IL_12c0: Expected O, but got I4
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "getSecondRescanTask" + 2048;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		object obj5 = default(object);
		object obj6 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X10_v84-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X10_v84-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj6 = obj4 + 16;
			obj3--;
			bool flag = (nint)obj3 != 1;
			obj4 = obj6;
			if (flag)
			{
				continue;
			}
			goto IL_00c4;
		}
		object obj7 = obj4 + 1;
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v452 @ X0_v144] (should have been resolved before IL gen)");
		object obj10 = default(object);
		bool flag2 = obj10 == null;
		obj6 = obj4;
		if (!flag2)
		{
			goto IL_015d;
		}
		return;
		IL_080c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		int num2 = 4;
		goto IL_15b4;
		IL_15b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v954 @ X0_v11] (should have been resolved before IL gen)");
		object obj11 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				goto IL_088d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
			object obj14 = (nint)0 & (nint)1;
			bool flag3 = obj14 == null;
			object obj15 = !flag3;
			if (obj15 != null)
			{
				goto IL_088d;
			}
		}
		_ = 1;
		object obj16 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v99+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		object obj18 = obj16;
		if (obj17 != null)
		{
			goto IL_08c2;
		}
		goto IL_0995;
		IL_128e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1625 @ X0_v38+B8]");
		object obj19 = 0;
		GameReplay gameReplay = (GameReplay)obj19;
		bool flag5 = obj19 == null;
		object obj20 = !flag5;
		if (obj20 != null)
		{
			goto IL_1390;
		}
		goto IL_1441;
		IL_16cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1440 @ X0_v61] (should have been resolved before IL gen)");
		object obj21 = obj;
		object obj23;
		object obj22 = obj23;
		object obj25 = default(object);
		object obj24 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1353 @ X8_v59+12E]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1353 @ X8_v59+12E]");
		bool flag6 = (nint)0 == 0;
		object obj28 = default(object);
		object obj27 = obj28;
		object obj29 = obj5;
		object obj30 = obj23;
		object obj31 = obj28;
		object obj32 = obj6;
		object obj33 = obj;
		if (!flag6)
		{
			goto IL_0f7f;
		}
		goto IL_0ff6;
		IL_00c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v349 @ X0_v141] (should have been resolved before IL gen)");
		object obj34 = default(object);
		bool flag7 = obj34 == null;
		object obj35 = !flag7;
		if (obj35 == null)
		{
			return;
		}
		goto IL_015d;
		IL_015d:
		nint num3 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01f9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj37 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X10_v79-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X10_v79-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj6 = obj37 + 16;
			obj36--;
			bool flag8 = (nint)obj36 != 1;
			obj37 = obj6;
			if (flag8)
			{
				continue;
			}
			goto IL_01f9;
		}
		object obj38 = obj37 + 29;
		object obj39 = num3 + obj38;
		object obj40 = obj39 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v647 @ X0_v137] (should have been resolved before IL gen)");
		obj6 = obj37;
		goto IL_027a;
		IL_0d9d:
		object obj41 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 232;
		object obj42 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1261 @ X8_v67+12E]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1261 @ X8_v67+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0e48;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1261 @ X8_v67+B0]");
		object obj44 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1367 @ X10_v33-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1367 @ X10_v33-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj6 = obj44 + 16;
			obj43--;
			bool flag9 = (nint)obj43 != 1;
			obj44 = obj6;
			if (flag9)
			{
				continue;
			}
			goto IL_0e48;
		}
		object obj45 = obj44 + 24;
		object obj46 = obj42 + obj45;
		object obj47 = obj46 + 312;
		obj6 = obj44;
		goto IL_16cf;
		IL_0e48:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_16cf;
		IL_088d:
		obj16 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v99+E4]");
		bool flag10 = (nint)0 == 0;
		obj18 = obj16;
		if (!flag10)
		{
			goto IL_08c2;
		}
		goto IL_0995;
		IL_10f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_17be;
		IL_01f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v624 @ X0_v134] (should have been resolved before IL gen)");
		object obj48 = default(object);
		bool flag11 = obj48 == null;
		object obj49 = !flag11;
		if (obj49 != null)
		{
			goto IL_027a;
		}
		goto IL_1441;
		IL_027a:
		object obj50 = "getSecondRescanTask" + 1840;
		object obj51 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v9+12E]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v9+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0325;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v9+B0]");
		object obj53 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X10_v74-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X10_v74-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj6 = obj53 + 16;
			obj52--;
			bool flag12 = (nint)obj52 != 1;
			obj53 = obj6;
			if (flag12)
			{
				continue;
			}
			goto IL_0325;
		}
		object obj54 = obj53 + 1;
		object obj55 = obj51 + obj54;
		object obj56 = obj55 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v708 @ X0_v130] (should have been resolved before IL gen)");
		object obj57 = default(object);
		bool flag13 = obj57 == null;
		obj6 = obj53;
		if (!flag13)
		{
			goto IL_03be;
		}
		return;
		IL_0995:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj58 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v92+B8]");
		object obj59 = 0;
		object obj60 = obj59;
		goto IL_09c4;
		IL_08c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v99+B8]");
		object obj61 = 0;
		obj60 = obj61;
		bool flag14 = obj61 == null;
		object obj62 = !flag14;
		if (obj62 != null)
		{
			goto IL_09c4;
		}
		goto IL_1441;
		IL_09c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X8_v21+98]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v22+18]");
		object obj65 = default(object);
		object obj64 = obj65 - 0;
		obj23 = "fetch_products" + 24;
		object obj67;
		object obj66 = obj67;
		object obj69 = default(object);
		object obj68 = obj69;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v80+12E]");
		object obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v80+12E]");
		bool flag15 = (nint)0 == 0;
		int num4 = 0;
		int num6 = default(int);
		int num5 = num6;
		object obj71 = obj64;
		object obj72 = obj67;
		int num7 = 0;
		if (!flag15)
		{
			goto IL_0a6c;
		}
		goto IL_0aec;
		IL_17be:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X0_v44+8]");
		object obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1590 @ X0_v44] (should have been resolved before IL gen)");
		obj5 = obj29;
		object obj75 = default(object);
		object obj74 = obj75;
		obj27 = obj31;
		obj6 = obj32;
		object obj76 = obj23;
		goto IL_1805;
		IL_0325:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v689 @ X0_v127] (should have been resolved before IL gen)");
		object obj77 = default(object);
		bool flag16 = obj77 == null;
		object obj78 = !flag16;
		if (obj78 == null)
		{
			return;
		}
		goto IL_03be;
		IL_03be:
		object obj79 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v11+12E]");
		object obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v11+12E]");
		if ((nint)0 == 0)
		{
			goto IL_045a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v11+B0]");
		object obj81 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v69-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v69-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj6 = obj81 + 16;
			obj80--;
			bool flag17 = (nint)obj80 != 1;
			obj81 = obj6;
			if (flag17)
			{
				continue;
			}
			goto IL_045a;
		}
		object obj82 = obj81 + 29;
		object obj83 = obj79 + obj82;
		object obj84 = obj83 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v763 @ X0_v123] (should have been resolved before IL gen)");
		obj6 = obj81;
		goto IL_04db;
		IL_0a6c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v80+B0]");
		object obj85 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X10_v49-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X10_v49-8]");
			if (0 == (nint)obj66)
			{
				break;
			}
			obj6 = obj85 + 16;
			obj70--;
			bool flag18 = (nint)obj70 != 1;
			num5 = 0;
			obj71 = obj64;
			obj72 = obj66;
			num7 = num4;
			obj85 = obj6;
			if (flag18)
			{
				continue;
			}
			goto IL_0aec;
		}
		object obj86 = obj85 + 4;
		object obj87 = obj68 + obj86;
		object obj88 = obj87 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1089 @ X0_v87] (should have been resolved before IL gen)");
		object obj89 = default(object);
		bool flag19 = obj64 >= obj89;
		num5 = 0;
		obj71 = obj64;
		obj6 = obj85;
		num7 = num4;
		if (!flag19)
		{
			goto IL_0b94;
		}
		return;
		IL_0f7f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1353 @ X8_v59+B0]");
		obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1344 @ X10_v29-8]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1344 @ X10_v29-8]");
			if (0 == (nint)obj21)
			{
				break;
			}
			obj32 = obj6 + 16;
			obj26--;
			bool flag20 = (nint)obj26 != 1;
			obj30 = obj22;
			obj31 = obj27;
			obj33 = obj21;
			obj6 = obj32;
			if (flag20)
			{
				continue;
			}
			goto IL_0ff6;
		}
		object obj90 = obj6 + 1;
		object obj91 = obj24 + obj90;
		object obj92 = obj91 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1455 @ X0_v56+8]");
		obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1455 @ X0_v56] (should have been resolved before IL gen)");
		object obj93 = default(object);
		bool flag21 = obj93 == null;
		object obj94 = !flag21;
		obj31 = obj27;
		obj32 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1344 @ X10_v29-8]");
		obj5 = 0;
		obj76 = obj22;
		if (obj94 != null)
		{
			goto IL_1057;
		}
		goto IL_1195;
		IL_1390:
		object obj95 = default(object);
		gameReplay.AddReplayEvent((ReplayEvent)obj95, num7);
		obj64 = obj71 + 1;
		num4 = num7 + 1;
		obj66 = obj67;
		obj68 = obj69;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v80+12E]");
		obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v80+12E]");
		bool flag22 = (nint)0 == 0;
		object obj96 = !flag22;
		num2 = num7;
		if (obj96 != null)
		{
			goto IL_0a6c;
		}
		num5 = 0;
		obj71 = obj64;
		obj72 = obj67;
		num7 = num4;
		goto IL_0aec;
		IL_1805:
		object obj97 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj95..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253530]");
		_ = 0;
		object obj98 = obj95 + 24;
		obj98 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj99 = obj95 + 32;
		obj99 = obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj100 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1600 @ X0_v27+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
			object obj101 = (nint)0 & (nint)1;
			if (obj101 != null)
			{
				goto IL_1259;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
			object obj102 = (nint)0 & (nint)1;
			bool flag23 = obj102 == null;
			object obj103 = !flag23;
			if (obj103 != null)
			{
				goto IL_1259;
			}
		}
		_ = 1;
		object obj104 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1625 @ X0_v38+E4]");
		bool flag24 = (nint)0 == 0;
		object obj105 = !flag24;
		object obj106 = obj104;
		if (obj105 != null)
		{
			goto IL_128e;
		}
		goto IL_1361;
		IL_045a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v746 @ X0_v120] (should have been resolved before IL gen)");
		object obj107 = default(object);
		bool flag25 = obj107 == null;
		object obj108 = !flag25;
		if (obj108 != null)
		{
			goto IL_04db;
		}
		goto IL_1441;
		IL_04db:
		object obj109 = "placementId" + 2064;
		object obj110 = obj107;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v13+12E]");
		object obj111 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v13+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0586;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v13+B0]");
		object obj112 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X10_v64-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X10_v64-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj6 = obj112 + 16;
			obj111--;
			bool flag26 = (nint)obj111 != 1;
			obj112 = obj6;
			if (flag26)
			{
				continue;
			}
			goto IL_0586;
		}
		object obj113 = obj112 + 1;
		object obj114 = obj110 + obj113;
		object obj115 = obj114 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v819 @ X0_v116] (should have been resolved before IL gen)");
		object obj116 = default(object);
		bool flag27 = obj116 == null;
		obj6 = obj112;
		if (!flag27)
		{
			goto IL_061f;
		}
		return;
		IL_1441:
		throw new NullReferenceException();
		IL_0aec:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1062 @ X0_v83] (should have been resolved before IL gen)");
		object obj117 = default(object);
		if (obj71 >= obj117)
		{
			return;
		}
		goto IL_0b94;
		IL_0b94:
		object obj118 = obj69;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1110 @ X8_v27+12E]");
		object obj119 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1110 @ X8_v27+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0c30;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1110 @ X8_v27+B0]");
		object obj120 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X10_v43-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X10_v43-8]");
			if (0 == (nint)obj67)
			{
				break;
			}
			obj6 = obj120 + 16;
			obj119--;
			bool flag28 = (nint)obj119 != 1;
			obj120 = obj6;
			if (flag28)
			{
				continue;
			}
			goto IL_0c30;
		}
		object obj121 = obj120 + 51;
		object obj122 = obj118 + obj121;
		object obj123 = obj122 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1145 @ X0_v78] (should have been resolved before IL gen)");
		obj6 = obj120;
		goto IL_0cb1;
		IL_1057:
		object obj124 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1484 @ X8_v53+12E]");
		object obj125 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1484 @ X8_v53+12E]");
		if ((nint)0 == 0)
		{
			goto IL_10f3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1484 @ X8_v53+B0]");
		object obj126 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1572 @ X10_v19-8]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1572 @ X10_v19-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj32 = obj126 + 16;
			obj125--;
			bool flag29 = (nint)obj125 != 1;
			obj126 = obj32;
			if (flag29)
			{
				continue;
			}
			goto IL_10f3;
		}
		object obj127 = obj126 + 24;
		object obj128 = obj124 + obj127;
		object obj129 = obj128 + 312;
		obj32 = obj126;
		goto IL_17be;
		IL_0586:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v802 @ X0_v113] (should have been resolved before IL gen)");
		object obj130 = default(object);
		bool flag30 = obj130 == null;
		object obj131 = !flag30;
		if (obj131 == null)
		{
			return;
		}
		goto IL_061f;
		IL_061f:
		object obj132 = obj107;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v15+12E]");
		object obj133 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v15+12E]");
		if ((nint)0 == 0)
		{
			goto IL_06bb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v15+B0]");
		object obj134 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X10_v59-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X10_v59-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj6 = obj134 + 16;
			obj133--;
			bool flag31 = (nint)obj133 != 1;
			obj134 = obj6;
			if (flag31)
			{
				continue;
			}
			goto IL_06bb;
		}
		object obj135 = obj134 + 28;
		object obj136 = obj132 + obj135;
		object obj137 = obj136 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X0_v109+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v874 @ X0_v109] (should have been resolved before IL gen)");
		obj6 = obj134;
		goto IL_075c;
		IL_1361:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj138 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1642 @ X0_v31+B8]");
		object obj139 = 0;
		gameReplay = (GameReplay)obj139;
		goto IL_1390;
		IL_0d5c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1200 @ X0_v68] (should have been resolved before IL gen)");
		object obj140 = default(object);
		bool flag32 = obj140 == null;
		obj29 = obj5;
		obj32 = obj6;
		if (!flag32)
		{
			goto IL_0d9d;
		}
		goto IL_0eca;
		IL_0eca:
		obj21 = obj;
		obj22 = obj23;
		obj24 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1353 @ X8_v59+12E]");
		obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1353 @ X8_v59+12E]");
		bool flag33 = (nint)0 == 0;
		object obj141 = !flag33;
		obj27 = 0;
		if (obj141 != null)
		{
			goto IL_0f7f;
		}
		obj30 = obj23;
		obj31 = 0;
		obj33 = obj;
		goto IL_0ff6;
		IL_1195:
		obj74 = 0;
		goto IL_1805;
		IL_06bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v106+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v857 @ X0_v106] (should have been resolved before IL gen)");
		bool flag34 = obj69 == null;
		object obj142 = !flag34;
		if (obj142 != null)
		{
			goto IL_075c;
		}
		goto IL_1441;
		IL_075c:
		obj67 = typeof(System.IOAsyncCallback) + 960;
		object obj143 = obj69;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X8_v17+12E]");
		object obj144 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X8_v17+12E]");
		if ((nint)0 == 0)
		{
			goto IL_080c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X8_v17+B0]");
		object obj145 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X10_v54-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X10_v54-8]");
			if (0 == (nint)obj67)
			{
				break;
			}
			obj6 = obj145 + 16;
			obj144--;
			bool flag35 = (nint)obj144 != 1;
			obj145 = obj6;
			if (flag35)
			{
				continue;
			}
			goto IL_080c;
		}
		object obj146 = obj145 + 4;
		object obj147 = obj143 + obj146;
		object obj148 = obj147 + 312;
		obj6 = obj145;
		goto IL_15b4;
		IL_1259:
		obj104 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1625 @ X0_v38+E4]");
		bool flag36 = (nint)0 == 0;
		obj106 = obj104;
		if (!flag36)
		{
			goto IL_128e;
		}
		goto IL_1361;
		IL_0c30:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1128 @ X0_v75] (should have been resolved before IL gen)");
		bool flag37 = obj25 == null;
		object obj149 = !flag37;
		if (obj149 != null)
		{
			goto IL_0cb1;
		}
		goto IL_1441;
		IL_0cb1:
		object obj150 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 232;
		object obj151 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X8_v31+12E]");
		object obj152 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X8_v31+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0d5c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X8_v31+B0]");
		obj32 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1548 @ X10_v15-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1548 @ X10_v15-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj6 = obj32 + 16;
			obj152--;
			bool flag38 = (nint)obj152 != 1;
			obj32 = obj6;
			if (flag38)
			{
				continue;
			}
			goto IL_0d5c;
		}
		object obj153 = obj32 + 1;
		object obj154 = obj151 + obj153;
		object obj155 = obj154 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1232 @ X0_v71] (should have been resolved before IL gen)");
		object obj156 = default(object);
		bool flag39 = obj156 == null;
		object obj157 = !flag39;
		obj6 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1548 @ X10_v15-8]");
		obj29 = 0;
		if (obj157 != null)
		{
			goto IL_0d9d;
		}
		goto IL_0eca;
		IL_0ff6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1411 @ X0_v52+8]");
		obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1411 @ X0_v52] (should have been resolved before IL gen)");
		object obj158 = default(object);
		bool flag40 = obj158 == null;
		obj5 = obj29;
		obj27 = obj31;
		obj6 = obj32;
		obj76 = obj30;
		if (!flag40)
		{
			goto IL_1057;
		}
		goto IL_1195;
	}

	private void OnCardGameEnd(CardGameEndScores cardGameEndScores)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_0183: Expected O, but got I4
		//IL_0191: Expected O, but got I4
		//IL_00a6: Expected O, but got I
		//IL_0074: Expected O, but got I4
		//IL_0082: Expected O, but got I4
		//IL_021f: Expected O, but got I4
		//IL_01bf: Expected O, but got I
		//IL_01d9: Expected O, but got I4
		//IL_0118: Expected O, but got I
		//IL_0132: Expected O, but got I4
		//IL_025f: Expected O, but got I
		//IL_039f: Expected O, but got I
		//IL_03b9: Expected O, but got I4
		//IL_02bf: Expected O, but got I
		//IL_042f: Expected O, but got I
		//IL_043f: Expected O, but got I
		//IL_046f: Expected O, but got I4
		//IL_03f7: Expected O, but got I4
		//IL_0321: Expected O, but got I
		//IL_0331: Expected O, but got I
		//IL_0353: Expected O, but got I4
		//IL_0621: Expected O, but got I4
		//IL_037a: Expected O, but got I4
		//IL_04bc: Expected O, but got I4
		//IL_04ce: Expected I4, but got O
		//IL_04f8: Expected O, but got I4
		//IL_063c: Expected O, but got I4
		//IL_0673: Expected O, but got I4
		//IL_0565: Expected O, but got I
		//IL_06da: Expected O, but got I4
		//IL_0698: Expected O, but got I4
		//IL_05c7: Expected O, but got I
		//IL_05e1: Expected O, but got I4
		//IL_0762: Expected O, but got I
		//IL_0712: Expected O, but got I
		//IL_0839: Expected O, but got I4
		//IL_07bc: Expected O, but got I
		//IL_07cc: Expected O, but got I
		//IL_07ee: Expected O, but got I4
		//IL_0871: Expected O, but got I
		//IL_0881: Expected O, but got I
		//IL_08f2: Expected O, but got I
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected O, but got Unknown
		//IL_0912: Expected O, but got I
		//IL_091e: Expected O, but got I
		//IL_0942: Expected I, but got O
		//IL_0950: Expected I, but got O
		//IL_09af: Expected O, but got I4
		//IL_09b8: Expected O, but got I4
		//IL_0988: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E816E]");
		object obj2 = (nint)0 & (nint)1;
		KPlayer kPlayer;
		KPlayer kPlayer2;
		List<object>.Enumerator enumerator;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v77+E4]");
			bool flag = (nint)0 == 0;
			kPlayer = null;
			enumerator = (List<object>.Enumerator)0;
			kPlayer2 = null;
			enumerator = (List<object>.Enumerator)0;
			if (!flag)
			{
				goto IL_0090;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v77+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			kPlayer = null;
			enumerator = (List<object>.Enumerator)0;
			kPlayer2 = null;
			enumerator = (List<object>.Enumerator)0;
			if (obj4 != null)
			{
				goto IL_0090;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
		object obj5 = (nint)0 & (nint)1;
		bool flag3 = obj5 == null;
		object obj6 = !flag3;
		kPlayer = kPlayer2;
		if (obj6 != null)
		{
			goto IL_00cb;
		}
		goto IL_01ef;
		IL_0a50:
		NullReferenceException ex = new NullReferenceException();
		object obj7;
		bool flag4 = (nint)obj7 != 1;
		NullReferenceException ex2 = ex;
		(int, int) tuple;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj7 = tuple;
			enumerator.Dispose();
			object obj8 = default(object);
			if (obj8 == null)
			{
				return;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			object obj9 = obj8;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BE88");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_08ae:
		KGame kGame;
		List<KPlayer> players = kGame.Players;
		bool flag5 = players == null;
		IntPtr intPtr = default(IntPtr);
		nint num = intPtr;
		obj7 = null;
		if (!flag5)
		{
			object obj10 = (nint)0 + (nint)2944;
			object obj11 = typeof(SqlSingle[]) + 2376;
			object obj12 = (nint)0 + (nint)2192;
			tuple = ((int, int))((nint)0 + (nint)2936);
			List<object>.Enumerator enumerator2 = ((List<object>)(object)players).GetEnumerator();
			Action action = default(Action);
			object obj13;
			while (true)
			{
				if (enumerator.MoveNext())
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					num = (nint)obj12;
					action..ctor(this, (IntPtr)obj12);
					if (kPlayer == null)
					{
						break;
					}
					kPlayer.OnDidLastAction -= action;
					obj13 = 0;
					continue;
				}
				enumerator.Dispose();
				return;
			}
			NullReferenceException ex4 = new NullReferenceException();
			obj13 = 0;
			object obj9 = 0;
			obj7 = this;
		}
		goto IL_0a50;
		IL_0737:
		_isFirstRound = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj14 = (nint)0 & (nint)1;
		object obj16;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v40+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = obj16;
			if (!flag6)
			{
				goto IL_07ac;
			}
		}
		else
		{
			_ = 1;
			obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v40+E4]");
			bool flag7 = (nint)0 == 0;
			object obj17 = !flag7;
			object obj15 = obj16;
			if (obj17 != null)
			{
				goto IL_07ac;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v35+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v17+8]");
		kGame = (KGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v17+8]");
		bool flag8 = (nint)0 == 0;
		num = intPtr;
		if (!flag8)
		{
			goto IL_08ae;
		}
		goto IL_0a50;
		IL_0090:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
		object obj20 = (nint)0 & (nint)1;
		bool flag9 = obj20 == null;
		kPlayer2 = kPlayer;
		if (!flag9)
		{
			goto IL_00cb;
		}
		goto IL_01ef;
		IL_01ef:
		_ = 1;
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v2+E4]");
		bool flag10 = (nint)0 == 0;
		object obj22 = !flag10;
		kPlayer = kPlayer2;
		object obj23 = obj21;
		if (obj22 != null)
		{
			goto IL_0108;
		}
		goto IL_023d;
		IL_00cb:
		obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v2+E4]");
		bool flag11 = (nint)0 == 0;
		obj23 = obj21;
		kPlayer2 = kPlayer;
		if (!flag11)
		{
			goto IL_0108;
		}
		goto IL_023d;
		IL_023d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v2+B8]");
		object obj24 = 0;
		bool flag12 = obj24 == null;
		kPlayer = kPlayer2;
		if (!flag12)
		{
			goto IL_0284;
		}
		return;
		IL_0108:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v2+B8]");
		object obj25 = 0;
		bool flag13 = obj25 == null;
		object obj26 = !flag13;
		if (obj26 == null)
		{
			return;
		}
		goto IL_0284;
		IL_0284:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
			object obj27 = (nint)0 & (nint)1;
			if (obj27 != null)
			{
				goto IL_02dc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
			object obj28 = (nint)0 & (nint)1;
			bool flag14 = obj28 == null;
			object obj29 = !flag14;
			if (obj29 != null)
			{
				goto IL_02dc;
			}
		}
		_ = 1;
		object obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v65+E4]");
		bool flag15 = (nint)0 == 0;
		object obj31 = !flag15;
		object obj32 = obj30;
		if (obj31 != null)
		{
			goto IL_0311;
		}
		goto IL_040d;
		IL_07ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v40+B8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v21+8]");
		kGame = (KGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v21+8]");
		bool flag16 = (nint)0 == 0;
		object obj34 = !flag16;
		if (obj34 != null)
		{
			goto IL_08ae;
		}
		num = intPtr;
		goto IL_0a50;
		IL_054f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
		object obj35 = (nint)0 & (nint)1;
		if (obj35 != null)
		{
			obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v40+E4]");
			bool flag17 = (nint)0 == 0;
			object obj36 = obj16;
			if (!flag17)
			{
				goto IL_05b7;
			}
		}
		else
		{
			_ = 1;
			obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v40+E4]");
			bool flag18 = (nint)0 == 0;
			object obj37 = !flag18;
			object obj36 = obj16;
			if (obj37 != null)
			{
				goto IL_05b7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v40+B8]");
		object obj38 = 0;
		bool flag19 = obj38 == null;
		num = intPtr;
		if (!flag19)
		{
			goto IL_0737;
		}
		goto IL_0a50;
		IL_0528:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Room room;
		obj7 = room;
		(int, int) tuple2;
		tuple = tuple2;
		int num3;
		int num2 = num3;
		goto IL_054f;
		IL_02dc:
		obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v65+E4]");
		bool flag20 = (nint)0 == 0;
		obj32 = obj30;
		if (!flag20)
		{
			goto IL_0311;
		}
		goto IL_040d;
		IL_040d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj39 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v57+B8]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v35+8]");
		KGame kGame2 = (KGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v35+8]");
		bool flag21 = (nint)0 == 0;
		num = intPtr;
		obj7 = cardGameEndScores;
		tuple = ((int, int))152993792;
		if (!flag21)
		{
			goto IL_047d;
		}
		goto IL_0a50;
		IL_0311:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v65+B8]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v41+8]");
		kGame2 = (KGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v41+8]");
		bool flag22 = (nint)0 == 0;
		object obj42 = !flag22;
		if (obj42 != null)
		{
			goto IL_047d;
		}
		num = intPtr;
		obj7 = cardGameEndScores;
		tuple = ((int, int))152993792;
		goto IL_0a50;
		IL_047d:
		bool isTutorial = kGame2.IsTutorial;
		if (isTutorial)
		{
			room = <Room>k__BackingField;
			(int, int) scores = ((GameReplayManager)isTutorial).GetScores(<Room>k__BackingField);
			num3 = (object)scores >> 32;
			object obj43 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v51+E4]");
			bool flag23 = (nint)0 == 0;
			object obj44 = !flag23;
			tuple2 = scores;
			obj7 = <Room>k__BackingField;
			tuple = scores;
			num2 = num3;
			if (obj44 == null)
			{
				goto IL_0528;
			}
		}
		else
		{
			bool flag24 = cardGameEndScores == null;
			num = intPtr;
			obj7 = null;
			tuple = ((int, int))152993792;
			if (flag24)
			{
				goto IL_0a50;
			}
			tuple = ((int, int))cardGameEndScores.<Team1Score>k__BackingField;
			num2 = cardGameEndScores.<Team2Score>k__BackingField;
			object obj43 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v51+E4]");
			bool flag25 = (nint)0 == 0;
			object obj45 = !flag25;
			obj7 = null;
			if (obj45 == null)
			{
				room = null;
				tuple2 = ((int, int))cardGameEndScores.<Team1Score>k__BackingField;
				num3 = cardGameEndScores.<Team2Score>k__BackingField;
				goto IL_0528;
			}
		}
		goto IL_054f;
		IL_05b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v40+B8]");
		object obj46 = 0;
		bool flag26 = obj46 == null;
		object obj47 = !flag26;
		if (obj47 != null)
		{
			goto IL_0737;
		}
		num = intPtr;
		goto IL_0a50;
	}

	private void OnUserLeaveRoom(User user)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0130: Expected O, but got I
		//IL_014a: Expected O, but got I4
		//IL_002f: Expected O, but got I
		//IL_01c0: Expected O, but got I
		//IL_01d0: Expected O, but got I
		//IL_01f2: Expected O, but got I4
		//IL_0188: Expected O, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		string dbId = SFSKammelnaUserExtensions.GetDbId(user);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				goto IL_004c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_004c;
			}
		}
		_ = 1;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v24+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		object obj8 = obj6;
		if (obj7 != null)
		{
			goto IL_0081;
		}
		goto IL_019e;
		IL_0081:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v24+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v14+8]");
		KGame kGame = (KGame)0;
		goto IL_00a6;
		IL_00a6:
		object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1792;
		int playerIndexByUserDbId = kGame.GetPlayerIndexByUserDbId(dbId);
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(user);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = default(object);
		obj11..ctor();
		_ = 10;
		AddReplayEvent((ReplayEvent)obj11);
		return;
		IL_019e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v9+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6+8]");
		kGame = (KGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6+8]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a6;
		IL_004c:
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v24+E4]");
		bool flag4 = (nint)0 == 0;
		obj8 = obj6;
		if (!flag4)
		{
			goto IL_0081;
		}
		goto IL_019e;
	}

	private void OnUserJoinRoom(User user)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_013c: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_01c2: Expected O, but got I4
		//IL_016a: Expected O, but got I
		//IL_0184: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_010b: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8170]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_0192;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v15+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v11+8]");
		AddJoinEvent((BalootGame)0, user);
		return;
		IL_01d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		goto IL_00e5;
		IL_00b0:
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = obj9;
		if (!flag3)
		{
			goto IL_00e5;
		}
		goto IL_01d8;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E8]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			goto IL_00b0;
		}
		goto IL_0192;
		IL_0192:
		_ = 1;
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		obj10 = obj9;
		if (obj12 != null)
		{
			goto IL_00e5;
		}
		goto IL_01d8;
	}

	private void AddWatchersFromLobby(BalootGame game)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I
		//IL_0167: Expected O, but got I
		//IL_018b: Expected O, but got I4
		//IL_010c: Expected O, but got I
		//IL_01bb: Expected O, but got I
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_0201: Expected O, but got I
		//IL_0232: Expected O, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_02ca: Expected O, but got I
		//IL_02d6: Expected O, but got I
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02f6: Expected O, but got I
		//IL_030e: Expected O, but got I
		//IL_059b: Expected I, but got O
		//IL_0349: Expected O, but got I
		//IL_03e2: Expected I, but got O
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = (object)game == null;
		IEnumerable<object> enumerable = null;
		object obj3 = obj2;
		object obj4;
		object obj6;
		IEnumerable<object> enumerable2;
		object obj13 = default(object);
		nint num2 = default(nint);
		nint num;
		if (!flag)
		{
			Room room = game.Room;
			bool flag2 = obj2 == null;
			enumerable = null;
			obj3 = obj2;
			if (!flag2)
			{
				obj4 = obj2 + 16;
				obj4 = room;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj5 = obj4;
				bool flag3 = obj4 == null;
				enumerable = (IEnumerable<object>)room;
				obj3 = obj2;
				if (!flag3)
				{
					obj6 = typeof(RegisteredWaitHandle) + 1376;
					object obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v5+12E]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v5+12E]");
					if ((nint)0 == 0)
					{
						goto IL_014d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v5+B0]");
					object obj9 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X10_v13-8]");
						if (0 == (nint)obj6)
						{
							break;
						}
						obj9 += 16;
						obj8--;
						if ((nint)obj8 != 1)
						{
							continue;
						}
						goto IL_014d;
					}
					object obj10 = obj9 + 28;
					object obj11 = obj7 + obj10;
					object obj12 = obj11 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v47+8]");
					enumerable2 = (IEnumerable<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v291 @ X0_v47] (should have been resolved before IL gen)");
					bool flag4 = obj13 == null;
					num = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v47+8]");
					enumerable = (IEnumerable<object>)0;
					obj3 = obj2;
					if (!flag4)
					{
						goto IL_0248;
					}
				}
			}
		}
		goto IL_0455;
		IL_0576:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v449 @ X0_v24] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		object obj14;
		func..ctor(obj2, (IntPtr)obj14);
		IEnumerable<object> source = default(IEnumerable<object>);
		IEnumerable<object> enumerable3 = Enumerable.Where(source, func);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15;
		num2 = (nint)obj15;
		List<object> list = default(List<object>);
		list..ctor(enumerable3);
		bool flag5 = list == null;
		enumerable = enumerable3;
		obj3 = enumerable3;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag5)
		{
			List<object>.Enumerator enumerator = list.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				AddJoinEvent(game, null);
			}
			enumerator2.Dispose();
			return;
		}
		goto IL_0455;
		IL_0455:
		NullReferenceException ex = new NullReferenceException();
		bool flag6 = (nint)enumerable != 1;
		NullReferenceException ex2 = ex;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			enumerable = (IEnumerable<object>)obj3;
			enumerator2.Dispose();
			object obj16 = default(object);
			if (obj16 == null)
			{
				return;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			object obj17 = obj16;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BEC8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_014d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v44+8]");
		enumerable2 = (IEnumerable<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v266 @ X0_v44] (should have been resolved before IL gen)");
		bool flag7 = obj13 == null;
		object obj18 = !flag7;
		num = 28;
		if (obj18 != null)
		{
			goto IL_0248;
		}
		num2 = 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v44+8]");
		enumerable = (IEnumerable<object>)0;
		obj3 = obj2;
		goto IL_0455;
		IL_0248:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v23+18]");
		if ((nint)0 == 0)
		{
			return;
		}
		object obj19 = obj4;
		bool flag8 = obj4 == null;
		num2 = num;
		enumerable = enumerable2;
		obj3 = obj2;
		if (flag8)
		{
			goto IL_0455;
		}
		object obj20 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 56;
		obj14 = (nint)0 + (nint)1856;
		object obj21 = (nint)0 + (nint)3840;
		object obj22 = typeof(List<Tween>) + 152;
		obj15 = (nint)0 + (nint)2816;
		object obj23 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v8+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v8+12E]");
		if ((nint)0 == 0)
		{
			goto IL_038a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v8+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X10_v8-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj25 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_038a;
		}
		object obj26 = obj25 + 28;
		object obj27 = obj23 + obj26;
		object obj28 = obj27 + 312;
		goto IL_0576;
		IL_038a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num = 28;
		goto IL_0576;
	}

	private void AddJoinEvent(BalootGame game, User user)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0087: Expected I, but got O
		//IL_0097: Expected O, but got I
		//IL_012d: Expected O, but got I
		//IL_0140: Expected O, but got I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_00d2: Expected O, but got I
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_020d: Expected O, but got I
		//IL_0231: Expected O, but got I4
		//IL_023a: Expected O, but got I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		string dbId = SFSKammelnaUserExtensions.GetDbId(user);
		int playerIndexByUserDbId = game.GetPlayerIndexByUserDbId(dbId);
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(user);
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(user);
		bool flag = SFSKammelnaUserExtensions.IsSubscribed(user);
		bool flag2 = SFSKammelnaUserExtensions.IsVerified(user);
		int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(user);
		object obj = typeof(UsageHint) + 8;
		nint num = (nint)user;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0113;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v6-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_0113;
		}
		object obj4 = obj3 + 1;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v29+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v253 @ X0_v29] (should have been resolved before IL gen)");
		bool flag3 = rank == null;
		object obj8 = !flag3;
		object obj9 = 0;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0145;
		IL_0145:
		object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = default(object);
		obj11..ctor();
		_ = 11;
		object obj12 = obj11 + 32;
		object obj13 = default(object);
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = rank.<Points>k__BackingField;
		_ = rank.<IsNew>k__BackingField;
		AddReplayEvent((ReplayEvent)obj11);
		return;
		IL_0113:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v26+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v237 @ X0_v26] (should have been resolved before IL gen)");
		obj9 = 1;
		goto IL_0145;
	}

	private static string FilePath(GameReplay gameReplay)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_0147: Expected O, but got I4
		if (gameReplay != null)
		{
			object obj = "[{0}]:{1}" + 912;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 72;
			long num = default(long);
			string text = num.ToString();
			string text2 = gameReplay.<Name>k__BackingField + (string)obj + text;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
			if (text2 != null)
			{
				object obj5 = ", stale={0}" + 2488;
				object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
				string[] value = text2.Split(invalidFileNameChars);
				string text3 = string.Join((string)obj, value);
				string path = text3 + (string)obj5;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v18+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string savingPath = SavingPath;
				return Path.Combine(savingPath, path);
			}
		}
		return (string)(object)new NullReferenceException();
	}

	public static bool SaveGameReplayGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0267: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_00a2: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_02ff: Expected O, but got I4
		//IL_0295: Expected O, but got I
		//IL_02af: Expected O, but got I4
		//IL_02b8: Expected O, but got I4
		//IL_02c1: Expected O, but got I4
		//IL_0106: Expected O, but got I
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_03ad: Expected O, but got I4
		//IL_033f: Expected O, but got I
		//IL_0359: Expected O, but got I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_03ec: Expected O, but got I4
		//IL_0412: Expected O, but got I
		//IL_042c: Expected O, but got I4
		//IL_015e: Expected O, but got I
		//IL_04a2: Expected O, but got I
		//IL_046a: Expected O, but got I4
		//IL_020a: Expected O, but got I4
		//IL_01c0: Expected O, but got I
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_0673: Expected O, but got I4
		//IL_0a0a: Expected O, but got I4
		//IL_0ad9: Expected O, but got I
		//IL_0af3: Expected O, but got I4
		//IL_0dd9: Expected O, but got I
		//IL_0dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df3: Expected O, but got Unknown
		//IL_0e1d: Expected O, but got I4
		//IL_0547: Expected O, but got I
		//IL_0eb3: Expected O, but got I
		//IL_0ec3: Expected O, but got I
		//IL_0ecd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed2: Expected O, but got Unknown
		//IL_0ef4: Expected O, but got I4
		//IL_0c32: Expected O, but got I
		//IL_0c4c: Expected O, but got I4
		//IL_0b69: Expected O, but got I
		//IL_0b31: Expected O, but got I4
		//IL_0aa9: Expected O, but got I
		//IL_06fc: Expected O, but got I
		//IL_0b8d: Expected O, but got I
		//IL_0ba7: Expected O, but got I4
		//IL_05a9: Expected O, but got I
		//IL_05c8: Expected O, but got I
		//IL_0a68: Expected O, but got I4
		//IL_0cc2: Expected O, but got I
		//IL_0c8a: Expected O, but got I4
		//IL_0be5: Expected O, but got I4
		//IL_0e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3f: Expected O, but got Unknown
		//IL_0e55: Expected O, but got I
		//IL_0e66: Expected I, but got O
		//IL_0e84: Expected O, but got I
		//IL_0ce6: Expected O, but got I
		//IL_0d00: Expected O, but got I4
		//IL_075e: Expected O, but got I
		//IL_077d: Expected O, but got I
		//IL_062a: Expected O, but got I
		//IL_0a98: Expected O, but got I
		//IL_0d3e: Expected O, but got I4
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected O, but got Unknown
		//IL_0d76: Expected O, but got I
		//IL_0da6: Expected O, but got I4
		//IL_07df: Expected O, but got I
		//IL_0962: Expected O, but got I4
		//IL_096b: Expected O, but got I4
		//IL_08b6: Expected O, but got I4
		//IL_08dc: Expected O, but got I
		//IL_08ec: Expected O, but got I
		//IL_09a3: Expected O, but got I
		//IL_09b3: Expected O, but got I
		//IL_09d5: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8179]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		object obj7 = 146685952;
		object obj8 = 146685952;
		if (obj6 != null)
		{
			goto IL_00b9;
		}
		goto IL_02cf;
		IL_0d54:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v96+B8]");
		object obj10 = 0;
		_ = 1;
		object obj12;
		object obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X0_v92+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 != null)
		{
			goto IL_0812;
		}
		goto IL_0db4;
		IL_0564:
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v148+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = obj14;
		if (!flag4)
		{
			goto IL_0599;
		}
		goto IL_0b47;
		IL_0b47:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v137+B8]");
		object gameReplay = 0;
		SaveGame((GameReplay)gameReplay);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EE]");
		object obj17 = (nint)0 & (nint)1;
		bool flag5 = obj17 == null;
		object obj18 = !flag5;
		if (obj18 != null)
		{
			goto IL_05e5;
		}
		goto IL_0bb5;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
		object obj19 = (nint)0 & (nint)1;
		bool flag6 = obj19 == null;
		obj7 = 146685952;
		obj8 = 146685952;
		if (!flag6)
		{
			goto IL_00b9;
		}
		goto IL_02cf;
		IL_02cf:
		_ = 1;
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v48+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		obj7 = obj8;
		object obj22 = obj20;
		if (obj21 != null)
		{
			goto IL_00f6;
		}
		goto IL_031d;
		IL_00b9:
		obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v48+E4]");
		bool flag8 = (nint)0 == 0;
		obj8 = obj7;
		obj22 = obj20;
		if (!flag8)
		{
			goto IL_00f6;
		}
		goto IL_031d;
		IL_031d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v48+B8]");
		object obj23 = 0;
		bool flag9 = obj23 == null;
		object obj24 = !flag9;
		obj7 = obj8;
		if (obj24 != null)
		{
			goto IL_0123;
		}
		goto IL_036f;
		IL_00f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v48+B8]");
		object obj25 = 0;
		if (obj25 != null)
		{
			goto IL_0123;
		}
		goto IL_036f;
		IL_036f:
		object obj26 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v2+E4]");
		bool flag10 = (nint)0 == 0;
		object obj28 = !flag10;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "Read object reference Id '{0}' for {1}." + 2272;
		Toast.Show((string)message, (Vector2)0, 0f);
		return false;
		IL_0dc3:
		return true;
		IL_01e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v161+E4]");
		bool flag11 = (nint)0 == 0;
		object obj29 = !flag11;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GoToReplay(TrackingPlacement.EndGamePopup);
		return false;
		IL_0123:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v48+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E4]");
			object obj30 = (nint)0 & (nint)1;
			if (obj30 != null)
			{
				goto IL_017b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E4]");
			object obj31 = (nint)0 & (nint)1;
			bool flag12 = obj31 == null;
			object obj32 = !flag12;
			if (obj32 != null)
			{
				goto IL_017b;
			}
		}
		_ = 1;
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v161+E4]");
		bool flag13 = (nint)0 == 0;
		object obj34 = !flag13;
		object obj35 = obj33;
		if (obj34 != null)
		{
			goto IL_01b0;
		}
		goto IL_0480;
		IL_074e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v121+B8]");
		object gameReplay2 = 0;
		SaveGame((GameReplay)gameReplay2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EE]");
		object obj36 = (nint)0 & (nint)1;
		if (obj36 != null)
		{
			goto IL_079a;
		}
		goto IL_0d0e;
		IL_0ca0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v105+B8]");
		object gameReplay3 = 0;
		SaveGame((GameReplay)gameReplay3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EE]");
		object obj38 = (nint)0 & (nint)1;
		bool flag14 = obj38 == null;
		object obj39 = !flag14;
		if (obj39 != null)
		{
			goto IL_079a;
		}
		goto IL_0d0e;
		IL_0719:
		object obj40 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v121+E4]");
		bool flag15 = (nint)0 == 0;
		object obj41 = obj40;
		if (!flag15)
		{
			goto IL_074e;
		}
		goto IL_0ca0;
		IL_017b:
		obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v161+E4]");
		bool flag16 = (nint)0 == 0;
		obj35 = obj33;
		if (!flag16)
		{
			goto IL_01b0;
		}
		goto IL_0480;
		IL_0480:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v161+B8]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v100+40]");
		if ((nint)0 == 1)
		{
			goto IL_01e8;
		}
		goto IL_04c7;
		IL_01b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v161+B8]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v109+40]");
		if ((nint)0 == 1)
		{
			goto IL_01e8;
		}
		goto IL_04c7;
		IL_04c7:
		User mySelf = SFS.MySelf;
		bool flag17 = SFSKammelnaUserExtensions.IsSubscribed(mySelf);
		if (flag17)
		{
			object obj44 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v126+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
				object obj45 = (nint)0 & (nint)1;
				if (obj45 != null)
				{
					goto IL_0564;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X21_v6+5E9]");
				object obj46 = (nint)0 & (nint)1;
				bool flag18 = obj46 == null;
				object obj47 = !flag18;
				if (obj47 != null)
				{
					goto IL_0564;
				}
			}
			_ = 1;
			obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v148+E4]");
			bool flag19 = (nint)0 == 0;
			object obj48 = !flag19;
			obj15 = obj14;
			if (obj48 != null)
			{
				goto IL_0599;
			}
			goto IL_0b47;
		}
		obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj49 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v70+E4]");
		bool flag20 = (nint)0 == 0;
		object obj50 = !flag20;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int usedReplayTrails = Preferences.UsedReplayTrails;
		object obj51 = obj;
		if (usedReplayTrails < 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v75+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
				object obj52 = (nint)0 & (nint)1;
				if (obj52 != null)
				{
					goto IL_0719;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
				object obj53 = (nint)0 & (nint)1;
				bool flag21 = obj53 == null;
				object obj54 = !flag21;
				if (obj54 != null)
				{
					goto IL_0719;
				}
			}
			_ = 1;
			obj40 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v121+E4]");
			bool flag22 = (nint)0 == 0;
			object obj55 = !flag22;
			obj41 = obj40;
			if (obj55 != null)
			{
				goto IL_074e;
			}
			goto IL_0ca0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v75+E4]");
		bool flag23 = (nint)0 == 0;
		object obj56 = !flag23;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj51 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v75+B8]");
		object obj57 = 0;
		_ = 1;
		object obj58 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 48;
		object obj59 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X0_v77+E4]");
		bool flag24 = (nint)0 == 0;
		object obj60 = !flag24;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj59 = obj58;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X0_v77+B8]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v43+8]");
		Action<object> action = (Action<object>)0;
		object obj62 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v43+8]");
		bool flag25 = (nint)0 == 0;
		object obj63 = !flag25;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X0_v77+E4]");
			bool flag26 = (nint)0 == 0;
			object obj64 = !flag26;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj65 = obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v49+B8]");
				obj61 = 0;
			}
			object obj66 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2896;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj67 = (nint)0 + (nint)1840;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj61, (IntPtr)obj67);
			object obj68 = obj58;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v48+B8]");
			object obj69 = (nint)0 + (nint)8;
			obj69 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			action = action2;
		}
		object obj70 = (nint)0 + (nint)3384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F3ABAC");
		return false;
		IL_079a:
		object obj71 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v117+E4]");
		bool flag27 = (nint)0 == 0;
		object obj72 = obj71;
		if (!flag27)
		{
			goto IL_07cf;
		}
		goto IL_0d54;
		IL_0d0e:
		_ = 1;
		obj71 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v117+E4]");
		bool flag28 = (nint)0 == 0;
		object obj73 = !flag28;
		obj72 = obj71;
		if (obj73 != null)
		{
			goto IL_07cf;
		}
		goto IL_0d54;
		IL_0812:
		int usedReplayTrails2 = Preferences.UsedReplayTrails;
		int usedReplayTrails3 = usedReplayTrails2 + 1;
		Preferences.UsedReplayTrails = usedReplayTrails3;
		goto IL_0837;
		IL_07cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v117+B8]");
		object obj74 = 0;
		_ = 1;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X0_v92+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0812;
		}
		goto IL_0db4;
		IL_0bb5:
		_ = 1;
		object obj75 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v145+E4]");
		bool flag29 = (nint)0 == 0;
		object obj76 = !flag29;
		object obj77 = obj75;
		if (obj76 != null)
		{
			goto IL_061a;
		}
		goto IL_0bfb;
		IL_0599:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v148+B8]");
		object gameReplay4 = 0;
		SaveGame((GameReplay)gameReplay4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EE]");
		object obj78 = (nint)0 & (nint)1;
		if (obj78 != null)
		{
			goto IL_05e5;
		}
		goto IL_0bb5;
		IL_0bfb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj75 = obj;
		goto IL_061a;
		IL_05e5:
		obj75 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v145+E4]");
		bool flag30 = (nint)0 == 0;
		obj77 = obj75;
		if (!flag30)
		{
			goto IL_061a;
		}
		goto IL_0bfb;
		IL_0837:
		ITrackEvent trackEvent = TrackerLibrary.GameReplaySaved(flag17);
		object obj79 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj80 = obj79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v24+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			object obj81 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X0_v68+E4]");
			bool flag31 = (nint)0 == 0;
			object obj82 = 0;
			object obj83 = obj81;
			if (!flag31)
			{
				goto IL_08cc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			object obj81 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X0_v68+E4]");
			bool flag32 = (nint)0 == 0;
			object obj84 = !flag32;
			object obj82 = 0;
			object obj83 = obj81;
			if (obj84 != null)
			{
				goto IL_08cc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj85 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X0_v60+B8]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v27+48]");
		object obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v27+48]");
		bool flag33 = (nint)0 == 0;
		object obj88 = !flag33;
		if (obj88 != null)
		{
			goto IL_0911;
		}
		goto IL_0dc3;
		IL_08cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X0_v68+B8]");
		object obj89 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v32+48]");
		obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v32+48]");
		if ((nint)0 != 0)
		{
			goto IL_0911;
		}
		goto IL_0dc3;
		IL_0911:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v641 @ X8_v30+18] (should have been resolved before IL gen)");
		goto IL_0dc3;
		IL_061a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v145+B8]");
		object obj90 = 0;
		_ = 1;
		goto IL_0837;
		IL_0db4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0812;
	}

	private static void SaveGame(GameReplay gameReplay)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I4
		//IL_0156: Expected O, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0138: Expected O, but got I4
		//IL_0054: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+B8]");
		object obj4 = 0;
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+38]");
		string objectAsString = JsonConvert.SerializeObject(gameReplay, (JsonSerializerSettings)0);
		string path = FilePath(gameReplay);
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v8+E4]");
		if ((nint)0 != 0)
		{
			FileUtils.SaveObject(path, objectAsString);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FileUtils.SaveObject(path, objectAsString);
	}

	public static UnityWebRequestAsyncOperation SaveGame(string gameName)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0058: Expected O, but got I4
		//IL_0069: Expected O, but got I4
		//IL_0082: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_02cb: Expected O, but got I4
		//IL_02d4: Expected O, but got I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c7: Expected I, but got O
		//IL_00d7: Expected O, but got I
		//IL_0112: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_013b: Expected O, but got I
		UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = (UnityWebRequestAsyncOperation)(object)("getSecondRescanTask" + 3952);
		object obj = ", stale={0}" + 2488;
		string uri = (string)(object)unityWebRequestAsyncOperation + gameName + (string)obj;
		UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri);
		UnityWebRequestAsyncOperation unityWebRequestAsyncOperation2 = unityWebRequest.SendWebRequest();
		bool flag = unityWebRequest == null;
		string text = (string)obj;
		object obj3 = default(object);
		object obj2 = obj3;
		object obj4 = 0;
		UnityWebRequest unityWebRequest2 = unityWebRequest;
		object obj5 = 0;
		string text2 = (string)obj;
		object obj7 = default(object);
		object obj6 = obj7;
		obj4 = 0;
		UnityWebRequestAsyncOperation result = unityWebRequestAsyncOperation2;
		UnityWebRequestAsyncOperation unityWebRequestAsyncOperation3 = unityWebRequestAsyncOperation;
		object obj8 = 0;
		if (!flag)
		{
			goto IL_00ab;
		}
		goto IL_02b1;
		IL_00ab:
		object obj9 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num = (nint)unityWebRequest2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v9 (Il2CppClass<UnityEngine.Networking.UnityWebRequest>)+12E]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v9 (Il2CppClass<UnityEngine.Networking.UnityWebRequest>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0163;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v9 (Il2CppClass<UnityEngine.Networking.UnityWebRequest>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X10_v8-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj2 = obj10 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v9 (Il2CppClass<UnityEngine.Networking.UnityWebRequest>)+12E]");
			obj6 = -1;
			bool flag2 = (nint)obj6 != 1;
			obj10 = obj2;
			if (flag2)
			{
				continue;
			}
			goto IL_0163;
		}
		obj6 = obj10;
		object obj11 = num + obj10;
		object obj12 = obj11 + 312;
		text2 = text;
		obj2 = obj10;
		unityWebRequestAsyncOperation3 = unityWebRequestAsyncOperation2;
		goto IL_0308;
		IL_02b1:
		object obj14 = default(object);
		UnityWebRequestAsyncOperation result2 = default(UnityWebRequestAsyncOperation);
		while (true)
		{
			bool flag3 = obj8 == null;
			object obj13 = !flag3;
			obj4 = 0;
			if (obj13 == null)
			{
				return result;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			if (0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj5 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				bool flag4 = unityWebRequest == null;
				object obj15 = !flag4;
				text = (string)obj;
				obj2 = obj3;
				obj4 = obj14;
				unityWebRequestAsyncOperation2 = null;
				unityWebRequest2 = unityWebRequest;
				if (obj15 != null)
				{
					break;
				}
				text2 = (string)obj;
				obj6 = obj7;
				obj4 = obj14;
				result = null;
				unityWebRequestAsyncOperation3 = unityWebRequestAsyncOperation;
				obj8 = obj14;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return result2;
		}
		goto IL_00ab;
		IL_0163:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text2 = null;
		unityWebRequestAsyncOperation3 = unityWebRequestAsyncOperation2;
		goto IL_0308;
		IL_0308:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v276 @ X0_v20] (should have been resolved before IL gen)");
		result = unityWebRequestAsyncOperation3;
		obj8 = obj5;
		goto IL_02b1;
	}

	private void AddRoundEvent(GameReplay gameReplay)
	{
		if (_isRecording && _gameInitialized)
		{
			gameReplay.AddRoundEvent();
		}
	}

	private void AddReplayEvent(ReplayEvent replayEvent)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_013e: Expected O, but got I
		//IL_0158: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_01ce: Expected O, but got I
		//IL_01f0: Expected O, but got I4
		//IL_0196: Expected O, but got I4
		//IL_0102: Expected O, but got I
		if (!_isRecording || !_gameInitialized || !_roundInitialized)
		{
			return;
		}
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				goto IL_00bd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_00bd;
			}
		}
		_ = 1;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v16+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		object obj8 = obj6;
		if (obj7 != null)
		{
			goto IL_00f2;
		}
		goto IL_01ac;
		IL_010f:
		GameReplay gameReplay;
		gameReplay.AddReplayEvent(replayEvent);
		return;
		IL_01ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v7+B8]");
		object obj10 = 0;
		gameReplay = (GameReplay)obj10;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_010f;
		IL_00bd:
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v16+E4]");
		bool flag4 = (nint)0 == 0;
		obj8 = obj6;
		if (!flag4)
		{
			goto IL_00f2;
		}
		goto IL_01ac;
		IL_00f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v16+B8]");
		object obj12 = 0;
		gameReplay = (GameReplay)obj12;
		goto IL_010f;
	}

	public static void SetReplayPlayer(ReplayPlayer replayPlayer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_007e: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
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
		object obj4 = (nint)0 + (nint)80;
		obj4 = replayPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public static CommentEvent EditComment(CommentEvent commentToEdit, string comment, CommentDuration commentDuration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_018f: Expected O, but got I
		//IL_01a9: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_021f: Expected O, but got I
		//IL_022f: Expected O, but got I
		//IL_0285: Expected O, but got I
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_02ae: Expected O, but got I
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_0317: Expected O, but got I
		//IL_03ee: Expected O, but got I4
		//IL_0379: Expected O, but got I
		//IL_0389: Expected O, but got I
		//IL_03ab: Expected O, but got I4
		//IL_0471: Expected O, but got I
		//IL_0426: Expected O, but got I
		//IL_0436: Expected O, but got I
		//IL_0540: Expected O, but got I4
		//IL_04cb: Expected O, but got I
		//IL_04db: Expected O, but got I
		//IL_04fd: Expected O, but got I4
		//IL_0578: Expected O, but got I
		//IL_0588: Expected O, but got I
		//IL_05f7: Expected O, but got I
		//IL_061b: Expected O, but got I
		//IL_06f8: Expected O, but got I4
		//IL_067d: Expected O, but got I
		//IL_068d: Expected O, but got I
		//IL_0730: Expected O, but got I
		//IL_0740: Expected O, but got I
		//IL_0762: Expected O, but got I4
		//IL_06c3: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E817D]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v51+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v51+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_06b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v17+98]");
		SaveGame((GameReplay)0);
		object obj7 = default(object);
		return (CommentEvent)obj7;
		IL_045b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj8 = (nint)0 & (nint)1;
		object obj10;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v33+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = obj10;
			if (!flag3)
			{
				goto IL_04bb;
			}
		}
		else
		{
			_ = 1;
			obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v33+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			object obj9 = obj10;
			if (obj11 != null)
			{
				goto IL_04bb;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v29+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v23+18]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v23+18]");
		if ((nint)0 != 0)
		{
			goto IL_05ad;
		}
		goto IL_0770;
		IL_0369:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v33+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v37+18]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v37+18]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 != null)
		{
			goto IL_045b;
		}
		goto IL_0770;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj18 = (nint)0 & (nint)1;
		if (obj18 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_01b7:
		_ = 1;
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v63+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		object obj21 = obj19;
		if (obj20 != null)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
		IL_00a7:
		obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v63+E4]");
		bool flag7 = (nint)0 == 0;
		obj21 = obj19;
		if (!flag7)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
		IL_01fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v45+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v41+18]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v41+18]");
		if ((nint)0 != 0)
		{
			goto IL_0254;
		}
		goto IL_0770;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v63+B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v51+18]");
		obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v51+18]");
		bool flag8 = (nint)0 == 0;
		object obj26 = !flag8;
		if (obj26 != null)
		{
			goto IL_0254;
		}
		goto IL_0770;
		IL_0254:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v3+F0]");
		int replayEventIndex;
		if ((nint)0 != 0)
		{
			object obj27 = (nint)0 + (nint)3952;
			object obj28 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v3+F0]");
			replayEventIndex = ((List<object>)0).IndexOf(commentToEdit);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj7..ctor();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253550]");
			_ = 0;
			object obj29 = obj7 + 24;
			obj29 = comment;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj30 = (nint)0 & (nint)1;
			if (obj30 != null)
			{
				obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v33+E4]");
				bool flag9 = (nint)0 == 0;
				object obj31 = obj10;
				if (!flag9)
				{
					goto IL_0369;
				}
			}
			else
			{
				_ = 1;
				obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v33+E4]");
				bool flag10 = (nint)0 == 0;
				object obj32 = !flag10;
				object obj31 = obj10;
				if (obj32 != null)
				{
					goto IL_0369;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v33+B8]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v32+18]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v32+18]");
			if ((nint)0 != 0)
			{
				goto IL_045b;
			}
		}
		goto IL_0770;
		IL_0770:
		return (CommentEvent)(object)new NullReferenceException();
		IL_05ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v8+98]");
		object obj40;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v8+98]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v10+B8]");
			((GameReplay)num).AddReplayEvent((ReplayEvent)obj7, 0, replayEventIndex);
			DeleteComment(commentToEdit);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj34 = (nint)0 & (nint)1;
			if (obj34 != null)
			{
				object obj35 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v25+E4]");
				bool flag11 = (nint)0 == 0;
				object obj36 = obj35;
				if (!flag11)
				{
					goto IL_066d;
				}
			}
			else
			{
				_ = 1;
				object obj35 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v25+E4]");
				bool flag12 = (nint)0 == 0;
				object obj37 = !flag12;
				object obj36 = obj35;
				if (obj37 != null)
				{
					goto IL_066d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj38 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v17+B8]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v13+18]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v13+18]");
			bool flag13 = (nint)0 == 0;
			object obj41 = !flag13;
			if (obj41 != null)
			{
				goto IL_06b2;
			}
		}
		goto IL_0770;
		IL_04bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v33+B8]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v28+18]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v28+18]");
		bool flag14 = (nint)0 == 0;
		object obj43 = !flag14;
		if (obj43 != null)
		{
			goto IL_05ad;
		}
		goto IL_0770;
		IL_066d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v25+B8]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v19+18]");
		obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v19+18]");
		if ((nint)0 != 0)
		{
			goto IL_06b2;
		}
		goto IL_0770;
	}

	public static CommentEvent AddComment(string comment, CommentDuration commentDuration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected O, but got Unknown
		//IL_017a: Expected O, but got I4
		//IL_0183: Expected O, but got I4
		//IL_018c: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		//IL_0077: Expected O, but got I
		//IL_008f: Expected O, but got I4
		//IL_01ba: Expected O, but got I
		//IL_01d4: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		//IL_0224: Expected O, but got I4
		//IL_00f3: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_0125: Expected O, but got I4
		//IL_0264: Expected O, but got I
		//IL_0274: Expected O, but got I
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_0315: Expected O, but got I
		//IL_03ec: Expected O, but got I4
		//IL_0377: Expected O, but got I
		//IL_0387: Expected O, but got I
		//IL_03a9: Expected O, but got I4
		//IL_046f: Expected O, but got I
		//IL_0424: Expected O, but got I
		//IL_0434: Expected O, but got I
		//IL_053e: Expected O, but got I4
		//IL_04c9: Expected O, but got I
		//IL_04d9: Expected O, but got I
		//IL_04fb: Expected O, but got I4
		//IL_0576: Expected O, but got I
		//IL_0586: Expected O, but got I
		//IL_05fd: Expected O, but got I
		//IL_0613: Expected O, but got I
		//IL_06ea: Expected O, but got I4
		//IL_0675: Expected O, but got I
		//IL_0685: Expected O, but got I
		//IL_06a7: Expected O, but got I4
		//IL_0768: Expected O, but got I
		//IL_077e: Expected O, but got I
		//IL_0722: Expected O, but got I
		//IL_0732: Expected O, but got I
		//IL_0861: Expected O, but got I4
		//IL_07e0: Expected O, but got I
		//IL_07f0: Expected O, but got I
		//IL_0899: Expected O, but got I
		//IL_08a9: Expected O, but got I
		//IL_08cb: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		ITrackEvent trackEvent = TrackerLibrary.CommentAdded();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+E4]");
		object obj6;
		object obj5;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v63+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = 0;
			if (!flag)
			{
				goto IL_0061;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v63+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = 0;
			obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0061;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj8 = (nint)0 & (nint)1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		object obj10 = 146685952;
		obj5 = obj6;
		if (obj9 != null)
		{
			goto IL_00a6;
		}
		goto IL_01f4;
		IL_04b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v45+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v37+18]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v37+18]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 != null)
		{
			goto IL_05ab;
		}
		goto IL_08d9;
		IL_0815:
		GameReplayController gameReplayController;
		gameReplayController.SetAklasIndices();
		gameReplayController.SetReplayPlayerReplayEvents();
		object obj14 = default(object);
		return (CommentEvent)obj14;
		IL_08d9:
		return (CommentEvent)(object)new NullReferenceException();
		IL_0061:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj15 = (nint)0 & (nint)1;
		bool flag5 = obj15 == null;
		obj10 = 146685952;
		obj6 = obj5;
		if (!flag5)
		{
			goto IL_00a6;
		}
		goto IL_01f4;
		IL_01f4:
		_ = 1;
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v69+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		obj5 = obj6;
		object obj18 = obj16;
		if (obj17 != null)
		{
			goto IL_00e3;
		}
		goto IL_0242;
		IL_00a6:
		obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v69+E4]");
		bool flag7 = (nint)0 == 0;
		obj6 = obj5;
		obj18 = obj16;
		if (!flag7)
		{
			goto IL_00e3;
		}
		goto IL_0242;
		IL_0242:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v57+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v50+18]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v50+18]");
		bool flag8 = (nint)0 == 0;
		obj5 = obj6;
		if (!flag8)
		{
			goto IL_02a1;
		}
		goto IL_08d9;
		IL_00e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v69+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v59+18]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v59+18]");
		bool flag9 = (nint)0 == 0;
		object obj23 = !flag9;
		if (obj23 != null)
		{
			goto IL_02a1;
		}
		goto IL_08d9;
		IL_02a1:
		object obj24 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj14..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253550]");
		_ = 0;
		object obj25 = obj14 + 24;
		obj25 = comment;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj26 = (nint)0 & (nint)1;
		object obj27;
		if (obj26 != null)
		{
			obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v45+E4]");
			bool flag10 = (nint)0 == 0;
			object obj28 = obj27;
			if (!flag10)
			{
				goto IL_0367;
			}
		}
		else
		{
			_ = 1;
			obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v45+E4]");
			bool flag11 = (nint)0 == 0;
			object obj29 = !flag11;
			object obj28 = obj27;
			if (obj29 != null)
			{
				goto IL_0367;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj27 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v45+B8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v41+18]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v41+18]");
		if ((nint)0 != 0)
		{
			goto IL_0459;
		}
		goto IL_08d9;
		IL_07d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v28+B8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v20+18]");
		gameReplayController = (GameReplayController)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v20+18]");
		if ((nint)0 != 0)
		{
			goto IL_0815;
		}
		goto IL_08d9;
		IL_0757:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v12+98]");
		SaveGame((GameReplay)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj33 = (nint)0 & (nint)1;
		if (obj33 != null)
		{
			object obj34 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v28+E4]");
			bool flag12 = (nint)0 == 0;
			object obj35 = obj34;
			if (!flag12)
			{
				goto IL_07d0;
			}
		}
		else
		{
			_ = 1;
			object obj34 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v28+E4]");
			bool flag13 = (nint)0 == 0;
			object obj36 = !flag13;
			object obj35 = obj34;
			if (obj36 != null)
			{
				goto IL_07d0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj37 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v19+B8]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v15+18]");
		gameReplayController = (GameReplayController)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v15+18]");
		bool flag14 = (nint)0 == 0;
		object obj39 = !flag14;
		if (obj39 != null)
		{
			goto IL_0815;
		}
		goto IL_08d9;
		IL_05ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v8+98]");
		object obj46;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v8+98]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v10+B8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v5+128]");
			((GameReplay)num).AddReplayEvent((ReplayEvent)obj14, (int)num2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj40 = (nint)0 & (nint)1;
			if (obj40 != null)
			{
				object obj41 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v37+E4]");
				bool flag15 = (nint)0 == 0;
				object obj42 = obj41;
				if (!flag15)
				{
					goto IL_0665;
				}
			}
			else
			{
				_ = 1;
				object obj41 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v37+E4]");
				bool flag16 = (nint)0 == 0;
				object obj43 = !flag16;
				object obj42 = obj41;
				if (obj43 != null)
				{
					goto IL_0665;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj44 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v32+B8]");
			object obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v23+18]");
			obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v23+18]");
			if ((nint)0 != 0)
			{
				goto IL_0757;
			}
		}
		goto IL_08d9;
		IL_0367:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v45+B8]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v46+18]");
		obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v46+18]");
		bool flag17 = (nint)0 == 0;
		object obj48 = !flag17;
		if (obj48 != null)
		{
			goto IL_0459;
		}
		goto IL_08d9;
		IL_0459:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj49 = (nint)0 & (nint)1;
		if (obj49 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v45+E4]");
			bool flag18 = (nint)0 == 0;
			object obj50 = obj27;
			if (!flag18)
			{
				goto IL_04b9;
			}
		}
		else
		{
			_ = 1;
			obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v45+E4]");
			bool flag19 = (nint)0 == 0;
			object obj51 = !flag19;
			object obj50 = obj27;
			if (obj51 != null)
			{
				goto IL_04b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj52 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v41+B8]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v32+18]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v32+18]");
		if ((nint)0 != 0)
		{
			goto IL_05ab;
		}
		goto IL_08d9;
		IL_0665:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v37+B8]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v28+18]");
		obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v28+18]");
		bool flag20 = (nint)0 == 0;
		object obj55 = !flag20;
		if (obj55 != null)
		{
			goto IL_0757;
		}
		goto IL_08d9;
	}

	public static void DeleteComment(ReplayEvent commentToDelete)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_016b: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_00a2: Expected O, but got I4
		//IL_01fb: Expected O, but got I4
		//IL_0199: Expected O, but got I
		//IL_01b3: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		//IL_00f6: Expected O, but got I
		//IL_0106: Expected O, but got I
		//IL_0128: Expected O, but got I4
		//IL_0258: Expected O, but got I
		//IL_0233: Expected O, but got I
		//IL_0243: Expected O, but got I
		//IL_0273: Expected O, but got I
		//IL_0342: Expected O, but got I4
		//IL_02cd: Expected O, but got I
		//IL_02dd: Expected O, but got I
		//IL_02ff: Expected O, but got I4
		//IL_03ad: Expected O, but got I
		//IL_037a: Expected O, but got I
		//IL_038a: Expected O, but got I
		//IL_03c2: Expected O, but got I
		//IL_03d7: Expected O, but got I
		//IL_03f1: Expected O, but got I
		//IL_04c8: Expected O, but got I4
		//IL_0453: Expected O, but got I
		//IL_0463: Expected O, but got I
		//IL_0485: Expected O, but got I4
		//IL_0500: Expected O, but got I
		//IL_0510: Expected O, but got I
		//IL_0542: Expected O, but got I
		//IL_05fb: Expected O, but got I4
		//IL_05a4: Expected O, but got I
		//IL_05b4: Expected O, but got I
		//IL_05ca: Expected O, but got I
		//IL_0633: Expected O, but got I
		//IL_0643: Expected O, but got I
		//IL_0665: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81E6]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v51+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v51+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		object obj7 = 146685952;
		if (obj6 != null)
		{
			goto IL_00b1;
		}
		goto IL_01cb;
		IL_05b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v19+98]");
		SaveGame((GameReplay)0);
		return;
		IL_0594:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v22+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v21+18]");
		object obj9 = 0;
		goto IL_05b9;
		IL_038f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v4+98]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v6+B8]");
		object obj10 = ((List<object>)num).get_Item(0);
		object obj11 = (nint)0 + (nint)3968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v6 (System.Object)+10]");
		bool flag3 = ((List<object>)0).Remove(commentToDelete);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj12 = (nint)0 & (nint)1;
		if (obj12 != null)
		{
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v31+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = obj13;
			if (!flag4)
			{
				goto IL_0443;
			}
		}
		else
		{
			_ = 1;
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v31+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			object obj14 = obj13;
			if (obj15 != null)
			{
				goto IL_0443;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v26+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v25+18]");
		GameReplayController gameReplayController = (GameReplayController)0;
		goto IL_0515;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj18 = (nint)0 & (nint)1;
		bool flag6 = obj18 == null;
		obj7 = 146685952;
		if (!flag6)
		{
			goto IL_00b1;
		}
		goto IL_01cb;
		IL_01cb:
		_ = 1;
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v42+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		object obj21 = obj19;
		if (obj20 != null)
		{
			goto IL_00e6;
		}
		goto IL_0211;
		IL_00b1:
		obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v42+E4]");
		bool flag8 = (nint)0 == 0;
		obj21 = obj19;
		if (!flag8)
		{
			goto IL_00e6;
		}
		goto IL_0211;
		IL_0211:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v42+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v42+18]");
		object obj23 = 0;
		goto IL_0248;
		IL_00e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v42+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v52+18]");
		obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v52+18]");
		bool flag9 = (nint)0 == 0;
		object obj25 = !flag9;
		if (obj25 != null)
		{
			goto IL_0248;
		}
		goto IL_0673;
		IL_0248:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v3+98]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj27 = (nint)0 & (nint)1;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v42+E4]");
			bool flag10 = (nint)0 == 0;
			object obj28 = obj19;
			if (!flag10)
			{
				goto IL_02bd;
			}
		}
		else
		{
			_ = 1;
			obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v42+E4]");
			bool flag11 = (nint)0 == 0;
			object obj29 = !flag11;
			object obj28 = obj19;
			if (obj29 != null)
			{
				goto IL_02bd;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v38+B8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v33+18]");
		object obj32 = 0;
		goto IL_038f;
		IL_0515:
		gameReplayController.SetAklasIndices();
		gameReplayController.SetReplayPlayerReplayEvents();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj33 = (nint)0 & (nint)1;
		if (obj33 != null)
		{
			object obj34 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v22+E4]");
			bool flag12 = (nint)0 == 0;
			object obj35 = obj34;
			if (!flag12)
			{
				goto IL_0594;
			}
		}
		else
		{
			_ = 1;
			object obj34 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v22+E4]");
			bool flag13 = (nint)0 == 0;
			object obj36 = !flag13;
			object obj35 = obj34;
			if (obj36 != null)
			{
				goto IL_0594;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v15+B8]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v15+18]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v15+18]");
		bool flag14 = (nint)0 == 0;
		object obj39 = !flag14;
		if (obj39 != null)
		{
			goto IL_05b9;
		}
		goto IL_0673;
		IL_0443:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v31+B8]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v29+18]");
		gameReplayController = (GameReplayController)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v29+18]");
		bool flag15 = (nint)0 == 0;
		object obj41 = !flag15;
		if (obj41 != null)
		{
			goto IL_0515;
		}
		goto IL_0673;
		IL_0673:
		throw new NullReferenceException();
		IL_02bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v42+B8]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v38+18]");
		obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v38+18]");
		bool flag16 = (nint)0 == 0;
		object obj43 = !flag16;
		if (obj43 != null)
		{
			goto IL_038f;
		}
		goto IL_0673;
	}

	public static void ShowComment(ReplayEvent replayEvent)
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_01bf: Expected O, but got I4
		//IL_0158: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_009e: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_0187: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		bool flag = replayEvent == null;
		ReplayEvent replayEvent2 = replayEvent;
		ReplayEvent replayEvent3;
		object obj8;
		object obj6;
		if (!flag)
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2040;
			object obj3 = obj2;
			nint num = (nint)replayEvent;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X9_v4 (Il2CppClass<Features.GameReplay.ReplayEvent>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v10+130]");
			bool flag2 = num2 < 0;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X9_v4 (Il2CppClass<Features.GameReplay.ReplayEvent>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v10+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v6-8]");
				replayEvent3 = ((0 != (nint)obj3) ? null : replayEvent);
				obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					obj8 = obj6;
					replayEvent2 = replayEvent3;
					goto IL_006a;
				}
				goto IL_0148;
			}
			replayEvent2 = null;
		}
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		obj6 = obj8;
		replayEvent3 = replayEvent2;
		if (obj9 == null)
		{
			goto IL_006a;
		}
		goto IL_0148;
		IL_006a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj;
		replayEvent3 = replayEvent2;
		goto IL_0148;
		IL_0148:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v3+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+50]");
		((ReplayPlayer)0).ShowComment((CommentEvent)replayEvent3);
	}

	public static void GoToReplay(TrackingPlacement trackingPlacement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_012d: Expected O, but got I4
		//IL_0136: Expected O, but got I4
		//IL_013f: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		//IL_0077: Expected O, but got I
		//IL_016d: Expected O, but got I
		//IL_0187: Expected O, but got I4
		//IL_01cd: Expected O, but got I4
		//IL_00e1: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		TrackingPlacement placement = default(TrackingPlacement);
		ITrackEvent trackEvent = TrackerLibrary.GoToReplayClicked(placement);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+E4]");
		object obj6;
		object obj5;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = 0;
			if (!flag)
			{
				goto IL_0061;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = 0;
			obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0061;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
		object obj8 = (nint)0 & (nint)1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		obj5 = obj6;
		if (obj9 != null)
		{
			goto IL_009c;
		}
		goto IL_019d;
		IL_00d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v17+B8]");
		object gameReplay = 0;
		SFS.GoToReplay((GameReplay)gameReplay);
		return;
		IL_01eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj10 = obj2;
		goto IL_00d1;
		IL_009c:
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v17+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = obj10;
		if (!flag4)
		{
			goto IL_00d1;
		}
		goto IL_01eb;
		IL_0061:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
		object obj12 = (nint)0 & (nint)1;
		bool flag5 = obj12 == null;
		obj6 = obj5;
		if (!flag5)
		{
			goto IL_009c;
		}
		goto IL_019d;
		IL_019d:
		_ = 1;
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v17+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		obj5 = obj6;
		obj11 = obj10;
		if (obj13 != null)
		{
			goto IL_00d1;
		}
		goto IL_01eb;
	}

	public static void GoToReplay(GameReplay gameReplay, TrackingPlacement trackingPlacement)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0136: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_01bc: Expected O, but got I4
		//IL_0164: Expected O, but got I
		//IL_017e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8181]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EB]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_018c;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GoToReplay(trackingPlacement);
		return;
		IL_01d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj2;
		goto IL_00e5;
		IL_00b0:
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = obj8;
		if (!flag3)
		{
			goto IL_00e5;
		}
		goto IL_01d2;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EB]");
		object obj10 = (nint)0 & (nint)1;
		if (obj10 != null)
		{
			goto IL_00b0;
		}
		goto IL_018c;
		IL_018c:
		_ = 1;
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		obj9 = obj8;
		if (obj11 != null)
		{
			goto IL_00e5;
		}
		goto IL_01d2;
	}

	public unsafe static Task<List<GameReplayCardData>> GetAllSavedGames(CancellationToken cancellationToken)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I4
		//IL_003f: Expected O, but got I
		//IL_005c: Expected O, but got Ref
		//IL_0074: Expected O, but got I
		//IL_0094: Expected O, but got I
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1416;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<object>.Create();
		<GetAllSavedGames>d__108 stateMachine = default(<GetAllSavedGames>d__108);
		object obj4 = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder<object>)((nint)(&stateMachine) | (nint)8);
		((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder2)->Start(ref stateMachine);
		AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder<object>)((nint)(&stateMachine) | (nint)8);
		return (Task<List<GameReplayCardData>>)(object)((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder3)->Task;
	}

	public static IEnumerator GetAllSavedGamesWeb()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		return (IEnumerator)obj2;
	}

	public static void DeleteGameReplay(GameReplayCardData gameReplayCardData)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		string text;
		string path;
		if ((nint)0 != 0)
		{
			text = FilePath(gameReplayCardData.<GameReplay>k__BackingField);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			path = text;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			text = FilePath(gameReplayCardData.<GameReplay>k__BackingField);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			path = text;
			if (obj5 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FileUtils.Delete(path);
		return;
		IL_00a1:
		FileUtils.Delete(text);
	}

	public static string Share()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_016b: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_01f1: Expected O, but got I4
		//IL_0199: Expected O, but got I
		//IL_01b3: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0248: Expected O, but got I4
		//IL_0132: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81E7]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_01c1;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v15+B8]");
		object value = 0;
		object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v11+38]");
		return JsonConvert.SerializeObject(value, (JsonSerializerSettings)0);
		IL_0207:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj11 = obj2;
		goto IL_00e5;
		IL_00b0:
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = obj11;
		if (!flag4)
		{
			goto IL_00e5;
		}
		goto IL_0207;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E9]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			goto IL_00b0;
		}
		goto IL_01c1;
		IL_01c1:
		_ = 1;
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v15+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		obj12 = obj11;
		if (obj14 != null)
		{
			goto IL_00e5;
		}
		goto IL_0207;
	}

	public void ShowWatcherControls()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e4: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_011c: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_014e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8186]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+10]");
		CardGameVisualControls cardGameVisualControls = (CardGameVisualControls)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+10]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00aa;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v9+10]");
		cardGameVisualControls = (CardGameVisualControls)0;
		goto IL_00aa;
		IL_00aa:
		cardGameVisualControls.ShowControls();
	}

	public void HideWatcherControls()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e4: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_011c: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_014e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8187]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+10]");
		CardGameVisualControls cardGameVisualControls = (CardGameVisualControls)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+10]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00aa;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v9+10]");
		cardGameVisualControls = (CardGameVisualControls)0;
		goto IL_00aa;
		IL_00aa:
		cardGameVisualControls.HideWatcherControls();
	}

	public static void ShowOthersCards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I4
		//IL_0100: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0070: Expected O, but got I
		//IL_0080: Expected O, but got I
		//IL_00a2: Expected O, but got I4
		//IL_0138: Expected O, but got I
		//IL_0148: Expected O, but got I
		//IL_0164: Expected O, but got I4
		//IL_017a: Expected O, but got I
		//IL_0253: Expected O, but got I4
		//IL_01dc: Expected O, but got I
		//IL_01ec: Expected O, but got I
		//IL_0209: Expected O, but got I
		//IL_0219: Expected O, but got I
		//IL_028b: Expected O, but got I
		//IL_029b: Expected O, but got I
		//IL_02bd: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		ITrackEvent trackEvent = TrackerLibrary.ToggleShowPlayingCardsClicked(show: true);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0060;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj5 = 0;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0060;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v21+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v17+10]");
		CardGameVisualControls cardGameVisualControls = (CardGameVisualControls)0;
		goto IL_014d;
		IL_0269:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v9+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v8+18]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v8+18]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 != null)
		{
			goto IL_01f1;
		}
		goto IL_02cb;
		IL_0223:
		_ = 1;
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v16+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		object obj16 = obj14;
		if (obj15 != null)
		{
			goto IL_01cc;
		}
		goto IL_0269;
		IL_01f1:
		object obj17 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v12+2B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v12+2C0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v115 @ X2_v3 (should have been resolved before IL gen)");
		goto IL_0223;
		IL_0060:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v27+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v20+10]");
		cardGameVisualControls = (CardGameVisualControls)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v20+10]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 != null)
		{
			goto IL_014d;
		}
		goto IL_02cb;
		IL_014d:
		cardGameVisualControls.ShowOthersCards();
		object obj22 = 146685952;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj23 = (nint)0 & (nint)1;
		if (obj23 == null)
		{
			goto IL_0223;
		}
		obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v16+E4]");
		bool flag6 = (nint)0 == 0;
		obj16 = obj14;
		if (!flag6)
		{
			goto IL_01cc;
		}
		goto IL_0269;
		IL_02cb:
		throw new NullReferenceException();
		IL_01cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v16+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v14+18]");
		obj12 = 0;
		goto IL_01f1;
	}

	public static void HideOthersCards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I4
		//IL_0100: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0070: Expected O, but got I
		//IL_0080: Expected O, but got I
		//IL_00a2: Expected O, but got I4
		//IL_0138: Expected O, but got I
		//IL_0148: Expected O, but got I
		//IL_0164: Expected O, but got I4
		//IL_017a: Expected O, but got I
		//IL_0253: Expected O, but got I4
		//IL_01dc: Expected O, but got I
		//IL_01ec: Expected O, but got I
		//IL_0209: Expected O, but got I
		//IL_0219: Expected O, but got I
		//IL_028b: Expected O, but got I
		//IL_029b: Expected O, but got I
		//IL_02bd: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		ITrackEvent trackEvent = TrackerLibrary.ToggleShowPlayingCardsClicked(show: false);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0060;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj5 = 0;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0060;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v21+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v17+10]");
		CardGameVisualControls cardGameVisualControls = (CardGameVisualControls)0;
		goto IL_014d;
		IL_0269:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v9+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v8+18]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v8+18]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 != null)
		{
			goto IL_01f1;
		}
		goto IL_02cb;
		IL_0223:
		_ = 1;
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v16+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		object obj16 = obj14;
		if (obj15 != null)
		{
			goto IL_01cc;
		}
		goto IL_0269;
		IL_01f1:
		object obj17 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v12+2B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v12+2C0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v115 @ X2_v3 (should have been resolved before IL gen)");
		goto IL_0223;
		IL_0060:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v27+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v20+10]");
		cardGameVisualControls = (CardGameVisualControls)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v20+10]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 != null)
		{
			goto IL_014d;
		}
		goto IL_02cb;
		IL_014d:
		cardGameVisualControls.HideOthersCards();
		object obj22 = 146685952;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj23 = (nint)0 & (nint)1;
		if (obj23 == null)
		{
			goto IL_0223;
		}
		obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v16+E4]");
		bool flag6 = (nint)0 == 0;
		obj16 = obj14;
		if (!flag6)
		{
			goto IL_01cc;
		}
		goto IL_0269;
		IL_02cb:
		throw new NullReferenceException();
		IL_01cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v16+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v14+18]");
		obj12 = 0;
		goto IL_01f1;
	}

	static GameReplayManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0081: Expected O, but got I
		//IL_00c9: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		JsonSerializerSettings jsonSerializerSettings = default(JsonSerializerSettings);
		jsonSerializerSettings..ctor();
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 1184;
		jsonSerializerSettings.NullValueHandling = NullValueHandling.Ignore;
		jsonSerializerSettings.DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v3+B8]");
		object obj5 = (nint)0 + (nint)56;
		obj5 = jsonSerializerSettings;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v4+B8]");
		object obj7 = (nint)0 + (nint)88;
		obj7 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
