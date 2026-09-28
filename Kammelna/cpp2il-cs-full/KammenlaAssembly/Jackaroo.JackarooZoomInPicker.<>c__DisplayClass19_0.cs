using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Pool;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;

namespace Jackaroo;

public class JackarooZoomInPicker : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<JackarooZoomInPickerOption> <>9__14_1;

		public static Action<JackarooZoomInPickerOption> <>9__14_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Awake>b__14_1(JackarooZoomInPickerOption option)
		{
			GameObject gameObject = option.gameObject;
			gameObject.SetActive(value: true);
		}

		internal void <Awake>b__14_2(JackarooZoomInPickerOption option)
		{
			GameObject gameObject = option.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private sealed class <>c__DisplayClass19_0
	{
		public JackarooMarbleMono marble;

		public IEnumerable<JackarooMarbleMono> marbles;

		public JackarooZoomInPicker <>4__this;

		public JackarooZoomInPickerOption option;

		internal unsafe void <AddPickerOption>b__0()
		{
			//IL_06bc: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0060: Expected I, but got O
			//IL_0070: Expected O, but got I
			//IL_0143: Expected O, but got I4
			//IL_0725: Unknown result type (might be due to invalid IL or missing references)
			//IL_072a: Expected O, but got Unknown
			//IL_0739: Unknown result type (might be due to invalid IL or missing references)
			//IL_073e: Expected O, but got Unknown
			//IL_074d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0752: Expected O, but got Unknown
			//IL_0774: Expected O, but got Ref
			//IL_00ab: Expected O, but got I
			//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ed: Expected O, but got Unknown
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected O, but got Unknown
			//IL_0613: Expected O, but got I4
			//IL_0198: Expected O, but got I
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00dc: Expected O, but got I
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			//IL_026b: Expected O, but got I4
			//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ea: Expected O, but got Unknown
			//IL_01d3: Expected O, but got I
			//IL_040d: Expected O, but got I4
			//IL_0416: Expected O, but got I4
			//IL_078c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0791: Expected O, but got Unknown
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0293: Expected O, but got Unknown
			//IL_08bd: Expected O, but got I4
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Expected O, but got Unknown
			//IL_0204: Expected O, but got I
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0214: Expected O, but got Unknown
			//IL_0433: Expected O, but got I
			//IL_02dd: Expected O, but got I
			//IL_04d2: Expected O, but got I4
			//IL_03b0: Expected O, but got I4
			//IL_046e: Expected O, but got I
			//IL_0318: Expected O, but got I
			//IL_0536: Expected O, but got I
			//IL_0819: Unknown result type (might be due to invalid IL or missing references)
			//IL_081e: Expected O, but got Unknown
			//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fa: Expected O, but got Unknown
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Expected O, but got Unknown
			//IL_047c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0481: Expected O, but got Unknown
			//IL_0497: Expected O, but got I
			//IL_032e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0333: Expected O, but got Unknown
			//IL_0349: Expected O, but got I
			//IL_0354: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Expected O, but got Unknown
			JackarooMarbleMono jackarooMarbleMono = marble;
			bool flag = (object)marble == null;
			object obj = 0;
			Action <OnSelectAction>k__BackingField;
			bool flag4 = default(bool);
			if (!flag)
			{
				IEnumerable<JackarooMarbleMono> enumerable = marbles;
				bool flag2 = marbles == null;
				obj = 0;
				if (!flag2)
				{
					object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3424;
					<OnSelectAction>k__BackingField = jackarooMarbleMono.<OnSelectAction>k__BackingField;
					nint num = (nint)enumerable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Jackaroo.JackarooMarbleMono>>)+12E]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Jackaroo.JackarooMarbleMono>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0130;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Jackaroo.JackarooMarbleMono>>)+B0]");
					object obj4 = (nint)0 + (nint)8;
					bool flag3 = flag4;
					object obj6;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v29-8]");
						object obj5 = 0 - obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v29-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj6 = obj4 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Jackaroo.JackarooMarbleMono>>)+12E]");
						obj3 = -1;
						obj5 = obj3 - 1;
						bool flag5 = obj5 == null;
						flag4 = (nint)obj3 != 1;
						flag3 = flag4;
						obj4 = obj6;
						if (flag4)
						{
							continue;
						}
						goto IL_0130;
					}
					obj3 = obj4;
					object obj7 = num + obj4;
					object obj8 = obj7 + 312;
					flag4 = flag3;
					obj6 = obj4;
					goto IL_0716;
				}
			}
			goto IL_06ca;
			IL_0130:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj9 = 0;
			goto IL_0716;
			IL_0716:
			object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			object obj11 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 832;
			object obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v26+8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v269 @ X0_v26] (should have been resolved before IL gen)");
			jackarooMarbleMono = (JackarooMarbleMono)(&obj);
			object obj13 = default(object);
			object obj17 = default(object);
			object obj19 = default(object);
			object obj23 = default(object);
			object obj29 = default(object);
			object obj31 = default(object);
			JackarooMarbleMono jackarooMarbleMono2 = default(JackarooMarbleMono);
			while (true)
			{
				if (obj13 != null)
				{
					object obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v20+12E]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v20+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0258;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v20+B0]");
					object obj15 = (nint)0 + (nint)8;
					bool flag6 = flag4;
					object obj6;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X10_v24-8]");
						object obj5 = 0 - obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X10_v24-8]");
						if (0 == (nint)obj10)
						{
							break;
						}
						obj6 = obj15 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v20+12E]");
						obj3 = -1;
						obj5 = obj3 - 1;
						bool flag5 = obj5 == null;
						flag4 = (nint)obj3 != 1;
						flag6 = flag4;
						obj15 = obj6;
						if (flag4)
						{
							continue;
						}
						goto IL_0258;
					}
					obj3 = obj15;
					object obj16 = obj14 + obj15;
					obj17 = obj16 + 312;
					flag4 = flag6;
					obj6 = obj15;
					goto IL_07ba;
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_0600;
				IL_07ba:
				jackarooMarbleMono = (JackarooMarbleMono)obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v32+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v486 @ X0_v32] (should have been resolved before IL gen)");
				object obj18 = obj19 & 1;
				if (obj18 != null)
				{
					if (obj13 != null)
					{
						object obj20 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v23+12E]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v23+12E]");
						if ((nint)0 == 0)
						{
							goto IL_039d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v23+B0]");
						object obj21 = (nint)0 + (nint)8;
						bool flag7 = flag4;
						object obj6;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X10_v19-8]");
							object obj5 = 0 - obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X10_v19-8]");
							if (0 == (nint)obj11)
							{
								break;
							}
							obj6 = obj21 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v23+12E]");
							obj3 = -1;
							obj5 = obj3 - 1;
							bool flag5 = obj5 == null;
							flag4 = (nint)obj3 != 1;
							flag7 = flag4;
							obj21 = obj6;
							if (flag4)
							{
								continue;
							}
							goto IL_039d;
						}
						obj3 = obj21;
						object obj22 = obj20 + obj21;
						obj23 = obj22 + 312;
						flag4 = flag7;
						obj6 = obj21;
						goto IL_0847;
					}
					NullReferenceException ex2 = new NullReferenceException();
					goto IL_0600;
				}
				obj = obj13;
				object obj24 = 0;
				object obj25 = 0;
				while (true)
				{
					if (obj == null)
					{
						goto IL_08a3;
					}
					object obj26 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v8+12E]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v8+12E]");
					if ((nint)0 == 0)
					{
						goto IL_04bf;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v8+B0]");
					object obj27 = (nint)0 + (nint)8;
					object obj6;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X10_v7-8]");
						if (0 == (nint)obj12)
						{
							break;
						}
						obj6 = obj27 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v8+12E]");
						obj3 = -1;
						bool flag8 = (nint)obj3 != 1;
						obj27 = obj6;
						if (flag8)
						{
							continue;
						}
						goto IL_04bf;
					}
					obj3 = obj27;
					object obj28 = obj26 + obj27;
					obj29 = obj28 + 312;
					obj6 = obj27;
					goto IL_08ef;
					IL_08a3:
					bool flag9 = obj25 == null;
					object obj30 = !flag9;
					if (obj30 != null)
					{
						OutOfMemoryException ex3 = new OutOfMemoryException();
						if (num2 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
							obj25 = obj31;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
							obj24 = obj31;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
						return;
					}
					break;
					IL_04bf:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj9 = 0;
					goto IL_08ef;
					IL_08ef:
					jackarooMarbleMono = (JackarooMarbleMono)obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v8+8]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v550 @ X0_v8] (should have been resolved before IL gen)");
					goto IL_08a3;
				}
				if (jackarooMarbleMono.<OnSelectAction>k__BackingField == null)
				{
					break;
				}
				jackarooMarbleMono = (JackarooMarbleMono)(nint)((Delegate)<OnSelectAction>k__BackingField).invoke_impl;
				num2 = ((Delegate)<OnSelectAction>k__BackingField).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v128.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				if ((object)<>4__this == null)
				{
					break;
				}
				<>4__this.HidePickerPanel();
				jackarooMarbleMono = (JackarooMarbleMono)(object)option;
				if ((object)option == null || (object)jackarooMarbleMono.<MarbleImage>k__BackingField == null)
				{
					break;
				}
				((GameObject)(object)jackarooMarbleMono.<MarbleImage>k__BackingField).SetActive(value: false);
				return;
				IL_0847:
				jackarooMarbleMono = (JackarooMarbleMono)obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X0_v36+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v607 @ X0_v36] (should have been resolved before IL gen)");
				if ((object)jackarooMarbleMono2 != null)
				{
					jackarooMarbleMono2.Reset();
					continue;
				}
				NullReferenceException ex4 = new NullReferenceException();
				goto IL_0600;
				IL_0600:
				obj = obj13;
				obj24 = 0;
				break;
				IL_039d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj9 = 0;
				goto IL_0847;
				IL_0258:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj9 = 0;
				goto IL_07ba;
			}
			goto IL_06ca;
			IL_06ca:
			throw new NullReferenceException();
		}

		internal Vector3 <AddPickerOption>b__1()
		{
			JackarooZoomInPickerOption jackarooZoomInPickerOption = option;
			if ((object)option != null && (object)jackarooZoomInPickerOption.<Transform>k__BackingField != null)
			{
				return jackarooZoomInPickerOption.<Transform>k__BackingField.localPosition;
			}
			return (Vector3)new NullReferenceException();
		}

		internal void <AddPickerOption>b__2(Vector3 value)
		{
			//IL_0022: Expected O, but got I4
			JackarooZoomInPickerOption jackarooZoomInPickerOption = option;
			jackarooZoomInPickerOption.<Transform>k__BackingField.localPosition = (Vector3)0;
		}

		internal Vector2 <AddPickerOption>b__3()
		{
			JackarooZoomInPickerOption jackarooZoomInPickerOption = option;
			if ((object)option != null && (object)jackarooZoomInPickerOption.<MarbleRenderer>k__BackingField != null)
			{
				return jackarooZoomInPickerOption.<MarbleRenderer>k__BackingField.size;
			}
			return (Vector2)new NullReferenceException();
		}

		internal void <AddPickerOption>b__4(Vector2 value)
		{
			//IL_0022: Expected O, but got I4
			JackarooZoomInPickerOption jackarooZoomInPickerOption = option;
			jackarooZoomInPickerOption.<MarbleRenderer>k__BackingField.size = (Vector2)0;
		}

		internal void <AddPickerOption>b__5()
		{
			//IL_003b: Expected I, but got O
			//IL_004b: Expected O, but got I
			//IL_005b: Expected O, but got I
			JackarooZoomInPickerOption jackarooZoomInPickerOption = option;
			MarbleHighlight <MarbleHighlight>k__BackingField = jackarooZoomInPickerOption.<MarbleHighlight>k__BackingField;
			DOTweenAnimation animation = <MarbleHighlight>k__BackingField._animation;
			nint num = (nint)animation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v4 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+1D8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v4 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+1E0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v33 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private Transform _parentTransform;

	private Vector3 _centerPosition;

	private Vector3 _perspectiveOffset;

	private float _duration;

	private float _offset;

	private Vector2 _largeMarbleSize;

	private Vector2 _smallMarbleSize;

	private JackarooZoomInPickerOption _marbleOption;

	private UnityEngine.Pool.ObjectPool<JackarooZoomInPickerOption> _optionsPool;

	private readonly List<JackarooZoomInPickerOption> _pooledOptionsPool;

	private readonly List<JackarooMarbleMono> _marbles;

	private Button _dissmisserButton;

	private GameEventsChannel _gameEventsChannel;

	private KGameVisualControls _visualControls;

	private Action _onDismiss;

	private const string HighlightLayer = "Highlight";

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_04ef: Expected O, but got I
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected O, but got Unknown
		//IL_050f: Expected O, but got I
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_054d: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0066: Expected I, but got O
		//IL_0074: Expected I, but got O
		//IL_0393: Expected O, but got I
		//IL_03a3: Expected O, but got I
		//IL_03c5: Expected O, but got I4
		//IL_0113: Expected O, but got I4
		//IL_0121: Expected O, but got I4
		//IL_00b6: Expected O, but got I
		//IL_00c6: Expected O, but got I
		//IL_03fd: Expected O, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_016c: Expected O, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018c: Expected O, but got I
		//IL_019c: Expected O, but got I
		//IL_01ac: Expected O, but got I
		//IL_01ce: Expected O, but got I4
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected O, but got Unknown
		//IL_0616: Expected O, but got I
		//IL_061e: Expected I, but got O
		//IL_062f: Expected I, but got O
		//IL_064d: Expected O, but got I
		//IL_045c: Expected O, but got I4
		//IL_0465: Expected O, but got I4
		//IL_047e: Expected O, but got I4
		//IL_0486: Expected I, but got O
		//IL_042d: Expected O, but got I
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_01fe: Expected O, but got I4
		//IL_0286: Expected I, but got O
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected O, but got Unknown
		//IL_0585: Expected O, but got I
		//IL_058d: Expected I, but got O
		//IL_059e: Expected I, but got O
		//IL_05bc: Expected O, but got I
		//IL_05df: Expected O, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02ab: Expected O, but got I
		//IL_022e: Expected O, but got I
		//IL_02d7: Expected I, but got O
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_031a: Expected O, but got I
		//IL_0332: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)144;
		object obj3 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2416;
		object obj4 = (nint)0 + (nint)984;
		object obj5 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 912;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj8 = this + 136;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)obj4;
		Func<object> func = default(Func<object>);
		func..ctor((object)this, (IntPtr)obj4);
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v26+E4]");
		object obj11;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v26+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v7+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v7+8]");
			bool flag2 = (nint)0 == 0;
			object obj12 = obj10;
			if (!flag2)
			{
				goto IL_00f3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v26+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v7+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v7+8]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			object obj12 = obj10;
			if (obj13 != null)
			{
				goto IL_00f3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v14+B8]");
			obj11 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)2408;
		num = (nint)obj17;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj11, (IntPtr)obj17);
		object obj18 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v12+B8]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v26+E4]");
		bool flag5 = (nint)0 == 0;
		object obj20 = !flag5;
		object obj21 = 0;
		object obj22 = action2;
		action = action2;
		object obj23 = 0;
		nint num2 = (nint)obj17;
		object obj24 = action2;
		object obj25 = obj10;
		Action<object> action3 = action2;
		if (obj20 != null)
		{
			goto IL_014c;
		}
		goto IL_04ac;
		IL_014c:
		object obj26 = typeof(List<Tween>) + 2680;
		object obj27 = (nint)0 + (nint)1400;
		object obj28 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 944;
		object obj29 = (nint)0 + (nint)1008;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v26+B8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v24+10]");
		Action<object> action4 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v24+10]");
		bool flag6 = (nint)0 == 0;
		object obj31 = !flag6;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v26+E4]");
			bool flag7 = (nint)0 == 0;
			object obj32 = !flag7;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj33 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v30+B8]");
				obj30 = 0;
			}
			object obj34 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj35 = (nint)0 + (nint)2416;
			num = (nint)obj35;
			Action<object> action5 = default(Action<object>);
			action5..ctor(obj30, (IntPtr)obj35);
			object obj36 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v29+B8]");
			object obj37 = (nint)0 + (nint)16;
			obj37 = action5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			action4 = action5;
			obj21 = 0;
			obj22 = action5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3989138");
		object obj38 = this + 96;
		object obj39 = default(object);
		obj38 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object, object> action6 = default(Action<object, object, object>);
		action6..ctor((object)this, (IntPtr)obj29);
		object obj40 = typeof(SqlSingle[]) + 2376;
		object obj41 = (nint)0 + (nint)1000;
		_gameEventsChannel.DisplayZoomInPicker += action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action7 = default(Action);
		action7..ctor(this, (IntPtr)obj41);
		_gameEventsChannel.HideZoomInPicker += action7;
		Button dissmisserButton = _dissmisserButton;
		object obj42 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj43 = (nint)0 + (nint)992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj43);
		dissmisserButton.m_OnClick.AddListener(unityAction);
		GameObject gameObject = _dissmisserButton.gameObject;
		gameObject.SetActive(value: false);
		return;
		IL_04ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj10 = obj5;
		obj21 = obj23;
		num = num2;
		obj22 = obj24;
		action = action3;
		goto IL_014c;
		IL_00f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v26+E4]");
		bool flag8 = (nint)0 == 0;
		obj21 = 0;
		obj22 = this;
		obj23 = 0;
		num2 = num;
		obj24 = this;
		obj25 = obj10;
		action3 = action;
		if (!flag8)
		{
			goto IL_014c;
		}
		goto IL_04ac;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_009e: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 944;
		object obj2 = (nint)0 + (nint)1008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object, object> action = default(Action<object, object, object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1000;
		_gameEventsChannel.DisplayZoomInPicker -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		_gameEventsChannel.HideZoomInPicker -= action2;
	}

	private void ShowPickerPanel(JackarooMarbleMono mainMarble, List<JackarooMarbleMono> marbles, Action onDismiss)
	{
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_0017: Expected O, but got I
		//IL_0070: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_023d: Expected O, but got I4
		//IL_0254: Expected O, but got I
		//IL_00f4: Expected O, but got I
		//IL_0100: Expected O, but got I
		//IL_010c: Expected O, but got I
		//IL_027f: Expected O, but got I4
		//IL_0288: Expected O, but got I4
		//IL_0291: Expected O, but got I4
		//IL_029a: Expected O, but got I4
		//IL_0204: Expected O, but got I4
		//IL_02c1: Expected O, but got I4
		//IL_02ca: Expected O, but got I4
		//IL_02d3: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_0748: Expected O, but got I4
		//IL_0777: Expected O, but got I4
		//IL_054a: Expected F4, but got O
		//IL_0359: Expected O, but got I4
		//IL_05ae: Expected O, but got I4
		//IL_01a9: Expected O, but got I
		//IL_0380: Expected O, but got I
		//IL_0448: Expected O, but got I
		//IL_0496: Expected O, but got I4
		object obj = this + 144;
		Action action = default(Action);
		obj = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X23_v8 (System.Object)-18]");
		bool flag = (nint)0 == 0;
		List<JackarooMarbleMono> list = marbles;
		Action action2 = action;
		object obj3 = default(object);
		object obj4 = default(object);
		object obj6 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X23_v8 (System.Object)-18]");
			GameObject gameObject = ((Component)0).gameObject;
			bool flag2 = (object)gameObject == null;
			list = marbles;
			action2 = null;
			if (!flag2)
			{
				gameObject.SetActive(value: true);
				bool flag3 = (object)mainMarble == null;
				list = null;
				action2 = (Action)1;
				if (!flag3)
				{
					bool flag4 = (object)mainMarble.<Transform>k__BackingField == null;
					list = null;
					action2 = (Action)1;
					if (!flag4)
					{
						Vector3 position = mainMarble.<Transform>k__BackingField.position;
						bool flag5 = marbles == null;
						list = null;
						action2 = null;
						if (!flag5)
						{
							object obj2 = (nint)0 + (nint)2776;
							obj3 = (nint)0 + (nint)2296;
							obj = (nint)0 + (nint)2768;
							List<object>.Enumerator enumerator = ((List<object>)(object)marbles).GetEnumerator();
							object obj5 = default(object);
							obj4 = obj5;
							object obj7 = default(object);
							obj6 = obj7;
							enumerator2 = enumerator3;
							int num = default(int);
							while (true)
							{
								action2 = (Action)obj2;
								if (!enumerator4.MoveNext())
								{
									break;
								}
								bool flag6 = num == 0;
								enumerator4 = enumerator5;
								enumerator3 = enumerator5;
								enumerator5 = (List<object>.Enumerator)0;
								list = null;
								if (flag6)
								{
									goto IL_0575;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ stack_-88 (System.Int32)+30]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ stack_-88 (System.Int32)+30]");
									Vector3 position2 = ((Transform)0).position;
									enumerator2 = (List<object>.Enumerator)((object)enumerator2 + (object)enumerator5);
									obj6 += obj7;
									obj4 += obj5;
									continue;
								}
								goto IL_058b;
							}
							action2 = (Action)obj;
							enumerator4.Dispose();
							enumerator4 = enumerator5;
							enumerator3 = enumerator5;
							enumerator5 = (List<object>.Enumerator)0;
							list = null;
							goto IL_020e;
						}
					}
				}
			}
		}
		goto IL_0567;
		IL_020e:
		if ((object)_parentTransform != null)
		{
			_parentTransform.position = (Vector3)0;
			IntPtr intPtr = default(IntPtr);
			AddPickerOption(mainMarble, 1, marbles, (Vector3)(nint)intPtr);
			bool flag7 = marbles._size < 1;
			action = (Action)(object)marbles;
			object obj7 = 0;
			object obj5 = 0;
			enumerator3 = (List<object>.Enumerator)0;
			list = (List<JackarooMarbleMono>)1;
			action2 = (Action)(object)mainMarble;
			if (flag7)
			{
				goto IL_04f5;
			}
			Action action3 = (Action)(object)marbles;
			object obj8 = 0;
			object obj9 = 0;
			List<object>.Enumerator enumerator6 = (List<object>.Enumerator)0;
			object obj10 = obj4;
			object obj11 = obj6;
			List<object>.Enumerator enumerator7 = enumerator2;
			object obj12 = obj;
			int num2 = 0;
			while (true)
			{
				list = (List<JackarooMarbleMono>)obj3;
				object obj13 = ((List<object>)(object)marbles).get_Item(num2);
				bool flag8 = obj13 == null;
				action = action3;
				obj7 = obj8;
				obj5 = obj9;
				enumerator3 = enumerator6;
				obj4 = obj10;
				obj6 = obj11;
				enumerator2 = enumerator7;
				action2 = (Action)num2;
				obj = obj12;
				if (flag8)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v32 (System.Object)+30]");
				bool flag9 = (nint)0 == 0;
				action = action3;
				obj7 = obj8;
				obj5 = obj9;
				enumerator3 = enumerator6;
				obj4 = obj10;
				obj6 = obj11;
				enumerator2 = enumerator7;
				action2 = (Action)num2;
				obj = obj13;
				if (flag9)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v32 (System.Object)+30]");
				Vector3 position3 = ((Transform)0).position;
				bool flag10 = (object)mainMarble.<Transform>k__BackingField == null;
				action = action3;
				obj7 = obj8;
				obj5 = obj9;
				enumerator3 = enumerator6;
				obj4 = obj10;
				obj6 = obj11;
				enumerator2 = enumerator7;
				action2 = null;
				obj = obj13;
				if (flag10)
				{
					break;
				}
				Vector3 position4 = mainMarble.<Transform>k__BackingField.position;
				enumerator3 = (List<object>.Enumerator)((object)enumerator6 - (object)enumerator6);
				obj7 = obj8 - obj8;
				obj5 = obj9 - obj9;
				int num3 = num2 + 2;
				AddPickerOption((JackarooMarbleMono)obj13, num3, marbles, (Vector3)(nint)intPtr);
				num2++;
				bool flag11 = num2 < marbles._size;
				action = (Action)(object)marbles;
				obj4 = obj9;
				obj6 = obj8;
				enumerator2 = enumerator6;
				list = (List<JackarooMarbleMono>)num3;
				action2 = (Action)obj13;
				obj = obj13;
				action3 = (Action)(object)marbles;
				obj8 = obj7;
				obj9 = obj5;
				enumerator6 = enumerator3;
				obj10 = obj5;
				obj11 = obj7;
				enumerator7 = enumerator3;
				obj12 = obj13;
				if (flag11)
				{
					continue;
				}
				goto IL_04f5;
			}
		}
		goto IL_0567;
		IL_0567:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0575;
		IL_0575:
		NullReferenceException ex2 = new NullReferenceException();
		List<object>.Enumerator enumerator8 = enumerator4;
		goto IL_05be;
		IL_058b:
		ex2 = new NullReferenceException();
		enumerator8 = enumerator5;
		enumerator3 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		list = null;
		goto IL_05be;
		IL_05be:
		bool flag12 = (nint)action2 != 1;
		NullReferenceException ex3 = ex2;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			action2 = (Action)obj;
			enumerator8.Dispose();
			object obj14 = default(object);
			bool flag13 = obj14 == null;
			enumerator4 = enumerator8;
			enumerator5 = (List<object>.Enumerator)obj14;
			if (flag13)
			{
				goto IL_020e;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			enumerator5 = (List<object>.Enumerator)obj14;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BB08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_04f5:
		if ((object)_visualControls != null)
		{
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMove(duration: (!_visualControls.IsCurrentPerspectiveTopDown) ? ((float)_centerPosition + (float)_perspectiveOffset) : ((float)_centerPosition), target: _parentTransform, endValue: (Vector3)0);
			return;
		}
		goto IL_0567;
	}

	private void AddPickerOption(JackarooMarbleMono marble, int index, IEnumerable<JackarooMarbleMono> marbles, Vector3 offset = default(Vector3))
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00be: Expected O, but got I
		//IL_00d9: Expected O, but got I
		//IL_0133: Expected O, but got I4
		//IL_01b1: Expected O, but got I
		//IL_01c1: Expected O, but got I
		//IL_01d1: Expected O, but got I
		//IL_01ef: Expected O, but got I
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_019c: Expected O, but got I4
		//IL_0239: Expected O, but got I
		//IL_0293: Expected O, but got I4
		//IL_0308: Expected O, but got I
		//IL_0318: Expected O, but got I
		//IL_0328: Expected O, but got I
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_0371: Expected I4, but got O
		//IL_0786: Expected O, but got I
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03de: Expected O, but got I
		//IL_03f9: Expected I, but got O
		//IL_0418: Expected O, but got I
		//IL_043f: Expected I, but got O
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_0497: Expected O, but got I
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_04c0: Expected O, but got I
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_04e0: Expected O, but got I
		//IL_04f6: Expected O, but got I4
		//IL_04f6: Expected O, but got I
		//IL_0516: Expected I, but got O
		//IL_0536: Expected I, but got O
		//IL_0546: Expected O, but got I
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected O, but got Unknown
		//IL_056b: Expected O, but got I
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_058b: Expected O, but got I
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		//IL_05ab: Expected O, but got I
		//IL_05bc: Expected O, but got I
		//IL_05ea: Expected O, but got I4
		//IL_067d: Expected O, but got I4
		//IL_06ab: Expected I, but got O
		//IL_06cb: Expected I, but got O
		//IL_06e8: Expected F4, but got O
		//IL_06e8: Expected O, but got I4
		//IL_06f8: Expected O, but got I
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected O, but got Unknown
		//IL_0731: Expected O, but got I
		//IL_0742: Expected I, but got O
		//IL_0753: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = marble;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = marbles;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 32;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((JackarooMarbleMono)obj3).ShowText(index);
		object obj6 = obj3;
		object sortingLayerName = "HH:mm:ss.ffZ" + 1464;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v4+50]");
		((Canvas)0).sortingLayerName = (string)sortingLayerName;
		List<object> marbles2 = (List<object>)(object)_marbles;
		object obj7 = (nint)0 + (nint)2256;
		object obj8 = obj7;
		int version = marbles2._version + 1;
		marbles2._version = version;
		object[] items = marbles2._items;
		bool flag = marbles2._size < items.Length;
		object obj9 = !flag;
		if (obj9 == null)
		{
			int size = marbles2._size + 1;
			marbles2._size = size;
			object obj10 = items + marbles2._size;
			object obj11 = obj10 + 32;
			obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj12 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v9+20]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v36+C0]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v37+70]");
			object obj12 = 0;
			marbles2.AddWithResize(obj3);
		}
		object obj15 = (nint)0 + (nint)1408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D49814");
		object obj16 = obj2 + 40;
		object obj17 = default(object);
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		List<object> pooledOptionsPool = (List<object>)(object)_pooledOptionsPool;
		object obj18 = (nint)0 + (nint)2536;
		object obj19 = obj18;
		int version2 = pooledOptionsPool._version + 1;
		pooledOptionsPool._version = version2;
		object[] items2 = pooledOptionsPool._items;
		bool flag2 = pooledOptionsPool._size < items2.Length;
		object obj20 = !flag2;
		if (obj20 == null)
		{
			int size2 = pooledOptionsPool._size + 1;
			pooledOptionsPool._size = size2;
			object obj21 = items2 + pooledOptionsPool._size;
			object obj22 = obj21 + 32;
			obj22 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v15+20]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v33+C0]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v34+70]");
			object obj12 = 0;
			pooledOptionsPool.AddWithResize(obj16);
		}
		object obj25 = obj3;
		JackarooZoomInPickerOption jackarooZoomInPickerOption = (JackarooZoomInPickerOption)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v18+130]");
		bool flag3 = (nint)0 != 1;
		int num = (int)obj16;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v18+154]");
			num = 0;
			object obj26 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v18+154]");
			((JackarooZoomInPickerOption)obj26).ShowFireMode(0);
			obj25 = obj3;
			jackarooZoomInPickerOption = (JackarooZoomInPickerOption)obj16;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v18+48]");
		object obj27 = 0;
		object obj28 = typeof(SqlSingle[]) + 2376;
		object obj29 = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj29);
		SpriteRenderer <MarbleRenderer>k__BackingField = jackarooZoomInPickerOption.<MarbleRenderer>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v19+D8]");
		<MarbleRenderer>k__BackingField.sprite = (Sprite)0;
		TextMeshProUGUI marbleIndex = jackarooZoomInPickerOption._marbleIndex;
		int num2 = default(int);
		string text = num2.ToString();
		nint num3 = (nint)marbleIndex;
		marbleIndex.text = text;
		object obj30 = jackarooZoomInPickerOption + 64;
		obj30 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj31 = obj16;
		object obj32 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X9_v12+30]");
		Vector3 position = ((Transform)0).position;
		object obj33 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 80;
		object obj34 = (nint)0 + (nint)2432;
		object obj35 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 160;
		object obj36 = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v21+20]");
		((Transform)0).position = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOGetter<Vector3> dOGetter = default(DOGetter<Vector3>);
		dOGetter..ctor(obj2, (IntPtr)obj34);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOSetter<Vector3> dOSetter = default(DOSetter<Vector3>);
		dOSetter..ctor(obj2, (IntPtr)obj36);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Object)+28]");
		object obj37 = 0;
		object obj38 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj39 = (nint)0 + (nint)2904;
		object obj40 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 72;
		object obj41 = (nint)0 + (nint)2448;
		object obj42 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 152;
		object obj43 = (nint)0 + (nint)2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v22+20]");
		Vector3 localPosition = ((Transform)0).localPosition;
		object obj44 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v43+E4]");
		bool flag4 = (nint)0 == 0;
		object obj45 = !flag4;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj46 = default(object);
		float num4 = (float)obj46 * _offset;
		float num5 = (float)obj46 + num4;
		object obj47 = default(object);
		float num6 = (float)obj47 * _offset;
		float num7 = (float)obj47 + num6;
		object obj48 = default(object);
		float num8 = (float)obj48 * _offset;
		float duration = (float)obj48 + num8;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, (Vector3)0, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOGetter<Vector2> dOGetter2 = default(DOGetter<Vector2>);
		dOGetter2..ctor(obj2, (IntPtr)obj41);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOSetter<Vector2> dOSetter2 = default(DOSetter<Vector2>);
		dOSetter2..ctor(obj2, (IntPtr)obj43);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTween.To(dOGetter2, dOSetter2, (Vector2)0, (float)_largeMarbleSize);
		object obj49 = (nint)0 + (nint)2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj50 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj51 = (nint)0 + (nint)2464;
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj51);
		object obj52 = (nint)0 + (nint)2488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void Dismiss()
	{
		Action onDismiss = _onDismiss;
		if (_onDismiss != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v0.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		HidePickerPanel();
	}

	private void HidePickerPanel()
	{
		//IL_07a0: Expected O, but got I4
		//IL_07aa: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_0037: Expected O, but got I
		//IL_0043: Expected O, but got I
		//IL_07c0: Expected I, but got O
		//IL_0247: Expected I, but got O
		//IL_025a: Expected O, but got I4
		//IL_026c: Expected O, but got I4
		//IL_0701: Expected I, but got O
		//IL_0617: Expected O, but got I4
		//IL_0629: Expected O, but got I4
		//IL_0641: Expected O, but got I4
		//IL_0653: Expected O, but got I4
		//IL_031c: Expected O, but got I4
		//IL_0321: Expected I, but got O
		//IL_00c1: Expected O, but got I4
		//IL_00c1: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00ed: Expected I, but got O
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_05ed: Expected O, but got I4
		//IL_05ff: Expected O, but got I4
		//IL_0833: Expected I, but got O
		//IL_010b: Expected O, but got I
		//IL_0127: Expected I, but got O
		//IL_041f: Expected I, but got O
		//IL_045d: Expected O, but got I4
		//IL_0466: Expected O, but got I4
		//IL_0177: Expected O, but got I
		//IL_05cb: Expected O, but got I4
		//IL_05d4: Expected O, but got I4
		//IL_052c: Expected O, but got I4
		//IL_0535: Expected O, but got I4
		//IL_04f7: Expected O, but got I4
		//IL_04fc: Expected I, but got O
		//IL_066b: Expected O, but got I4
		//IL_067d: Expected O, but got I4
		//IL_057c: Expected O, but got I4
		//IL_0581: Expected I, but got O
		//IL_058a: Expected O, but got I4
		//IL_03bb: Expected O, but got I
		//IL_03d3: Expected I, but got O
		//IL_0209: Expected O, but got I
		//IL_0695: Expected O, but got I4
		//IL_06b0: Expected O, but got I4
		//IL_06b5: Expected I, but got O
		//IL_0230: Expected I4, but got O
		//IL_081d: Expected I, but got O
		//IL_0409: Expected O, but got I
		bool flag = _pooledOptionsPool == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		List<object>.Enumerator enumerator2 = (List<object>.Enumerator)0;
		object obj3 = default(object);
		object obj4 = default(object);
		object obj5 = default(object);
		nint num = default(nint);
		object obj6 = default(object);
		int num3;
		List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
		if (!flag)
		{
			object obj = (nint)0 + (nint)2872;
			object obj2 = (nint)0 + (nint)1416;
			obj3 = (nint)0 + (nint)2776;
			obj4 = (nint)0 + (nint)2768;
			obj5 = (nint)0 + (nint)2864;
			List<object>.Enumerator enumerator3 = ((List<object>)(object)_pooledOptionsPool).GetEnumerator();
			List<object>.Enumerator enumerator4 = enumerator5;
			List<object>.Enumerator enumerator6 = default(List<object>.Enumerator);
			while (true)
			{
				num = (nint)obj;
				if (!enumerator6.MoveNext())
				{
					break;
				}
				if (obj6 == null)
				{
					goto IL_0604;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ stack_-A8+28]");
				if ((nint)0 != 0)
				{
					enumerator4 = (List<object>.Enumerator)_smallMarbleSize;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ stack_-A8+28]");
					((SpriteRenderer)0).size = (Vector2)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ stack_-A8+30]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ stack_-A8+30]");
					bool flag2 = (nint)0 == 0;
					num = unchecked((nint)null);
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X27_v2+38]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X27_v2+38]");
						bool flag3 = (nint)0 == 0;
						num = unchecked((nint)null);
						if (!flag3)
						{
							object obj9 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v21+1C8]");
							int num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v21+1D0]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v370 @ X8_v21+1C8] (should have been resolved before IL gen)");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X27_v2+38]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X27_v2+38]");
							if ((nint)0 != 0)
							{
								object obj11 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v22+1A8]");
								num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v22+1B0]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v271 @ X8_v22+1A8] (should have been resolved before IL gen)");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ stack_-A8+48]");
								if ((nint)0 == 0)
								{
									goto IL_0658;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ stack_-A8+48]");
								((GameObject)0).SetActive(value: false);
								if (_optionsPool != null)
								{
									num3 = (int)obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D498F4");
									continue;
								}
								goto IL_0682;
							}
						}
					}
					goto IL_05da;
				}
				goto IL_062e;
			}
			num = (nint)obj5;
			enumerator6.Dispose();
			enumerator = (List<object>.Enumerator)0;
			enumerator2 = enumerator5;
			enumerator5 = (List<object>.Enumerator)0;
			goto IL_0271;
		}
		goto IL_07ea;
		IL_0658:
		NullReferenceException ex = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		enumerator2 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		goto IL_07ea;
		IL_0271:
		List<JackarooZoomInPickerOption> pooledOptionsPool = _pooledOptionsPool;
		if (_pooledOptionsPool != null)
		{
			num3 = pooledOptionsPool._size;
			int num2 = pooledOptionsPool._version + 1;
			pooledOptionsPool._size = 0;
			pooledOptionsPool._version = num2;
			if (pooledOptionsPool._size >= 1)
			{
				Array.Clear(pooledOptionsPool._items, 0, pooledOptionsPool._size);
				object obj12 = 0;
				num = unchecked((nint)null);
			}
			if (_marbles != null)
			{
				List<object>.Enumerator enumerator7 = ((List<object>)(object)_marbles).GetEnumerator();
				object sortingLayerName = "Read object reference Id '{0}' for {1}." + 3096;
				while (true)
				{
					num = (nint)obj3;
					List<object>.Enumerator enumerator4;
					if (enumerator.MoveNext())
					{
						if (obj6 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ stack_-A8+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ stack_-A8+20]");
								GameObject gameObject = ((Component)0).gameObject;
								bool flag4 = (object)gameObject == null;
								num = unchecked((nint)null);
								if (!flag4)
								{
									gameObject.SetActive(value: false);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ stack_-A8+50]");
									bool flag5 = (nint)0 == 0;
									num3 = 0;
									num = unchecked((nint)null);
									if (!flag5)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ stack_-A8+50]");
										((Canvas)0).sortingLayerName = (string)sortingLayerName;
										num3 = 0;
										continue;
									}
								}
							}
						}
						NullReferenceException ex2 = new NullReferenceException();
						enumerator = enumerator5;
						enumerator4 = enumerator5;
						enumerator5 = (List<object>.Enumerator)0;
						obj5 = 1;
						break;
					}
					num = (nint)obj4;
					enumerator.Dispose();
					List<JackarooMarbleMono> marbles = _marbles;
					bool flag6 = _marbles == null;
					enumerator = enumerator5;
					enumerator4 = enumerator5;
					enumerator5 = (List<object>.Enumerator)0;
					obj5 = 1;
					if (flag6)
					{
						break;
					}
					num3 = marbles._size;
					num2 = marbles._version + 1;
					marbles._size = 0;
					marbles._version = num2;
					if (marbles._size >= 1)
					{
						Array.Clear(marbles._items, 0, marbles._size);
						object obj12 = 0;
						num = unchecked((nint)null);
					}
					bool flag7 = (object)_dissmisserButton == null;
					enumerator = enumerator5;
					enumerator4 = enumerator5;
					enumerator5 = (List<object>.Enumerator)0;
					obj5 = 1;
					if (flag7)
					{
						break;
					}
					GameObject gameObject2 = _dissmisserButton.gameObject;
					bool flag8 = (object)gameObject2 == null;
					enumerator = enumerator5;
					enumerator4 = enumerator5;
					enumerator5 = (List<object>.Enumerator)0;
					num = unchecked((nint)null);
					obj5 = 1;
					if (flag8)
					{
						break;
					}
					gameObject2.SetActive(value: false);
					return;
				}
			}
		}
		goto IL_07ea;
		IL_07ea:
		NullReferenceException ex3 = new NullReferenceException();
		if (num == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj5;
			enumerator2.Dispose();
			object obj13 = default(object);
			bool flag9 = obj13 == null;
			enumerator5 = (List<object>.Enumerator)obj13;
			if (flag9)
			{
				goto IL_0271;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BB08");
			NullReferenceException ex5 = (NullReferenceException)(object)ex4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BC48");
			NullReferenceException ex5 = ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0682:
		NullReferenceException ex6 = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		num3 = 0;
		enumerator2 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		num = unchecked((nint)null);
		goto IL_07ea;
		IL_0604:
		NullReferenceException ex7 = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		enumerator2 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		goto IL_07ea;
		IL_05da:
		NullReferenceException ex8 = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		enumerator2 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		goto IL_07ea;
		IL_062e:
		NullReferenceException ex9 = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		enumerator2 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		goto IL_07ea;
	}

	public JackarooZoomInPicker()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_007b: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1992;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 1952;
		_centerPosition = (Vector3)0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253370]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253380]");
		_largeMarbleSize = (Vector2)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 104;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj4 = this + 112;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private JackarooZoomInPickerOption <Awake>b__14_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_006d: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)568;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		JackarooZoomInPickerOption result = default(JackarooZoomInPickerOption);
		return result;
	}
}
