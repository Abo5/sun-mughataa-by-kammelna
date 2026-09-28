using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

public static class RemoteAssetsCacher
{
	private enum RequestStatus
	{
		WaitingTurn,
		Requesting
	}

	private abstract class AssetRequest
	{
		private RequestStatus <Status>k__BackingField;

		public RequestStatus Status
		{
			get
			{
				return <Status>k__BackingField;
			}
			set
			{
				<Status>k__BackingField = value;
			}
		}

		public abstract string AssetId { get; }

		public abstract IEnumerable<UnityEngine.Object> Requestors { get; }

		public abstract bool IsInvalid();

		public abstract Type GetAssetType();
	}

	private class AssetRequest<T> : AssetRequest where T : class
	{
		private readonly AssetLoadingModel<T> <AssetModel>k__BackingField;

		private readonly Dictionary<UnityEngine.Object, Action<T>> <Receivers>k__BackingField;

		public AssetLoadingModel<T> AssetModel
		{
			get
			{
				//IL_000d: Expected O, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+AssetRequest`1<T>)+18]");
				return (AssetLoadingModel<T>)0;
			}
		}

		public Dictionary<UnityEngine.Object, Action<T>> Receivers
		{
			get
			{
				//IL_000d: Expected O, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+AssetRequest`1<T>)+20]");
				return (Dictionary<UnityEngine.Object, Action<T>>)0;
			}
		}

		public override string AssetId
		{
			get
			{
				//IL_0010: Expected O, but got I
				//IL_0042: Expected O, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+AssetRequest`1<T>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+AssetRequest`1<T>)+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+10]");
					return (string)0;
				}
				return (string)(object)new NullReferenceException();
			}
		}

