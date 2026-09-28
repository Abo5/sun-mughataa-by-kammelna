using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UI.Pickers;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.Events;
using UnityEngine.InputSystem.UI;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Comparison<TutorialGameUi> <>9__9_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <InitializeTutorialGamesUiIe>b__9_0(TutorialGameUi x, TutorialGameUi y)
		{
			//IL_0095: Expected I4, but got O
			if ((object)x != null)
			{
				string name = x.name;
				if ((object)y != null)
				{
					string name2 = y.name;
					if (name != null)
					{
						return name.CompareTo(name2);
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass11_0
	{
		public TutorialPages tutorialPages;

		public DiscreteProgressIndicator discreteProgressIndicator;

		public int numberOfPages;

		public Tutorial <>4__this;

		internal void <SetupButtons>g__Call|0()
		{
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected O, but got Unknown
			//IL_0168: Expected O, but got I
			//IL_0176: Expected I, but got O
			TutorialPages tutorialPages = this.tutorialPages;
			tutorialPages._pagesParent.SetActive(value: true);
			discreteProgressIndicator.SetupNumberProgress(numberOfPages);
			GameObject gameObject = discreteProgressIndicator.gameObject;
			gameObject.SetActive(value: true);
			TutorialPages tutorialPages2 = this.tutorialPages;
			object obj = tutorialPages2._pageScrollButtonsHandler + 56;
			obj = discreteProgressIndicator;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			TutorialPages tutorialPages3 = this.tutorialPages;
			tutorialPages3._pageScrollButtonsHandler.OpenPageCheck();
			TutorialPages tutorialPages4 = this.tutorialPages;
			UIPicker uiPicker = tutorialPages4._uiPicker;
			int currentProgress = uiPicker._currentSelectionIndex + 1;
			discreteProgressIndicator.CurrentProgress = currentProgress;
			if (ScreenUtility.IsTablet)
			{
				TutorialPages tutorialPages5 = this.tutorialPages;
				tutorialPages5._uiPicker.MoveToHome();
				Tutorial tutorial = <>4__this;
				object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3888;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj3 = (nint)0 + (nint)808;
				Action<object> action = default(Action<object>);
				action..ctor((object)this, (IntPtr)obj3);
				((List<object>)(object)tutorial._allTutorialsPages).ForEach(action);
			}
		}

		internal void <SetupButtons>b__2(TutorialPages pages)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ff: Expected O, but got I4
			//IL_0157: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F1B]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				obj5 = tutorialPages;
				obj6 = tutorialPages;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = tutorialPages;
				obj6 = tutorialPages;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = pages != obj6;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				return;
			}
			goto IL_00bb;
			IL_00bb:
			pages._pagesParent.SetActive(value: false);
			return;
			IL_0091:
			if (pages != obj5)
			{
				goto IL_00bb;
			}
		}

		internal void <SetupButtons>b__1()
		{
			GameObject gameObject = discreteProgressIndicator.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private sealed class <>c__DisplayClass13_0
	{
		public TutorialPages tutorialPages;

		internal void <ShowPage>b__0()
		{
			TutorialPages tutorialPages = this.tutorialPages;
			tutorialPages._uiPicker.MoveToNext();
		}
	}

	private sealed class <InitializeTutorialGamesUiIe>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public Tutorial <>4__this;

		public RectTransform tutorialsPagesParent;

		public RectTransform tutorialButtonsParent;

		public Button tutorialButtonPrefab;

		public DiscreteProgressIndicator discreteProgressIndicator;

		private AsyncOperationHandle<IList<TutorialGameUi>> <loadAssetsAsync>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <InitializeTutorialGamesUiIe>d__9(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0008: Expected O, but got Ref
			//IL_024b: Expected I4, but got I8
			//IL_0257: Expected O, but got I
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Expected O, but got Unknown
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Expected O, but got Unknown
			//IL_029e: Expected O, but got I
			//IL_02a6: Expected I, but got O
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Expected O, but got Unknown
			//IL_0145: Expected O, but got I4
			//IL_017f: Expected I4, but got I8
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Expected O, but got Unknown
			//IL_01bd: Expected O, but got I4
			//IL_06ac: Expected O, but got I
			//IL_06bc: Expected O, but got I
			//IL_06de: Expected O, but got I4
			//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b35: Expected I4, but got Unknown
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Expected O, but got Unknown
			//IL_0049: Expected O, but got I4
			//IL_0304: Expected O, but got I
			//IL_0314: Expected O, but got I
			//IL_0162: Expected I4, but got I8
			//IL_016b: Expected O, but got I4
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Expected O, but got Unknown
			//IL_0237: Expected O, but got I4
			//IL_078e: Expected O, but got I4
			//IL_070e: Expected O, but got I4
			//IL_0066: Expected I4, but got I8
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_00a4: Expected O, but got I4
			//IL_0372: Expected O, but got I
			//IL_037a: Expected I, but got O
			//IL_0396: Unknown result type (might be due to invalid IL or missing references)
			//IL_039b: Expected O, but got Unknown
			//IL_0ba5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0baa: Expected O, but got Unknown
			//IL_0bc0: Expected O, but got I
			//IL_0bc8: Expected I, but got O
			//IL_0bd9: Expected I, but got O
			//IL_0bf7: Expected O, but got I
			//IL_0b4a: Expected O, but got I
			//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b5e: Expected O, but got Unknown
			//IL_0b88: Expected O, but got I4
			//IL_075d: Expected O, but got I4
			//IL_073e: Expected O, but got I
			//IL_0c3d: Expected O, but got I
			//IL_0c5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c61: Expected O, but got Unknown
			//IL_0c7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c7f: Expected O, but got Unknown
			//IL_03e8: Expected O, but got Ref
			//IL_0401: Expected O, but got I4
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			//IL_0104: Expected O, but got I4
			//IL_07a5: Expected O, but got I
			//IL_084c: Expected O, but got I
			//IL_0866: Expected O, but got I4
			//IL_086f: Expected O, but got I4
			//IL_0809: Expected O, but got I4
			//IL_0819: Expected O, but got Ref
			//IL_082a: Expected O, but got I4
			//IL_09b5: Expected I, but got O
			//IL_0441: Expected O, but got I
			//IL_09cb: Expected O, but got Ref
			//IL_09dc: Expected O, but got I4
			//IL_0614: Expected O, but got I
			//IL_0636: Expected O, but got I4
			//IL_0647: Expected O, but got I4
			//IL_0556: Expected I, but got O
			//IL_0a6c: Expected O, but got I
			//IL_0a95: Expected O, but got I4
			//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_08fd: Expected O, but got Unknown
			//IL_0913: Expected O, but got I
			//IL_092f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0934: Expected O, but got Unknown
			//IL_0955: Expected O, but got I4
			//IL_08db: Expected O, but got I4
			//IL_058c: Expected O, but got I4
			//IL_0456: Expected O, but got I
			//IL_0466: Expected O, but got I
			//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d1: Expected O, but got Unknown
			//IL_05da: Unknown result type (might be due to invalid IL or missing references)
			//IL_05df: Expected O, but got Unknown
			//IL_0603: Expected I, but got O
			object obj2 = default(object);
			object obj = (object)(&obj2);
			_ = 0;
			_ = 0;
			_ = 0;
			List<object> list = default(List<object>);
			Comparison<object> comparison;
			nint num;
			object obj3;
			RectTransform rectTransform = default(RectTransform);
			AsyncOperationHandle<IList<TutorialGameUi>> asyncOperationHandle = default(AsyncOperationHandle<IList<TutorialGameUi>>);
			RectTransform rectTransform2;
			List<object> list2;
			if (<>1__state <= 1)
			{
				if (<>1__state != 0)
				{
					bool flag = <>1__state != 1;
					obj3 = 0;
					if (!flag)
					{
						<>1__state = -1;
						object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2264;
						object obj5 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v79+E4]");
						bool flag2 = (nint)0 == 0;
						object obj6 = !flag2;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj5 = obj4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v79+B8]");
						object obj7 = 0;
						object obj8 = typeof(SqlSingle[]) + 3048;
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v79+E4]");
						bool flag3 = (nint)0 == 0;
						object obj10 = !flag3;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj11 = (nint)0 + (nint)3264;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F36B18");
						<loadAssetsAsync>5__2 = asyncOperationHandle;
						object obj12 = this + 72;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj13 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1272;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object obj14 = this + 24;
						object obj15 = default(object);
						obj14 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = 2;
						obj3 = 1;
					}
				}
				else
				{
					<>1__state = -1;
					object obj16 = typeof(SqlSingle[]) + 3048;
					object obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v69+E4]");
					bool flag4 = (nint)0 == 0;
					object obj18 = !flag4;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AsyncOperationHandle<IResourceLocator> asyncOperationHandle2 = Addressables.InitializeAsync(autoReleaseHandle: true);
					object obj19 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1296;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object obj20 = this + 24;
					object obj21 = default(object);
					obj20 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					obj3 = 1;
				}
			}
			else
			{
				if (<>1__state == 2)
				{
					<>1__state = -1;
					object obj22 = (nint)0 + (nint)416;
					AsyncOperationHandle<object> asyncOperationHandle3 = (AsyncOperationHandle<object>)(this + 72);
					object result = ((AsyncOperationHandle<object>*)asyncOperationHandle3)->Result;
					object obj23 = typeof(List<AdaptivePerformanceScaler>) + 4080;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj24 = (nint)0 + (nint)1824;
					num = (nint)obj24;
					list..ctor((IEnumerable<object>)result);
					object obj25 = typeof(TrackedDeviceRaycaster.<>c) + 192;
					object obj26 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v36+E4]");
					object obj27;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v36+B8]");
						obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v32+8]");
						comparison = (Comparison<object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v32+8]");
						if ((nint)0 != 0)
						{
							goto IL_0339;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj26 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v36+B8]");
						obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v32+8]");
						comparison = (Comparison<object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v32+8]");
						bool flag5 = (nint)0 == 0;
						object obj28 = !flag5;
						if (obj28 != null)
						{
							goto IL_0339;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v36+E4]");
					bool flag6 = (nint)0 == 0;
					object obj29 = !flag6;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj30 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v38+B8]");
						obj27 = 0;
					}
					object obj31 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3488;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj32 = (nint)0 + (nint)792;
					num = (nint)obj32;
					Comparison<object> comparison2 = default(Comparison<object>);
					comparison2..ctor(obj27, (IntPtr)obj32);
					object obj33 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v37+B8]");
					object obj34 = (nint)0 + (nint)8;
					obj34 = comparison2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag7 = list == null;
					object obj35 = !flag7;
					rectTransform = null;
					comparison = comparison2;
					rectTransform2 = null;
					list2 = (List<object>)(object)comparison2;
					if (obj35 != null)
					{
						goto IL_0366;
					}
					goto IL_0785;
				}
				bool flag8 = <>1__state != 3;
				obj3 = 0;
				if (!flag8)
				{
					<>1__state = -1;
					obj3 = 0;
				}
			}
			goto IL_0b27;
			IL_0366:
			object obj36 = (nint)0 + (nint)1840;
			num = (nint)obj36;
			list.Sort(comparison);
			object obj37 = typeof(List<AdaptivePerformanceScaler>) + 4088;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list3 = default(List<object>);
			list3..ctor();
			List<object>.Enumerator enumerator = list.GetEnumerator();
			bool flag9 = (object)<>4__this == null;
			rectTransform2 = rectTransform;
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			List<object>.Enumerator enumerator2 = (List<object>.Enumerator)(&enumerator3);
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			enumerator3 = enumerator4;
			list2 = list3;
			asyncOperationHandle = (AsyncOperationHandle<IList<TutorialGameUi>>)0;
			List<object>.Enumerator enumerator5 = enumerator4;
			Button button = default(Button);
			DiscreteProgressIndicator discreteProgressIndicator = default(DiscreteProgressIndicator);
			NullReferenceException ex;
			object obj46;
			RectTransform rectTransform4;
			RectTransform rectTransform3;
			if (!flag9)
			{
				TutorialGameUi tutorialGameUi = default(TutorialGameUi);
				if (list3 != null)
				{
					object obj38 = (nint)0 + (nint)1856;
					while (enumerator3.MoveNext())
					{
						button = tutorialButtonPrefab;
						discreteProgressIndicator = this.discreteProgressIndicator;
						rectTransform2 = tutorialButtonsParent;
						TutorialPages tutorialPages = <>4__this.InstantiateTutorialGame(tutorialsPagesParent, tutorialGameUi, tutorialButtonsParent, tutorialButtonPrefab, this.discreteProgressIndicator);
						object obj39 = obj38;
						int version = list3._version + 1;
						list3._version = version;
						object[] items = list3._items;
						bool flag10 = list3._items == null;
						num = (nint)tutorialGameUi;
						rectTransform3 = (RectTransform)(object)tutorialPages;
						if (!flag10)
						{
							bool flag11 = list3._size < items.Length;
							object obj40 = !flag11;
							if (obj40 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X8_v59+20]");
								object obj41 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v61+C0]");
								object obj42 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X8_v62+70]");
								num = 0;
								list3.AddWithResize((object)tutorialPages);
								rectTransform = tutorialButtonsParent;
							}
							else
							{
								int size = list3._size + 1;
								list3._size = size;
								object obj43 = list3._items + list3._size;
								object obj44 = obj43 + 32;
								obj44 = tutorialPages;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								rectTransform = tutorialButtonsParent;
								num = (nint)tutorialGameUi;
							}
							continue;
						}
						goto IL_09ba;
					}
					object obj45 = (nint)0 + (nint)2728;
					rectTransform4 = (RectTransform)obj45;
					enumerator3.Dispose();
					rectTransform2 = rectTransform;
					obj46 = 10;
					list2 = list3;
					obj3 = 0;
					enumerator5 = enumerator4;
					goto IL_08a4;
				}
				bool flag12 = enumerator3.MoveNext();
				bool flag13 = !flag12;
				object obj47 = !flag13;
				rectTransform2 = rectTransform;
				enumerator2 = (List<object>.Enumerator)(&enumerator3);
				list2 = list3;
				asyncOperationHandle = (AsyncOperationHandle<IList<TutorialGameUi>>)0;
				enumerator5 = enumerator4;
				if (obj47 != null)
				{
					button = tutorialButtonPrefab;
					discreteProgressIndicator = this.discreteProgressIndicator;
					rectTransform3 = tutorialsPagesParent;
					rectTransform2 = tutorialButtonsParent;
					TutorialPages tutorialPages2 = <>4__this.InstantiateTutorialGame(tutorialsPagesParent, tutorialGameUi, tutorialButtonsParent, tutorialButtonPrefab, this.discreteProgressIndicator);
					num = (nint)tutorialGameUi;
					goto IL_09ba;
				}
			}
			else
			{
				object obj48 = (nint)0 + (nint)2736;
				rectTransform3 = (RectTransform)obj48;
				if (enumerator3.MoveNext())
				{
					ex = new NullReferenceException();
					goto IL_09ef;
				}
			}
			object obj49 = (nint)0 + (nint)2728;
			rectTransform4 = (RectTransform)obj49;
			((List<object>.Enumerator*)enumerator2)->Dispose();
			obj46 = 10;
			obj3 = 0;
			rectTransform = rectTransform2;
			DiscreteProgressIndicator discreteProgressIndicator2 = discreteProgressIndicator;
			Button button2 = button;
			IntPtr intPtr = num;
			rectTransform3 = (RectTransform)obj49;
			List<object>.Enumerator enumerator6 = enumerator5;
			goto IL_0adb;
			IL_09ef:
			bool flag14 = (nint)rectTransform3 != 1;
			rectTransform = rectTransform2;
			discreteProgressIndicator2 = discreteProgressIndicator;
			button2 = button;
			intPtr = num;
			OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
			enumerator6 = enumerator5;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				object obj50 = default(object);
				obj3 = obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj51 = (nint)0 + (nint)2728;
				rectTransform4 = (RectTransform)obj51;
				((List<object>.Enumerator*)enumerator2)->Dispose();
				bool flag15 = obj50 == null;
				obj46 = 0;
				rectTransform = rectTransform2;
				discreteProgressIndicator2 = discreteProgressIndicator;
				button2 = button;
				intPtr = num;
				asyncOperationHandle = (AsyncOperationHandle<IList<TutorialGameUi>>)obj50;
				rectTransform3 = (RectTransform)obj51;
				enumerator6 = enumerator5;
				if (flag15)
				{
					goto IL_08a4;
				}
				goto IL_0adb;
			}
			goto IL_0c0e;
			IL_0b27:
			return (byte)(obj3 & 1) != 0;
			IL_09ba:
			ex = new NullReferenceException();
			enumerator2 = (List<object>.Enumerator)(&enumerator3);
			list2 = list3;
			asyncOperationHandle = (AsyncOperationHandle<IList<TutorialGameUi>>)0;
			enumerator5 = enumerator4;
			goto IL_09ef;
			IL_08a4:
			if ((nint)obj46 != 10)
			{
				bool flag16 = obj46 == null;
				object obj52 = !flag16;
				if (obj52 != null)
				{
					goto IL_0b27;
				}
			}
			object obj53 = typeof(Queue<string>) + 2576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj54 = (nint)0 + (nint)3536;
			Tuple<object, object> tuple = default(Tuple<object, object>);
			tuple..ctor((object)list, (object)list2);
			object obj55 = this + 24;
			obj55 = tuple;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 3;
			obj3 = 1;
			goto IL_0b27;
			IL_0c0e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2239464");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			bool result2 = default(bool);
			return result2;
			IL_0adb:
			OutOfMemoryException ex3 = new OutOfMemoryException();
			ex2 = ex3;
			goto IL_0c0e;
			IL_0339:
			bool flag17 = list == null;
			rectTransform2 = rectTransform;
			list2 = (List<object>)(object)comparison;
			if (!flag17)
			{
				goto IL_0366;
			}
			goto IL_0785;
			IL_0785:
			enumerator3 = (List<object>.Enumerator)0;
			throw new NullReferenceException();
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
			object obj2 = (nint)0 + (nint)832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private sealed class <Start>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public Tutorial <>4__this;

		private IEnumerator <tutorialGamesUiIe>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <Start>d__12(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_015f: Expected I4, but got I8
			//IL_04b6: Expected I4, but got O
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Expected O, but got Unknown
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Expected O, but got Unknown
			//IL_0036: Expected I4, but got I8
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_007b: Expected I, but got O
			//IL_008b: Expected O, but got I
			//IL_0135: Expected O, but got I4
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Expected O, but got Unknown
			//IL_02a0: Expected O, but got I4
			//IL_00c6: Expected O, but got I
			//IL_02d4: Expected O, but got I
			//IL_030f: Expected O, but got I
			//IL_0204: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Expected O, but got Unknown
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Expected O, but got Unknown
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Expected O, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_0343: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Expected O, but got Unknown
			//IL_0365: Unknown result type (might be due to invalid IL or missing references)
			//IL_036a: Expected O, but got Unknown
			//IL_0390: Unknown result type (might be due to invalid IL or missing references)
			//IL_0395: Expected O, but got Unknown
			//IL_0436: Expected O, but got I
			//IL_0458: Expected O, but got I4
			//IL_03d2: Expected O, but got I
			Tutorial tutorial = <>4__this;
			object obj7 = default(object);
			object obj8;
			if (<>1__state != 0)
			{
				if (<>1__state != 1)
				{
					goto IL_0484;
				}
				<>1__state = -1;
				IEnumerator enumerator = <tutorialGamesUiIe>5__2;
				if (<tutorialGamesUiIe>5__2 != null)
				{
					object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
					nint num = (nint)enumerator;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v11 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v11 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0107;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v11 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X10_v10-8]");
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
						goto IL_0107;
					}
					object obj4 = obj3 + 1;
					object obj5 = num + obj4;
					object obj6 = obj5 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v330 @ X0_v32] (should have been resolved before IL gen)");
					bool flag = obj7 == null;
					obj8 = obj7;
					if (!flag)
					{
						goto IL_0253;
					}
					goto IL_0303;
				}
			}
			else
			{
				<>1__state = -1;
				if ((object)<>4__this != null)
				{
					IEnumerator enumerator2 = <>4__this.InitializeTutorialGamesUiIe(tutorial._tutorialsPagesParent, tutorial._tutorialButtonsParent, tutorial._tutorialButtonPrefab, tutorial._discreteProgressIndicator);
					object obj9 = this + 40;
					obj9 = enumerator2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj10 = this + 24;
					obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					goto IL_0484;
				}
			}
			goto IL_049a;
			IL_0107:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v297 @ X0_v29] (should have been resolved before IL gen)");
			bool flag2 = obj7 == null;
			object obj11 = !flag2;
			if (obj11 != null)
			{
				goto IL_0253;
			}
			obj8 = obj7;
			goto IL_0303;
			IL_0503:
			Tutorial tutorial2;
			RoutingCommand routingCommand;
			tutorial2.ShowPage(routingCommand, tutorial._allTutorialsGameUis, tutorial._allTutorialsPages, tutorial._discreteProgressIndicator);
			goto IL_0484;
			IL_0484:
			return <>1__state == 0;
			IL_0253:
			object obj12 = typeof(Queue<string>) + 2576;
			object obj13 = obj12;
			object obj14 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v26+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X1_v16+130]");
			bool flag3 = num2 < 0;
			object obj15 = !flag3;
			object obj16 = ~obj15;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v26+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X1_v16+130]");
				object obj17 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v28-8]");
				bool flag4 = 0 != (nint)obj13;
				obj8 = obj7;
				if (!flag4)
				{
					goto IL_0303;
				}
			}
			goto IL_04a8;
			IL_03ff:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v20+10]");
			routingCommand = RoutingCommand.NO_MESSAGE;
			goto IL_0503;
			IL_04a8:
			InvalidCastException ex = new InvalidCastException();
			return (byte)(int)ex != 0;
			IL_0303:
			object obj18 = (nint)0 + (nint)2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050028");
			if ((object)<>4__this == null)
			{
				goto IL_049a;
			}
			object obj19 = <>4__this + 64;
			object obj20 = default(object);
			obj19 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj21 = <>4__this + 72;
			object obj22 = default(object);
			obj21 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj23 = typeof(RegisteredWaitHandle) + 1552;
			tutorial2 = (Tutorial)obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v22 (Tutorial)+E4]");
			Tutorial tutorial3;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v22 (Tutorial)+B8]");
				object obj24 = 0;
				object obj25 = obj24;
				bool flag5 = obj24 == null;
				tutorial3 = tutorial2;
				if (!flag5)
				{
					goto IL_03ff;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				tutorial2 = (Tutorial)obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v22 (Tutorial)+B8]");
				object obj26 = 0;
				object obj25 = obj26;
				bool flag6 = obj26 == null;
				object obj27 = !flag6;
				tutorial3 = tutorial2;
				if (obj27 != null)
				{
					goto IL_03ff;
				}
			}
			routingCommand = RoutingCommand.NO_MESSAGE;
			tutorial2 = tutorial3;
			goto IL_0503;
			IL_049a:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_04a8;
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
			object obj2 = (nint)0 + (nint)840;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private Button _tutorialButtonPrefab;

	private RectTransform _tutorialButtonsParent;

	private RectTransform _tutorialsPagesParent;

	private DiscreteProgressIndicator _discreteProgressIndicator;

	private const string LabelUi = "TutorialUi";

	private static readonly List<string> Keys;

	private IList<TutorialGameUi> _allTutorialsGameUis;

	private List<TutorialPages> _allTutorialsPages;

	private List<Button> _allButtons;

	private IEnumerator InitializeTutorialGamesUiIe(RectTransform tutorialsPagesParent, RectTransform tutorialButtonsParent, Button tutorialButtonPrefab, DiscreteProgressIndicator discreteProgressIndicator)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 40;
		obj4 = tutorialsPagesParent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 48;
		obj5 = tutorialButtonsParent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 56;
		obj6 = tutorialButtonPrefab;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 64;
		obj7 = discreteProgressIndicator;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private TutorialPages InstantiateTutorialGame(RectTransform tutorialsPagesParent, TutorialGameUi tutorialGameUi, RectTransform tutorialButtonsParent, Button tutorialButtonPrefab, DiscreteProgressIndicator discreteProgressIndicator)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_0068: Expected O, but got I4
		//IL_00f6: Expected O, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		if ((object)tutorialGameUi != null)
		{
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = (nint)0 + (nint)1088;
			object obj3 = (nint)0 + (nint)488;
			TutorialPages pagesPrefab = tutorialGameUi.PagesPrefab;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			List<object> allButtons = (List<object>)(object)_allButtons;
			if (_allButtons != null)
			{
				int version = allButtons._version + 1;
				allButtons._version = version;
				object[] items = allButtons._items;
				if (allButtons._items != null)
				{
					bool flag2 = allButtons._size < items.Length;
					object obj6 = !flag2;
					object obj9 = default(object);
					if (obj6 == null)
					{
						int size = allButtons._size + 1;
						allButtons._size = size;
						object obj7 = allButtons._items + allButtons._size;
						object obj8 = obj7 + 32;
						obj8 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						((List<object>)(object)_allButtons).AddWithResize(obj9);
					}
					TutorialPages tutorialPages = default(TutorialPages);
					SetupButtons((Button)obj9, tutorialGameUi._tutorialButtonText, tutorialPages, tutorialGameUi._numberOfPages, discreteProgressIndicator);
					return tutorialPages;
				}
			}
		}
		return (TutorialPages)(object)new NullReferenceException();
	}

	private void SetupButtons(Button tutorialButton, string tutorialButtonText, TutorialPages tutorialPages, int numberOfPages, DiscreteProgressIndicator discreteProgressIndicator)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b1: Expected O, but got I
		//IL_00e8: Expected I, but got O
		//IL_0148: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_0174: Expected I, but got O
		//IL_018e: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = tutorialPages;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = discreteProgressIndicator;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 40;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = (nint)0 + (nint)288;
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj8 = (nint)0 + (nint)816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, tutorialButtonText);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(obj2, (IntPtr)obj8);
		tutorialButton.m_OnClick.AddListener(unityAction);
		if (!ScreenUtility.IsTablet)
		{
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v6+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)800;
			UnityAction unityAction2 = default(UnityAction);
			unityAction2..ctor(obj2, (IntPtr)obj11);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v7+100]");
			((UnityEvent)0).AddListener(unityAction2);
		}
	}

	private IEnumerator Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private unsafe void ShowPage(RoutingCommand routingCommand, IList<TutorialGameUi> allTutorialsGameUis, List<TutorialPages> allTutorialsPages, DiscreteProgressIndicator discreteProgressIndicator)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_0045: Expected O, but got I
		//IL_133d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1342: Expected O, but got Unknown
		//IL_1351: Unknown result type (might be due to invalid IL or missing references)
		//IL_1356: Expected O, but got Unknown
		//IL_1365: Unknown result type (might be due to invalid IL or missing references)
		//IL_136a: Expected O, but got Unknown
		//IL_137a: Expected O, but got I
		//IL_0080: Expected O, but got I
		//IL_127f: Expected O, but got I
		//IL_12a0: Expected O, but got I4
		//IL_12b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b5: Expected O, but got Unknown
		//IL_12ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ef: Expected O, but got Unknown
		//IL_12ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1304: Expected O, but got Unknown
		//IL_11e7: Expected O, but got I4
		//IL_10e8: Expected I4, but got O
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_093f: Expected I4, but got O
		//IL_1142: Expected O, but got Ref
		//IL_114b: Expected O, but got I4
		//IL_01ca: Expected O, but got I
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00b1: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_16be: Expected O, but got I4
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected O, but got Unknown
		//IL_0979: Expected O, but got I
		//IL_1479: Unknown result type (might be due to invalid IL or missing references)
		//IL_147e: Expected O, but got Unknown
		//IL_149d: Expected O, but got Ref
		//IL_14ae: Expected O, but got I4
		//IL_14de: Expected O, but got I
		//IL_0205: Expected O, but got I
		//IL_13a7: Expected O, but got I
		//IL_13c8: Expected O, but got I4
		//IL_13d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13dd: Expected O, but got Unknown
		//IL_1412: Unknown result type (might be due to invalid IL or missing references)
		//IL_1417: Expected O, but got Unknown
		//IL_1427: Unknown result type (might be due to invalid IL or missing references)
		//IL_142c: Expected O, but got Unknown
		//IL_09b4: Expected O, but got I
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_0add: Expected O, but got I4
		//IL_16ec: Expected O, but got I
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0236: Expected O, but got I
		//IL_0250: Expected O, but got I4
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected O, but got Unknown
		//IL_0b07: Expected I, but got O
		//IL_0b17: Expected O, but got I
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3c: Expected O, but got Unknown
		//IL_036c: Expected O, but got I
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c7: Expected O, but got Unknown
		//IL_09dd: Expected O, but got I
		//IL_1773: Expected O, but got I
		//IL_0b52: Expected O, but got I
		//IL_15c3: Expected O, but got I
		//IL_03a7: Expected O, but got I
		//IL_173f: Expected O, but got I
		//IL_1504: Expected O, but got I
		//IL_1525: Expected O, but got I4
		//IL_1535: Unknown result type (might be due to invalid IL or missing references)
		//IL_153a: Expected O, but got Unknown
		//IL_156f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1574: Expected O, but got Unknown
		//IL_1584: Unknown result type (might be due to invalid IL or missing references)
		//IL_1589: Expected O, but got Unknown
		//IL_0bf4: Expected O, but got I
		//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc0: Expected O, but got Unknown
		//IL_0bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcd: Expected O, but got Unknown
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Expected O, but got Unknown
		//IL_04e1: Expected O, but got I
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		//IL_0b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Expected O, but got Unknown
		//IL_0b7b: Expected O, but got I
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03d8: Expected O, but got I
		//IL_03f2: Expected O, but got I4
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected O, but got Unknown
		//IL_0c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c50: Expected O, but got Unknown
		//IL_0c91: Expected I4, but got O
		//IL_051e: Expected O, but got I
		//IL_0540: Expected O, but got I4
		//IL_0556: Expected O, but got I
		//IL_058a: Expected O, but got I
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		//IL_06e8: Expected O, but got I4
		//IL_0cce: Expected I4, but got O
		//IL_08bd: Expected O, but got Ref
		//IL_08ce: Expected O, but got I4
		//IL_05f6: Expected O, but got I
		//IL_1618: Unknown result type (might be due to invalid IL or missing references)
		//IL_161d: Expected O, but got Unknown
		//IL_1636: Expected O, but got I4
		//IL_163e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1643: Expected O, but got Unknown
		//IL_1668: Unknown result type (might be due to invalid IL or missing references)
		//IL_166d: Expected O, but got Unknown
		//IL_1675: Unknown result type (might be due to invalid IL or missing references)
		//IL_167a: Expected O, but got Unknown
		//IL_0cf2: Expected O, but got I
		//IL_0771: Expected I4, but got O
		//IL_079b: Expected O, but got I4
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		//IL_062b: Expected O, but got I4
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_0df4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df9: Expected O, but got Unknown
		//IL_0e0f: Expected O, but got I
		//IL_0e20: Expected I, but got O
		//IL_0e34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e39: Expected O, but got Unknown
		//IL_0e63: Expected O, but got I4
		//IL_0ed4: Expected I4, but got O
		//IL_0efa: Expected O, but got I
		//IL_0f33: Expected I4, but got O
		//IL_1010: Expected O, but got I
		//IL_105b: Expected I4, but got O
		//IL_10aa: Expected I4, but got O
		//IL_10d1: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = allTutorialsGameUis == null;
		List<TutorialPages> list = allTutorialsPages;
		IList<TutorialGameUi> list2 = allTutorialsGameUis;
		int num = 0;
		IList<TutorialGameUi> list3 = allTutorialsGameUis;
		if (flag)
		{
			goto IL_1261;
		}
		object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3824;
		nint num2 = (nint)allTutorialsGameUis;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v40 (Il2CppClass<System.Collections.Generic.IList`1<TutorialGameUi>>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v40 (Il2CppClass<System.Collections.Generic.IList`1<TutorialGameUi>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_015e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v40 (Il2CppClass<System.Collections.Generic.IList`1<TutorialGameUi>>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		bool flag3 = default(bool);
		bool flag2 = flag3;
		object obj6 = default(object);
		object obj12 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X10_v41-8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X10_v41-8]");
			bool flag4 = 0 < (nint)obj3;
			object obj7 = !flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X10_v41-8]");
			object obj8 = 0 - obj3;
			bool flag5 = (nint)obj8 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X10_v41-8]");
			bool flag6 = 0 == (nint)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X10_v41-8]");
			object obj9 = 0 ^ obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X10_v41-8]");
			object obj10 = 0 ^ obj8;
			object obj11 = obj9 & obj10;
			bool flag7 = (nint)obj11 < 0;
			if (flag6)
			{
				break;
			}
			obj12 = obj5 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v40 (Il2CppClass<System.Collections.Generic.IList`1<TutorialGameUi>>)+12E]");
			obj4 = -1;
			bool flag8 = (nint)obj4 < 1;
			obj7 = !flag8;
			obj8 = obj4 - 1;
			flag5 = (nint)obj8 < 0;
			flag6 = obj8 == null;
			obj9 = obj4 ^ 1;
			obj10 = obj4 ^ obj8;
			obj11 = obj9 & obj10;
			flag7 = (nint)obj11 < 0;
			flag3 = (nint)obj4 != 1;
			flag2 = flag3;
			obj5 = obj12;
			if (flag3)
			{
				continue;
			}
			goto IL_015e;
		}
		obj4 = obj5;
		object obj13 = num2 + obj5;
		object obj14 = obj13 + 312;
		IList<TutorialGameUi> list4 = allTutorialsGameUis;
		flag3 = flag2;
		obj12 = obj5;
		goto IL_132e;
		IL_1710:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v52+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v732 @ X0_v52] (should have been resolved before IL gen)");
		goto IL_16a4;
		IL_0ba3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1763;
		IL_1763:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X0_v21+8]");
		list2 = (IList<TutorialGameUi>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v853 @ X0_v21] (should have been resolved before IL gen)");
		bool flag9 = allTutorialsPages == null;
		object obj15;
		obj6 = obj15;
		object obj16;
		obj12 = obj16;
		int num3 = default(int);
		num = num3;
		UnityEngine.Object obj20 = default(UnityEngine.Object);
		int num4 = default(int);
		if (!flag9)
		{
			object obj17 = (nint)0 + (nint)1872;
			list2 = (IList<TutorialGameUi>)obj17;
			object obj18 = ((List<object>)(object)allTutorialsPages).get_Item(num3);
			bool flag10 = obj2 == null;
			obj6 = obj15;
			obj12 = obj16;
			num = num3;
			if (!flag10)
			{
				obj = obj2 + 16;
				obj = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj19 = obj;
				bool flag11 = obj == null;
				obj6 = obj15;
				obj12 = obj16;
				num = (int)obj18;
				if (!flag11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v18+38]");
					bool flag12 = (nint)0 == 0;
					obj6 = obj15;
					obj12 = obj16;
					num = (int)obj18;
					if (!flag12)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v18+38]");
						((GameObject)0).SetActive(value: true);
						bool flag13 = (object)discreteProgressIndicator == null;
						obj6 = obj15;
						list2 = null;
						obj12 = obj16;
						num = 1;
						if (!flag13)
						{
							GameObject gameObject = discreteProgressIndicator.gameObject;
							bool flag14 = (object)gameObject == null;
							obj6 = obj15;
							list2 = null;
							obj12 = obj16;
							num = 0;
							if (!flag14)
							{
								gameObject.SetActive(value: true);
								bool flag15 = (object)obj20 == null;
								obj6 = obj15;
								list2 = null;
								obj12 = obj16;
								num = 1;
								if (!flag15)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X24_v3 (UnityEngine.Object)+38]");
									discreteProgressIndicator.SetupNumberProgress(0);
									discreteProgressIndicator.CurrentProgress = num4;
									object obj21 = typeof(SqlSingle[]) + 2376;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj22 = (nint)0 + (nint)824;
									Action action = default(Action);
									action..ctor(obj2, (IntPtr)obj22);
									object obj23 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
									object obj24 = obj23;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X0_v35+E4]");
									bool flag16 = (nint)0 == 0;
									object obj25 = !flag16;
									if (obj25 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									int n = num4 - 1;
									KUtil.Repeat(n, action);
									object obj26 = obj;
									bool flag17 = obj == null;
									obj6 = obj15;
									list = null;
									list2 = null;
									obj12 = obj16;
									num = (int)action;
									list3 = (IList<TutorialGameUi>)(object)action;
									if (!flag17)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v26+30]");
										object obj27 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v26+30]");
										bool flag18 = (nint)0 == 0;
										obj6 = obj15;
										list = null;
										list2 = null;
										obj12 = obj16;
										num = (int)action;
										list3 = (IList<TutorialGameUi>)(object)action;
										if (!flag18)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v27+78]");
											num = (discreteProgressIndicator.CurrentProgress = (int)((nint)0 + (nint)1));
											object obj28 = obj;
											bool flag19 = obj == null;
											obj6 = obj15;
											list = null;
											list2 = null;
											obj12 = obj16;
											list3 = (IList<TutorialGameUi>)(object)action;
											if (!flag19)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v29+28]");
												bool flag20 = (nint)0 == 0;
												obj6 = obj15;
												list = null;
												list2 = null;
												obj12 = obj16;
												list3 = (IList<TutorialGameUi>)(object)action;
												if (!flag20)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v29+28]");
													object obj29 = (nint)0 + (nint)56;
													obj29 = discreteProgressIndicator;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													object obj30 = obj;
													bool flag21 = obj == null;
													obj6 = obj15;
													list = null;
													list2 = null;
													obj12 = obj16;
													num = (int)discreteProgressIndicator;
													list3 = (IList<TutorialGameUi>)(object)action;
													if (!flag21)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v30+28]");
														bool flag22 = (nint)0 == 0;
														obj6 = obj15;
														list = null;
														list2 = null;
														obj12 = obj16;
														num = (int)discreteProgressIndicator;
														list3 = (IList<TutorialGameUi>)(object)action;
														if (!flag22)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v30+28]");
															((PageScrollButtonsHandler)0).CheckPreviousAndNextButtons();
															return;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_1261;
		IL_1261:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1180;
		IL_0a05:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		list2 = null;
		goto IL_1710;
		IL_015e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		list4 = null;
		goto IL_132e;
		IL_132e:
		object obj31 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1280;
		object obj32 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v58+8]");
		UnityEngine.Object obj33 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v345 @ X0_v58] (should have been resolved before IL gen)");
		UnityEngine.Object obj34 = null;
		int num6 = 0;
		object obj35 = default(object);
		UnityEngine.Object obj51 = default(UnityEngine.Object);
		object obj56 = default(object);
		object obj58 = default(object);
		UnityEngine.Object obj60;
		object obj59;
		bool flag41;
		object obj37;
		do
		{
			IL_15ea:
			object obj7;
			object obj8;
			bool flag5;
			bool flag6;
			object obj9;
			object obj10;
			object obj11;
			bool flag7;
			if (obj35 != null)
			{
				object obj36 = obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v46+12E]");
				obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v46+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02e3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v46+B0]");
				object obj38 = (nint)0 + (nint)8;
				bool flag23 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X10_v36-8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X10_v36-8]");
					bool flag24 = 0 < (nint)obj31;
					obj7 = !flag24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X10_v36-8]");
					obj8 = 0 - obj31;
					flag5 = (nint)obj8 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X10_v36-8]");
					flag6 = 0 == (nint)obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X10_v36-8]");
					obj9 = 0 ^ obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X10_v36-8]");
					obj10 = 0 ^ obj8;
					obj11 = obj9 & obj10;
					flag7 = (nint)obj11 < 0;
					if (flag6)
					{
						break;
					}
					obj12 = obj38 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v46+12E]");
					obj37 = -1;
					bool flag25 = (nint)obj37 < 1;
					obj7 = !flag25;
					obj8 = obj37 - 1;
					flag5 = (nint)obj8 < 0;
					flag6 = obj8 == null;
					obj9 = obj37 ^ 1;
					obj10 = obj37 ^ obj8;
					obj11 = obj9 & obj10;
					flag7 = (nint)obj11 < 0;
					flag3 = (nint)obj37 != 1;
					flag23 = flag3;
					obj38 = obj12;
					if (flag3)
					{
						continue;
					}
					goto IL_02e3;
				}
				obj37 = obj38;
				object obj39 = obj36 + obj38;
				object obj40 = obj39 + 312;
				list2 = list4;
				flag3 = flag23;
				obj12 = obj38;
				goto IL_1456;
			}
			NullReferenceException ex2 = new NullReferenceException();
			num = (int)obj33;
			goto IL_1131;
			IL_0819:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object obj41;
			obj34 = obj41;
			int num7;
			num6 = num7;
			bool flag26;
			flag3 = flag26;
			bool flag27;
			flag7 = flag27;
			object obj42;
			obj11 = obj42;
			object obj43;
			obj10 = obj43;
			object obj44;
			obj9 = obj44;
			bool flag28;
			flag6 = flag28;
			bool flag29;
			flag5 = flag29;
			object obj45;
			obj8 = obj45;
			object obj46;
			obj7 = obj46;
			object obj47;
			obj12 = obj47;
			object obj48;
			obj4 = obj48;
			goto IL_0890;
			IL_06be:
			object obj49 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X0_v75+E4]");
			bool flag30 = (nint)0 == 0;
			object obj50 = !flag30;
			if (obj50 == null)
			{
				obj41 = obj34;
				num7 = num6;
				flag26 = flag3;
				flag27 = flag7;
				obj42 = obj11;
				obj43 = obj10;
				obj44 = obj9;
				flag28 = flag6;
				flag29 = flag5;
				obj45 = obj8;
				obj46 = obj7;
				obj47 = obj12;
				obj48 = obj4;
				goto IL_0819;
			}
			goto IL_0890;
			IL_0485:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			list2 = null;
			goto IL_15b3;
			IL_15b3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X0_v68+8]");
			obj33 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v779 @ X0_v68] (should have been resolved before IL gen)");
			if ((object)obj51 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v70 (UnityEngine.Object)+30]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v70 (UnityEngine.Object)+30]");
				bool flag31 = (nint)0 == 0;
				list4 = list2;
				if (flag31)
				{
					goto IL_15ea;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v28+18]");
				object obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v28+18]");
				bool flag32 = (nint)0 < (nint)1;
				obj7 = !flag32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v28+18]");
				obj8 = -1;
				flag5 = (nint)obj8 < 0;
				flag6 = obj8 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v28+18]");
				obj9 = (nint)0 ^ (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v28+18]");
				obj10 = 0 ^ obj8;
				obj11 = obj9 & obj10;
				flag7 = (nint)obj11 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v28+18]");
				flag3 = (nint)0 < (nint)1;
				if (flag3)
				{
					goto IL_06be;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v70 (UnityEngine.Object)+30]");
				object obj53 = (nint)0 + (nint)32;
				flag26 = flag3;
				while (true)
				{
					obj12 = obj53;
					obj4 = obj53 + 8;
					bool flag33 = (nint)routingCommand < (nint)obj53;
					obj46 = !flag33;
					obj45 = routingCommand - obj53;
					flag29 = (nint)obj45 < 0;
					flag28 = (nint)routingCommand == (nint)obj53;
					obj44 = routingCommand ^ obj53;
					obj43 = routingCommand ^ obj45;
					obj42 = obj44 & obj43;
					flag27 = (nint)obj42 < 0;
					if (flag28)
					{
						break;
					}
					obj52--;
					bool flag34 = (nint)obj52 < 1;
					obj7 = !flag34;
					obj8 = obj52 - 1;
					flag5 = (nint)obj8 < 0;
					flag6 = obj8 == null;
					obj9 = obj52 ^ 1;
					obj10 = obj52 ^ obj8;
					obj11 = obj9 & obj10;
					flag7 = (nint)obj11 < 0;
					flag3 = (nint)obj52 != 1;
					flag26 = flag3;
					obj53 = obj4;
					if (flag3)
					{
						continue;
					}
					goto IL_06be;
				}
				num7 = obj53 >> 32;
				obj49 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X0_v75+E4]");
				bool flag35 = (nint)0 == 0;
				object obj54 = !flag35;
				obj41 = obj51;
				obj47 = obj53;
				obj48 = obj4;
				obj34 = obj51;
				num6 = num7;
				flag3 = flag26;
				flag7 = flag27;
				obj11 = obj42;
				obj10 = obj43;
				obj9 = obj44;
				flag6 = flag28;
				flag5 = flag29;
				obj8 = obj45;
				obj7 = obj46;
				if (obj54 == null)
				{
					goto IL_0819;
				}
				goto IL_0890;
			}
			NullReferenceException ex3 = new NullReferenceException();
			list4 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X0_v68+8]");
			num = 0;
			goto IL_1131;
			IL_02e3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			list2 = null;
			goto IL_1456;
			IL_1456:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v64+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v545 @ X0_v64] (should have been resolved before IL gen)");
			object obj55 = obj56 & 1;
			bool flag36 = obj55 == null;
			object obj57 = obj35;
			obj58 = (object)(&obj57);
			obj15 = obj6;
			obj59 = 0;
			list = allTutorialsPages;
			obj20 = obj34;
			num4 = num6;
			obj16 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v64+8]");
			obj60 = (UnityEngine.Object)0;
			list3 = allTutorialsGameUis;
			if (flag36)
			{
				break;
			}
			if (obj35 != null)
			{
				object obj61 = obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v49+12E]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v49+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0485;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v49+B0]");
				object obj62 = (nint)0 + (nint)8;
				bool flag37 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X10_v31-8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X10_v31-8]");
					bool flag38 = 0 < (nint)obj;
					obj7 = !flag38;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X10_v31-8]");
					obj8 = 0 - obj;
					flag5 = (nint)obj8 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X10_v31-8]");
					flag6 = 0 == (nint)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X10_v31-8]");
					obj9 = 0 ^ obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X10_v31-8]");
					obj10 = 0 ^ obj8;
					obj11 = obj9 & obj10;
					flag7 = (nint)obj11 < 0;
					if (flag6)
					{
						break;
					}
					obj12 = obj62 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v49+12E]");
					obj4 = -1;
					bool flag39 = (nint)obj4 < 1;
					obj7 = !flag39;
					obj8 = obj4 - 1;
					flag5 = (nint)obj8 < 0;
					flag6 = obj8 == null;
					obj9 = obj4 ^ 1;
					obj10 = obj4 ^ obj8;
					obj11 = obj9 & obj10;
					flag7 = (nint)obj11 < 0;
					flag3 = (nint)obj4 != 1;
					flag37 = flag3;
					obj62 = obj12;
					if (flag3)
					{
						continue;
					}
					goto IL_0485;
				}
				obj4 = obj62;
				object obj63 = obj61 + obj62;
				object obj64 = obj63 + 312;
				flag3 = flag37;
				obj12 = obj62;
				goto IL_15b3;
			}
			NullReferenceException ex4 = new NullReferenceException();
			list4 = list2;
			obj4 = obj37;
			goto IL_1131;
			IL_1131:
			obj57 = obj35;
			obj58 = (object)(&obj57);
			obj59 = 0;
			list = allTutorialsPages;
			obj20 = obj34;
			num4 = num6;
			list2 = list4;
			obj37 = obj4;
			list3 = allTutorialsGameUis;
			goto IL_1261;
			IL_0890:
			bool flag40 = obj34 != null;
			flag41 = !flag40;
			obj57 = obj35;
			obj58 = (object)(&obj57);
			obj15 = obj6;
			obj59 = 0;
			list = allTutorialsPages;
			obj20 = obj34;
			num4 = num6;
			list2 = null;
			obj16 = obj12;
			obj37 = obj4;
			obj60 = null;
			list3 = allTutorialsGameUis;
			list4 = null;
			obj33 = null;
		}
		while (flag41);
		goto IL_0920;
		IL_0920:
		object obj65 = obj58;
		bool flag42 = obj58 == null;
		num = (int)obj60;
		if (flag42)
		{
			goto IL_16a4;
		}
		object obj66 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj67 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v34+12E]");
		obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v34+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0a05;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v34+B0]");
		object obj68 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X10_v16-8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X10_v16-8]");
			if (0 == (nint)obj66)
			{
				break;
			}
			obj16 = obj68 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v34+12E]");
			obj37 = -1;
			bool flag43 = (nint)obj37 != 1;
			obj68 = obj16;
			if (flag43)
			{
				continue;
			}
			goto IL_0a05;
		}
		obj37 = obj68;
		object obj69 = obj67 + obj68;
		object obj70 = obj69 + 312;
		obj16 = obj68;
		goto IL_1710;
		IL_16a4:
		bool flag44 = obj59 == null;
		object obj71 = !flag44;
		obj6 = obj15;
		obj12 = obj16;
		if (obj71 != null)
		{
			goto IL_1180;
		}
		object obj72 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v18+E4]");
		if ((nint)0 != 0)
		{
			if (obj20 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag45 = obj20 == null;
			bool flag46 = !flag45;
			object obj73 = !flag46;
			if (obj73 != null)
			{
				return;
			}
		}
		object obj74 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1944;
		nint num8 = (nint)list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v13 (Il2CppClass<System.Collections.Generic.IList`1<TutorialGameUi>>)+12E]");
		obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v13 (Il2CppClass<System.Collections.Generic.IList`1<TutorialGameUi>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0ba3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v13 (Il2CppClass<System.Collections.Generic.IList`1<TutorialGameUi>>)+B0]");
		object obj75 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X10_v10-8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X10_v10-8]");
			if (0 == (nint)obj74)
			{
				break;
			}
			obj16 = obj75 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v13 (Il2CppClass<System.Collections.Generic.IList`1<TutorialGameUi>>)+12E]");
			obj37 = -1;
			bool flag47 = (nint)obj37 != 1;
			obj75 = obj16;
			if (flag47)
			{
				continue;
			}
			goto IL_0ba3;
		}
		obj37 = obj75 + 2;
		object obj76 = num8 + obj37;
		object obj77 = obj76 + 312;
		obj16 = obj75;
		goto IL_1763;
		IL_1180:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		if (num == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj15 = obj6;
			object obj78 = default(object);
			obj59 = obj78;
			obj16 = obj12;
			obj60 = (UnityEngine.Object)num;
			goto IL_0920;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void GoBackToMenu()
	{
		SFS.BackFromOffline();
	}

	public static RoutingCommand GetTutorialTransitionMessage()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004c: Expected O, but got I
		//IL_0034: Expected I4, but got O
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+20]");
			return RoutingCommand.NO_MESSAGE;
		}
		NullReferenceException ex = new NullReferenceException();
		return (RoutingCommand)ex;
	}

	public Tutorial()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 4088;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 72;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj4 = this + 80;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	static Tutorial()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		//IL_0118: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = "ThisIsFakeReceiptData" + 2696;
		object obj3 = (nint)0 + (nint)3072;
		object obj4 = obj3;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2264;
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
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6+20]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9+C0]");
			object obj10 = 0;
			list.AddWithResize(obj2);
		}
		object obj11 = obj5;
		object obj12 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
