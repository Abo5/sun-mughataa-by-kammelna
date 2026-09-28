using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

namespace Features.GameReplay;

public class RoundEvent
{
	private List<ReplayEvent> <ReplayEvents>k__BackingField;

	public List<ReplayEvent> ReplayEvents
	{
		get
		{
			return <ReplayEvents>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static List<RoundEvent> DeserializeObjects(IEnumerable<string> json)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0051: Expected I, but got O
		object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3616;
		object obj2 = (nint)0 + (nint)16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)null, (IntPtr)obj2);
		IEnumerable<object> source = Enumerable.Select(json, func);
		return (List<RoundEvent>)(object)Enumerable.ToList(source);
	}

	public RoundEvent()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 16;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
