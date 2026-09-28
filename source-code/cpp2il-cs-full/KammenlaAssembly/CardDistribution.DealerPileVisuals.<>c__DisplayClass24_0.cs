using System;
using System.Buffers.Text;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

namespace CardDistribution;

public class DealerPileVisuals : MonoBehaviour
{
	private sealed class <>c__DisplayClass24_0
	{
		public PlayerPilesStacks tilted;

		public int nextBatchIndex;

		public int batchCount;

		public float fadeDuration;

		public PlayerPilesStacks topDown;

		internal void <BuildPlayerBatchSequence>b__0()
		{
			tilted.FadeOutBatch(nextBatchIndex, batchCount, fadeDuration);
		}

		internal void <BuildPlayerBatchSequence>b__1()
		{
			topDown.FadeOutBatch(nextBatchIndex, batchCount, fadeDuration);
		}
	}

	private DealerPileSO dealerPileSo;

	private CanvasGroup _canvasGroup;

	private PlayersPiles _tiltedPlayers;

	private PlayersPiles _topDownPlayers;

	private RectTransform _transform;

	private bool _isTopDown;

	private int _currentDealer;

	public int[] CardsPerBatch
	{
		get
		{
			DealerPileSO dealerPileSO = dealerPileSo;
			if ((object)dealerPileSo != null)
			{
				return dealerPileSO.<CardsPerBatch>k__BackingField;
			}
			return (int[])(object)new NullReferenceException();
		}
	}

