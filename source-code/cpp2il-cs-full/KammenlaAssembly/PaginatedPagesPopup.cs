using System;
using System.Buffers.Text;
using System.Collections;
using System.Data;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.TextCore;

public class PaginatedPagesPopup : MonoBehaviour, IInitializable
{
	private PopupUI popupUi;

	private RectTransform pagesParent;

	private DiscreteProgressIndicator pagination;

	private int _currentPage;

	private int _numPages;

	private float ItemsSpacing
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0052: Expected O, but got I4
			//IL_0091: Invalid comparison between F4 and I4
			//IL_00a0: Invalid comparison between F4 and I4
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_00c1: Expected O, but got F4
			//IL_00f6: Expected O, but got I4
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			//IL_0123: Expected F4, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			Rect rect = pagesParent.rect;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num = ScreenUtility.CanvasWidth;
			float num3 = default(float);
			float num2 = num3 - 1.1762565E+09f;
			bool flag2 = num2 < 0f;
			bool flag3 = num2 == 0f;
			object obj4 = num3 ^ 0x461C4000;
			object obj5 = num3 ^ num2;
			object obj6 = obj4 & obj5;
			bool flag4 = (nint)obj6 < 0;
			bool flag5 = flag2 == flag4;
			object obj7 = !flag3;
			object obj8 = flag5 & obj7;
			object obj9 = ~obj8;
			float num4 = ((obj9 != null) ? num3 : 1.1762565E+09f);
			if (!(num3 < num))
			{
				num = num4;
			}
			return num;
		}
	}

	private unsafe void Start()
	{
		//IL_0807: Expected O, but got I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I4
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_09ef: Expected I, but got O
		//IL_09ff: Expected O, but got I
		//IL_0192: Expected O, but got I4
		//IL_08eb: Expected I, but got O
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Expected O, but got Unknown
		//IL_012e: Expected O, but got I
		//IL_05ce: Expected O, but got I4
		//IL_05d7: Expected O, but got I4
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa3: Expected O, but got Unknown
		//IL_0aab: Expected I4, but got O
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_0a3e: Expected O, but got I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0157: Expected O, but got I
		//IL_05f4: Expected O, but got I
		//IL_01ec: Expected I, but got O
		//IL_01fc: Expected O, but got I
		//IL_068b: Expected O, but got I4
		//IL_029b: Expected O, but got I4
		//IL_062f: Expected O, but got I
		//IL_0237: Expected O, but got I
		//IL_0714: Expected O, but got I4
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected I, but got Unknown
		//IL_02de: Expected I4, but got O
		//IL_02e6: Expected I, but got O
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected O, but got Unknown
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0260: Expected O, but got I
		//IL_0363: Expected O, but got I4
		//IL_03a2: Invalid comparison between F4 and I4
		//IL_03b1: Invalid comparison between F4 and I4
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_03d2: Expected O, but got F4
		//IL_0407: Expected O, but got I4
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_0434: Expected F4, but got I4
		//IL_0495: Expected O, but got I4
		//IL_04e0: Expected O, but got I4
		//IL_053a: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7887]");
		nint num = 0;
		bool flag = (object)pagesParent == null;
		IntPtr intPtr = default(IntPtr);
		int num2 = (int)(nint)intPtr;
		int num3;
		float num4;
		float num6;
		object obj7;
		object obj9;
		object obj31;
		float num5 = default(float);
		float num7 = default(float);
		object obj8 = default(object);
		object obj10 = default(object);
		if (!flag)
		{
			num = (nint)0 + (nint)280;
			num2 = (int)num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
			Transform transform = default(Transform);
			if ((object)transform != null)
			{
				IEnumerator enumerator = transform.GetEnumerator();
				bool flag2 = enumerator == null;
				num2 = 0;
				object obj = default(object);
				num3 = (int)(&obj);
				if (flag2)
				{
					goto IL_058b;
				}
				object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
				object obj4 = 153100288 + 1024;
				object obj5 = typeof(DataRelation) + 856;
				object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
				num4 = num5;
				num6 = num7;
				obj7 = obj8;
				obj9 = obj10;
				IEnumerator enumerator2 = enumerator;
				object obj14 = default(object);
				object obj16 = default(object);
				IEnumerator enumerator3 = default(IEnumerator);
				RectTransform rectTransform = default(RectTransform);
				float num11 = default(float);
				object message = default(object);
				while (true)
				{
					nint num8 = (nint)enumerator2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v20 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v20 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_017f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v20 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
					object obj12 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v24-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj9 = obj12 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v20 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
						obj11 = -1;
						bool flag3 = (nint)obj11 != 1;
						obj12 = obj9;
						if (flag3)
						{
							continue;
						}
						goto IL_017f;
					}
					obj11 = obj12;
					object obj13 = num8 + obj12;
					obj14 = obj13 + 312;
					obj9 = obj12;
					goto IL_08e3;
					IL_08e3:
					num = (nint)obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v31+8]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v511 @ X0_v31] (should have been resolved before IL gen)");
					object obj15 = obj16 & 1;
					if (obj15 == null)
					{
						break;
					}
					if (enumerator3 == null)
					{
						goto IL_0772;
					}
					nint num9 = (nint)enumerator3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0288;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
					object obj17 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X10_v19-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj9 = obj17 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
						obj11 = -1;
						bool flag4 = (nint)obj11 != 1;
						obj17 = obj9;
						if (flag4)
						{
							continue;
						}
						goto IL_0288;
					}
					obj11 = obj17 + 1;
					object obj18 = num9 + obj11;
					object obj19 = obj18 + 312;
					obj9 = obj17;
					goto IL_0955;
					IL_0955:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v35+8]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v723 @ X0_v35] (should have been resolved before IL gen)");
					if ((object)rectTransform != null)
					{
						num2 = (int)obj6;
						num = (nint)rectTransform;
						if (rectTransform != obj6)
						{
							goto IL_07cb;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7886]");
					num = 0;
					if ((object)pagesParent == null)
					{
						goto IL_0742;
					}
					Rect rect = pagesParent.rect;
					object obj20 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v42+E4]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v42+E4]");
					bool flag5 = (nint)0 == 0;
					object obj21 = !flag5;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					num7 = ScreenUtility.CanvasWidth;
					float num10 = num11 - 1.1762565E+09f;
					bool flag6 = num10 < 0f;
					bool flag7 = num10 == 0f;
					object obj22 = num11 ^ 0x461C4000;
					object obj23 = num11 ^ num10;
					object obj24 = obj22 & obj23;
					bool flag8 = (nint)obj24 < 0;
					bool flag9 = flag6 == flag8;
					object obj25 = !flag7;
					object obj26 = flag9 & obj25;
					object obj27 = ~obj26;
					num5 = ((obj27 != null) ? num11 : 1.1762565E+09f);
					float num12 = ((!(num11 < num7)) ? num5 : num7);
					if ((object)rectTransform != null)
					{
						Vector2 anchoredPosition = rectTransform.anchoredPosition;
						float num13 = num12 * (float)_numPages;
						num7 = 0f - num13;
						rectTransform.anchoredPosition = (Vector2)0;
						Vector2 anchoredPosition2 = rectTransform.anchoredPosition;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object obj28 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X0_v53+E4]");
						bool flag10 = (nint)0 == 0;
						object obj29 = !flag10;
						if (obj29 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Debug.Log(message);
						num3 = ++_numPages;
						bool flag11 = enumerator3 == null;
						object obj30 = !flag11;
						float num14 = num7;
						obj8 = obj7;
						obj10 = obj9;
						num2 = 0;
						num14 = num7;
						num4 = num5;
						num6 = num7;
						enumerator2 = enumerator3;
						if (obj30 != null)
						{
							continue;
						}
						goto IL_058b;
					}
					goto IL_07a2;
					IL_0288:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj7 = 1;
					goto IL_0955;
					IL_017f:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj7 = 0;
					goto IL_08e3;
				}
				num5 = num4;
				num7 = num6;
				obj8 = obj7;
				obj10 = obj9;
				obj31 = 0;
				object obj32 = 0;
				object obj34 = default(object);
				object obj40 = default(object);
				IntPtr intPtr2 = default(IntPtr);
				while (true)
				{
					object obj33 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
					num2 = (int)obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj34 == null)
					{
						goto IL_0a24;
					}
					object obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v6+12E]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v6+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0678;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v6+B0]");
					object obj37 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X10_v7-8]");
						if (0 == (nint)obj33)
						{
							break;
						}
						obj10 = obj37 + 16;
						obj36--;
						bool flag12 = (nint)obj36 != 1;
						obj37 = obj10;
						if (flag12)
						{
							continue;
						}
						goto IL_0678;
					}
					object obj38 = obj35 + obj37;
					num = (nint)(obj38 + 312);
					obj10 = obj37;
					goto IL_0a70;
					IL_0a24:
					bool flag13 = obj32 == null;
					object obj39 = !flag13;
					if (obj39 != null)
					{
						OutOfMemoryException ex = new OutOfMemoryException();
						if (num2 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
							obj32 = obj40;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
							obj31 = obj40;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
						return;
					}
					break;
					IL_0678:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj8 = 0;
					num = intPtr2;
					goto IL_0a70;
					IL_0a70:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v4 (Il2CppClass<UnityEngine.RectTransform>)+8]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v199 @ X8_v4 (Il2CppClass<UnityEngine.RectTransform>)] (should have been resolved before IL gen)");
					goto IL_0a24;
				}
				if ((object)pagination != null)
				{
					num2 = _numPages;
					pagination.MaxProgress = _numPages;
					bool flag14 = (object)pagination == null;
					obj8 = 0;
					if (!flag14)
					{
						int currentProgress = _currentPage + 1;
						pagination.CurrentProgress = currentProgress;
						return;
					}
				}
			}
		}
		goto IL_08b3;
		IL_058b:
		NullReferenceException ex2 = new NullReferenceException();
		num = num3;
		goto IL_07fb;
		IL_0742:
		NullReferenceException ex3 = new NullReferenceException();
		num5 = num4;
		num7 = num6;
		obj8 = obj7;
		obj10 = obj9;
		goto IL_07fb;
		IL_08b3:
		throw new NullReferenceException();
		IL_07fb:
		obj31 = 0;
		goto IL_08b3;
		IL_07a2:
		NullReferenceException ex4 = new NullReferenceException();
		obj8 = obj7;
		obj10 = obj9;
		num2 = 0;
		goto IL_07fb;
		IL_07cb:
		InvalidCastException ex5 = new InvalidCastException();
		num5 = num4;
		num7 = num6;
		obj8 = obj7;
		obj10 = obj9;
		goto IL_07fb;
		IL_0772:
		NullReferenceException ex6 = new NullReferenceException();
		num5 = num4;
		num7 = num6;
		obj8 = obj7;
		obj10 = obj9;
		goto IL_07fb;
	}

	public void Initialize()
	{
		popupUi.SlideFromBottom(null);
	}

	public void OnSwipe(SwipeGesture swipeGesture)
	{
		int num;
		if (swipeGesture.CardinalDirection != GestureDirection.Left)
		{
			if (swipeGesture.CardinalDirection != GestureDirection.Right)
			{
				return;
			}
			num = _currentPage + 1;
			if (num >= _numPages)
			{
				return;
			}
		}
		else
		{
			num = _currentPage - 1;
			if (num < 1)
			{
				return;
			}
		}
		_currentPage = num;
		UpdateNavigation();
	}

	private void NextPage()
	{
		int num = _currentPage + 1;
		if (num < _numPages)
		{
			_currentPage = num;
			UpdateNavigation();
		}
	}

	private void PreviousPage()
	{
		int num = _currentPage - 1;
		if (num >= 1)
		{
			_currentPage = num;
			UpdateNavigation();
		}
	}

	private void UpdateNavigation()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		//IL_00b5: Invalid comparison between F4 and I4
		//IL_00c4: Invalid comparison between F4 and I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e5: Expected O, but got F4
		//IL_011a: Expected O, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0147: Expected F4, but got I4
		//IL_01ac: Expected O, but got I4
		//IL_01eb: Invalid comparison between F4 and I4
		//IL_01fa: Invalid comparison between F4 and I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_021b: Expected O, but got F4
		//IL_0250: Expected O, but got I4
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_027d: Expected F4, but got I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02ee: Expected O, but got I4
		//IL_0332: Invalid comparison between F8 and I4
		//IL_0341: Invalid comparison between F8 and I4
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_036c: Expected O, but got F8
		//IL_03a1: Expected O, but got I4
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03ce: Expected F8, but got I4
		//IL_04eb: Expected O, but got I4
		//IL_051f: Expected O, but got I4
		int currentProgress = _currentPage + 1;
		pagination.CurrentProgress = currentProgress;
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = pagesParent.rect;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float canvasWidth = ScreenUtility.CanvasWidth;
		float num2 = default(float);
		float num = num2 - 1.1762565E+09f;
		bool flag2 = num < 0f;
		bool flag3 = num == 0f;
		object obj4 = num2 ^ 0x461C4000;
		object obj5 = num2 ^ num;
		object obj6 = obj4 & obj5;
		bool flag4 = (nint)obj6 < 0;
		bool flag5 = flag2 == flag4;
		object obj7 = !flag3;
		object obj8 = flag5 & obj7;
		object obj9 = ~obj8;
		float num3 = ((obj9 != null) ? num2 : 1.1762565E+09f);
		float num4 = ((!(num2 < canvasWidth)) ? num3 : canvasWidth);
		Rect rect2 = pagesParent.rect;
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v14+E4]");
		bool flag6 = (nint)0 == 0;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num5 = ScreenUtility.CanvasWidth;
		float num6 = num2 - 1.1762565E+09f;
		bool flag7 = num6 < 0f;
		bool flag8 = num6 == 0f;
		object obj12 = num2 ^ 0x461C4000;
		object obj13 = num2 ^ num6;
		object obj14 = obj12 & obj13;
		bool flag9 = (nint)obj14 < 0;
		bool flag10 = flag7 == flag9;
		object obj15 = !flag8;
		object obj16 = flag10 & obj15;
		object obj17 = ~obj16;
		float num7 = ((obj17 != null) ? num2 : 1.1762565E+09f);
		if (!(num2 < num5))
		{
			num5 = num7;
		}
		float num8 = num4 * (float)_currentPage;
		float num9 = num5 * 0.5f;
		float endValue = num8 + num9;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosX(pagesParent, endValue, 0.3f);
		object obj18 = typeof(DataRelation) + 856;
		Rect rect3 = pagesParent.rect;
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v22+E4]");
		bool flag11 = (nint)0 == 0;
		object obj20 = !flag11;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float canvasWidth2 = ScreenUtility.CanvasWidth;
		double num10 = 0.5 - 1176256512.0;
		bool flag12 = num10 < 0.0;
		bool flag13 = num10 == 0.0;
		object obj21 = 0.5 ^ 0x461C4000;
		object obj22 = 0.5 ^ num10;
		object obj23 = obj21 & obj22;
		bool flag14 = (nint)obj23 < 0;
		bool flag15 = flag12 == flag14;
		object obj24 = !flag13;
		object obj25 = flag15 & obj24;
		object obj26 = ~obj25;
		double num11 = ((obj26 != null) ? 0.5 : 1176256512.0);
		double num12 = ((!(0.5 < (double)canvasWidth2)) ? num11 : ((double)canvasWidth2));
		double num13 = num12 * (double)_currentPage;
		object obj27 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj28 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v24+E4]");
		bool flag16 = (nint)0 == 0;
		object obj29 = !flag16;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = default(object);
		Debug.Log(message);
	}

	public void Show()
	{
		popupUi.SlideFromBottom(null);
	}

	public void Close()
	{
		//IL_0017: Expected I, but got O
		//IL_0056: Expected O, but got I
		//IL_0056: Expected O, but got I4
		PopupUI popupUI = popupUi;
		nint num = (nint)popupUI;
		popupUI.HidePopup(hideContentNow: false);
		float canvasHeight = ScreenUtility.CanvasHeight;
		RectTransform content = popupUI.content;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v1 (Il2CppClass<PopupUI>)+1B0]");
		Action onFinish = default(Action);
		TransitionExtension.DoTweenSlide(content, (Vector2)0, (Vector2)0, 0f, onFinish);
	}
}
