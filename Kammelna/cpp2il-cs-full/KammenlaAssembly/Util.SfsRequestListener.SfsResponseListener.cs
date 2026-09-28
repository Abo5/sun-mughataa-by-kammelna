using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Core;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace Util;

public class SfsRequestListener
{
	public class SfsResponseListener
	{
		private readonly GameObject <GameObject>k__BackingField;

		private readonly Action<ISFSObject> <Callback>k__BackingField;

		private readonly bool <Once>k__BackingField;

		private readonly int <RequestId>k__BackingField;

		public GameObject GameObject => <GameObject>k__BackingField;

		public Action<ISFSObject> Callback => <Callback>k__BackingField;

		public bool Once => <Once>k__BackingField;

		public int RequestId => <RequestId>k__BackingField;

		public SfsResponseListener(GameObject go, Action<ISFSObject> callback, bool once, int requestId = 0)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			object obj = this + 16;
			obj = go;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj2 = this + 24;
			obj2 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Predicate<SfsResponseListener> <>9__11_2;

		public static Func<KeyValuePair<string, List<SfsResponseListener>>, bool> <>9__11_0;

		public static Func<KeyValuePair<string, List<SfsResponseListener>>, string> <>9__11_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <ClearNulls>b__11_2(SfsResponseListener go)
		{
			//IL_0093: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			if (go != null)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = go.<GameObject>k__BackingField;
				return (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ClearNulls>b__11_0(KeyValuePair<string, List<SfsResponseListener>> u)
		{
			//IL_000f: Expected O, but got I
			IntPtr intPtr = default(IntPtr);
			bool flag = Enumerable.Any((IEnumerable<object>)(nint)intPtr);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}

		internal string <ClearNulls>b__11_1(KeyValuePair<string, List<SfsResponseListener>> e)
		{
			return (string)e;
		}
	}

	private sealed class <>c__DisplayClass10_0
	{
		public int responseRequestId;

		internal bool <OnExtensionResponse>b__0(SfsResponseListener listener)
		{
			//IL_00e7: Expected I4, but got O
			//IL_0080: Expected O, but got I4
			//IL_00ab: Expected O, but got I4
			if (listener != null)
			{
				if (listener.<Once>k__BackingField)
				{
					if (listener.<RequestId>k__BackingField != 0)
					{
						bool flag = responseRequestId == 0;
						object obj = !flag;
						object obj2 = ~obj;
						if (obj2 == null)
						{
							object obj3 = responseRequestId - listener.<RequestId>k__BackingField;
							return obj3 == null;
						}
						return true;
					}
					return true;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public GameObject go;

		public Action<ISFSObject> callback;

		internal bool <AddListener>b__0(SfsResponseListener listener)
		{
			//IL_00f2: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I4
			if (listener != null)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
				bool flag;
				if ((nint)0 != 0)
				{
					flag = listener.<GameObject>k__BackingField == go;
					if (flag)
					{
						goto IL_0077;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					flag = listener.<GameObject>k__BackingField == go;
					bool flag2 = !flag;
					object obj3 = !flag2;
					if (obj3 != null)
					{
						goto IL_0077;
					}
				}
				return flag;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0077:
			return listener.<Callback>k__BackingField == callback;
		}
	}

	private const string RequestIdKey = "rid";

	private static SfsRequestListener RequestListener;

	private readonly IDictionary<string, List<SfsResponseListener>> listeners;

	private static int _nextRequestId;

	public SfsRequestListener()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2152;
		object obj2 = typeof(DataRelation) + 3728;
		object obj3 = (nint)0 + (nint)3496;
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj4 = this + 16;
		obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj3);
		SFS.OnExtensionResponse += eventListenerDelegate;
	}

	public void AddListener(string command, GameObject go, bool listenOnce, Action<ISFSObject> callback, int requestId = 0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0089: Expected I, but got O
		//IL_0099: Expected O, but got I
		//IL_012f: Expected O, but got I
		//IL_0153: Expected O, but got I4
		//IL_00d4: Expected O, but got I
		//IL_01dd: Expected I, but got O
		//IL_01ed: Expected O, but got I
		//IL_0283: Expected O, but got I
		//IL_02a7: Expected O, but got I4
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_019f: Expected O, but got I
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_0657: Expected O, but got I
		//IL_0663: Expected O, but got I
		//IL_067e: Expected I, but got O
		//IL_0228: Expected O, but got I
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_02dd: Expected O, but got I
		//IL_03ab: Expected I, but got O
		//IL_03bb: Expected O, but got I
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_030d: Expected O, but got I
		//IL_0331: Expected O, but got I4
		//IL_0349: Expected O, but got I
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_03f6: Expected O, but got I
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected O, but got Unknown
		//IL_0566: Expected O, but got I4
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected O, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = go;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IDictionary<string, List<SfsResponseListener>> dictionary = listeners;
		object obj5 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2416;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v4 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v4 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0115;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v4 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+B0]");
		object obj7 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X10_v20-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj7 += 16;
			obj6--;
			if ((nint)obj6 != 1)
			{
				continue;
			}
			goto IL_0115;
		}
		object obj8 = obj7 + 4;
		object obj9 = num + obj8;
		object obj10 = obj9 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v48+8]");
		List<object> list = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v360 @ X0_v48] (should have been resolved before IL gen)");
		object obj11 = default(object);
		if (obj11 != null)
		{
			goto IL_01c6;
		}
		goto IL_0367;
		IL_06b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X0_v30+8]");
		bool flag = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v543 @ X0_v30] (should have been resolved before IL gen)");
		List<object> list3 = default(List<object>);
		List<object> list2 = list3;
		string text2 = default(string);
		string text = text2;
		List<object> list4 = list3;
		goto IL_0637;
		IL_0367:
		object obj12 = typeof(List<Tween>) + 1264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		list3..ctor();
		IDictionary<string, List<SfsResponseListener>> dictionary2 = listeners;
		nint num2 = (nint)dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v19 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v19 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0437;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v19 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X10_v9-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj14 += 16;
			obj13--;
			if ((nint)obj13 != 1)
			{
				continue;
			}
			goto IL_0437;
		}
		object obj15 = obj14 + 1;
		object obj16 = num2 + obj15;
		object obj17 = obj16 + 312;
		goto IL_06b8;
		IL_0637:
		object obj18 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 536;
		object obj19 = (nint)0 + (nint)2080;
		object obj20 = (nint)0 + (nint)2952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj19);
		if (!Enumerable.Any(list4, func))
		{
			object obj21 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj22 = default(object);
			obj22..ctor();
			object obj23 = obj22 + 16;
			obj23 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj24 = obj22 + 24;
			obj24 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int version = list4._version + 1;
			list4._version = version;
			object[] items = list4._items;
			bool flag2 = list4._size < items.Length;
			object obj25 = !flag2;
			if (obj25 == null)
			{
				int size = list4._size + 1;
				list4._size = size;
				object obj26 = items + list4._size;
				object obj27 = obj26 + 32;
				obj27 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list4.AddWithResize(obj22);
			}
		}
		return;
		IL_0437:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_06b8;
		IL_0115:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v45+8]");
		list = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v325 @ X0_v45] (should have been resolved before IL gen)");
		object obj28 = default(object);
		bool flag3 = obj28 == null;
		object obj29 = !flag3;
		if (obj29 != null)
		{
			goto IL_01c6;
		}
		goto IL_0367;
		IL_01c6:
		IDictionary<string, List<SfsResponseListener>> dictionary3 = listeners;
		nint num3 = (nint)dictionary3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v24 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v24 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0269;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v24 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+B0]");
		object obj31 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X10_v15-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj31 += 16;
			obj30--;
			if ((nint)obj30 != 1)
			{
				continue;
			}
			goto IL_0269;
		}
		object obj32 = num3 + obj31;
		object obj33 = obj32 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v41+8]");
		list = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v451 @ X0_v41] (should have been resolved before IL gen)");
		List<object> list5 = default(List<object>);
		bool flag4 = list5 == null;
		object obj34 = !flag4;
		flag = listenOnce;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v41+8]");
		list2 = (List<object>)0;
		text = text2;
		list4 = list5;
		if (obj34 == null)
		{
			goto IL_0367;
		}
		goto IL_0637;
		IL_0269:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v38+8]");
		list2 = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v431 @ X0_v38] (should have been resolved before IL gen)");
		List<object> list6 = default(List<object>);
		bool flag5 = list6 == null;
		object obj35 = !flag5;
		flag = listenOnce;
		text = text2;
		list4 = list6;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v38+8]");
			list = (List<object>)0;
			goto IL_0367;
		}
		goto IL_0637;
	}

	public static void AddListener(GameObject go, string command, bool onlyOnce = false, Action<ISFSObject> callback = null)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_014b: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8703]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v12+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v12+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v5+B8]");
		object obj8 = 0;
		SfsRequestListener sfsRequestListener = (SfsRequestListener)obj8;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a2;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v12+B8]");
		object obj10 = 0;
		sfsRequestListener = (SfsRequestListener)obj10;
		goto IL_00a2;
		IL_00a2:
		sfsRequestListener.AddListener(command, go, onlyOnce, callback);
	}

	public static void SendZoneRequest(GameObject go, string command, ISFSObject param = null, bool keepListening = false, Action<ISFSObject> callback = null)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017d: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_0203: Expected O, but got I4
		//IL_01ab: Expected O, but got I
		//IL_01c5: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_012a: Expected O, but got I4
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_02fa: Expected I, but got O
		//IL_030a: Expected O, but got I
		//IL_023b: Expected O, but got I
		//IL_0270: Expected O, but got I4
		//IL_0470: Expected O, but got I4
		//IL_0345: Expected O, but got I
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_048e: Expected O, but got I
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8742]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v27+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8744]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_01d3;
		IL_0386:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_043c;
		IL_02cf:
		object obj8 = typeof(System.IOAsyncCallback) + 976;
		object obj9 = "placementId" + 4048;
		ISFSObject iSFSObject;
		nint num = (nint)iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0386;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X10_v6-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0386;
		}
		object obj12 = obj11 + 35;
		object obj13 = num + obj12;
		object obj14 = obj13 + 312;
		goto IL_043c;
		IL_028e:
		object obj15 = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		int num3;
		int num2 = num3;
		iSFSObject = sFSObject;
		goto IL_02cf;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8744]");
		object obj16 = (nint)0 & (nint)1;
		if (obj16 != null)
		{
			goto IL_00b0;
		}
		goto IL_01d3;
		IL_01d3:
		_ = 1;
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v42+E4]");
		bool flag3 = (nint)0 == 0;
		object obj18 = !flag3;
		object obj19 = obj17;
		if (obj18 != null)
		{
			goto IL_00e5;
		}
		goto IL_0219;
		IL_00b0:
		obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v42+E4]");
		bool flag4 = (nint)0 == 0;
		obj19 = obj17;
		if (!flag4)
		{
			goto IL_00e5;
		}
		goto IL_0219;
		IL_0219:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v21+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v16+8]");
		num3 = (int)((nint)0 + (nint)1);
		bool flag5 = param == null;
		object obj22 = !flag5;
		num2 = num3;
		iSFSObject = param;
		if (obj22 == null)
		{
			goto IL_028e;
		}
		goto IL_02cf;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v42+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v25+8]");
		num2 = (int)((nint)0 + (nint)1);
		bool flag6 = param == null;
		object obj24 = !flag6;
		iSFSObject = param;
		if (obj24 == null)
		{
			num3 = num2;
			goto IL_028e;
		}
		goto IL_02cf;
		IL_043c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v231 @ X0_v4] (should have been resolved before IL gen)");
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v8+E4]");
		bool flag7 = (nint)0 == 0;
		object obj26 = !flag7;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v8+B8]");
		object obj27 = 0;
		bool listenOnce = (byte)((keepListening ? 1u : 0u) ^ 1u) != 0;
		((SfsRequestListener)obj27).AddListener(command, go, listenOnce, callback, num2);
		SFS.SendZoneExtensionRequest(command, iSFSObject);
	}

	public static void SendRoomRequest(GameObject go, string command, ISFSObject param = null, bool keepListening = false, Action<ISFSObject> callback = null)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017d: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_0203: Expected O, but got I4
		//IL_01ab: Expected O, but got I
		//IL_01c5: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_012a: Expected O, but got I4
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_02fa: Expected I, but got O
		//IL_030a: Expected O, but got I
		//IL_023b: Expected O, but got I
		//IL_0270: Expected O, but got I4
		//IL_0470: Expected O, but got I4
		//IL_0345: Expected O, but got I
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_048e: Expected O, but got I
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8743]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v27+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8744]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_01d3;
		IL_0386:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_043c;
		IL_02cf:
		object obj8 = typeof(System.IOAsyncCallback) + 976;
		object obj9 = "placementId" + 4048;
		ISFSObject iSFSObject;
		nint num = (nint)iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0386;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X10_v6-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0386;
		}
		object obj12 = obj11 + 35;
		object obj13 = num + obj12;
		object obj14 = obj13 + 312;
		goto IL_043c;
		IL_028e:
		object obj15 = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		int num3;
		int num2 = num3;
		iSFSObject = sFSObject;
		goto IL_02cf;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8744]");
		object obj16 = (nint)0 & (nint)1;
		if (obj16 != null)
		{
			goto IL_00b0;
		}
		goto IL_01d3;
		IL_01d3:
		_ = 1;
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v42+E4]");
		bool flag3 = (nint)0 == 0;
		object obj18 = !flag3;
		object obj19 = obj17;
		if (obj18 != null)
		{
			goto IL_00e5;
		}
		goto IL_0219;
		IL_00b0:
		obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v42+E4]");
		bool flag4 = (nint)0 == 0;
		obj19 = obj17;
		if (!flag4)
		{
			goto IL_00e5;
		}
		goto IL_0219;
		IL_0219:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v21+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v16+8]");
		num3 = (int)((nint)0 + (nint)1);
		bool flag5 = param == null;
		object obj22 = !flag5;
		num2 = num3;
		iSFSObject = param;
		if (obj22 == null)
		{
			goto IL_028e;
		}
		goto IL_02cf;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v42+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v25+8]");
		num2 = (int)((nint)0 + (nint)1);
		bool flag6 = param == null;
		object obj24 = !flag6;
		iSFSObject = param;
		if (obj24 == null)
		{
			num3 = num2;
			goto IL_028e;
		}
		goto IL_02cf;
		IL_043c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v231 @ X0_v4] (should have been resolved before IL gen)");
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v8+E4]");
		bool flag7 = (nint)0 == 0;
		object obj26 = !flag7;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v8+B8]");
		object obj27 = 0;
		bool listenOnce = (byte)((keepListening ? 1u : 0u) ^ 1u) != 0;
		((SfsRequestListener)obj27).AddListener(command, go, listenOnce, callback, num2);
		SFS.SendRoomExtensionRequest(command, iSFSObject);
	}

	private static int GenerateRequestId()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_0078: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+8]");
		return (int)((nint)0 + (nint)1);
	}

	private void OnExtensionResponse(BaseEvent evt)
	{
		//IL_0c07: Expected O, but got I4
		//IL_0c15: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0188: Expected O, but got I4
		//IL_0240: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_0c4a: Expected O, but got I4
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected O, but got Unknown
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Expected O, but got Unknown
		//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Expected O, but got Unknown
		//IL_0263: Expected I, but got O
		//IL_0273: Expected O, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_03a6: Expected O, but got I
		//IL_03ca: Expected O, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_009d: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_02ae: Expected O, but got I
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_0cfa: Expected O, but got I4
		//IL_0d0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0f: Expected O, but got Unknown
		//IL_0d44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d49: Expected O, but got Unknown
		//IL_0d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5e: Expected O, but got Unknown
		//IL_04d3: Expected O, but got I4
		//IL_04dc: Expected O, but got I4
		//IL_04e9: Expected I, but got O
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_0418: Expected O, but got I
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02df: Expected O, but got I
		//IL_02f9: Expected O, but got I4
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_052b: Expected O, but got I
		//IL_088b: Expected O, but got I
		//IL_08b6: Expected O, but got I4
		//IL_08bf: Expected O, but got I4
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Expected O, but got Unknown
		//IL_090b: Expected O, but got I
		//IL_091c: Expected I, but got O
		//IL_092d: Expected O, but got I
		//IL_0935: Expected I, but got O
		//IL_0952: Expected O, but got I
		//IL_0ad0: Expected O, but got I4
		//IL_0ad9: Expected O, but got I4
		//IL_0986: Expected O, but got I4
		//IL_0793: Expected O, but got I
		//IL_09c6: Expected O, but got I4
		//IL_05dd: Expected O, but got I
		//IL_0818: Expected O, but got I
		//IL_09e4: Expected I, but got O
		//IL_09f4: Expected O, but got I
		//IL_0b6a: Expected O, but got I
		//IL_0673: Expected O, but got I4
		//IL_0690: Expected O, but got I
		//IL_06cb: Expected O, but got I
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_0775: Expected O, but got I
		//IL_0a2f: Expected O, but got I
		//IL_0a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8d: Expected O, but got Unknown
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected O, but got Unknown
		//IL_0aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa8: Expected O, but got Unknown
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected O, but got Unknown
		//IL_0a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Expected O, but got Unknown
		ClearNulls();
		string command = SFSExtensions.GetCommand(evt);
		IDictionary<string, List<SfsResponseListener>> dictionary = listeners;
		bool flag = listeners == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		string text = null;
		string text2 = (string)152993792;
		SfsRequestListener sfsRequestListener = this;
		object obj;
		bool flag3 = default(bool);
		object obj4 = default(object);
		object obj5 = default(object);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		object obj6 = default(object);
		object obj7 = default(object);
		object obj8 = default(object);
		bool flag7 = default(bool);
		object obj2;
		nint num2;
		if (!flag)
		{
			obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2416;
			nint num = (nint)dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_014a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			bool flag2 = flag3;
			object obj9;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v21-8]");
				bool flag4 = 0 < (nint)obj;
				obj4 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v21-8]");
				obj5 = 0 - obj;
				flag5 = (nint)obj5 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v21-8]");
				flag6 = 0 == (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v21-8]");
				obj6 = 0 ^ obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v21-8]");
				obj7 = 0 ^ obj5;
				obj8 = obj6 & obj7;
				flag7 = (nint)obj8 < 0;
				if (flag6)
				{
					break;
				}
				obj9 = obj3 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
				obj2 = -1;
				bool flag8 = (nint)obj2 < 1;
				obj4 = !flag8;
				obj5 = obj2 - 1;
				flag5 = (nint)obj5 < 0;
				flag6 = obj5 == null;
				obj6 = obj2 ^ 1;
				obj7 = obj2 ^ obj5;
				obj8 = obj6 & obj7;
				flag7 = (nint)obj8 < 0;
				flag3 = (nint)obj2 != 1;
				flag2 = flag3;
				obj3 = obj9;
				if (flag3)
				{
					continue;
				}
				goto IL_014a;
			}
			obj2 = obj3 + 4;
			object obj10 = num + obj2;
			object obj11 = obj10 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v64+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v285 @ X0_v64] (should have been resolved before IL gen)");
			object obj12 = default(object);
			bool flag9 = obj12 == null;
			flag3 = flag2;
			obj9 = obj3;
			text = command;
			if (!flag9)
			{
				goto IL_021b;
			}
			return;
		}
		goto IL_0afb;
		IL_0afb:
		throw new NullReferenceException();
		IL_038c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X0_v54+8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v532 @ X0_v54] (should have been resolved before IL gen)");
		List<object> list = default(List<object>);
		bool flag10 = list == null;
		object obj14 = !flag10;
		string text3 = command;
		if (obj14 == null)
		{
			return;
		}
		goto IL_044f;
		IL_044f:
		object obj15 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = default(object);
		obj16..ctor();
		ISFSObject responseParams = SFSExtensions.GetResponseParams(evt);
		object obj17 = "placementId" + 4048;
		text = (string)obj17;
		int num3 = SFSExtensions.Get(responseParams, (string)obj17, 0);
		bool flag11 = obj16 == null;
		enumerator = (List<object>.Enumerator)0;
		object obj18 = 0;
		object obj19 = obj16;
		num2 = unchecked((nint)null);
		dictionary = (IDictionary<string, List<SfsResponseListener>>)list;
		text2 = command;
		sfsRequestListener = this;
		if (!flag11)
		{
			List<object>.Enumerator enumerator2 = list.GetEnumerator();
			object obj20 = (nint)0 + (nint)440;
			int num4 = 0;
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			object obj22 = default(object);
			object obj31 = default(object);
			List<object>.Enumerator enumerator6;
			List<object> list2;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			while (true)
			{
				object obj21 = obj20;
				List<object>.Enumerator enumerator5;
				if (enumerator3.MoveNext())
				{
					if (obj22 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ stack_-88+24]");
						bool flag12 = (nint)0 == 0;
						bool flag13 = flag3;
						bool flag14 = flag7;
						object obj23 = obj8;
						object obj24 = obj7;
						object obj25 = obj6;
						bool flag15 = flag6;
						bool flag16 = flag5;
						object obj26 = obj5;
						object obj27 = obj4;
						object obj28 = obj2;
						if (!flag12)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v40 (System.Object)+10]");
							obj28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v40 (System.Object)+10]");
							bool flag17 = (nint)0 == 0;
							flag13 = flag3;
							flag14 = flag7;
							obj23 = obj8;
							obj24 = obj7;
							obj25 = obj6;
							flag15 = flag6;
							flag16 = flag5;
							obj26 = obj5;
							obj27 = obj4;
							if (!flag17)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v40 (System.Object)+10]");
								nint num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ stack_-88+24]");
								bool flag18 = num5 < 0;
								obj27 = !flag18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v40 (System.Object)+10]");
								nint num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ stack_-88+24]");
								obj26 = num6 - 0;
								flag16 = (nint)obj26 < 0;
								flag15 = obj26 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v40 (System.Object)+10]");
								nint num7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ stack_-88+24]");
								obj25 = num7 ^ 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v40 (System.Object)+10]");
								obj24 = 0 ^ obj26;
								obj23 = obj25 & obj24;
								flag14 = (nint)obj23 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v40 (System.Object)+10]");
								nint num8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ stack_-88+24]");
								flag13 = num8 != 0;
								flag3 = flag13;
								flag7 = flag14;
								obj8 = obj23;
								obj7 = obj24;
								obj6 = obj25;
								flag6 = flag15;
								flag5 = flag16;
								obj5 = obj26;
								obj4 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v40 (System.Object)+10]");
								obj2 = 0;
								if (flag13)
								{
									continue;
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ stack_-88+18]");
						object obj29 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ stack_-88+18]");
						bool flag19 = (nint)0 == 0;
						flag3 = flag13;
						flag7 = flag14;
						obj8 = obj23;
						obj7 = obj24;
						obj6 = obj25;
						flag6 = flag15;
						flag5 = flag16;
						obj5 = obj26;
						obj4 = obj27;
						obj2 = obj28;
						if (!flag19)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v42+18]");
							obj2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v42+28]");
							num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v660 @ X8_v42+18] (should have been resolved before IL gen)");
							flag3 = flag13;
							flag7 = flag14;
							obj8 = obj23;
							obj7 = obj24;
							obj6 = obj25;
							flag6 = flag15;
							flag5 = flag16;
							obj5 = obj26;
							obj4 = obj27;
						}
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					enumerator = enumerator4;
					enumerator5 = enumerator4;
					enumerator4 = (List<object>.Enumerator)0;
					obj18 = 0;
					obj19 = obj16;
					dictionary = (IDictionary<string, List<SfsResponseListener>>)list;
					text2 = command;
					sfsRequestListener = this;
					bool flag20 = (nint)obj21 != 1;
					NullReferenceException ex2 = ex;
					if (!flag20)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
						object obj30 = (nint)0 + (nint)432;
						obj21 = obj30;
						enumerator.Dispose();
						bool flag21 = obj31 == null;
						enumerator6 = enumerator;
						enumerator4 = (List<object>.Enumerator)obj31;
						list2 = (List<object>)dictionary;
						if (flag21)
						{
							break;
						}
						OutOfMemoryException ex3 = new OutOfMemoryException();
						ex2 = (NullReferenceException)(object)ex3;
						enumerator4 = (List<object>.Enumerator)obj31;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223DC98");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
					return;
				}
				object obj32 = (nint)0 + (nint)432;
				obj21 = obj32;
				enumerator3.Dispose();
				enumerator6 = enumerator4;
				enumerator5 = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				obj18 = 0;
				obj19 = obj16;
				list2 = list;
				text2 = command;
				sfsRequestListener = this;
				break;
			}
			object obj33 = typeof(List<Tween>) + 3768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj34 = (nint)0 + (nint)2072;
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor(obj19, (IntPtr)obj34);
			object obj35 = (nint)0 + (nint)136;
			num2 = (nint)obj35;
			int num9 = list2.RemoveAll(predicate);
			object obj36 = (nint)0 + (nint)2432;
			text = (string)obj36;
			bool flag22 = Enumerable.Any(list2);
			bool flag23 = !flag22;
			object obj37 = !flag23;
			if (obj37 != null)
			{
				return;
			}
			sfsRequestListener = (SfsRequestListener)sfsRequestListener.listeners;
			bool flag24 = sfsRequestListener.listeners == null;
			enumerator = enumerator6;
			obj18 = 0;
			dictionary = (IDictionary<string, List<SfsResponseListener>>)list2;
			if (!flag24)
			{
				nint num10 = (nint)sfsRequestListener;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v21 (Il2CppClass<Util.SfsRequestListener>)+12E]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v21 (Il2CppClass<Util.SfsRequestListener>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0a70;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v21 (Il2CppClass<Util.SfsRequestListener>)+B0]");
				object obj39 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X10_v9-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj39 += 16;
					obj38--;
					if ((nint)obj38 != 1)
					{
						continue;
					}
					goto IL_0a70;
				}
				object obj40 = obj39 + 6;
				object obj41 = num10 + obj40;
				object obj42 = obj41 + 312;
				goto IL_0e06;
			}
		}
		goto IL_0afb;
		IL_0e06:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v729 @ X0_v31] (should have been resolved before IL gen)");
		return;
		IL_0a70:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0e06;
		IL_014a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v61+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v238 @ X0_v61] (should have been resolved before IL gen)");
		object obj43 = default(object);
		bool flag25 = obj43 == null;
		object obj44 = !flag25;
		text = command;
		if (obj44 == null)
		{
			return;
		}
		goto IL_021b;
		IL_021b:
		dictionary = listeners;
		bool flag26 = listeners == null;
		enumerator = (List<object>.Enumerator)0;
		text2 = command;
		sfsRequestListener = this;
		if (!flag26)
		{
			nint num11 = (nint)dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v27 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v27 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_038c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v27 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+B0]");
			object obj45 = (nint)0 + (nint)8;
			bool flag27 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X10_v16-8]");
				bool flag28 = 0 < (nint)obj;
				obj4 = !flag28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X10_v16-8]");
				obj5 = 0 - obj;
				flag5 = (nint)obj5 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X10_v16-8]");
				flag6 = 0 == (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X10_v16-8]");
				obj6 = 0 ^ obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X10_v16-8]");
				obj7 = 0 ^ obj5;
				obj8 = obj6 & obj7;
				flag7 = (nint)obj8 < 0;
				if (flag6)
				{
					break;
				}
				object obj9 = obj45 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v27 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
				obj2 = -1;
				bool flag29 = (nint)obj2 < 1;
				obj4 = !flag29;
				obj5 = obj2 - 1;
				flag5 = (nint)obj5 < 0;
				flag6 = obj5 == null;
				obj6 = obj2 ^ 1;
				obj7 = obj2 ^ obj5;
				obj8 = obj6 & obj7;
				flag7 = (nint)obj8 < 0;
				flag3 = (nint)obj2 != 1;
				flag27 = flag3;
				obj45 = obj9;
				if (flag3)
				{
					continue;
				}
				goto IL_038c;
			}
			obj2 = obj45;
			object obj46 = num11 + obj45;
			object obj47 = obj46 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v57+8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v567 @ X0_v57] (should have been resolved before IL gen)");
			bool flag30 = list == null;
			flag3 = flag27;
			text3 = command;
			if (!flag30)
			{
				goto IL_044f;
			}
			return;
		}
		goto IL_0afb;
	}

	private unsafe void ClearNulls()
	{
		//IL_0010: Expected O, but got I
		//IL_0e39: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_0ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eab: Expected O, but got Unknown
		//IL_0eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebf: Expected O, but got Unknown
		//IL_0ece: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed3: Expected O, but got Unknown
		//IL_0ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee7: Expected O, but got Unknown
		//IL_0ef3: Expected O, but got I
		//IL_0eff: Expected O, but got I
		//IL_0f0f: Expected O, but got I
		//IL_0f21: Expected O, but got Ref
		//IL_007c: Expected O, but got I
		//IL_0e57: Expected O, but got I
		//IL_0e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6e: Expected O, but got Unknown
		//IL_0c30: Expected O, but got Ref
		//IL_0c39: Expected O, but got I4
		//IL_0c41: Expected I, but got O
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0169: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_0fa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa6: Expected O, but got Unknown
		//IL_01a4: Expected O, but got I
		//IL_0578: Expected O, but got Ref
		//IL_0581: Expected O, but got I4
		//IL_058a: Expected O, but got I4
		//IL_0593: Expected O, but got I4
		//IL_059c: Expected O, but got I4
		//IL_05dc: Expected O, but got Ref
		//IL_05e5: Expected O, but got I4
		//IL_05ee: Expected O, but got I4
		//IL_0617: Expected O, but got I4
		//IL_0f36: Expected O, but got I
		//IL_0f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4d: Expected O, but got Unknown
		//IL_10ef: Expected O, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		//IL_0651: Expected O, but got I
		//IL_0c57: Expected O, but got Ref
		//IL_0c60: Expected O, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01d5: Expected O, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected O, but got Unknown
		//IL_02af: Expected O, but got I
		//IL_068c: Expected O, but got I
		//IL_0853: Expected O, but got I
		//IL_0863: Expected O, but got I
		//IL_0885: Expected O, but got I4
		//IL_0895: Expected O, but got I
		//IL_0791: Expected O, but got I4
		//IL_1165: Expected O, but got I
		//IL_02ea: Expected O, but got I
		//IL_0d4b: Expected O, but got I4
		//IL_0d5c: Expected O, but got I4
		//IL_0d65: Expected O, but got I4
		//IL_1224: Expected O, but got I
		//IL_07dc: Expected O, but got I
		//IL_07ec: Expected O, but got I
		//IL_080e: Expected O, but got I4
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected O, but got Unknown
		//IL_044e: Expected O, but got I
		//IL_045e: Expected O, but got I
		//IL_0480: Expected O, but got I4
		//IL_0fd3: Expected O, but got I
		//IL_0fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fea: Expected O, but got Unknown
		//IL_09ae: Expected O, but got I
		//IL_09be: Expected O, but got I
		//IL_09e0: Expected O, but got I4
		//IL_0a00: Expected O, but got I
		//IL_08b3: Expected O, but got I
		//IL_08d5: Expected O, but got I4
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected O, but got Unknown
		//IL_06bd: Expected O, but got I
		//IL_03cf: Expected O, but got I
		//IL_03df: Expected O, but got I
		//IL_0401: Expected O, but got I4
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_0dc4: Expected O, but got I4
		//IL_12e0: Expected O, but got I
		//IL_12e8: Expected I, but got O
		//IL_1305: Expected O, but got I
		//IL_130d: Expected I, but got O
		//IL_0927: Expected O, but got I
		//IL_0937: Expected O, but got I
		//IL_0959: Expected O, but got I4
		//IL_1273: Unknown result type (might be due to invalid IL or missing references)
		//IL_1278: Expected O, but got Unknown
		//IL_128e: Expected O, but got I
		//IL_129f: Expected I, but got O
		//IL_12bd: Expected O, but got I
		//IL_082c: Expected O, but got I
		//IL_0c76: Expected O, but got Ref
		//IL_0c7f: Expected O, but got I4
		//IL_04b6: Expected O, but got I
		//IL_04d8: Expected O, but got I4
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_031b: Expected O, but got I
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0a1e: Expected O, but got I
		//IL_0a40: Expected O, but got I4
		//IL_0905: Expected O, but got I
		//IL_053a: Expected I, but got O
		//IL_054f: Expected O, but got I
		//IL_105c: Expected I, but got O
		//IL_106d: Expected I, but got O
		//IL_108b: Expected O, but got I
		//IL_10b2: Expected I, but got O
		//IL_0aa4: Expected O, but got I
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Expected O, but got Unknown
		//IL_0ac0: Expected O, but got Ref
		//IL_138e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1393: Expected O, but got Unknown
		//IL_13a9: Expected O, but got I
		//IL_13ba: Expected I, but got O
		//IL_13d8: Expected O, but got I
		//IL_0987: Expected O, but got I
		//IL_0508: Expected O, but got I
		//IL_1402: Expected I, but got O
		//IL_0a70: Expected O, but got I
		//IL_0cc5: Expected O, but got Ref
		//IL_0cce: Expected O, but got I4
		//IL_0b2c: Expected I, but got O
		//IL_0b3c: Expected O, but got I
		//IL_0b77: Expected O, but got I
		//IL_143c: Expected O, but got I
		//IL_144e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1453: Expected O, but got Unknown
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bef: Expected O, but got Unknown
		//IL_0bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Expected O, but got Unknown
		//IL_0c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Expected O, but got Unknown
		//IL_0b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8a: Expected O, but got Unknown
		//IL_0b93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Expected O, but got Unknown
		//IL_0ba3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba8: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8705]");
		object obj = 0;
		IDictionary<string, List<SfsResponseListener>> dictionary = listeners;
		bool flag = listeners == null;
		object obj2 = 0;
		bool flag3 = default(bool);
		object obj6 = default(object);
		object obj8 = default(object);
		if (!flag)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2760;
			nint num = (nint)dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v59 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v59 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0101;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v59 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			bool flag2 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X10_v37-8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X10_v37-8]");
				object obj7 = 0 - obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X10_v37-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj8 = obj5 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v59 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
				obj4 = -1;
				obj7 = obj4 - 1;
				bool flag4 = obj7 == null;
				flag3 = (nint)obj4 != 1;
				flag2 = flag3;
				obj5 = obj8;
				if (flag3)
				{
					continue;
				}
				goto IL_0101;
			}
			obj4 = obj5;
			object obj9 = num + obj5;
			object obj10 = obj9 + 312;
			flag3 = flag2;
			obj8 = obj5;
			goto IL_0e97;
		}
		goto IL_13ef;
		IL_0e97:
		object obj11 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj12 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 64;
		object obj13 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3168;
		object obj14 = typeof(List<Tween>) + 3768;
		object obj15 = (nint)0 + (nint)2064;
		object obj16 = (nint)0 + (nint)136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v65+8]");
		Predicate<object> predicate = (Predicate<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v301 @ X0_v65] (should have been resolved before IL gen)");
		obj = (object)(&obj2);
		object obj20 = default(object);
		object obj23 = default(object);
		Predicate<object> predicate2 = default(Predicate<object>);
		Func<KeyValuePair<object, object>, object> func = default(Func<KeyValuePair<object, object>, object>);
		IEnumerable<KeyValuePair<object, object>> enumerable2 = default(IEnumerable<KeyValuePair<object, object>>);
		object obj49 = default(object);
		Func<KeyValuePair<object, object>, bool> func3 = default(Func<KeyValuePair<object, object>, bool>);
		object obj67 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		object obj84 = default(object);
		nint num3 = default(nint);
		while (true)
		{
			object obj4;
			if (false)
			{
				object obj17 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v64+12E]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v64+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0229;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v64+B0]");
				object obj18 = (nint)0 + (nint)8;
				bool flag5 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X10_v32-8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X10_v32-8]");
					object obj7 = 0 - obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X10_v32-8]");
					if (0 == (nint)obj11)
					{
						break;
					}
					obj8 = obj18 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v64+12E]");
					obj4 = -1;
					obj7 = obj4 - 1;
					bool flag4 = obj7 == null;
					flag3 = (nint)obj4 != 1;
					flag5 = flag3;
					obj18 = obj8;
					if (flag3)
					{
						continue;
					}
					goto IL_0229;
				}
				obj4 = obj18;
				object obj19 = obj17 + obj18;
				obj20 = obj19 + 312;
				flag3 = flag5;
				obj8 = obj18;
				goto IL_0f76;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj21 = (object)(&obj2);
			object obj22 = 0;
			nint num2 = (nint)predicate;
			break;
			IL_1189:
			obj = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v59+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v711 @ X0_v59] (should have been resolved before IL gen)");
			object obj24 = obj6;
			object obj25 = obj14;
			object obj26 = obj11;
			object obj27 = obj15;
			object obj28 = obj12;
			object obj29 = obj16;
			object obj30 = obj13;
			object obj31 = obj21;
			object obj33;
			object obj32 = obj33;
			IEnumerable<KeyValuePair<object, object>> enumerable = enumerable2;
			bool flag6 = flag3;
			object obj34 = obj8;
			object obj36;
			object obj35 = obj36;
			goto IL_10d5;
			IL_04a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X0_v82+E4]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X0_v82+E4]");
			bool flag7 = (nint)0 == 0;
			object obj37 = !flag7;
			object obj39;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj38 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v75+B8]");
				obj39 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			num3 = (nint)obj15;
			predicate2..ctor(obj39, (IntPtr)obj15);
			obj = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v4+B8]");
			object obj40 = (nint)0 + (nint)8;
			obj40 = predicate2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			enumerable2 = null;
			Predicate<object> predicate3 = predicate2;
			num2 = (nint)predicate2;
			goto IL_050d;
			IL_06ed:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			nint num4 = 0;
			goto IL_1189;
			IL_0a0e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X0_v27+E4]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X0_v27+E4]");
			bool flag8 = (nint)0 == 0;
			object obj41 = !flag8;
			object obj43;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj42 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v33+B8]");
				obj43 = 0;
			}
			object obj44 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3584;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj45 = (nint)0 + (nint)2056;
			func..ctor(obj43, (IntPtr)obj45);
			object obj46 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v32+B8]");
			object obj47 = (nint)0 + (nint)24;
			obj47 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			IEnumerable<KeyValuePair<object, object>> enumerable3;
			enumerable2 = enumerable3;
			Func<KeyValuePair<object, object>, object> selector = func;
			goto IL_12d4;
			IL_0229:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = 0;
			goto IL_0f76;
			IL_0f76:
			obj = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v70+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v551 @ X0_v70] (should have been resolved before IL gen)");
			object obj48 = obj49 & 1;
			if (obj48 != null)
			{
				if (false)
				{
					object obj50 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v67+12E]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v67+12E]");
					if ((nint)0 == 0)
					{
						goto IL_036f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v67+B0]");
					object obj51 = (nint)0 + (nint)8;
					bool flag9 = flag3;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X10_v27-8]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X10_v27-8]");
						object obj7 = 0 - obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X10_v27-8]");
						if (0 == (nint)obj12)
						{
							break;
						}
						obj8 = obj51 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v67+12E]");
						obj4 = -1;
						obj7 = obj4 - 1;
						bool flag4 = obj7 == null;
						flag3 = (nint)obj4 != 1;
						flag9 = flag3;
						obj51 = obj8;
						if (flag3)
						{
							continue;
						}
						goto IL_036f;
					}
					obj4 = obj51;
					object obj52 = obj50 + obj51;
					object obj53 = obj52 + 312;
					flag3 = flag9;
					obj8 = obj51;
					goto IL_1013;
				}
				NullReferenceException ex2 = new NullReferenceException();
				obj21 = (object)(&obj2);
				obj22 = 0;
				break;
			}
			bool flag10 = 0 == 0;
			obj21 = (object)(&obj2);
			obj22 = 0;
			obj33 = 5;
			object obj54 = 0;
			obj36 = 0;
			obj24 = obj6;
			obj25 = obj14;
			obj26 = obj11;
			obj27 = obj15;
			obj28 = obj12;
			obj29 = obj16;
			obj30 = obj13;
			obj31 = (object)(&obj2);
			obj22 = 0;
			obj32 = 5;
			enumerable = enumerable2;
			num4 = num3;
			flag6 = flag3;
			obj34 = obj8;
			obj35 = 0;
			if (!flag10)
			{
				goto IL_0625;
			}
			goto IL_10d5;
			IL_050d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v74+8]");
			if ((nint)0 != 0)
			{
				num3 = (nint)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v74+8]");
				int num5 = ((List<object>)0).RemoveAll(predicate3);
				predicate = predicate3;
				continue;
			}
			NullReferenceException ex3 = new NullReferenceException();
			obj21 = (object)(&obj2);
			obj22 = 0;
			break;
			IL_1218:
			object obj55 = (nint)0 + (nint)3168;
			Func<KeyValuePair<object, object>, bool> predicate4;
			IEnumerable<KeyValuePair<object, object>> enumerable4 = Enumerable.Where((IEnumerable<KeyValuePair<object, object>>)listeners, predicate4);
			object obj56 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X0_v27+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X0_v27+B8]");
				obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X8_v27+18]");
				selector = (Func<KeyValuePair<object, object>, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X8_v27+18]");
				bool flag11 = (nint)0 == 0;
				object obj57 = !flag11;
				enumerable2 = enumerable4;
				if (obj57 == null)
				{
					enumerable3 = enumerable4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X8_v27+18]");
					Func<KeyValuePair<object, object>, object> func2 = (Func<KeyValuePair<object, object>, object>)0;
					goto IL_0a0e;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj56 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X0_v27+B8]");
				obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X8_v27+18]");
				Func<KeyValuePair<object, object>, object> func2 = (Func<KeyValuePair<object, object>, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X8_v27+18]");
				bool flag12 = (nint)0 == 0;
				object obj58 = !flag12;
				enumerable3 = enumerable4;
				enumerable2 = enumerable4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X8_v27+18]");
				selector = (Func<KeyValuePair<object, object>, object>)0;
				if (obj58 == null)
				{
					goto IL_0a0e;
				}
			}
			goto IL_12d4;
			IL_08a3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X0_v37+E4]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X0_v37+E4]");
			bool flag13 = (nint)0 == 0;
			object obj59 = !flag13;
			object obj61;
			if (obj59 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj60 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X8_v44+B8]");
				obj61 = 0;
			}
			object obj62 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj63 = (nint)0 + (nint)2048;
			func3..ctor(obj61, (IntPtr)obj63);
			object obj64 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v43+B8]");
			object obj65 = (nint)0 + (nint)16;
			obj65 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate4 = func3;
			goto IL_1218;
			IL_10d5:
			while (true)
			{
				bool flag14 = obj35 == null;
				object obj66 = !flag14;
				obj6 = obj24;
				obj14 = obj25;
				obj11 = obj26;
				obj15 = obj27;
				obj12 = obj28;
				obj16 = obj29;
				obj13 = obj30;
				obj21 = obj31;
				enumerable2 = enumerable;
				num3 = num4;
				obj8 = obj34;
				if (obj66 != null)
				{
					OutOfMemoryException ex4 = new OutOfMemoryException();
					flag3 = num2 != 1;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
						obj36 = obj67;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
						bool flag15 = 0 == 0;
						object obj68 = !flag15;
						obj22 = obj67;
						obj33 = 0;
						obj54 = 0;
						if (obj68 == null)
						{
							obj24 = obj6;
							obj25 = obj14;
							obj26 = obj11;
							obj27 = obj15;
							obj28 = obj12;
							obj29 = obj16;
							obj30 = obj13;
							obj31 = obj21;
							obj22 = obj67;
							obj32 = 0;
							enumerable = enumerable2;
							num4 = num3;
							flag6 = flag3;
							obj34 = obj8;
							obj35 = obj67;
							continue;
						}
						goto IL_0625;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
					return;
				}
				break;
			}
			object obj69 = obj32 - 5;
			if ((nint)obj32 != 5)
			{
				bool flag16 = obj32 == null;
				object obj70 = !flag16;
				if (obj70 != null)
				{
					return;
				}
			}
			object obj71 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X0_v37+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X0_v37+B8]");
				obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v38+10]");
				predicate4 = (Func<KeyValuePair<object, object>, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v38+10]");
				bool flag17 = (nint)0 == 0;
				object obj72 = !flag17;
				if (obj72 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v38+10]");
					Func<KeyValuePair<object, object>, bool> func4 = (Func<KeyValuePair<object, object>, bool>)0;
					goto IL_08a3;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj71 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X0_v37+B8]");
				obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v38+10]");
				Func<KeyValuePair<object, object>, bool> func4 = (Func<KeyValuePair<object, object>, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v38+10]");
				bool flag18 = (nint)0 == 0;
				object obj73 = !flag18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v38+10]");
				predicate4 = (Func<KeyValuePair<object, object>, bool>)0;
				if (obj73 == null)
				{
					goto IL_08a3;
				}
			}
			goto IL_1218;
			IL_0625:
			object obj74 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj75 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v53+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v53+12E]");
			if ((nint)0 == 0)
			{
				goto IL_06ed;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v53+B0]");
			object obj76 = (nint)0 + (nint)8;
			bool flag19 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X10_v18-8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X10_v18-8]");
				if (0 == (nint)obj74)
				{
					break;
				}
				obj8 = obj76 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v53+12E]");
				obj4 = -1;
				flag3 = (nint)obj4 != 1;
				flag19 = flag3;
				obj76 = obj8;
				if (flag3)
				{
					continue;
				}
				goto IL_06ed;
			}
			obj4 = obj76;
			object obj77 = obj75 + obj76;
			obj23 = obj77 + 312;
			num4 = num3;
			flag3 = flag19;
			obj8 = obj76;
			goto IL_1189;
			IL_036f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = 0;
			goto IL_1013;
			IL_1013:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v821 @ X0_v74] (should have been resolved before IL gen)");
			object obj78 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X0_v82+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X0_v82+B8]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v4+8]");
				predicate3 = (Predicate<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v4+8]");
				bool flag20 = (nint)0 == 0;
				object obj79 = !flag20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v74+8]");
				num2 = 0;
				if (obj79 == null)
				{
					obj39 = obj;
					goto IL_04a6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj78 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X0_v82+B8]");
				obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X8_v73+8]");
				predicate3 = (Predicate<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X8_v73+8]");
				bool flag21 = (nint)0 == 0;
				object obj80 = !flag21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v74+8]");
				num2 = 0;
				obj = obj39;
				if (obj80 == null)
				{
					goto IL_04a6;
				}
			}
			goto IL_050d;
			IL_12d4:
			object obj81 = (nint)0 + (nint)2776;
			num3 = (nint)obj81;
			IEnumerable<object> source = Enumerable.Select(enumerable2, selector);
			obj = (nint)0 + (nint)2736;
			num2 = (nint)obj;
			List<object> list = Enumerable.ToList(source);
			bool flag22 = list == null;
			obj6 = obj24;
			obj14 = obj25;
			obj11 = obj26;
			obj15 = obj27;
			obj12 = obj28;
			obj16 = obj29;
			obj13 = obj30;
			obj21 = obj31;
			obj8 = obj34;
			if (flag22)
			{
				break;
			}
			List<object>.Enumerator enumerator = list.GetEnumerator();
			object obj82 = (nint)0 + (nint)1872;
			obj13 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2416;
			obj = (object)(&enumerator2);
			while (true)
			{
				num2 = (nint)obj82;
				if (enumerator2.MoveNext())
				{
					IDictionary<string, List<SfsResponseListener>> dictionary2 = listeners;
					if (listeners == null)
					{
						break;
					}
					nint num6 = (nint)dictionary2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v997 @ X8_v22 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v997 @ X8_v22 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v997 @ X8_v22 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Util.SfsRequestListener+SfsResponseListener>>>)+B0]");
						obj34 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X10_v9-8]");
							obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X10_v9-8]");
							obj69 = 0 - obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X10_v9-8]");
							if (0 == (nint)obj13)
							{
								break;
							}
							obj34 += 16;
							obj4--;
							obj69 = obj4 - 1;
							bool flag23 = obj69 == null;
							if ((nint)obj4 != 1)
							{
								continue;
							}
							goto IL_0ac5;
						}
						obj4 = obj34 + 6;
						object obj83 = num6 + obj4;
						obj84 = obj83 + 312;
						goto IL_0ad4;
					}
					goto IL_0ac5;
				}
				enumerator2.Dispose();
				return;
				IL_0ac5:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				goto IL_0ad4;
				IL_0ad4:
				obj = obj84;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X0_v22+8]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1051 @ X0_v22] (should have been resolved before IL gen)");
			}
			NullReferenceException ex5 = new NullReferenceException();
			obj6 = obj24;
			obj14 = obj25;
			obj11 = obj26;
			obj15 = obj27;
			obj12 = obj28;
			obj16 = obj29;
			obj21 = (object)(&enumerator2);
			obj22 = 0;
			obj8 = obj34;
			break;
		}
		goto IL_13ef;
		IL_13ef:
		throw new NullReferenceException();
		IL_0101:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num3 = 0;
		goto IL_0e97;
	}

	static SfsRequestListener()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SfsRequestListener sfsRequestListener = default(SfsRequestListener);
		sfsRequestListener..ctor();
		object obj2 = obj;
		object obj3 = sfsRequestListener;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
