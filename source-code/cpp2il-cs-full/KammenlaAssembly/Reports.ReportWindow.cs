using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using Kammelna.Server;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using Unity.Properties;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class Reports : MonoBehaviour, IInitializable
{
	private enum ReportType
	{
		Categories,
		Subscription,
		Game,
		Membership,
		Suggestions,
		WebOrders
	}

	private class ReportWindow
	{
		private readonly PopupUI popup;

		private readonly ReportType <reportType>k__BackingField;

		public ReportType reportType => <reportType>k__BackingField;

		public GameObject gameObject
		{
			get
			{
				if ((object)popup != null)
				{
					return popup.gameObject;
				}
				return (GameObject)(object)new NullReferenceException();
			}
		}

		public bool IsCurrentlyShown
		{
			get
			{
				//IL_0041: Expected I4, but got O
				PopupUI popupUI = popup;
				if ((object)popup != null)
				{
					return popupUI.<IsCurrentlyShown>k__BackingField;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}

		public ReportWindow(PopupUI popup, ReportType reportType)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			object obj = this + 16;
			obj = popup;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		public void Show()
		{
			//IL_002e: Expected O, but got I4
			//IL_00d1: Expected O, but got I4
			PopupUI popupUI = popup;
			bool flag = !popupUI.<IsCurrentlyShown>k__BackingField;
			object obj = !flag;
			if (obj != null)
			{
				return;
			}
			PopupUI popupUI2;
			if (<reportType>k__BackingField != ReportType.Categories)
			{
				TransitionExtension.RectSlideFromLeft(popupUI.content, popupUI.animationSpeed);
				popupUI2 = popup;
			}
			else
			{
				TransitionExtension.RectSlideFromRight(popupUI.content, popupUI.animationSpeed);
				popupUI2 = popup;
				bool flag2 = (object)popup == null;
				object obj2 = !flag2;
				if (obj2 == null)
				{
					throw new NullReferenceException();
				}
			}
			popupUI2.<IsCurrentlyShown>k__BackingField = true;
		}

		public void Hide()
		{
			//IL_0066: Expected O, but got I4
			PopupUI popupUI = popup;
			PopupUI popupUI2;
			if (<reportType>k__BackingField != ReportType.Categories)
			{
				TransitionExtension.RectSlideToLeft(popupUI.content, popupUI.animationSpeed);
				popupUI2 = popup;
				bool flag = (object)popup == null;
				object obj = !flag;
				if (obj == null)
				{
					throw new NullReferenceException();
				}
			}
			else
			{
				TransitionExtension.RectSlideToRight(popupUI.content, popupUI.animationSpeed);
				popupUI2 = popup;
			}
			popupUI2.<IsCurrentlyShown>k__BackingField = false;
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ReportWindow, bool> <>9__14_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 856;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_AnyVisible>b__14_0(ReportWindow window)
		{
			//IL_0064: Expected I4, but got O
			if (window != null)
			{
				PopupUI popup = window.popup;
				if ((object)window.popup != null)
				{
					return popup.<IsCurrentlyShown>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public ReportType reportType;

		internal bool <GetPopup>b__0(ReportWindow popup)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (popup != null)
			{
				object obj = popup.<reportType>k__BackingField - reportType;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public PopupUI ReportCategories;

	public PopupUI ReportSuggestions;

	public PopupUI ReportGame;

	public PopupUI MembershipProblems;

	public PopupUI ReportSubscription;

	public PopupUI ReportWebOrders;

	public Button CancelButton;

	private DatePickerManager pickerManager;

	private readonly List<ReportWindow> reports;

	private ReportWindow currentReport;

	private static bool TabletView => ScreenUtility.IsTablet;

	private bool AnyVisible
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_00a5: Expected O, but got I
			//IL_00b5: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01aa: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0289: Expected O, but got I
			//IL_029a: Expected I, but got O
			//IL_02b8: Expected O, but got I
			//IL_0244: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 856;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E797F]");
			object obj3 = (nint)0 & (nint)1;
			List<ReportWindow> list;
			List<ReportWindow> list2;
			object obj4;
			if (obj3 != null)
			{
				list = reports;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				list2 = reports;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				list = reports;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				list2 = reports;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)2944;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			IEnumerable<object> enumerable = list2;
			object obj10 = obj7;
			IEnumerable<object> source = list2;
			if (obj9 == null)
			{
				goto IL_01f2;
			}
			goto IL_0249;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)3960;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj7;
			predicate = func;
			source = enumerable;
			goto IL_0249;
			IL_0249:
			return Enumerable.Any(source, predicate);
			IL_0099:
			obj10 = (nint)0 + (nint)2944;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			source = list;
			if (obj17 == null)
			{
				obj7 = obj10;
				enumerable = list;
				goto IL_01f2;
			}
			goto IL_0249;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected O, but got Unknown
		//IL_0030: Expected O, but got I
		//IL_008a: Expected O, but got I4
		//IL_0107: Expected O, but got I
		//IL_0117: Expected O, but got I
		//IL_0127: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_01ea: Expected O, but got I4
		//IL_0267: Expected O, but got I
		//IL_0277: Expected O, but got I
		//IL_0287: Expected O, but got I
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_034a: Expected O, but got I4
		//IL_03c7: Expected O, but got I
		//IL_03d7: Expected O, but got I
		//IL_03e7: Expected O, but got I
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		//IL_04aa: Expected O, but got I4
		//IL_0527: Expected O, but got I
		//IL_0537: Expected O, but got I
		//IL_0547: Expected O, but got I
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected O, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected O, but got Unknown
		//IL_060a: Expected O, but got I4
		//IL_0687: Expected O, but got I
		//IL_0697: Expected O, but got I
		//IL_06a7: Expected O, but got I
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected O, but got Unknown
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected O, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected O, but got Unknown
		//IL_076a: Expected O, but got I4
		//IL_080d: Expected O, but got I
		//IL_081d: Expected O, but got I
		//IL_082d: Expected O, but got I
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected O, but got Unknown
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected O, but got Unknown
		//IL_07ee: Expected O, but got I4
		//IL_0883: Expected O, but got I4
		//IL_08a5: Expected O, but got I4
		//IL_08c7: Expected O, but got I4
		//IL_08e9: Expected O, but got I4
		//IL_090b: Expected O, but got I4
		//IL_092d: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 872;
		List<object> list = (List<object>)(object)reports;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = ReportCategories;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		object obj4 = (nint)0 + (nint)3984;
		object obj5 = obj4;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v55+C0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v56+70]");
			object obj12 = 0;
			list.AddWithResize(obj2);
			object obj9 = obj2;
		}
		List<object> list2 = (List<object>)(object)reports;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = default(object);
		obj13..ctor();
		object obj14 = obj13 + 16;
		obj14 = ReportSubscription;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 1;
		object obj15 = obj4;
		int version2 = list2._version + 1;
		list2._version = version2;
		object[] items2 = list2._items;
		bool flag2 = list2._size < items2.Length;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			int size2 = list2._size + 1;
			list2._size = size2;
			object obj17 = items2 + list2._size;
			object obj18 = obj17 + 32;
			obj18 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj19 = obj13;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v7+20]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v52+C0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v53+70]");
			object obj12 = 0;
			list2.AddWithResize(obj13);
			object obj19 = obj13;
		}
		List<object> list3 = (List<object>)(object)reports;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = default(object);
		obj22..ctor();
		object obj23 = obj22 + 16;
		obj23 = ReportGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 2;
		object obj24 = obj4;
		int version3 = list3._version + 1;
		list3._version = version3;
		object[] items3 = list3._items;
		bool flag3 = list3._size < items3.Length;
		object obj25 = !flag3;
		if (obj25 == null)
		{
			int size3 = list3._size + 1;
			list3._size = size3;
			object obj26 = items3 + list3._size;
			object obj27 = obj26 + 32;
			obj27 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj28 = obj22;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v10+20]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v49+C0]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v50+70]");
			object obj12 = 0;
			list3.AddWithResize(obj22);
			object obj28 = obj22;
		}
		List<object> list4 = (List<object>)(object)reports;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj31 = default(object);
		obj31..ctor();
		object obj32 = obj31 + 16;
		obj32 = MembershipProblems;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 3;
		object obj33 = obj4;
		int version4 = list4._version + 1;
		list4._version = version4;
		object[] items4 = list4._items;
		bool flag4 = list4._size < items4.Length;
		object obj34 = !flag4;
		if (obj34 == null)
		{
			int size4 = list4._size + 1;
			list4._size = size4;
			object obj35 = items4 + list4._size;
			object obj36 = obj35 + 32;
			obj36 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj37 = obj31;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v13+20]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v46+C0]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v47+70]");
			object obj12 = 0;
			list4.AddWithResize(obj31);
			object obj37 = obj31;
		}
		List<object> list5 = (List<object>)(object)reports;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj40 = default(object);
		obj40..ctor();
		object obj41 = obj40 + 16;
		obj41 = ReportSuggestions;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 4;
		object obj42 = obj4;
		int version5 = list5._version + 1;
		list5._version = version5;
		object[] items5 = list5._items;
		bool flag5 = list5._size < items5.Length;
		object obj43 = !flag5;
		if (obj43 == null)
		{
			int size5 = list5._size + 1;
			list5._size = size5;
			object obj44 = items5 + list5._size;
			object obj45 = obj44 + 32;
			obj45 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj46 = obj40;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v16+20]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v43+C0]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v44+70]");
			object obj12 = 0;
			list5.AddWithResize(obj40);
			object obj46 = obj40;
		}
		List<object> list6 = (List<object>)(object)reports;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj49 = default(object);
		obj49..ctor();
		object obj50 = obj49 + 16;
		obj50 = ReportWebOrders;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 5;
		object obj51 = obj4;
		int version6 = list6._version + 1;
		list6._version = version6;
		object[] items6 = list6._items;
		bool flag6 = list6._size < items6.Length;
		object obj52 = !flag6;
		if (obj52 == null)
		{
			int size6 = list6._size + 1;
			list6._size = size6;
			object obj53 = items6 + list6._size;
			object obj54 = obj53 + 32;
			obj54 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool isTablet = ScreenUtility.IsTablet;
			bool flag7 = !isTablet;
			object obj55 = !flag7;
			if (obj55 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v19+20]");
			object obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v39+C0]");
			object obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v40+70]");
			object obj12 = 0;
			list6.AddWithResize(obj49);
			if (!ScreenUtility.IsTablet)
			{
				return;
			}
		}
		PopupUI reportCategories = ReportCategories;
		reportCategories.content.pivot = (Vector2)0;
		PopupUI reportSubscription = ReportSubscription;
		reportSubscription.content.pivot = (Vector2)0;
		PopupUI reportGame = ReportGame;
		reportGame.content.pivot = (Vector2)0;
		PopupUI membershipProblems = MembershipProblems;
		membershipProblems.content.pivot = (Vector2)0;
		PopupUI reportSuggestions = ReportSuggestions;
		reportSuggestions.content.pivot = (Vector2)0;
		PopupUI reportWebOrders = ReportWebOrders;
		reportWebOrders.content.pivot = (Vector2)0;
	}

	private ReportWindow GetPopup(ReportType reportType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0059: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(List<Tween>) + 3752;
			object obj4 = (nint)0 + (nint)3968;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor(obj2, (IntPtr)obj4);
			if (reports != null)
			{
				return (ReportWindow)((List<object>)(object)reports).Find(predicate);
			}
		}
		return (ReportWindow)(object)new NullReferenceException();
	}

	public void Initialize()
	{
		Show();
	}

	public void Show()
	{
		//IL_03f0: Expected O, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0038: Expected O, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00aa: Expected O, but got I
		//IL_00b8: Expected I, but got O
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0140: Expected O, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0190: Expected O, but got I4
		//IL_01b9: Expected O, but got I
		//IL_021c: Expected O, but got I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0276: Expected I, but got O
		//IL_0286: Expected O, but got I
		//IL_032e: Expected O, but got I4
		//IL_02c1: Expected O, but got I
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_03a5: Expected O, but got I4
		//IL_03ae: Expected O, but got I4
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		bool anyVisible = AnyVisible;
		ReportWindow popup = GetPopup(ReportType.Categories);
		bool flag = !anyVisible;
		object obj = !flag;
		ReportWindow report = popup;
		object obj22;
		if (obj == null)
		{
			object obj2 = this + 104;
			obj2 = popup;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X20_v6-48]");
			((PopupUI)0).SlideFromBottom();
			PopupUI reportCategories = ReportCategories;
			reportCategories.enableBlur = false;
			ReportWindow popup2 = GetPopup(ReportType.Categories);
			GameObject popup3 = popup2.popup.gameObject;
			object obj3 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = (nint)0 + (nint)736;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj4);
			object obj5 = typeof(RegisteredWaitHandle) + 3136;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ScreenManager.PushPopup(popup3, action);
			object action2 = "October" + 1128;
			object type = (nint)0 + (nint)2000;
			FirebaseTrack.Event((string)action2, (string)type);
			object obj8 = typeof(Queue<string>) + 848;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v23+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			Room currentRoom = sessionModel.CurrentRoom;
			if (currentRoom == null)
			{
				return;
			}
			object obj12 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v29+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			Room currentRoom2 = sessionModel2.CurrentRoom;
			object obj14 = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)currentRoom2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0302;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj16 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X10_v7-8]");
				if (0 == (nint)obj14)
				{
					break;
				}
				obj16 += 16;
				obj15--;
				if ((nint)obj15 != 1)
				{
					continue;
				}
				goto IL_0302;
			}
			object obj17 = obj16 + 6;
			object obj18 = num + obj17;
			object obj19 = obj18 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v289 @ X8_v26] (should have been resolved before IL gen)");
			object obj20 = default(object);
			bool flag5 = obj20 == null;
			object obj21 = !flag5;
			obj22 = 0;
			if (obj21 == null)
			{
				return;
			}
			goto IL_033c;
		}
		goto IL_0406;
		IL_0302:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v316 @ X0_v37] (should have been resolved before IL gen)");
		object obj23 = default(object);
		bool flag6 = obj23 == null;
		obj22 = 6;
		if (!flag6)
		{
			goto IL_033c;
		}
		return;
		IL_0406:
		ShowReport(report);
		return;
		IL_033c:
		ReportWindow popup4 = GetPopup(ReportType.Game);
		report = popup4;
		goto IL_0406;
	}

	public void Close()
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0087: Expected O, but got I4
		ReportWindow popup = GetPopup(ReportType.Categories);
		if (currentReport != popup)
		{
			if (AnyVisible)
			{
				ReportWindow reportWindow = currentReport;
				GameObject go = reportWindow.popup.gameObject;
				object obj = typeof(RegisteredWaitHandle) + 3136;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				ScreenManager.RemovePopup(go);
				ReportWindow popup2 = GetPopup(ReportType.Categories);
				ShowReport(popup2);
			}
		}
		else
		{
			PopupUI reportCategories = ReportCategories;
			reportCategories.enableBlur = true;
			reportCategories.SlideToBottom();
			ReportWindow popup3 = GetPopup(ReportType.Categories);
			GameObject go2 = popup3.popup.gameObject;
			object obj4 = typeof(RegisteredWaitHandle) + 3136;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7+E4]");
			if ((nint)0 != 0)
			{
				ScreenManager.RemovePopup(go2);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ScreenManager.RemovePopup(go2);
		}
	}

	public void CloseAll()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_005c: Expected I, but got O
		//IL_0086: Expected O, but got I4
		if (AnyVisible)
		{
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)736;
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Close();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.5f, action);
		}
	}

	public void OpenTimePicker(InputFieldTMProUGUI field)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7985]");
		object obj3 = (nint)0 & (nint)1;
		DatePickerManager datePickerManager;
		DatePickerManager datePickerManager2;
		if (obj3 != null)
		{
			datePickerManager = pickerManager;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			datePickerManager2 = pickerManager;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			datePickerManager = pickerManager;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			datePickerManager2 = pickerManager;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime now = DateTime.Now;
		bool flag3 = (object)datePickerManager2 == null;
		object obj6 = !flag3;
		datePickerManager = datePickerManager2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_009f;
		IL_0091:
		now = DateTime.Now;
		goto IL_009f;
		IL_009f:
		datePickerManager.PickDateTime(field, now, IPicker.PickerMode.PastOnly);
	}

	private void ShowReport(ReportWindow report)
	{
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_00da: Expected O, but got I4
		//IL_0191: Expected O, but got I4
		//IL_0057: Expected O, but got I
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_029a: Expected O, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02bf: Expected O, but got I
		//IL_006c: Expected F4, but got I
		//IL_0089: Expected F4, but got I
		//IL_0089: Expected O, but got I
		//IL_0099: Expected O, but got I
		//IL_02e0: Expected I, but got O
		//IL_030a: Expected O, but got I4
		//IL_015a: Expected O, but got I4
		//IL_01bc: Expected O, but got I
		//IL_034a: Expected F4, but got I
		//IL_0367: Expected F4, but got I
		//IL_0367: Expected O, but got I
		//IL_0389: Expected O, but got I4
		//IL_01fb: Expected O, but got I4
		object obj = this + 104;
		object obj2 = obj;
		if (obj == report)
		{
			return;
		}
		float num;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X22_v10+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X22_v10+10]");
				object obj3 = 0;
				goto IL_005c;
			}
			bool isTablet = ScreenUtility.IsTablet;
			bool flag = !isTablet;
			object obj4 = !flag;
			if (obj4 == null)
			{
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X22_v10+10]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X22_v10+18]");
				if ((nint)0 != 0)
				{
					bool flag2 = obj3 == null;
					object obj5 = !flag2;
					if (obj5 != null)
					{
						goto IL_005c;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v18+3C]");
					num = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v18+28]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v18+3C]");
					TransitionExtension.RectSlideToRight((RectTransform)num2, 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X22_v10+10]");
					bool flag3 = (nint)0 == 0;
					object obj6 = !flag3;
					if (obj6 != null)
					{
						goto IL_009e;
					}
				}
				goto IL_0397;
			}
		}
		goto IL_00a9;
		IL_0397:
		throw new NullReferenceException();
		IL_00a9:
		PopupUI popup = report.popup;
		bool flag4 = !popup.<IsCurrentlyShown>k__BackingField;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			num = popup.animationSpeed;
			PopupUI popup2;
			if (report.<reportType>k__BackingField != ReportType.Categories)
			{
				TransitionExtension.RectSlideFromLeft(popup.content, popup.animationSpeed);
				popup2 = report.popup;
				bool flag5 = (object)report.popup == null;
				object obj8 = !flag5;
				if (obj8 == null)
				{
					goto IL_0397;
				}
			}
			else
			{
				TransitionExtension.RectSlideFromRight(popup.content, popup.animationSpeed);
				popup2 = report.popup;
			}
			popup2.<IsCurrentlyShown>k__BackingField = true;
		}
		currentReport = report;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ReportWindow reportWindow = currentReport;
		bool interactable = reportWindow.<reportType>k__BackingField == ReportType.Categories;
		CancelButton.interactable = interactable;
		object obj9 = obj;
		object obj10 = typeof(SqlSingle[]) + 2376;
		object obj11 = (nint)0 + (nint)736;
		object obj12 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v8+10]");
		GameObject popup3 = ((Component)0).gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj11);
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(popup3, action);
		return;
		IL_005c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v18+3C]");
		num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v18+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v18+3C]");
		TransitionExtension.RectSlideToLeft((RectTransform)num3, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X22_v10+10]");
		object obj15 = 0;
		goto IL_009e;
		IL_009e:
		_ = 0;
		goto IL_00a9;
	}

	public void OnReportClick(int reportType)
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)1600;
		CancelButton.interactable = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D712E8");
		ReportType reportType2 = default(ReportType);
		ReportWindow popup = GetPopup(reportType2);
		ShowReport(popup);
	}

	public void TestHide()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)728;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
	}

	private void TestMessagePopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_020d: Expected O, but got I4
		//IL_01a8: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_0090: Expected I, but got O
		//IL_00a0: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0179: Expected O, but got I4
		//IL_022e: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		object obj2 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string email = UserInfo.Email;
		object[] array = default(object[]);
		object obj5;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj6;
		if (array != null)
		{
			bool flag2 = email == null;
			obj5 = 1;
			if (!flag2)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
				obj6 = 0;
				if (flag3)
				{
					goto IL_01c3;
				}
			}
			if (array.Length != 0)
			{
				object text = "Read object reference Id '{0}' for {1}." + 2328;
				object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
				object obj8 = array + 32;
				obj8 = email;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				LocalizableText text2 = TextMeshProExtensions.LocalizeWith((string)text, array);
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v8+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Toast.Show(text2, (Vector2)0, 0f);
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj5 = 1;
		}
		ex = new IndexOutOfRangeException();
		obj6 = obj5;
		goto IL_01c3;
		IL_01c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	public Reports()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<Tween>) + 1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 96;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <TestHide>b__24_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00b5: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)736;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Close();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.5f, action);
	}
}
