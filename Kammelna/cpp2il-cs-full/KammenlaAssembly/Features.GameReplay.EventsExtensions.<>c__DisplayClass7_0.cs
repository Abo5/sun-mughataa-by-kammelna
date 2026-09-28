using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using GoogleMobileAds.Ump.Api;
using HuaweiMobileServices.Location.Location;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Rendering;

namespace Features.GameReplay;

internal static class EventsExtensions
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ReplayEvent, ReplayEventsTypes, <>f__AnonymousType1<ReplayEvent, ReplayEventsTypes>> <>9__5_1;

		public static Func<<>f__AnonymousType1<ReplayEvent, ReplayEventsTypes>, bool> <>9__5_2;

		public static Func<<>f__AnonymousType1<ReplayEvent, ReplayEventsTypes>, ReplayEvent> <>9__5_3;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 1776;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal <>f__AnonymousType1<ReplayEvent, ReplayEventsTypes> <GetReplayEvents>b__5_1(ReplayEvent replayEvent, ReplayEventsTypes replayEventEnum)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 64;
			object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 2544;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FD4F6C");
			<>f__AnonymousType1<ReplayEvent, ReplayEventsTypes> result = default(<>f__AnonymousType1<ReplayEvent, ReplayEventsTypes>);
			return result;
		}

		internal bool <GetReplayEvents>b__5_2(<>f__AnonymousType1<ReplayEvent, ReplayEventsTypes> <>h__TransparentIdentifier0)
		{
			//IL_0079: Expected I4, but got O
			//IL_0015: Expected O, but got I
			//IL_0057: Expected O, but got I
			if (<>h__TransparentIdentifier0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>h__TransparentIdentifier0 @ X1 (<>f__AnonymousType1`2<Features.GameReplay.ReplayEvent, Features.GameReplay.ReplayEventsTypes>)+10]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>h__TransparentIdentifier0 @ X1 (<>f__AnonymousType1`2<Features.GameReplay.ReplayEvent, Features.GameReplay.ReplayEventsTypes>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+14]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>h__TransparentIdentifier0 @ X1 (<>f__AnonymousType1`2<Features.GameReplay.ReplayEvent, Features.GameReplay.ReplayEventsTypes>)+18]");
					object obj2 = num - 0;
					return obj2 == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal ReplayEvent <GetReplayEvents>b__5_3(<>f__AnonymousType1<ReplayEvent, ReplayEventsTypes> <>h__TransparentIdentifier0)
		{
			//IL_0012: Expected O, but got I
			if (<>h__TransparentIdentifier0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>h__TransparentIdentifier0 @ X1 (<>f__AnonymousType1`2<Features.GameReplay.ReplayEvent, Features.GameReplay.ReplayEventsTypes>)+10]");
				return (ReplayEvent)0;
			}
			return (ReplayEvent)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass1_0
	{
		public ReplayEventsTypes replayEventType;

		internal bool <GetFirstReplayEvent>b__0(ReplayEvent replayEvent)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (replayEvent != null)
			{
				object obj = replayEvent.<ReplayEventType>k__BackingField - replayEventType;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public ReplayEventsTypes replayEventType;

		internal bool <GetLastReplayEvent>b__0(ReplayEvent replayEvent)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (replayEvent != null)
			{
				object obj = replayEvent.<ReplayEventType>k__BackingField - replayEventType;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public ReplayEventsTypes[] replayEventsTypes;

		internal IEnumerable<ReplayEventsTypes> <GetReplayEvents>b__0(ReplayEvent replayEvent)
		{
			return replayEventsTypes;
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public ReplayEventsTypes replayEventType;

		internal bool <GetReplayEvents>b__0(ReplayEvent replayEvent)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (replayEvent != null)
			{
				object obj = replayEvent.<ReplayEventType>k__BackingField - replayEventType;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public static ReplayEvent GetFirstReplayEvent(RoundEvent roundEvent, ReplayEventsTypes replayEventType)
	{
		if (roundEvent != null)
		{
			return GetFirstReplayEvent(roundEvent.<ReplayEvents>k__BackingField, replayEventType);
		}
		return (ReplayEvent)(object)new NullReferenceException();
	}

	public static ReplayEvent GetFirstReplayEvent(List<ReplayEvent> replayEvents, ReplayEventsTypes replayEventType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005a: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 1784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3096;
			object obj4 = (nint)0 + (nint)3168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return (ReplayEvent)Enumerable.FirstOrDefault(replayEvents, func);
		}
		return (ReplayEvent)(object)new NullReferenceException();
	}

	public static ReplayEvent GetLastReplayEvent(RoundEvent roundEvent, ReplayEventsTypes replayEventType)
	{
		if (roundEvent != null)
		{
			return GetLastReplayEvent(roundEvent.<ReplayEvents>k__BackingField, replayEventType);
		}
		return (ReplayEvent)(object)new NullReferenceException();
	}

	public static ReplayEvent GetLastReplayEvent(List<ReplayEvent> replayEvents, ReplayEventsTypes replayEventType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0065: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 1792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3096;
			object obj4 = (nint)0 + (nint)3176;
			object obj5 = (nint)0 + (nint)1832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC96CC");
			ReplayEvent result = default(ReplayEvent);
			return result;
		}
		return (ReplayEvent)(object)new NullReferenceException();
	}

	public static void GetReplayEvents(RoundEvent roundEvent, List<ReplayEvent> replayEventsToReturn, ReplayEventsTypes[] replayEventsTypes)
	{
		GetReplayEvents(roundEvent.<ReplayEvents>k__BackingField, replayEventsToReturn, replayEventsTypes);
	}

	public static void GetReplayEvents(List<ReplayEvent> replayEvents, List<ReplayEvent> replayEventsToReturn, ReplayEventsTypes[] replayEventsTypes)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_008d: Expected I, but got O
		//IL_0141: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0161: Expected O, but got I
		//IL_0183: Expected O, but got I4
		//IL_00c6: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_00e6: Expected O, but got I
		//IL_0108: Expected O, but got I4
		//IL_02c1: Expected O, but got I
		//IL_02d1: Expected O, but got I
		//IL_02e1: Expected O, but got I
		//IL_0303: Expected O, but got I4
		//IL_01bb: Expected O, but got I4
		//IL_0246: Expected O, but got I
		//IL_0256: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_0288: Expected O, but got I4
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_0557: Expected O, but got I
		//IL_0568: Expected I, but got O
		//IL_0586: Expected O, but got I
		//IL_043d: Expected O, but got I
		//IL_044d: Expected O, but got I
		//IL_046f: Expected O, but got I4
		//IL_033b: Expected O, but got I4
		//IL_01eb: Expected O, but got I
		//IL_03bf: Expected O, but got I
		//IL_03cf: Expected O, but got I
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected O, but got Unknown
		//IL_05d7: Expected O, but got I
		//IL_05e8: Expected I, but got O
		//IL_0606: Expected O, but got I
		//IL_0621: Expected O, but got I4
		//IL_04a0: Expected O, but got I4
		//IL_036b: Expected O, but got I
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected O, but got Unknown
		//IL_0660: Expected O, but got I
		//IL_0671: Expected I, but got O
		//IL_068f: Expected O, but got I
		//IL_0500: Expected O, but got I4
		//IL_04d0: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 1800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3088;
		object obj4 = (nint)0 + (nint)3184;
		object obj5 = typeof(DebugUI.BitField) + 1776;
		object obj6 = obj2 + 16;
		obj6 = replayEventsTypes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v47+E4]");
		object obj8;
		object obj9;
		Func<object, System.Int32Enum, object> resultSelector;
		object obj11;
		if ((nint)0 != 0)
		{
			obj8 = (nint)0 + (nint)432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v47+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v36+8]");
			resultSelector = (Func<object, System.Int32Enum, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v36+8]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			if (obj10 == null)
			{
				obj11 = obj8;
				goto IL_0199;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj5;
			obj11 = (nint)0 + (nint)432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v47+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v36+8]");
			resultSelector = (Func<object, System.Int32Enum, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v36+8]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			obj8 = obj11;
			if (obj12 == null)
			{
				goto IL_0199;
			}
		}
		goto IL_01f0;
		IL_040b:
		IEnumerable<object> collection;
		((List<object>)(object)replayEventsToReturn).AddRange(collection);
		return;
		IL_01f0:
		object obj13 = obj8;
		IEnumerable<object> source = Enumerable.SelectMany(replayEvents, (Func<object, IEnumerable<System.Int32Enum>>)func, resultSelector);
		object obj14 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v37+E4]");
		object obj16;
		Func<object, bool> predicate;
		object obj18;
		object obj15;
		if ((nint)0 != 0)
		{
			obj15 = (nint)0 + (nint)3064;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v37+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v25+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v25+10]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				obj18 = obj15;
				goto IL_0319;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj5;
			obj18 = (nint)0 + (nint)3064;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v37+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v25+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v25+10]");
			bool flag4 = (nint)0 == 0;
			object obj19 = !flag4;
			obj15 = obj18;
			if (obj19 == null)
			{
				goto IL_0319;
			}
		}
		goto IL_0370;
		IL_03f5:
		IEnumerable<object> source2;
		Func<object, object> selector;
		collection = Enumerable.Select(source2, selector);
		goto IL_040b;
		IL_0199:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v47+E4]");
		bool flag5 = (nint)0 == 0;
		object obj20 = !flag5;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj21 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v42+B8]");
			obj9 = 0;
		}
		object obj22 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)3144;
		Func<object, System.Int32Enum, object> func2 = default(Func<object, System.Int32Enum, object>);
		func2..ctor(obj9, (IntPtr)obj23);
		object obj24 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v41+B8]");
		object obj25 = (nint)0 + (nint)8;
		obj25 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj8 = obj11;
		resultSelector = func2;
		goto IL_01f0;
		IL_0319:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v37+E4]");
		bool flag6 = (nint)0 == 0;
		object obj26 = !flag6;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj27 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v31+B8]");
			obj16 = 0;
		}
		object obj28 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = (nint)0 + (nint)3152;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj16, (IntPtr)obj29);
		object obj30 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v30+B8]");
		object obj31 = (nint)0 + (nint)16;
		obj31 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj13 = 0;
		obj15 = obj18;
		predicate = func3;
		goto IL_0370;
		IL_0370:
		source2 = Enumerable.Where(source, predicate);
		object obj32 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v20+E4]");
		object obj33;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v20+B8]");
			obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v10+18]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v10+18]");
			if ((nint)0 != 0)
			{
				goto IL_03f5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj32 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v20+B8]");
			obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v10+18]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v10+18]");
			bool flag7 = (nint)0 == 0;
			object obj34 = !flag7;
			if (obj34 != null)
			{
				goto IL_03f5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v20+E4]");
		bool flag8 = (nint)0 == 0;
		object obj35 = !flag8;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj36 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v16+B8]");
			obj33 = 0;
		}
		object obj37 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj38 = (nint)0 + (nint)3160;
		Func<object, object> func4 = default(Func<object, object>);
		func4..ctor(obj33, (IntPtr)obj38);
		object obj39 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v15+B8]");
		object obj40 = (nint)0 + (nint)24;
		obj40 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		collection = Enumerable.Select(source2, func4);
		bool flag9 = replayEventsToReturn == null;
		object obj41 = !flag9;
		if (obj41 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_040b;
	}

	public static List<ReplayEvent> GetReplayEvents(RoundEvent roundEvent, ReplayEventsTypes replayEventType)
	{
		if (roundEvent != null)
		{
			return GetReplayEvents(roundEvent.<ReplayEvents>k__BackingField, replayEventType);
		}
		return (List<ReplayEvent>)(object)new NullReferenceException();
	}

	public static List<ReplayEvent> GetReplayEvents(List<ReplayEvent> replayEvents, ReplayEventsTypes replayEventType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005b: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 1808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3096;
			object obj4 = (nint)0 + (nint)3192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			IEnumerable<object> source = Enumerable.Where(replayEvents, func);
			return (List<ReplayEvent>)(object)Enumerable.ToList(source);
		}
		return (List<ReplayEvent>)(object)new NullReferenceException();
	}

	public static List<ReplayEvent> GetReplayEventsRange(RoundEvent roundEvent, ReplayEvent startEvent, ReplayEvent endEvent)
	{
		//IL_0016: Expected O, but got I
		//IL_00af: Expected O, but got I
		//IL_00c9: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_0049: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81D9]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81DF]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81DF]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		if (roundEvent != null)
		{
			goto IL_00fa;
		}
		goto IL_01a0;
		IL_01a0:
		return (List<ReplayEvent>)(object)new NullReferenceException();
		IL_00fa:
		if (roundEvent.<ReplayEvents>k__BackingField != null)
		{
			int num = ((List<object>)(object)roundEvent.<ReplayEvents>k__BackingField).IndexOf((object)startEvent);
			if (roundEvent.<ReplayEvents>k__BackingField != null)
			{
				int num2 = ((List<object>)(object)roundEvent.<ReplayEvents>k__BackingField).IndexOf((object)endEvent);
				if (roundEvent.<ReplayEvents>k__BackingField != null)
				{
					int count = num2 - num;
					List<object> range = ((List<object>)(object)roundEvent.<ReplayEvents>k__BackingField).GetRange(num, count);
					List<object> source = Enumerable.ToList(range);
					return (List<ReplayEvent>)(object)Enumerable.ToList(source);
				}
			}
		}
		goto IL_01a0;
		IL_0066:
		bool flag2 = roundEvent == null;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			goto IL_00fa;
		}
		goto IL_01a0;
	}

	public static List<ReplayEvent> GetReplayEventsRange(RoundEvent roundEvent, int start, int count)
	{
		if (roundEvent != null && roundEvent.<ReplayEvents>k__BackingField != null)
		{
			int index = default(int);
			int count2 = default(int);
			List<object> range = ((List<object>)(object)roundEvent.<ReplayEvents>k__BackingField).GetRange(index, count2);
			return (List<ReplayEvent>)(object)Enumerable.ToList(range);
		}
		return (List<ReplayEvent>)(object)new NullReferenceException();
	}

	public static ReplayEvent GetFirstReplayEventAfter(List<ReplayEvent> replayEvents, int index, ReplayEventsTypes replayEventType)
	{
		int count = default(int);
		IEnumerable<object> source = Enumerable.Skip((IEnumerable<object>)replayEvents, count);
		List<object> replayEvents2 = Enumerable.ToList(source);
		return GetFirstReplayEvent((List<ReplayEvent>)(object)replayEvents2, replayEventType);
	}

	public static List<ReplayEvent> GetReplayEventsAfter(RoundEvent roundEvent, ReplayEvent replayEvent)
	{
		//IL_0016: Expected O, but got I
		//IL_00af: Expected O, but got I
		//IL_00c9: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_0049: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81DB]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81DF]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81DF]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		if (roundEvent != null)
		{
			goto IL_00fa;
		}
		goto IL_013f;
		IL_013f:
		return (List<ReplayEvent>)(object)new NullReferenceException();
		IL_00fa:
		if (roundEvent.<ReplayEvents>k__BackingField != null)
		{
			int count = ((List<object>)(object)roundEvent.<ReplayEvents>k__BackingField).IndexOf((object)replayEvent);
			IEnumerable<object> source = Enumerable.Skip((IEnumerable<object>)roundEvent.<ReplayEvents>k__BackingField, count);
			List<object> source2 = Enumerable.ToList(source);
			return (List<ReplayEvent>)(object)Enumerable.ToList(source2);
		}
		goto IL_013f;
		IL_0066:
		bool flag2 = roundEvent == null;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			goto IL_00fa;
		}
		goto IL_013f;
	}

	public static List<ReplayEvent> GetReplayEventsAfter(RoundEvent roundEvent, int index)
	{
		if (roundEvent != null)
		{
			int count = default(int);
			IEnumerable<object> source = Enumerable.Skip((IEnumerable<object>)roundEvent.<ReplayEvents>k__BackingField, count);
			return (List<ReplayEvent>)(object)Enumerable.ToList(source);
		}
		return (List<ReplayEvent>)(object)new NullReferenceException();
	}

	public static List<ReplayEvent> GetReplayEventsAfter(List<ReplayEvent> replayEvents, int index)
	{
		int count = default(int);
		IEnumerable<object> source = Enumerable.Skip((IEnumerable<object>)replayEvents, count);
		return (List<ReplayEvent>)(object)Enumerable.ToList(source);
	}

	public static List<ReplayEvent> GetReplayEventsBefore(RoundEvent roundEvent, ReplayEvent replayEvent)
	{
		//IL_0016: Expected O, but got I
		//IL_00af: Expected O, but got I
		//IL_00c9: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_0049: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81DD]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81DF]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81DF]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		if (roundEvent != null)
		{
			goto IL_00fa;
		}
		goto IL_013f;
		IL_013f:
		return (List<ReplayEvent>)(object)new NullReferenceException();
		IL_00fa:
		if (roundEvent.<ReplayEvents>k__BackingField != null)
		{
			int count = ((List<object>)(object)roundEvent.<ReplayEvents>k__BackingField).IndexOf((object)replayEvent);
			IEnumerable<object> source = Enumerable.Take((IEnumerable<object>)roundEvent.<ReplayEvents>k__BackingField, count);
			List<object> source2 = Enumerable.ToList(source);
			return (List<ReplayEvent>)(object)Enumerable.ToList(source2);
		}
		goto IL_013f;
		IL_0066:
		bool flag2 = roundEvent == null;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			goto IL_00fa;
		}
		goto IL_013f;
	}

	public static List<ReplayEvent> GetReplayEventsBefore(RoundEvent roundEvent, int index)
	{
		if (roundEvent != null)
		{
			int count = default(int);
			IEnumerable<object> source = Enumerable.Take((IEnumerable<object>)roundEvent.<ReplayEvents>k__BackingField, count);
			return (List<ReplayEvent>)(object)Enumerable.ToList(source);
		}
		return (List<ReplayEvent>)(object)new NullReferenceException();
	}

	public static int IndexOf(RoundEvent roundEvent, ReplayEvent replayEvent)
	{
		//IL_0051: Expected I4, but got O
		if (roundEvent != null && roundEvent.<ReplayEvents>k__BackingField != null)
		{
			return ((List<object>)(object)roundEvent.<ReplayEvents>k__BackingField).IndexOf((object)replayEvent);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static bool IsA(ReplayEvent replayEvent, ReplayEventsTypes replayEventType)
	{
		//IL_0051: Expected I4, but got O
		//IL_002f: Expected O, but got I4
		if (replayEvent != null)
		{
			object obj = replayEvent.<ReplayEventType>k__BackingField - replayEventType;
			return obj == null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool IsOneOf(ReplayEvent replayEvent, ReplayEventsTypes[] replayEventsTypes)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0046: Expected I, but got O
		object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3112;
		object obj2 = (nint)0 + (nint)328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<System.Int32Enum, bool> func = default(Func<System.Int32Enum, bool>);
		func..ctor((object)replayEvent, (IntPtr)obj2);
		return Enumerable.Any((IEnumerable<System.Int32Enum>)(object)replayEventsTypes, func);
	}

	public static bool RemoveReplayEvent(RoundEvent roundEvent, ReplayEvent replayEvent)
	{
		//IL_0051: Expected I4, but got O
		if (roundEvent != null && roundEvent.<ReplayEvents>k__BackingField != null)
		{
			return ((List<object>)(object)roundEvent.<ReplayEvents>k__BackingField).Remove((object)replayEvent);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static int ToDuration(CommentDuration commentDuration)
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
		bool flag = commentDuration < (CommentDuration)4;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = 119877632 + 1376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X8_v2+commentDuration @ X0 (Features.GameReplay.CommentDuration)*4]");
			return 0;
		}
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = "com.unity.services.authentication.profile" + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj6 = (nint)0 + (nint)336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (int)ex2;
	}
}
