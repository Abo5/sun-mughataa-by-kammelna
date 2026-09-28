using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Spine;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class TabsUI : MonoBehaviour
{
	[Serializable]
	public class Tab
	{
		private string title;

		private Toggle button;

		private GameObject view;

		private Action<Tab, bool> m_OnTabActivated;

		public string Title => title;

		public Toggle Button => button;

		public GameObject View
		{
			get
			{
				return view;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 32;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}

		public event Action<Tab, bool> OnTabActivated
		{
			add
			{
				//IL_0096: Unknown result type (might be due to invalid IL or missing references)
				//IL_009b: Expected O, but got Unknown
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a6: Expected O, but got Unknown
				//IL_000e: Expected O, but got I4
				//IL_0065: Expected O, but got I4
				object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 840;
				object obj2 = this + 40;
				Delegate obj3 = (Delegate)obj2;
				object obj6 = default(object);
				bool flag2;
				Delegate obj8 = default(Delegate);
				do
				{
					Delegate obj4 = Delegate.Combine(obj3, value);
					if ((object)obj4 == null)
					{
						object obj5 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag = obj6 == null;
						object obj7 = !flag;
						object obj5 = obj6;
						if (obj7 == null)
						{
							throw new InvalidCastException();
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag2 = (object)obj8 == obj3;
					obj3 = obj8;
				}
				while (!flag2);
			}
			remove
			{
				//IL_0096: Unknown result type (might be due to invalid IL or missing references)
				//IL_009b: Expected O, but got Unknown
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a6: Expected O, but got Unknown
				//IL_000e: Expected O, but got I4
				//IL_0065: Expected O, but got I4
				object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 840;
				object obj2 = this + 40;
				Delegate obj3 = (Delegate)obj2;
				object obj6 = default(object);
				bool flag2;
				Delegate obj8 = default(Delegate);
				do
				{
					Delegate obj4 = Delegate.Remove(obj3, value);
					if ((object)obj4 == null)
					{
						object obj5 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag = obj6 == null;
						object obj7 = !flag;
						object obj5 = obj6;
						if (obj7 == null)
						{
							throw new InvalidCastException();
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag2 = (object)obj8 == obj3;
					obj3 = obj8;
				}
				while (!flag2);
			}
		}

		public void Init()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_003d: Expected I, but got O
			Toggle toggle = button;
			object obj = typeof(TypeConverter<ushort, char>) + 360;
			object obj2 = (nint)0 + (nint)2624;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction<bool> unityAction = default(UnityAction<bool>);
			unityAction..ctor((object)this, (IntPtr)obj2);
			toggle.onValueChanged.AddListener(unityAction);
		}

		private void OnToggleChanged(bool active)
		{
			//IL_0039: Expected O, but got I
			//IL_0049: Expected O, but got I
			//IL_0059: Expected O, but got I
			Action<Tab, bool> onTabActivated = this.OnTabActivated;
			if (this.OnTabActivated != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<TabsUI+Tab, System.Boolean>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<TabsUI+Tab, System.Boolean>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<TabsUI+Tab, System.Boolean>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v6 @ X4_v1 (should have been resolved before IL gen)");
			}
		}

		public void SetActive(bool active, bool sendCallback)
		{
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00d7: Expected O, but got I4
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0052: Expected O, but got I4
			//IL_0159: Expected O, but got I4
			//IL_0073: Expected O, but got I4
			bool flag = default(bool);
			UnityEngine.Object obj4;
			UnityEngine.Object obj6;
			if (sendCallback)
			{
				button.isOn = flag;
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj3 = !flag2;
				obj4 = view;
				if (obj3 != null)
				{
					goto IL_00ef;
				}
				object obj5 = 0;
				obj6 = view;
			}
			else
			{
				button.SetIsOnWithoutNotify(flag);
				object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v6+E4]");
				bool flag3 = (nint)0 == 0;
				obj4 = view;
				object obj5 = 0;
				obj6 = view;
				if (!flag3)
				{
					goto IL_00ef;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = obj6 != null;
			bool flag5 = !flag4;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				return;
			}
			goto IL_0116;
			IL_00ef:
			if (obj4 != null)
			{
				goto IL_0116;
			}
			return;
			IL_0116:
			view.SetActive(flag);
		}

		public Tab(string title, Toggle button, GameObject view)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			object obj = this + 16;
			obj = title;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj2 = this + 24;
			obj2 = button;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj3 = this + 32;
			obj3 = view;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Tab, bool> <>9__20_0;

		public static Predicate<Tab> <>9__22_0;

		public static Func<Tab, bool> <>9__40_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_AnyActive>b__20_0(Tab tab)
		{
			//IL_0064: Expected I4, but got O
			if (tab != null && (object)tab.view != null)
			{
				return tab.view.activeSelf;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_ActiveTabIndex>b__22_0(Tab tab)
		{
			//IL_0064: Expected I4, but got O
			if (tab != null && (object)tab.view != null)
			{
				return tab.view.activeSelf;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <IsHome>b__40_0(Tab tab)
		{
			//IL_0064: Expected I4, but got O
			if (tab != null && (object)tab.view != null)
			{
				return tab.view.activeSelf;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private int defaultTab = -1;

	private bool partOfNavigation;

	private bool rememberTabs;

	private RectTransform layout;

	private bool enableCounterBasedTab;

	private CounterBubbleType counterType;

	private string counterExtra;

	private int counterBasedTabIndex;

	private bool shouldUpdateText;

	private string defaultText;

	private TextMeshProUGUI textMeshToUpdate;

	private RectTransform selectedTabIndicator;

	private List<Tab> tabs;

	public UnityEvent<int> OnTabChanged;

	private static readonly Dictionary<string, int> LastActivatedSceneTab;

	private bool isSet;

	private string TabGroupName
	{
		get
		{
			GameObject current = base.gameObject;
			return UIExtensions.GetPath(current);
		}
	}

	public bool AnyActive
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
			object obj2 = typeof(SkeletonBinary.SkeletonInput) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ADC]");
			object obj3 = (nint)0 & (nint)1;
			List<Tab> list;
			List<Tab> list2;
			object obj4;
			if (obj3 != null)
			{
				list = tabs;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				list2 = tabs;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				list = tabs;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				list2 = tabs;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)2960;
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
			object obj13 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 560;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)2616;
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
			obj10 = (nint)0 + (nint)2960;
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

	public int ActiveTabIndex
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_015c: Expected O, but got I4
			//IL_00a9: Expected O, but got I
			//IL_00b9: Expected O, but got I
			//IL_0208: Expected O, but got I4
			//IL_019e: Expected O, but got I
			//IL_01ae: Expected O, but got I
			//IL_01d0: Expected O, but got I4
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Expected O, but got Unknown
			//IL_02ad: Expected O, but got I
			//IL_02be: Expected I, but got O
			//IL_02dc: Expected O, but got I
			//IL_0257: Expected O, but got I4
			//IL_0238: Expected O, but got I
			//IL_0283: Expected I4, but got O
			object obj = 152989696;
			object obj2 = typeof(SkeletonBinary.SkeletonInput) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ADD]");
			object obj3 = (nint)0 & (nint)1;
			List<Tab> list;
			List<Tab> list2;
			object obj4;
			if (obj3 != null)
			{
				list = tabs;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				list2 = tabs;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				list = tabs;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				list2 = tabs;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v4+10]");
			Predicate<object> match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v4+10]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			list = list2;
			if (obj8 != null)
			{
				goto IL_00e6;
			}
			goto IL_01e6;
			IL_00e6:
			bool flag4 = list == null;
			List<object> list3 = (List<object>)(object)list;
			if (!flag4)
			{
				goto IL_010b;
			}
			goto IL_0275;
			IL_0275:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_010b:
			return list3.FindIndex(match);
			IL_0099:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v4+10]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v4+10]");
			bool flag5 = (nint)0 == 0;
			list2 = list;
			if (!flag5)
			{
				goto IL_00e6;
			}
			goto IL_01e6;
			IL_01e6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
			bool flag6 = (nint)0 == 0;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v10+B8]");
				obj7 = 0;
			}
			object obj11 = typeof(List<Tween>) + 3784;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)2608;
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor(obj7, (IntPtr)obj12);
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v9+B8]");
			object obj14 = (nint)0 + (nint)16;
			obj14 = predicate;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag7 = list2 == null;
			object obj15 = !flag7;
			match = predicate;
			list3 = (List<object>)(object)list2;
			if (obj15 != null)
			{
				goto IL_010b;
			}
			goto IL_0275;
		}
	}

	public bool HasRememberedTab
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_00c5: Expected O, but got I
			//IL_0093: Expected I4, but got O
			if (rememberTabs)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3752;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+B8]");
				object obj4 = 0;
				GameObject current = base.gameObject;
				string path = UIExtensions.GetPath(current);
				if (obj4 != null)
				{
					return ((Dictionary<object, int>)obj4).ContainsKey((object)path);
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	private Tab ActiveTab
	{
		get
		{
			//IL_000c: Expected O, but got I
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00b7: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			object obj = (nint)0 + (nint)1896;
			int activeTabIndex = ActiveTabIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C948A8");
			object obj3 = default(object);
			object obj2 = obj3 & 1;
			bool flag = obj2 == null;
			object obj4 = !flag;
			int num = activeTabIndex;
			if (obj4 == null)
			{
				num = defaultTab;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C948A8");
			if (tabs != null)
			{
				object obj5 = default(object);
				bool flag2 = obj5 == null;
				object obj6 = !flag2;
				object obj7 = ~obj6;
				int index = ((obj7 == null) ? num : 0);
				return (Tab)((List<object>)(object)tabs).get_Item(index);
			}
			return (Tab)(object)new NullReferenceException();
		}
	}

	public Tab Item
	{
		get
		{
			int index2 = default(int);
			if (tabs != null)
			{
				return (Tab)((List<object>)(object)tabs).get_Item(index2);
			}
			return (Tab)(object)new NullReferenceException();
		}
	}

	private void Awake()
	{
		//IL_0016: Expected O, but got I
		//IL_00dc: Expected O, but got I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_015b: Expected O, but got I
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0181: Expected I, but got O
		//IL_018f: Expected I, but got O
		//IL_01be: Expected O, but got I4
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_0261: Expected O, but got I
		//IL_026f: Expected I, but got O
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_02ad: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7AE0]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			RegisterEvents();
			if (isSet)
			{
				goto IL_0058;
			}
		}
		else
		{
			_ = 1;
			RegisterEvents();
			bool flag = !isSet;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_0058;
			}
		}
		int targetTab = GetTargetTab();
		Activate(targetTab);
		bool flag2 = !enableCounterBasedTab;
		bool flag3 = true;
		int num = targetTab;
		if (flag2)
		{
			goto IL_0087;
		}
		goto IL_013b;
		IL_0087:
		bool flag4 = rememberTabs;
		nint num2 = 1;
		if (!flag4)
		{
			return;
		}
		goto IL_0206;
		IL_0206:
		if (partOfNavigation)
		{
			GameObject popup = base.gameObject;
			object obj3 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = (nint)0 + (nint)200;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj4);
			object obj5 = typeof(RegisteredWaitHandle) + 3136;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v7+E4]");
			bool flag5 = (nint)0 == 0;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ScreenManager.PushPopup(popup, action);
		}
		return;
		IL_013b:
		object obj8 = typeof(CardUtils.<>c) + 2776;
		object obj9 = (nint)0 + (nint)208;
		object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		num2 = (nint)obj9;
		CounterBubbleManager.CounterUpdated counterUpdated = default(CounterBubbleManager.CounterUpdated);
		counterUpdated..ctor(this, (IntPtr)obj9);
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v14+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.OnCounterUpdated += counterUpdated;
		if (rememberTabs)
		{
			goto IL_0206;
		}
		return;
		IL_0058:
		bool flag7 = enableCounterBasedTab;
		bool flag8 = default(bool);
		flag3 = flag8;
		IntPtr intPtr = default(IntPtr);
		num = (int)(nint)intPtr;
		if (!flag7)
		{
			goto IL_0087;
		}
		goto IL_013b;
	}

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0051: Expected I, but got O
		if (enableCounterBasedTab)
		{
			object obj = typeof(CardUtils.<>c) + 2776;
			object obj2 = (nint)0 + (nint)208;
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			CounterBubbleManager.CounterUpdated counterUpdated = default(CounterBubbleManager.CounterUpdated);
			counterUpdated..ctor(this, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				CounterBubbleManager.OnCounterUpdated -= counterUpdated;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CounterBubbleManager.OnCounterUpdated -= counterUpdated;
		}
	}

	private void OnValidate()
	{
		//IL_0027: Expected O, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		//IL_0089: Expected O, but got I4
		//IL_00e1: Expected O, but got I4
		//IL_010a: Expected O, but got I4
		List<Tab> list = tabs;
		int num = list._size - 1;
		object obj = defaultTab - num;
		bool flag = (nint)obj < 0;
		int num2 = defaultTab ^ num;
		int num3 = defaultTab ^ obj;
		int num4 = num2 & num3;
		bool flag2 = num4 < 0;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			num = defaultTab;
		}
		object obj4 = defaultTab + 1;
		bool flag4 = (nint)obj4 < 0;
		bool flag5 = !flag4;
		object obj5 = !flag5;
		if (obj5 != null)
		{
			num = -1;
		}
		defaultTab = num;
	}

	private void RegisterEvents()
	{
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_02a0: Expected I, but got O
		//IL_0197: Expected O, but got I
		//IL_019f: Expected I, but got O
		//IL_0145: Expected O, but got I4
		//IL_0089: Expected I, but got O
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_0113: Expected O, but got I4
		//IL_0120: Expected I, but got O
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (tabs != null)
		{
			object obj = (nint)0 + (nint)560;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 840;
			object obj3 = (nint)0 + (nint)216;
			List<object>.Enumerator enumerator = ((List<object>)(object)tabs).GetEnumerator();
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			Tab tab = default(Tab);
			Action<object, bool> action = default(Action<object, bool>);
			object obj7 = default(object);
			Delegate obj10 = default(Delegate);
			while (true)
			{
				num = (nint)obj;
				object obj11;
				Delegate obj12;
				if (enumerator2.MoveNext())
				{
					if (tab != null)
					{
						tab.Init();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						action..ctor((object)this, (IntPtr)obj3);
						object obj4 = tab + 40;
						Delegate obj5 = (Delegate)obj4;
						while (true)
						{
							Delegate obj6 = Delegate.Combine(obj5, action);
							if ((object)obj6 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag = obj7 == null;
								object obj8 = !flag;
								object obj9 = obj7;
								if (obj8 == null)
								{
									break;
								}
							}
							else
							{
								object obj9 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
							bool flag2 = (object)obj10 != obj5;
							obj5 = obj10;
							if (!flag2)
							{
								goto IL_00db;
							}
						}
						InvalidCastException ex = new InvalidCastException();
						obj11 = 0;
						obj12 = null;
						num = (nint)obj2;
					}
					else
					{
						NullReferenceException ex2 = new NullReferenceException();
					}
					break;
				}
				enumerator2.Dispose();
				return;
				IL_00db:
				obj11 = 0;
				obj12 = obj10;
			}
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			enumerator3 = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
		}
		NullReferenceException ex3 = new NullReferenceException();
		bool flag3 = num != 1;
		OutOfMemoryException ex4 = (OutOfMemoryException)(object)ex3;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj13 = (nint)0 + (nint)552;
			num = (nint)obj13;
			enumerator3.Dispose();
			object obj14 = default(object);
			if (obj14 == null)
			{
				return;
			}
			ex4 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223AF14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void HandleCounterUpdated(CounterBubbleType type, int newCount, string extra)
	{
		if (type == counterType)
		{
			bool flag = extra == counterExtra;
			if (newCount >= 1 && flag)
			{
				Activate(counterBasedTabIndex);
			}
		}
	}

	private void OnTabActivated(Tab tab, bool isOn)
	{
		//IL_0481: Expected I4, but got O
		//IL_00b3: Expected O, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I4
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_03ea: Expected O, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_04d5: Expected O, but got I
		//IL_0073: Expected O, but got I
		//IL_007b: Expected I4, but got O
		//IL_0189: Expected O, but got I4
		//IL_020f: Expected O, but got I4
		//IL_0285: Expected O, but got I4
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_032a: Expected O, but got I4
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_0353: Expected O, but got I
		//IL_0361: Expected I, but got O
		bool flag2 = default(bool);
		bool flag = !flag2;
		int num = (int)tab;
		if (!flag)
		{
			int num2 = ((List<object>)(object)tabs).IndexOf((object)tab);
			Activate(num2, sendCallback: false);
			bool flag3 = OnTabChanged == null;
			flag2 = false;
			num = num2;
			if (!flag3)
			{
				int activeTabIndex = ActiveTabIndex;
				object obj = (nint)0 + (nint)976;
				flag2 = (byte)(int)obj != 0;
				OnTabChanged.Invoke(activeTabIndex);
				num = activeTabIndex;
			}
		}
		bool flag4 = !partOfNavigation;
		Action action = (Action)num;
		object obj2;
		object obj5;
		if (!flag4)
		{
			obj2 = typeof(DataRelation) + 3776;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v20+E4]");
			bool flag5 = (nint)0 == 0;
			object obj4 = !flag5;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			EventSystem current = EventSystem.current;
			obj5 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v15+E4]");
			if ((nint)0 != 0)
			{
				bool flag6 = current;
				bool flag7 = !flag6;
				object obj7 = !flag7;
				Action action2 = null;
				if (obj7 != null)
				{
					goto IL_01e5;
				}
				action = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag8 = current;
				bool flag9 = !flag8;
				Action action2 = null;
				action = null;
				if (!flag9)
				{
					goto IL_01e5;
				}
			}
		}
		goto IL_0389;
		IL_0389:
		if (rememberTabs)
		{
			object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3752;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v11+E4]");
			bool flag10 = (nint)0 == 0;
			object obj10 = !flag10;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v11+B8]");
			object obj11 = 0;
			GameObject current2 = base.gameObject;
			string path = UIExtensions.GetPath(current2);
			int activeTabIndex2 = ActiveTabIndex;
			((Dictionary<object, int>)obj11).set_Item((object)path, activeTabIndex2);
		}
		if (shouldUpdateText)
		{
			Tab activeTab = ActiveTab;
			TextMeshProExtensions.Localize(textMeshToUpdate, activeTab.title);
		}
		return;
		IL_01e5:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v25+E4]");
		bool flag11 = (nint)0 == 0;
		object obj13 = !flag11;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		EventSystem current3 = EventSystem.current;
		Tab activeTab2 = ActiveTab;
		GameObject gameObject = activeTab2.button.gameObject;
		object obj14 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v33+E4]");
		bool flag12 = (nint)0 == 0;
		object obj15 = !flag12;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag13 = current3.m_CurrentSelected == gameObject;
		bool flag14 = !flag13;
		flag2 = false;
		action = (Action)(object)gameObject;
		if (!flag14)
		{
			GameObject go = base.gameObject;
			object obj16 = typeof(RegisteredWaitHandle) + 3136;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v20+E4]");
			bool flag15 = (nint)0 == 0;
			object obj18 = !flag15;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ScreenManager.RemovePopup(go);
			GameObject popup = base.gameObject;
			object obj19 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj20 = (nint)0 + (nint)200;
			Action action3 = default(Action);
			action3..ctor(this, (IntPtr)obj20);
			ScreenManager.PushPopup(popup, action3);
			flag2 = false;
			action = action3;
		}
		goto IL_0389;
	}

	private void BackAction()
	{
		//IL_0099: Expected I4, but got I8
		//IL_00b3: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		if (IsHome())
		{
			object obj = typeof(Queue<string>) + 840;
			object obj2 = (nint)0 + (nint)2184;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			ScreenManager screenManager = default(ScreenManager);
			screenManager.Back();
		}
		else
		{
			int num = (int)(defaultTab & 0x80000000L);
			bool flag2 = num == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Activate(defaultTab);
				return;
			}
			int targetTab = GetTargetTab();
			Activate(targetTab);
		}
	}

	private void SetupTabs()
	{
		int targetTab = GetTargetTab();
		Activate(targetTab);
	}

	private int GetTargetTab()
	{
		//IL_024e: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_0100: Expected O, but got I
		//IL_026c: Expected O, but got I
		//IL_0231: Expected I4, but got O
		//IL_0092: Expected O, but got I4
		//IL_01bf: Expected O, but got I
		bool flag = !rememberTabs;
		int? num = (int?)(object)0;
		if (!flag)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3752;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v22+B8]");
			object obj4 = 0;
			GameObject current = base.gameObject;
			string path = UIExtensions.GetPath(current);
			if (obj4 == null)
			{
				goto IL_0223;
			}
			int value;
			bool flag3 = ((Dictionary<object, int>)obj4).TryGetValue((object)path, out value);
			bool flag4 = !flag3;
			num = (int?)(object)0;
			if (!flag4)
			{
				int? num2 = value;
				num = num2;
			}
		}
		object obj5 = (??)num & 1;
		if (obj5 == null)
		{
			goto IL_021c;
		}
		int value2 = num.Value;
		object obj6 = (nint)0 + (nint)1896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C948A8");
		object obj7 = default(object);
		if (obj7 == null)
		{
			goto IL_020a;
		}
		int value3 = num.Value;
		if (tabs != null)
		{
			object obj8 = ((List<object>)(object)tabs).get_Item(value3);
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v17 (System.Object)+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v17 (System.Object)+18]");
					GameObject gameObject = ((Component)0).gameObject;
					if ((object)gameObject != null)
					{
						if (gameObject.activeInHierarchy)
						{
							goto IL_020a;
						}
						goto IL_021c;
					}
				}
			}
		}
		goto IL_0223;
		IL_0223:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_020a:
		return num.Value;
		IL_021c:
		return defaultTab;
	}

	public void ActivateHome()
	{
		//IL_0014: Expected I4, but got I8
		//IL_002e: Expected O, but got I4
		int num = (int)(defaultTab & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			Activate(defaultTab);
			return;
		}
		int targetTab = GetTargetTab();
		Activate(targetTab);
	}

	public void Activate(int tabIndex, bool sendCallback = true)
	{
		//IL_01e5: Expected I4, but got I8
		//IL_01ff: Expected O, but got I4
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0126: Expected O, but got I4
		//IL_0185: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		List<object> list = (List<object>)(object)tabs;
		bool flag = tabs == null;
		bool flag2 = sendCallback;
		if (flag)
		{
			goto IL_019b;
		}
		if (sendCallback)
		{
			flag2 = false;
			while ((flag2 ? 1 : 0) < list._size)
			{
				object obj = list.get_Item(flag2 ? 1 : 0);
				if (obj != null)
				{
					object obj2 = tabIndex - (flag2 ? 1 : 0);
					bool active = obj2 == null;
					((Tab)obj).SetActive(active, sendCallback: true);
					flag2 = (byte)((flag2 ? 1u : 0u) + 1u) != 0;
					list = (List<object>)(object)tabs;
					bool flag3 = tabs == null;
					object obj3 = !flag3;
					if (obj3 != null)
					{
						continue;
					}
				}
				goto IL_019b;
			}
		}
		else
		{
			bool flag4 = false;
			while (true)
			{
				bool flag5 = (flag4 ? 1 : 0) >= list._size;
				flag2 = flag4;
				if (flag5)
				{
					break;
				}
				object obj4 = list.get_Item(flag4 ? 1 : 0);
				bool flag6 = obj4 == null;
				flag2 = flag4;
				if (!flag6)
				{
					object obj5 = tabIndex - (flag4 ? 1 : 0);
					bool flag7 = obj5 == null;
					bool sendCallback2 = !flag7;
					((Tab)obj4).SetActive(flag7, sendCallback2);
					flag2 = (byte)((flag4 ? 1u : 0u) + 1u) != 0;
					list = (List<object>)(object)tabs;
					bool flag8 = tabs == null;
					object obj6 = !flag8;
					flag4 = flag2;
					if (obj6 != null)
					{
						continue;
					}
				}
				goto IL_019b;
			}
		}
		goto IL_01b1;
		IL_01b1:
		if (shouldUpdateText)
		{
			int num = (int)(tabIndex & 0x80000000L);
			bool flag9 = num == 0;
			object obj7 = !flag9;
			object text;
			if (obj7 == null)
			{
				object obj8 = list.get_Item(tabIndex);
				if (obj8 == null)
				{
					goto IL_019b;
				}
				text = obj8 + 16;
			}
			else
			{
				text = this + 72;
			}
			TextMeshProExtensions.Localize(textMeshToUpdate, (string)text);
		}
		isSet = true;
		return;
		IL_019b:
		NullReferenceException ex = new NullReferenceException();
		list = (List<object>)(object)ex;
		goto IL_01b1;
	}

	public void SetDefaultTab(int defaultTabIndex)
	{
		defaultTab = defaultTabIndex;
	}

	public void SetTabView(int tabIndex, GameObject view)
	{
		//IL_0011: Expected O, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = (nint)0 + (nint)984;
		int index = default(int);
		object obj2 = ((List<object>)(object)tabs).get_Item(index);
		object obj3 = obj2 + 32;
		obj3 = view;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public bool IsHome()
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
		//IL_0395: Expected I4, but got I8
		//IL_03af: Expected O, but got I4
		//IL_0214: Expected O, but got I4
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0323: Expected O, but got I
		//IL_0334: Expected I, but got O
		//IL_0352: Expected O, but got I
		//IL_02f9: Expected I4, but got O
		//IL_0244: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B78]");
		object obj3 = (nint)0 & (nint)1;
		List<Tab> list;
		List<Tab> list2;
		object obj4;
		if (obj3 != null)
		{
			list = tabs;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			list2 = tabs;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			list = tabs;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			list2 = tabs;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)1496;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v18+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v12+18]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v12+18]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v18+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)2600;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v17+B8]");
		object obj16 = (nint)0 + (nint)24;
		obj16 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func;
		obj10 = obj7;
		source = enumerable;
		goto IL_0249;
		IL_0249:
		object obj17 = Enumerable.FirstOrDefault(source, predicate);
		int num = (int)(defaultTab & 0x80000000L);
		bool flag5 = num == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			List<object> list3 = (List<object>)(object)tabs;
			if (tabs == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			if (defaultTab < list3._size)
			{
				object obj19 = ((List<object>)(object)tabs).get_Item(defaultTab);
				object obj20 = obj17 - obj19;
				return obj20 == null;
			}
		}
		return false;
		IL_0099:
		obj10 = (nint)0 + (nint)1496;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v18+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v12+18]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v12+18]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		source = list;
		if (obj21 == null)
		{
			obj7 = obj10;
			enumerable = list;
			goto IL_01f2;
		}
		goto IL_0249;
	}

	private bool IsHome(Tab tab)
	{
		//IL_00b3: Expected I4, but got I8
		//IL_00cd: Expected O, but got I4
		//IL_009f: Expected I4, but got O
		int num = (int)(defaultTab & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			List<object> list = (List<object>)(object)tabs;
			if (tabs == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			if (defaultTab < list._size)
			{
				object obj2 = ((List<object>)(object)tabs).get_Item(defaultTab);
				object obj3 = (object)tab - obj2;
				return obj3 == null;
			}
		}
		return false;
	}

	public static void ClearLastTabs()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_0137: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3752;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7AE8]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v15+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v15+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5+B8]");
		object obj8 = 0;
		Dictionary<object, int> dictionary = (Dictionary<object, int>)obj8;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a2;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v15+B8]");
		object obj10 = 0;
		dictionary = (Dictionary<object, int>)obj10;
		goto IL_00a2;
		IL_00a2:
		dictionary.Clear();
	}

	public void AddTab(string title, Toggle toggle, GameObject view)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_009f: Expected O, but got I
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_019f: Expected O, but got I
		//IL_01af: Expected O, but got I
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_01ff: Expected I, but got O
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_020d: Expected O, but got I4
		//IL_0264: Expected O, but got I4
		Delegate obj = (Delegate)(typeof(SkeletonBinary.SkeletonInput) + 2368);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = toggle;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 32;
		obj5 = view;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform transform = toggle.transform;
		transform.SetParent(layout, worldPositionStays: false);
		List<object> list = (List<object>)(object)tabs;
		object obj6 = (nint)0 + (nint)944;
		object obj7 = obj6;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		object obj8 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 840;
		object obj9 = (nint)0 + (nint)216;
		bool flag = list._size < items.Length;
		object obj10 = !flag;
		if (obj10 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj11 = items + list._size;
			object obj12 = obj11 + 32;
			obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag2 = false;
			object obj13 = obj2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v6+20]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v13+C0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v14+70]");
			bool flag2 = false;
			list.AddWithResize(obj2);
			object obj13 = obj2;
		}
		((Tab)obj2).Init();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, bool> action = default(Action<object, bool>);
		action..ctor((object)this, (IntPtr)obj9);
		object obj16 = obj2 + 40;
		Delegate obj17 = (Delegate)obj16;
		object obj20 = default(object);
		bool flag4;
		Delegate obj22 = default(Delegate);
		do
		{
			Delegate obj18 = Delegate.Combine(obj17, action);
			if ((object)obj18 == null)
			{
				object obj19 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = obj20 == null;
				object obj21 = !flag3;
				object obj19 = obj20;
				if (obj21 == null)
				{
					InvalidCastException ex = new InvalidCastException();
					break;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			flag4 = (object)obj22 == obj17;
			obj17 = obj22;
		}
		while (!flag4);
		List<Tab> list2 = tabs;
		int tabIndex = list2._size - 1;
		Activate(tabIndex);
	}

	static TabsUI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2504;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, int> dictionary = default(Dictionary<object, int>);
		dictionary..ctor();
		object obj3 = obj2;
		object obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