	private RectTransform CoverCardRect
	{
		get
		{
			//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b9: Expected O, but got Unknown
			//IL_0018: Expected O, but got I4
			//IL_0394: Expected O, but got I4
			//IL_0777: Expected O, but got I4
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected I4, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected I4, but got Unknown
			//IL_00e8: Expected O, but got I4
			//IL_0452: Expected O, but got I4
			//IL_00da: Expected O, but got I4
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Expected O, but got Unknown
			//IL_0518: Expected O, but got I4
			//IL_0525: Unknown result type (might be due to invalid IL or missing references)
			//IL_052a: Expected O, but got Unknown
			//IL_0595: Expected O, but got I4
			//IL_0280: Expected O, but got I
			//IL_08a3: Expected O, but got I4
			//IL_04b8: Expected O, but got I4
			//IL_012c: Expected O, but got I4
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Expected O, but got Unknown
			//IL_01a9: Expected O, but got I4
			//IL_07ed: Expected O, but got I4
			//IL_08d5: Expected O, but got I4
			//IL_05c2: Expected O, but got I4
			//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d4: Expected O, but got Unknown
			//IL_02e0: Expected O, but got I
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Expected O, but got Unknown
			//IL_0305: Expected O, but got I
			//IL_0314: Unknown result type (might be due to invalid IL or missing references)
			//IL_0319: Expected O, but got Unknown
			//IL_0343: Expected O, but got I4
			//IL_0353: Expected O, but got I
			//IL_081f: Expected O, but got I4
			//IL_01d6: Expected O, but got I4
			//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f4: Expected O, but got Unknown
			//IL_0609: Expected O, but got I
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Expected O, but got Unknown
			//IL_022a: Expected O, but got I4
			//IL_0669: Expected O, but got I
			//IL_0679: Unknown result type (might be due to invalid IL or missing references)
			//IL_067e: Expected O, but got Unknown
			//IL_06b4: Expected O, but got I
			//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e9: Expected O, but got Unknown
			PlayerPilesStacks activeStack = ActiveStack;
			if ((object)activeStack != null)
			{
				object obj = activeStack._batchCount - 1;
				bool flag;
				bool flag2;
				if (activeStack._batchCount >= 1)
				{
					object obj2 = activeStack._currentBatchIndex - obj;
					flag = (nint)obj2 < 0;
					int num = activeStack._currentBatchIndex ^ obj;
					int num2 = activeStack._currentBatchIndex ^ obj2;
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
					bool flag4 = activeStack._currentBatchIndex < activeStack._batchCount;
					obj4 = !flag4;
				}
				else
				{
					obj4 = 1;
				}
				object obj5 = ~obj4;
				if (obj5 == null)
				{
					CardsStack[] <Piles>k__BackingField = activeStack.<Piles>k__BackingField;
					if (activeStack.<Piles>k__BackingField == null)
					{
						goto IL_070d;
					}
					object obj6 = <Piles>k__BackingField.Length - 1;
					object obj7 = obj6 - activeStack._currentBatchIndex;
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
					bool flag11 = (nint)obj18 < <Piles>k__BackingField.Length;
					object obj19 = !flag11;
					if (obj19 != null)
					{
						goto IL_071b;
					}
					object obj20 = (object)activeStack.<Piles>k__BackingField + obj18;
					object obj21 = obj20 + 32;
					object obj22 = obj21;
					bool flag12 = obj21 == null;
					object obj23 = !flag12;
					if (obj23 != null)
					{
						goto IL_0270;
					}
				}
				else
				{
					object obj24 = activeStack + 48;
					object obj22 = obj24;
					if (obj24 != null)
					{
						goto IL_0270;
					}
				}
			}
			goto IL_03a5;
			IL_03f0:
			UnityEngine.Object obj25;
			if (!(obj25 != null))
			{
				goto IL_03a3;
			}
			goto IL_0418;
			IL_0418:
			PlayerPilesStacks activeStack2 = ActiveStack;
			object obj28;
			if ((object)activeStack2 != null)
			{
				object obj26 = activeStack2._batchCount - 1;
				if (activeStack2._batchCount >= 1 && activeStack2._currentBatchIndex >= (nint)obj26)
				{
					bool flag13 = activeStack2._currentBatchIndex < activeStack2._batchCount;
					object obj27 = !flag13;
					if (obj27 == null)
					{
						obj28 = activeStack2 + 48;
						goto IL_082d;
					}
				}
				CardsStack[] <Piles>k__BackingField2 = activeStack2.<Piles>k__BackingField;
				if (activeStack2.<Piles>k__BackingField != null)
				{
					object obj29 = <Piles>k__BackingField2.Length - 1;
					object obj30 = obj29 - activeStack2._currentBatchIndex;
					object obj31 = obj30 - obj29;
					bool flag14 = (nint)obj31 < 0;
					object obj32 = obj30 ^ obj29;
					object obj33 = obj30 ^ obj31;
					object obj34 = obj32 & obj33;
					bool flag15 = (nint)obj34 < 0;
					bool flag16 = flag14 == flag15;
					object obj35 = !flag16;
					object obj36 = ~obj35;
					if (obj36 == null)
					{
						obj29 = obj30;
					}
					bool flag17 = (nint)obj30 < 0;
					object obj37 = obj30 ^ obj30;
					object obj38 = obj30 & obj37;
					bool flag18 = (nint)obj38 < 0;
					bool flag19 = flag17 == flag18;
					object obj39 = !flag19;
					object obj40 = ~obj39;
					object obj41 = ((obj40 != null) ? obj29 : ((object)0));
					bool flag20 = (nint)obj41 < <Piles>k__BackingField2.Length;
					object obj42 = !flag20;
					if (obj42 != null)
					{
						goto IL_071b;
					}
					object obj43 = (object)activeStack2.<Piles>k__BackingField + obj41;
					obj28 = obj43 + 32;
					goto IL_082d;
				}
			}
			goto IL_070d;
			IL_082d:
			object obj44 = obj28;
			if (obj28 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v9+18]");
				object obj45 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v9+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v10+18]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v10+18]");
						object obj46 = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v9+18]");
						object obj47 = 0 + obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v11+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v11+20]");
							RectTransform rectTransform = (RectTransform)((Component)0).transform;
							if ((object)rectTransform != null)
							{
								object obj48 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
								if (rectTransform != obj48)
								{
									goto IL_0729;
								}
							}
							return rectTransform;
						}
					}
				}
			}
			goto IL_070d;
			IL_0361:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object obj49;
			bool flag21 = obj49 != null;
			bool flag22 = !flag21;
			object obj50 = !flag22;
			if (obj50 == null)
			{
				goto IL_03a3;
			}
			goto IL_0418;
			IL_0270:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v31+18]");
			object obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v31+18]");
			object obj55;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v32+18]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v32+18]");
					object obj52 = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v31+18]");
					object obj53 = 0 + obj52;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v33+20]");
					obj49 = (UnityEngine.Object)0;
					object obj54 = typeof(MemberAchievementClanFeedData) + 2976;
					obj55 = obj54;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v21+E4]");
					bool flag23 = (nint)0 == 0;
					object obj56 = !flag23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v33+20]");
					obj25 = (UnityEngine.Object)0;
					if (obj56 == null)
					{
						goto IL_0361;
					}
					goto IL_03f0;
				}
			}
			goto IL_03a5;
			IL_0729:
			return (RectTransform)(object)new InvalidCastException();
			IL_03a3:
			return null;
			IL_070d:
			NullReferenceException ex = new NullReferenceException();
			goto IL_071b;
			IL_071b:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			goto IL_0729;
			IL_03a5:
			object obj57 = typeof(MemberAchievementClanFeedData) + 2976;
			obj55 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v21+E4]");
			bool flag24 = (nint)0 == 0;
			obj49 = null;
			obj25 = null;
			if (flag24)
			{
				goto IL_0361;
			}
			goto IL_03f0;
		}
	}

	public Vector3 TopCardWorldPosition
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0132: Expected O, but got I4
			//IL_01b2: Expected O, but got I4
			//IL_017f: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EF5]");
			object obj2 = (nint)0 & (nint)1;
			RectTransform coverCardRect;
			UnityEngine.Object obj4;
			if (obj2 != null)
			{
				coverCardRect = CoverCardRect;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+E4]");
				bool flag = (nint)0 == 0;
				obj4 = coverCardRect;
				if (!flag)
				{
					goto IL_0086;
				}
			}
			else
			{
				_ = 1;
				coverCardRect = CoverCardRect;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				obj4 = coverCardRect;
				if (obj5 != null)
				{
					goto IL_0086;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = coverCardRect != null;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			if (obj6 != null)
			{
				goto IL_00b2;
			}
			goto IL_018e;
			IL_00e1:
			Transform transform;
			return transform.position;
			IL_01c0:
			return (Vector3)new NullReferenceException();
			IL_00b2:
			RectTransform coverCardRect2 = CoverCardRect;
			bool flag5 = (object)coverCardRect2 == null;
			transform = coverCardRect2;
			if (!flag5)
			{
				goto IL_00e1;
			}
			goto IL_01c0;
			IL_0086:
			if (obj4 != null)
			{
				goto IL_00b2;
			}
			goto IL_018e;
			IL_018e:
			transform = base.transform;
			bool flag6 = (object)transform == null;
			object obj7 = !flag6;
			if (obj7 != null)
			{
				goto IL_00e1;
			}
			goto IL_01c0;
		}
	}

	public Transform TopCardTransform
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0100: Expected O, but got I4
			//IL_014d: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EF6]");
			object obj2 = (nint)0 & (nint)1;
			RectTransform coverCardRect;
			UnityEngine.Object obj4;
			if (obj2 != null)
			{
				coverCardRect = CoverCardRect;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v3+E4]");
				bool flag = (nint)0 == 0;
				obj4 = coverCardRect;
				if (!flag)
				{
					goto IL_0086;
				}
			}
			else
			{
				_ = 1;
				coverCardRect = CoverCardRect;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				obj4 = coverCardRect;
				if (obj5 != null)
				{
					goto IL_0086;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = coverCardRect != null;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			if (obj6 != null)
			{
				goto IL_00b2;
			}
			goto IL_015c;
			IL_00b2:
			return CoverCardRect;
			IL_015c:
			return base.transform;
			IL_0086:
			if (obj4 != null)
			{
				goto IL_00b2;
			}
			goto IL_015c;
		}
	}

	private PlayerPilesStacks ActiveStack
	{
		get
		{
			//IL_001c: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			//IL_02c0: Expected O, but got I
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d4: Expected O, but got Unknown
			//IL_02ea: Expected O, but got I
			//IL_003c: Expected O, but got I4
			//IL_00e4: Expected O, but got I4
			//IL_008e: Expected O, but got I
			//IL_010e: Expected O, but got I
			//IL_0131: Expected O, but got I4
			//IL_0174: Expected O, but got I
			//IL_01a9: Expected O, but got I4
			//IL_01dc: Expected O, but got I
			//IL_0247: Expected O, but got I4
			//IL_0328: Expected O, but got I4
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Expected O, but got Unknown
			//IL_0292: Expected O, but got I
			bool flag = !_isTopDown;
			object obj = !flag;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				object obj3 = 56;
			}
			else
			{
				object obj3 = 48;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CardDistribution.DealerPileVisuals)+v32 @ X8_v3]");
			UnityEngine.Object obj4 = (UnityEngine.Object)0;
			object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F65]");
			object obj6 = (nint)0 & (nint)1;
			if (obj6 != null)
			{
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v8+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CardDistribution.DealerPileVisuals)+v32 @ X8_v3]");
			bool flag3 = (UnityEngine.Object)0 == null;
			bool flag4 = !flag3;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				goto IL_013f;
			}
			goto IL_0292;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CardDistribution.DealerPileVisuals)+v32 @ X8_v3]");
			if (!((UnityEngine.Object)0 == null))
			{
				goto IL_013f;
			}
			goto IL_0292;
			IL_013f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CardDistribution.DealerPileVisuals)+v32 @ X8_v3]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X20_v1 (UnityEngine.Object)+20]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X20_v1 (UnityEngine.Object)+20]");
				if ((nint)0 != 0)
				{
					object obj11 = _currentDealer - 1;
					if ((nint)obj11 >= 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v8+18]");
						object obj12 = -1;
						object obj13 = obj11 - obj12;
						bool flag5 = (nint)obj13 < 0;
						object obj14 = obj11 ^ obj12;
						object obj15 = obj11 ^ obj13;
						object obj16 = obj14 & obj15;
						bool flag6 = (nint)obj16 < 0;
						bool flag7 = flag5 == flag6;
						object obj17 = !flag7;
						object obj18 = ~obj17;
						if (obj18 != null)
						{
							obj11 = obj12;
						}
						object obj19 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v8+18]");
						bool flag8 = (nint)obj19 < 0;
						object obj20 = !flag8;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X20_v1 (UnityEngine.Object)+20]");
							object obj21 = 0 + obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v9+20]");
							return (PlayerPilesStacks)0;
						}
						goto IL_02a2;
					}
				}
				goto IL_0292;
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_02a2;
			IL_02a2:
			return (PlayerPilesStacks)(object)new IndexOutOfRangeException();
			IL_0292:
			return null;
		}
	}

	private void Awake()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0089: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			if (transform == obj)
			{
				object obj2 = this + 64;
				obj2 = transform;
				if (transform == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return;
				}
			}
			throw new InvalidCastException();
		}
		object obj3 = this + 64;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SetDealerCardBack(Sprite sprite)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		//IL_00c2: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		//IL_014c: Expected O, but got I4
		//IL_015a: Expected O, but got I4
		//IL_03cb: Expected O, but got I
		//IL_0478: Expected O, but got I4
		//IL_01db: Expected O, but got I4
		//IL_0218: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_04bf: Expected O, but got I4
		//IL_04fd: Expected O, but got I
		//IL_0708: Expected O, but got I4
		//IL_0532: Expected O, but got I4
		//IL_02ce: Expected O, but got I
		//IL_0565: Expected O, but got I
		//IL_05d0: Expected O, but got I4
		//IL_0313: Expected O, but got I
		//IL_077e: Expected O, but got I4
		//IL_0396: Expected O, but got I
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected O, but got Unknown
		//IL_061e: Expected O, but got I
		//IL_0373: Expected O, but got I
		//IL_037c: Expected O, but got I4
		//IL_072b: Expected O, but got I
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected O, but got Unknown
		//IL_0653: Expected O, but got I
		//IL_06d6: Expected O, but got I
		//IL_06b3: Expected O, but got I
		//IL_06bc: Expected O, but got I4
		//IL_07a1: Expected O, but got I
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected O, but got Unknown
		PlayersPiles tiltedPlayers = _tiltedPlayers;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F65]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v29+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007e;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v29+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_007e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = _tiltedPlayers == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		object obj8 = 0;
		Sprite sprite2 = null;
		if (obj5 == null)
		{
			goto IL_016d;
		}
		goto IL_03ab;
		IL_0415:
		if (_topDownPlayers == null)
		{
			return;
		}
		goto IL_04ce;
		IL_06d8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_06e6;
		IL_04ce:
		if ((object)_topDownPlayers != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X21_v5 (UnityEngine.Object)+20]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X21_v5 (UnityEngine.Object)+20]");
			if ((nint)0 == 0)
			{
				return;
			}
			object obj10 = _currentDealer - 1;
			if ((nint)obj10 < 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v8+18]");
			object obj11 = -1;
			object obj12 = obj10 - obj11;
			bool flag4 = (nint)obj12 < 0;
			object obj13 = obj10 ^ obj11;
			object obj14 = obj10 ^ obj12;
			object obj15 = obj13 & obj14;
			bool flag5 = (nint)obj15 < 0;
			bool flag6 = flag4 == flag5;
			object obj16 = !flag6;
			object obj17 = ~obj16;
			if (obj17 != null)
			{
				obj10 = obj11;
			}
			object obj18 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v8+18]");
			bool flag7 = (nint)obj18 < 0;
			object obj19 = !flag7;
			if (obj19 != null)
			{
				goto IL_06e6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X21_v5 (UnityEngine.Object)+20]");
			object obj20 = 0 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v9+20]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v9+20]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X20_v6+28]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X20_v6+28]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X21_v7+18]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X20_v6+28]");
					object obj23 = (nint)0 + (nint)32;
					object obj24 = 0;
					object obj25;
					do
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X23_v5+v479 @ X22_v7*8]");
						PlayerPilesStacks.SetTopCard((CardsStack)0, sprite);
						obj24++;
						obj25 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X21_v7+18]");
					}
					while ((nint)obj25 < 0);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X20_v6+30]");
				PlayerPilesStacks.SetTopCard((CardsStack)0, sprite);
				return;
			}
		}
		goto IL_06d8;
		IL_007e:
		bool flag8 = _tiltedPlayers == null;
		bool flag9 = !flag8;
		obj6 = 0;
		obj7 = null;
		if (flag9)
		{
			goto IL_016d;
		}
		obj8 = 0;
		sprite2 = null;
		goto IL_03ab;
		IL_016d:
		if ((object)_tiltedPlayers != null)
		{
			PlayerPilesStacks[] <PlayersPilesList>k__BackingField = tiltedPlayers.<PlayersPilesList>k__BackingField;
			bool flag10 = tiltedPlayers.<PlayersPilesList>k__BackingField == null;
			obj8 = obj6;
			sprite2 = (Sprite)obj7;
			if (!flag10)
			{
				object obj26 = _currentDealer - 1;
				bool flag11 = (nint)obj26 < 1;
				obj8 = obj6;
				sprite2 = (Sprite)obj7;
				if (!flag11)
				{
					object obj27 = <PlayersPilesList>k__BackingField.Length - 1;
					object obj28 = obj26 - obj27;
					bool flag12 = (nint)obj28 < 0;
					object obj29 = obj26 ^ obj27;
					object obj30 = obj26 ^ obj28;
					object obj31 = obj29 & obj30;
					bool flag13 = (nint)obj31 < 0;
					bool flag14 = flag12 == flag13;
					object obj32 = !flag14;
					object obj33 = ~obj32;
					if (obj33 != null)
					{
						obj26 = obj27;
					}
					bool flag15 = (nint)obj26 < <PlayersPilesList>k__BackingField.Length;
					object obj34 = !flag15;
					if (obj34 != null)
					{
						goto IL_06e6;
					}
					object obj35 = (object)tiltedPlayers.<PlayersPilesList>k__BackingField + obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v21+20]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v21+20]");
					bool flag16 = (nint)0 == 0;
					obj8 = obj6;
					sprite2 = (Sprite)obj7;
					if (!flag16)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X21_v9+28]");
						object obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X21_v9+28]");
						if ((nint)0 == 0)
						{
							goto IL_06d8;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X24_v6+18]");
						if ((nint)0 >= (nint)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X21_v9+28]");
							object obj38 = (nint)0 + (nint)32;
							object obj39 = 0;
							object obj40;
							do
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X26_v7+v422 @ X25_v8*8]");
								PlayerPilesStacks.SetTopCard((CardsStack)0, sprite);
								obj39++;
								obj40 = obj39;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X24_v6+18]");
							}
							while ((nint)obj40 < 0);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X21_v9+30]");
						PlayerPilesStacks.SetTopCard((CardsStack)0, sprite);
						obj8 = obj6;
						sprite2 = sprite;
					}
				}
			}
			goto IL_03ab;
		}
		goto IL_06d8;
		IL_03ab:
		UnityEngine.Object topDownPlayers = _topDownPlayers;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F65]");
		object obj41 = (nint)0 & (nint)1;
		if (obj41 != null)
		{
			object obj42 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0415;
			}
		}
		else
		{
			_ = 1;
			object obj42 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v12+E4]");
			bool flag17 = (nint)0 == 0;
			object obj43 = !flag17;
			if (obj43 != null)
			{
				goto IL_0415;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag18 = _topDownPlayers == null;
		bool flag19 = !flag18;
		object obj44 = !flag19;
		if (obj44 == null)
		{
			goto IL_04ce;
		}
		return;
		IL_06e6:
		throw new IndexOutOfRangeException();
	}

	public void ApplyState(int batchIndex)
	{
		//IL_00a8: Expected F4, but got I4
		if (batchIndex > 0)
		{
			DealerPileSO dealerPileSO = dealerPileSo;
			int[] <CardsPerBatch>k__BackingField = dealerPileSO.<CardsPerBatch>k__BackingField;
			float alpha = ((batchIndex >= <CardsPerBatch>k__BackingField.Length) ? 0f : 1f);
			_canvasGroup.alpha = alpha;
			ApplyPlayerState(batchIndex);
		}
		else
		{
			_canvasGroup.alpha = 1f;
			ApplyPlayerState(0);
			SnapPlayerPerspective();
		}
	}

	public void SetPerspective(bool isTopDown)
	{
		//IL_0068: Expected O, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0092: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_0104: Expected O, but got I4
		//IL_0120: Expected O, but got I4
		//IL_01a8: Expected O, but got I4
		//IL_01b1: Expected O, but got I4
		//IL_01bf: Expected O, but got I4
		//IL_0201: Expected O, but got I
		//IL_03d9: Expected O, but got I
		//IL_03f3: Expected O, but got I4
		//IL_03fc: Expected O, but got I4
		//IL_0405: Expected O, but got I4
		//IL_0246: Expected O, but got I4
		//IL_04bf: Expected O, but got I4
		//IL_0289: Expected O, but got I
		//IL_02f4: Expected O, but got I4
		//IL_0670: Expected O, but got I4
		//IL_0679: Expected O, but got I4
		//IL_077d: Expected O, but got I4
		//IL_06a1: Expected O, but got I4
		//IL_04fa: Expected O, but got I
		//IL_070f: Expected O, but got I4
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_0342: Expected O, but got I
		//IL_0362: Expected O, but got I
		//IL_037c: Expected O, but got I4
		//IL_0741: Expected F4, but got I4
		//IL_0805: Expected O, but got I
		//IL_06c1: Expected F4, but got I4
		//IL_052f: Expected O, but got I4
		//IL_0834: Expected O, but got I
		//IL_03a4: Expected O, but got I
		//IL_0562: Expected O, but got I
		//IL_05cd: Expected O, but got I4
		//IL_07d9: Expected O, but got I4
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected O, but got Unknown
		//IL_061b: Expected O, but got I
		//IL_0635: Expected O, but got I4
		//IL_0653: Expected O, but got I
		_isTopDown = isTopDown;
		DealerPileSO dealerPileSO = dealerPileSo;
		object obj2;
		object obj9;
		UnityEngine.Object obj10;
		object obj7;
		UnityEngine.Object obj8;
		if ((object)dealerPileSo != null)
		{
			if (_currentDealer > 0)
			{
				UnityEngine.Object tiltedPlayers = _tiltedPlayers;
				object obj = 152989696;
				obj2 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F65]");
				object obj3 = (nint)0 & (nint)1;
				if (obj3 != null)
				{
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v27+E4]");
					if ((nint)0 != 0)
					{
						goto IL_00dc;
					}
				}
				else
				{
					_ = 1;
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v27+E4]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 != null)
					{
						goto IL_00dc;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = _tiltedPlayers == null;
				bool flag3 = !flag2;
				object obj6 = !flag3;
				obj7 = 0;
				obj8 = null;
				obj9 = 0;
				obj10 = null;
				if (obj6 == null)
				{
					goto IL_01d2;
				}
				goto IL_03b9;
			}
			HideAllPlayerStacks();
			return;
		}
		goto IL_0747;
		IL_0747:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0755;
		IL_06d8:
		object obj11;
		if (obj11 != null)
		{
			bool flag4 = !isTopDown;
			object obj12 = !flag4;
			object obj13 = ~obj12;
			float endValue = ((obj13 != null) ? 0f : 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X20_v5+20]");
			TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade((CanvasGroup)0, endValue, dealerPileSO.<PerspectiveFadeDuration>k__BackingField);
		}
		return;
		IL_04cd:
		UnityEngine.Object obj14;
		object obj27;
		object obj28;
		if ((object)obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X21_v5 (UnityEngine.Object)+20]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X21_v5 (UnityEngine.Object)+20]");
			if ((nint)0 != 0)
			{
				object obj16 = _currentDealer - 1;
				if ((nint)obj16 >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v10+18]");
					object obj17 = -1;
					object obj18 = obj16 - obj17;
					bool flag5 = (nint)obj18 < 0;
					object obj19 = obj16 ^ obj17;
					object obj20 = obj16 ^ obj18;
					object obj21 = obj19 & obj20;
					bool flag6 = (nint)obj21 < 0;
					bool flag7 = flag5 == flag6;
					object obj22 = !flag7;
					object obj23 = ~obj22;
					if (obj23 != null)
					{
						obj16 = obj17;
					}
					object obj24 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v10+18]");
					bool flag8 = (nint)obj24 < 0;
					object obj25 = !flag8;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X21_v5 (UnityEngine.Object)+20]");
						object obj26 = 0 + obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v11+20]");
						obj27 = 0;
						bool flag9 = obj28 == null;
						object obj29 = !flag9;
						if (obj29 != null)
						{
							goto IL_0687;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v11+20]");
						obj11 = 0;
						goto IL_06d8;
					}
					goto IL_0755;
				}
			}
			goto IL_0658;
		}
		goto IL_0747;
		IL_03b9:
		PlayersPiles topDownPlayers = _topDownPlayers;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X24_v4+F65]");
		object obj30 = (nint)0 & (nint)1;
		bool flag10 = obj30 == null;
		object obj31 = !flag10;
		object obj32 = 0;
		obj28 = 0;
		obj7 = obj9;
		obj8 = obj10;
		obj14 = _topDownPlayers;
		if (obj31 == null)
		{
			goto IL_042d;
		}
		goto IL_078b;
		IL_042d:
		_ = 1;
		obj28 = obj32;
		obj7 = obj9;
		obj8 = obj10;
		obj14 = topDownPlayers;
		goto IL_078b;
		IL_0755:
		throw new IndexOutOfRangeException();
		IL_00dc:
		bool flag11 = _tiltedPlayers == null;
		bool flag12 = !flag11;
		obj7 = 0;
		obj8 = null;
		if (flag12)
		{
			goto IL_01d2;
		}
		obj9 = 0;
		obj10 = null;
		goto IL_03b9;
		IL_01d2:
		if ((object)_tiltedPlayers != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X21_v4 (UnityEngine.Object)+20]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X21_v4 (UnityEngine.Object)+20]");
			bool flag13 = (nint)0 == 0;
			obj9 = obj7;
			obj10 = obj8;
			if (!flag13)
			{
				object obj34 = _currentDealer - 1;
				bool flag14 = (nint)obj34 < 1;
				obj9 = obj7;
				obj10 = obj8;
				if (!flag14)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v17+18]");
					object obj35 = -1;
					object obj36 = obj34 - obj35;
					bool flag15 = (nint)obj36 < 0;
					object obj37 = obj34 ^ obj35;
					object obj38 = obj34 ^ obj36;
					object obj39 = obj37 & obj38;
					bool flag16 = (nint)obj39 < 0;
					bool flag17 = flag15 == flag16;
					object obj40 = !flag17;
					object obj41 = ~obj40;
					if (obj41 != null)
					{
						obj34 = obj35;
					}
					object obj42 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v17+18]");
					bool flag18 = (nint)obj42 < 0;
					object obj43 = !flag18;
					if (obj43 != null)
					{
						goto IL_0755;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X21_v4 (UnityEngine.Object)+20]");
					object obj44 = 0 + obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v18+20]");
					obj28 = 0;
					topDownPlayers = _topDownPlayers;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X24_v4+F65]");
					object obj45 = (nint)0 & (nint)1;
					bool flag19 = obj45 == null;
					object obj46 = !flag19;
					obj14 = _topDownPlayers;
					if (obj46 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v18+20]");
						obj32 = 0;
						obj9 = obj7;
						obj10 = obj8;
						goto IL_042d;
					}
					goto IL_078b;
				}
			}
			goto IL_03b9;
		}
		goto IL_0747;
		IL_078b:
		object obj47 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			if (!(obj14 == null))
			{
				goto IL_04cd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag20 = obj14 == null;
			bool flag21 = !flag20;
			object obj48 = !flag21;
			if (obj48 == null)
			{
				goto IL_04cd;
			}
		}
		goto IL_0658;
		IL_0658:
		bool flag22 = obj28 == null;
		obj27 = 0;
		obj11 = 0;
		if (!flag22)
		{
			goto IL_0687;
		}
		goto IL_06d8;
		IL_0687:
		bool flag23 = !isTopDown;
		object obj49 = !flag23;
		object obj50 = ~obj49;
		float endValue2 = ((obj50 != null) ? 1f : 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X22_v4+20]");
		TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTweenModuleUI.DOFade((CanvasGroup)0, endValue2, dealerPileSO.<PerspectiveFadeDuration>k__BackingField);
		obj11 = obj27;
		goto IL_06d8;
	}

	public void SnapToDealerInstant(int rotatedDealer)
	{
		_currentDealer = rotatedDealer;
		_canvasGroup.alpha = 1f;
		SnapPlayerPerspective();
	}

	public Sequence BuildMoveSequence(int rotatedDealer)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_00cd: Expected O, but got I
		_currentDealer = rotatedDealer;
		SnapPlayerPerspective();
		DealerPileSO dealerPileSO = dealerPileSo;
		if ((object)dealerPileSo != null && (object)_canvasGroup != null)
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			_canvasGroup.alpha = 0f;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence s = DOTween.Sequence();
			DealerPileSO dealerPileSO2 = dealerPileSo;
			if ((object)dealerPileSo != null)
			{
				object obj4 = (nint)0 + (nint)2864;
				float duration = dealerPileSO.<FadeInDuration>k__BackingField * dealerPileSO2.<FadeInDurationMultiplier>k__BackingField;
				TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(_canvasGroup, 1f, duration);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				Tween t = default(Tween);
				return TweenSettingsExtensions.Join(s, t);
			}
		}
		return (Sequence)(object)new NullReferenceException();
	}

	public Sequence BuildBatchSequence(int nextBatchIndex, float batchDuration, float lastCardTime = -1f)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_01f6: Invalid comparison between F4 and I4
		//IL_0209: Expected O, but got F4
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_023e: Expected O, but got I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_0101: Expected O, but got I
		//IL_015a: Expected O, but got I4
		//IL_0193: Expected O, but got I
		DealerPileSO dealerPileSO = dealerPileSo;
		Sequence sequence;
		TweenerCore<float, float, FloatOptions> t = default(TweenerCore<float, float, FloatOptions>);
		if ((object)dealerPileSo != null)
		{
			int[] <CardsPerBatch>k__BackingField = dealerPileSO.<CardsPerBatch>k__BackingField;
			if (dealerPileSO.<CardsPerBatch>k__BackingField != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Sequence s = DOTween.Sequence();
				sequence = TweenSettingsExtensions.AppendInterval(s, 0f);
				if (nextBatchIndex >= <CardsPerBatch>k__BackingField.Length)
				{
					DealerPileSO dealerPileSO2 = dealerPileSo;
					if ((object)dealerPileSo != null)
					{
						t = DOTweenModuleUI.DOFade(_canvasGroup, 0f, dealerPileSO2.<BatchFadeDuration>k__BackingField);
						goto IL_01ed;
					}
				}
				else
				{
					DealerPileSO dealerPileSO3 = dealerPileSo;
					if ((object)dealerPileSo != null)
					{
						object obj4 = typeof(UsageHint) + 816;
						object obj5 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X9_v7+B8]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v8+C]");
						float duration = 0f * dealerPileSO3.<PunchStrength>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v8+10]");
						float elasticity = 0f * dealerPileSO3.<PunchStrength>k__BackingField;
						Tweener tweener = ShortcutExtensions.DOPunchScale(_transform, (Vector3)dealerPileSO3.<PunchVibrato>k__BackingField, duration, 0, elasticity);
						DealerPileSO dealerPileSO4 = dealerPileSo;
						if ((object)dealerPileSo != null)
						{
							object obj7 = (nint)0 + (nint)2944;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
							goto IL_01ed;
						}
					}
				}
			}
		}
		return (Sequence)(object)new NullReferenceException();
		IL_01ed:
		bool flag2 = lastCardTime < 0f;
		object obj8 = lastCardTime ^ lastCardTime;
		object obj9 = lastCardTime & obj8;
		bool flag3 = (nint)obj9 < 0;
		bool flag4 = flag2 == flag3;
		object obj10 = !flag4;
		object obj11 = ~obj10;
		if (obj11 == null)
		{
		}
		Sequence sequence2 = TweenSettingsExtensions.Insert(sequence, lastCardTime, t);
		return sequence;
	}

	public Sequence BuildPlayerBatchSequence(int nextBatchIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0052: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_00db: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_0169: Expected O, but got I4
		//IL_01a6: Expected O, but got I
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_0385: Expected O, but got I4
		//IL_03af: Expected O, but got I
		//IL_03c9: Expected O, but got I4
		//IL_03d2: Expected O, but got I4
		//IL_03e3: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_0497: Expected O, but got I4
		//IL_04a0: Expected O, but got I4
		//IL_04a9: Expected O, but got I4
		//IL_0444: Expected O, but got I4
		//IL_021e: Expected O, but got I
		//IL_0289: Expected O, but got I4
		//IL_062b: Expected O, but got I4
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected O, but got Unknown
		//IL_045b: Expected O, but got I4
		//IL_0c0c: Expected O, but got I4
		//IL_06a7: Expected O, but got I
		//IL_04e4: Expected O, but got I
		//IL_06c4: Expected O, but got I4
		//IL_06d2: Expected O, but got I4
		//IL_0642: Expected O, but got I
		//IL_065c: Expected O, but got I4
		//IL_0665: Expected O, but got I4
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02d7: Expected O, but got I
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_02f5: Expected O, but got I
		//IL_031f: Expected O, but got I
		//IL_0339: Expected O, but got I4
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected O, but got Unknown
		//IL_07eb: Expected O, but got I4
		//IL_0521: Expected O, but got I4
		//IL_0681: Expected O, but got I4
		//IL_0369: Expected O, but got I
		//IL_078c: Expected O, but got I4
		//IL_0795: Expected O, but got I4
		//IL_0738: Expected O, but got I4
		//IL_055c: Expected O, but got I
		//IL_05c7: Expected O, but got I4
		//IL_0c68: Expected O, but got I4
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected O, but got Unknown
		//IL_0615: Expected O, but got I
		//IL_0a69: Expected O, but got I
		//IL_0a88: Expected O, but got I4
		//IL_0a91: Expected O, but got I4
		//IL_0a9f: Expected O, but got I4
		//IL_08dd: Expected O, but got I
		//IL_08f5: Expected O, but got I4
		//IL_0903: Expected O, but got I4
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected O, but got Unknown
		//IL_0940: Expected O, but got I
		//IL_0951: Expected I, but got O
		//IL_099e: Expected O, but got I4
		//IL_09a7: Expected F4, but got I4
		//IL_09b0: Expected O, but got I4
		//IL_09c1: Expected O, but got I4
		//IL_09ca: Expected F4, but got I4
		//IL_0b31: Expected O, but got I4
		//IL_0a13: Expected O, but got I4
		//IL_0a24: Expected O, but got I4
		//IL_0a35: Expected O, but got I4
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Expected O, but got Unknown
		//IL_0b6e: Expected O, but got I
		//IL_0b7f: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 3808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3;
		object obj9;
		object obj8;
		if (obj2 != null)
		{
			obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			UnityEngine.Object tiltedPlayers = _tiltedPlayers;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F65]");
			object obj4 = (nint)0 & (nint)1;
			if (obj4 != null)
			{
				object obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v81+E4]");
				if ((nint)0 != 0)
				{
					goto IL_009c;
				}
			}
			else
			{
				_ = 1;
				object obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v81+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				if (obj6 != null)
				{
					goto IL_009c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = _tiltedPlayers == null;
			bool flag3 = !flag2;
			object obj7 = !flag3;
			obj8 = 0;
			obj9 = 0;
			if (obj7 == null)
			{
				goto IL_0177;
			}
			goto IL_036e;
		}
		goto IL_0b9f;
		IL_0b44:
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)1336;
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj11);
		Sequence sequence2;
		Sequence sequence = TweenSettingsExtensions.InsertCallback(sequence2, 0f, tweenCallback);
		return sequence2;
		IL_0b07:
		UnityEngine.Object obj12;
		bool flag4 = obj12 != null;
		bool flag5 = !flag4;
		Sequence result = sequence2;
		object obj13 = 0;
		UnityEngine.Object obj14 = null;
		if (flag5)
		{
			goto IL_0a48;
		}
		goto IL_0b44;
		IL_04b7:
		UnityEngine.Object obj15;
		object obj18;
		object obj30;
		if ((object)obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X21_v5 (UnityEngine.Object)+20]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X21_v5 (UnityEngine.Object)+20]");
			bool flag6 = (nint)0 == 0;
			object obj17 = obj18;
			if (!flag6)
			{
				object obj19 = _currentDealer - 1;
				bool flag7 = (nint)obj19 < 1;
				obj17 = obj18;
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v32+18]");
					object obj20 = -1;
					object obj21 = obj19 - obj20;
					bool flag8 = (nint)obj21 < 0;
					object obj22 = obj19 ^ obj20;
					object obj23 = obj19 ^ obj21;
					object obj24 = obj22 & obj23;
					bool flag9 = (nint)obj24 < 0;
					bool flag10 = flag8 == flag9;
					object obj25 = !flag10;
					object obj26 = ~obj25;
					if (obj26 != null)
					{
						obj19 = obj20;
					}
					object obj27 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v32+18]");
					bool flag11 = (nint)obj27 < 0;
					object obj28 = !flag11;
					if (obj28 != null)
					{
						goto IL_0bad;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X21_v5 (UnityEngine.Object)+20]");
					object obj29 = 0 + obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v33+20]");
					obj30 = 0;
					obj17 = obj18;
					goto IL_0c76;
				}
			}
			goto IL_0622;
		}
		goto IL_0b9f;
		IL_0916:
		object obj31 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj32 = (nint)0 + (nint)1328;
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(obj2, (IntPtr)obj32);
		Sequence sequence3 = TweenSettingsExtensions.InsertCallback(sequence2, 0f, tweenCallback2);
		object obj34;
		UnityEngine.Object obj33 = (UnityEngine.Object)obj34;
		object obj35 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v24+E4]");
		bool flag12 = (nint)0 == 0;
		object obj36 = !flag12;
		float num = 0f;
		object obj37 = 0;
		TweenCallback tweenCallback3 = tweenCallback2;
		object obj38 = 0;
		float num2 = 0f;
		obj12 = (UnityEngine.Object)obj34;
		if (obj36 == null)
		{
			goto IL_09e0;
		}
		goto IL_0b07;
		IL_009c:
		bool flag13 = _tiltedPlayers == null;
		bool flag14 = !flag13;
		obj8 = 0;
		if (flag14)
		{
			goto IL_0177;
		}
		obj9 = 0;
		goto IL_036e;
		IL_0177:
		PlayersPiles topDownPlayers;
		object obj55;
		object obj51;
		if ((object)_tiltedPlayers != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X21_v4 (UnityEngine.Object)+20]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X21_v4 (UnityEngine.Object)+20]");
			bool flag15 = (nint)0 == 0;
			obj9 = obj8;
			if (!flag15)
			{
				object obj40 = _currentDealer - 1;
				bool flag16 = (nint)obj40 < 1;
				obj9 = obj8;
				if (!flag16)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v39+18]");
					object obj41 = -1;
					object obj42 = obj40 - obj41;
					bool flag17 = (nint)obj42 < 0;
					object obj43 = obj40 ^ obj41;
					object obj44 = obj40 ^ obj42;
					object obj45 = obj43 & obj44;
					bool flag18 = (nint)obj45 < 0;
					bool flag19 = flag17 == flag18;
					object obj46 = !flag19;
					object obj47 = ~obj46;
					if (obj47 != null)
					{
						obj40 = obj41;
					}
					object obj48 = obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v39+18]");
					bool flag20 = (nint)obj48 < 0;
					object obj49 = !flag20;
					if (obj49 != null)
					{
						goto IL_0bad;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X21_v4 (UnityEngine.Object)+20]");
					object obj50 = 0 + obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v40+20]");
					obj51 = 0;
					object obj52 = obj2 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v40+20]");
					obj52 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					topDownPlayers = _topDownPlayers;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F65]");
					object obj53 = (nint)0 & (nint)1;
					bool flag21 = obj53 == null;
					object obj54 = !flag21;
					obj15 = _topDownPlayers;
					if (obj54 == null)
					{
						obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v40+20]");
						obj55 = 0;
						goto IL_03fb;
					}
					goto IL_0c1a;
				}
			}
			goto IL_036e;
		}
		goto IL_0b9f;
		IL_0a48:
		return result;
		IL_07ad:
		object obj56 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj57 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v17+E4]");
		bool flag22 = (nint)0 == 0;
		object obj58 = !flag22;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		sequence2 = DOTween.Sequence();
		Sequence sequence4 = TweenSettingsExtensions.AppendInterval(sequence2, 0f);
		DealerPileSO dealerPileSO = dealerPileSo;
		if ((object)dealerPileSo != null)
		{
			int[] <CardsPerBatch>k__BackingField = dealerPileSO.<CardsPerBatch>k__BackingField;
			if (dealerPileSO.<CardsPerBatch>k__BackingField != null)
			{
				_ = <CardsPerBatch>k__BackingField.Length;
				num = dealerPileSO.<BatchFadeDuration>k__BackingField;
				_ = dealerPileSO.<BatchFadeDuration>k__BackingField;
				object obj59 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v16+E4]");
				UnityEngine.Object obj62;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
					bool flag23 = (UnityEngine.Object)0 != null;
					bool flag24 = !flag23;
					object obj60 = 0;
					UnityEngine.Object obj61 = null;
					obj37 = 0;
					obj62 = null;
					if (!flag24)
					{
						goto IL_0916;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
					bool flag25 = (UnityEngine.Object)0 != null;
					bool flag26 = !flag25;
					object obj63 = !flag26;
					object obj60 = 0;
					UnityEngine.Object obj61 = null;
					obj37 = 0;
					obj62 = null;
					if (obj63 != null)
					{
						goto IL_0916;
					}
				}
				obj33 = (UnityEngine.Object)obj34;
				obj35 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v24+E4]");
				bool flag27 = (nint)0 == 0;
				tweenCallback3 = (TweenCallback)(object)obj62;
				object obj64 = default(object);
				obj38 = obj64;
				num2 = num;
				obj12 = (UnityEngine.Object)obj34;
				if (flag27)
				{
					goto IL_09e0;
				}
				goto IL_0b07;
			}
		}
		goto IL_0b9f;
		IL_0b9f:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0bad;
		IL_06e5:
		object obj65 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X0_v51+E4]");
		if ((nint)0 != 0)
		{
			bool flag28 = (UnityEngine.Object)obj34 == null;
			bool flag29 = !flag28;
			object obj66 = 0;
			UnityEngine.Object obj67 = null;
			if (flag29)
			{
				goto IL_07ad;
			}
			result = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag30 = (UnityEngine.Object)obj34 == null;
			bool flag31 = !flag30;
			object obj68 = !flag31;
			object obj66 = 0;
			UnityEngine.Object obj67 = null;
			result = null;
			if (obj68 == null)
			{
				goto IL_07ad;
			}
		}
		goto IL_0a48;
		IL_09e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag32 = obj33 != null;
		bool flag33 = !flag32;
		object obj69 = !flag33;
		result = sequence2;
		obj38 = 0;
		num2 = num;
		obj13 = 0;
		obj14 = null;
		if (obj69 == null)
		{
			goto IL_0a48;
		}
		goto IL_0b44;
		IL_0622:
		obj30 = 0;
		goto IL_0c76;
		IL_0c76:
		obj34 = obj2 + 40;
		obj34 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj70 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X21_v7-18]");
			bool flag34 = (UnityEngine.Object)0 == null;
			bool flag35 = !flag34;
			object obj71 = !flag35;
			object obj72 = 0;
			UnityEngine.Object obj73 = null;
			if (obj71 != null)
			{
				goto IL_06e5;
			}
			object obj66 = 0;
			UnityEngine.Object obj67 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X21_v7-18]");
			bool flag36 = (UnityEngine.Object)0 == null;
			bool flag37 = !flag36;
			object obj72 = 0;
			UnityEngine.Object obj73 = null;
			object obj66 = 0;
			UnityEngine.Object obj67 = null;
			if (!flag37)
			{
				goto IL_06e5;
			}
		}
		goto IL_07ad;
		IL_0bad:
		return (Sequence)(object)new IndexOutOfRangeException();
		IL_036e:
		object obj74 = obj2 + 16;
		obj74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		topDownPlayers = _topDownPlayers;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F65]");
		object obj75 = (nint)0 & (nint)1;
		bool flag38 = obj75 == null;
		object obj76 = !flag38;
		obj55 = 0;
		obj8 = obj9;
		obj51 = 0;
		obj15 = _topDownPlayers;
		if (obj76 == null)
		{
			goto IL_03fb;
		}
		goto IL_0c1a;
		IL_03fb:
		_ = 1;
		obj8 = obj9;
		obj51 = obj55;
		obj15 = topDownPlayers;
		goto IL_0c1a;
		IL_0c1a:
		object obj77 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			bool flag39 = obj15 == null;
			bool flag40 = !flag39;
			obj18 = 0;
			if (flag40)
			{
				goto IL_04b7;
			}
			object obj17 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag41 = obj15 == null;
			bool flag42 = !flag41;
			object obj78 = !flag42;
			obj18 = 0;
			object obj17 = 0;
			if (obj78 == null)
			{
				goto IL_04b7;
			}
		}
		goto IL_0622;
	}

	private PlayerPilesStacks ActivePlayerStack(PlayersPiles playersPiles)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0119: Expected O, but got I4
		//IL_0183: Expected O, but got I4
		//IL_01b0: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_029c: Expected O, but got I4
		//IL_0263: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F65]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = playersPiles == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			goto IL_0127;
		}
		goto IL_0263;
		IL_0263:
		return null;
		IL_0273:
		return (PlayerPilesStacks)(object)new IndexOutOfRangeException();
		IL_0127:
		if ((object)playersPiles != null)
		{
			PlayerPilesStacks[] <PlayersPilesList>k__BackingField = playersPiles.<PlayersPilesList>k__BackingField;
			if (playersPiles.<PlayersPilesList>k__BackingField != null)
			{
				object obj6 = _currentDealer - 1;
				if ((nint)obj6 >= 1)
				{
					object obj7 = <PlayersPilesList>k__BackingField.Length - 1;
					object obj8 = obj6 - obj7;
					bool flag4 = (nint)obj8 < 0;
					object obj9 = obj6 ^ obj7;
					object obj10 = obj6 ^ obj8;
					object obj11 = obj9 & obj10;
					bool flag5 = (nint)obj11 < 0;
					bool flag6 = flag4 == flag5;
					object obj12 = !flag6;
					object obj13 = ~obj12;
					if (obj13 != null)
					{
						obj6 = obj7;
					}
					bool flag7 = (nint)obj6 < <PlayersPilesList>k__BackingField.Length;
					object obj14 = !flag7;
					if (obj14 == null)
					{
						object obj15 = (object)playersPiles.<PlayersPilesList>k__BackingField + obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v6+20]");
						return (PlayerPilesStacks)0;
					}
					goto IL_0273;
				}
			}
			goto IL_0263;
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0273;
		IL_0074:
		if (!(playersPiles == null))
		{
			goto IL_0127;
		}
		goto IL_0263;
	}

	private void HideAllPlayerStacks()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0114: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_0167: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		//IL_01b3: Expected O, but got I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_0201: Expected O, but got I4
		//IL_032e: Expected O, but got I4
		//IL_025b: Expected O, but got I
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0296: Expected O, but got I
		//IL_03a8: Expected O, but got I4
		//IL_02b5: Expected O, but got I
		//IL_02bf: Expected O, but got I4
		//IL_02c8: Expected F4, but got I4
		//IL_02d1: Expected O, but got I4
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_03de: Expected O, but got I4
		//IL_0423: Expected O, but got I
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_045e: Expected O, but got I
		//IL_0484: Expected O, but got I4
		//IL_03f9: Expected O, but got I
		//IL_0403: Expected O, but got I4
		//IL_040c: Expected F4, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EFA]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object tiltedPlayers;
		UnityEngine.Object tiltedPlayers2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v23+E4]");
			bool flag = (nint)0 == 0;
			tiltedPlayers = _tiltedPlayers;
			tiltedPlayers2 = _tiltedPlayers;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v23+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			tiltedPlayers = _tiltedPlayers;
			tiltedPlayers2 = _tiltedPlayers;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = tiltedPlayers2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (!flag4)
		{
			goto IL_0188;
		}
		goto IL_02db;
		IL_02db:
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = _topDownPlayers != null;
			bool flag6 = !flag5;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(_topDownPlayers != null))
			{
				return;
			}
		}
		PlayersPiles topDownPlayers = _topDownPlayers;
		PlayerPilesStacks[] <PlayersPilesList>k__BackingField = topDownPlayers.<PlayersPilesList>k__BackingField;
		object obj12 = <PlayersPilesList>k__BackingField.Length;
		if (<PlayersPilesList>k__BackingField.Length < 1)
		{
			return;
		}
		object obj13 = <PlayersPilesList>k__BackingField + 32;
		object obj14 = 0;
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X21_v6+v203 @ X20_v8*8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X21_v6+v203 @ X20_v8*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X22_v6+20]");
				int num = ShortcutExtensions.DOKill((Component)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X22_v6+20]");
				bool flag7 = (nint)0 == 0;
				object obj16 = !flag7;
				if (obj16 == null)
				{
					throw new NullReferenceException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X22_v6+20]");
				((CanvasGroup)0).alpha = 0f;
				obj12 = <PlayersPilesList>k__BackingField.Length;
				float num2 = 0f;
			}
			obj14++;
		}
		while (obj14 < obj12);
		return;
		IL_0188:
		PlayersPiles tiltedPlayers3 = _tiltedPlayers;
		PlayerPilesStacks[] <PlayersPilesList>k__BackingField2 = tiltedPlayers3.<PlayersPilesList>k__BackingField;
		object obj17 = <PlayersPilesList>k__BackingField2.Length;
		bool flag8 = <PlayersPilesList>k__BackingField2.Length < 1;
		obj8 = obj6;
		obj9 = obj7;
		if (!flag8)
		{
			object obj18 = <PlayersPilesList>k__BackingField2 + 32;
			float num2 = default(float);
			float num3 = num2;
			object obj19 = 0;
			bool flag9;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X23_v5+v151 @ X22_v8*8]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X23_v5+v151 @ X22_v8*8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X24_v6+20]");
					int num4 = ShortcutExtensions.DOKill((Component)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X24_v6+20]");
					((CanvasGroup)0).alpha = 0f;
					obj17 = <PlayersPilesList>k__BackingField2.Length;
					num3 = 0f;
					obj6 = 0;
					obj7 = null;
				}
				obj19++;
				flag9 = obj19 >= obj17;
				num2 = num3;
				obj8 = obj6;
				obj9 = obj7;
			}
			while (!flag9);
		}
		goto IL_02db;
		IL_0091:
		flag3 = tiltedPlayers != null;
		bool flag10 = !flag3;
		object obj21 = !flag10;
		obj6 = 0;
		obj7 = null;
		if (obj21 != null)
		{
			goto IL_0188;
		}
		obj8 = 0;
		obj9 = null;
		goto IL_02db;
	}

	private void SnapPlayerPerspective()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_00c8: Expected O, but got I4
		//IL_0149: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_01a2: Expected O, but got I
		//IL_03ca: Expected O, but got I
		//IL_0476: Expected O, but got I4
		//IL_01e7: Expected O, but got I4
		//IL_022a: Expected O, but got I
		//IL_0295: Expected O, but got I4
		//IL_04bd: Expected O, but got I4
		//IL_04fa: Expected O, but got I
		//IL_0709: Expected O, but got I4
		//IL_052f: Expected O, but got I4
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02e3: Expected O, but got I
		//IL_0562: Expected O, but got I
		//IL_05cd: Expected O, but got I4
		//IL_032e: Expected O, but got I
		//IL_0760: Expected O, but got I4
		//IL_0373: Expected O, but got I4
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected O, but got Unknown
		//IL_061b: Expected O, but got I
		//IL_072c: Expected O, but got I
		//IL_0735: Expected O, but got I4
		//IL_0393: Expected F4, but got I4
		//IL_0656: Expected O, but got I
		//IL_069b: Expected O, but got I4
		//IL_06cd: Expected F4, but got I4
		//IL_0783: Expected O, but got I
		HideAllPlayerStacks();
		UnityEngine.Object tiltedPlayers = _tiltedPlayers;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F65]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v27+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0084;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0084;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = _tiltedPlayers == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (obj5 == null)
		{
			goto IL_0173;
		}
		goto IL_03aa;
		IL_04cb:
		if ((object)_topDownPlayers != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X20_v5 (UnityEngine.Object)+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X20_v5 (UnityEngine.Object)+20]");
			if ((nint)0 == 0)
			{
				return;
			}
			object obj11 = _currentDealer - 1;
			if ((nint)obj11 < 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v8+18]");
			object obj12 = -1;
			object obj13 = obj11 - obj12;
			bool flag4 = (nint)obj13 < 0;
			object obj14 = obj11 ^ obj12;
			object obj15 = obj11 ^ obj13;
			object obj16 = obj14 & obj15;
			bool flag5 = (nint)obj16 < 0;
			bool flag6 = flag4 == flag5;
			object obj17 = !flag6;
			object obj18 = ~obj17;
			if (obj18 != null)
			{
				obj11 = obj12;
			}
			object obj19 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v8+18]");
			bool flag7 = (nint)obj19 < 0;
			object obj20 = !flag7;
			if (obj20 != null)
			{
				goto IL_06e1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X20_v5 (UnityEngine.Object)+20]");
			object obj21 = 0 + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v9+20]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v9+20]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X20_v8+20]");
			int num = ShortcutExtensions.DOKill((Component)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X20_v8+20]");
			if ((nint)0 != 0)
			{
				bool flag8 = !_isTopDown;
				object obj23 = !flag8;
				object obj24 = ~obj23;
				float alpha = ((obj24 != null) ? 0f : 1f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X20_v8+20]");
				((CanvasGroup)0).alpha = alpha;
				return;
			}
		}
		goto IL_06d3;
		IL_06d3:
		NullReferenceException ex = new NullReferenceException();
		goto IL_06e1;
		IL_0414:
		if (_topDownPlayers == null)
		{
			return;
		}
		goto IL_04cb;
		IL_0084:
		bool flag9 = _tiltedPlayers == null;
		bool flag10 = !flag9;
		obj6 = 0;
		obj7 = null;
		if (flag10)
		{
			goto IL_0173;
		}
		obj8 = 0;
		obj9 = null;
		goto IL_03aa;
		IL_0173:
		if ((object)_tiltedPlayers != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X20_v1 (UnityEngine.Object)+20]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X20_v1 (UnityEngine.Object)+20]");
			bool flag11 = (nint)0 == 0;
			obj8 = obj6;
			obj9 = obj7;
			if (!flag11)
			{
				object obj26 = _currentDealer - 1;
				bool flag12 = (nint)obj26 < 1;
				obj8 = obj6;
				obj9 = obj7;
				if (!flag12)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v16+18]");
					object obj27 = -1;
					object obj28 = obj26 - obj27;
					bool flag13 = (nint)obj28 < 0;
					object obj29 = obj26 ^ obj27;
					object obj30 = obj26 ^ obj28;
					object obj31 = obj29 & obj30;
					bool flag14 = (nint)obj31 < 0;
					bool flag15 = flag13 == flag14;
					object obj32 = !flag15;
					object obj33 = ~obj32;
					if (obj33 != null)
					{
						obj26 = obj27;
					}
					object obj34 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v16+18]");
					bool flag16 = (nint)obj34 < 0;
					object obj35 = !flag16;
					if (obj35 != null)
					{
						goto IL_06e1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X20_v1 (UnityEngine.Object)+20]");
					object obj36 = 0 + obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v17+20]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v17+20]");
					bool flag17 = (nint)0 == 0;
					obj8 = obj6;
					obj9 = obj7;
					if (!flag17)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X20_v10+20]");
						int num2 = ShortcutExtensions.DOKill((Component)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X20_v10+20]");
						if ((nint)0 == 0)
						{
							goto IL_06d3;
						}
						bool flag18 = !_isTopDown;
						object obj38 = !flag18;
						object obj39 = ~obj38;
						float alpha2 = ((obj39 != null) ? 1f : 0f);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X20_v10+20]");
						((CanvasGroup)0).alpha = alpha2;
						obj8 = 0;
						obj9 = null;
					}
				}
			}
			goto IL_03aa;
		}
		goto IL_06d3;
		IL_03aa:
		UnityEngine.Object topDownPlayers = _topDownPlayers;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F65]");
		object obj40 = (nint)0 & (nint)1;
		if (obj40 != null)
		{
			object obj41 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0414;
			}
		}
		else
		{
			_ = 1;
			object obj41 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v11+E4]");
			bool flag19 = (nint)0 == 0;
			object obj42 = !flag19;
			if (obj42 != null)
			{
				goto IL_0414;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag20 = _topDownPlayers == null;
		bool flag21 = !flag20;
		object obj43 = !flag21;
		if (obj43 == null)
		{
			goto IL_04cb;
		}
		return;
		IL_06e1:
		throw new IndexOutOfRangeException();
	}

	private void ApplyPlayerState(int batchIndex)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_008c: Expected O, but got I
		//IL_0158: Expected O, but got I4
		//IL_019f: Expected O, but got I4
		//IL_021d: Expected I4, but got O
		//IL_03a5: Expected O, but got I
		//IL_0451: Expected O, but got I4
		//IL_023b: Expected O, but got I4
		//IL_025a: Expected I4, but got O
		//IL_0278: Expected O, but got I4
		//IL_02e3: Expected O, but got I4
		//IL_0498: Expected O, but got I4
		//IL_04d5: Expected O, but got I
		//IL_0658: Expected O, but got I4
		//IL_050a: Expected O, but got I4
		//IL_0345: Expected I4, but got O
		//IL_053d: Expected O, but got I
		//IL_05a8: Expected O, but got I4
		//IL_036e: Expected O, but got I
		//IL_0687: Expected O, but got I4
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected O, but got Unknown
		//IL_0626: Expected O, but got I
		DealerPileSO dealerPileSO = dealerPileSo;
		int[] <CardsPerBatch>k__BackingField;
		PlayersPiles tiltedPlayers;
		object obj;
		int num;
		UnityEngine.Object obj6;
		int num2;
		int num3;
		if ((object)dealerPileSo != null)
		{
			<CardsPerBatch>k__BackingField = dealerPileSO.<CardsPerBatch>k__BackingField;
			if (dealerPileSO.<CardsPerBatch>k__BackingField != null)
			{
				tiltedPlayers = _tiltedPlayers;
				obj = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F65]");
				object obj2 = (nint)0 & (nint)1;
				if (obj2 != null)
				{
					object obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v23+E4]");
					if ((nint)0 != 0)
					{
						goto IL_00d6;
					}
				}
				else
				{
					_ = 1;
					object obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v23+E4]");
					bool flag = (nint)0 == 0;
					object obj4 = !flag;
					if (obj4 != null)
					{
						goto IL_00d6;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = _tiltedPlayers == null;
				bool flag3 = !flag2;
				object obj5 = !flag3;
				num = 0;
				obj6 = null;
				num2 = 0;
				num3 = 0;
				if (obj5 == null)
				{
					goto IL_01cd;
				}
				goto IL_0385;
			}
		}
		goto IL_0628;
		IL_03ef:
		if (_topDownPlayers == null)
		{
			return;
		}
		goto IL_04a6;
		IL_04a6:
		if ((object)_topDownPlayers == null)
		{
			goto IL_0628;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X22_v4 (UnityEngine.Object)+20]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X22_v4 (UnityEngine.Object)+20]");
		if ((nint)0 == 0)
		{
			return;
		}
		object obj8 = _currentDealer - 1;
		if ((nint)obj8 < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v10+18]");
		object obj9 = -1;
		object obj10 = obj8 - obj9;
		bool flag4 = (nint)obj10 < 0;
		object obj11 = obj8 ^ obj9;
		object obj12 = obj8 ^ obj10;
		object obj13 = obj11 & obj12;
		bool flag5 = (nint)obj13 < 0;
		bool flag6 = flag4 == flag5;
		object obj14 = !flag6;
		object obj15 = ~obj14;
		if (obj15 != null)
		{
			obj8 = obj9;
		}
		object obj16 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v10+18]");
		bool flag7 = (nint)obj16 < 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X22_v4 (UnityEngine.Object)+20]");
			object obj18 = 0 + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v11+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v11+20]");
				((PlayerPilesStacks)0).ApplyState(batchIndex, <CardsPerBatch>k__BackingField.Length);
			}
			return;
		}
		goto IL_0636;
		IL_0636:
		throw new IndexOutOfRangeException();
		IL_0628:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0636;
		IL_0385:
		UnityEngine.Object topDownPlayers = _topDownPlayers;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F65]");
		object obj19 = (nint)0 & (nint)1;
		if (obj19 != null)
		{
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_03ef;
			}
		}
		else
		{
			_ = 1;
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v9+E4]");
			bool flag8 = (nint)0 == 0;
			object obj21 = !flag8;
			if (obj21 != null)
			{
				goto IL_03ef;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag9 = _topDownPlayers == null;
		bool flag10 = !flag9;
		object obj22 = !flag10;
		if (obj22 == null)
		{
			goto IL_04a6;
		}
		return;
		IL_00d6:
		bool flag11 = _tiltedPlayers == null;
		bool flag12 = !flag11;
		num = 0;
		obj6 = null;
		if (flag12)
		{
			goto IL_01cd;
		}
		num2 = 0;
		num3 = 0;
		goto IL_0385;
		IL_01cd:
		if ((object)_tiltedPlayers != null)
		{
			PlayerPilesStacks[] <PlayersPilesList>k__BackingField = tiltedPlayers.<PlayersPilesList>k__BackingField;
			bool flag13 = tiltedPlayers.<PlayersPilesList>k__BackingField == null;
			num2 = num;
			num3 = (int)obj6;
			if (!flag13)
			{
				object obj23 = _currentDealer - 1;
				bool flag14 = (nint)obj23 < 1;
				num2 = num;
				num3 = (int)obj6;
				if (!flag14)
				{
					object obj24 = <PlayersPilesList>k__BackingField.Length - 1;
					object obj25 = obj23 - obj24;
					bool flag15 = (nint)obj25 < 0;
					object obj26 = obj23 ^ obj24;
					object obj27 = obj23 ^ obj25;
					object obj28 = obj26 & obj27;
					bool flag16 = (nint)obj28 < 0;
					bool flag17 = flag15 == flag16;
					object obj29 = !flag17;
					object obj30 = ~obj29;
					if (obj30 != null)
					{
						obj23 = obj24;
					}
					bool flag18 = (nint)obj23 < <PlayersPilesList>k__BackingField.Length;
					object obj31 = !flag18;
					if (obj31 != null)
					{
						goto IL_0636;
					}
					object obj32 = (object)tiltedPlayers.<PlayersPilesList>k__BackingField + obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v19+20]");
					bool flag19 = (nint)0 == 0;
					num2 = num;
					num3 = (int)obj6;
					if (!flag19)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v19+20]");
						((PlayerPilesStacks)0).ApplyState(batchIndex, <CardsPerBatch>k__BackingField.Length);
						num2 = <CardsPerBatch>k__BackingField.Length;
						num3 = batchIndex;
					}
				}
			}
			goto IL_0385;
		}
		goto IL_0628;
	}

	private void ResetState()
	{
		_canvasGroup.alpha = 1f;
		ApplyPlayerState(0);
		SnapPlayerPerspective();
	}
}