		public override IEnumerable<UnityEngine.Object> Requestors
		{
			get
			{
				//IL_0037: Expected O, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+AssetRequest`1<T>)+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+AssetRequest`1<T>)+20]");
					return (IEnumerable<UnityEngine.Object>)(object)((Dictionary<object, object>)0).Keys;
				}
				return (IEnumerable<UnityEngine.Object>)new NullReferenceException();
			}
		}

		public AssetRequest(AssetLoadingModel<T> assetModel, UnityEngine.Object lifecycle, Action<T> callback)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_003e: Expected O, but got I
			//IL_0054: Expected O, but got I
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			//IL_007c: Expected O, but got I4
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected O, but got Unknown
			object obj = this + 24;
			obj = assetModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v2 (Il2CppRgctx<RemoteAssetsCacher+AssetRequest`1>)+10]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v2 (Il2CppRgctx<RemoteAssetsCacher+AssetRequest`1>)+10]");
			object obj3 = (nint)0 + (nint)309;
			object obj4 = obj3 & 1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Dictionary<object, object> dictionary = default(Dictionary<object, object>);
			dictionary..ctor();
			nint num2 = 0;
			dictionary.Add(lifecycle, callback);
			object obj6 = this + 32;
			obj6 = dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		public void RemoveRequestor(UnityEngine.Object gameObject)
		{
			//IL_0016: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+AssetRequest`1<T>)+20]");
			bool flag = ((Dictionary<object, object>)0).Remove(gameObject);
		}

		public override bool IsInvalid()
		{
			//IL_006e: Expected I4, but got O
			//IL_0057: Expected O, but got I
			if (this != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+AssetRequest`1<T>)+10]");
				if ((nint)0 != 0)
				{
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+AssetRequest`1<T>)+20]");
				return ArraysExtensions.IsNullOrEmpty((IEnumerable<KeyValuePair<object, object>>)0);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		public override Type GetAssetType()
		{
			//IL_0015: Expected O, but got I4
			//IL_0025: Expected O, but got I
			//IL_007f: Expected O, but got I
			//IL_005b: Expected O, but got I
			nint num = 0;
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v4+E0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X8_v2 (Il2CppRgctx<RemoteAssetsCacher+AssetRequest`1>)+70]");
				return Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X8_v2 (Il2CppRgctx<RemoteAssetsCacher+AssetRequest`1>)+70]");
			return Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<UnityEngine.Object, bool> <>9__17_2;

		public static Predicate<AssetRequest> <>9__17_0;

		public static Func<AssetRequest, bool> <>9__17_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 520;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <UpdateQueue>b__17_0(AssetRequest request)
		{
			//IL_01b5: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_00e2: Expected O, but got I
			//IL_00f2: Expected O, but got I
			//IL_0102: Expected O, but got I
			//IL_0124: Expected O, but got I4
			//IL_0067: Expected O, but got I
			//IL_0077: Expected O, but got I
			//IL_0087: Expected O, but got I
			//IL_00a9: Expected O, but got I4
			//IL_015c: Expected O, but got I4
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Expected O, but got Unknown
			//IL_01fc: Expected O, but got I
			//IL_020d: Expected I, but got O
			//IL_022b: Expected O, but got I
			//IL_018c: Expected O, but got I
			object obj;
			IEnumerable<UnityEngine.Object> requestors;
			object obj4;
			Func<object, bool> predicate;
			object obj6;
			object obj3;
			if (request != null)
			{
				obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 520;
				nint num = (nint)request;
				requestors = request.Requestors;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+E4]");
				if ((nint)0 != 0)
				{
					obj3 = (nint)0 + (nint)1928;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v7+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v7+8]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						obj6 = obj3;
						goto IL_013a;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					obj6 = (nint)0 + (nint)1928;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v7+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v7+8]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					obj3 = obj6;
					if (obj7 == null)
					{
						goto IL_013a;
					}
				}
				goto IL_0191;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0191:
			return Enumerable.All(requestors, predicate);
			IL_013a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v13+B8]");
				obj4 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2616;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)3744;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj4, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v12+B8]");
			object obj13 = (nint)0 + (nint)8;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj3 = obj6;
			predicate = func;
			goto IL_0191;
		}

		internal bool <UpdateQueue>b__17_2(UnityEngine.Object requestor)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return requestor == null;
		}

		internal bool <UpdateQueue>b__17_1(AssetRequest r)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (r != null)
			{
				object obj = r.<Status>k__BackingField - 1;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	[Serializable]
	private sealed class <>c__18<T> where T : class
	{
		public static readonly <>c__18<T> <>9;

		public static Predicate<AssetRequest> <>9__18_2;

		static <>c__18()
		{
			//IL_000c: Expected O, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0287: Expected O, but got I
			//IL_028f: Expected I, but got O
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected O, but got Unknown
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected O, but got Unknown
			//IL_02c5: Expected O, but got I4
			//IL_02cd: Expected I, but got O
			//IL_009c: Expected O, but got I
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00c4: Expected O, but got I4
			//IL_0053: Expected O, but got I
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0114: Expected O, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0360: Expected O, but got I
			//IL_0370: Expected O, but got I
			//IL_0386: Expected O, but got I
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected O, but got Unknown
			//IL_03ae: Expected O, but got I4
			//IL_03be: Expected O, but got I
			//IL_0300: Expected O, but got I
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Expected O, but got Unknown
			//IL_01b6: Expected O, but got I
			//IL_01ca: Expected O, but got I
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_016b: Expected O, but got I
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_0198: Expected O, but got I
			//IL_0450: Expected O, but got I
			//IL_0460: Expected O, but got I
			//IL_0476: Expected O, but got I
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_049e: Expected O, but got I4
			//IL_04ae: Expected O, but got I
			//IL_03e6: Expected O, but got I
			//IL_03fa: Expected O, but got I
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Expected O, but got Unknown
			//IL_0422: Expected O, but got I4
			//IL_0211: Expected O, but got I
			//IL_0227: Expected O, but got I
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			//IL_0254: Expected O, but got I
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			if (obj2 != null)
			{
				nint num = 0;
				nint num2 = num;
				object obj3 = num + 309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				nint num3 = num;
				if (!flag)
				{
					goto IL_0086;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v6+C0]");
				object obj5 = 0;
				nint num2 = (nint)obj5;
				object obj6 = obj5 + 309;
				object obj7 = obj6 & 1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				nint num3 = (nint)obj5;
				if (obj8 != null)
				{
					goto IL_0086;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj12 = default(object);
			object obj11 = obj12;
			nint num4 = 0;
			if (flag3)
			{
				goto IL_00e8;
			}
			object obj13 = obj12;
			goto IL_00ff;
			IL_01a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v28+B8]");
			object obj14 = 0;
			obj14 = obj13;
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag4 = obj16 == null;
			nint num5 = 0;
			if (!flag4)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_01fb:
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<RemoteAssetsCacher+<>c__18`1>)+10]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<RemoteAssetsCacher+<>c__18`1>)+10]");
			object obj18 = (nint)0 + (nint)309;
			object obj19 = obj18 & 1;
			bool flag5 = obj19 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<RemoteAssetsCacher+<>c__18`1>)+10]");
			object obj20 = 0;
			if (!flag5)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_04bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
			IL_0436:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v16+C0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			object obj22 = (nint)0 + (nint)309;
			object obj23 = obj22 & 1;
			bool flag6 = obj23 == null;
			object obj24 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj20 = 0;
			if (obj24 != null)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_0086:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25 & 1;
			bool flag7 = obj26 == null;
			object obj27 = !flag7;
			object obj28 = default(object);
			obj11 = obj28;
			num4 = 0;
			obj13 = obj28;
			if (obj27 == null)
			{
				goto IL_00e8;
			}
			goto IL_00ff;
			IL_00e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			obj13 = obj11;
			goto IL_00ff;
			IL_00ff:
			obj13..ctor();
			object obj29 = (nint)0 + (nint)309;
			object obj30 = obj29 & 1;
			if (obj30 != null)
			{
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<RemoteAssetsCacher+<>c__18`1>)+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<RemoteAssetsCacher+<>c__18`1>)+10]");
				object obj32 = (nint)0 + (nint)309;
				object obj33 = obj32 & 1;
				bool flag8 = obj33 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<RemoteAssetsCacher+<>c__18`1>)+10]");
				object obj34 = 0;
				if (!flag8)
				{
					goto IL_01a6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v21+C0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj36 = (nint)0 + (nint)309;
				object obj37 = obj36 & 1;
				bool flag9 = obj37 == null;
				object obj38 = !flag9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj34 = 0;
				if (obj38 != null)
				{
					goto IL_01a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v19+B8]");
			object obj39 = 0;
			obj39 = obj13;
			object obj40 = (nint)0 + (nint)309;
			object obj41 = obj40 & 1;
			bool flag10 = obj41 == null;
			object obj42 = !flag10;
			num5 = 0;
			if (obj42 != null)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_0262:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <CleanQueues>b__18_2(AssetRequest request)
		{
			//IL_005d: Expected I4, but got O
			//IL_0025: Expected I, but got O
			//IL_0035: Expected O, but got I
			//IL_0045: Expected O, but got I
			if (request != null)
			{
				nint num = (nint)request;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<RemoteAssetsCacher+AssetRequest>)+198]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<RemoteAssetsCacher+AssetRequest>)+1A0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass11_0<T> where T : class
	{
		public AssetRequest<T> assetRequest;

		internal bool <NotifyAssetResult>b__0(AssetRequest r)
		{
			//IL_007c: Expected I4, but got O
			if (assetRequest != null)
			{
				string assetId = ((AssetRequest<>)(object)assetRequest).AssetId;
				if (r != null)
				{
					string assetId2 = r.AssetId;
					return assetId == assetId2;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass16_0<T> where T : class
	{
		public AssetLoadingModel<T> asset;

		internal bool <QueueLoadOperation>b__0(AssetRequest ar)
		{
			//IL_007d: Expected I4, but got O
			if (ar != null)
			{
				string assetId = ar.AssetId;
				AssetLoadingModel<T> assetLoadingModel = asset;
				if (asset != null)
				{
					return assetId == assetLoadingModel.<AssetId>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass18_0<T> where T : class
	{
		public UnityEngine.Object go;

		internal bool <CleanQueues>b__0(AssetRequest request)
		{
			//IL_0039: Expected I4, but got O
			if (request != null)
			{
				IEnumerable<object> requestors = request.Requestors;
				return Enumerable.Contains(requestors, go);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <CleanQueues>b__1(AssetRequest<T> request)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3C7A440");
		}
	}

	private sealed class <LoadAssetCoroutine>d__9<T> : IEnumerator<object>, IEnumerator, IDisposable where T : class
	{
		private int <>1__state;

		private object <>2__current;

		public AssetRequest<T> request;

		private AssetLoadingModel<T> <asset>5__2;

		private List<IAssetLoader>.Enumerator <>7__wrap2;

		private IEnumerator <operation>5__4;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <LoadAssetCoroutine>d__9(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		unsafe void IDisposable.Dispose()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0085: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_00a2: Expected I4, but got I8
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected O, but got Unknown
			object obj = <>1__state - 1;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3 = ~obj2;
			bool flag2;
			if (obj3 == null)
			{
				object obj4 = <>1__state - -3;
				flag2 = obj4 == null;
			}
			else
			{
				flag2 = true;
			}
			object obj5 = !flag2;
			if (obj5 == null)
			{
				<>1__state = -1;
				List<object>.Enumerator enumerator = (List<object>.Enumerator)(this + 48);
				((List<object>.Enumerator*)enumerator)->Dispose();
			}
		}

		private unsafe bool MoveNext()
		{
			//IL_0008: Expected O, but got Ref
			//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc9: Expected O, but got Unknown
			//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cdd: Expected O, but got Unknown
			//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf1: Expected O, but got Unknown
			//IL_0d0d: Expected O, but got I4
			//IL_0d1d: Expected O, but got I4
			//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d5c: Expected I4, but got Unknown
			//IL_017d: Expected I4, but got I8
			//IL_018d: Expected O, but got I
			//IL_01af: Expected O, but got I4
			//IL_0247: Expected O, but got I
			//IL_06b6: Expected I, but got O
			//IL_06c6: Expected O, but got I
			//IL_002b: Expected O, but got I4
			//IL_07f2: Expected O, but got I4
			//IL_11c8: Expected O, but got I
			//IL_11d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_11d6: Expected O, but got Unknown
			//IL_11f0: Expected O, but got I4
			//IL_0701: Expected O, but got I
			//IL_0048: Expected I4, but got I8
			//IL_098a: Expected O, but got I
			//IL_10ff: Expected O, but got I
			//IL_1120: Expected O, but got I4
			//IL_1130: Unknown result type (might be due to invalid IL or missing references)
			//IL_1135: Expected O, but got Unknown
			//IL_116a: Unknown result type (might be due to invalid IL or missing references)
			//IL_116f: Expected I4, but got Unknown
			//IL_117f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1184: Expected I4, but got Unknown
			//IL_0807: Unknown result type (might be due to invalid IL or missing references)
			//IL_080c: Expected O, but got Unknown
			//IL_0815: Unknown result type (might be due to invalid IL or missing references)
			//IL_081a: Expected O, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected O, but got Unknown
			//IL_008c: Expected O, but got I
			//IL_00c0: Expected O, but got I4
			//IL_09b7: Expected I, but got O
			//IL_09c7: Expected O, but got I
			//IL_0717: Unknown result type (might be due to invalid IL or missing references)
			//IL_071c: Expected O, but got Unknown
			//IL_0732: Expected O, but got I
			//IL_074c: Expected O, but got I4
			//IL_0755: Unknown result type (might be due to invalid IL or missing references)
			//IL_075a: Expected O, but got Unknown
			//IL_0781: Unknown result type (might be due to invalid IL or missing references)
			//IL_0786: Expected I4, but got Unknown
			//IL_0793: Expected I4, but got O
			//IL_0d96: Expected O, but got I
			//IL_0a56: Expected O, but got I4
			//IL_0864: Expected O, but got I
			//IL_0874: Expected O, but got I
			//IL_088e: Expected O, but got I
			//IL_0897: Unknown result type (might be due to invalid IL or missing references)
			//IL_089c: Expected O, but got Unknown
			//IL_08b6: Expected O, but got I4
			//IL_1242: Expected O, but got I
			//IL_1264: Expected O, but got I
			//IL_0a02: Expected O, but got I
			//IL_0a85: Expected O, but got I4
			//IL_00f7: Expected O, but got I
			//IL_011b: Expected O, but got I
			//IL_0ab2: Expected O, but got I
			//IL_0ac2: Expected O, but got I
			//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d2: Expected O, but got Unknown
			//IL_08db: Expected O, but got I4
			//IL_013a: Expected O, but got I
			//IL_0151: Expected O, but got I8
			//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b45: Expected O, but got Unknown
			//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b52: Expected O, but got Unknown
			//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b60: Expected O, but got Unknown
			//IL_0dd1: Expected O, but got I
			//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a15: Expected O, but got Unknown
			//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a23: Expected O, but got Unknown
			//IL_1284: Expected O, but got I
			//IL_12a4: Expected O, but got I
			//IL_12bd: Expected O, but got I
			//IL_12f9: Expected O, but got I4
			//IL_0b05: Expected O, but got I
			//IL_0b15: Expected O, but got I
			//IL_0291: Expected O, but got I
			//IL_02a1: Expected O, but got I
			//IL_02d6: Expected O, but got I
			//IL_02ec: Expected O, but got I
			//IL_0509: Expected O, but got I
			//IL_0519: Expected O, but got I
			//IL_0529: Expected O, but got I
			//IL_0531: Expected I, but got O
			//IL_0541: Expected O, but got I
			//IL_0336: Expected I, but got O
			//IL_0346: Expected O, but got I
			//IL_0ff8: Expected O, but got I
			//IL_101a: Expected O, but got I
			//IL_102a: Expected O, but got I
			//IL_10e1: Expected O, but got I
			//IL_057c: Expected O, but got I
			//IL_0472: Expected O, but got I4
			//IL_0eff: Expected O, but got I
			//IL_0f28: Expected O, but got I4
			//IL_0f45: Expected O, but got I
			//IL_0f9f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa4: Expected I4, but got Unknown
			//IL_0ecd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed2: Expected O, but got Unknown
			//IL_0381: Expected O, but got I
			//IL_0679: Unknown result type (might be due to invalid IL or missing references)
			//IL_067e: Expected O, but got Unknown
			//IL_0686: Unknown result type (might be due to invalid IL or missing references)
			//IL_068b: Expected O, but got Unknown
			//IL_0694: Unknown result type (might be due to invalid IL or missing references)
			//IL_0699: Expected O, but got Unknown
			//IL_0e0b: Expected O, but got I
			//IL_0e2c: Expected O, but got I4
			//IL_0e3c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e41: Expected O, but got Unknown
			//IL_0e76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e7b: Expected I4, but got Unknown
			//IL_0e8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e90: Expected I4, but got Unknown
			//IL_0592: Unknown result type (might be due to invalid IL or missing references)
			//IL_0597: Expected O, but got Unknown
			//IL_05ad: Expected O, but got I
			//IL_05c7: Expected O, but got I4
			//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d5: Expected O, but got Unknown
			//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0601: Expected I4, but got Unknown
			//IL_060e: Expected I4, but got O
			//IL_04bf: Expected O, but got I
			//IL_04cf: Expected O, but got I
			//IL_0487: Unknown result type (might be due to invalid IL or missing references)
			//IL_048c: Expected O, but got Unknown
			//IL_0495: Unknown result type (might be due to invalid IL or missing references)
			//IL_049a: Expected O, but got Unknown
			//IL_0397: Unknown result type (might be due to invalid IL or missing references)
			//IL_039c: Expected O, but got Unknown
			//IL_03b2: Expected O, but got I
			//IL_03cc: Expected O, but got I4
			//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03da: Expected O, but got Unknown
			//IL_0401: Unknown result type (might be due to invalid IL or missing references)
			//IL_0406: Expected I4, but got Unknown
			//IL_0413: Expected I4, but got O
			object obj2 = default(object);
			object obj = (object)(&obj2);
			object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1000;
			object obj4 = typeof(RegisteredWaitHandle) + 40;
			object obj5 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			bool flag = <>1__state < 1;
			object obj6 = !flag;
			object obj7 = <>1__state - 1;
			bool flag2 = (nint)obj7 < 0;
			bool flag3 = <>1__state == 1;
			int num = <>1__state ^ 1;
			int num2 = <>1__state ^ obj7;
			int num3 = num & num2;
			bool flag4 = num3 < 0;
			object obj18 = default(object);
			object obj15 = default(object);
			object obj17 = default(object);
			object obj19 = default(object);
			<LoadAssetCoroutine>d__9<T> <LoadAssetCoroutine>d__;
			object obj14;
			if (!flag3)
			{
				bool flag5 = <>1__state == 0;
				object obj8 = !flag5;
				if (obj8 != null)
				{
					goto IL_0b29;
				}
				<>1__state = -1;
				AssetRequest<T> assetRequest = request;
				if (request != null)
				{
					<LoadAssetCoroutine>d__ = (<LoadAssetCoroutine>d__9<T>)(this + 40);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v59 (RemoteAssetsCacher+AssetRequest`1<T>)+18]");
					<LoadAssetCoroutine>d__ = (<LoadAssetCoroutine>d__9<T>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj9 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v75+E4]");
					bool flag6 = (nint)0 == 0;
					object obj10 = !flag6;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj9 = obj4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v75+B8]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v61+8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v61+8]");
						List<object>.Enumerator enumerator = ((List<object>)0).GetEnumerator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
						object obj12 = (nint)0 + (nint)48;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
						object obj13 = 0;
						_ = 4294967293L;
						obj14 = 4294967293L;
						object obj16 = default(object);
						obj15 = obj16;
						obj17 = obj18;
						obj19 = obj18;
						goto IL_0dbb;
					}
					throw new NullReferenceException();
				}
				throw new NullReferenceException();
			}
			<>1__state = -3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>)+48]");
			<LoadAssetCoroutine>d__ = (<LoadAssetCoroutine>d__9<T>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>)+48]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			object obj22 = default(object);
			object obj21 = obj22;
			object obj24 = default(object);
			object obj23 = obj24;
			object obj26 = default(object);
			object obj25 = obj26;
			bool flag9 = default(bool);
			bool flag8 = flag9;
			bool flag10 = flag4;
			int num4 = num3;
			int num5 = num2;
			int num6 = num;
			bool flag11 = flag3;
			bool flag12 = flag2;
			object obj27 = obj7;
			object obj28 = obj6;
			object obj30 = default(object);
			object obj29 = obj30;
			object obj31 = obj15;
			object obj32 = obj17;
			object obj33 = obj19;
			object obj34 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>)+48]");
			<LoadAssetCoroutine>d__9<T> <LoadAssetCoroutine>d__2 = (<LoadAssetCoroutine>d__9<T>)0;
			if (obj20 == null)
			{
				goto IL_0255;
			}
			goto IL_06ae;
			IL_1278:
			object obj35 = (nint)0 + (nint)1280;
			_ = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
			List<object>.Enumerator enumerator2 = (List<object>.Enumerator)((nint)0 + (nint)48);
			((List<object>.Enumerator*)enumerator2)->Dispose();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
			object obj36 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			object obj37 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v32+E4]");
			bool flag13 = (nint)0 == 0;
			object obj38 = !flag13;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ stack_-60_v2+20]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v33+C0]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEF2B4");
			UpdateQueue();
			goto IL_0b29;
			IL_11ae:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v460 @ X0_v41] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
			object obj41 = 0;
			object obj43 = default(object);
			object obj42 = obj43 & 1;
			bool flag14 = obj42 == null;
			object obj44 = !flag14;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v40+28]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ stack_-60_v2+20]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v47+C0]");
					object obj46 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3C7A23C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
					object obj47 = 0;
					object obj49 = default(object);
					object obj48 = obj49 & 1;
					bool flag15 = obj48 == null;
					object obj50 = !flag15;
					if (obj50 == null)
					{
						object obj51 = obj47 + 72;
						obj51 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj22 = obj21;
						obj24 = obj23;
						obj26 = obj25;
						flag9 = flag8;
						flag4 = flag10;
						num3 = num4;
						num2 = num5;
						num = num6;
						flag3 = flag11;
						flag2 = flag12;
						obj7 = obj27;
						obj6 = obj28;
						obj30 = obj29;
						obj15 = obj31;
						obj17 = obj32;
						obj19 = obj33;
						obj18 = obj34;
						<LoadAssetCoroutine>d__ = <LoadAssetCoroutine>d__2;
						goto IL_0dbb;
					}
					object obj52 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v59+E4]");
					bool flag16 = (nint)0 == 0;
					object obj53 = !flag16;
					if (obj53 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ stack_-60_v2+20]");
					object obj54 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v52+C0]");
					object obj55 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEACC");
					obj26 = obj25;
					obj19 = obj33;
					goto IL_1278;
				}
				throw new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v40+48]");
			<LoadAssetCoroutine>d__ = (<LoadAssetCoroutine>d__9<T>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v40+48]");
			if ((nint)0 != 0)
			{
				nint num7 = (nint)<LoadAssetCoroutine>d__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v41 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+12E]");
				object obj56 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v41 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0a43;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v41 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+B0]");
				object obj57 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X10_v24-8]");
					if (0 == (nint)obj5)
					{
						break;
					}
					obj57 += 16;
					obj56--;
					if ((nint)obj56 != 1)
					{
						continue;
					}
					goto IL_0a43;
				}
				object obj58 = obj57 + 1;
				object obj59 = num7 + obj58;
				object obj60 = obj59 + 312;
				goto IL_1222;
			}
			throw new NullReferenceException();
			IL_1222:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v623 @ X0_v45] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
			object obj61 = (nint)0 + (nint)24;
			object obj62 = default(object);
			obj61 = obj62;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
			object obj63 = 0;
			_ = 1;
			return true;
			IL_06ae:
			nint num8 = (nint)<LoadAssetCoroutine>d__2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v37 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+12E]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v37 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_07df;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v37 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+B0]");
			object obj64 = (nint)0 + (nint)8;
			bool flag17 = flag8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X10_v29-8]");
				obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X10_v29-8]");
				bool flag18 = 0 < (nint)obj5;
				obj28 = !flag18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X10_v29-8]");
				obj27 = 0 - obj5;
				flag12 = (nint)obj27 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X10_v29-8]");
				flag11 = 0 == (nint)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X10_v29-8]");
				num6 = 0 ^ obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X10_v29-8]");
				num5 = 0 ^ obj27;
				num4 = num6 & num5;
				flag10 = num4 < 0;
				if (flag11)
				{
					break;
				}
				obj29 = obj64 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v37 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+12E]");
				obj14 = -1;
				bool flag19 = (nint)obj14 < 1;
				obj28 = !flag19;
				obj27 = obj14 - 1;
				flag12 = (nint)obj27 < 0;
				flag11 = obj27 == null;
				num6 = obj14 ^ 1;
				num5 = obj14 ^ obj27;
				num4 = num6 & num5;
				flag10 = num4 < 0;
				flag8 = (nint)obj14 != 1;
				flag17 = flag8;
				obj64 = obj29;
				if (flag8)
				{
					continue;
				}
				goto IL_07df;
			}
			obj14 = obj64;
			object obj65 = num8 + obj64;
			object obj66 = obj65 + 312;
			flag8 = flag17;
			obj29 = obj64;
			goto IL_11ae;
			IL_0255:
			throw new NullReferenceException();
			IL_04af:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
			object obj67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v22+28]");
			object obj68 = 0;
			goto IL_04f9;
			IL_0fce:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1950");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v748 @ X0_v10+8] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
			object obj69 = (nint)0 + (nint)72;
			object obj70 = default(object);
			obj69 = obj70;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
			object obj71 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X19_v6+48]");
			<LoadAssetCoroutine>d__ = (<LoadAssetCoroutine>d__9<T>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X19_v6+48]");
			bool flag20 = (nint)0 == 0;
			object obj72 = default(object);
			obj26 = obj72;
			obj21 = obj22;
			obj23 = obj24;
			obj25 = obj72;
			flag8 = flag9;
			flag10 = flag4;
			num4 = num3;
			num5 = num2;
			num6 = num;
			flag11 = flag3;
			flag12 = flag2;
			obj27 = obj7;
			obj28 = obj6;
			obj29 = obj30;
			obj31 = obj15;
			obj32 = obj17;
			obj33 = obj19;
			obj34 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X19_v6+48]");
			<LoadAssetCoroutine>d__2 = (<LoadAssetCoroutine>d__9<T>)0;
			if (flag20)
			{
				goto IL_0255;
			}
			goto IL_06ae;
			IL_065a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0fce;
			IL_0b29:
			return false;
			IL_0dbb:
			object obj79 = default(object);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
				List<object>.Enumerator enumerator3 = (List<object>.Enumerator)((nint)0 + (nint)48);
				if (!((List<object>.Enumerator*)enumerator3)->MoveNext())
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
				object obj73 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v9+28]");
				obj68 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v9+28]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v9+40]");
					<LoadAssetCoroutine>d__ = (<LoadAssetCoroutine>d__9<T>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X20_v6+39]");
					object obj74 = (nint)0 & (nint)1;
					if (obj74 == null)
					{
						goto IL_04d4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v9+40]");
					if ((nint)0 != 0)
					{
						nint num9 = (nint)<LoadAssetCoroutine>d__;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v19 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+12E]");
						obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v19 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_045f;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v19 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+B0]");
						object obj75 = (nint)0 + (nint)8;
						bool flag21 = flag9;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X10_v14-8]");
							obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X10_v14-8]");
							bool flag22 = 0 < (nint)obj3;
							obj6 = !flag22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X10_v14-8]");
							obj7 = 0 - obj3;
							flag2 = (nint)obj7 < 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X10_v14-8]");
							flag3 = 0 == (nint)obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X10_v14-8]");
							num = 0 ^ obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X10_v14-8]");
							num2 = 0 ^ obj7;
							num3 = num & num2;
							flag4 = num3 < 0;
							if (flag3)
							{
								break;
							}
							obj30 = obj75 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v19 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+12E]");
							obj14 = -1;
							bool flag23 = (nint)obj14 < 1;
							obj6 = !flag23;
							obj7 = obj14 - 1;
							flag2 = (nint)obj7 < 0;
							flag3 = obj7 == null;
							num = obj14 ^ 1;
							num2 = obj14 ^ obj7;
							num3 = num & num2;
							flag4 = num3 < 0;
							flag9 = (nint)obj14 != 1;
							flag21 = flag9;
							obj75 = obj30;
							if (flag9)
							{
								continue;
							}
							goto IL_045f;
						}
						obj14 = obj75;
						object obj76 = num9 + obj75;
						object obj77 = obj76 + 312;
						flag9 = flag21;
						obj30 = obj75;
						goto IL_0eba;
					}
					throw new NullReferenceException();
				}
				throw new NullReferenceException();
				IL_045f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj26 = 0;
				goto IL_0eba;
				IL_0eba:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v735 @ X0_v21] (should have been resolved before IL gen)");
				object obj78 = obj79 & 1;
				if (obj78 == null)
				{
					continue;
				}
				goto IL_04af;
			}
			goto IL_1278;
			IL_04f9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ stack_-60_v2+20]");
			object obj80 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X8_v13+C0]");
			object obj81 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v14+30]");
			obj24 = 0;
			nint num10 = (nint)<LoadAssetCoroutine>d__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v15 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+12E]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v15 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_065a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v15 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+B0]");
			object obj82 = (nint)0 + (nint)8;
			bool flag24 = flag9;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X10_v8-8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X10_v8-8]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X21_v3+20]");
				bool flag25 = num11 < 0;
				obj6 = !flag25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X10_v8-8]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X21_v3+20]");
				obj7 = num12 - 0;
				flag2 = (nint)obj7 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X10_v8-8]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X21_v3+20]");
				flag3 = num13 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X10_v8-8]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X21_v3+20]");
				num = (int)(num14 ^ 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X10_v8-8]");
				num2 = 0 ^ obj7;
				num3 = num & num2;
				flag4 = num3 < 0;
				if (flag3)
				{
					break;
				}
				obj30 = obj82 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v15 (Il2CppClass<RemoteAssetsCacher+<LoadAssetCoroutine>d__9`1<T>>)+12E]");
				obj14 = -1;
				bool flag26 = (nint)obj14 < 1;
				obj6 = !flag26;
				obj7 = obj14 - 1;
				flag2 = (nint)obj7 < 0;
				flag3 = obj7 == null;
				num = obj14 ^ 1;
				num2 = obj14 ^ obj7;
				num3 = num & num2;
				flag4 = num3 < 0;
				flag9 = (nint)obj14 != 1;
				flag24 = flag9;
				obj82 = obj30;
				if (flag9)
				{
					continue;
				}
				goto IL_065a;
			}
			object obj83 = obj82;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X21_v3+50]");
			obj14 = obj83 + 0;
			object obj84 = num10 + obj14;
			object obj85 = obj84 + 312;
			flag9 = flag24;
			obj30 = obj82;
			goto IL_0fce;
			IL_0a43:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj25 = 1;
			goto IL_1222;
			IL_07df:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj25 = 0;
			goto IL_11ae;
			IL_04d4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v9+40]");
			if ((nint)0 != 0)
			{
				goto IL_04f9;
			}
			throw new NullReferenceException();
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private unsafe void <>m__Finally1()
		{
			//IL_0015: Expected I4, but got I8
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			<>1__state = -1;
			List<object>.Enumerator enumerator = (List<object>.Enumerator)(this + 48);
			((List<object>.Enumerator*)enumerator)->Dispose();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}
	}

	private sealed class <Retry>d__10<T> : IEnumerator<object>, IEnumerator, IDisposable where T : class
	{
		private int <>1__state;

		private object <>2__current;

		public AssetLoadingModel<T> asset;

		public IAssetLoader breakAt;

		private List<IAssetLoader>.Enumerator <>7__wrap1;

		private IEnumerator <operation>5__3;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <Retry>d__10(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		unsafe void IDisposable.Dispose()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0085: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_00a2: Expected I4, but got I8
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected O, but got Unknown
			object obj = <>1__state - 1;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3 = ~obj2;
			bool flag2;
			if (obj3 == null)
			{
				object obj4 = <>1__state - -3;
				flag2 = obj4 == null;
			}
			else
			{
				flag2 = true;
			}
			object obj5 = !flag2;
			if (obj5 == null)
			{
				<>1__state = -1;
				List<object>.Enumerator enumerator = (List<object>.Enumerator)(this + 48);
				((List<object>.Enumerator*)enumerator)->Dispose();
			}
		}

		private unsafe bool MoveNext()
		{
			//IL_0008: Expected O, but got Ref
			//IL_0b00: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b05: Expected O, but got Unknown
			//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b19: Expected O, but got Unknown
			//IL_0b2b: Expected O, but got I4
			//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b5c: Expected I4, but got Unknown
			//IL_0148: Expected I4, but got I8
			//IL_0158: Expected O, but got I
			//IL_017a: Expected O, but got I4
			//IL_01fa: Expected O, but got I
			//IL_05ee: Expected O, but got I
			//IL_0030: Expected O, but got I4
			//IL_06e6: Expected O, but got I4
			//IL_0ff1: Expected O, but got I
			//IL_0ffa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fff: Expected O, but got Unknown
			//IL_1019: Expected O, but got I4
			//IL_0629: Expected O, but got I
			//IL_004d: Expected I4, but got I8
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_008b: Expected O, but got I4
			//IL_0889: Expected O, but got I
			//IL_0f63: Expected O, but got I
			//IL_0f75: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f7a: Expected O, but got Unknown
			//IL_0fa1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa6: Expected I4, but got Unknown
			//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fbb: Expected I4, but got Unknown
			//IL_0b88: Expected O, but got I
			//IL_0709: Unknown result type (might be due to invalid IL or missing references)
			//IL_070e: Expected O, but got Unknown
			//IL_08c6: Expected O, but got I
			//IL_063f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0644: Expected O, but got Unknown
			//IL_065a: Expected O, but got I
			//IL_0665: Unknown result type (might be due to invalid IL or missing references)
			//IL_066a: Expected O, but got Unknown
			//IL_0683: Unknown result type (might be due to invalid IL or missing references)
			//IL_0688: Expected I4, but got Unknown
			//IL_0695: Expected I4, but got O
			//IL_00c2: Expected O, but got I
			//IL_00e6: Expected O, but got I
			//IL_0955: Expected O, but got I4
			//IL_0758: Expected O, but got I
			//IL_0768: Expected O, but got I
			//IL_0778: Expected O, but got I
			//IL_0792: Expected O, but got I
			//IL_079b: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a0: Expected O, but got Unknown
			//IL_07ba: Expected O, but got I4
			//IL_0105: Expected O, but got I
			//IL_011c: Expected O, but got I8
			//IL_109d: Expected O, but got I
			//IL_10bf: Expected O, but got I
			//IL_0901: Expected O, but got I
			//IL_0bc3: Expected O, but got I
			//IL_0be0: Expected O, but got I
			//IL_103d: Expected O, but got I
			//IL_1046: Unknown result type (might be due to invalid IL or missing references)
			//IL_104b: Expected O, but got Unknown
			//IL_07de: Expected O, but got I
			//IL_07e7: Expected O, but got I4
			//IL_0963: Unknown result type (might be due to invalid IL or missing references)
			//IL_0968: Expected O, but got Unknown
			//IL_097e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0983: Expected O, but got Unknown
			//IL_0f22: Expected O, but got I
			//IL_0f3b: Expected O, but got I
			//IL_0234: Expected O, but got I
			//IL_090f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0914: Expected O, but got Unknown
			//IL_091d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0922: Expected O, but got Unknown
			//IL_0a70: Expected O, but got I4
			//IL_0269: Expected O, but got I
			//IL_027f: Expected O, but got I
			//IL_0c0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c14: Expected O, but got Unknown
			//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c40: Expected I4, but got Unknown
			//IL_0c4d: Expected I4, but got O
			//IL_02d9: Expected O, but got I
			//IL_0450: Expected O, but got I
			//IL_0460: Expected O, but got I
			//IL_0470: Expected O, but got I
			//IL_0480: Expected O, but got I
			//IL_0498: Expected O, but got I
			//IL_03d1: Expected O, but got I4
			//IL_0314: Expected O, but got I
			//IL_0e22: Expected O, but got I
			//IL_0e44: Expected O, but got I
			//IL_0e54: Expected O, but got I
			//IL_0ef3: Expected O, but got I
			//IL_04d3: Expected O, but got I
			//IL_0cc1: Expected O, but got I
			//IL_0cd3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cd8: Expected O, but got Unknown
			//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d04: Expected I4, but got Unknown
			//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d19: Expected I4, but got Unknown
			//IL_0d6c: Expected O, but got I
			//IL_0d8b: Expected O, but got I
			//IL_0dd7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ddc: Expected I4, but got Unknown
			//IL_041e: Expected O, but got I
			//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f9: Expected O, but got Unknown
			//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a6: Expected O, but got Unknown
			//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c1: Expected O, but got Unknown
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_032f: Expected O, but got Unknown
			//IL_0345: Expected O, but got I
			//IL_0350: Unknown result type (might be due to invalid IL or missing references)
			//IL_0355: Expected O, but got Unknown
			//IL_036e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Expected I4, but got Unknown
			//IL_0380: Expected I4, but got O
			//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ee: Expected O, but got Unknown
			//IL_0504: Expected O, but got I
			//IL_050f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0514: Expected O, but got Unknown
			//IL_052d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0532: Expected I4, but got Unknown
			//IL_053f: Expected I4, but got O
			object obj2 = default(object);
			object obj = (object)(&obj2);
			object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1000;
			object obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			object obj5 = <>1__state - 1;
			bool flag = <>1__state == 1;
			int num = <>1__state ^ 1;
			int num2 = <>1__state ^ obj5;
			int num3 = num & num2;
			object obj17 = default(object);
			object obj14 = default(object);
			object obj16 = default(object);
			object obj18 = default(object);
			object obj13;
			object obj7;
			if (!flag)
			{
				bool flag2 = <>1__state == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					<>1__state = -1;
					obj7 = typeof(RegisteredWaitHandle) + 40;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v72+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj8 = obj7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v72+B8]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v57+8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v57+8]");
						List<object>.Enumerator enumerator = ((List<object>)0).GetEnumerator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
						object obj11 = (nint)0 + (nint)48;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
						object obj12 = 0;
						_ = 4294967293L;
						obj13 = 4294967293L;
						object obj15 = default(object);
						obj14 = obj15;
						obj16 = obj17;
						obj18 = obj17;
						goto IL_0bad;
					}
					throw new NullReferenceException();
				}
				return false;
			}
			<>1__state = -3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+<Retry>d__10`1<T>)+48]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+<Retry>d__10`1<T>)+48]");
			bool flag4 = (nint)0 == 0;
			object obj19 = !flag4;
			object obj21 = default(object);
			object obj20 = obj21;
			object obj23 = default(object);
			object obj22 = obj23;
			object obj25 = default(object);
			object obj24 = obj25;
			bool flag6 = default(bool);
			bool flag5 = flag6;
			int num4 = num3;
			int num5 = num2;
			int num6 = num;
			bool flag7 = flag;
			object obj26 = obj5;
			object obj28 = default(object);
			object obj27 = obj28;
			object obj29 = obj14;
			object obj30 = obj16;
			object obj31 = obj18;
			object obj32 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RemoteAssetsCacher+<Retry>d__10`1<T>)+48]");
			object obj33 = 0;
			if (obj19 == null)
			{
				goto IL_0208;
			}
			goto IL_05d6;
			IL_0df8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1950");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v784 @ X0_v16+8] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			object obj34 = (nint)0 + (nint)72;
			object obj35 = default(object);
			obj34 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X19_v6+48]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X19_v6+48]");
			bool flag8 = (nint)0 == 0;
			object obj37 = default(object);
			obj25 = obj37;
			num3 = num4;
			num2 = num5;
			num = num6;
			flag = flag7;
			obj5 = obj26;
			obj20 = obj21;
			obj22 = obj23;
			obj24 = obj37;
			flag5 = flag6;
			obj27 = obj28;
			obj29 = obj14;
			obj30 = obj16;
			obj31 = obj18;
			obj32 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X19_v6+48]");
			obj33 = 0;
			if (flag8)
			{
				goto IL_0208;
			}
			goto IL_05d6;
			IL_057d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0df8;
			IL_0a75:
			throw new NullReferenceException();
			IL_05d6:
			object obj38 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v39+12E]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v39+12E]");
			if ((nint)0 == 0)
			{
				goto IL_06d3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v39+B0]");
			object obj39 = (nint)0 + (nint)8;
			bool flag9 = flag5;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X10_v29-8]");
				obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X10_v29-8]");
				obj26 = 0 - obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X10_v29-8]");
				flag7 = 0 == (nint)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X10_v29-8]");
				num6 = 0 ^ obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X10_v29-8]");
				num5 = 0 ^ obj26;
				num4 = num6 & num5;
				if (flag7)
				{
					break;
				}
				obj27 = obj39 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v39+12E]");
				obj13 = -1;
				obj26 = obj13 - 1;
				flag7 = obj26 == null;
				num6 = obj13 ^ 1;
				num5 = obj13 ^ obj26;
				num4 = num6 & num5;
				flag5 = (nint)obj13 != 1;
				flag9 = flag5;
				obj39 = obj27;
				if (flag5)
				{
					continue;
				}
				goto IL_06d3;
			}
			obj13 = obj39;
			object obj40 = obj38 + obj39;
			object obj41 = obj40 + 312;
			flag5 = flag9;
			obj27 = obj39;
			goto IL_0fd7;
			IL_107d:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v649 @ X0_v50] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			object obj42 = (nint)0 + (nint)24;
			object obj43 = default(object);
			obj42 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			object obj44 = 0;
			_ = 1;
			return true;
			IL_0208:
			throw new NullReferenceException();
			IL_06d3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj24 = 0;
			goto IL_0fd7;
			IL_0942:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj24 = 1;
			goto IL_107d;
			IL_0bad:
			object obj45;
			object obj53 = default(object);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
				List<object>.Enumerator enumerator2 = (List<object>.Enumerator)((nint)0 + (nint)48);
				bool flag10 = ((List<object>.Enumerator*)enumerator2)->MoveNext();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
				obj45 = 0;
				if (flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X20_v11+20]");
					object obj46 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X20_v11+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X20_v11+40]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v14+39]");
						object obj47 = (nint)0 & (nint)1;
						if (obj47 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X20_v11+40]");
						if ((nint)0 != 0)
						{
							object obj48 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v25+12E]");
							obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v25+12E]");
							if ((nint)0 == 0)
							{
								goto IL_03be;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v25+B0]");
							object obj49 = (nint)0 + (nint)8;
							bool flag11 = flag6;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X10_v13-8]");
								obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X10_v13-8]");
								obj5 = 0 - obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X10_v13-8]");
								flag = 0 == (nint)obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X10_v13-8]");
								num = 0 ^ obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X10_v13-8]");
								num2 = 0 ^ obj5;
								num3 = num & num2;
								if (flag)
								{
									break;
								}
								obj28 = obj49 + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v25+12E]");
								obj13 = -1;
								obj5 = obj13 - 1;
								flag = obj5 == null;
								num = obj13 ^ 1;
								num2 = obj13 ^ obj5;
								num3 = num & num2;
								flag6 = (nint)obj13 != 1;
								flag11 = flag6;
								obj49 = obj28;
								if (flag6)
								{
									continue;
								}
								goto IL_03be;
							}
							obj13 = obj49;
							object obj50 = obj48 + obj49;
							object obj51 = obj50 + 312;
							flag6 = flag11;
							obj28 = obj49;
							goto IL_0d35;
						}
						throw new NullReferenceException();
					}
					throw new NullReferenceException();
				}
				_ = 4294967295L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
				List<object>.Enumerator enumerator3 = (List<object>.Enumerator)((nint)0 + (nint)48);
				((List<object>.Enumerator*)enumerator3)->Dispose();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
				object obj52 = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				return false;
				IL_0d35:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v749 @ X0_v26] (should have been resolved before IL gen)");
				if (obj53 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
					obj45 = 0;
					break;
				}
				continue;
				IL_03be:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj25 = 0;
				goto IL_0d35;
			}
			object obj54 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X20_v11+28]");
			obj26 = obj54 - 0;
			object obj55 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X20_v11+28]");
			flag7 = obj55 == null;
			object obj56 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X20_v11+28]");
			num6 = obj56 ^ 0;
			num5 = obj7 ^ obj26;
			num4 = num6 & num5;
			obj20 = obj21;
			obj22 = obj23;
			obj24 = obj25;
			flag5 = flag6;
			obj27 = obj28;
			obj29 = obj14;
			obj30 = obj16;
			obj31 = obj18;
			obj32 = obj17;
			if (!flag7)
			{
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-40]");
					object obj57 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v18+20]");
					object obj58 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v19+C0]");
					object obj59 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v20+20]");
					obj23 = 0;
					object obj60 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v21+12E]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v21+12E]");
					if ((nint)0 == 0)
					{
						goto IL_057d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v21+B0]");
					object obj61 = (nint)0 + (nint)8;
					bool flag12 = flag6;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X10_v7-8]");
						obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X10_v7-8]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X21_v1+20]");
						obj26 = num7 - 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X10_v7-8]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X21_v1+20]");
						flag7 = num8 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X10_v7-8]");
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X21_v1+20]");
						num6 = (int)(num9 ^ 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X10_v7-8]");
						num5 = 0 ^ obj26;
						num4 = num6 & num5;
						if (flag7)
						{
							break;
						}
						obj28 = obj61 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v21+12E]");
						obj13 = -1;
						obj26 = obj13 - 1;
						flag7 = obj26 == null;
						num6 = obj13 ^ 1;
						num5 = obj13 ^ obj26;
						num4 = num6 & num5;
						flag6 = (nint)obj13 != 1;
						flag12 = flag6;
						obj61 = obj28;
						if (flag6)
						{
							continue;
						}
						goto IL_057d;
					}
					object obj62 = obj61;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X21_v1+50]");
					obj13 = obj62 + 0;
					object obj63 = obj60 + obj13;
					object obj64 = obj63 + 312;
					flag6 = flag12;
					obj28 = obj61;
					goto IL_0df8;
				}
				throw new NullReferenceException();
			}
			goto IL_1027;
			IL_0fd7:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v518 @ X0_v47] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			object obj65 = 0;
			object obj67 = default(object);
			object obj66 = obj67 & 1;
			bool flag13 = obj66 == null;
			object obj68 = !flag13;
			if (obj68 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v42+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-40]");
					object obj69 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v48+20]");
					object obj70 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v49+C0]");
					object obj71 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3C7A23C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
					obj45 = 0;
					object obj73 = default(object);
					object obj72 = obj73 & 1;
					bool flag14 = obj72 == null;
					object obj74 = !flag14;
					if (obj74 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
						object obj75 = (nint)0 + (nint)72;
						obj75 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj21 = obj20;
						obj23 = obj22;
						obj25 = obj24;
						flag6 = flag5;
						num3 = num4;
						num2 = num5;
						num = num6;
						flag = flag7;
						obj5 = obj26;
						obj28 = obj27;
						obj14 = obj29;
						obj16 = obj30;
						obj18 = obj31;
						obj17 = obj32;
						obj7 = obj33;
						goto IL_0bad;
					}
					goto IL_1027;
				}
				throw new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v42+48]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v42+48]");
			if ((nint)0 == 0)
			{
				goto IL_0a75;
			}
			object obj76 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v43+12E]");
			object obj77 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v43+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0942;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v43+B0]");
			object obj78 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X10_v24-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				obj78 += 16;
				obj77--;
				if ((nint)obj77 != 1)
				{
					continue;
				}
				goto IL_0942;
			}
			object obj79 = obj78 + 1;
			object obj80 = obj76 + obj79;
			object obj81 = obj80 + 312;
			goto IL_107d;
			IL_1027:
			_ = 4294967295L;
			object obj82 = (nint)0 + (nint)1280;
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)(obj45 + 48);
			((List<object>.Enumerator*)enumerator4)->Dispose();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DF0E84");
			OutOfMemoryException ex = new OutOfMemoryException();
			obj7 = 0;
			goto IL_0a75;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private unsafe void <>m__Finally1()
		{
			//IL_0015: Expected I4, but got I8
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			<>1__state = -1;
			List<object>.Enumerator enumerator = (List<object>.Enumerator)(this + 48);
			((List<object>.Enumerator*)enumerator)->Dispose();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}
	}

	private const int MaxNumberOfActiveRequests = 10;

	private static readonly List<AssetRequest> RequestsQueue;

	private static readonly List<IAssetLoader> AssetLoaders;

	private static readonly MethodInfo GenericLoadAssetCoroutineMethod;

	static RemoteAssetsCacher()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_00be: Expected O, but got I
		//IL_00e0: Expected O, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013e: Expected O, but got I
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0186: Expected O, but got I
		//IL_01b5: Expected I, but got O
		//IL_01e4: Expected O, but got I4
		object obj = typeof(List<Tween>) + 1184;
		object obj2 = typeof(RegisteredWaitHandle) + 40;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 1360;
		object handle = typeof(IAsyncEnumerable<>) + 3144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = obj2;
		object obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v4+B8]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v6+E0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
		object name = "LAK" + 2000;
		object obj11 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1848;
		object obj12 = (nint)0 + (nint)2968;
		object obj13 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		MethodInfo method = typeFromHandle.GetMethod((string)name, (BindingFlags)40);
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v10+B8]");
		object obj15 = (nint)0 + (nint)16;
		obj15 = method;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Application.LowMemoryCallback lowMemoryCallback = default(Application.LowMemoryCallback);
		lowMemoryCallback..ctor(null, (IntPtr)obj12);
		object obj16 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v22+E4]");
		bool flag2 = (nint)0 == 0;
		object obj17 = !flag2;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.lowMemory += lowMemoryCallback;
		InitializeAssetLoaders();
	}

	private static void InitializeAssetLoaders()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_00c7: Expected O, but got I4
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0177: Expected O, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_0142: Expected O, but got I
		//IL_0152: Expected O, but got I
		//IL_021c: Expected O, but got I
		//IL_022c: Expected O, but got I
		//IL_0250: Expected O, but got I
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02be: Expected O, but got I4
		//IL_033b: Expected O, but got I
		//IL_034b: Expected O, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_03fb: Expected O, but got I4
		//IL_0478: Expected O, but got I
		//IL_0488: Expected O, but got I
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_051d: Expected O, but got I4
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(RegisteredWaitHandle) + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70D0]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v61+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v61+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v32+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v27+8]");
		List<object> list = (List<object>)0;
		goto IL_0157;
		IL_0157:
		object obj9 = typeof(List<AdaptivePerformanceScaler>) + 1360;
		object obj10 = (nint)0 + (nint)3448;
		object obj11 = typeof(System.IOAsyncCallback) + 2560;
		int size = list._size;
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		if (list._size >= 1)
		{
			Array.Clear(list._items, 0, list._size);
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v24+B8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v25+8]");
			list = (List<object>)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InMemoryCacheAssetLoader inMemoryCacheAssetLoader = default(InMemoryCacheAssetLoader);
		inMemoryCacheAssetLoader..ctor();
		object obj14 = (nint)0 + (nint)3456;
		object obj15 = obj14;
		int version2 = list2._version + 1;
		list2._version = version2;
		object[] items = list2._items;
		object obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2592;
		bool flag3 = list2._size < items.Length;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			int size2 = list2._size + 1;
			list2._size = size2;
			object obj18 = items + list2._size;
			object obj19 = obj18 + 32;
			obj19 = inMemoryCacheAssetLoader;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj20 = inMemoryCacheAssetLoader;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v7+20]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v21+C0]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v22+70]");
			size = 0;
			list2.AddWithResize((object)inMemoryCacheAssetLoader);
			object obj20 = inMemoryCacheAssetLoader;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = default(object);
		obj23..ctor();
		object obj24 = obj14;
		int version3 = list2._version + 1;
		list2._version = version3;
		object[] items2 = list2._items;
		object obj25 = typeof(RegisteredWaitHandle) + 96;
		bool flag4 = list2._size < items2.Length;
		object obj26 = !flag4;
		if (obj26 == null)
		{
			int size3 = list2._size + 1;
			list2._size = size3;
			object obj27 = items2 + list2._size;
			object obj28 = obj27 + 32;
			obj28 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj29 = obj23;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v9+20]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v18+C0]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v19+70]");
			size = 0;
			list2.AddWithResize(obj23);
			object obj29 = obj23;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj32 = default(object);
		obj32..ctor();
		int version4 = list2._version + 1;
		list2._version = version4;
		object[] items3 = list2._items;
		bool flag5 = list2._size < items3.Length;
		object obj33 = !flag5;
		if (obj33 == null)
		{
			int size4 = list2._size + 1;
			list2._size = size4;
			object obj34 = items3 + list2._size;
			object obj35 = obj34 + 32;
			obj35 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list2.AddWithResize(obj32);
		}
		list.AddRange(list2);
		return;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v61+B8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v31+8]");
		list = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v31+8]");
		bool flag6 = (nint)0 == 0;
		object obj37 = !flag6;
		if (obj37 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0157;
	}

	private static string GetLocalAssetPath(string imageID)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string cachePath = Config.CachePath;
		return cachePath + imageID;
	}

	public static void LoadAsset<T>(string assetId, string url, UnityEngine.Object lifecycle, Action<T> callback, bool storeLocally = true, DateTime? timeStamp = null) where T : class
	{
		//IL_0010: Expected O, but got I
		//IL_0032: Expected O, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I4
		//IL_00f2: Expected O, but got I
		//IL_0050: Expected O, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0217: Expected O, but got I
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0184: Expected O, but got I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01f2: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X7+38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X7+38]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		object obj4;
		object obj7;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X7+38]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X7+38]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X7+38]");
				object obj3 = 0;
				obj4 = obj3;
				object obj5 = obj3 + 309;
				object obj6 = obj5 & 1;
				if (obj6 == null)
				{
					goto IL_00c9;
				}
				obj7 = obj3;
				goto IL_00d8;
			}
		}
		obj4 = obj;
		object obj8 = obj + 309;
		object obj9 = obj8 & 1;
		bool flag2 = obj9 == null;
		object obj10 = !flag2;
		obj7 = obj;
		if (obj10 == null)
		{
			goto IL_00c9;
		}
		goto IL_00d8;
		IL_00d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X7+38]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3C7A24C");
		object obj13 = default(object);
		object obj12 = obj13 + 16;
		obj12 = assetId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = obj13 + 24;
		obj14 = url;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj15 = typeof(RegisteredWaitHandle) + 40;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string localAssetPath = GetLocalAssetPath(assetId);
		object obj18 = obj13 + 32;
		obj18 = localAssetPath;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X7+38]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEF544");
		return;
		IL_00c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_00d8;
	}

	public static void LoadLocalOnlyAsset<T>(string assetId, string url, UnityEngine.Object lifecycle, Action<T> callback, DateTime? timeStamp = null) where T : class
	{
		//IL_0010: Expected O, but got I
		//IL_0032: Expected O, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I4
		//IL_00f2: Expected O, but got I
		//IL_0050: Expected O, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0218: Expected O, but got I
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0184: Expected O, but got I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X6+38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X6+38]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		object obj4;
		object obj7;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X6+38]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X6+38]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X6+38]");
				object obj3 = 0;
				obj4 = obj3;
				object obj5 = obj3 + 309;
				object obj6 = obj5 & 1;
				if (obj6 == null)
				{
					goto IL_00c9;
				}
				obj7 = obj3;
				goto IL_00d8;
			}
		}
		obj4 = obj;
		object obj8 = obj + 309;
		object obj9 = obj8 & 1;
		bool flag2 = obj9 == null;
		object obj10 = !flag2;
		obj7 = obj;
		if (obj10 == null)
		{
			goto IL_00c9;
		}
		goto IL_00d8;
		IL_00d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X6+38]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3C7A24C");
		object obj13 = default(object);
		object obj12 = obj13 + 16;
		obj12 = assetId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = obj13 + 24;
		obj14 = url;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj15 = typeof(RegisteredWaitHandle) + 40;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string localAssetPath = GetLocalAssetPath(assetId);
		object obj18 = obj13 + 32;
		obj18 = localAssetPath;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X6+38]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEF544");
		return;
		IL_00c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_00d8;
	}

	public static void DeleteAsset(string assetId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0322: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_035a: Expected O, but got I
		//IL_036a: Expected O, but got I
		//IL_038c: Expected O, but got I4
		//IL_00d7: Expected O, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_016d: Expected O, but got I4
		//IL_0400: Expected I, but got O
		//IL_04b4: Expected O, but got I4
		//IL_01e2: Expected O, but got I4
		//IL_01ea: Expected I, but got O
		//IL_0210: Expected O, but got I
		//IL_024b: Expected O, but got I
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(RegisteredWaitHandle) + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7215]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v63+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v63+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v18+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+8]");
		List<object> list = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_00ca;
		}
		goto IL_039a;
		IL_03a8:
		NullReferenceException ex = new NullReferenceException();
		nint num = default(nint);
		bool flag4 = num != 1;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		object obj10 = default(object);
		List<object>.Enumerator enumerator = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj10;
			enumerator.Dispose();
			object obj11 = default(object);
			if (obj11 == null)
			{
				return;
			}
			ex2 = new OutOfMemoryException();
			enumerator2 = (List<object>.Enumerator)obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2239950");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00ca:
		object obj12 = (nint)0 + (nint)1288;
		object obj13 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1000;
		obj10 = (nint)0 + (nint)1280;
		List<object>.Enumerator enumerator3 = list.GetEnumerator();
		object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		object obj19 = default(object);
		while (true)
		{
			string text;
			string text2;
			if (enumerator4.MoveNext())
			{
				object obj15 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v46+E4]");
				bool flag5 = (nint)0 == 0;
				object obj16 = !flag5;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj17 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v50+E4]");
				bool flag6 = (nint)0 == 0;
				object obj18 = !flag6;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string cachePath = Config.CachePath;
				text = cachePath + assetId;
				bool flag7 = obj19 == null;
				text2 = null;
				enumerator = enumerator2;
				enumerator2 = (List<object>.Enumerator)0;
				num = (nint)assetId;
				if (flag7)
				{
					break;
				}
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v19+12E]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v19+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v19+B0]");
					object obj22 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X10_v8-8]");
						object obj23 = 0 - obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X10_v8-8]");
						if (0 == (nint)obj13)
						{
							break;
						}
						obj22 += 16;
						obj21--;
						obj23 = obj21 - 1;
						bool flag8 = obj23 == null;
						if ((nint)obj21 != 1)
						{
							continue;
						}
						goto IL_011d;
					}
					object obj24 = obj22 + 3;
					object obj25 = obj20 + obj24;
					object obj26 = obj25 + 312;
					goto IL_012c;
				}
				goto IL_011d;
			}
			enumerator4.Dispose();
			return;
			IL_011d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_012c;
			IL_012c:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v404 @ X0_v54] (should have been resolved before IL gen)");
			text2 = text;
		}
		goto IL_03a8;
		IL_039a:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_03a8;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v63+B8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v24+8]");
		list = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v24+8]");
		if ((nint)0 != 0)
		{
			goto IL_00ca;
		}
		goto IL_039a;
	}

	private static IEnumerator LoadAssetCoroutine<T>(AssetRequest<T> request) where T : class
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00bf: Expected I4, but got O
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IEnumerator enumerator = default(IEnumerator);
		((<LoadAssetCoroutine>d__9<T>)enumerator)..ctor(0);
		if (enumerator != null)
		{
			<LoadAssetCoroutine>d__9<T> <LoadAssetCoroutine>d__ = (<LoadAssetCoroutine>d__9<T>)(enumerator + 32);
			<LoadAssetCoroutine>d__ = (<LoadAssetCoroutine>d__9<T>)(object)request;
			<LoadAssetCoroutine>d__..ctor((int)request);
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public static IEnumerator Retry<T>(AssetLoadingModel<T> asset, IAssetLoader breakAt) where T : class
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00bf: Expected I4, but got O
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00e2: Expected I4, but got O
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IEnumerator enumerator = default(IEnumerator);
		((<Retry>d__10<T>)enumerator)..ctor(0);
		if (enumerator != null)
		{
			<Retry>d__10<T> <Retry>d__ = (<Retry>d__10<T>)(enumerator + 32);
			<Retry>d__ = (<Retry>d__10<T>)(object)asset;
			<Retry>d__..ctor((int)asset);
			<Retry>d__10<T> <Retry>d__2 = (<Retry>d__10<T>)(enumerator + 40);
			<Retry>d__2 = (<Retry>d__10<T>)(object)breakAt;
			<Retry>d__2..ctor((int)breakAt);
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private unsafe static void NotifyAssetResult<T>(AssetRequest<T> assetRequest) where T : class
	{
		//IL_0008: Expected O, but got Ref
		//IL_0480: Expected O, but got I
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_04a8: Expected O, but got I4
		//IL_006f: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_007e: Expected O, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I4
		//IL_04d7: Expected O, but got I
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		//IL_0532: Expected O, but got I4
		//IL_053b: Expected O, but got I4
		//IL_0544: Expected O, but got I4
		//IL_0123: Expected O, but got I
		//IL_012b: Expected I, but got O
		//IL_0166: Expected O, but got I4
		//IL_016f: Expected O, but got I4
		//IL_0178: Expected O, but got I4
		//IL_01b8: Expected O, but got I4
		//IL_01c1: Expected O, but got I4
		//IL_01ca: Expected O, but got I4
		//IL_01f1: Expected O, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_021d: Expected O, but got I4
		//IL_0226: Expected O, but got I4
		//IL_022f: Expected O, but got I4
		//IL_039a: Expected O, but got I4
		//IL_03a3: Expected O, but got I4
		//IL_05d7: Expected O, but got I
		//IL_05e7: Expected O, but got I
		//IL_05f7: Expected O, but got I
		//IL_061a: Expected O, but got I4
		//IL_0245: Expected O, but got I
		//IL_0255: Expected O, but got I
		//IL_0265: Expected O, but got I
		//IL_027e: Expected I, but got O
		//IL_02a0: Expected O, but got I4
		//IL_057c: Expected O, but got I4
		//IL_0585: Expected O, but got I4
		//IL_03cf: Expected O, but got I4
		//IL_03d8: Expected O, but got I4
		//IL_03e2: Expected O, but got I4
		//IL_033a: Expected O, but got I
		//IL_0382: Expected O, but got I4
		//IL_038b: Expected O, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3 & 1;
		bool flag = obj4 == null;
		object obj5 = !flag;
		nint num = 0;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = default(object);
		((<>c__DisplayClass11_0<T>)obj6)..ctor();
		bool flag2 = obj6 == null;
		object value = null;
		object obj7 = null;
		KeyValuePair<object, object> keyValuePair = (KeyValuePair<object, object>)0;
		Dictionary<object, object>.Enumerator enumerator = (Dictionary<object, object>.Enumerator)0;
		object obj8 = 0;
		AssetRequest<T> assetRequest2 = assetRequest;
		if (!flag2)
		{
			object obj9 = obj6 + 16;
			obj9 = assetRequest;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj10 = typeof(RegisteredWaitHandle) + 40;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v22+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v22+B8]");
			object obj13 = 0;
			assetRequest2 = (AssetRequest<T>)obj13;
			object obj14 = typeof(List<Tween>) + 3744;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor(obj6, (IntPtr)(nint)__ldftn(<>c__DisplayClass11_0<T>.<NotifyAssetResult>b__0));
			bool flag4 = obj13 == null;
			value = null;
			obj7 = null;
			keyValuePair = (KeyValuePair<object, object>)0;
			enumerator = (Dictionary<object, object>.Enumerator)0;
			object obj15 = 0;
			nint num2 = (nint)__ldftn(<>c__DisplayClass11_0<T>.<NotifyAssetResult>b__0);
			obj8 = obj6;
			if (!flag4)
			{
				object obj16 = (nint)0 + (nint)3848;
				num2 = (nint)obj16;
				int num3 = ((List<object>)obj13).RemoveAll(predicate);
				object obj17 = obj9;
				bool flag5 = obj9 == null;
				value = null;
				obj7 = null;
				keyValuePair = (KeyValuePair<object, object>)0;
				enumerator = (Dictionary<object, object>.Enumerator)0;
				obj15 = 0;
				obj8 = predicate;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v18+20]");
					bool flag6 = (nint)0 == 0;
					value = null;
					obj7 = null;
					keyValuePair = (KeyValuePair<object, object>)0;
					enumerator = (Dictionary<object, object>.Enumerator)0;
					obj15 = 0;
					obj8 = predicate;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v18+20]");
						Dictionary<object, object>.Enumerator enumerator2 = ((Dictionary<object, object>)0).GetEnumerator();
						assetRequest2 = (AssetRequest<T>)(typeof(MemberAchievementClanFeedData) + 2976);
						value = null;
						obj7 = null;
						keyValuePair = (KeyValuePair<object, object>)0;
						enumerator = (Dictionary<object, object>.Enumerator)0;
						obj15 = 0;
						Dictionary<object, object>.Enumerator enumerator3 = default(Dictionary<object, object>.Enumerator);
						object obj28 = default(object);
						object obj23;
						while (true)
						{
							if (enumerator3.MoveNext())
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
								object obj18 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v25+38]");
								object obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v26+58]");
								obj15 = 0;
								keyValuePair.Deconstruct(out obj7, out value);
								nint num4 = (nint)assetRequest2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v33 (Il2CppClass<RemoteAssetsCacher+AssetRequest`1<T>>)+E4]");
								bool flag7 = (nint)0 == 0;
								object obj20 = !flag7;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag8 = (UnityEngine.Object)obj7;
								bool flag9 = value != null && flag8;
								bool flag10 = !flag9;
								keyValuePair = (KeyValuePair<object, object>)0;
								enumerator = (Dictionary<object, object>.Enumerator)0;
								num2 = (nint)(&value);
								if (!flag10)
								{
									object obj21 = obj9;
									if (obj9 == null)
									{
										NullReferenceException ex = new NullReferenceException();
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v29+18]");
									object obj22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v29+18]");
									if ((nint)0 == 0)
									{
										NullReferenceException ex2 = new NullReferenceException();
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ stack_-90_v3 (System.Object)+28]");
									num2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ stack_-90_v3 (System.Object)+18] (should have been resolved before IL gen)");
									keyValuePair = (KeyValuePair<object, object>)0;
									enumerator = (Dictionary<object, object>.Enumerator)0;
								}
								continue;
							}
							obj23 = 0;
							object obj24 = 0;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
								object obj25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v7+38]");
								object obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v8+A8]");
								obj8 = 0;
								enumerator3.Dispose();
								bool flag11 = obj24 == null;
								object obj27 = !flag11;
								if (obj27 == null)
								{
									return;
								}
								OutOfMemoryException ex3 = new OutOfMemoryException();
								if ((nint)obj8 != 1)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
								obj24 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
								obj23 = obj28;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CBCC5C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
							return;
						}
						keyValuePair = (KeyValuePair<object, object>)0;
						enumerator = (Dictionary<object, object>.Enumerator)0;
						obj23 = 0;
						num2 = (nint)(&value);
						obj8 = null;
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private static void CacheAsset<T>(AssetLoadingModel<T> asset) where T : class
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_02c8: Expected O, but got I
		//IL_008e: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_034a: Expected I, but got O
		//IL_0250: Expected O, but got I
		//IL_0258: Expected I, but got O
		//IL_00ac: Expected O, but got I4
		//IL_01fe: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 40;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+8]");
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+8]");
			List<object>.Enumerator enumerator = ((List<object>)0).GetEnumerator();
			object obj5 = (nint)0 + (nint)1288;
			num = (nint)obj5;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			object obj6 = 0;
			NullReferenceException ex = new NullReferenceException();
			object obj7 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj8 = (nint)0 + (nint)1280;
			num = (nint)obj8;
			enumerator2.Dispose();
			object obj9 = default(object);
			if (obj9 == null)
			{
				return;
			}
			ex3 = new OutOfMemoryException();
			object obj7 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CBCC1C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private static void OnLowMemory()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1752;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		AsyncOperation asyncOperation = Resources.UnloadUnusedAssets();
		Prefs.Save();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long totalMemory = GC.GetTotalMemory(forceFullCollection: false);
		ITrackEvent trackEvent = TrackerLibrary.DevLowMemory(totalMemory);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public static void ResetEnvironment()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_02a3: Expected O, but got I4
		//IL_02ac: Expected O, but got I4
		//IL_02b5: Expected O, but got I4
		//IL_02c6: Expected O, but got I4
		//IL_02cf: Expected O, but got I4
		//IL_00b9: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_0078: Expected O, but got I4
		//IL_0081: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_0361: Expected O, but got I4
		//IL_02ff: Expected O, but got I
		//IL_030f: Expected O, but got I
		//IL_0331: Expected O, but got I4
		//IL_00fb: Expected O, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_011b: Expected O, but got I
		//IL_0163: Expected O, but got I4
		//IL_0191: Expected O, but got I
		//IL_01cc: Expected O, but got I
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(RegisteredWaitHandle) + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70D2]");
		object obj3 = (nint)0 & (nint)1;
		object obj5;
		object obj7;
		List<object>.Enumerator enumerator;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v53+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			enumerator = (List<object>.Enumerator)0;
			object obj6 = obj4;
			obj7 = 0;
			enumerator = (List<object>.Enumerator)0;
			if (!flag)
			{
				goto IL_00a9;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v53+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj5 = 0;
			enumerator = (List<object>.Enumerator)0;
			object obj6 = obj4;
			obj7 = 0;
			enumerator = (List<object>.Enumerator)0;
			if (obj8 != null)
			{
				goto IL_00a9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v19+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5+8]");
		List<object> list = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5+8]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		obj5 = obj7;
		if (obj11 != null)
		{
			goto IL_00ee;
		}
		goto IL_0347;
		IL_0366:
		NullReferenceException ex = new NullReferenceException();
		object obj12 = default(object);
		bool flag4 = (nint)obj12 != 1;
		NullReferenceException ex2 = ex;
		object obj13;
		List<object>.Enumerator enumerator2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj12 = obj13;
			enumerator2.Dispose();
			object obj14 = default(object);
			if (obj14 == null)
			{
				return;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			object obj15 = obj14;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2239950");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00ee:
		object obj16 = (nint)0 + (nint)1288;
		object obj17 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1000;
		obj13 = (nint)0 + (nint)1280;
		List<object>.Enumerator enumerator3 = list.GetEnumerator();
		while (true)
		{
			obj12 = obj16;
			if (enumerator.MoveNext())
			{
				bool flag5 = obj5 == null;
				object obj15 = 0;
				enumerator2 = enumerator;
				if (flag5)
				{
					break;
				}
				object obj18 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v14+12E]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v14+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v14+B0]");
					object obj20 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X10_v8-8]");
						object obj21 = 0 - obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X10_v8-8]");
						if (0 == (nint)obj17)
						{
							break;
						}
						obj20 += 16;
						obj19--;
						obj21 = obj19 - 1;
						bool flag6 = obj21 == null;
						if ((nint)obj19 != 1)
						{
							continue;
						}
						goto IL_012d;
					}
					object obj22 = obj20 + 4;
					object obj23 = obj18 + obj22;
					object obj24 = obj23 + 312;
					goto IL_013c;
				}
				goto IL_012d;
			}
			enumerator.Dispose();
			return;
			IL_012d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_013c;
			IL_013c:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v345 @ X0_v48] (should have been resolved before IL gen)");
		}
		goto IL_0366;
		IL_0347:
		NullReferenceException ex4 = new NullReferenceException();
		enumerator2 = enumerator;
		obj13 = 152989696;
		goto IL_0366;
		IL_00a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v53+B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v19+8]");
		list = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v19+8]");
		if ((nint)0 != 0)
		{
			goto IL_00ee;
		}
		goto IL_0347;
	}

	public static void TryFreeUserStorage()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_0212: Expected O, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02e0: Expected O, but got I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0264: Expected O, but got I
		//IL_027e: Expected O, but got I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0195: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(RegisteredWaitHandle) + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7216]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = "alignContent" + 3448;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "alignContent" + 3448;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string text = (string)obj6;
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7214]");
		object obj9 = (nint)0 & (nint)1;
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		object obj11 = obj8;
		string text2 = (string)obj6;
		if (obj10 != null)
		{
			goto IL_00f3;
		}
		goto IL_029c;
		IL_014c:
		string cachePath = Config.CachePath;
		string path = cachePath + text;
		object obj13;
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v23+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long maxSize = FileUtils.MegabytesToBytes(10);
		FileUtils.CleanFolder(path, maxSize);
		return;
		IL_0306:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		text = text2;
		object obj15;
		obj13 = obj15;
		goto IL_014c;
		IL_00f3:
		obj13 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		object obj16 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = obj16;
		text2 = text;
		obj15 = obj13;
		if (!flag5)
		{
			goto IL_014c;
		}
		goto IL_0306;
		IL_0094:
		text = (string)obj4;
		obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7214]");
		object obj18 = (nint)0 & (nint)1;
		bool flag6 = obj18 == null;
		obj11 = obj8;
		text2 = (string)obj4;
		if (!flag6)
		{
			goto IL_00f3;
		}
		goto IL_029c;
		IL_029c:
		_ = 1;
		obj13 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		obj16 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v20+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		text = text2;
		obj17 = obj16;
		obj15 = obj13;
		if (obj19 != null)
		{
			goto IL_014c;
		}
		goto IL_0306;
	}

	private unsafe static void QueueLoadOperation<T>(AssetLoadingModel<T> asset, UnityEngine.Object lifecycle, Action<T> callback) where T : class
	{
		//IL_0016: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003e: Expected O, but got I4
		//IL_0087: Expected O, but got I
		//IL_0087: Expected O, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I4
		//IL_006d: Expected O, but got I
		//IL_006d: Expected O, but got I
		//IL_013c: Expected O, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0163: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_0187: Expected O, but got I
		//IL_0251: Expected O, but got I
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0279: Expected O, but got I4
		//IL_02b0: Expected O, but got I
		//IL_02b0: Expected O, but got I
		//IL_01f2: Expected O, but got I
		//IL_021c: Expected O, but got I4
		//IL_02f4: Expected O, but got I4
		//IL_029b: Expected O, but got I
		//IL_029b: Expected O, but got I
		//IL_0552: Expected O, but got I
		//IL_0230: Expected O, but got I
		//IL_0325: Expected O, but got I
		//IL_037f: Expected O, but got I4
		//IL_0455: Expected O, but got I
		//IL_0465: Expected O, but got I
		//IL_0475: Expected O, but got I
		//IL_04ac: Expected O, but got I4
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_0414: Expected O, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = default(IntPtr);
		if (obj3 == null)
		{
			((AssetRequest<T>)num)..ctor((AssetLoadingModel<T>)(object)lifecycle, (UnityEngine.Object)(object)callback, (Action<T>)(nint)intPtr);
		}
		((AssetRequest<T>)num2)..ctor((AssetLoadingModel<T>)(object)lifecycle, (UnityEngine.Object)(object)callback, (Action<T>)(nint)intPtr);
		object obj4 = default(object);
		((<>c__DisplayClass16_0<T>)obj4)..ctor();
		AssetRequest<T> assetRequest = (AssetRequest<T>)(obj4 + 16);
		assetRequest = (AssetRequest<T>)(object)asset;
		assetRequest..ctor(asset, (UnityEngine.Object)(object)callback, (Action<T>)(nint)intPtr);
		object obj5 = typeof(RegisteredWaitHandle) + 40;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CleanQueues<T>(lifecycle);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v7+B8]");
		object source = 0;
		object obj9 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 520;
		((AssetRequest<T>)obj9)..ctor((AssetLoadingModel<T>)0, (UnityEngine.Object)(object)callback, (Action<T>)(nint)intPtr);
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj4, (IntPtr)(nint)__ldftn(<>c__DisplayClass16_0<T>.<QueueLoadOperation>b__0));
		object lifecycle2 = (nint)0 + (nint)3936;
		IEnumerable<object> source2 = Enumerable.Where((IEnumerable<object>)source, func);
		IEnumerable<AssetRequest<T>> source3 = Enumerable.OfType<AssetRequest<T>>(source2);
		AssetRequest<T> assetRequest2 = Enumerable.SingleOrDefault(source3);
		if (assetRequest2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v15 (RemoteAssetsCacher+AssetRequest`1<T>)+20]");
			((Dictionary<object, object>)0).Add(lifecycle, callback);
			object obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v18+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Action<T> action = (Action<T>)0;
				object obj12 = callback;
				object obj13 = lifecycle;
				goto IL_04d0;
			}
		}
		else
		{
			object obj14 = (nint)0 + (nint)309;
			object obj15 = obj14 & 1;
			bool flag4 = obj15 == null;
			object obj16 = !flag4;
			nint num3 = 0;
			if (obj16 == null)
			{
				((AssetRequest<T>)0)..ctor((AssetLoadingModel<T>)0, (UnityEngine.Object)lifecycle2, (Action<T>)null);
			}
			((AssetRequest<T>)num3)..ctor((AssetLoadingModel<T>)0, (UnityEngine.Object)lifecycle2, (Action<T>)null);
			object obj17 = default(object);
			((AssetRequest<T>)obj17)..ctor((AssetLoadingModel<T>)(object)assetRequest, lifecycle, callback);
			object obj18 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v24+E4]");
			bool flag5 = (nint)0 == 0;
			object obj19 = !flag5;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj18 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v24+B8]");
			object obj20 = 0;
			List<object> list = (List<object>)obj20;
			object obj21 = (nint)0 + (nint)3840;
			object obj22 = obj21;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag6 = list._size < items.Length;
			object obj23 = !flag6;
			if (obj23 == null)
			{
				int size = list._size + 1;
				list._size = size;
				object obj24 = items + list._size;
				AssetRequest<T> assetRequest3 = (AssetRequest<T>)(obj24 + 32);
				assetRequest3 = (AssetRequest<T>)obj17;
				assetRequest3..ctor((AssetLoadingModel<T>)obj17, lifecycle, callback);
				object obj10 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v18+E4]");
				bool flag7 = (nint)0 == 0;
				object obj25 = !flag7;
				if (obj25 == null)
				{
					nint num4 = 0;
					Action<T> action = callback;
					object obj12 = lifecycle;
					object obj13 = obj17;
					goto IL_04d0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26+20]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v27+C0]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v28+70]");
				object obj12 = 0;
				list.AddWithResize(obj17);
				object obj10 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v18+E4]");
				bool flag8 = (nint)0 == 0;
				object obj28 = !flag8;
				nint num4 = 0;
				Action<T> action = callback;
				object obj13 = obj17;
				if (obj28 == null)
				{
					goto IL_04d0;
				}
			}
		}
		goto IL_04df;
		IL_04d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_04df;
		IL_04df:
		UpdateQueue();
	}

	private static void UpdateQueue()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_01ae: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c1: Expected I, but got O
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0258: Expected I, but got O
		//IL_027c: Expected O, but got I4
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected I, but got O
		//IL_0220: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_030b: Expected O, but got I
		//IL_02bc: Expected O, but got I4
		//IL_0439: Expected O, but got I
		//IL_0449: Expected I, but got O
		//IL_046b: Expected O, but got I4
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Expected O, but got Unknown
		//IL_0891: Expected O, but got I
		//IL_08a3: Expected I, but got O
		//IL_08ab: Expected I, but got O
		//IL_08c1: Expected O, but got I
		//IL_03aa: Expected O, but got I
		//IL_03ca: Expected O, but got I
		//IL_03ec: Expected O, but got I4
		//IL_0359: Expected O, but got I
		//IL_0369: Expected I, but got O
		//IL_02e2: Expected O, but got I4
		//IL_0552: Expected O, but got I
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_049b: Expected I, but got O
		//IL_04a7: Expected O, but got I
		//IL_04c7: Expected O, but got I
		//IL_04e9: Expected O, but got I4
		//IL_0994: Expected O, but got I4
		//IL_09e1: Expected O, but got I
		//IL_0529: Expected O, but got I4
		//IL_0611: Expected O, but got I4
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected I4, but got Unknown
		//IL_0674: Expected O, but got I4
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Expected O, but got Unknown
		//IL_0902: Expected O, but got I
		//IL_0914: Expected I, but got O
		//IL_091c: Expected I, but got O
		//IL_0932: Expected O, but got I
		//IL_0955: Expected O, but got I4
		//IL_0699: Expected O, but got I4
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected I4, but got Unknown
		//IL_071d: Expected O, but got I4
		//IL_079a: Expected O, but got I4
		//IL_07a2: Expected O, but got I4
		//IL_074d: Expected O, but got I
		//IL_07e0: Expected O, but got I4
		//IL_080e: Expected I, but got O
		//IL_0842: Expected O, but got I4
		//IL_05e3: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(RegisteredWaitHandle) + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70D3]");
		object obj3 = (nint)0 & (nint)1;
		CoroutineDummy coroutineDummy;
		CoroutineDummy coroutineDummy2;
		if (obj3 != null)
		{
			coroutineDummy = (CoroutineDummy)(typeof(RankedPlayManager.<>c__DisplayClass36_0) + 520);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v101+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			coroutineDummy2 = coroutineDummy;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			_ = 1;
			coroutineDummy = (CoroutineDummy)(typeof(RankedPlayManager.<>c__DisplayClass36_0) + 520);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v101+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			coroutineDummy2 = coroutineDummy;
			if (obj6 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v63+B8]");
		object obj8 = 0;
		List<object> list = (List<object>)obj8;
		nint num = (nint)coroutineDummy2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v58 (Il2CppClass<CoroutineDummy>)+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		nint num2 = num;
		coroutineDummy = coroutineDummy2;
		List<object> list2 = (List<object>)obj8;
		if (obj9 != null)
		{
			goto IL_0106;
		}
		goto IL_0246;
		IL_039e:
		object obj10 = (nint)0 + (nint)3656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v48 (Il2CppClass<CoroutineDummy>)+B8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v35 (Il2CppStaticFields<CoroutineDummy>)+18]");
		Func<object, bool> func = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v35 (Il2CppStaticFields<CoroutineDummy>)+18]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		object obj12;
		nint num5;
		IEnumerable<object> enumerable;
		IEnumerable<object> enumerable2;
		nint num4;
		if (obj11 == null)
		{
			obj12 = obj10;
			num4 = num5;
			enumerable = enumerable2;
			goto IL_0507;
		}
		goto IL_0546;
		IL_02ff:
		object obj13 = (nint)0 + (nint)3848;
		Predicate<object> match;
		int num6 = list.RemoveAll(match);
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v6+B8]");
			object obj15 = 0;
			enumerable2 = (IEnumerable<object>)obj15;
			num5 = (nint)coroutineDummy;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v48 (Il2CppClass<CoroutineDummy>)+E4]");
			bool flag5 = (nint)0 == 0;
			nint num7 = num5;
			enumerable = (IEnumerable<object>)obj15;
			if (!flag5)
			{
				goto IL_039e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v46+B8]");
			object obj17 = 0;
			enumerable2 = (IEnumerable<object>)obj17;
			nint num7 = (nint)coroutineDummy;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v42 (Il2CppClass<CoroutineDummy>)+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			num5 = num7;
			enumerable = (IEnumerable<object>)obj17;
			if (obj18 != null)
			{
				goto IL_039e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num4 = (nint)coroutineDummy;
		obj12 = (nint)0 + (nint)3656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v34 (Il2CppClass<CoroutineDummy>)+B8]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v31 (Il2CppStaticFields<CoroutineDummy>)+18]");
		func = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v31 (Il2CppStaticFields<CoroutineDummy>)+18]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		obj10 = obj12;
		enumerable2 = enumerable;
		if (obj19 == null)
		{
			goto IL_0507;
		}
		goto IL_0546;
		IL_013d:
		bool flag8 = list == null;
		object obj20 = !flag8;
		if (obj20 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_02ff;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v101+B8]");
		object obj21 = 0;
		list = (List<object>)obj21;
		nint num9 = (nint)coroutineDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v102 (Il2CppClass<CoroutineDummy>)+E4]");
		bool flag9 = (nint)0 == 0;
		num2 = num9;
		num = num9;
		coroutineDummy2 = coroutineDummy;
		list2 = (List<object>)obj21;
		if (!flag9)
		{
			goto IL_0106;
		}
		goto IL_0246;
		IL_0246:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num2 = (nint)coroutineDummy2;
		match = (Predicate<object>)(object)CoroutineDummy._permanentInstance;
		bool flag10 = (object)CoroutineDummy._permanentInstance == null;
		object obj22 = !flag10;
		coroutineDummy = coroutineDummy2;
		list = list2;
		if (obj22 != null)
		{
			goto IL_013d;
		}
		goto IL_029a;
		IL_0106:
		match = (Predicate<object>)(object)CoroutineDummy._permanentInstance;
		bool flag11 = (object)CoroutineDummy._permanentInstance == null;
		coroutineDummy2 = coroutineDummy;
		list2 = list;
		if (!flag11)
		{
			goto IL_013d;
		}
		goto IL_029a;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v50 (Il2CppClass<CoroutineDummy>)+E4]");
		bool flag12 = (nint)0 == 0;
		object obj23 = !flag12;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj24 = typeof(List<Tween>) + 3744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)3728;
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor((object)CoroutineDummy.mainThreadCallBacks, (IntPtr)obj25);
		nint num10 = (nint)coroutineDummy2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v44 (Il2CppClass<CoroutineDummy>)+B8]");
		object obj26 = (nint)0 + (nint)16;
		obj26 = predicate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj27 = 0;
		match = predicate;
		coroutineDummy = coroutineDummy2;
		list = list2;
		goto IL_02ff;
		IL_0546:
		object obj28 = (nint)0 + (nint)3864;
		object obj29 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj30 = obj10;
		int num11 = Enumerable.Count(enumerable2, func);
		Func<object, bool> func2 = func;
		int num12 = 0;
		int num13 = num11;
		Type assetType = default(Type);
		while (true)
		{
			object obj31 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v12+E4]");
			bool flag13 = (nint)0 == 0;
			object obj32 = !flag13;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj31 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v12+B8]");
			object obj33 = 0;
			List<object> list3 = (List<object>)obj33;
			object obj34 = num12 - list3._size;
			bool flag14 = (nint)obj34 < 0;
			int num14 = num12 ^ list3._size;
			int num15 = num12 ^ obj34;
			int num16 = num14 & num15;
			bool flag15 = num16 < 0;
			bool flag16 = flag14 == flag15;
			object obj35 = !flag16;
			object obj36 = ~obj35;
			bool flag17;
			bool flag18;
			if (obj36 == null)
			{
				object obj37 = num13 - 11;
				flag17 = (nint)obj37 < 0;
				int num17 = num13 ^ 0xB;
				int num18 = num13 ^ obj37;
				int num19 = num17 & num18;
				flag18 = num19 < 0;
			}
			else
			{
				flag18 = false;
				flag17 = false;
			}
			if (flag17 == flag18)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v12+E4]");
			bool flag19 = (nint)0 == 0;
			object obj38 = !flag19;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj39 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v18+B8]");
				object obj40 = 0;
				list3 = (List<object>)obj40;
			}
			obj30 = obj28;
			object obj41 = list3.get_Item(num12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v15 (System.Object)+10]");
			bool flag20 = (nint)0 == 0;
			object obj42 = !flag20;
			func2 = (Func<object, bool>)num12;
			if (obj42 == null)
			{
				_ = 1;
				object obj43 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v17+E4]");
				bool flag21 = (nint)0 == 0;
				object obj44 = !flag21;
				if (obj44 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CoroutineDummy instance = CoroutineDummy.Instance;
				nint num20 = (nint)obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v471 @ X8_v16 (Il2CppClass<System.Object>)+1A8] (should have been resolved before IL gen)");
				object obj45 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v17+E4]");
				bool flag22 = (nint)0 == 0;
				object obj46 = !flag22;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				IEnumerator enumerator = CallGenericLoadAssetCoroutine(assetType, (AssetRequest)obj41);
				Coroutine coroutine = instance.StartCoroutine(enumerator);
				num13++;
				func2 = (Func<object, bool>)(object)enumerator;
				obj30 = 0;
			}
			num12++;
		}
		return;
		IL_0507:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v34 (Il2CppClass<CoroutineDummy>)+E4]");
		bool flag23 = (nint)0 == 0;
		object obj47 = !flag23;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj48 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj49 = (nint)0 + (nint)3736;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor((object)CoroutineDummy.mainThreadCallBacks, (IntPtr)obj49);
		nint num21 = (nint)coroutineDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v27 (Il2CppClass<CoroutineDummy>)+B8]");
		object obj50 = (nint)0 + (nint)24;
		obj50 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj12;
		obj27 = 0;
		func = func3;
		enumerable2 = enumerable;
		goto IL_0546;
	}

	private unsafe static void CleanQueues<T>(UnityEngine.Object go) where T : class
	{
		//IL_0016: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003e: Expected O, but got I4
		//IL_007f: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_00a2: Expected O, but got I
		//IL_0069: Expected O, but got I
		//IL_0069: Expected O, but got I
		//IL_076b: Expected O, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_011d: Expected O, but got I4
		//IL_0507: Expected O, but got I
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected O, but got Unknown
		//IL_052f: Expected O, but got I4
		//IL_087e: Expected O, but got I
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected O, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected O, but got Unknown
		//IL_07b7: Expected O, but got I
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected O, but got Unknown
		//IL_015b: Expected O, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0183: Expected O, but got I4
		//IL_05f3: Expected O, but got I
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_061b: Expected O, but got I4
		//IL_057c: Expected O, but got I
		//IL_01b0: Expected O, but got I
		//IL_0667: Expected O, but got I
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected O, but got Unknown
		//IL_068f: Expected O, but got I4
		//IL_01f1: Expected O, but got I
		//IL_020b: Expected O, but got I
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_019e: Expected O, but got I
		//IL_01a2: Expected I, but got O
		//IL_06d0: Expected O, but got I
		//IL_06fd: Expected O, but got I4
		//IL_0712: Expected I, but got O
		//IL_0641: Expected O, but got I
		//IL_034a: Expected O, but got I
		//IL_036c: Expected O, but got I4
		//IL_06b5: Expected O, but got I
		//IL_026d: Expected O, but got I
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_03e5: Expected O, but got I
		//IL_03f5: Expected O, but got I
		//IL_0405: Expected O, but got I
		//IL_0427: Expected O, but got I4
		//IL_0390: Expected O, but got I
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_03b8: Expected O, but got I4
		//IL_02c4: Expected O, but got I
		//IL_0447: Expected O, but got I
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_0482: Expected O, but got I
		//IL_04ed: Expected O, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		if (obj3 == null)
		{
			((Action<AssetRequest<T>>)num)..ctor((object)(nint)intPtr, intPtr2);
		}
		((Action<AssetRequest<T>>)num2)..ctor((object)(nint)intPtr, intPtr2);
		object obj4 = default(object);
		((<>c__DisplayClass18_0<T>)obj4)..ctor();
		bool flag2 = obj4 == null;
		Action<object> action = (Action<object>)0;
		object obj5 = obj4;
		object obj6 = default(object);
		Action<object> action3;
		nint num7;
		nint num6;
		if (!flag2)
		{
			Action<AssetRequest<T>> action2 = (Action<AssetRequest<T>>)(obj4 + 16);
			action2 = (Action<AssetRequest<T>>)(object)go;
			action2..ctor((object)go, intPtr2);
			obj6 = typeof(RegisteredWaitHandle) + 40;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v32+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v32+B8]");
			object source = 0;
			object obj9 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 520;
			((Action<AssetRequest<T>>)obj9)..ctor((object)go, intPtr2);
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj4, (IntPtr)(nint)__ldftn(<>c__DisplayClass18_0<T>.<CleanQueues>b__0));
			IEnumerable<object> source2 = Enumerable.Where((IEnumerable<object>)source, func);
			IEnumerable<object> enumeration = Enumerable.OfType<AssetRequest<T>>(source2);
			object obj10 = (nint)0 + (nint)309;
			object obj11 = obj10 & 1;
			bool flag4 = obj11 == null;
			object obj12 = !flag4;
			nint num3 = 0;
			if (obj12 == null)
			{
				num3 = (nint)Enumerable.OfType<AssetRequest<T>>((IEnumerable)0);
			}
			action3 = (Action<object>)(object)Enumerable.OfType<AssetRequest<T>>((IEnumerable)num3);
			action3..ctor(obj4, (IntPtr)(nint)__ldftn(<>c__DisplayClass18_0<T>.<CleanQueues>b__1));
			ArraysExtensions.ForEach(enumeration, action3);
			object obj13 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v45+B8]");
			object obj14 = 0;
			obj5 = obj14;
			nint num4 = 0;
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			if (obj16 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v42 (Il2CppClass<RemoteAssetsCacher+<>c__18`1<T>>)+E4]");
				bool flag5 = (nint)0 == 0;
				nint num5 = 0;
				if (!flag5)
				{
					goto IL_0261;
				}
			}
			else
			{
				((Action<AssetRequest<T>>)0)..ctor((object)action3, (IntPtr)(nint)(delegate*<IEnumerable<AssetRequest<T>>, Action<AssetRequest<T>>, void>)(&ArraysExtensions.ForEach));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v47 (Il2CppClass<RemoteAssetsCacher+<>c__18`1<T>>)+E4]");
				bool flag6 = (nint)0 == 0;
				object obj17 = !flag6;
				if (obj17 != null)
				{
					goto IL_0261;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = (nint)0 + (nint)309;
			object obj19 = obj18 & 1;
			bool flag7 = obj19 == null;
			object obj20 = !flag7;
			num6 = 0;
			num7 = 0;
			if (obj20 != null)
			{
				goto IL_02a4;
			}
			goto IL_03d2;
		}
		goto IL_0732;
		IL_0435:
		nint num8 = 0;
		object obj21 = (nint)0 + (nint)309;
		object obj22 = obj21 & 1;
		bool flag8 = obj22 == null;
		nint num9 = 0;
		intPtr2 = (nint)(delegate*<IEnumerable<AssetRequest<T>>, Action<AssetRequest<T>>, void>)(&ArraysExtensions.ForEach);
		action = action3;
		NullReferenceException ex = (NullReferenceException)0;
		if (flag8)
		{
			goto IL_0748;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v44 (Il2CppClass<RemoteAssetsCacher+<>c__18`1<T>>)+E4]");
		bool flag9 = (nint)0 == 0;
		num9 = 0;
		intPtr2 = (nint)(delegate*<IEnumerable<AssetRequest<T>>, Action<AssetRequest<T>>, void>)(&ArraysExtensions.ForEach);
		action = action3;
		nint num10 = 0;
		IntPtr intPtr3 = (nint)(delegate*<IEnumerable<AssetRequest<T>>, Action<AssetRequest<T>>, void>)(&ArraysExtensions.ForEach);
		object obj23 = obj6;
		Action<object> action4 = action3;
		object obj24 = obj5;
		NullReferenceException ex2 = (NullReferenceException)0;
		if (!flag9)
		{
			goto IL_04fb;
		}
		goto IL_07a1;
		IL_02a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v52 (Il2CppClass<RemoteAssetsCacher+<>c__18`1<T>>)+B8]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v64 (Il2CppStaticFields<RemoteAssetsCacher+<>c__18`1<T>>)+8]");
		Predicate<object> match = (Predicate<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v64 (Il2CppStaticFields<RemoteAssetsCacher+<>c__18`1<T>>)+8]");
		if ((nint)0 != 0)
		{
			goto IL_02e9;
		}
		goto IL_0435;
		IL_05a9:
		object obj25 = typeof(List<Tween>) + 3744;
		((Action<AssetRequest<T>>)obj25)..ctor((object)action, intPtr2);
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor((object)<>c__18<T>.<>9, (IntPtr)(nint)__ldftn(<>c__18<T>.<CleanQueues>b__18_2));
		object obj26 = (nint)0 + (nint)309;
		object obj27 = obj26 & 1;
		bool flag10 = obj27 == null;
		object obj28 = !flag10;
		nint num12 = 0;
		if (obj28 == null)
		{
			((Action<AssetRequest<T>>)0)..ctor((object)<>c__18<T>.<>9, (IntPtr)(nint)__ldftn(<>c__18<T>.<CleanQueues>b__18_2));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v14 (Il2CppClass<RemoteAssetsCacher+<>c__18`1<T>>)+B8]");
		nint num13 = 0;
		object obj29 = (nint)0 + (nint)309;
		object obj30 = obj29 & 1;
		bool flag11 = obj30 == null;
		object obj31 = !flag11;
		nint num14 = 0;
		if (obj31 == null)
		{
			((Action<AssetRequest<T>>)0)..ctor((object)<>c__18<T>.<>9, (IntPtr)(nint)__ldftn(<>c__18<T>.<CleanQueues>b__18_2));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v16 (Il2CppClass<RemoteAssetsCacher+<>c__18`1<T>>)+B8]");
		Action<AssetRequest<T>> action5 = (Action<AssetRequest<T>>)((nint)0 + (nint)8);
		action5..ctor((object)predicate, (IntPtr)(nint)__ldftn(<>c__18<T>.<CleanQueues>b__18_2));
		bool flag12 = obj5 == null;
		object obj32 = !flag12;
		List<object> list = (List<object>)obj5;
		match = predicate;
		num9 = unchecked((nint)null);
		intPtr2 = (nint)__ldftn(<>c__18<T>.<CleanQueues>b__18_2);
		action = (Action<object>)(object)predicate;
		if (obj32 != null)
		{
			goto IL_0326;
		}
		goto IL_0732;
		IL_0732:
		ex = (NullReferenceException)(object)new Action<AssetRequest<T>>(action, intPtr2);
		goto IL_0748;
		IL_02e9:
		bool flag13 = obj5 == null;
		list = (List<object>)obj5;
		num9 = 0;
		intPtr2 = (nint)(delegate*<IEnumerable<AssetRequest<T>>, Action<AssetRequest<T>>, void>)(&ArraysExtensions.ForEach);
		action = action3;
		if (!flag13)
		{
			goto IL_0326;
		}
		goto IL_0732;
		IL_04fb:
		object obj33 = (nint)0 + (nint)309;
		object obj34 = obj33 & 1;
		bool flag14 = obj34 == null;
		object obj35 = !flag14;
		num10 = num9;
		intPtr3 = intPtr2;
		obj23 = obj6;
		action4 = action;
		obj24 = obj5;
		nint num15 = 0;
		if (obj35 == null)
		{
			goto IL_056b;
		}
		goto IL_05a9;
		IL_0748:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v3 (System.NullReferenceException)+E4]");
		bool flag15 = (nint)0 == 0;
		object obj36 = !flag15;
		num10 = num9;
		intPtr3 = intPtr2;
		obj23 = obj6;
		action4 = action;
		obj24 = obj5;
		if (obj36 != null)
		{
			goto IL_04fb;
		}
		goto IL_07a1;
		IL_0326:
		int num16 = list.RemoveAll(match);
		return;
		IL_056b:
		((Action<AssetRequest<T>>)num15)..ctor((object)action4, intPtr3);
		num9 = num10;
		intPtr2 = intPtr3;
		obj6 = obj23;
		action = action4;
		obj5 = obj24;
		goto IL_05a9;
		IL_07a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj37 = (nint)0 + (nint)309;
		object obj38 = obj37 & 1;
		bool flag16 = obj38 == null;
		num15 = 0;
		if (flag16)
		{
			goto IL_056b;
		}
		num9 = num10;
		intPtr2 = intPtr3;
		obj6 = obj23;
		action = action4;
		obj5 = obj24;
		goto IL_05a9;
		IL_0261:
		object obj39 = (nint)0 + (nint)309;
		object obj40 = obj39 & 1;
		bool flag17 = obj40 == null;
		num6 = 0;
		num7 = 0;
		if (!flag17)
		{
			goto IL_02a4;
		}
		goto IL_03d2;
		IL_03d2:
		((Action<AssetRequest<T>>)num7)..ctor((object)action3, (IntPtr)(nint)(delegate*<IEnumerable<AssetRequest<T>>, Action<AssetRequest<T>>, void>)(&ArraysExtensions.ForEach));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v46 (System.Action`1<RemoteAssetsCacher+AssetRequest`1<T>>)+B8]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v56+8]");
		match = (Predicate<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v56+8]");
		bool flag18 = (nint)0 == 0;
		object obj42 = !flag18;
		if (obj42 != null)
		{
			goto IL_02e9;
		}
		goto IL_0435;
	}

	private static IEnumerator CallGenericLoadAssetCoroutine(Type assetType, AssetRequest request)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_014e: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00e5: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_018e: Expected O, but got I
		//IL_019e: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_01c5: Expected O, but got I4
		//IL_01ce: Expected O, but got I4
		//IL_0211: Expected O, but got I
		//IL_023a: Expected O, but got I
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_0302: Expected O, but got I4
		//IL_0328: Expected O, but got I4
		//IL_033e: Expected I, but got O
		//IL_034e: Expected O, but got I
		//IL_0377: Expected O, but got I
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(RegisteredWaitHandle) + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70D4]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = typeof(SqlSingle[]) + 392;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v50+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			object obj7 = obj4;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			_ = 1;
			object obj4 = typeof(SqlSingle[]) + 392;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v50+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			object obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v34+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v18+10]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj12 = default(object);
		bool flag3 = obj12 == null;
		Type type = (Type)1;
		Type type2 = (Type)1;
		if (!flag3)
		{
			goto IL_01dc;
		}
		goto IL_0468;
		IL_0476:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0484;
		IL_0468:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0476;
		IL_0484:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v50+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v22+10]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag4 = obj12 == null;
		object obj14 = !flag4;
		type = (Type)1;
		if (obj14 != null)
		{
			goto IL_01dc;
		}
		type2 = (Type)1;
		goto IL_0468;
		IL_01dc:
		if ((object)assetType != null)
		{
			object obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v16+40]");
			type = (Type)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag5 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v16+40]");
			type2 = (Type)0;
			if (flag5)
			{
				goto IL_0484;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v11+18]");
		bool flag6 = (nint)0 == 0;
		type2 = type;
		if (!flag6)
		{
			object obj16 = obj12 + 32;
			obj16 = assetType;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag7 = obj11 == null;
			type2 = assetType;
			if (!flag7)
			{
				object obj17 = typeof(TypeConverter<ushort, char>) + 3400;
				object obj18 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ X8_v9+3F8] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object[] array = default(object[]);
				bool flag8 = array == null;
				type2 = (Type)1;
				if (!flag8)
				{
					bool flag9 = request == null;
					Type type3 = (Type)1;
					if (!flag9)
					{
						nint num = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
						type3 = (Type)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag10 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
						type2 = (Type)0;
						if (flag10)
						{
							goto IL_0484;
						}
					}
					bool flag11 = array.Length == 0;
					type2 = type3;
					if (flag11)
					{
						goto IL_0476;
					}
					object obj19 = array + 32;
					obj19 = request;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					MethodBase methodBase = default(MethodBase);
					bool flag12 = (object)methodBase == null;
					type2 = (Type)(object)request;
					if (!flag12)
					{
						object obj20 = methodBase.Invoke(null, array);
						bool flag13 = obj20 == null;
						IEnumerator enumerator = (IEnumerator)obj20;
						if (!flag13)
						{
							object obj21 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							if (enumerator == null)
							{
								return (IEnumerator)new InvalidCastException();
							}
						}
						return enumerator;
					}
				}
			}
			goto IL_0468;
		}
		goto IL_0476;
	}
}
