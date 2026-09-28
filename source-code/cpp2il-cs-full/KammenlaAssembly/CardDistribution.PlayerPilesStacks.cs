using System;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

namespace CardDistribution;

public class PlayerPilesStacks : MonoBehaviour
{
	private CanvasGroup <CanvasGroup>k__BackingField;

	private CardsStack[] <Piles>k__BackingField;

	private CardsStack <LastPile>k__BackingField;

	private Image <Shadow>k__BackingField;

	private int _currentBatchIndex;

	private int _batchCount;

	public CanvasGroup CanvasGroup
	{
		get
		{
			return <CanvasGroup>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public CardsStack[] Piles
	{
		get
		{
			return <Piles>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public CardsStack LastPile
	{
		get
		{
			return <LastPile>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Image Shadow
	{
		get
		{
			return <Shadow>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private CardsStack ActivePile
	{
		get
		{
			//IL_0010: Expected O, but got I4
			//IL_022c: Expected O, but got I4
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected I4, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected I4, but got Unknown
			//IL_00ce: Expected O, but got I4
			//IL_00c0: Expected O, but got I4
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Expected O, but got Unknown
			//IL_010c: Expected O, but got I4
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected O, but got Unknown
			//IL_0186: Expected O, but got I4
			//IL_02a2: Expected O, but got I4
			//IL_02d4: Expected O, but got I4
			//IL_01b3: Expected O, but got I4
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			object obj = _batchCount - 1;
			bool flag;
			bool flag2;
			if (_batchCount >= 1)
			{
				object obj2 = _currentBatchIndex - obj;
				flag = (nint)obj2 < 0;
				int num = _currentBatchIndex ^ obj;
				int num2 = _currentBatchIndex ^ obj2;
				int num3 = num & num2;
				flag2 = num3 < 0;
			}
			else
			{
				flag2 = false;
				flag = true;
			}
			bool flag3 = flag == flag2;
			object obj3 = !flag3;
			object obj4;
			if (obj3 == null)
			{
				bool flag4 = _currentBatchIndex < _batchCount;
				obj4 = !flag4;
			}
			else
			{
				obj4 = 1;
			}
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				CardsStack[] array = <Piles>k__BackingField;
				if (<Piles>k__BackingField != null)
				{
					object obj6 = array.Length - 1;
					object obj7 = obj6 - _currentBatchIndex;
					object obj8 = obj7 - obj6;
					bool flag5 = (nint)obj8 < 0;
					object obj9 = obj7 ^ obj6;
					object obj10 = obj7 ^ obj8;
					object obj11 = obj9 & obj10;
					bool flag6 = (nint)obj11 < 0;
					bool flag7 = flag5 == flag6;
					object obj12 = !flag7;
					object obj13 = ~obj12;
					if (obj13 == null)
					{
						obj6 = obj7;
					}
					bool flag8 = (nint)obj7 < 0;
					object obj14 = obj7 ^ obj7;
					object obj15 = obj7 & obj14;
					bool flag9 = (nint)obj15 < 0;
					bool flag10 = flag8 == flag9;
					object obj16 = !flag10;
					object obj17 = ~obj16;
					object obj18 = ((obj17 != null) ? obj6 : ((object)0));
					bool flag11 = (nint)obj18 < array.Length;
					object obj19 = !flag11;
					if (obj19 == null)
					{
						object obj20 = (object)<Piles>k__BackingField + obj18;
						return (CardsStack)(obj20 + 32);
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				return (CardsStack)(object)new IndexOutOfRangeException();
			}
			return (CardsStack)(this + 48);
		}
	}

	public Image CoverCard
	{
		get
		{
			//IL_0010: Expected O, but got I4
			//IL_0310: Expected O, but got I4
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected I4, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected I4, but got Unknown
			//IL_00ce: Expected O, but got I4
			//IL_00c0: Expected O, but got I4
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Expected O, but got Unknown
			//IL_0257: Expected O, but got I
			//IL_010c: Expected O, but got I4
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected O, but got Unknown
			//IL_0186: Expected O, but got I4
			//IL_0386: Expected O, but got I4
			//IL_02b7: Expected O, but got I
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Expected O, but got Unknown
			//IL_02d9: Expected O, but got I
			//IL_03b8: Expected O, but got I4
			//IL_01b3: Expected O, but got I4
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_0204: Expected O, but got I4
			object obj = _batchCount - 1;
			bool flag;
			bool flag2;
			if (_batchCount >= 1)
			{
				object obj2 = _currentBatchIndex - obj;
				flag = (nint)obj2 < 0;
				int num = _currentBatchIndex ^ obj;
				int num2 = _currentBatchIndex ^ obj2;
				int num3 = num & num2;
				flag2 = num3 < 0;
			}
			else
			{
				flag2 = false;
				flag = true;
			}
			bool flag3 = flag == flag2;
			object obj3 = !flag3;
			object obj4;
			if (obj3 == null)
			{
				bool flag4 = _currentBatchIndex < _batchCount;
				obj4 = !flag4;
			}
			else
			{
				obj4 = 1;
			}
			object obj5 = ~obj4;
			object obj22;
			if (obj5 == null)
			{
				CardsStack[] array = <Piles>k__BackingField;
				if (<Piles>k__BackingField != null)
				{
					object obj6 = array.Length - 1;
					object obj7 = obj6 - _currentBatchIndex;
					object obj8 = obj7 - obj6;
					bool flag5 = (nint)obj8 < 0;
					object obj9 = obj7 ^ obj6;
					object obj10 = obj7 ^ obj8;
					object obj11 = obj9 & obj10;
					bool flag6 = (nint)obj11 < 0;
					bool flag7 = flag5 == flag6;
					object obj12 = !flag7;
					object obj13 = ~obj12;
					if (obj13 == null)
					{
						obj6 = obj7;
					}
					bool flag8 = (nint)obj7 < 0;
					object obj14 = obj7 ^ obj7;
					object obj15 = obj7 & obj14;
					bool flag9 = (nint)obj15 < 0;
					bool flag10 = flag8 == flag9;
					object obj16 = !flag10;
					object obj17 = ~obj16;
					object obj18 = ((obj17 != null) ? obj6 : ((object)0));
					bool flag11 = (nint)obj18 < array.Length;
					object obj19 = !flag11;
					if (obj19 == null)
					{
						object obj20 = (object)<Piles>k__BackingField + obj18;
						object obj21 = obj20 + 32;
						obj22 = obj21;
						bool flag12 = obj21 == null;
						object obj23 = !flag12;
						if (obj23 != null)
						{
							goto IL_0247;
						}
						goto IL_02d9;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				return (Image)(object)new IndexOutOfRangeException();
			}
			object obj24 = this + 48;
			obj22 = obj24;
			if (obj24 != null)
			{
				goto IL_0247;
			}
			goto IL_02d9;
			IL_02d9:
			return null;
			IL_0247:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v3+18]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v3+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v4+18]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v4+18]");
					object obj26 = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v3+18]");
					object obj27 = 0 + obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v5+20]");
					return (Image)0;
				}
			}
			goto IL_02d9;
		}
	}

	public void ApplyState(int batchIndex, int batchCount)
	{
		//IL_0022: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0120: Expected O, but got I
		//IL_01d3: Expected O, but got I4
		//IL_0190: Expected O, but got I4
		//IL_0235: Expected O, but got I4
		//IL_023e: Expected F8, but got I4
		//IL_0087: Expected O, but got I
		//IL_0281: Expected O, but got I4
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected O, but got Unknown
		//IL_0676: Expected O, but got I4
		//IL_00f7: Expected O, but got I4
		//IL_0300: Expected F8, but got I4
		//IL_04ef: Expected O, but got I4
		//IL_059b: Expected O, but got I4
		//IL_0511: Expected O, but got I
		//IL_0398: Expected O, but got I4
		//IL_052c: Expected O, but got I
		//IL_054b: Expected O, but got I
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected O, but got Unknown
		//IL_057f: Expected O, but got I4
		//IL_05bd: Expected O, but got I
		//IL_05d8: Expected O, but got I
		//IL_03ac: Expected O, but got I4
		//IL_03c9: Expected O, but got I
		//IL_0434: Expected O, but got I4
		//IL_05f7: Expected O, but got I
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_062b: Expected O, but got I4
		//IL_0466: Expected F8, but got I4
		//IL_0481: Expected O, but got I
		//IL_049f: Expected O, but got I
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_04d3: Expected O, but got I4
		_currentBatchIndex = batchIndex;
		_batchCount = batchCount;
		object obj = batchCount - 1;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		if (batchIndex < batchCount && batchIndex != (nint)obj)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F07]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v37+E4]");
				if ((nint)0 != 0)
				{
					goto IL_00d1;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v37+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_00d1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (<Shadow>k__BackingField != null)
			{
				goto IL_02c7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F07]");
			object obj6 = (nint)0 & (nint)1;
			if (obj6 != null)
			{
				object obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v24+E4]");
				if ((nint)0 != 0)
				{
					goto IL_016a;
				}
			}
			else
			{
				_ = 1;
				object obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v24+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 != null)
				{
					goto IL_016a;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (<Shadow>k__BackingField != null)
			{
				goto IL_0219;
			}
		}
		goto IL_0645;
		IL_02c7:
		double num = 1.0;
		goto IL_02d9;
		IL_00d1:
		bool flag3 = <Shadow>k__BackingField != null;
		bool flag4 = !flag3;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_02c7;
		}
		goto IL_0645;
		IL_0639:
		throw new NullReferenceException();
		IL_0645:
		CardsStack cardsStack = <LastPile>k__BackingField;
		object obj10 = batchIndex - obj;
		bool flag5 = obj10 == null;
		object obj11 = !flag5;
		object obj12 = ~obj11;
		double num2 = ((obj12 != null) ? 1.0 : 0.0);
		int num3 = ShortcutExtensions.DOKill(cardsStack.<CanvasGroup>k__BackingField);
		cardsStack.<CanvasGroup>k__BackingField.alpha = (float)num2;
		CardsStack[] array = <Piles>k__BackingField;
		if (batchIndex != (nint)obj)
		{
			if (batchIndex < batchCount)
			{
				object obj13 = 0;
				object obj23;
				do
				{
					if ((nint)obj13 < array.Length)
					{
						object obj14 = array.Length - batchIndex;
						object obj15 = (object)array + obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v11+20]");
						object obj16 = 0;
						object obj17 = obj13 - obj14;
						bool flag6 = (nint)obj17 < 0;
						object obj18 = obj13 ^ obj14;
						object obj19 = obj13 ^ obj17;
						object obj20 = obj18 & obj19;
						bool flag7 = (nint)obj20 < 0;
						bool flag8 = flag6 == flag7;
						object obj21 = !flag8;
						object obj22 = ~obj21;
						double num4 = ((obj22 != null) ? 0.0 : 1.0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X22_v4+10]");
						int num5 = ShortcutExtensions.DOKill((Component)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X22_v4+10]");
						((CanvasGroup)0).alpha = (float)num4;
						array = <Piles>k__BackingField;
						obj13++;
						bool flag9 = <Piles>k__BackingField == null;
						obj23 = !flag9;
						continue;
					}
					return;
				}
				while (obj23 != null);
			}
			else
			{
				object obj24 = 0;
				object obj27;
				do
				{
					if ((nint)obj24 < array.Length)
					{
						object obj25 = (object)array + obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v8+20]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X21_v5+10]");
						int num6 = ShortcutExtensions.DOKill((Component)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X21_v5+10]");
						((CanvasGroup)0).alpha = 0f;
						array = <Piles>k__BackingField;
						obj24++;
						bool flag10 = <Piles>k__BackingField == null;
						obj27 = !flag10;
						continue;
					}
					return;
				}
				while (obj27 != null);
			}
		}
		else
		{
			object obj28 = 0;
			object obj31;
			do
			{
				if ((nint)obj28 < array.Length)
				{
					object obj29 = (object)array + obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v5+20]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X21_v3+10]");
					int num7 = ShortcutExtensions.DOKill((Component)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X21_v3+10]");
					((CanvasGroup)0).alpha = 0f;
					array = <Piles>k__BackingField;
					obj28++;
					bool flag11 = <Piles>k__BackingField == null;
					obj31 = !flag11;
					continue;
				}
				return;
			}
			while (obj31 != null);
		}
		goto IL_0639;
		IL_02d9:
		<Shadow>k__BackingField.CrossFadeAlpha((float)num, 0f, ignoreTimeScale: true);
		goto IL_0645;
		IL_016a:
		bool flag12 = <Shadow>k__BackingField != null;
		bool flag13 = !flag12;
		object obj32 = !flag13;
		if (obj32 != null)
		{
			goto IL_0219;
		}
		goto IL_0645;
		IL_0219:
		bool flag14 = (object)<Shadow>k__BackingField == null;
		object obj33 = !flag14;
		num = 0.0;
		if (obj33 != null)
		{
			goto IL_02d9;
		}
		goto IL_0639;
	}

	public void FadeOutBatch(int nextBatchIndex, int batchCount, float duration)
	{
		//IL_01d8: Expected F4, but got I4
		//IL_0041: Expected O, but got I4
		//IL_01ec: Expected O, but got I4
		//IL_0113: Expected O, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_013d: Expected O, but got I
		//IL_02ae: Expected O, but got I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		//IL_0248: Expected O, but got I
		//IL_026a: Expected O, but got I4
		//IL_01ad: Expected O, but got I4
		//IL_0372: Expected O, but got I
		//IL_02fc: Expected I, but got O
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I
		//IL_00f2: Expected F4, but got I4
		int num = default(int);
		_currentBatchIndex = num;
		_batchCount = batchCount;
		UnityEngine.Object obj5;
		CardsStack cardsStack;
		if (num < batchCount)
		{
			object obj = batchCount - 1;
			CardsStack[] array = <Piles>k__BackingField;
			if (num == (nint)obj)
			{
				bool flag = array.Length < 1;
				float num2 = duration;
				if (!flag)
				{
					object obj2 = array + 32;
					object obj3 = 0;
					bool flag2;
					do
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X22_v7+v108 @ X21_v9*8]");
						object obj4 = 0;
						obj3++;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v22+10]");
						TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade((CanvasGroup)0, 0f, duration);
						flag2 = (nint)obj3 < array.Length;
						num2 = 0f;
					}
					while (flag2);
				}
				obj5 = <Shadow>k__BackingField;
				object obj6 = 152989696;
				object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F08]");
				object obj8 = (nint)0 & (nint)1;
				if (obj8 != null)
				{
					object obj9 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v14+E4]");
					if ((nint)0 != 0)
					{
						goto IL_0187;
					}
				}
				else
				{
					_ = 1;
					object obj9 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v14+E4]");
					bool flag3 = (nint)0 == 0;
					object obj10 = !flag3;
					if (obj10 != null)
					{
						goto IL_0187;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if (<Shadow>k__BackingField != null)
				{
					goto IL_02f4;
				}
				goto IL_0377;
			}
			object obj11 = array.Length - num;
			if (array.Length < num || (nint)obj11 >= array.Length)
			{
				return;
			}
			object obj12 = (object)array + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v7+20]");
			cardsStack = (CardsStack)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v7+20]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			cardsStack = <LastPile>k__BackingField;
		}
		float endValue = 0f;
		goto IL_0386;
		IL_0386:
		TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTweenModuleUI.DOFade(cardsStack.<CanvasGroup>k__BackingField, endValue, duration);
		return;
		IL_0377:
		CardsStack cardsStack2 = <LastPile>k__BackingField;
		int num3 = ShortcutExtensions.DOKill(cardsStack2.<CanvasGroup>k__BackingField);
		cardsStack2.<CanvasGroup>k__BackingField.alpha = 0f;
		cardsStack = <LastPile>k__BackingField;
		endValue = 1f;
		goto IL_0386;
		IL_0187:
		bool flag5 = <Shadow>k__BackingField != null;
		bool flag6 = !flag5;
		object obj14 = !flag6;
		if (obj14 != null)
		{
			goto IL_02f4;
		}
		goto IL_0377;
		IL_02f4:
		nint num4 = (nint)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v331 @ X8_v15 (Il2CppClass<UnityEngine.Object>)+448] (should have been resolved before IL gen)");
		goto IL_0377;
	}

	public void SetDealerCardBack(Sprite sprite)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_006f: Expected O, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		CardsStack[] array = <Piles>k__BackingField;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X23_v3+v92 @ X22_v4*8]");
				SetTopCard((CardsStack)0, sprite);
				obj2++;
			}
			while ((nint)obj2 < array.Length);
		}
		SetTopCard(<LastPile>k__BackingField, sprite);
	}

	private static void SetTopCard(CardsStack pile, Sprite sprite)
	{
		//IL_0067: Expected O, but got I8
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0170: Expected O, but got I
		//IL_018f: Expected O, but got I4
		//IL_00db: Expected O, but got I
		//IL_012b: Expected O, but got I8
		//IL_0153: Expected O, but got I
		if (pile == null)
		{
			return;
		}
		Image[] <Cards>k__BackingField = pile.<Cards>k__BackingField;
		if (pile.<Cards>k__BackingField == null || <Cards>k__BackingField.Length < 1)
		{
			return;
		}
		object obj = -4294967296L + <Cards>k__BackingField.Length;
		object obj2 = pile.<Cards>k__BackingField + 32;
		object obj3 = obj >> 29;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X22_v3+v144 @ X8_v6]");
			if (!((UnityEngine.Object)0 != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X22_v3+v144 @ X8_v6]");
			bool flag = (UnityEngine.Object)0 != null;
			bool flag2 = !flag;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				return;
			}
		}
		if (<Cards>k__BackingField.Length != 0)
		{
			object obj7 = -4294967296L + <Cards>k__BackingField.Length;
			object obj8 = obj7 >> 29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X22_v3+v133 @ X8_v13]");
			((Image)0).sprite = sprite;
			return;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public void SnapPerspective(float alpha)
	{
		int num = ShortcutExtensions.DOKill(<CanvasGroup>k__BackingField);
		<CanvasGroup>k__BackingField.alpha = alpha;
	}

	public void FadePerspective(float targetAlpha, float duration)
	{
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(<CanvasGroup>k__BackingField, targetAlpha, duration);
	}

	private bool IsOnLastPile(int batchIndex)
	{
		//IL_0010: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0153: Expected O, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected I4, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected I4, but got Unknown
		//IL_0135: Expected O, but got I4
		//IL_016a: Expected I4, but got O
		//IL_0127: Expected O, but got I4
		object obj = _batchCount - 1;
		bool flag = _batchCount < 0;
		bool flag2 = _batchCount == 0;
		int num = _batchCount ^ _batchCount;
		int num2 = _batchCount & num;
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		bool flag5;
		bool flag6;
		if (obj4 == null)
		{
			object obj5 = batchIndex - obj;
			flag5 = (nint)obj5 < 0;
			int num3 = batchIndex ^ obj;
			int num4 = batchIndex ^ obj5;
			int num5 = num3 & num4;
			flag6 = num5 < 0;
		}
		else
		{
			flag6 = false;
			flag5 = true;
		}
		bool flag7 = flag5 == flag6;
		object obj6 = !flag7;
		object obj7;
		if (obj6 == null)
		{
			bool flag8 = batchIndex < _batchCount;
			obj7 = !flag8;
		}
		else
		{
			obj7 = 1;
		}
		return (byte)(int)(~obj7) != 0;
	}

	private unsafe static void GetBatchState(int batchIndex, int batchCount, out bool onLastPile, out bool allDealt)
	{
		//IL_000d: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		//IL_0076: Expected O, but got I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		object obj = batchIndex - batchCount;
		bool flag = (nint)obj < 0;
		int num = batchIndex ^ batchCount;
		int num2 = batchIndex ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		ref bool reference = ref *(flag3 ? ((bool*)1) : ((bool*)null));
		object obj2 = batchCount - 1;
		object obj3 = batchIndex - obj2;
		bool flag4 = obj3 == null;
		ref bool reference2 = ref *(flag4 ? ((bool*)1) : ((bool*)null));
	}

	private static void SnapImage(Image image, float alpha)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_00ac: Expected I, but got O
		//IL_00bc: Expected O, but got I
		//IL_00cc: Expected O, but got I
		//IL_0147: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F07]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00d6;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			goto IL_007d;
		}
		goto IL_0114;
		IL_0114:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag = image != null;
		bool flag2 = !flag;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			return;
		}
		goto IL_00a4;
		IL_007d:
		if (image != null)
		{
			goto IL_00a4;
		}
		return;
		IL_00a4:
		nint num = (nint)image;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7 (Il2CppClass<UnityEngine.UI.Image>)+448]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7 (Il2CppClass<UnityEngine.UI.Image>)+450]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v91 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00d6;
		IL_00d6:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_007d;
		}
		goto IL_0114;
	}

	private static void FadeImage(Image image, float alpha, float duration)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_00ac: Expected I, but got O
		//IL_00bc: Expected O, but got I
		//IL_00cc: Expected O, but got I
		//IL_0147: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F08]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00d6;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			goto IL_007d;
		}
		goto IL_0114;
		IL_0114:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag = image != null;
		bool flag2 = !flag;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			return;
		}
		goto IL_00a4;
		IL_007d:
		if (image != null)
		{
			goto IL_00a4;
		}
		return;
		IL_00a4:
		nint num = (nint)image;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7 (Il2CppClass<UnityEngine.UI.Image>)+448]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7 (Il2CppClass<UnityEngine.UI.Image>)+450]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v92 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00d6;
		IL_00d6:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_007d;
		}
		goto IL_0114;
	}
}
