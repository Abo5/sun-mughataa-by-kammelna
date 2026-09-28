using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class ClansFeedWidget : MonoBehaviour, IClanLandingWidget
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ClanFeedModel, int, ClansLandingFeedDataHolder> <>9__2_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1608;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal ClansLandingFeedDataHolder <Populate>b__2_0(ClanFeedModel model, int index)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 24;
			obj3 = model;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (ClansLandingFeedDataHolder)obj2;
		}
	}

	private ClansLandingFeedListView listView;

	private GameObject emptyPlaceHolder;

	public void Populate(ClanLandingResponseModel landing)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0138: Expected O, but got I
		//IL_0148: Expected O, but got I
		//IL_016a: Expected O, but got I4
		//IL_0078: Expected O, but got I
		//IL_0088: Expected O, but got I
		//IL_00aa: Expected O, but got I4
		//IL_019a: Expected O, but got I4
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_029f: Expected O, but got I
		//IL_02b0: Expected I, but got O
		//IL_02ce: Expected O, but got I
		//IL_01ca: Expected O, but got I
		object obj;
		object obj3;
		Func<object, int, object> selector;
		if (landing != null && landing.LandingFeed != null)
		{
			obj = typeof(CardUtils.<>c) + 1608;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v18+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v18+B8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v18+8]");
				selector = (Func<object, int, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v18+8]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					goto IL_0178;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v18+B8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v18+8]");
				selector = (Func<object, int, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v18+8]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					goto IL_0178;
				}
			}
			goto IL_01cf;
		}
		object obj6 = typeof(List<AdaptivePerformanceScaler>) + 584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		listView.data = (List<ClansLandingFeedDataHolder>)(object)list;
		GameObject gameObject = emptyPlaceHolder;
		bool active = true;
		goto IL_0267;
		IL_0267:
		gameObject.SetActive(active);
		return;
		IL_01cf:
		IEnumerable<object> source = Enumerable.Select(landing.LandingFeed, selector);
		List<object> data = Enumerable.ToList(source);
		listView.data = (List<ClansLandingFeedDataHolder>)(object)data;
		List<ClanFeedModel> landingFeed = landing.LandingFeed;
		gameObject = emptyPlaceHolder;
		bool flag3 = landingFeed._size == 0;
		active = flag3;
		goto IL_0267;
		IL_0178:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v24+B8]");
			obj3 = 0;
		}
		object obj9 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)872;
		Func<object, int, object> func = default(Func<object, int, object>);
		func..ctor(obj3, (IntPtr)obj10);
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v23+B8]");
		object obj12 = (nint)0 + (nint)8;
		obj12 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func;
		goto IL_01cf;
	}
}
