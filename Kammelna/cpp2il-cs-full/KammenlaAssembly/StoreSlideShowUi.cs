using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Spine;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class StoreSlideShowUi : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<AbstractSlideShowPage> <>9__5_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Awake>b__5_0(AbstractSlideShowPage page)
		{
			//IL_0008: Expected I, but got O
			//IL_0018: Expected O, but got I
			//IL_0028: Expected O, but got I
			nint num = (nint)page;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<AbstractSlideShowPage>)+1A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<AbstractSlideShowPage>)+1B0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <AutoNext>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public float waiting;

		public StoreSlideShowUi <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <AutoNext>d__11(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00e5: Expected I4, but got I8
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0040: Expected I4, but got I8
			//IL_0152: Expected I4, but got O
			//IL_009e: Expected O, but got I4
			//IL_00d1: Expected I4, but got I8
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					StoreSlideShowUi storeSlideShowUi = <>4__this;
					<>1__state = -1;
					if ((object)<>4__this != null)
					{
						AbstractSlideShowPage[] pages = storeSlideShowUi.pages;
						if (storeSlideShowUi.pages != null)
						{
							object obj = pages.Length - 1;
							if (storeSlideShowUi.currentPage >= (nint)obj)
							{
								storeSlideShowUi.currentPage = -1;
							}
							<>4__this.Next(7f);
							goto IL_0171;
						}
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
			}
			else
			{
				<>1__state = -1;
				object obj2 = typeof(UsageHint) + 1640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				WaitForSeconds waitForSeconds = default(WaitForSeconds);
				waitForSeconds..ctor(waiting);
				object obj3 = this + 24;
				obj3 = waitForSeconds;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				<>1__state = 1;
			}
			goto IL_0171;
			IL_0171:
			return <>1__state == 0;
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
			object obj2 = (nint)0 + (nint)1744;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private DiscreteProgressIndicator pagination;

	private AbstractSlideShowPage[] pages;

	private int currentPage;

	private RectTransform slidesParent;

	private StoreSlidesGroupAsset slidesGroupAsset;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_005e: Expected O, but got I4
		//IL_00b2: Expected O, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_010d: Expected O, but got I
		//IL_013e: Expected O, but got I
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0273: Expected O, but got I
		//IL_0283: Expected O, but got I
		//IL_02a5: Expected O, but got I4
		//IL_02c6: Expected O, but got I
		//IL_023d: Expected O, but got I4
		//IL_01b4: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_01fc: Expected O, but got I
		//IL_02f6: Expected O, but got I4
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_0446: Expected O, but got I
		//IL_0457: Expected I, but got O
		//IL_0475: Expected O, but got I
		//IL_0326: Expected O, but got I
		Action<object> action;
		IEnumerable<object> enumeration;
		AbstractSlideShowPage[] array2;
		if ((object)slidesGroupAsset != null)
		{
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = (nint)0 + (nint)736;
			StoreSlideGroup currentSlideGroup = slidesGroupAsset.GetCurrentSlideGroup();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			object obj5 = default(object);
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v9+28]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v9+28]");
					object[] array = ((List<object>)0).ToArray();
					object obj6 = this + 40;
					obj6 = array;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj7 = obj6;
					if (obj6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8+20]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8+20]");
						if ((nint)0 != 0)
						{
							object obj9 = (nint)0 + (nint)584;
							object obj10 = typeof(SkeletonBinary.SkeletonInput) + 1576;
							object obj11 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v197 @ X8_v9+188] (should have been resolved before IL gen)");
							IEnumerable<object> enumerable = Enumerable.Skip((IEnumerable<object>)obj6, 1);
							object obj12 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v22+E4]");
							object obj13;
							IEnumerable<object> enumeration2;
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v22+B8]");
								obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+8]");
								action = (Action<object>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+8]");
								bool flag2 = (nint)0 == 0;
								enumeration = enumerable;
								enumeration2 = enumerable;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+8]");
								Action<object> action2 = (Action<object>)0;
								if (!flag2)
								{
									goto IL_020a;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj12 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v22+B8]");
								obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+8]");
								action = (Action<object>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+8]");
								bool flag3 = (nint)0 == 0;
								object obj14 = !flag3;
								enumeration = enumerable;
								enumeration2 = enumerable;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+8]");
								Action<object> action2 = (Action<object>)0;
								if (obj14 != null)
								{
									goto IL_020a;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v22+E4]");
							bool flag4 = (nint)0 == 0;
							object obj15 = !flag4;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj16 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v20+B8]");
								obj13 = 0;
							}
							object obj17 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1000;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj18 = (nint)0 + (nint)1736;
							Action<object> action3 = default(Action<object>);
							action3..ctor(obj13, (IntPtr)obj18);
							object obj19 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v18+B8]");
							object obj20 = (nint)0 + (nint)8;
							obj20 = action3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							ArraysExtensions.ForEach(enumeration2, action3);
							array2 = pages;
							if (pages != null)
							{
								goto IL_0361;
							}
						}
					}
				}
			}
		}
		goto IL_03c1;
		IL_03c1:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0361:
		if ((object)pagination != null)
		{
			pagination.MaxProgress = array2.Length;
			if ((object)pagination != null)
			{
				pagination.CurrentProgress = 1;
				return;
			}
		}
		goto IL_03c1;
		IL_020a:
		ArraysExtensions.ForEach(enumeration, action);
		array2 = pages;
		bool flag5 = pages == null;
		object obj21 = !flag5;
		if (obj21 != null)
		{
			goto IL_0361;
		}
		goto IL_03c1;
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 1084227584;
		Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
	}

	public void OnSwipe(SwipeGesture swipe)
	{
		if (swipe.CardinalDirection != GestureDirection.Left)
		{
			if (swipe.CardinalDirection == GestureDirection.Right)
			{
				Next(12f);
			}
		}
		else
		{
			Previous();
		}
	}

	private void SwitchPage()
	{
		//IL_0037: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_0109: Expected I, but got O
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_00c9: Expected I, but got O
		//IL_0138: Expected I, but got O
		//IL_00fc: Expected O, but got I4
		int currentProgress = currentPage + 1;
		pagination.CurrentProgress = currentProgress;
		AbstractSlideShowPage[] array = pages;
		object obj = 0;
		object obj2 = 0;
		object obj4 = default(object);
		while ((nint)obj < array.Length)
		{
			object obj3 = (object)array + obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v5+20]");
			Component component = (Component)0;
			if ((nint)obj == currentPage)
			{
				nint num = (nint)component;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v72 @ X8_v9 (Il2CppClass<UnityEngine.Component>)+188] (should have been resolved before IL gen)");
				GameObject gameObject = component.gameObject;
				gameObject.SetActive(value: true);
				obj2 = 0;
			}
			else
			{
				nint num2 = (nint)component;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v154 @ X8_v7 (Il2CppClass<UnityEngine.Component>)+178] (should have been resolved before IL gen)");
				if (obj4 != null)
				{
					nint num3 = (nint)component;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ X8_v8 (Il2CppClass<UnityEngine.Component>)+198] (should have been resolved before IL gen)");
				}
			}
			obj++;
			array = pages;
		}
	}

	public void Next(float waiting)
	{
		//IL_0025: Expected O, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		StopAllCoroutines();
		AbstractSlideShowPage[] array = pages;
		object obj = array.Length - 1;
		if (currentPage < (nint)obj)
		{
			int num = currentPage + 1;
			currentPage = num;
			SwitchPage();
			object obj2 = typeof(SkeletonBinary.SkeletonInput) + 1584;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = default(object);
			obj3..ctor();
			_ = 0;
			object obj4 = obj3 + 40;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Coroutine coroutine = StartCoroutine((IEnumerator)obj3);
		}
	}

	public void Previous()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		StopAllCoroutines();
		int num = currentPage - 1;
		if (num >= 1)
		{
			currentPage = num;
			SwitchPage();
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1584;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			_ = 0;
			object obj3 = obj2 + 40;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1094713344;
			Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
		}
	}

	private IEnumerator AutoNext(float waiting)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}
}
