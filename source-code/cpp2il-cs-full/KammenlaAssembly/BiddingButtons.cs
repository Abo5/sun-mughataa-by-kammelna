using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UI;

public class BiddingButtons : MonoBehaviour
{
	protected CardGame game;

	public RectTransform biddingBar;

	protected bool isBidder;

	protected List<Button> allButtons;

	protected Button preDeterminedChoice;

	protected bool isNaturalFlowDisturbedThisRound;

	protected bool? _allowBiddingPredetermination;

	protected unsafe bool allowBiddingPredetermination
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Expected O, but got Unknown
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_0172: Expected O, but got I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Expected O, but got Unknown
			//IL_01b0: Expected O, but got I
			//IL_01da: Expected O, but got I4
			//IL_010a: Expected O, but got I4
			//IL_024e: Expected O, but got I4
			//IL_0392: Expected I4, but got O
			object obj = 152985600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E664F]");
			object obj2 = (nint)0 & (nint)1;
			object obj3;
			bool? flag;
			object obj5;
			bool? flag3;
			if (obj2 != null)
			{
				obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				flag = (bool?)(object)(this + 73);
				object obj4 = (??)flag & 1;
				bool flag2 = obj4 == null;
				obj5 = obj3;
				flag3 = flag;
				if (!flag2)
				{
					goto IL_0096;
				}
			}
			else
			{
				_ = 1;
				obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				flag = (bool?)(object)(this + 73);
				object obj6 = (??)flag & 1;
				bool flag4 = obj6 == null;
				object obj7 = !flag4;
				obj5 = obj3;
				flag3 = flag;
				if (obj7 != null)
				{
					goto IL_0096;
				}
			}
			object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj9 = (nint)0 + (nint)2008;
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool biddingPredetermination = Preferences.BiddingPredetermination;
			bool? flag6 = biddingPredetermination;
			flag3 = flag6;
			UnityEngine.Object obj12 = game;
			object obj13 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v13+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			flag = flag3;
			bool flag8 = biddingPredetermination;
			UnityEngine.Object obj15 = game;
			if (obj14 != null)
			{
				goto IL_00e7;
			}
			goto IL_0276;
			IL_02b3:
			if ((object)game != null)
			{
				Room room = game.Room;
				bool flag9 = room == null;
				flag3 = flag;
				if (!flag9)
				{
					if ((object)game == null)
					{
						goto IL_0384;
					}
					Room room2 = game.Room;
					bool flag10 = SFSKammelnaRoomExtensions.IsOffline(room2);
					bool flag11 = !flag10;
					flag3 = flag;
					if (!flag11)
					{
						return false;
					}
				}
				goto IL_0371;
			}
			goto IL_0384;
			IL_00e7:
			bool flag12 = obj12;
			bool flag13 = !flag12;
			object obj16 = !flag13;
			if (obj16 != null)
			{
				goto IL_02b3;
			}
			flag3 = flag;
			goto IL_0371;
			IL_0276:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag14 = obj15;
			bool flag15 = !flag14;
			flag = flag3;
			if (!flag15)
			{
				goto IL_02b3;
			}
			goto IL_0371;
			IL_0371:
			return ((bool?*)flag3)->Value;
			IL_0384:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0096:
			obj13 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v13+E4]");
			bool flag16 = (nint)0 == 0;
			obj12 = game;
			IntPtr intPtr = default(IntPtr);
			flag8 = (byte)(nint)intPtr != 0;
			obj15 = game;
			flag3 = flag;
			if (!flag16)
			{
				goto IL_00e7;
			}
			goto IL_0276;
		}
	}

	protected virtual void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_008b: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 32;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected virtual void GameStateUpdated()
	{
		//IL_00d3: Expected O, but got I4
		//IL_00dc: Expected O, but got I4
		//IL_010c: Expected I, but got O
		//IL_011c: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_00ea: Expected O, but got I4
		//IL_00f3: Expected O, but got I4
		CardGame cardGame = game;
		object obj2;
		object obj3;
		if (cardGame.<Stage>k__BackingField.IsBidding)
		{
			CardGame cardGame2 = game;
			if (Enumerable.Any(cardGame2.<Bidders>k__BackingField))
			{
				bool isReplay = game.IsReplay;
				bool flag = !isReplay;
				object obj = !flag;
				if (obj == null && !game.IsSpectator)
				{
					obj2 = 488;
					obj3 = 496;
					goto IL_0107;
				}
			}
		}
		obj2 = 504;
		obj3 = 512;
		goto IL_0107;
		IL_0107:
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v1 (Il2CppClass<BiddingButtons>)+v67 @ X9_v1]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v1 (Il2CppClass<BiddingButtons>)+v76 @ X8_v5]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v62 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void Clear()
	{
		HideContainer();
		isBidder = false;
		isNaturalFlowDisturbedThisRound = false;
	}

	protected virtual void HideContainer()
	{
		//IL_000c: Expected O, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0030: Expected O, but got I4
		object obj = (nint)0 + (nint)2872;
		object obj2 = this + 64;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateStateButtons();
		int num = ShortcutExtensions.DOKill(biddingBar);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(biddingBar, 0f, 0.5f, snapping: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	protected virtual Button[] getStateButtons()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 1840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Button[] result = default(Button[]);
		return result;
	}

	protected virtual void ShowPredetermineBid()
	{
	}

	protected void ShowBid()
	{
		//IL_000f: Expected I, but got O
		//IL_001f: Expected O, but got I
		//IL_002f: Expected O, but got I
		Button[] stateButtons = getStateButtons();
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X8_v2 (Il2CppClass<BiddingButtons>)+1D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X8_v2 (Il2CppClass<BiddingButtons>)+1E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v32 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void ShowBid(Button[] newStateButtons)
	{
	}

	protected virtual void UpdateShowBid()
	{
	}

	protected virtual void UpdateHideBid()
	{
	}

	protected void onButtonClick(Button button)
	{
		//IL_0108: Expected O, but got I4
		//IL_0111: Expected O, but got I4
		//IL_012b: Expected I, but got O
		//IL_013b: Expected O, but got I
		//IL_014b: Expected O, but got I
		//IL_0096: Expected O, but got I4
		//IL_00ce: Expected O, but got I4
		//IL_00d7: Expected O, but got I4
		CardGame cardGame = game;
		if (cardGame.<Stage>k__BackingField.IsBidding)
		{
			CardGame cardGame2 = game;
			if (Enumerable.Any(cardGame2.<Bidders>k__BackingField))
			{
				bool isSpectator = game.IsSpectator;
				bool flag = !isSpectator;
				object obj = !flag;
				if (obj == null && isBidder)
				{
					object obj2 = 552;
					object obj3 = 560;
					goto IL_0126;
				}
			}
		}
		if (allowBiddingPredetermination)
		{
			object obj2 = 536;
			object obj3 = 544;
			goto IL_0126;
		}
		return;
		IL_0126:
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X10_v1 (Il2CppClass<BiddingButtons>)+v75 @ X9_v1]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X10_v1 (Il2CppClass<BiddingButtons>)+v87 @ X8_v5]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v64 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void SubmitPredetermineBid()
	{
	}

	protected virtual void PredetermineBid(Button button)
	{
	}

	protected virtual void SubmitBid(Button button)
	{
	}

	protected virtual void UpdateStateButtons()
	{
	}

	protected virtual void MitigateMissClicks()
	{
	}
}
