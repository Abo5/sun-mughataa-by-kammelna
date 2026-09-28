using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking.Strategies;
using Firebase.Analytics;
using Firebase.Crashlytics;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;
using Util;

namespace DataTracking;

public static class Tracker
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<StoreOwnedItem, bool> <>9__14_0;

		public static Func<StoreOwnedItem, bool> <>9__14_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <UserProfile>b__14_0(StoreOwnedItem r)
		{
			//IL_003d: Expected I4, but got O
			if (r != null)
			{
				return r.IsActiveItem;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <UserProfile>b__14_1(StoreOwnedItem c)
		{
			//IL_003d: Expected I4, but got O
			if (c != null)
			{
				return c.IsActiveItem;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const bool DebugLogEvents = true;

	private static readonly List<IAnalyticsStrategy> AnalyticsStrategies;

	private static bool HasTrackedUserProfileToday
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Expected O, but got Unknown
			//IL_0242: Expected O, but got I4
			//IL_0160: Expected O, but got I
			//IL_017a: Expected O, but got I4
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected O, but got Unknown
			//IL_0086: Expected O, but got I
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Expected O, but got Unknown
			//IL_01c7: Expected O, but got I4
			//IL_00ff: Expected O, but got I
			//IL_0114: Expected O, but got I
			object obj = typeof(DataRelation) + 712;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime today = DateTime.Today;
			DateTime dateTime = default(DateTime);
			DateTime date = dateTime.Date;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D75]");
				object obj6 = (nint)0 & (nint)1;
				if (obj6 != null)
				{
					goto IL_00a3;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D75]");
				object obj7 = (nint)0 & (nint)1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				if (obj8 != null)
				{
					goto IL_00a3;
				}
			}
			_ = 1;
			object obj9 = "LAK" + 552;
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v21+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			object obj12 = obj9;
			object obj13 = obj10;
			if (obj11 != null)
			{
				goto IL_00ef;
			}
			goto IL_01e5;
			IL_00a3:
			obj9 = "LAK" + 552;
			obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v21+E4]");
			bool flag4 = (nint)0 == 0;
			obj12 = obj9;
			obj13 = obj10;
			if (!flag4)
			{
				goto IL_00ef;
			}
			goto IL_01e5;
			IL_01e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj;
			obj9 = obj12;
			goto IL_00ef;
			IL_00ef:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v21+B8]");
			object obj14 = 0;
			object key = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v11+10]");
			DateTime date2 = Prefs.GetDate((string)key, (DateTime)0);
			DateTime date3 = dateTime.Date;
			return date == date3;
		}
	}

	private static bool IsNotProduction
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0132: Expected O, but got I4
			//IL_00c9: Expected O, but got I4
			//IL_016e: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isInitialized = Config.IsInitialized;
			bool flag2 = !isInitialized;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_009f;
			}
			goto IL_017c;
			IL_009f:
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isProduction = Config.IsProduction;
			return (byte)((isProduction ? 1u : 0u) ^ 1u) != 0;
			IL_017c:
			return true;
			IL_007d:
			if (Config.IsInitialized)
			{
				goto IL_009f;
			}
			goto IL_017c;
		}
	}

	private static DateTime LastTrackDateForUserProfile
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
			object key = "LAK" + 552;
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
			object key = "LAK" + 552;
			Prefs.SetDate((string)key, value);
		}
	}

	public static void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0133: Expected O, but got I4
		//IL_0151: Expected O, but got I
		//IL_0084: Expected O, but got I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2048;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+B8]");
		object obj5 = 0;
		List<object> list = (List<object>)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GameAnalyticsStrategy gameAnalyticsStrategy = default(GameAnalyticsStrategy);
		gameAnalyticsStrategy..ctor();
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag2 = list._size < items.Length;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = gameAnalyticsStrategy;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)gameAnalyticsStrategy);
		}
	}

	public unsafe static void PurchaseEvent(TrackerPurchase type, string itemId, double price, string currencyCode)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0a37: Expected O, but got I4
		//IL_0033: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_008d: Expected O, but got Ref
		//IL_09c8: Expected O, but got I
		//IL_00b0: Expected O, but got I8
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_011c: Expected O, but got I4
		//IL_0132: Expected O, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01c6: Expected O, but got I8
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_022d: Expected O, but got I4
		//IL_0243: Expected O, but got I
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02da: Expected O, but got I4
		//IL_02f0: Expected O, but got I
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0372: Expected O, but got I4
		//IL_0388: Expected O, but got I
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected I4, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_0410: Expected O, but got I8
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_0605: Expected O, but got I4
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected O, but got Unknown
		//IL_0527: Expected O, but got I
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_0651: Expected O, but got I
		//IL_066b: Expected O, but got I4
		//IL_06b9: Expected O, but got I4
		//IL_05b0: Expected O, but got I4
		//IL_0768: Expected O, but got I4
		//IL_07da: Expected O, but got I4
		//IL_0a55: Expected O, but got I
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected O, but got Unknown
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected O, but got Unknown
		//IL_085f: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		bool flag = array == null;
		string text = (string)8;
		object obj3;
		object obj5 = default(object);
		object obj32;
		string text4;
		object obj37;
		object obj40;
		if (!flag)
		{
			bool flag2 = array.Length == 0;
			text = (string)8;
			if (!flag2)
			{
				object obj2 = "___# Content push apply failed [{0}]: {1}" + 624;
				obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1776;
				object obj4 = array + 32;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				string text2 = ((Enum)(&obj5)).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X23_v7-8]");
				object obj6 = 0 & 0xFFFFFFFEL;
				bool flag3 = obj6 == null;
				obj5 = obj3;
				text = null;
				if (!flag3)
				{
					object obj7 = array + 40;
					obj7 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X23_v9-10]");
					bool flag4 = (nint)0 < (nint)2;
					object obj8 = !flag4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X23_v9-10]");
					object obj9 = -2;
					bool flag5 = obj9 == null;
					object obj10 = ~obj8;
					object obj11 = obj10 | flag5;
					obj5 = obj3;
					text = text2;
					if (obj11 == null)
					{
						object obj12 = "1.2.840.113549.1.12.1.5" + 1488;
						text = (string)obj12;
						object obj13 = array + 48;
						obj13 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X23_v11-18]");
						object obj14 = 0 & 0xFFFFFFFCL;
						bool flag6 = obj14 == null;
						obj5 = obj3;
						if (!flag6)
						{
							object obj15 = array + 56;
							obj15 = itemId;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X23_v13-20]");
							bool flag7 = (nint)0 < (nint)4;
							object obj16 = !flag7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X23_v13-20]");
							object obj17 = -4;
							bool flag8 = obj17 == null;
							object obj18 = ~obj16;
							object obj19 = obj18 | flag8;
							obj5 = obj3;
							text = itemId;
							if (obj19 == null)
							{
								object obj20 = array + 64;
								obj20 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								double num = default(double);
								string text3 = num.ToString();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X23_v15-28]");
								bool flag9 = (nint)0 < (nint)5;
								object obj21 = !flag9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X23_v15-28]");
								object obj22 = -5;
								bool flag10 = obj22 == null;
								object obj23 = ~obj21;
								object obj24 = obj23 | flag10;
								obj5 = obj3;
								text = null;
								if (obj24 == null)
								{
									object obj25 = array + 72;
									obj25 = text3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X23_v17-30]");
									bool flag11 = (nint)0 < (nint)6;
									object obj26 = !flag11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X23_v17-30]");
									object obj27 = -6;
									bool flag12 = obj27 == null;
									object obj28 = ~obj26;
									bool flag13 = (byte)((obj28 | flag12) ? 1 : 0) != 0;
									obj5 = obj3;
									text = text3;
									if (!flag13)
									{
										text = (string)obj12;
										object obj29 = array + 80;
										obj29 = obj12;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X23_v19-38]");
										object obj30 = 0 & 0xFFFFFFF8L;
										bool flag14 = obj30 == null;
										obj5 = obj3;
										if (!flag14)
										{
											object obj31 = typeof(DataRelation) + 856;
											obj32 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
											object obj33 = array + 88;
											obj33 = currencyCode;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											string message = string.Concat(array);
											object obj34 = obj31;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v20+E4]");
											if ((nint)0 != 0)
											{
												Debug.Log(message);
												object obj35 = obj32;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v77+E4]");
												bool flag15 = (nint)0 == 0;
												text = null;
												text4 = null;
												if (!flag15)
												{
													goto IL_04fd;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												Debug.Log(message);
												object obj35 = obj32;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v77+E4]");
												bool flag16 = (nint)0 == 0;
												object obj36 = !flag16;
												text = null;
												text4 = null;
												if (obj36 != null)
												{
													goto IL_04fd;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj37 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
											object obj38 = (nint)0 & (nint)1;
											bool flag17 = obj38 == null;
											object obj39 = !flag17;
											text = text4;
											obj40 = obj37;
											if (obj39 != null)
											{
												goto IL_0554;
											}
											goto IL_0689;
										}
									}
								}
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		goto IL_096d;
		IL_0554:
		object obj41 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v68+E4]");
		bool flag18 = (nint)0 == 0;
		text4 = text;
		obj40 = obj37;
		if (!flag18)
		{
			goto IL_0591;
		}
		goto IL_06d7;
		IL_06d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isInitialized = Config.IsInitialized;
		bool flag19 = !isInitialized;
		text = text4;
		obj37 = obj40;
		if (!flag19)
		{
			goto IL_0718;
		}
		return;
		IL_096d:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag20 = (nint)text != 1;
		NullReferenceException ex3 = ex2;
		List<object>.Enumerator enumerator = default(List<object>.Enumerator);
		if (!flag20)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj42 = (nint)0 + (nint)1232;
			text = (string)obj42;
			enumerator.Dispose();
			object obj43 = default(object);
			if (obj43 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			obj5 = obj43;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B15C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0718:
		object obj44 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X0_v45+E4]");
		if ((nint)0 != 0)
		{
			bool isProduction = Config.IsProduction;
			bool flag21 = !isProduction;
			object obj45 = !flag21;
			if (obj45 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!Config.IsProduction)
			{
				return;
			}
		}
		object obj46 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v48+E4]");
		bool flag22 = (nint)0 == 0;
		object obj47 = !flag22;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj46 = obj32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v48+B8]");
		object obj48 = 0;
		bool flag23 = obj48 == null;
		obj5 = obj3;
		if (!flag23)
		{
			List<object>.Enumerator enumerator2 = ((List<object>)obj48).GetEnumerator();
			object obj49 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 760;
			object obj50 = "SetRoomVariables request error" + 464;
			while (enumerator.MoveNext())
			{
				object obj51 = 0;
			}
			enumerator.Dispose();
			return;
		}
		goto IL_096d;
		IL_0591:
		bool isInitialized2 = Config.IsInitialized;
		bool flag24 = !isInitialized2;
		object obj52 = !flag24;
		if (obj52 == null)
		{
			return;
		}
		goto IL_0718;
		IL_04fd:
		obj37 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
		object obj53 = (nint)0 & (nint)1;
		bool flag25 = obj53 == null;
		text4 = text;
		obj40 = obj37;
		if (!flag25)
		{
			goto IL_0554;
		}
		goto IL_0689;
		IL_0689:
		_ = 1;
		obj41 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v68+E4]");
		bool flag26 = (nint)0 == 0;
		object obj54 = !flag26;
		text = text4;
		obj37 = obj40;
		if (obj54 != null)
		{
			goto IL_0591;
		}
		goto IL_06d7;
	}

	public unsafe static void DesignEvent(ITrackEvent trackEvent)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_0045: Expected O, but got I
		//IL_00dc: Expected O, but got I4
		//IL_0d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7b: Expected O, but got Unknown
		//IL_0d85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8a: Expected O, but got Unknown
		//IL_0d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d99: Expected O, but got Unknown
		//IL_0da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da8: Expected O, but got Unknown
		//IL_0db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbc: Expected O, but got Unknown
		//IL_0df0: Expected O, but got I4
		//IL_0080: Expected O, but got I
		//IL_0cdd: Expected O, but got I
		//IL_0ce5: Expected I, but got O
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_01a8: Expected I, but got O
		//IL_0c7d: Expected I, but got O
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0245: Expected I, but got O
		//IL_02b6: Expected O, but got I8
		//IL_025b: Expected I, but got O
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02fb: Expected I, but got O
		//IL_030b: Expected O, but got I
		//IL_03cd: Expected O, but got I4
		//IL_03de: Expected O, but got I4
		//IL_0485: Expected I, but got O
		//IL_0346: Expected O, but got I
		//IL_03fd: Expected O, but got I4
		//IL_0500: Expected O, but got I4
		//IL_0510: Expected O, but got I4
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected I4, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected O, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_058a: Expected I, but got O
		//IL_059a: Expected O, but got I
		//IL_0652: Expected O, but got I4
		//IL_05d5: Expected O, but got I
		//IL_0708: Expected O, but got I8
		//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e89: Expected O, but got Unknown
		//IL_069d: Expected I, but got O
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected O, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected O, but got Unknown
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected O, but got Unknown
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected O, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected O, but got Unknown
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected O, but got Unknown
		//IL_0904: Expected O, but got I4
		//IL_0909: Expected I, but got O
		//IL_090e: Expected I, but got O
		//IL_07e9: Expected I, but got O
		//IL_07ee: Expected I, but got O
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected O, but got Unknown
		//IL_0826: Expected O, but got I
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected O, but got Unknown
		//IL_0950: Expected O, but got I
		//IL_096a: Expected O, but got I4
		//IL_09b8: Expected O, but got I4
		//IL_08af: Expected O, but got I4
		//IL_0a67: Expected O, but got I4
		//IL_0ad9: Expected O, but got I4
		//IL_0ef9: Expected O, but got I
		//IL_0f19: Expected O, but got I4
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Expected O, but got Unknown
		//IL_0b4f: Expected O, but got I4
		if (trackEvent == null)
		{
			goto IL_0c82;
		}
		object obj = typeof(System.IOAsyncCallback) + 1816;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		nint num = (nint)trackEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v8 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v8 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v8 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		object obj5 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X10_v29-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj5 = obj4 + 16;
			obj3--;
			bool flag = (nint)obj3 != 1;
			obj4 = obj5;
			if (flag)
			{
				continue;
			}
			goto IL_00c9;
		}
		object obj6 = obj4 + 3;
		object obj7 = num + obj6;
		object obj8 = obj7 + 312;
		obj5 = obj4;
		goto IL_0d6c;
		IL_0c4f:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		nint num3;
		nint num2 = num3;
		goto IL_0c65;
		IL_04e4:
		object[] array = default(object[]);
		bool flag2 = array.Length < 2;
		object obj9 = !flag2;
		object obj10 = array.Length - 2;
		bool flag3 = obj10 == null;
		object obj11 = ~obj9;
		bool flag4 = (byte)((obj11 | flag3) ? 1 : 0) != 0;
		object obj13;
		object obj12 = obj13;
		if (flag4)
		{
			goto IL_0c4f;
		}
		object obj14 = typeof(List<Tween>) + 2496;
		object obj15 = array + 48;
		object obj16;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num4 = (nint)trackEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v23 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v23 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_063f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v23 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
		object obj18 = (nint)0 + (nint)8;
		bool flag5 = flag4;
		object obj19;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X10_v18-8]");
			obj10 = 0 - obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X10_v18-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj19 = obj18 + 16;
			obj17--;
			obj10 = obj17 - 1;
			flag4 = (nint)obj17 != 1;
			flag5 = flag4;
			obj18 = obj19;
			if (flag4)
			{
				continue;
			}
			goto IL_063f;
		}
		object obj20 = obj18 + 6;
		object obj21 = num4 + obj20;
		object obj22 = obj21 + 312;
		flag4 = flag5;
		obj19 = obj18;
		goto IL_0eb0;
		IL_0c65:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		nint num5 = unchecked((nint)null);
		goto IL_0c82;
		IL_09d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isInitialized = Config.IsInitialized;
		bool flag6 = !isInitialized;
		nint num6;
		num5 = num6;
		object obj24;
		object obj23 = obj24;
		if (!flag6)
		{
			goto IL_0a17;
		}
		return;
		IL_0890:
		bool isInitialized2 = Config.IsInitialized;
		bool flag7 = !isInitialized2;
		object obj25 = !flag7;
		if (obj25 == null)
		{
			return;
		}
		goto IL_0a17;
		IL_00c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj12 = 3;
		goto IL_0d6c;
		IL_0d6c:
		object obj26 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3304;
		object obj27 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3272;
		object obj28 = "___# Content push apply failed [{0}]: {1}" + 848;
		object obj29 = "___# Content push apply failed [{0}]: {1}" + 32;
		object obj30 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v262 @ X0_v17] (should have been resolved before IL gen)");
		object obj31 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v20+E4]");
		bool flag8 = (nint)0 == 0;
		object obj32 = !flag8;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj34 = default(object);
		object obj33 = (((nint)obj34 != 49) ? obj27 : obj26);
		object obj35 = (((nint)obj34 != 49) ? obj29 : obj28);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag9 = array == null;
		num5 = 4;
		object obj43;
		if (!flag9)
		{
			bool flag10 = obj33 == null;
			num3 = 4;
			if (!flag10)
			{
				nint num7 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v64 (Il2CppClass<System.Object[]>)+40]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag11 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v64 (Il2CppClass<System.Object[]>)+40]");
				num2 = 0;
				if (flag11)
				{
					goto IL_0c65;
				}
			}
			if (array.Length != 0)
			{
				object obj36 = array + 32;
				obj36 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag12 = obj35 == null;
				num3 = (nint)obj33;
				if (!flag12)
				{
					nint num8 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v63 (Il2CppClass<System.Object[]>)+40]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag13 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v63 (Il2CppClass<System.Object[]>)+40]");
					num2 = 0;
					if (flag13)
					{
						goto IL_0c65;
					}
				}
				object obj37 = array.Length & 0xFFFFFFFEL;
				if (obj37 != null)
				{
					object obj38 = array + 40;
					obj38 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					nint num9 = (nint)trackEvent;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v20 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
					object obj39 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v20 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_038f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v20 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
					obj19 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X10_v13-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj5 = obj19 + 16;
						obj39--;
						bool flag14 = (nint)obj39 != 1;
						obj19 = obj5;
						if (flag14)
						{
							continue;
						}
						goto IL_038f;
					}
					object obj40 = num9 + obj19;
					object obj41 = obj40 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X0_v110+8]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v631 @ X0_v110] (should have been resolved before IL gen)");
					object obj42 = default(object);
					bool flag15 = obj42 == null;
					obj43 = obj42;
					obj5 = obj19;
					obj16 = obj42;
					obj13 = obj12;
					if (!flag15)
					{
						goto IL_047d;
					}
					goto IL_04e4;
				}
			}
			goto IL_0c4f;
		}
		goto IL_0c82;
		IL_0c82:
		NullReferenceException ex3 = new NullReferenceException();
		bool flag16 = num5 != 1;
		NullReferenceException ex4 = ex3;
		List<object>.Enumerator enumerator = default(List<object>.Enumerator);
		object obj46 = default(object);
		if (!flag16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj44 = (nint)0 + (nint)1232;
			num5 = (nint)obj44;
			enumerator.Dispose();
			object obj45 = default(object);
			if (obj45 == null)
			{
				return;
			}
			OutOfMemoryException ex5 = new OutOfMemoryException();
			obj46 = obj45;
			ex4 = (NullReferenceException)(object)ex5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B15C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_07fc:
		obj23 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
		object obj47 = (nint)0 & (nint)1;
		bool flag17 = obj47 == null;
		num6 = num5;
		obj24 = obj23;
		if (!flag17)
		{
			goto IL_0853;
		}
		goto IL_0988;
		IL_0988:
		_ = 1;
		object obj48 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X0_v76+E4]");
		bool flag18 = (nint)0 == 0;
		object obj49 = !flag18;
		num5 = num6;
		obj23 = obj24;
		if (obj49 != null)
		{
			goto IL_0890;
		}
		goto IL_09d6;
		IL_0eb0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v719 @ X0_v41] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj50 = default(object);
		bool flag19 = obj50 == null;
		num3 = (nint)(&obj46);
		object obj51 = default(object);
		if (!flag19)
		{
			nint num10 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v56 (Il2CppClass<System.Object[]>)+40]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag20 = ex == null;
			obj46 = obj51;
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v56 (Il2CppClass<System.Object[]>)+40]");
			num2 = 0;
			if (flag20)
			{
				goto IL_0c65;
			}
		}
		object obj52 = array.Length & 0xFFFFFFFCL;
		bool flag21 = obj52 == null;
		obj46 = obj51;
		obj12 = obj13;
		if (!flag21)
		{
			object format = "1.2.840.113549.1.12.1.5" + 3536;
			object obj53 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj54 = array + 56;
			obj54 = obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string obj55 = string.Format((string)format, array);
			object obj56 = obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v28+E4]");
			if ((nint)0 != 0)
			{
				KLogger.LogAnalytics(obj55);
				object obj57 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X0_v85+E4]");
				bool flag22 = (nint)0 == 0;
				num5 = unchecked((nint)null);
				num6 = unchecked((nint)null);
				if (!flag22)
				{
					goto IL_07fc;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				KLogger.LogAnalytics(obj55);
				object obj57 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X0_v85+E4]");
				bool flag23 = (nint)0 == 0;
				object obj58 = !flag23;
				num5 = unchecked((nint)null);
				num6 = unchecked((nint)null);
				if (obj58 != null)
				{
					goto IL_07fc;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
			object obj59 = (nint)0 & (nint)1;
			bool flag24 = obj59 == null;
			object obj60 = !flag24;
			num5 = num6;
			obj24 = obj23;
			if (obj60 != null)
			{
				goto IL_0853;
			}
			goto IL_0988;
		}
		goto IL_0c4f;
		IL_063f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj13 = 6;
		goto IL_0eb0;
		IL_047d:
		nint num11 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
		num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag25 = ex == null;
		obj16 = obj43;
		obj13 = obj12;
		obj19 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
		num2 = 0;
		if (!flag25)
		{
			goto IL_04e4;
		}
		goto IL_0c65;
		IL_038f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X0_v107+8]");
		num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v599 @ X0_v107] (should have been resolved before IL gen)");
		object obj61 = default(object);
		bool flag26 = obj61 == null;
		object obj62 = !flag26;
		obj43 = obj61;
		obj12 = 0;
		if (obj62 != null)
		{
			goto IL_047d;
		}
		obj16 = obj61;
		obj13 = 0;
		obj19 = obj5;
		goto IL_04e4;
		IL_0a17:
		object obj63 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v53+E4]");
		if ((nint)0 != 0)
		{
			bool isProduction = Config.IsProduction;
			bool flag27 = !isProduction;
			object obj64 = !flag27;
			if (obj64 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!Config.IsProduction)
			{
				return;
			}
		}
		object obj65 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X0_v56+E4]");
		bool flag28 = (nint)0 == 0;
		object obj66 = !flag28;
		if (obj66 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj65 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X0_v56+B8]");
		object obj67 = 0;
		bool flag29 = obj67 == null;
		obj46 = obj51;
		obj12 = 0;
		if (!flag29)
		{
			List<object>.Enumerator enumerator2 = ((List<object>)obj67).GetEnumerator();
			object obj68 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 760;
			while (enumerator.MoveNext())
			{
				object obj69 = 0;
			}
			enumerator.Dispose();
			return;
		}
		goto IL_0c82;
		IL_0853:
		obj48 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X0_v76+E4]");
		bool flag30 = (nint)0 == 0;
		num6 = num5;
		obj24 = obj23;
		if (!flag30)
		{
			goto IL_0890;
		}
		goto IL_09d6;
	}

	public unsafe static void ResourceEvent(ResourceFlowType flowType, ResourceItemType type, string itemId, double amount, ResourceCurrency currency)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_015e: Expected O, but got I4
		//IL_016d: Expected O, but got I4
		//IL_0075: Expected O, but got I4
		//IL_0084: Expected O, but got I4
		//IL_01ec: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_01b1: Expected O, but got I4
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_0319: Expected O, but got I4
		//IL_028d: Expected O, but got I4
		//IL_110a: Expected O, but got I4
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_038b: Expected O, but got I4
		//IL_0394: Expected O, but got I4
		//IL_1286: Unknown result type (might be due to invalid IL or missing references)
		//IL_128b: Expected O, but got Unknown
		//IL_12bd: Expected O, but got I4
		//IL_112a: Expected O, but got I4
		//IL_03b1: Expected O, but got I4
		//IL_03c7: Expected I, but got O
		//IL_03d7: Expected O, but got I
		//IL_0400: Expected O, but got I
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_04d5: Expected O, but got I8
		//IL_047a: Expected I, but got O
		//IL_048a: Expected O, but got I
		//IL_04b3: Expected O, but got I
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_054c: Expected O, but got Ref
		//IL_05cd: Expected O, but got I4
		//IL_05dd: Expected O, but got I4
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected O, but got Unknown
		//IL_0562: Expected I, but got O
		//IL_0572: Expected O, but got I
		//IL_05a3: Expected O, but got I
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected O, but got Unknown
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		//IL_06f5: Expected O, but got I8
		//IL_0692: Expected I, but got O
		//IL_06a2: Expected O, but got I
		//IL_06d3: Expected O, but got I
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected O, but got Unknown
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected O, but got Unknown
		//IL_0762: Expected O, but got I4
		//IL_07eb: Expected O, but got I4
		//IL_07fb: Expected O, but got I4
		//IL_081b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Expected O, but got Unknown
		//IL_0780: Expected I, but got O
		//IL_0790: Expected O, but got I
		//IL_07c1: Expected O, but got I
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Expected O, but got Unknown
		//IL_0865: Expected O, but got I4
		//IL_088b: Expected O, but got Ref
		//IL_0914: Expected O, but got I4
		//IL_0924: Expected O, but got I4
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected O, but got Unknown
		//IL_08a1: Expected I, but got O
		//IL_08b1: Expected O, but got I
		//IL_08ea: Expected O, but got I
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Expected O, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected O, but got Unknown
		//IL_09c1: Expected O, but got Ref
		//IL_0a4a: Expected O, but got I4
		//IL_0a5a: Expected O, but got I4
		//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected I4, but got Unknown
		//IL_09d7: Expected I, but got O
		//IL_09e7: Expected O, but got I
		//IL_0a20: Expected O, but got I
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected O, but got Unknown
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac5: Expected O, but got Unknown
		//IL_0ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad3: Expected O, but got Unknown
		//IL_0b13: Expected O, but got I
		//IL_0ca2: Expected O, but got I4
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Expected O, but got Unknown
		//IL_0ba2: Expected O, but got I
		//IL_0bba: Expected O, but got I4
		//IL_0bc3: Expected O, but got I4
		//IL_0cd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Expected O, but got Unknown
		//IL_0cee: Expected O, but got I
		//IL_0d08: Expected O, but got I4
		//IL_0d11: Expected O, but got I4
		//IL_0d22: Expected O, but got I4
		//IL_0d46: Expected I, but got O
		//IL_0d68: Expected O, but got I4
		//IL_0be9: Expected I, but got O
		//IL_0c4d: Expected O, but got I4
		//IL_0ddf: Expected I, but got O
		//IL_0e27: Expected O, but got I4
		//IL_0e99: Expected O, but got I4
		//IL_115c: Expected O, but got I
		//IL_0ed8: Expected O, but got I
		//IL_0ee7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eec: Expected O, but got Unknown
		//IL_0ef9: Expected O, but got Ref
		//IL_1055: Expected F8, but got I4
		//IL_105e: Expected F8, but got I4
		//IL_123e: Expected O, but got I
		//IL_1258: Invalid comparison between F8 and I4
		//IL_1269: Expected O, but got I4
		//IL_0f51: Expected I, but got O
		//IL_0f61: Expected O, but got I
		//IL_10e2: Expected F8, but got O
		//IL_0f1f: Expected I4, but got O
		//IL_0f27: Expected O, but got I4
		//IL_0f9c: Expected O, but got I
		//IL_10f9: Expected F8, but got O
		//IL_11d1: Expected O, but got I4
		//IL_11e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e6: Expected O, but got Unknown
		//IL_1027: Unknown result type (might be due to invalid IL or missing references)
		//IL_102c: Expected O, but got Unknown
		//IL_1034: Unknown result type (might be due to invalid IL or missing references)
		//IL_1039: Expected O, but got Unknown
		//IL_1042: Unknown result type (might be due to invalid IL or missing references)
		//IL_1047: Expected O, but got Unknown
		//IL_0faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Expected O, but got Unknown
		//IL_0fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbd: Expected O, but got Unknown
		//IL_0fd7: Expected O, but got I4
		//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe5: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D79]");
		object obj2 = (nint)0 & (nint)1;
		object[] array;
		List<object>.Enumerator enumerator;
		object[] array2;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v130+E4]");
			bool flag = (nint)0 == 0;
			array = null;
			enumerator = (List<object>.Enumerator)0;
			array2 = null;
			enumerator = (List<object>.Enumerator)0;
			if (!flag)
			{
				goto IL_0092;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v130+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			array = null;
			enumerator = (List<object>.Enumerator)0;
			array2 = null;
			enumerator = (List<object>.Enumerator)0;
			if (obj4 != null)
			{
				goto IL_0092;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string text = default(string);
		bool flag3 = string.IsNullOrEmpty(text);
		bool flag4 = !flag3;
		object obj5 = !flag4;
		array = array2;
		string text2 = null;
		if (obj5 != null)
		{
			goto IL_00ca;
		}
		goto IL_01cc;
		IL_0364:
		object obj6 = "___# Content push apply failed [{0}]: {1}" + 24;
		object[] array3 = (object[])(object)(" SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3296);
		object obj7 = 1;
		object[] array4 = (object[])152989696;
		goto IL_1277;
		IL_1277:
		object obj8 = typeof(TypeConverter<ushort, char>) + 3400;
		string text3 = (string)(object)array3;
		string text4 = (string)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array5 = default(object[]);
		bool flag5 = array5 == null;
		text2 = (string)7;
		double num6 = default(double);
		double num8 = default(double);
		string text11;
		string text12;
		object[] array6;
		string text8;
		if (!flag5)
		{
			bool flag6 = array3 == null;
			string text5 = (string)7;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			string text6;
			if (!flag6)
			{
				nint num = (nint)array5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v53 (Il2CppClass<System.Object[]>)+40]");
				text5 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag7 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v53 (Il2CppClass<System.Object[]>)+40]");
				text6 = (string)0;
				if (flag7)
				{
					goto IL_107a;
				}
			}
			if (array5.Length != 0)
			{
				object obj9 = array5 + 32;
				obj9 = text3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag8 = text4 == null;
				text5 = text3;
				if (!flag8)
				{
					nint num2 = (nint)array5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v52 (Il2CppClass<System.Object[]>)+40]");
					text5 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag9 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v52 (Il2CppClass<System.Object[]>)+40]");
					text6 = (string)0;
					if (flag9)
					{
						goto IL_107a;
					}
				}
				object obj10 = array5.Length & 0xFFFFFFFEL;
				if (obj10 != null)
				{
					text3 = (string)(typeof(RegisteredWaitHandle) + 912);
					object obj11 = array5 + 40;
					obj11 = text4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					string text7 = default(string);
					bool flag10 = text7 == null;
					ResourceFlowType resourceFlowType = default(ResourceFlowType);
					text5 = (string)(&resourceFlowType);
					if (!flag10)
					{
						nint num3 = (nint)array5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v51 (Il2CppClass<System.Object[]>)+40]");
						text5 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag11 = ex == null;
						text4 = text7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v51 (Il2CppClass<System.Object[]>)+40]");
						text6 = (string)0;
						if (flag11)
						{
							goto IL_107a;
						}
					}
					bool flag12 = array5.Length < 2;
					object obj12 = !flag12;
					object obj13 = array5.Length - 2;
					bool flag13 = obj13 == null;
					object obj14 = ~obj12;
					object obj15 = obj14 | flag13;
					text4 = text7;
					if (obj15 == null)
					{
						text3 = (string)(typeof(RegisteredWaitHandle) + 936);
						object obj16 = array5 + 48;
						obj16 = text7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						Enum enumeration = default(Enum);
						string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
						bool flag14 = friendlyName == null;
						text5 = null;
						if (!flag14)
						{
							nint num4 = (nint)array5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v50 (Il2CppClass<System.Object[]>)+40]");
							text5 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag15 = ex == null;
							text4 = friendlyName;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v50 (Il2CppClass<System.Object[]>)+40]");
							text6 = (string)0;
							if (flag15)
							{
								goto IL_107a;
							}
						}
						object obj17 = array5.Length & 0xFFFFFFFCL;
						bool flag16 = obj17 == null;
						text4 = friendlyName;
						if (!flag16)
						{
							object obj18 = array5 + 56;
							obj18 = friendlyName;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj19 = obj7 & 1;
							bool flag17 = obj19 == null;
							object obj20 = !flag17;
							text5 = friendlyName;
							if (obj20 == null)
							{
								nint num5 = (nint)array5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v49 (Il2CppClass<System.Object[]>)+40]");
								text5 = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag18 = ex == null;
								text4 = friendlyName;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v49 (Il2CppClass<System.Object[]>)+40]");
								text6 = (string)0;
								if (flag18)
								{
									goto IL_107a;
								}
							}
							bool flag19 = array5.Length < 4;
							object obj21 = !flag19;
							object obj22 = array5.Length - 4;
							bool flag20 = obj22 == null;
							object obj23 = ~obj21;
							object obj24 = obj23 | flag20;
							text4 = friendlyName;
							if (obj24 == null)
							{
								object obj25 = array5 + 64;
								obj25 = text8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj26 = 153100288 + 1024;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
								string text9 = default(string);
								bool flag21 = text9 == null;
								text5 = (string)(&num6);
								if (!flag21)
								{
									nint num7 = (nint)array5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v48 (Il2CppClass<System.Object[]>)+40]");
									text5 = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag22 = ex == null;
									num6 = num8;
									text4 = text9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v48 (Il2CppClass<System.Object[]>)+40]");
									text6 = (string)0;
									if (flag22)
									{
										goto IL_107a;
									}
								}
								bool flag23 = array5.Length < 5;
								object obj27 = !flag23;
								object obj28 = array5.Length - 5;
								bool flag24 = obj28 == null;
								object obj29 = ~obj27;
								object obj30 = obj29 | flag24;
								num6 = num8;
								text4 = text9;
								if (obj30 == null)
								{
									text3 = (string)(typeof(RegisteredWaitHandle) + 896);
									object obj31 = array5 + 72;
									obj31 = text9;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
									string text10 = default(string);
									bool flag25 = text10 == null;
									ResourceCurrency resourceCurrency = default(ResourceCurrency);
									text5 = (string)(&resourceCurrency);
									if (!flag25)
									{
										nint num9 = (nint)array5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
										text5 = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag26 = ex == null;
										num6 = num8;
										text4 = text10;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
										text6 = (string)0;
										if (flag26)
										{
											goto IL_107a;
										}
									}
									bool flag27 = array5.Length < 6;
									object obj32 = !flag27;
									object obj33 = array5.Length - 6;
									bool flag28 = obj33 == null;
									object obj34 = ~obj32;
									bool flag29 = (byte)((obj34 | flag28) ? 1 : 0) != 0;
									num6 = num8;
									text4 = text10;
									if (!flag29)
									{
										text3 = "1.2.840.113549.1.12.1.5" + 3544;
										obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
										object obj35 = array5 + 80;
										obj35 = text10;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										string obj36 = string.Format(text3, array5);
										object obj37 = obj7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X8_v21+E4]");
										array3 = (object[])0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X8_v21+E4]");
										if ((nint)0 != 0)
										{
											KLogger.LogAnalytics(obj36);
											object obj38 = obj;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v80+E4]");
											bool flag30 = (nint)0 == 0;
											text2 = null;
											text11 = null;
											if (!flag30)
											{
												goto IL_0b78;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											KLogger.LogAnalytics(obj36);
											object obj38 = obj;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v80+E4]");
											bool flag31 = (nint)0 == 0;
											object obj39 = !flag31;
											text2 = null;
											text11 = null;
											if (obj39 != null)
											{
												goto IL_0b78;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										array4 = (object[])(typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
										object obj40 = (nint)0 & (nint)1;
										bool flag32 = obj40 == null;
										object obj41 = !flag32;
										text4 = (string)152989696;
										text2 = text11;
										text12 = (string)152989696;
										array6 = array4;
										if (obj41 != null)
										{
											goto IL_0be1;
										}
										goto IL_0d38;
									}
								}
							}
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			text6 = text5;
			goto IL_107a;
		}
		goto IL_1097;
		IL_0d8e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isInitialized = Config.IsInitialized;
		bool flag33 = !isInitialized;
		text4 = text12;
		text2 = text11;
		array4 = array6;
		if (!flag33)
		{
			goto IL_0dd7;
		}
		return;
		IL_0092:
		bool flag34 = string.IsNullOrEmpty(text);
		bool flag35 = !flag34;
		text2 = null;
		array2 = array;
		if (!flag35)
		{
			goto IL_00ca;
		}
		goto IL_01cc;
		IL_01cc:
		bool flag36 = text == null;
		ResourceCurrency resourceCurrency2 = currency;
		array4 = (object[])152989696;
		text8 = text;
		ResourceCurrency resourceCurrency3;
		string text13;
		if (!flag36)
		{
			bool flag37 = text._stringLength < 17;
			resourceCurrency3 = currency;
			array = array2;
			text13 = text;
			if (!flag37)
			{
				string text14 = text.Substring(0, 16);
				bool flag38 = text14 == null;
				resourceCurrency3 = ResourceCurrency.None;
				array = array2;
				text13 = text14;
				resourceCurrency2 = ResourceCurrency.None;
				text = (string)16;
				text8 = text14;
				if (flag38)
				{
					goto IL_0364;
				}
			}
			goto IL_02a3;
		}
		goto IL_1097;
		IL_0c2e:
		bool isInitialized2 = Config.IsInitialized;
		bool flag39 = !isInitialized2;
		object obj42 = !flag39;
		if (obj42 == null)
		{
			return;
		}
		goto IL_0dd7;
		IL_0d38:
		_ = 1;
		nint num10 = (nint)array6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X0_v71 (Il2CppClass<System.Object[]>)+E4]");
		bool flag40 = (nint)0 == 0;
		object obj43 = !flag40;
		text4 = text12;
		text2 = text11;
		array4 = array6;
		if (obj43 != null)
		{
			goto IL_0c2e;
		}
		goto IL_0d8e;
		IL_00ca:
		bool flag41 = text == null;
		object obj44 = !flag41;
		resourceCurrency3 = currency;
		text13 = text;
		if (obj44 != null)
		{
			goto IL_02a3;
		}
		resourceCurrency2 = currency;
		array2 = array;
		text8 = text;
		goto IL_0364;
		IL_02a3:
		object value = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3440;
		array4 = (object[])(object)(" SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3296);
		object[] array7 = (object[])(object)(" SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3304);
		object obj45 = "___# Content push apply failed [{0}]: {1}" + 24;
		object obj46 = "___# Content push apply failed [{0}]: {1}" + 840;
		bool flag42 = text13.StartsWith((string)value);
		bool flag43 = !flag42;
		object obj47 = !flag43;
		object obj48 = ~obj47;
		array3 = ((obj48 != null) ? array4 : array7);
		object obj49 = !flag43;
		object obj50 = ~obj49;
		obj6 = ((obj50 != null) ? obj45 : obj46);
		obj7 = 0;
		resourceCurrency2 = resourceCurrency3;
		text = null;
		array2 = array;
		text8 = text13;
		goto IL_1277;
		IL_107a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		text2 = null;
		goto IL_1097;
		IL_0be1:
		nint num11 = (nint)array4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X0_v90 (Il2CppClass<System.Object[]>)+E4]");
		bool flag44 = (nint)0 == 0;
		text12 = text4;
		text11 = text2;
		num10 = num11;
		array6 = array4;
		if (!flag44)
		{
			goto IL_0c2e;
		}
		goto IL_0d8e;
		IL_0b78:
		array4 = (object[])(typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
		object obj51 = (nint)0 & (nint)1;
		bool flag45 = obj51 == null;
		text4 = (string)152989696;
		text12 = (string)152989696;
		text11 = text2;
		array6 = array4;
		if (!flag45)
		{
			goto IL_0be1;
		}
		goto IL_0d38;
		IL_0dd7:
		nint num12 = (nint)array4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X0_v49 (Il2CppClass<System.Object[]>)+E4]");
		if ((nint)0 != 0)
		{
			bool isProduction = Config.IsProduction;
			bool flag46 = !isProduction;
			object obj52 = !flag46;
			if (obj52 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!Config.IsProduction)
			{
				return;
			}
		}
		object obj53 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v919 @ X0_v52+E4]");
		bool flag47 = (nint)0 == 0;
		object obj54 = !flag47;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj53 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v919 @ X0_v52+B8]");
		object obj55 = 0;
		bool flag48 = obj55 == null;
		num6 = num8;
		text = null;
		if (!flag48)
		{
			List<object>.Enumerator enumerator2 = ((List<object>)obj55).GetEnumerator();
			text4 = (string)((nint)0 + (nint)1240);
			text3 = (string)(typeof(UnityEngine.TextCore.HorizontalAlignment) + 760);
			text = null;
			array4 = (object[])(&enumerator);
			while (enumerator.MoveNext())
			{
				if (array2 == null)
				{
					continue;
				}
				nint num13 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X8_v30 (Il2CppClass<System.Object[]>)+12E]");
				array3 = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X8_v30 (Il2CppClass<System.Object[]>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0efe;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X8_v30 (Il2CppClass<System.Object[]>)+B0]");
				obj8 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X10_v8-8]");
					bool flag49 = 0 < (nint)text3;
					object obj32 = !flag49;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X10_v8-8]");
					object obj33 = 0 - text3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X10_v8-8]");
					if (0 == (nint)text3)
					{
						break;
					}
					obj8 += 16;
					array3 = (object[])(array3 - 1);
					bool flag50 = (nint)array3 < 1;
					obj32 = !flag50;
					obj33 = array3 - 1;
					bool flag28 = obj33 == null;
					if ((nint)array3 != 1)
					{
						continue;
					}
					goto IL_0efe;
				}
				array3 = (object[])(obj8 + 3);
				object obj56 = num13 + array3;
				object obj57 = obj56 + 312;
				goto IL_0f0d;
				IL_0f0d:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1012 @ X0_v59] (should have been resolved before IL gen)");
				resourceCurrency2 = (ResourceCurrency)text8;
				text = (string)type;
				continue;
				IL_0efe:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				goto IL_0f0d;
			}
			num6 = 0.0;
			double num14 = 0.0;
			object obj60 = default(object);
			while (true)
			{
				object obj58 = (nint)0 + (nint)1232;
				text2 = (string)obj58;
				enumerator.Dispose();
				bool flag51 = num14 == 0.0;
				object obj59 = !flag51;
				if (obj59 == null)
				{
					return;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				if ((nint)text2 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				num14 = (double)obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				num6 = (double)obj60;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B15C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		goto IL_1097;
		IL_1097:
		throw new NullReferenceException();
	}

	public unsafe static void AdEvent(AdSDK adSDK, AdAction adAction, AdType adType, AdPlace adPlacement)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0c31: Expected O, but got Ref
		//IL_0c5f: Expected O, but got I4
		//IL_004f: Expected O, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I8
		//IL_0bbb: Expected O, but got I
		//IL_0bd1: Expected O, but got Ref
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_010d: Expected O, but got I4
		//IL_0123: Expected O, but got I
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0198: Expected O, but got Ref
		//IL_01bb: Expected O, but got I8
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_021f: Expected O, but got I4
		//IL_0235: Expected O, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_029b: Expected O, but got Ref
		//IL_02c6: Expected O, but got I4
		//IL_02dc: Expected O, but got I
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_0356: Expected O, but got I4
		//IL_036c: Expected O, but got I
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected I4, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_03d5: Expected O, but got Ref
		//IL_03f8: Expected O, but got I8
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected O, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_05ea: Expected O, but got I4
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected O, but got Unknown
		//IL_050c: Expected O, but got I
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_0636: Expected O, but got I
		//IL_0650: Expected O, but got I4
		//IL_069e: Expected O, but got I4
		//IL_0595: Expected O, but got I4
		//IL_074d: Expected O, but got I4
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected O, but got Unknown
		//IL_07f5: Expected O, but got I4
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5d: Expected O, but got Unknown
		//IL_0a98: Expected O, but got I4
		//IL_0b02: Expected O, but got I
		//IL_0b24: Expected O, but got I4
		//IL_0870: Expected O, but got I
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected O, but got Unknown
		//IL_0c7b: Expected O, but got Ref
		//IL_0a0e: Expected O, but got Ref
		//IL_08fd: Expected O, but got I
		//IL_093a: Expected O, but got I
		//IL_0975: Expected O, but got I
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Expected O, but got Unknown
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected O, but got Unknown
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected O, but got Unknown
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected O, but got Unknown
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a6: Expected O, but got Unknown
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(SqlSingle[]) + 2792;
		object obj4 = typeof(SqlSingle[]) + 32;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj5 = default(object);
		string text = ((Enum)(&obj5)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		bool flag = array == null;
		AdType adType3 = default(AdType);
		AdType adType2 = adType3;
		string text2 = (string)8;
		if (flag)
		{
			goto IL_0b4a;
		}
		bool flag2 = array.Length == 0;
		text2 = (string)8;
		object obj37;
		string text6;
		object obj42;
		object obj45;
		if (!flag2)
		{
			object obj6 = "_InputUv1BufferOffset" + 4032;
			text2 = (string)obj6;
			object obj7 = array + 32;
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X24_v8-8]");
			object obj8 = 0 & 0xFFFFFFFEL;
			if (obj8 != null)
			{
				object obj9 = array + 40;
				obj9 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X24_v10-10]");
				bool flag3 = (nint)0 < (nint)2;
				object obj10 = !flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X24_v10-10]");
				object obj11 = -2;
				bool flag4 = obj11 == null;
				object obj12 = ~obj10;
				object obj13 = obj12 | flag4;
				text2 = text;
				if (obj13 == null)
				{
					object obj14 = "1.2.840.113549.1.12.1.5" + 1488;
					object obj15 = array + 48;
					obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj16 = default(object);
					string text3 = ((Enum)(&obj16)).ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X24_v12-18]");
					object obj17 = 0 & 0xFFFFFFFCL;
					bool flag5 = obj17 == null;
					text2 = null;
					if (!flag5)
					{
						object obj18 = array + 56;
						obj18 = text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X24_v14-20]");
						bool flag6 = (nint)0 < (nint)4;
						object obj19 = !flag6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X24_v14-20]");
						object obj20 = -4;
						bool flag7 = obj20 == null;
						object obj21 = ~obj19;
						object obj22 = obj21 | flag7;
						text2 = text3;
						if (obj22 == null)
						{
							object obj23 = array + 64;
							obj23 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj24 = default(object);
							string text4 = ((Enum)(&obj24)).ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X24_v16-28]");
							bool flag8 = (nint)0 < (nint)5;
							object obj25 = !flag8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X24_v16-28]");
							object obj26 = -5;
							bool flag9 = obj26 == null;
							object obj27 = ~obj25;
							object obj28 = obj27 | flag9;
							text2 = null;
							if (obj28 == null)
							{
								object obj29 = array + 72;
								obj29 = text4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X24_v18-30]");
								bool flag10 = (nint)0 < (nint)6;
								object obj30 = !flag10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X24_v18-30]");
								object obj31 = -6;
								bool flag11 = obj31 == null;
								object obj32 = ~obj30;
								bool flag12 = (byte)((obj32 | flag11) ? 1 : 0) != 0;
								text2 = text4;
								if (!flag12)
								{
									object obj33 = array + 80;
									obj33 = obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object obj34 = default(object);
									string text5 = ((Enum)(&obj34)).ToString();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X24_v20-38]");
									object obj35 = 0 & 0xFFFFFFF8L;
									bool flag13 = obj35 == null;
									text2 = null;
									if (!flag13)
									{
										object obj36 = typeof(DataRelation) + 856;
										obj37 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
										object obj38 = array + 88;
										obj38 = text5;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										string message = string.Concat(array);
										object obj39 = obj36;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v23+E4]");
										if ((nint)0 != 0)
										{
											Debug.Log(message);
											object obj40 = obj37;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v95+E4]");
											bool flag14 = (nint)0 == 0;
											text2 = null;
											text6 = null;
											if (!flag14)
											{
												goto IL_04e2;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											Debug.Log(message);
											object obj40 = obj37;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v95+E4]");
											bool flag15 = (nint)0 == 0;
											object obj41 = !flag15;
											text2 = null;
											text6 = null;
											if (obj41 != null)
											{
												goto IL_04e2;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj42 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
										object obj43 = (nint)0 & (nint)1;
										bool flag16 = obj43 == null;
										object obj44 = !flag16;
										text2 = text6;
										obj45 = obj42;
										if (obj44 != null)
										{
											goto IL_0539;
										}
										goto IL_066e;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0b58;
		IL_04e2:
		obj42 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
		object obj46 = (nint)0 & (nint)1;
		bool flag17 = obj46 == null;
		text6 = text2;
		obj45 = obj42;
		if (!flag17)
		{
			goto IL_0539;
		}
		goto IL_066e;
		IL_066e:
		_ = 1;
		object obj47 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X0_v86+E4]");
		bool flag18 = (nint)0 == 0;
		object obj48 = !flag18;
		text2 = text6;
		obj42 = obj45;
		if (obj48 != null)
		{
			goto IL_0576;
		}
		goto IL_06bc;
		IL_0539:
		obj47 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X0_v86+E4]");
		bool flag19 = (nint)0 == 0;
		text6 = text2;
		obj45 = obj42;
		if (!flag19)
		{
			goto IL_0576;
		}
		goto IL_06bc;
		IL_06bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isInitialized = Config.IsInitialized;
		bool flag20 = !isInitialized;
		text2 = text6;
		obj42 = obj45;
		if (!flag20)
		{
			goto IL_06fd;
		}
		return;
		IL_0576:
		bool isInitialized2 = Config.IsInitialized;
		bool flag21 = !isInitialized2;
		object obj49 = !flag21;
		if (obj49 == null)
		{
			return;
		}
		goto IL_06fd;
		IL_06fd:
		object obj50 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X0_v49+E4]");
		if ((nint)0 != 0)
		{
			bool isProduction = Config.IsProduction;
			bool flag22 = !isProduction;
			object obj51 = !flag22;
			if (obj51 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!Config.IsProduction)
			{
				return;
			}
		}
		object obj52 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj53 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X0_v51+E4]");
		if ((nint)0 != 0)
		{
			bool noPlayServices = KUtil.NoPlayServices;
			bool flag23 = !noPlayServices;
			object obj54 = !flag23;
			if (obj54 == null)
			{
				goto IL_0803;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!KUtil.NoPlayServices)
			{
				goto IL_0803;
			}
		}
		object obj55 = "HH:mm:ss.ffZ" + 1744;
		string text7 = (string)obj55 + text;
		object obj56 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X0_v75+E4]");
		bool flag24 = (nint)0 == 0;
		object obj57 = !flag24;
		adType2 = AdType.Rewarded;
		text2 = text;
		string text8 = text7;
		AdType adType4 = AdType.Rewarded;
		string text9 = text;
		object obj58 = obj56;
		string text10 = text7;
		if (obj57 != null)
		{
			goto IL_0860;
		}
		goto IL_0ae0;
		IL_0860:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X0_v75+B8]");
		object obj59 = 0;
		List<object> list = (List<object>)obj59;
		if (obj59 != null)
		{
			goto IL_0895;
		}
		goto IL_0b4a;
		IL_0ae0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj60 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X0_v54+B8]");
		object obj61 = 0;
		list = (List<object>)obj61;
		bool flag25 = obj61 == null;
		object obj62 = !flag25;
		text8 = text10;
		adType2 = adType4;
		text2 = text9;
		if (obj62 != null)
		{
			goto IL_0895;
		}
		goto IL_0b4a;
		IL_0803:
		obj56 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X0_v75+E4]");
		bool flag26 = (nint)0 == 0;
		adType2 = adType3;
		text8 = text;
		adType4 = adType3;
		text9 = text2;
		obj58 = obj56;
		text10 = text;
		if (!flag26)
		{
			goto IL_0860;
		}
		goto IL_0ae0;
		IL_0b4a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b58;
		IL_0b58:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		bool flag27 = (nint)text2 != 1;
		obj5 = obj3;
		IndexOutOfRangeException ex3 = ex2;
		if (!flag27)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj63 = (nint)0 + (nint)1232;
			text2 = (string)obj63;
			List<object>.Enumerator enumerator = (List<object>.Enumerator)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
			((List<object>.Enumerator*)enumerator)->Dispose();
			object obj64 = default(object);
			if (obj64 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			obj5 = obj64;
			ex3 = (IndexOutOfRangeException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B15C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0895:
		List<object>.Enumerator enumerator2 = list.GetEnumerator();
		object obj65 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 760;
		AdPlace adPlace = adPlacement;
		while (true)
		{
			List<object>.Enumerator enumerator3 = (List<object>.Enumerator)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
			if (!((List<object>.Enumerator*)enumerator3)->MoveNext())
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
			if ((nint)0 == 0)
			{
				continue;
			}
			object obj67 = obj66;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X8_v41+12E]");
			object obj68 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X8_v41+12E]");
			if ((nint)0 == 0)
			{
				goto IL_08c7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X8_v41+B0]");
			object obj69 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X10_v7-8]");
				object obj31 = 0 - obj65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X10_v7-8]");
				if (0 == (nint)obj65)
				{
					break;
				}
				obj69 += 16;
				obj68--;
				obj31 = obj68 - 1;
				bool flag13 = obj31 == null;
				if ((nint)obj68 != 1)
				{
					continue;
				}
				goto IL_08c7;
			}
			object obj70 = obj67 + obj69;
			object obj71 = obj70 + 312;
			goto IL_08d6;
			IL_08d6:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v748 @ X0_v70] (should have been resolved before IL gen)");
			adPlace = (AdPlace)adType3;
			continue;
			IL_08c7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_08d6;
		}
		List<object>.Enumerator enumerator4 = (List<object>.Enumerator)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
		((List<object>.Enumerator*)enumerator4)->Dispose();
	}

	public unsafe static void UserProfile()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0244: Expected O, but got I
		//IL_025e: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0184: Expected O, but got I
		//IL_02a4: Expected O, but got I4
		//IL_01fd: Expected O, but got I4
		//IL_033f: Expected O, but got I4
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_03c1: Expected O, but got I4
		//IL_03ea: Expected O, but got I
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_0484: Expected O, but got I4
		//IL_3299: Expected O, but got I
		//IL_32a9: Expected O, but got I
		//IL_32cb: Expected O, but got I4
		//IL_050c: Expected O, but got I
		//IL_0547: Expected O, but got I4
		//IL_336a: Expected O, but got I
		//IL_337a: Expected O, but got I
		//IL_339c: Expected O, but got I4
		//IL_04cb: Expected O, but got I4
		//IL_05fe: Expected O, but got I4
		//IL_32e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ed: Expected O, but got Unknown
		//IL_3303: Expected O, but got I
		//IL_3314: Expected I, but got O
		//IL_3332: Expected O, but got I
		//IL_334d: Expected O, but got I4
		//IL_058e: Expected O, but got I4
		//IL_04fb: Expected O, but got I
		//IL_33b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_33be: Expected O, but got Unknown
		//IL_33d4: Expected O, but got I
		//IL_33e5: Expected I, but got O
		//IL_3403: Expected O, but got I
		//IL_341e: Expected O, but got I4
		//IL_0655: Expected O, but got I
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected O, but got Unknown
		//IL_05be: Expected O, but got I
		//IL_3438: Expected F4, but got I4
		//IL_0698: Expected O, but got I4
		//IL_347b: Expected F4, but got I4
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected O, but got Unknown
		//IL_0738: Expected O, but got I4
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected O, but got Unknown
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected O, but got Unknown
		//IL_34c6: Expected O, but got I4
		//IL_350d: Expected O, but got I4
		//IL_3535: Expected O, but got I4
		//IL_357c: Expected O, but got I4
		//IL_35a4: Expected O, but got I4
		//IL_35eb: Expected O, but got I4
		//IL_3629: Expected O, but got I4
		//IL_3651: Expected O, but got I4
		//IL_3698: Expected O, but got I4
		//IL_36c0: Expected O, but got I4
		//IL_3707: Expected O, but got I4
		//IL_372f: Expected O, but got I4
		//IL_3776: Expected O, but got I4
		//IL_379e: Expected O, but got I4
		//IL_37e5: Expected O, but got I4
		//IL_380d: Expected O, but got I4
		//IL_3854: Expected O, but got I4
		//IL_387c: Expected O, but got I4
		//IL_38c3: Expected O, but got I4
		//IL_38eb: Expected O, but got I4
		//IL_3932: Expected O, but got I4
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Expected O, but got Unknown
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected O, but got Unknown
		//IL_395a: Expected O, but got I4
		//IL_39a1: Expected O, but got I4
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Expected O, but got Unknown
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_097e: Expected O, but got Unknown
		//IL_39c9: Expected O, but got I4
		//IL_3a10: Expected O, but got I4
		//IL_09a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ac: Expected O, but got Unknown
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Expected O, but got Unknown
		//IL_3a97: Expected O, but got I4
		//IL_3a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aa4: Expected O, but got Unknown
		//IL_3aeb: Expected O, but got I4
		//IL_3b72: Expected O, but got I4
		//IL_3b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b7f: Expected O, but got Unknown
		//IL_3bc6: Expected O, but got I4
		//IL_0a11: Expected O, but got I4
		//IL_0a2b: Expected O, but got I4
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Expected O, but got Unknown
		//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc8: Expected O, but got Unknown
		//IL_3c72: Expected O, but got I4
		//IL_3c11: Expected O, but got I4
		//IL_3c53: Expected O, but got I4
		//IL_0a83: Expected O, but got I4
		//IL_3cb9: Expected O, but got I4
		//IL_3ce3: Expected O, but got I4
		//IL_0b38: Expected O, but got I4
		//IL_0ab2: Expected O, but got I4
		//IL_0acc: Expected O, but got I4
		//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c13: Expected O, but got Unknown
		//IL_0c3d: Expected O, but got I4
		//IL_0b67: Expected O, but got I4
		//IL_0b81: Expected O, but got I4
		//IL_0c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Expected O, but got Unknown
		//IL_0d9f: Expected O, but got I4
		//IL_0da8: Expected O, but got I4
		//IL_0db1: Expected O, but got I4
		//IL_0cee: Expected O, but got I4
		//IL_0cf7: Expected O, but got I4
		//IL_0df7: Expected O, but got I4
		//IL_3d24: Expected O, but got I4
		//IL_0d56: Expected O, but got I4
		//IL_0f4f: Expected O, but got I4
		//IL_0f58: Expected O, but got I4
		//IL_0f61: Expected O, but got I4
		//IL_0e9e: Expected O, but got I4
		//IL_0ea7: Expected O, but got I4
		//IL_0fa7: Expected O, but got I4
		//IL_3d6d: Expected O, but got I4
		//IL_0f06: Expected O, but got I4
		//IL_10ff: Expected O, but got I4
		//IL_1108: Expected O, but got I4
		//IL_1111: Expected O, but got I4
		//IL_104e: Expected O, but got I4
		//IL_1057: Expected O, but got I4
		//IL_1157: Expected O, but got I4
		//IL_3db6: Expected O, but got I4
		//IL_10b6: Expected O, but got I4
		//IL_1251: Expected O, but got I4
		//IL_125a: Expected O, but got I4
		//IL_11fc: Expected O, but got I4
		//IL_1205: Expected O, but got I4
		//IL_1448: Unknown result type (might be due to invalid IL or missing references)
		//IL_144d: Expected O, but got Unknown
		//IL_1477: Expected O, but got I4
		//IL_1292: Expected O, but got I4
		//IL_14a8: Expected O, but got Ref
		//IL_121c: Expected O, but got I4
		//IL_14bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c0: Expected O, but got Unknown
		//IL_14e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e5: Expected O, but got Unknown
		//IL_150f: Expected O, but got I4
		//IL_3e5d: Expected O, but got Ref
		//IL_1307: Expected O, but got I4
		//IL_1546: Unknown result type (might be due to invalid IL or missing references)
		//IL_154b: Expected O, but got Unknown
		//IL_155a: Unknown result type (might be due to invalid IL or missing references)
		//IL_155f: Expected O, but got Unknown
		//IL_1575: Expected O, but got I
		//IL_3ded: Expected O, but got I4
		//IL_1690: Expected O, but got I4
		//IL_134e: Expected O, but got I4
		//IL_16ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f2: Expected O, but got Unknown
		//IL_171c: Expected O, but got I4
		//IL_1770: Expected O, but got I4
		//IL_1779: Expected O, but got I4
		//IL_1782: Expected O, but got I4
		//IL_160d: Expected O, but got I4
		//IL_1616: Expected O, but got I4
		//IL_16d0: Expected O, but got I4
		//IL_164d: Expected O, but got I4
		//IL_13c3: Expected O, but got I4
		//IL_3e1c: Expected O, but got I4
		//IL_18c6: Expected O, but got I
		//IL_17f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fc: Expected O, but got Unknown
		//IL_1804: Expected I, but got O
		//IL_1814: Expected O, but got I
		//IL_13ee: Expected I4, but got I8
		//IL_141c: Expected O, but got I4
		//IL_18a3: Expected O, but got I4
		//IL_3e3c: Expected O, but got I4
		//IL_3eb7: Expected O, but got I
		//IL_3ed1: Expected O, but got I4
		//IL_184f: Expected O, but got I
		//IL_19a4: Expected O, but got I4
		//IL_1a29: Expected O, but got I4
		//IL_19d9: Expected O, but got I4
		//IL_190c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1911: Expected O, but got Unknown
		//IL_191a: Unknown result type (might be due to invalid IL or missing references)
		//IL_191f: Expected O, but got Unknown
		//IL_1a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5b: Expected O, but got Unknown
		//IL_185d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1862: Expected O, but got Unknown
		//IL_186b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1870: Expected O, but got Unknown
		//IL_1ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cab: Expected O, but got Unknown
		//IL_1cc9: Expected O, but got I
		//IL_1a9b: Expected O, but got I
		//IL_1ab5: Expected O, but got I4
		//IL_1d2d: Expected O, but got I4
		//IL_1b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2d: Expected O, but got Unknown
		//IL_1d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d4f: Expected O, but got Unknown
		//IL_1d79: Expected O, but got I4
		//IL_1e16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1b: Expected O, but got Unknown
		//IL_1e39: Expected O, but got I
		//IL_1dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db2: Expected O, but got Unknown
		//IL_1dd4: Expected O, but got I4
		//IL_1ddd: Expected O, but got I4
		//IL_1dee: Expected O, but got I4
		//IL_1b8d: Expected O, but got I
		//IL_1ba7: Expected O, but got I4
		//IL_1ead: Expected O, but got I4
		//IL_1eca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ecf: Expected O, but got Unknown
		//IL_1ef9: Expected O, but got I4
		//IL_1f4d: Expected O, but got I4
		//IL_1f56: Expected O, but got I4
		//IL_1f5f: Expected O, but got I4
		//IL_1c89: Expected O, but got I4
		//IL_1fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcf: Expected O, but got Unknown
		//IL_1ff5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ffa: Expected O, but got Unknown
		//IL_2010: Expected O, but got I
		//IL_20e7: Expected O, but got I4
		//IL_2144: Unknown result type (might be due to invalid IL or missing references)
		//IL_2149: Expected O, but got Unknown
		//IL_2173: Expected O, but got I4
		//IL_20a4: Expected O, but got I4
		//IL_2127: Expected O, but got I4
		//IL_21df: Expected O, but got I4
		//IL_21ef: Expected O, but got I
		//IL_2211: Expected O, but got I4
		//IL_2245: Unknown result type (might be due to invalid IL or missing references)
		//IL_224a: Expected O, but got Unknown
		//IL_2260: Expected O, but got I
		//IL_2340: Expected O, but got I4
		//IL_239d: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a2: Expected O, but got Unknown
		//IL_23cc: Expected O, but got I4
		//IL_22f4: Expected O, but got I4
		//IL_22fd: Expected O, but got I4
		//IL_2380: Expected O, but got I4
		//IL_240e: Expected O, but got I4
		//IL_2441: Unknown result type (might be due to invalid IL or missing references)
		//IL_2446: Expected O, but got Unknown
		//IL_246c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2471: Expected O, but got Unknown
		//IL_2487: Expected O, but got I
		//IL_255e: Expected O, but got I4
		//IL_25bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c0: Expected O, but got Unknown
		//IL_25ea: Expected O, but got I4
		//IL_251b: Expected O, but got I4
		//IL_259e: Expected O, but got I4
		//IL_262c: Expected O, but got I4
		//IL_2667: Unknown result type (might be due to invalid IL or missing references)
		//IL_266c: Expected O, but got Unknown
		//IL_2682: Expected O, but got I
		//IL_272c: Expected O, but got I4
		//IL_278e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2793: Expected O, but got Unknown
		//IL_27bd: Expected O, but got I4
		//IL_27f0: Expected O, but got I4
		//IL_276c: Expected O, but got I4
		//IL_2810: Unknown result type (might be due to invalid IL or missing references)
		//IL_2815: Expected O, but got Unknown
		//IL_282b: Expected O, but got I
		//IL_2902: Expected O, but got I4
		//IL_295f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2964: Expected O, but got Unknown
		//IL_298e: Expected O, but got I4
		//IL_28bf: Expected O, but got I4
		//IL_2942: Expected O, but got I4
		//IL_29d0: Expected O, but got I4
		//IL_2a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a3e: Expected O, but got Unknown
		//IL_2a54: Expected O, but got I
		//IL_2c26: Expected O, but got I4
		//IL_2c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c88: Expected O, but got Unknown
		//IL_2cb2: Expected O, but got I4
		//IL_2ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ceb: Expected O, but got Unknown
		//IL_2d0d: Expected O, but got I4
		//IL_2d16: Expected O, but got I4
		//IL_2d27: Expected O, but got I4
		//IL_2ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad3: Expected O, but got Unknown
		//IL_2c66: Expected O, but got I4
		//IL_2b3c: Expected O, but got I4
		//IL_2d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d54: Expected O, but got Unknown
		//IL_2d72: Expected O, but got I
		//IL_2d8c: Expected O, but got I4
		//IL_2baa: Expected O, but got I
		//IL_2f1a: Expected O, but got I4
		//IL_2e15: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1a: Expected O, but got Unknown
		//IL_2f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f3c: Expected O, but got Unknown
		//IL_2f66: Expected O, but got I4
		//IL_3003: Unknown result type (might be due to invalid IL or missing references)
		//IL_3008: Expected O, but got Unknown
		//IL_3026: Expected O, but got I
		//IL_3040: Expected O, but got I4
		//IL_2f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f9f: Expected O, but got Unknown
		//IL_2fc1: Expected O, but got I4
		//IL_2fca: Expected O, but got I4
		//IL_2fdb: Expected O, but got I4
		//IL_321e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3223: Expected O, but got Unknown
		//IL_322d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3232: Expected O, but got Unknown
		//IL_324c: Expected O, but got I4
		//IL_3131: Expected O, but got I4
		//IL_4000: Expected O, but got I
		//IL_2e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e88: Expected O, but got Unknown
		//IL_2ea6: Expected O, but got I
		//IL_314e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3153: Expected O, but got Unknown
		//IL_317d: Expected O, but got I4
		//IL_31d1: Expected O, but got I4
		//IL_31da: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D7B]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v957+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v957+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool hasTrackedUserProfileToday = HasTrackedUserProfileToday;
		bool flag3 = !hasTrackedUserProfileToday;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			goto IL_012d;
		}
		return;
		IL_1629:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag4 = (object)sessionModel == null;
		object obj7 = !flag4;
		if (obj7 != null)
		{
			goto IL_17be;
		}
		goto IL_3282;
		IL_2e0b:
		object obj8 = "Cannot populate JSON object onto type '{0}'." + 3024;
		string text = (string)obj8;
		ClanUserModel clanMembership;
		bool flag5 = clanMembership == null;
		object obj10;
		object obj9 = obj10;
		string text3;
		string text2 = text3;
		string text4 = (string)obj8;
		if (!flag5)
		{
			goto IL_2e57;
		}
		goto IL_2ff9;
		IL_22aa:
		if (KUtil.NoPlayServices)
		{
			goto IL_22d0;
		}
		goto IL_238e;
		IL_007c:
		if (HasTrackedUserProfileToday)
		{
			return;
		}
		goto IL_012d;
		IL_012d:
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v3+E4]");
		object obj12;
		object obj14;
		if ((nint)0 != 0)
		{
			obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
			object obj13 = (nint)0 & (nint)1;
			bool flag6 = obj13 == null;
			obj14 = obj12;
			if (!flag6)
			{
				goto IL_01a9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
			object obj15 = (nint)0 & (nint)1;
			bool flag7 = obj15 == null;
			object obj16 = !flag7;
			obj14 = obj12;
			if (obj16 != null)
			{
				goto IL_01a9;
			}
		}
		_ = 1;
		object obj17 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v839+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		obj12 = obj14;
		if (obj18 != null)
		{
			goto IL_01de;
		}
		goto IL_02ba;
		IL_2950:
		object obj19 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2712 @ X0_v308+E4]");
		bool flag9 = (nint)0 == 0;
		object obj21 = !flag9;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object name;
		string carrierProviderName;
		FirebaseAnalytics.SetUserProperty((string)name, carrierProviderName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj10 = 0;
		goto IL_29d5;
		IL_2875:
		if (KUtil.NoPlayServices)
		{
			goto IL_289b;
		}
		goto IL_2950;
		IL_3f88:
		object obj23;
		object obj22 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2852 @ X0_v227+E4]");
		if ((nint)0 != 0)
		{
			if (KUtil.NoPlayServices)
			{
				goto IL_2e0b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool noPlayServices = KUtil.NoPlayServices;
			bool flag10 = !noPlayServices;
			object obj24 = !flag10;
			if (obj24 != null)
			{
				goto IL_2e0b;
			}
		}
		object obj25 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2882 @ X0_v255+E4]");
		bool flag11 = (nint)0 == 0;
		object obj27 = !flag11;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text5;
		string text6;
		FirebaseAnalytics.SetUserProperty(text5, text6);
		object obj28 = "Cannot populate JSON object onto type '{0}'." + 3024;
		text = (string)obj28;
		bool flag12 = clanMembership == null;
		object obj29 = !flag12;
		obj10 = 0;
		text3 = text6;
		obj9 = 0;
		text2 = text6;
		text4 = (string)obj28;
		if (obj29 != null)
		{
			goto IL_2e57;
		}
		goto IL_2ff9;
		IL_01a9:
		obj17 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v839+E4]");
		bool flag13 = (nint)0 == 0;
		obj14 = obj12;
		if (!flag13)
		{
			goto IL_01de;
		}
		goto IL_02ba;
		IL_02ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isInitialized = Config.IsInitialized;
		bool flag14 = !isInitialized;
		obj12 = obj14;
		if (!flag14)
		{
			goto IL_02f3;
		}
		return;
		IL_01de:
		bool isInitialized2 = Config.IsInitialized;
		bool flag15 = !isInitialized2;
		object obj30 = !flag15;
		if (obj30 == null)
		{
			return;
		}
		goto IL_02f3;
		IL_02f3:
		object obj31 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			bool isProduction = Config.IsProduction;
			bool flag16 = !isProduction;
			object obj32 = !flag16;
			if (obj32 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!Config.IsProduction)
			{
				return;
			}
		}
		object obj33 = typeof(Queue<string>) + 848;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v7+E4]");
		bool flag17 = (nint)0 == 0;
		object obj35 = !flag17;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj36 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser = sessionModel2.LocalUser;
		List<StoreOwnedItem> ownedRoomThemes = SFSKammelnaUserExtensions.GetOwnedRoomThemes(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		User localUser2 = sessionModel3.LocalUser;
		List<StoreOwnedItem> ownedCards = SFSKammelnaUserExtensions.GetOwnedCards(localUser2);
		object obj37 = typeof(TrackedDeviceRaycaster.<>c) + 16;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v20+E4]");
		bool flag18 = (nint)0 == 0;
		object obj39 = !flag18;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj37;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v20+B8]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v382+8]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v382+8]");
		bool flag19 = (nint)0 == 0;
		object obj41 = !flag19;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v20+E4]");
			bool flag20 = (nint)0 == 0;
			object obj42 = !flag20;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj43 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v388+B8]");
				obj40 = 0;
			}
			object obj44 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj45 = (nint)0 + (nint)656;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj40, (IntPtr)obj45);
			object obj46 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X8_v387+B8]");
			object obj47 = (nint)0 + (nint)8;
			obj47 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj48 = 0;
			predicate = func;
		}
		object obj49 = (nint)0 + (nint)1264;
		object obj50 = Enumerable.FirstOrDefault(ownedRoomThemes, predicate);
		object obj51 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X0_v25+E4]");
		bool flag21 = (nint)0 == 0;
		object obj52 = !flag21;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj51 = obj37;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X0_v25+B8]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X8_v374+10]");
		Func<object, bool> predicate2 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X8_v374+10]");
		bool flag22 = (nint)0 == 0;
		object obj54 = !flag22;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X0_v25+E4]");
			bool flag23 = (nint)0 == 0;
			object obj55 = !flag23;
			if (obj55 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj56 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ X8_v380+B8]");
				obj53 = 0;
			}
			object obj57 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj58 = (nint)0 + (nint)664;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj53, (IntPtr)obj58);
			object obj59 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X8_v379+B8]");
			object obj60 = (nint)0 + (nint)16;
			obj60 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj48 = 0;
			predicate2 = func2;
		}
		object obj61 = Enumerable.FirstOrDefault(ownedCards, predicate2);
		object obj62 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X0_v29+E4]");
		bool flag24 = (nint)0 == 0;
		object obj63 = !flag24;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel4 = default(SessionModel);
		User localUser3 = sessionModel4.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser3);
		object obj64 = (nint)0 + (nint)88;
		object obj65 = typeof(TrackedDeviceRaycaster.<>c) + 32;
		float? value = aces;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent = default(TrackerLibrary.TrackerEvent);
		trackerEvent..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.OwnedAces, null, value);
		object obj66 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X0_v39+E4]");
		bool flag25 = (nint)0 == 0;
		object obj67 = !flag25;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DesignEvent(trackerEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel5 = default(SessionModel);
		User localUser4 = sessionModel5.LocalUser;
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser4);
		value = rank.<Points>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent2 = default(TrackerLibrary.TrackerEvent);
		trackerEvent2..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.RankPoints, null, value);
		DesignEvent(trackerEvent2);
		object obj68 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj69 = obj68;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X0_v51+E4]");
		bool flag26 = (nint)0 == 0;
		object obj70 = !flag26;
		if (obj70 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool gameSound = Preferences.GameSound;
		object obj71 = "Drop Menu Toggle" + 2544;
		object obj72 = "DNQUALIFIER" + 3304;
		bool flag27 = !gameSound;
		object obj73 = !flag27;
		object obj74 = ~obj73;
		object label = ((obj74 != null) ? obj72 : obj71);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent3 = default(TrackerLibrary.TrackerEvent);
		trackerEvent3..ctor(TrackingContext.Preferences, TrackingFeature.AppPreferences, TrackingPlacement.Settings, TrackingOutcome.GameSound, (string)label, (float?)(object)0);
		DesignEvent(trackerEvent3);
		bool chatSound = Preferences.ChatSound;
		bool flag28 = !chatSound;
		object obj75 = !flag28;
		object obj76 = ~obj75;
		object label2 = ((obj76 != null) ? obj72 : obj71);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent4 = default(TrackerLibrary.TrackerEvent);
		trackerEvent4..ctor(TrackingContext.Preferences, TrackingFeature.AppPreferences, TrackingPlacement.Settings, TrackingOutcome.ChatSound, (string)label2, (float?)(object)0);
		DesignEvent(trackerEvent4);
		bool backgroundMusic = Preferences.BackgroundMusic;
		bool flag29 = !backgroundMusic;
		object obj77 = !flag29;
		object obj78 = ~obj77;
		object label3 = ((obj78 != null) ? obj72 : obj71);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent5 = default(TrackerLibrary.TrackerEvent);
		trackerEvent5..ctor(TrackingContext.Preferences, TrackingFeature.AppPreferences, TrackingPlacement.Settings, TrackingOutcome.GameMusic, (string)label3, (float?)(object)0);
		DesignEvent(trackerEvent5);
		string soundActor = Preferences.SoundActor;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent6 = default(TrackerLibrary.TrackerEvent);
		trackerEvent6..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.VoiceActor, soundActor, (float?)(object)0);
		DesignEvent(trackerEvent6);
		bool multipleVoiceActors = Preferences.MultipleVoiceActors;
		bool flag30 = !multipleVoiceActors;
		object obj79 = !flag30;
		object obj80 = ~obj79;
		object label4 = ((obj80 != null) ? obj72 : obj71);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent7 = default(TrackerLibrary.TrackerEvent);
		trackerEvent7..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.MultiVoiceActor, (string)label4, (float?)(object)0);
		DesignEvent(trackerEvent7);
		bool cardDimming = Preferences.CardDimming;
		bool flag31 = !cardDimming;
		object obj81 = !flag31;
		object obj82 = ~obj81;
		object label5 = ((obj82 != null) ? obj72 : obj71);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent8 = default(TrackerLibrary.TrackerEvent);
		trackerEvent8..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.CardDim, (string)label5, (float?)(object)0);
		DesignEvent(trackerEvent8);
		bool biddingPredetermination = Preferences.BiddingPredetermination;
		bool flag32 = !biddingPredetermination;
		object obj83 = !flag32;
		object obj84 = ~obj83;
		object label6 = ((obj84 != null) ? obj72 : obj71);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent9 = default(TrackerLibrary.TrackerEvent);
		trackerEvent9..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.BidPredetermine, (string)label6, (float?)(object)0);
		DesignEvent(trackerEvent9);
		bool allowDifferentCardElevation = Preferences.AllowDifferentCardElevation;
		bool flag33 = !allowDifferentCardElevation;
		object obj85 = !flag33;
		object obj86 = ~obj85;
		object label7 = ((obj86 != null) ? obj72 : obj71);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent10 = default(TrackerLibrary.TrackerEvent);
		trackerEvent10..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.AllowDifferentCardElevation, (string)label7, (float?)(object)0);
		DesignEvent(trackerEvent10);
		bool allowMyTurnHandAnimation = Preferences.AllowMyTurnHandAnimation;
		bool flag34 = !allowMyTurnHandAnimation;
		object obj87 = !flag34;
		object obj88 = ~obj87;
		object label8 = ((obj88 != null) ? obj72 : obj71);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent11 = default(TrackerLibrary.TrackerEvent);
		trackerEvent11..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.AllowDifferentCardElevation, (string)label8, (float?)(object)0);
		DesignEvent(trackerEvent11);
		bool allowVibration = Preferences.AllowVibration;
		bool flag35 = !allowVibration;
		object obj89 = !flag35;
		object obj90 = ~obj89;
		object label9 = ((obj90 != null) ? obj72 : obj71);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent12 = default(TrackerLibrary.TrackerEvent);
		trackerEvent12..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.AllowDifferentCardElevation, (string)label9, (float?)(object)0);
		DesignEvent(trackerEvent12);
		bool showJackarooTips = Preferences.ShowJackarooTips;
		bool flag36 = !showJackarooTips;
		object obj91 = !flag36;
		object obj92 = ~obj91;
		object label10 = ((obj92 != null) ? obj72 : obj71);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent13 = default(TrackerLibrary.TrackerEvent);
		trackerEvent13..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.ShowJackarooTips, (string)label10, (float?)(object)0);
		DesignEvent(trackerEvent13);
		bool isPerspectiveTopDown = Preferences.IsPerspectiveTopDown;
		object obj93 = "ThisIsFakeReceiptData" + 848;
		object obj94 = "SetRoomVariables request error" + 696;
		bool flag37 = !isPerspectiveTopDown;
		object obj95 = !flag37;
		object obj96 = ~obj95;
		object label11 = ((obj96 != null) ? obj94 : obj93);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent14 = default(TrackerLibrary.TrackerEvent);
		trackerEvent14..ctor(TrackingContext.Preferences, TrackingFeature.GamePreferences, TrackingPlacement.Settings, TrackingOutcome.GamePlayPerspective, (string)label11, (float?)(object)0);
		DesignEvent(trackerEvent14);
		bool flag38 = NotificationPermissionUtils.IsGranted();
		object obj97 = "https://www.kammelna.com/Home/Terms" + 2800;
		object obj98 = "https://www.kammelna.com/Home/Terms" + 3112;
		bool flag39 = !flag38;
		object obj99 = !flag39;
		object obj100 = ~obj99;
		object label12 = ((obj100 != null) ? obj98 : obj97);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent15 = default(TrackerLibrary.TrackerEvent);
		trackerEvent15..ctor(TrackingContext.Preferences, TrackingFeature.AppPreferences, TrackingPlacement.HomeScreen, TrackingOutcome.PushNotificationPermission, (string)label12, (float?)(object)0);
		DesignEvent(trackerEvent15);
		object obj101 = "October" + 1624;
		object obj102 = "DNQUALIFIER" + 3720;
		bool flag40 = ownedCards._size < 0;
		bool flag41 = ownedCards._size == 0;
		int num = ownedCards._size ^ ownedCards._size;
		int num2 = ownedCards._size & num;
		bool flag42 = num2 < 0;
		bool flag43 = flag40 == flag42;
		object obj103 = !flag41;
		object obj104 = flag43 & obj103;
		object obj105 = ~obj104;
		object label13 = ((obj105 != null) ? obj102 : obj101);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent16 = default(TrackerLibrary.TrackerEvent);
		trackerEvent16..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.Cards, (string)label13, (float?)(object)0);
		DesignEvent(trackerEvent16);
		bool flag44 = ownedCards._size < 0;
		bool flag45 = ownedCards._size == 0;
		int num3 = ownedCards._size ^ ownedCards._size;
		int num4 = ownedCards._size & num3;
		bool flag46 = num4 < 0;
		bool flag47 = flag44 == flag46;
		object obj106 = !flag45;
		object obj107 = flag47 & obj106;
		object obj108 = ~obj107;
		object obj109 = ((obj108 != null) ? obj102 : obj101);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent17 = default(TrackerLibrary.TrackerEvent);
		trackerEvent17..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.Rooms, (string)obj109, (float?)(object)0);
		DesignEvent(trackerEvent17);
		bool flag48 = obj61 == null;
		object obj110 = 0;
		string text7 = (string)obj109;
		TrackingOutcome trackingOutcome = TrackingOutcome.Rooms;
		float? num5 = (float?)(object)0;
		TrackingPlacement trackingPlacement = TrackingPlacement.Background;
		TrackingFeature trackingFeature = TrackingFeature.UserInfo;
		TrackingContext trackingContext = TrackingContext.Diagnostic;
		if (!flag48)
		{
			string name2 = ((StoreOwnedItem)obj61).name;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TrackerLibrary.TrackerEvent trackerEvent18 = default(TrackerLibrary.TrackerEvent);
			trackerEvent18..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.ActiveCard, name2, (float?)(object)0);
			object obj111 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1673 @ X0_v664+E4]");
			bool flag49 = (nint)0 == 0;
			object obj112 = !flag49;
			if (obj112 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DesignEvent(trackerEvent18);
			obj110 = 0;
			text7 = name2;
			trackingOutcome = TrackingOutcome.ActiveCard;
			num5 = (float?)(object)0;
			trackingPlacement = TrackingPlacement.Background;
			trackingFeature = TrackingFeature.UserInfo;
			trackingContext = TrackingContext.Diagnostic;
		}
		if (obj50 != null)
		{
			string name3 = ((StoreOwnedItem)obj50).name;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TrackerLibrary.TrackerEvent trackerEvent19 = default(TrackerLibrary.TrackerEvent);
			trackerEvent19..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.ActiveRoom, name3, (float?)(object)0);
			object obj113 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1682 @ X0_v652+E4]");
			bool flag50 = (nint)0 == 0;
			object obj114 = !flag50;
			if (obj114 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DesignEvent(trackerEvent19);
			obj110 = 0;
			text7 = name3;
			trackingOutcome = TrackingOutcome.ActiveRoom;
			num5 = (float?)(object)0;
			trackingPlacement = TrackingPlacement.Background;
			trackingFeature = TrackingFeature.UserInfo;
			trackingContext = TrackingContext.Diagnostic;
		}
		bool hasScreenCutout = ScreenUtility.HasScreenCutout;
		object obj115 = "HH:mm:ss.ffZ" + 912;
		object obj116 = "Network Authentication Required" + 1368;
		bool flag51 = !hasScreenCutout;
		object obj117 = !flag51;
		object obj118 = ~obj117;
		object label14 = ((obj118 != null) ? obj116 : obj115);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TrackerLibrary.TrackerEvent trackerEvent20 = default(TrackerLibrary.TrackerEvent);
		trackerEvent20..ctor(TrackingContext.Diagnostic, TrackingFeature.UserInfo, TrackingPlacement.Background, TrackingOutcome.ScreenCutOut, (string)label14, (float?)(object)0);
		object obj119 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1691 @ X0_v146+E4]");
		bool flag52 = (nint)0 == 0;
		object obj120 = !flag52;
		if (obj120 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DesignEvent(trackerEvent20);
		object obj121 = typeof(Queue<string>) + 848;
		object obj122 = obj121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1699 @ X0_v149+E4]");
		bool flag53 = (nint)0 == 0;
		object obj123 = !flag53;
		if (obj123 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel6 = default(SessionModel);
		User localUser5 = sessionModel6.LocalUser;
		string userTwitterID = SFSKammelnaUserExtensions.GetUserTwitterID(localUser5);
		object obj124 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj125 = obj124;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1710 @ X8_v76+E4]");
		object obj127;
		object obj126;
		if ((nint)0 != 0)
		{
			bool flag54 = StringsExtensions.IsNullOrEmpty(userTwitterID);
			bool flag55 = !flag54;
			obj126 = 0;
			obj127 = 0;
			if (!flag55)
			{
				goto IL_0d05;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag56 = StringsExtensions.IsNullOrEmpty(userTwitterID);
			bool flag57 = !flag56;
			object obj128 = !flag57;
			obj126 = 0;
			obj127 = 0;
			if (obj128 != null)
			{
				goto IL_0d05;
			}
		}
		ITrackEvent trackEvent = TrackerLibrary.StatisticsSocialLinked(SocialPlatform.Twitter);
		object obj129 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1750 @ X8_v314+E4]");
		bool flag58 = (nint)0 == 0;
		object obj130 = !flag58;
		if (obj130 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DesignEvent(trackEvent);
		object obj131 = obj121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1747 @ X0_v614+E4]");
		bool flag59 = (nint)0 == 0;
		object obj132 = !flag59;
		obj126 = obj127;
		if (obj132 != null)
		{
			goto IL_0d32;
		}
		goto IL_0e14;
		IL_1890:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj133 = 0;
		object obj135 = default(object);
		object obj134 = obj135;
		goto IL_3e8a;
		IL_3e8a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2209 @ X8_v279] (should have been resolved before IL gen)");
		int num6 = default(int);
		string text8 = num6.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D71]");
		object obj136 = (nint)0 & (nint)1;
		bool flag60 = obj136 == null;
		object obj137 = !flag60;
		string text9 = text8;
		string text10 = null;
		object obj138 = obj133;
		string text11 = text8;
		string text12 = null;
		if (obj137 == null)
		{
			goto IL_1924;
		}
		goto IL_3f01;
		IL_2ff9:
		object obj139 = "Network Authentication Required" + 1600;
		string text13 = (string)obj139;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
		object obj140 = (nint)0 & (nint)1;
		bool flag61 = obj140 == null;
		object obj141 = !flag61;
		obj10 = obj9;
		text3 = text2;
		text = text4;
		string text14 = (string)obj139;
		if (obj141 == null)
		{
			goto IL_306e;
		}
		goto IL_3fb5;
		IL_3f01:
		object obj142 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2199 @ X0_v181+E4]");
		if ((nint)0 != 0)
		{
			if (!KUtil.NoPlayServices)
			{
				goto IL_19b2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool noPlayServices2 = KUtil.NoPlayServices;
			bool flag62 = !noPlayServices2;
			object obj143 = !flag62;
			if (obj143 == null)
			{
				goto IL_19b2;
			}
		}
		goto IL_19ff;
		IL_3282:
		throw new NullReferenceException();
		IL_238e:
		object obj144 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj145 = obj144;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2528 @ X0_v378+E4]");
		bool flag63 = (nint)0 == 0;
		object obj146 = !flag63;
		if (obj146 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object name4;
		string property;
		FirebaseAnalytics.SetUserProperty((string)name4, property);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj10 = 0;
		goto IL_2413;
		IL_1924:
		_ = 1;
		obj138 = obj133;
		text11 = text9;
		text12 = text10;
		goto IL_3f01;
		IL_19ff:
		object obj147 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2236 @ X0_v183+E4]");
		bool flag64 = (nint)0 == 0;
		object obj148 = !flag64;
		if (obj148 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UpdateDimensions();
		object name5 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3648;
		string text15;
		string text16;
		string text17;
		if (obj61 != null)
		{
			string name6 = ((StoreOwnedItem)obj61).name;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
			object obj149 = (nint)0 & (nint)1;
			bool flag65 = obj149 == null;
			object obj150 = !flag65;
			text12 = null;
			text15 = name6;
			text16 = null;
			text17 = name6;
			if (obj150 == null)
			{
				goto IL_1add;
			}
		}
		else
		{
			object obj151 = "DNQUALIFIER" + 2040;
			text15 = (string)obj151;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
			object obj152 = (nint)0 & (nint)1;
			if (obj152 == null)
			{
				goto IL_1add;
			}
			text16 = text12;
			text17 = (string)obj151;
		}
		goto IL_3f2e;
		IL_19b2:
		bool flag66 = string.IsNullOrEmpty(text11);
		bool flag67 = !flag66;
		object obj153 = !flag67;
		text12 = null;
		if (obj153 == null)
		{
			Crashlytics.SetUserId(text11);
			text12 = null;
		}
		goto IL_19ff;
		IL_2e57:
		if (clanMembership.IsOwner)
		{
			object obj154 = "October" + 1632;
			text13 = (string)obj154;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
			object obj155 = (nint)0 & (nint)1;
			bool flag68 = obj155 == null;
			obj9 = obj10;
			text2 = text3;
			text4 = text;
			if (flag68)
			{
				goto IL_306e;
			}
			text14 = (string)obj154;
		}
		else
		{
			bool isAdmin = clanMembership.IsAdmin;
			object obj156 = "Material with texture name \"" + 448;
			object obj157 = "Added Tournament Prizes And Features" + 208;
			bool flag69 = !isAdmin;
			object obj158 = !flag69;
			object obj159 = ~obj158;
			if (obj159 == null)
			{
				obj156 = obj157;
			}
			text13 = (string)obj156;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
			object obj160 = (nint)0 & (nint)1;
			bool flag70 = obj160 == null;
			obj9 = obj10;
			text2 = null;
			text4 = text;
			if (flag70)
			{
				goto IL_306e;
			}
			text3 = null;
			text14 = (string)obj156;
		}
		goto IL_3fb5;
		IL_289b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel7 = default(SessionModel);
		bool flag71 = (object)sessionModel7 == null;
		object obj161 = !flag71;
		if (obj161 != null)
		{
			goto IL_29d5;
		}
		goto IL_3282;
		IL_2413:
		SessionModel sessionModel8 = default(SessionModel);
		User localUser6 = sessionModel8.LocalUser;
		SocialPlatform socialPlatform = SFSKammelnaUserExtensions.GetSocialPlatform(localUser6);
		object obj162 = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object name7 = "SetRoomVariables request error" + 1480;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
		object obj163 = (nint)0 & (nint)1;
		if (obj163 != null)
		{
			object obj164 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2571 @ X0_v359+E4]");
			if ((nint)0 != 0)
			{
				goto IL_24d1;
			}
		}
		else
		{
			_ = 1;
			object obj164 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2571 @ X0_v359+E4]");
			bool flag72 = (nint)0 == 0;
			object obj165 = !flag72;
			if (obj165 != null)
			{
				goto IL_24d1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices3 = KUtil.NoPlayServices;
		bool flag73 = !noPlayServices3;
		object obj166 = !flag73;
		if (obj166 != null)
		{
			goto IL_24f7;
		}
		goto IL_25ac;
		IL_22d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag74 = (object)sessionModel8 == null;
		object obj167 = !flag74;
		obj10 = 0;
		if (obj167 != null)
		{
			goto IL_2413;
		}
		goto IL_3282;
		IL_0e14:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0e2d;
		IL_0e2d:
		SessionModel sessionModel9 = default(SessionModel);
		User localUser7 = sessionModel9.LocalUser;
		string userFacebookID = SFSKammelnaUserExtensions.GetUserFacebookID(localUser7);
		object obj168 = obj124;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1771 @ X8_v78+E4]");
		object obj170;
		object obj169;
		if ((nint)0 != 0)
		{
			bool flag75 = StringsExtensions.IsNullOrEmpty(userFacebookID);
			bool flag76 = !flag75;
			obj169 = 0;
			obj170 = 0;
			if (!flag76)
			{
				goto IL_0eb5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag77 = StringsExtensions.IsNullOrEmpty(userFacebookID);
			bool flag78 = !flag77;
			object obj171 = !flag78;
			obj169 = 0;
			obj170 = 0;
			if (obj171 != null)
			{
				goto IL_0eb5;
			}
		}
		ITrackEvent trackEvent2 = TrackerLibrary.StatisticsSocialLinked(SocialPlatform.Facebook);
		object obj172 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1811 @ X8_v309+E4]");
		bool flag79 = (nint)0 == 0;
		object obj173 = !flag79;
		if (obj173 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DesignEvent(trackEvent2);
		object obj174 = obj121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1808 @ X0_v592+E4]");
		bool flag80 = (nint)0 == 0;
		object obj175 = !flag80;
		obj169 = obj170;
		if (obj175 != null)
		{
			goto IL_0ee2;
		}
		goto IL_0fc4;
		IL_0d32:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag81 = (object)sessionModel9 == null;
		object obj176 = !flag81;
		if (obj176 != null)
		{
			goto IL_0e2d;
		}
		goto IL_3282;
		IL_0d05:
		obj131 = obj121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1747 @ X0_v614+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0d32;
		}
		goto IL_0e14;
		IL_29d5:
		User localUser8 = sessionModel7.LocalUser;
		clanMembership = SFSKammelnaUserExtensions.GetClanMembership(localUser8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel10 = default(SessionModel);
		User localUser9 = sessionModel10.LocalUser;
		int clanId = SFSKammelnaUserExtensions.GetClanId(localUser9);
		bool flag82 = default(bool);
		string text18 = flag82.ToString();
		object name8 = "HH:mm:ss.ffZ" + 3792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
		object obj177 = (nint)0 & (nint)1;
		if (obj177 != null)
		{
			object obj178 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2759 @ X0_v281+E4]");
			if ((nint)0 != 0)
			{
				goto IL_2a9e;
			}
		}
		else
		{
			_ = 1;
			object obj178 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2759 @ X0_v281+E4]");
			bool flag83 = (nint)0 == 0;
			object obj179 = !flag83;
			if (obj179 != null)
			{
				goto IL_2a9e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices4 = KUtil.NoPlayServices;
		bool flag84 = !noPlayServices4;
		object obj180 = !flag84;
		if (obj180 != null)
		{
			goto IL_2ac4;
		}
		goto IL_2c74;
		IL_31f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_30f4;
		IL_3f2e:
		object obj181 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2277 @ X0_v187+E4]");
		if ((nint)0 != 0)
		{
			if (KUtil.NoPlayServices)
			{
				goto IL_1b1e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool noPlayServices5 = KUtil.NoPlayServices;
			bool flag85 = !noPlayServices5;
			object obj182 = !flag85;
			if (obj182 != null)
			{
				goto IL_1b1e;
			}
		}
		object obj183 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj184 = obj183;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2301 @ X0_v450+E4]");
		bool flag86 = (nint)0 == 0;
		object obj185 = !flag86;
		if (obj185 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FirebaseAnalytics.SetUserProperty((string)name5, text17);
		object obj186 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3664;
		string text19 = (string)obj186;
		bool flag87 = obj50 == null;
		object obj187 = !flag87;
		obj138 = 0;
		StoreOwnedItem storeOwnedItem = (StoreOwnedItem)obj50;
		object obj188 = 0;
		text16 = text17;
		string text20 = (string)obj186;
		if (obj187 != null)
		{
			goto IL_1b6a;
		}
		goto IL_1e0c;
		IL_3fb5:
		object obj189 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2971 @ X0_v229+E4]");
		if ((nint)0 != 0)
		{
			if (KUtil.NoPlayServices)
			{
				goto IL_30bf;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool noPlayServices6 = KUtil.NoPlayServices;
			bool flag88 = !noPlayServices6;
			object obj190 = !flag88;
			if (obj190 != null)
			{
				goto IL_30bf;
			}
		}
		object obj191 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj192 = obj191;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3003 @ X0_v233+E4]");
		bool flag89 = (nint)0 == 0;
		object obj193 = !flag89;
		if (obj193 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FirebaseAnalytics.SetUserProperty(text, text14);
		object obj194 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v241+E4]");
		bool flag90 = (nint)0 == 0;
		object obj195 = !flag90;
		obj10 = 0;
		text3 = text14;
		object obj196 = obj194;
		if (obj195 != null)
		{
			goto IL_30f4;
		}
		goto IL_31f8;
		IL_0eb5:
		obj174 = obj121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1808 @ X0_v592+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0ee2;
		}
		goto IL_0fc4;
		IL_1add:
		_ = 1;
		text16 = text12;
		text17 = text15;
		goto IL_3f2e;
		IL_0fdd:
		SessionModel sessionModel11 = default(SessionModel);
		User localUser10 = sessionModel11.LocalUser;
		string userGoogleID = SFSKammelnaUserExtensions.GetUserGoogleID(localUser10);
		object obj197 = obj124;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1832 @ X8_v80+E4]");
		object obj199;
		object obj198;
		if ((nint)0 != 0)
		{
			bool flag91 = StringsExtensions.IsNullOrEmpty(userGoogleID);
			bool flag92 = !flag91;
			obj198 = 0;
			obj199 = 0;
			if (!flag92)
			{
				goto IL_1065;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag93 = StringsExtensions.IsNullOrEmpty(userGoogleID);
			bool flag94 = !flag93;
			object obj200 = !flag94;
			obj198 = 0;
			obj199 = 0;
			if (obj200 != null)
			{
				goto IL_1065;
			}
		}
		ITrackEvent trackEvent3 = TrackerLibrary.StatisticsSocialLinked(SocialPlatform.Google);
		object obj201 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1872 @ X8_v304+E4]");
		bool flag95 = (nint)0 == 0;
		object obj202 = !flag95;
		if (obj202 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DesignEvent(trackEvent3);
		object obj203 = obj121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1869 @ X0_v570+E4]");
		bool flag96 = (nint)0 == 0;
		object obj204 = !flag96;
		obj198 = obj199;
		if (obj204 != null)
		{
			goto IL_1092;
		}
		goto IL_1174;
		IL_0ee2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag97 = (object)sessionModel11 == null;
		object obj205 = !flag97;
		if (obj205 != null)
		{
			goto IL_0fdd;
		}
		goto IL_3282;
		IL_0fc4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0fdd;
		IL_2a9e:
		if (KUtil.NoPlayServices)
		{
			goto IL_2ac4;
		}
		goto IL_2c74;
		IL_25ac:
		object obj206 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj207 = obj206;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2593 @ X0_v353+E4]");
		bool flag98 = (nint)0 == 0;
		object obj208 = !flag98;
		if (obj208 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FirebaseAnalytics.SetUserProperty((string)name7, friendlyName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj10 = 0;
		goto IL_2631;
		IL_24d1:
		if (KUtil.NoPlayServices)
		{
			goto IL_24f7;
		}
		goto IL_25ac;
		IL_1065:
		obj203 = obj121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1869 @ X0_v570+E4]");
		if ((nint)0 != 0)
		{
			goto IL_1092;
		}
		goto IL_1174;
		IL_24f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel12 = default(SessionModel);
		bool flag99 = (object)sessionModel12 == null;
		object obj209 = !flag99;
		if (obj209 != null)
		{
			goto IL_2631;
		}
		goto IL_3282;
		IL_30bf:
		obj194 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v241+E4]");
		bool flag100 = (nint)0 == 0;
		obj196 = obj194;
		if (!flag100)
		{
			goto IL_30f4;
		}
		goto IL_31f8;
		IL_118d:
		SessionModel sessionModel13 = default(SessionModel);
		User localUser11 = sessionModel13.LocalUser;
		string userGoogleID2 = SFSKammelnaUserExtensions.GetUserGoogleID(localUser11);
		object obj210 = obj124;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1893 @ X8_v82+E4]");
		object obj213;
		if ((nint)0 != 0)
		{
			bool flag101 = StringsExtensions.IsNullOrEmpty(userGoogleID2);
			bool flag102 = !flag101;
			object obj211 = !flag102;
			object obj212 = 0;
			if (obj211 != null)
			{
				goto IL_1268;
			}
			obj213 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag103 = StringsExtensions.IsNullOrEmpty(userGoogleID2);
			bool flag104 = !flag103;
			object obj212 = 0;
			obj213 = 0;
			if (!flag104)
			{
				goto IL_1268;
			}
		}
		goto IL_1439;
		IL_1092:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag105 = (object)sessionModel13 == null;
		object obj214 = !flag105;
		if (obj214 != null)
		{
			goto IL_118d;
		}
		goto IL_3282;
		IL_1174:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_118d;
		IL_1268:
		object obj215 = obj121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1908 @ X0_v535+E4]");
		bool flag106 = (nint)0 == 0;
		object obj216 = !flag106;
		if (obj216 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel14 = default(SessionModel);
		User localUser12 = sessionModel14.LocalUser;
		string userTwitterID2 = SFSKammelnaUserExtensions.GetUserTwitterID(localUser12);
		object obj217 = obj124;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1926 @ X8_v299+E4]");
		bool flag107 = (nint)0 == 0;
		object obj218 = !flag107;
		if (obj218 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag108 = StringsExtensions.IsNullOrEmpty(userTwitterID2);
		bool flag109 = !flag108;
		obj213 = 0;
		if (!flag109)
		{
			object obj219 = obj121;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1985 @ X0_v543+E4]");
			bool flag110 = (nint)0 == 0;
			object obj220 = !flag110;
			if (obj220 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel15 = default(SessionModel);
			User localUser13 = sessionModel15.LocalUser;
			string userFacebookID2 = SFSKammelnaUserExtensions.GetUserFacebookID(localUser13);
			object obj221 = obj124;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1927 @ X8_v301+E4]");
			bool flag111 = (nint)0 == 0;
			object obj222 = !flag111;
			if (obj222 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag112 = StringsExtensions.IsNullOrEmpty(userFacebookID2);
			bool flag113 = !flag112;
			obj213 = 0;
			if (!flag113)
			{
				ITrackEvent trackEvent4 = TrackerLibrary.StatisticsSocialLinked(SocialPlatform.None);
				object obj223 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1925 @ X8_v302+E4]");
				bool flag114 = (nint)0 == 0;
				object obj224 = !flag114;
				if (obj224 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DesignEvent(trackEvent4);
				obj213 = 0;
			}
		}
		goto IL_1439;
		IL_1b1e:
		object obj225 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3664;
		text19 = (string)obj225;
		bool flag115 = obj50 == null;
		storeOwnedItem = (StoreOwnedItem)obj50;
		obj188 = obj138;
		text20 = (string)obj225;
		if (!flag115)
		{
			goto IL_1b6a;
		}
		goto IL_1e0c;
		IL_1e0c:
		object obj226 = "DNQUALIFIER" + 2040;
		string text21 = (string)obj226;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
		object obj227 = (nint)0 & (nint)1;
		bool flag116 = obj227 == null;
		obj138 = obj188;
		text19 = text20;
		if (flag116)
		{
			goto IL_1bdf;
		}
		string text22 = text16;
		string text23 = (string)obj226;
		goto IL_3f5b;
		IL_2c74:
		object obj228 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj229 = obj228;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2787 @ X0_v277+E4]");
		bool flag117 = (nint)0 == 0;
		object obj230 = !flag117;
		if (obj230 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FirebaseAnalytics.SetUserProperty((string)name8, text18);
		object obj231 = "Cannot populate JSON object onto type '{0}'." + 3032;
		text5 = (string)obj231;
		bool flag118 = !flag82;
		object obj232 = !flag118;
		obj10 = 0;
		string text24 = text18;
		object obj233 = 0;
		string text25 = text18;
		string text26 = (string)obj231;
		if (obj232 != null)
		{
			goto IL_2b12;
		}
		goto IL_2d45;
		IL_1b6a:
		string name9 = storeOwnedItem.name;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
		object obj234 = (nint)0 & (nint)1;
		bool flag119 = obj234 == null;
		object obj235 = !flag119;
		text16 = null;
		text21 = name9;
		obj188 = obj138;
		text22 = null;
		text20 = text19;
		text23 = name9;
		if (obj235 == null)
		{
			goto IL_1bdf;
		}
		goto IL_3f5b;
		IL_1bdf:
		_ = 1;
		obj188 = obj138;
		text22 = text16;
		text20 = text19;
		text23 = text21;
		goto IL_3f5b;
		IL_277f:
		object obj236 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj237 = obj236;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2655 @ X0_v333+E4]");
		bool flag120 = (nint)0 == 0;
		object obj238 = !flag120;
		if (obj238 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object name10;
		string text27;
		FirebaseAnalytics.SetUserProperty((string)name10, text27);
		obj10 = 0;
		string text28 = text27;
		goto IL_27fd;
		IL_30f4:
		UpdateTrackUserProfileDate();
		return;
		IL_3f5b:
		object obj239 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2360 @ X0_v189+E4]");
		if ((nint)0 != 0)
		{
			if (KUtil.NoPlayServices)
			{
				goto IL_1c30;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool noPlayServices7 = KUtil.NoPlayServices;
			bool flag121 = !noPlayServices7;
			object obj240 = !flag121;
			if (obj240 != null)
			{
				goto IL_1c30;
			}
		}
		object obj241 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj242 = obj241;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2382 @ X0_v433+E4]");
		bool flag122 = (nint)0 == 0;
		object obj243 = !flag122;
		if (obj243 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FirebaseAnalytics.SetUserProperty(text20, text23);
		object obj244 = obj121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2396 @ X0_v428+E4]");
		bool flag123 = (nint)0 == 0;
		object obj245 = !flag123;
		obj188 = 0;
		object obj246 = 0;
		text22 = text23;
		if (obj245 != null)
		{
			goto IL_1c65;
		}
		goto IL_1f75;
		IL_26cc:
		if (!KUtil.NoPlayServices)
		{
			goto IL_277f;
		}
		text28 = null;
		goto IL_27fd;
		IL_1c30:
		obj244 = obj121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2396 @ X0_v428+E4]");
		bool flag124 = (nint)0 == 0;
		obj246 = obj188;
		if (!flag124)
		{
			goto IL_1c65;
		}
		goto IL_1f75;
		IL_306e:
		_ = 1;
		obj10 = obj9;
		text3 = text2;
		text = text4;
		text14 = text13;
		goto IL_3fb5;
		IL_1c65:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel16 = default(SessionModel);
		bool flag125 = (object)sessionModel16 == null;
		object obj247 = !flag125;
		if (obj247 != null)
		{
			goto IL_1f9b;
		}
		goto IL_3282;
		IL_1f9b:
		User localUser14 = sessionModel16.LocalUser;
		PlayerRank rank2 = SFSKammelnaUserExtensions.GetRank(localUser14);
		object obj248 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration2 = default(Enum);
		string friendlyName2 = EnumExtensions.GetFriendlyName(enumeration2);
		object name11 = "Picking audio files is not supported on iOS" + 3904;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
		object obj249 = (nint)0 & (nint)1;
		if (obj249 != null)
		{
			object obj250 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2436 @ X0_v410+E4]");
			if ((nint)0 != 0)
			{
				goto IL_205a;
			}
		}
		else
		{
			_ = 1;
			object obj250 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2436 @ X0_v410+E4]");
			bool flag126 = (nint)0 == 0;
			object obj251 = !flag126;
			if (obj251 != null)
			{
				goto IL_205a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices8 = KUtil.NoPlayServices;
		bool flag127 = !noPlayServices8;
		object obj252 = !flag127;
		if (obj252 != null)
		{
			goto IL_2080;
		}
		goto IL_2135;
		IL_1f75:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj188 = obj246;
		goto IL_1f9b;
		IL_2d45:
		object obj253 = "Network Authentication Required" + 1600;
		string text29 = (string)obj253;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
		object obj254 = (nint)0 & (nint)1;
		bool flag128 = obj254 == null;
		object obj255 = !flag128;
		obj10 = obj233;
		text6 = (string)obj253;
		text3 = text25;
		text5 = text26;
		if (obj255 == null)
		{
			goto IL_2dba;
		}
		goto IL_3f88;
		IL_1439:
		object obj256 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj257 = obj256;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1933 @ X0_v165+E4]");
		bool flag129 = (nint)0 == 0;
		object obj258 = !flag129;
		if (obj258 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		string text30 = ((Enum)(&value)).ToString();
		object obj259 = "_InputUv1BufferOffset" + 4008;
		string text31 = (string)obj259 + text30;
		object obj260 = typeof(DataRelation) + 856;
		object obj261 = obj260;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1962 @ X8_v92+E4]");
		bool flag130 = (nint)0 == 0;
		object obj262 = !flag130;
		object message = text31;
		if (obj262 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text31;
		}
		Debug.Log(message);
		Games currentGame2 = Preferences.CurrentGame;
		SocialPlatform socialPlatform2 = default(SocialPlatform);
		string text32 = ((Enum)(&socialPlatform2)).ToString();
		object name12 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3656;
		obj23 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
		object obj263 = (nint)0 & (nint)1;
		if (obj263 != null)
		{
			object obj264 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2011 @ X0_v510+E4]");
			if ((nint)0 != 0)
			{
				goto IL_15bf;
			}
		}
		else
		{
			_ = 1;
			object obj264 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2011 @ X0_v510+E4]");
			bool flag131 = (nint)0 == 0;
			object obj265 = !flag131;
			if (obj265 != null)
			{
				goto IL_15bf;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices9 = KUtil.NoPlayServices;
		bool flag132 = !noPlayServices9;
		object obj266 = !flag132;
		if (obj266 != null)
		{
			goto IL_15e5;
		}
		goto IL_16de;
		IL_2631:
		User localUser15 = sessionModel12.LocalUser;
		int aces2 = SFSKammelnaUserExtensions.GetAces(localUser15);
		text27 = num6.ToString();
		name10 = "Complete" + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
		object obj267 = (nint)0 & (nint)1;
		if (obj267 != null)
		{
			object obj268 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2636 @ X0_v337+E4]");
			if ((nint)0 != 0)
			{
				goto IL_26cc;
			}
		}
		else
		{
			_ = 1;
			object obj268 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2636 @ X0_v337+E4]");
			bool flag133 = (nint)0 == 0;
			object obj269 = !flag133;
			if (obj269 != null)
			{
				goto IL_26cc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices10 = KUtil.NoPlayServices;
		bool flag134 = !noPlayServices10;
		object obj270 = !flag134;
		text28 = null;
		if (obj270 == null)
		{
			goto IL_277f;
		}
		goto IL_27fd;
		IL_2b12:
		object obj271 = obj121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2803 @ X0_v293+E4]");
		bool flag135 = (nint)0 == 0;
		object obj272 = !flag135;
		if (obj272 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel17 = default(SessionModel);
		User localUser16 = sessionModel17.LocalUser;
		int clanTier = SFSKammelnaUserExtensions.GetClanTier(localUser16);
		string text33 = num6.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
		object obj273 = (nint)0 & (nint)1;
		bool flag136 = obj273 == null;
		obj233 = obj10;
		text29 = text33;
		text25 = null;
		text26 = text5;
		if (flag136)
		{
			goto IL_2dba;
		}
		text6 = text33;
		text3 = null;
		goto IL_3f88;
		IL_205a:
		if (KUtil.NoPlayServices)
		{
			goto IL_2080;
		}
		goto IL_2135;
		IL_2ac4:
		object obj274 = "Cannot populate JSON object onto type '{0}'." + 3032;
		text5 = (string)obj274;
		bool flag137 = !flag82;
		text24 = null;
		obj233 = obj10;
		text25 = null;
		text26 = (string)obj274;
		if (!flag137)
		{
			goto IL_2b12;
		}
		goto IL_2d45;
		IL_2135:
		object obj275 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj276 = obj275;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2458 @ X0_v404+E4]");
		bool flag138 = (nint)0 == 0;
		object obj277 = !flag138;
		if (obj277 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FirebaseAnalytics.SetUserProperty((string)name11, friendlyName2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_21ac;
		IL_2dba:
		_ = 1;
		obj10 = obj233;
		text6 = text29;
		text3 = text25;
		text5 = text26;
		goto IL_3f88;
		IL_27fd:
		carrierProviderName = CarrierProvider.GetCarrierProviderName();
		name = "Cannot populate JSON object onto type '{0}'." + 1728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
		object obj278 = (nint)0 & (nint)1;
		if (obj278 != null)
		{
			object obj279 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2690 @ X0_v314+E4]");
			if ((nint)0 != 0)
			{
				goto IL_2875;
			}
		}
		else
		{
			_ = 1;
			object obj279 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2690 @ X0_v314+E4]");
			bool flag139 = (nint)0 == 0;
			object obj280 = !flag139;
			if (obj280 != null)
			{
				goto IL_2875;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices11 = KUtil.NoPlayServices;
		bool flag140 = !noPlayServices11;
		object obj281 = !flag140;
		if (obj281 != null)
		{
			goto IL_289b;
		}
		goto IL_2950;
		IL_21ac:
		SessionModel sessionModel18 = default(SessionModel);
		User localUser17 = sessionModel18.LocalUser;
		bool flag141 = SFSKammelnaUserExtensions.IsSubscribed(localUser17);
		object obj282 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2478 @ X8_v116+28]");
		object obj283 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2479 @ X0_v199+E4]");
		bool flag142 = (nint)0 == 0;
		object obj284 = !flag142;
		if (obj284 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag143 = default(bool);
		property = flag143.ToString();
		name4 = "SubscribeGroup request Error" + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
		object obj285 = (nint)0 & (nint)1;
		if (obj285 != null)
		{
			object obj286 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2506 @ X0_v384+E4]");
			if ((nint)0 != 0)
			{
				goto IL_22aa;
			}
		}
		else
		{
			_ = 1;
			object obj286 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2506 @ X0_v384+E4]");
			bool flag144 = (nint)0 == 0;
			object obj287 = !flag144;
			if (obj287 != null)
			{
				goto IL_22aa;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices12 = KUtil.NoPlayServices;
		bool flag145 = !noPlayServices12;
		object obj288 = !flag145;
		if (obj288 != null)
		{
			goto IL_22d0;
		}
		goto IL_238e;
		IL_16de:
		object obj289 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj290 = obj289;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2040 @ X0_v505+E4]");
		bool flag146 = (nint)0 == 0;
		object obj291 = !flag146;
		if (obj291 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FirebaseAnalytics.SetUserProperty((string)name12, text32);
		object obj292 = obj121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2056 @ X0_v500+E4]");
		bool flag147 = (nint)0 == 0;
		object obj293 = !flag147;
		obj133 = 0;
		object obj294 = 0;
		string text34 = text32;
		if (obj293 != null)
		{
			goto IL_1629;
		}
		goto IL_1798;
		IL_15bf:
		if (KUtil.NoPlayServices)
		{
			goto IL_15e5;
		}
		goto IL_16de;
		IL_1798:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj133 = obj294;
		goto IL_17be;
		IL_15e5:
		obj292 = obj121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2056 @ X0_v500+E4]");
		bool flag148 = (nint)0 == 0;
		obj133 = 0;
		obj294 = 0;
		text34 = null;
		if (!flag148)
		{
			goto IL_1629;
		}
		goto IL_1798;
		IL_2080:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag149 = (object)sessionModel18 == null;
		object obj295 = !flag149;
		if (obj295 != null)
		{
			goto IL_21ac;
		}
		goto IL_3282;
		IL_17be:
		User localUser18 = sessionModel.LocalUser;
		if (localUser18 != null)
		{
			object obj296 = typeof(UsageHint) + 8;
			nint num7 = (nint)localUser18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2084 @ X8_v278 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj297 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2084 @ X8_v278 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_1890;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2084 @ X8_v278 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj298 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2178 @ X10_v9-8]");
				if (0 == (nint)obj296)
				{
					break;
				}
				obj298 += 16;
				obj297--;
				if ((nint)obj297 != 1)
				{
					continue;
				}
				goto IL_1890;
			}
			object obj299 = num7 + obj298;
			obj134 = obj299 + 312;
			goto IL_3e8a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D71]");
		object obj300 = (nint)0 & (nint)1;
		bool flag150 = obj300 == null;
		text9 = null;
		text10 = null;
		if (flag150)
		{
			goto IL_1924;
		}
		obj138 = obj133;
		text11 = null;
		text12 = null;
		goto IL_3f01;
	}

	public static void UpdateDimensions(DimensionsModel dimensionsModel = null)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0171: Expected O, but got I4
		//IL_017a: Expected O, but got I4
		//IL_0183: Expected O, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I
		//IL_0078: Expected O, but got I4
		//IL_0081: Expected O, but got I4
		//IL_0225: Expected O, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I
		//IL_01df: Expected O, but got I4
		//IL_0132: Expected O, but got I4
		//IL_0323: Expected O, but got I4
		//IL_06e4: Expected O, but got I
		//IL_0362: Expected O, but got I
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_068f: Expected O, but got I
		//IL_0556: Expected O, but got I
		//IL_03eb: Expected O, but got I
		//IL_0591: Expected O, but got I
		//IL_0426: Expected O, but got I
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected O, but got Unknown
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected O, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected O, but got Unknown
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected O, but got Unknown
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected O, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D7C]");
		object obj3 = (nint)0 & (nint)1;
		List<object>.Enumerator enumerator;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v59+E4]");
			bool flag = (nint)0 == 0;
			enumerator = (List<object>.Enumerator)0;
			enumerator = (List<object>.Enumerator)0;
			if (!flag)
			{
				goto IL_008f;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v59+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			enumerator = (List<object>.Enumerator)0;
			enumerator = (List<object>.Enumerator)0;
			if (obj5 != null)
			{
				goto IL_008f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
		object obj7 = (nint)0 & (nint)1;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		object obj9 = obj6;
		if (obj8 != null)
		{
			goto IL_00de;
		}
		goto IL_01f5;
		IL_0274:
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			if (!Config.IsProduction)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!Config.IsProduction)
			{
				return;
			}
		}
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v5+B8]");
		object obj13 = 0;
		if (obj13 != null)
		{
			List<object>.Enumerator enumerator2 = ((List<object>)obj13).GetEnumerator();
			object obj14 = (nint)0 + (nint)1240;
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			object obj16 = default(object);
			if (dimensionsModel != null)
			{
				object obj15 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 760;
				while (enumerator3.MoveNext())
				{
					if (obj16 == null)
					{
						continue;
					}
					object obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v23+12E]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v23+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0398;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v23+B0]");
					object obj19 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X10_v7-8]");
						object obj20 = 0 - obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X10_v7-8]");
						if (0 == (nint)obj15)
						{
							break;
						}
						obj19 += 16;
						obj18--;
						obj20 = obj18 - 1;
						bool flag5 = obj20 == null;
						if ((nint)obj18 != 1)
						{
							continue;
						}
						goto IL_0398;
					}
					object obj21 = obj19 + 4;
					object obj22 = obj17 + obj21;
					object obj23 = obj22 + 312;
					goto IL_03a7;
					IL_03a7:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v490 @ X0_v38] (should have been resolved before IL gen)");
					continue;
					IL_0398:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					goto IL_03a7;
				}
			}
			else
			{
				object obj24 = typeof(DataRelation) + 2256;
				object obj25 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 760;
				DimensionsModel dimensionsModel2 = default(DimensionsModel);
				while (enumerator3.MoveNext())
				{
					if (obj16 == null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					dimensionsModel2..ctor();
					object obj26 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v18+12E]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v18+12E]");
					if ((nint)0 == 0)
					{
						goto IL_04eb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v18+B0]");
					object obj19 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X10_v7-8]");
						object obj20 = 0 - obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X10_v7-8]");
						if (0 == (nint)obj25)
						{
							break;
						}
						obj19 += 16;
						obj27--;
						obj20 = obj27 - 1;
						bool flag5 = obj20 == null;
						if ((nint)obj27 != 1)
						{
							continue;
						}
						goto IL_04eb;
					}
					object obj28 = obj19 + 4;
					object obj29 = obj26 + obj28;
					object obj30 = obj29 + 312;
					goto IL_04fa;
					IL_04fa:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v552 @ X0_v29] (should have been resolved before IL gen)");
					continue;
					IL_04eb:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					goto IL_04fa;
				}
			}
			enumerator3.Dispose();
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		IntPtr intPtr = default(IntPtr);
		bool flag6 = intPtr != (IntPtr)1;
		NullReferenceException ex2 = ex;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj31 = (nint)0 + (nint)1232;
			enumerator.Dispose();
			object obj32 = default(object);
			if (obj32 == null)
			{
				return;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj32;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B15C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0113:
		bool isInitialized = Config.IsInitialized;
		bool flag7 = !isInitialized;
		object obj33 = !flag7;
		if (obj33 == null)
		{
			return;
		}
		goto IL_0274;
		IL_023b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isInitialized2 = Config.IsInitialized;
		bool flag8 = !isInitialized2;
		obj6 = obj9;
		if (flag8)
		{
			return;
		}
		goto IL_0274;
		IL_008f:
		obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
		object obj34 = (nint)0 & (nint)1;
		bool flag9 = obj34 == null;
		obj9 = obj6;
		if (!flag9)
		{
			goto IL_00de;
		}
		goto IL_01f5;
		IL_01f5:
		_ = 1;
		object obj35 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v50+E4]");
		bool flag10 = (nint)0 == 0;
		object obj36 = !flag10;
		obj6 = obj9;
		if (obj36 != null)
		{
			goto IL_0113;
		}
		goto IL_023b;
		IL_00de:
		obj35 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v50+E4]");
		bool flag11 = (nint)0 == 0;
		obj9 = obj6;
		if (!flag11)
		{
			goto IL_0113;
		}
		goto IL_023b;
	}

	public static void Screen(string sceneName)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0149: Expected O, but got I
		//IL_016b: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I
		//IL_020d: Expected O, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01ad: Expected O, but got I
		//IL_01c7: Expected O, but got I4
		//IL_0120: Expected O, but got I4
		//IL_0364: Expected O, but got I4
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_0309: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D7D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v26+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7000]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
		object obj7 = (nint)0 & (nint)1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		object obj9 = obj6;
		if (obj8 != null)
		{
			goto IL_00cc;
		}
		goto IL_01dd;
		IL_025c:
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (!Config.IsProduction)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isProduction = Config.IsProduction;
			bool flag3 = !isProduction;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				return;
			}
		}
		object obj12 = "___# Content push apply failed [{0}]: {1}" + 496;
		string text = (string)obj12 + sceneName;
		object obj13 = typeof(DataRelation) + 856;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		object message = text;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.Log(message);
		FirebaseTrack.Screen(sceneName);
		return;
		IL_0101:
		bool isInitialized = Config.IsInitialized;
		bool flag5 = !isInitialized;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			return;
		}
		goto IL_025c;
		IL_0223:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isInitialized2 = Config.IsInitialized;
		bool flag6 = !isInitialized2;
		obj6 = obj9;
		if (!flag6)
		{
			goto IL_025c;
		}
		return;
		IL_007d:
		obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
		object obj17 = (nint)0 & (nint)1;
		bool flag7 = obj17 == null;
		obj9 = obj6;
		if (!flag7)
		{
			goto IL_00cc;
		}
		goto IL_01dd;
		IL_01dd:
		_ = 1;
		object obj18 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v17+E4]");
		bool flag8 = (nint)0 == 0;
		object obj19 = !flag8;
		obj6 = obj9;
		if (obj19 != null)
		{
			goto IL_0101;
		}
		goto IL_0223;
		IL_00cc:
		obj18 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v17+E4]");
		bool flag9 = (nint)0 == 0;
		obj9 = obj6;
		if (!flag9)
		{
			goto IL_0101;
		}
		goto IL_0223;
	}

	public unsafe static void SetActiveGame()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015f: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I
		//IL_0201: Expected O, but got I4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_01a1: Expected O, but got I
		//IL_01bb: Expected O, but got I4
		//IL_0120: Expected O, but got I4
		//IL_02ff: Expected O, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0360: Expected O, but got I4
		//IL_0391: Expected O, but got Ref
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03d3: Expected O, but got I
		//IL_05f8: Expected O, but got I4
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected O, but got Unknown
		//IL_0684: Expected O, but got I4
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected O, but got Unknown
		//IL_06ec: Expected O, but got I4
		//IL_06f5: Expected O, but got I4
		//IL_0706: Expected O, but got I4
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0638: Expected O, but got I4
		//IL_04a2: Expected O, but got I
		//IL_0732: Expected O, but got I
		//IL_075b: Expected O, but got I4
		//IL_07a2: Expected O, but got I
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_051c: Expected I, but got O
		//IL_052c: Expected O, but got I
		//IL_05bb: Expected O, but got I4
		//IL_0927: Expected O, but got I
		//IL_0941: Expected O, but got I4
		//IL_0567: Expected O, but got I
		//IL_0889: Expected O, but got I4
		//IL_0844: Expected O, but got I4
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected O, but got Unknown
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected O, but got Unknown
		//IL_08be: Expected O, but got I4
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected O, but got Unknown
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D7E]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v85+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v85+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
		object obj7 = (nint)0 & (nint)1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		object obj9 = obj6;
		if (obj8 != null)
		{
			goto IL_00cc;
		}
		goto IL_01d1;
		IL_041d:
		if (KUtil.NoPlayServices)
		{
			goto IL_0443;
		}
		goto IL_0646;
		IL_04d1:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		bool flag3 = localUser == null;
		string text = null;
		object obj14;
		if (!flag3)
		{
			object obj10 = typeof(UsageHint) + 8;
			nint num = (nint)localUser;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v37 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v37 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_05a8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v37 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj12 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X10_v7-8]");
				if (0 == (nint)obj10)
				{
					break;
				}
				obj12 += 16;
				obj11--;
				if ((nint)obj11 != 1)
				{
					continue;
				}
				goto IL_05a8;
			}
			object obj13 = num + obj12;
			obj14 = obj13 + 312;
			goto IL_08fa;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D71]");
		object obj15 = (nint)0 & (nint)1;
		bool flag4 = obj15 == null;
		string text2 = null;
		if (flag4)
		{
			goto IL_07fe;
		}
		object obj17 = default(object);
		object obj16 = obj17;
		string text3 = text;
		string text4 = null;
		goto IL_0971;
		IL_08fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v512 @ X8_v38] (should have been resolved before IL gen)");
		int num2 = default(int);
		string text5 = num2.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D71]");
		object obj18 = (nint)0 & (nint)1;
		bool flag5 = obj18 == null;
		object obj19 = !flag5;
		text = null;
		text2 = text5;
		obj16 = obj17;
		text3 = null;
		text4 = text5;
		if (obj19 == null)
		{
			goto IL_07fe;
		}
		goto IL_0971;
		IL_007d:
		obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D74]");
		object obj20 = (nint)0 & (nint)1;
		bool flag6 = obj20 == null;
		obj9 = obj6;
		if (!flag6)
		{
			goto IL_00cc;
		}
		goto IL_01d1;
		IL_01d1:
		_ = 1;
		object obj21 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v76+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		obj6 = obj9;
		if (obj22 != null)
		{
			goto IL_0101;
		}
		goto IL_0217;
		IL_00cc:
		obj21 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v76+E4]");
		bool flag8 = (nint)0 == 0;
		obj9 = obj6;
		if (!flag8)
		{
			goto IL_0101;
		}
		goto IL_0217;
		IL_0217:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isInitialized = Config.IsInitialized;
		bool flag9 = !isInitialized;
		obj6 = obj9;
		if (flag9)
		{
			return;
		}
		goto IL_0250;
		IL_0101:
		bool isInitialized2 = Config.IsInitialized;
		bool flag10 = !isInitialized2;
		object obj23 = !flag10;
		if (obj23 == null)
		{
			return;
		}
		goto IL_0250;
		IL_0250:
		object obj24 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			if (!Config.IsProduction)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!Config.IsProduction)
			{
				return;
			}
		}
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v4+E4]");
		bool flag11 = (nint)0 == 0;
		object obj26 = !flag11;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UpdateDimensions();
		object obj27 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v7+E4]");
		bool flag12 = (nint)0 == 0;
		object obj29 = !flag12;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		object obj30 = default(object);
		string text6 = ((Enum)(&obj30)).ToString();
		object name = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3656;
		object obj31 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
		object obj32 = (nint)0 & (nint)1;
		if (obj32 != null)
		{
			object obj33 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v41+E4]");
			if ((nint)0 != 0)
			{
				goto IL_041d;
			}
		}
		else
		{
			_ = 1;
			object obj33 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v41+E4]");
			bool flag13 = (nint)0 == 0;
			object obj34 = !flag13;
			if (obj34 != null)
			{
				goto IL_041d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		bool flag14 = !noPlayServices;
		object obj35 = !flag14;
		if (obj35 != null)
		{
			goto IL_0443;
		}
		goto IL_0646;
		IL_05a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj17 = 0;
		object obj36 = default(object);
		obj14 = obj36;
		goto IL_08fa;
		IL_0971:
		object obj37 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			bool noPlayServices2 = KUtil.NoPlayServices;
			bool flag15 = !noPlayServices2;
			object obj38 = !flag15;
			if (obj38 != null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool noPlayServices3 = KUtil.NoPlayServices;
			bool flag16 = !noPlayServices3;
			object obj39 = !flag16;
			if (obj39 != null)
			{
				return;
			}
		}
		bool flag17 = string.IsNullOrEmpty(text4);
		bool flag18 = !flag17;
		object obj40 = !flag18;
		if (obj40 == null)
		{
			Crashlytics.SetUserId(text4);
		}
		return;
		IL_0646:
		object obj41 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj42 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v36+E4]");
		bool flag19 = (nint)0 == 0;
		object obj43 = !flag19;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FirebaseAnalytics.SetUserProperty((string)name, text6);
		object obj44 = typeof(Queue<string>) + 848;
		object obj45 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v31+E4]");
		bool flag20 = (nint)0 == 0;
		object obj46 = !flag20;
		obj17 = 0;
		text = text6;
		object obj47 = 0;
		string text7 = text6;
		if (obj46 != null)
		{
			goto IL_0496;
		}
		goto IL_071c;
		IL_071c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj48 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag21 = (object)sessionModel == null;
		object obj49 = !flag21;
		obj17 = obj47;
		text = text7;
		if (obj49 != null)
		{
			goto IL_04d1;
		}
		goto IL_0779;
		IL_0443:
		object obj50 = typeof(Queue<string>) + 848;
		obj45 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v31+E4]");
		bool flag22 = (nint)0 == 0;
		text = null;
		obj47 = obj17;
		text7 = null;
		if (!flag22)
		{
			goto IL_0496;
		}
		goto IL_071c;
		IL_0779:
		obj17 = obj47;
		throw new NullReferenceException();
		IL_0496:
		object obj51 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag23 = (object)sessionModel == null;
		obj47 = obj17;
		if (!flag23)
		{
			goto IL_04d1;
		}
		goto IL_0779;
		IL_07fe:
		_ = 1;
		obj16 = obj17;
		text3 = text;
		text4 = text2;
		goto IL_0971;
	}

	public static string ItemId(ResourceItemId itemId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		return EnumExtensions.GetFriendlyName(enumeration);
	}

	public static string BuildItemId(ResourceItemId prefix, string name)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_007d: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 928;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return BuildItemId(friendlyName, name);
	}

	private static string BuildItemId(string prefix, string name)
	{
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_0325: Expected O, but got I4
		//IL_025d: Expected O, but got I4
		//IL_01b6: Expected O, but got I4
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0396: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		string text2;
		string text3;
		if (string.IsNullOrEmpty(prefix))
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v33+E4]");
			if ((nint)0 != 0)
			{
				string text = SanitizeItemIdPart(name);
				bool flag = string.IsNullOrEmpty(text);
				bool flag2 = !flag;
				text2 = text;
				if (flag2)
				{
					goto IL_027b;
				}
				text3 = text;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				string text4 = SanitizeItemIdPart(name);
				bool flag3 = string.IsNullOrEmpty(text4);
				bool flag4 = !flag3;
				object obj3 = !flag4;
				text2 = text4;
				text3 = text4;
				if (obj3 == null)
				{
					goto IL_027b;
				}
			}
			goto IL_02c5;
		}
		bool flag5 = string.IsNullOrEmpty(name);
		object obj4 = obj;
		if (flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			text2 = prefix;
			string text5 = null;
			text3 = prefix;
			if (!flag6)
			{
				goto IL_00eb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v13+E4]");
			string text7;
			string text5;
			if ((nint)0 != 0)
			{
				string text6 = SanitizeItemIdPart(name);
				bool flag7 = string.IsNullOrEmpty(text6);
				bool flag8 = !flag7;
				text5 = null;
				text7 = text6;
				if (!flag8)
				{
					goto IL_018c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				string text8 = SanitizeItemIdPart(name);
				bool flag9 = string.IsNullOrEmpty(text8);
				bool flag10 = !flag9;
				object obj5 = !flag10;
				text5 = null;
				text7 = text8;
				if (obj5 != null)
				{
					goto IL_018c;
				}
			}
			object obj6 = "[{0}]:{1}" + 912;
			text5 = (string)obj6;
			string text9 = prefix + (string)obj6 + text7;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v13+E4]");
			bool flag11 = (nint)0 == 0;
			object obj7 = !flag11;
			text2 = text9;
			if (obj7 != null)
			{
				goto IL_00eb;
			}
			text3 = text9;
		}
		goto IL_01d4;
		IL_018c:
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v13+E4]");
		bool flag12 = (nint)0 == 0;
		object obj8 = !flag12;
		text2 = prefix;
		text3 = prefix;
		if (obj8 != null)
		{
			goto IL_00eb;
		}
		goto IL_01d4;
		IL_00eb:
		if (!string.IsNullOrEmpty(text2))
		{
			goto IL_027b;
		}
		text3 = text2;
		goto IL_02c5;
		IL_027b:
		if (text2 != null)
		{
			bool flag13 = text2._stringLength >= 17;
			text3 = text2;
			if (!flag13)
			{
				goto IL_02c5;
			}
			return text2.Substring(0, 16);
		}
		return (string)(object)new NullReferenceException();
		IL_02c5:
		return text3;
		IL_01d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag14 = string.IsNullOrEmpty(text3);
		bool flag15 = !flag14;
		text2 = text3;
		if (flag15)
		{
			goto IL_027b;
		}
		goto IL_02c5;
	}

	private static bool IsClanFeature(TrackingFeature feature)
	{
		//IL_000e: Expected O, but got I4
		object obj = feature - 49;
		return obj == null;
	}

	private static string NormalizeItemId(string itemId)
	{
		//IL_0027: Expected O, but got I4
		bool flag = string.IsNullOrEmpty(itemId);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			if (itemId == null)
			{
				return (string)(object)new NullReferenceException();
			}
			if (itemId._stringLength >= 17)
			{
				return itemId.Substring(0, 16);
			}
		}
		return itemId;
	}

	private static string SanitizeItemIdPart(string value)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_0352: Expected I, but got O
		//IL_0362: Expected O, but got I
		//IL_0372: Expected O, but got I
		//IL_012f: Expected O, but got I
		//IL_0151: Expected O, but got I4
		//IL_018b: Expected O, but got I
		//IL_023c: Expected O, but got I4
		//IL_0274: Expected O, but got I4
		//IL_028e: Expected O, but got I4
		//IL_01c6: Expected O, but got I4
		//IL_03e5: Expected O, but got I4
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_0423: Expected O, but got I4
		//IL_02b3: Expected O, but got I4
		//IL_03c2: Expected O, but got I4
		//IL_0328: Expected O, but got I4
		if (string.IsNullOrEmpty(value))
		{
			return value;
		}
		StringBuilder stringBuilder = default(StringBuilder);
		if (value != null)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			stringBuilder..ctor(value._stringLength);
			string text = value.Trim();
			if (text != null)
			{
				if (text._stringLength < 1)
				{
					goto IL_032d;
				}
				object obj2 = 153100288 + 1024;
				object obj3 = 0;
				int num = 0;
				while (true)
				{
					char c = text.get_Chars(num);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X24_v5+88]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v15+E4]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag2 = char.IsLetterOrDigit(c);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X24_v5+88]");
					object obj6 = 0;
					char value2;
					if (flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v19+E4]");
						bool flag3 = (nint)0 == 0;
						object obj7 = !flag3;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						char c2 = char.ToLowerInvariant(c);
						if (stringBuilder == null)
						{
							break;
						}
						value2 = c2;
						goto IL_03b4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v19+E4]");
					bool flag4 = (nint)0 == 0;
					object obj8 = !flag4;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag5 = char.IsWhiteSpace(c);
					object obj9 = c - 45;
					bool flag6 = obj9 == null;
					object obj10 = !flag6;
					object obj11 = ~obj10;
					bool flag7;
					if (obj11 == null)
					{
						object obj12 = c - 95;
						flag7 = obj12 == null;
					}
					else
					{
						flag7 = true;
					}
					object obj13 = flag5 || flag7;
					object obj14 = ~obj13;
					object obj15 = obj3 | obj14;
					object obj16 = obj15 & 1;
					bool flag8 = obj16 == null;
					object obj17 = !flag8;
					if (obj17 == null)
					{
						if (stringBuilder == null)
						{
							break;
						}
						int length = stringBuilder.Length;
						if (length >= 1)
						{
							value2 = '_';
							goto IL_03b4;
						}
						obj3 = 0;
					}
					goto IL_00dc;
					IL_00dc:
					num++;
					if (num < text._stringLength)
					{
						continue;
					}
					goto IL_032d;
					IL_03b4:
					obj3 = (flag2 ? 1 : 0) ^ 1;
					StringBuilder stringBuilder2 = stringBuilder.Append(value2);
					goto IL_00dc;
				}
			}
		}
		goto IL_037c;
		IL_037c:
		return (string)(object)new NullReferenceException();
		IL_032d:
		if (stringBuilder != null)
		{
			nint num2 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v8 (Il2CppClass<System.Text.StringBuilder>)+168]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v8 (Il2CppClass<System.Text.StringBuilder>)+170]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v108 @ X2_v4 (should have been resolved before IL gen)");
		}
		goto IL_037c;
	}

	private static void UpdateTrackUserProfileDate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_016f: Expected O, but got I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0107: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0095: Expected O, but got I
		//IL_00af: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime today = DateTime.Today;
		DateTime dateTime = default(DateTime);
		DateTime date = dateTime.Date;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v8+E4]");
		object obj6;
		object key;
		if ((nint)0 != 0)
		{
			obj6 = "LAK" + 552;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D76]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			key = obj6;
			if (obj8 == null)
			{
				goto IL_00c5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = "LAK" + 552;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D76]");
			object obj9 = (nint)0 & (nint)1;
			if (obj9 == null)
			{
				goto IL_00c5;
			}
			key = obj6;
		}
		goto IL_017d;
		IL_017d:
		Prefs.SetDate((string)key, date);
		return;
		IL_00c5:
		_ = 1;
		key = obj6;
		goto IL_017d;
	}

	static Tracker()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1328;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = obj2;
		object obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
