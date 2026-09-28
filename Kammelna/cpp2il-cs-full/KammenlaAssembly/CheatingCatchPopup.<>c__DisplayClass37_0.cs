using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Baloot.Tutorial;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class CheatingCatchPopup : MonoBehaviour
{
	[Serializable]
	private struct CatcherTipBackground
	{
		private Image image;

		private Sprite dark;

		private Sprite green;

		private Sprite red;

		public Image Image => image;

		public void SetDark()
		{
			image.sprite = dark;
		}

		public void SetGreen()
		{
			image.sprite = green;
		}

		public void SetRed()
		{
			image.sprite = red;
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<PlayerCheatingBox> <>9__47_0;

		public static Action<EatingBox> <>9__47_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Clear>b__47_0(PlayerCheatingBox box)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			GameObject gameObject = box.gameObject;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				UnityEngine.Object.Destroy(gameObject);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(gameObject);
		}

		internal void <Clear>b__47_1(EatingBox box)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			GameObject gameObject = box.gameObject;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				UnityEngine.Object.Destroy(gameObject);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	private sealed class <>c__DisplayClass37_0
	{
		public KPlayer catcher;

		public CheatingInfo cheatingInfo;

		internal void <ShowCheatingBoard>b__0(Toggle toggle)
		{
			bool isMe = catcher.IsMe;
			toggle.interactable = isMe;
		}

		internal void <ShowCheatingBoard>b__1(BaseCheatingBox box)
		{
			CheatingInfo cheatingInfo = this.cheatingInfo;
			box.Highlight(cheatingInfo.<WrongCard>k__BackingField, cheatingInfo.<AllowedCard>k__BackingField);
			box.DisableCards();
		}
	}

	private sealed class <>c__DisplayClass37_1
	{
		public List<Card> cheatingCards;

		internal void <ShowCheatingBoard>b__2(BaseCheatingBox box)
		{
			object wrongCard = ((List<object>)(object)cheatingCards).get_Item(0);
			box.Highlight((Card)wrongCard, null);
			box.DisableCards();
		}
	}

	private sealed class <>c__DisplayClass42_0
	{
		public LiveCatchingInfo liveCatchingInfo;

		internal void <OnLiveCatching>b__0(BaseCheatingBox box)
		{
			//IL_003a: Expected O, but got I
			LiveCatchingInfo liveCatchingInfo = this.liveCatchingInfo;
			Card <WrongCard>k__BackingField = liveCatchingInfo.<WrongCard>k__BackingField;
			Card <WrongCard>k__BackingField2 = liveCatchingInfo.<WrongCard>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X8_v2 (Card)+20]");
			box.Highlight(<WrongCard>k__BackingField2, (Card)0);
		}
	}

	private sealed class <ResetScroll>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public CheatingCatchPopup <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <ResetScroll>d__53(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00c2: Expected I4, but got I8
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected O, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_0040: Expected I4, but got I8
			//IL_013a: Expected I4, but got O
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					CheatingCatchPopup cheatingCatchPopup = <>4__this;
					<>1__state = -1;
					if ((object)<>4__this == null || (object)cheatingCatchPopup.panelsScrollView == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					cheatingCatchPopup.panelsScrollView.verticalNormalizedPosition = 1f;
				}
				return <>1__state == 0;
			}
			<>1__state = -1;
			object obj = typeof(UsageHint) + 1632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			WaitForEndOfFrame waitForEndOfFrame = default(WaitForEndOfFrame);
			waitForEndOfFrame..ctor();
			object obj2 = this + 24;
			obj2 = waitForEndOfFrame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<>1__state = 1;
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
			object obj2 = (nint)0 + (nint)3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private PopupUI popup;

	private ScrollRect panelsScrollView;

	private Transform eatingPanel;

	private Transform opponentPanel;

	private Transform myTeamPanel;

	private GameObject catchType;

	private GameObject selectedType;

	private TextMeshProUGUI cheatingSelected;

	private TextMeshProUGUI catcherTip;

	private CatcherTipBackground tipBackground;

	private ToggleGroupIndexer typeButton;

	private GameObject watcherPanel;

	private Image card1;

	private Image card2;

	private TextMeshProUGUI card1Text;

	private TextMeshProUGUI card2Text;

	private Button submitButton;

	private Button closeButton;

	private TextMeshProUGUI nonCatcherLabel;

	private TextMeshProUGUI catcherName;

	private Timer timer;

	private EatingBox eatingBoxPrefab;

	private PlayerCheatingBox cheatingBoxPrefab;

	protected CatchSoundAlbum soundAlbum;

	private CardsSprites cardsSprites;

	private BalootGame game;

	private Card wrongCard;

	private Card allowedCard;

	private List<EatingBox> eatings;

	private List<PlayerCheatingBox> players;

	private string mode;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01de: Expected O, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_01fe: Expected O, but got I
		//IL_0228: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_006e: Expected I, but got O
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0093: Expected O, but got I
		//IL_00bf: Expected I, but got O
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I
		//IL_0110: Expected I, but got O
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0153: Expected O, but got I
		//IL_016b: Expected I, but got O
		//IL_017c: Expected O, but got I
		//IL_0188: Expected O, but got I
		//IL_01bd: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)8;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1408;
		object obj4 = (nint)0 + (nint)488;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		BalootGame balootGame = default(BalootGame);
		game = balootGame;
		object obj7 = this + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)512;
		game.OnCheating += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj9);
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2560;
		object obj11 = (nint)0 + (nint)504;
		game.OnRoundEnd += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj11);
		game.OnLiveCatching += action3;
		ToggleGroupIndexer toggleGroupIndexer = typeButton;
		object obj12 = typeof(TypeConverter<ushort, char>) + 408;
		object obj13 = (nint)0 + (nint)464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<int> unityAction = default(UnityAction<int>);
		unityAction..ctor((object)this, (IntPtr)obj13);
		object obj14 = (nint)0 + (nint)968;
		object obj15 = (nint)0 + (nint)496;
		toggleGroupIndexer.onSelectionChange.AddListener(unityAction);
		Clear();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj15);
		game.OnGameStateUpdated += action4;
	}

	private void OnGameStateUpdated()
	{
		HandleTutorialState();
	}

	private void CatchTypeButtonChanged(int catchType)
	{
		//IL_0081: Expected O, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		object obj;
		string text;
		if (catchType > 0)
		{
			if (catchType != 1)
			{
				if (catchType != 2)
				{
					if (catchType != 3)
					{
						goto IL_0102;
					}
					obj = "getSecondRescanTask" + 2976;
				}
				else
				{
					obj = "tournament_participate_warning_body_with_tickets_warning_daily" + 3328;
				}
			}
			else
			{
				obj = "destinationTimeZone" + 632;
			}
		}
		else
		{
			object obj2 = catchType + 1;
			if (obj2 == null)
			{
				text = null;
				goto IL_01ad;
			}
			bool flag = catchType == 0;
			object obj3 = !flag;
			if (obj3 != null)
			{
				goto IL_0102;
			}
			obj = "com.unity.services.authentication.profile" + 2712;
		}
		text = (string)obj;
		goto IL_01ad;
		IL_0102:
		if (game.IsSun)
		{
			UpdateSubmitButton();
			UpdateCatcherTip();
		}
		UpdateSubmitButton();
		UpdateCatcherTip();
		ISFSObject data = LiveCatchingInfo.SendCheatingData(wrongCard, allowedCard, mode);
		CardGame.SendLiveCatch(data);
		return;
		IL_01ad:
		mode = text;
		object obj4 = this + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0102;
	}

	private string GetCheatMode()
	{
		//IL_03c1: Expected O, but got I4
		//IL_03df: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		//IL_00d3: Expected O, but got I8
		//IL_00ed: Expected O, but got I4
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		uint num = global::<PrivateImplementationDetails>.ComputeStringHash(mode);
		bool flag = (int)num < 2699759368L;
		object obj = !flag;
		bool flag2 = (int)num == 2699759368L;
		object obj2 = !flag2;
		object obj3 = obj & obj2;
		if (obj3 == null)
		{
			if (!flag2)
			{
				switch (num)
				{
				case 2054312555u:
				{
					object obj5 = "utf-32" + 1696;
					if (mode == (string)obj5)
					{
						return "WhiteSmoke" + 488;
					}
					break;
				}
				case 1128467232u:
				{
					object obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 3328;
					if (mode == (string)obj4)
					{
						return "Cannot populate JSON object onto type '{0}'." + 2392;
					}
					break;
				}
				}
			}
			else
			{
				object obj6 = "destinationTimeZone" + 632;
				if (mode == (string)obj6)
				{
					return "Cannot populate JSON object onto type '{0}'." + 2360;
				}
			}
		}
		else
		{
			bool flag3 = (int)num < 3573652457L;
			object obj7 = !flag3;
			object obj8 = (int)num - 3573652457L;
			bool flag4 = obj8 == null;
			object obj9 = !flag4;
			object obj10 = obj7 & obj9;
			if (obj10 == null)
			{
				if ((int)num != 3268139107L)
				{
					if ((int)num == 3573652457L)
					{
						object obj11 = "getSecondRescanTask" + 2976;
						if (mode == (string)obj11)
						{
							return "Cannot populate JSON object onto type '{0}'." + 2368;
						}
					}
				}
				else
				{
					object obj12 = "placementId" + 56;
					if (mode == (string)obj12)
					{
						return "Cannot populate JSON object onto type '{0}'." + 2376;
					}
				}
			}
			else if ((int)num != 4106060478L)
			{
				if ((int)num == 4132842947L)
				{
					object obj13 = "com.unity.services.authentication.profile" + 2712;
					if (mode == (string)obj13)
					{
						return "Cannot populate JSON object onto type '{0}'." + 2352;
					}
				}
			}
			else
			{
				object obj14 = "placementId" + 1224;
				if (mode == (string)obj14)
				{
					return "Cannot populate JSON object onto type '{0}'." + 2384;
				}
			}
		}
		return (string)(this + 296);
	}

	private void OnCheating(CheatingInfo cheatingInfo)
	{
		if (!cheatingInfo.IsWrongSawa)
		{
			if (game.IsSun)
			{
				typeButton.SelectedIndex = 0;
				typeButton.SetIsOnWithoutNotify(0);
				CatchTypeButtonChanged(0);
			}
			string cheatMode = GetCheatMode();
			UpdateSelectedCatch(cheatMode);
			UpdateTopBar(cheatingInfo);
			ShowCheatingBoard(cheatingInfo);
		}
	}

	private void OnRoundEnd()
	{
		popup.ShrinkToParent();
		Clear();
	}

	private void ShowCheatingBoard(CheatingInfo cheatingInfo)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_007f: Expected O, but got I
		//IL_009a: Expected O, but got I
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00d8: Expected O, but got I
		//IL_017d: Expected O, but got I4
		//IL_011c: Expected O, but got I4
		//IL_0290: Expected O, but got I
		//IL_02b2: Expected O, but got I4
		//IL_0208: Expected O, but got I
		//IL_0229: Expected O, but got I
		//IL_0418: Expected O, but got I
		//IL_09fb: Expected I, but got O
		//IL_061c: Expected O, but got I
		//IL_063e: Expected O, but got I4
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_0321: Expected O, but got I
		//IL_0594: Expected O, but got I
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_05b5: Expected O, but got I
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_0683: Expected O, but got I
		//IL_09be: Expected O, but got I
		//IL_03ca: Expected O, but got I
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_03ff: Expected O, but got I
		//IL_06da: Expected O, but got I4
		//IL_0a29: Expected O, but got I
		//IL_06cc: Expected O, but got I4
		//IL_06eb: Expected O, but got I
		//IL_0718: Expected O, but got I
		//IL_053e: Expected F4, but got I
		//IL_077f: Expected O, but got I
		//IL_078d: Expected I, but got O
		//IL_084b: Expected O, but got I4
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Expected O, but got Unknown
		//IL_0892: Expected O, but got I
		//IL_08a3: Expected I, but got O
		//IL_0940: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = cheatingInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		popup.PopFromCenter();
		UpdateSubmitButton();
		object obj4 = obj3;
		object obj5 = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v4+28]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = (nint)0 + (nint)2984;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1256;
		object obj8 = (nint)0 + (nint)448;
		object obj9 = (nint)0 + (nint)456;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X22_v4+8]");
		string nickName;
		User user;
		bool flag4;
		bool isSubscribed;
		bool isVerified;
		if (((CheatingInfo)0).IsFirstPhase)
		{
			bool isWrongEkka = ((CheatingInfo)obj3).IsWrongEkka;
			bool flag = !isWrongEkka;
			object obj10 = !flag;
			if (obj10 == null && !game.IsReplay)
			{
				nickName = ((KPlayer)obj5).NickName;
				object obj11 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v26+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v26+18]");
					bool flag2 = SFSKammelnaUserExtensions.IsSubscribed((User)0);
					object obj12 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v53+18]");
					user = (User)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v53+18]");
					bool flag3 = (nint)0 == 0;
					flag4 = flag2;
					isSubscribed = flag2;
					if (!flag3)
					{
						goto IL_05ea;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v26+18]");
					user = (User)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v26+18]");
					bool flag5 = (nint)0 == 0;
					object obj13 = !flag5;
					flag4 = false;
					isSubscribed = false;
					if (obj13 != null)
					{
						goto IL_05ea;
					}
				}
				isVerified = false;
				goto IL_0a00;
			}
		}
		bool isWrongEkka2 = ((CheatingInfo)obj3).IsWrongEkka;
		bool flag6 = !isWrongEkka2;
		object obj14 = !flag6;
		if (obj14 == null && !game.IsReplay)
		{
			goto IL_096d;
		}
		string nickName2 = ((KPlayer)obj5).NickName;
		object obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v17+18]");
		User user2;
		bool flag9;
		bool isSubscribed2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v17+18]");
			bool flag7 = SFSKammelnaUserExtensions.IsSubscribed((User)0);
			object obj16 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v25+18]");
			user2 = (User)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v25+18]");
			bool flag8 = (nint)0 == 0;
			flag9 = flag7;
			isSubscribed2 = flag7;
			if (!flag8)
			{
				goto IL_025e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v17+18]");
			user2 = (User)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v17+18]");
			bool flag10 = (nint)0 == 0;
			object obj17 = !flag10;
			flag9 = false;
			isSubscribed2 = false;
			if (obj17 != null)
			{
				goto IL_025e;
			}
		}
		bool isVerified2 = false;
		goto IL_0981;
		IL_0a00:
		TextMeshProExtensions.SetUsername(catcherName, nickName, isSubscribed, isVerified);
		CatcherTipBackground catcherTipBackground = tipBackground;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CheatingCatchPopup)+70]");
		((Image)catcherTipBackground).sprite = (Sprite)0;
		UpdateCatcherTip();
		object obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v28+44]");
		if ((nint)0 < (nint)31)
		{
			object obj19 = 3;
		}
		else
		{
			object obj19 = 2;
		}
		object obj20 = (nint)0 + (nint)2392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		object obj21 = obj3;
		object obj22 = (nint)0 + (nint)448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D21984");
		object obj23 = obj3;
		Transform transform = opponentPanel;
		object obj24 = (nint)0 + (nint)456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D21984");
		if (game.IsTutorial)
		{
			IEnumerable<object> enumeration = Enumerable.Union((IEnumerable<object>)eatings, (IEnumerable<object>)players);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)472;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj25);
			ArraysExtensions.ForEach(enumeration, action);
			transform = null;
		}
		GameObject gameObject = ((Component)tipBackground).gameObject;
		bool isMe = ((KPlayer)obj5).IsMe;
		gameObject.SetActive(isMe);
		GameObject gameObject2 = nonCatcherLabel.gameObject;
		bool isMe2 = ((KPlayer)obj5).IsMe;
		bool active = (byte)((isMe2 ? 1u : 0u) ^ 1u) != 0;
		gameObject2.SetActive(active);
		bool isTutorial = game.IsTutorial;
		bool flag11 = !isTutorial;
		object obj26 = !flag11;
		if (obj26 == null)
		{
			ToggleGroupIndexer toggleGroupIndexer = typeButton;
			object obj27 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3720;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj28 = (nint)0 + (nint)3264;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj2, (IntPtr)obj28);
			ArraysExtensions.ForEach(toggleGroupIndexer.Toggles, action2);
		}
		GameObject gameObject3 = submitButton.gameObject;
		bool isMe3 = ((KPlayer)obj5).IsMe;
		gameObject3.SetActive(isMe3);
		GameObject gameObject4 = closeButton.gameObject;
		gameObject4.SetActive(value: false);
		Timer timer = this.timer;
		bool flag12 = (object)this.timer == null;
		object obj29 = !flag12;
		if (obj29 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0511;
		IL_096d:
		SoundChannel.StopSound();
		ShowCheatingResult((CheatingInfo)obj3);
		object obj37;
		object obj38;
		if (game.IsTutorial && ((CheatingInfo)obj3).IsWrongEkka)
		{
			object obj30 = typeof(CardUtils.<>c) + 416;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj31 = default(object);
			obj31..ctor();
			object obj32 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			object obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X8_v13+B8]");
			object obj34 = 0;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v15+D8]");
			List<Card> list = CardDataExtension.ToCards((List<CardData>)0);
			object obj36 = obj31 + 16;
			obj36 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj37 = (nint)0 + (nint)3280;
			obj38 = obj31;
		}
		else
		{
			obj37 = (nint)0 + (nint)3272;
			obj38 = obj2;
		}
		IEnumerable<object> enumeration2 = Enumerable.Union((IEnumerable<object>)eatings, (IEnumerable<object>)players);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj38, (IntPtr)obj37);
		ArraysExtensions.ForEach(enumeration2, action3);
		GameObject gameObject5 = ((Component)tipBackground).gameObject;
		gameObject5.SetActive(value: true);
		GameObject gameObject6 = nonCatcherLabel.gameObject;
		bool isSpectator = game.IsSpectator;
		gameObject6.SetActive(isSpectator);
		GameObject gameObject7 = submitButton.gameObject;
		gameObject7.SetActive(value: false);
		GameObject gameObject8 = closeButton.gameObject;
		bool isSpectator2 = game.IsSpectator;
		bool active2 = (byte)((isSpectator2 ? 1u : 0u) ^ 1u) != 0;
		gameObject8.SetActive(active2);
		timer = this.timer;
		goto IL_0511;
		IL_0981:
		TextMeshProExtensions.SetUsername(catcherName, nickName2, isSubscribed2, isVerified2);
		object obj39 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D21984");
		object obj40 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D21984");
		obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1256;
		obj6 = (nint)0 + (nint)2984;
		goto IL_096d;
		IL_05ea:
		bool flag13 = SFSKammelnaUserExtensions.IsVerified(user);
		isVerified = flag13;
		isSubscribed = flag4;
		goto IL_0a00;
		IL_025e:
		bool flag14 = SFSKammelnaUserExtensions.IsVerified(user2);
		isVerified2 = flag14;
		isSubscribed2 = flag9;
		goto IL_0981;
		IL_0511:
		timer.Hide();
		object obj41 = obj3;
		Timer obj42 = this.timer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v6+44]");
		obj42.StartTimer(0f);
	}

	private unsafe void InitializeCheatingBoxes<T>(T boxPrefab, Transform catcherTeamPanel, Transform otherTeamPanel, KPlayer currentCatcher, List<List<Card>> cardsList, List<T> boxesList, bool dimCatcherTeam) where T : BaseCheatingBox
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_003a: Expected O, but got I4
		//IL_006a: Expected O, but got I4
		//IL_0453: Expected O, but got I4
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_04d3: Expected O, but got I4
		//IL_0220: Expected O, but got I
		//IL_0266: Expected I, but got O
		//IL_0276: Expected O, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02b9: Expected O, but got I
		//IL_02c7: Expected I, but got O
		//IL_0367: Expected O, but got I4
		//IL_0136: Expected O, but got I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03e7: Expected O, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X27_v1+38]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X27_v1+38]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			}
		}
		CardGame cardGame;
		if (cardsList != null)
		{
			if (currentCatcher != null)
			{
				if (cardsList._size < 1)
				{
					return;
				}
				KPlayer kPlayer = currentCatcher;
				List<List<Card>> list = cardsList;
				Transform transform = otherTeamPanel;
				int num = 0;
				BaseCheatingBox baseCheatingBox = default(BaseCheatingBox);
				Action<object> action = default(Action<object>);
				while ((object)game != null)
				{
					int num2 = num + 1;
					int playerTeam = game.GetPlayerTeam(num2);
					if ((object)game == null)
					{
						break;
					}
					int playerTeam2 = game.GetPlayerTeam(currentCatcher.<Index>k__BackingField);
					if (playerTeam == playerTeam2)
					{
						Transform transform2 = catcherTeamPanel;
					}
					else
					{
						Transform transform2 = otherTeamPanel;
					}
					object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v14+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X27_v1+38]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
					object chCards = ((List<object>)(object)cardsList).get_Item(num);
					if ((object)baseCheatingBox == null)
					{
						break;
					}
					nint num3 = (nint)baseCheatingBox;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v15 (Il2CppClass<BaseCheatingBox>)+190]");
					list = (List<List<Card>>)0;
					baseCheatingBox.Populate(num2, (List<Card>)chCards, currentCatcher, dimCatcherTeam);
					object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1400;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj11 = (nint)0 + (nint)480;
					action..ctor((object)this, (IntPtr)obj11);
					baseCheatingBox.OnCardClicked += action;
					if (boxesList == null)
					{
						break;
					}
					int version = boxesList._version + 1;
					boxesList._version = version;
					T[] items = boxesList._items;
					if (boxesList._items == null)
					{
						break;
					}
					bool flag4 = boxesList._size < items.Length;
					object obj12 = !flag4;
					if (obj12 != null)
					{
						((List<object>)(object)boxesList).AddWithResize((object)baseCheatingBox);
						bool flag5 = num2 >= cardsList._size;
						kPlayer = (KPlayer)dimCatcherTeam;
						transform = null;
						num = num2;
						if (flag5)
						{
							return;
						}
						continue;
					}
					int size = boxesList._size + 1;
					boxesList._size = size;
					object obj13 = boxesList._items + boxesList._size;
					object obj14 = obj13 + 32;
					obj14 = baseCheatingBox;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag6 = num2 < cardsList._size;
					kPlayer = (KPlayer)dimCatcherTeam;
					transform = null;
					num = num2;
					if (!flag6)
					{
						return;
					}
				}
			}
			else
			{
				if (cardsList._size < 1)
				{
					return;
				}
				cardGame = game;
				bool flag7 = (object)game == null;
				object obj15 = !flag7;
				if (obj15 != null)
				{
					goto IL_0477;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		cardGame = (CardGame)(object)ex;
		goto IL_0477;
		IL_0477:
		int playerTeam3 = cardGame.GetPlayerTeam(1);
		throw new NullReferenceException();
	}

	private void ShowCheatingResult(CheatingInfo cheatingInfo)
	{
		//IL_008d: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_00bd: Expected O, but got I4
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_02f9: Expected O, but got I
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_0165: Expected O, but got I
		//IL_0187: Expected O, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_011b: Expected O, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0226: Expected O, but got I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0356: Expected O, but got I4
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_037c: Expected O, but got I
		//IL_03b8: Expected O, but got I4
		typeButton.DisableToggles();
		SetAsResult();
		Image image;
		if (cheatingInfo.<Correct>k__BackingField)
		{
			object obj = (nint)0 + (nint)2392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound singleSound = default(SingleSound);
			SoundChannel.PlaySFXSound(singleSound);
			image = (Image)tipBackground;
			object obj2 = 120;
		}
		else
		{
			object obj3 = (nint)0 + (nint)2392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound singleSound2 = default(SingleSound);
			SoundChannel.PlaySFXSound(singleSound2);
			image = (Image)tipBackground;
			object obj2 = 128;
		}
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Image image2 = image;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CheatingCatchPopup)+v213 @ X8_v5]");
		image2.sprite = (Sprite)0;
		mode = cheatingInfo.<CatchCheatMode>k__BackingField;
		object obj5 = this + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string cheatMode = GetCheatMode();
		UpdateSelectedCatch(cheatMode);
		object obj6 = obj4;
		string text;
		if (cheatingInfo.<NoCheatings>k__BackingField)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object input = "Network Authentication Required" + 1312;
			text = LocalizationUtil.Localize((string)input);
		}
		else
		{
			object obj8 = (nint)0 + (nint)2000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object input2 = "Cannot populate JSON object onto type '{0}'." + 1864;
			string text2 = LocalizationUtil.Localize((string)input2);
			object obj10 = "1.2.840.113549.1.12.1.5" + 1504;
			string text3 = (string)obj8 + text2 + (string)obj10;
			object input3 = "Complete" + 1736;
			object obj11 = "WhiteSmoke" + 472;
			bool flag3 = !cheatingInfo.<Correct>k__BackingField;
			object obj12 = !flag3;
			object obj13 = ~obj12;
			if (obj13 != null)
			{
				input3 = obj11;
			}
			object obj14 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v24+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text4 = LocalizationUtil.Localize((string)input3);
			text = text3 + text4;
		}
		catcherTip.alignment = TextAlignmentOptions.Center;
		TextMeshProExtensions.FixArabic(catcherTip, text);
		RectTransform rectTransform = catcherTip.rectTransform;
		int num = ShortcutExtensions.DOKill(rectTransform, complete: true);
		RectTransform rectTransform2 = catcherTip.rectTransform;
		object obj16 = typeof(UsageHint) + 744;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v10+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v11+8]");
		object obj19 = default(object);
		float duration = 0f * (float)obj19;
		float elasticity = default(float);
		Tweener tweener = ShortcutExtensions.DOPunchScale(rectTransform2, (Vector3)10, duration, 0, elasticity);
	}

	private void UpdateSubmitButton()
	{
		//IL_005c: Expected O, but got I4
		//IL_012a: Expected O, but got I
		//IL_0140: Expected O, but got I
		bool interactable;
		if (wrongCard != null && allowedCard != null)
		{
			bool flag = mode == null;
			bool flag2 = !flag;
			bool flag3 = (object)submitButton == null;
			object obj = !flag3;
			interactable = flag2;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			interactable = false;
		}
		submitButton.interactable = interactable;
		Component component = submitButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v5 (UnityEngine.Component)+D8]");
		if ((nint)0 == 1)
		{
			Transform target = component.transform;
			int num = ShortcutExtensions.DOKill(target, complete: true);
			Transform target2 = submitButton.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target2, 0.8f, 0.5f);
			object obj2 = (nint)0 + (nint)2440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
			object obj3 = (nint)0 + (nint)2904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		}
	}

	private void OnCardClicked(CheatingCard target)
	{
		//IL_004c: Expected I, but got O
		//IL_001f: Expected O, but got I4
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0274: Expected O, but got I4
		//IL_0096: Expected I, but got O
		//IL_02dd: Expected O, but got I
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_010a: Expected O, but got I4
		//IL_0151: Expected I, but got O
		//IL_01fb: Expected O, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		CatchSoundAlbum catchSoundAlbum;
		if (wrongCard != null)
		{
			bool flag = (object)target == null;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_007c;
			}
		}
		else
		{
			Card card = target.card;
			nint num = (nint)card;
			if (card.Equals(allowedCard))
			{
				goto IL_007c;
			}
			wrongCard = target.card;
			object obj2 = this + 264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			target.filter.sprite = target.red;
			catchSoundAlbum = soundAlbum;
			bool flag2 = (object)soundAlbum == null;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_02d1;
			}
		}
		goto IL_0331;
		IL_0331:
		throw new NullReferenceException();
		IL_02d1:
		object obj4 = (nint)0 + (nint)2392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		UpdateSubmitButton();
		UpdateCatcherTip();
		ISFSObject data = LiveCatchingInfo.SendCheatingData(wrongCard, allowedCard, mode);
		CardGame.SendLiveCatch(data);
		return;
		IL_007c:
		Card card2 = target.card;
		nint num2 = (nint)card2;
		Image filter;
		if (card2.Equals(wrongCard))
		{
			wrongCard = null;
			object obj5 = this + 264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			filter = target.filter;
			bool flag3 = (object)target.filter == null;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				goto IL_0331;
			}
		}
		else
		{
			Card card3 = target.card;
			if (allowedCard == null)
			{
				allowedCard = card3;
				object obj7 = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				target.filter.sprite = target.green;
				catchSoundAlbum = soundAlbum;
				goto IL_02d1;
			}
			nint num3 = (nint)card3;
			if (!card3.Equals(allowedCard))
			{
				return;
			}
			allowedCard = null;
			object obj8 = this + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			filter = target.filter;
		}
		filter.sprite = target.none;
		target.button.interactable = true;
		catchSoundAlbum = soundAlbum;
		bool flag4 = (object)soundAlbum == null;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_02d1;
		}
		goto IL_0331;
	}

	private void OnLiveCatching(LiveCatchingInfo liveCatchingInfo)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0058: Expected O, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_008c: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_0119: Expected O, but got I
		//IL_0132: Expected O, but got I
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0152: Expected O, but got I
		//IL_0171: Expected O, but got I
		//IL_01a6: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = liveCatchingInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v4+18]");
		wrongCard = (Card)0;
		object obj5 = this + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v5+20]");
		allowedCard = (Card)0;
		object obj7 = this + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v6+10]");
		mode = (string)0;
		object obj9 = this + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string cheatMode = GetCheatMode();
		UpdateSelectedCatch(cheatMode);
		object obj10 = obj3;
		TextMeshProUGUI text = card1Text;
		Image card = card1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+18]");
		WatchersCards(text, card, (Card)0);
		object obj11 = obj3;
		object obj12 = (nint)0 + (nint)2984;
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1256;
		object obj14 = (nint)0 + (nint)3288;
		TextMeshProUGUI text2 = card2Text;
		Image card2 = this.card2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v8+20]");
		WatchersCards(text2, card2, (Card)0);
		IEnumerable<object> enumeration = Enumerable.Union((IEnumerable<object>)eatings, (IEnumerable<object>)players);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj14);
		ArraysExtensions.ForEach(enumeration, action);
	}

	private void SendLiveCatchingData()
	{
		UpdateSubmitButton();
		UpdateCatcherTip();
		ISFSObject data = LiveCatchingInfo.SendCheatingData(wrongCard, allowedCard, mode);
		CardGame.SendLiveCatch(data);
	}

	private void UpdateSelectedCatch(string cheatMode)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01bf: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01fd: Expected O, but got I4
		//IL_00fe: Expected O, but got I4
		//IL_0107: Expected O, but got I4
		//IL_00ad: Expected O, but got I4
		//IL_0129: Expected O, but got I
		//IL_0153: Expected O, but got I4
		object obj = (nint)0 + (nint)2000;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object input = "Cannot populate JSON object onto type '{0}'." + 1856;
		object obj3 = (nint)0 + (nint)3688;
		object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationUtil.Localize((string)input);
		string text2 = (string)obj + text + (string)obj3;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v8+E4]");
		string text3;
		if ((nint)0 != 0)
		{
			bool flag2 = StringsExtensions.IsNullOrEmpty(cheatMode);
			bool flag3 = !flag2;
			object obj8 = 0;
			if (flag3)
			{
				goto IL_011d;
			}
			text3 = text2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = StringsExtensions.IsNullOrEmpty(cheatMode);
			bool flag5 = !flag4;
			object obj9 = !flag5;
			object obj8 = 0;
			text3 = text2;
			if (obj9 == null)
			{
				goto IL_011d;
			}
		}
		goto IL_020b;
		IL_011d:
		object obj10 = (nint)0 + (nint)3072;
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v12+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text4 = LocalizationUtil.Localize(cheatMode);
		string text5 = text2 + text4 + (string)obj10;
		text3 = text5;
		goto IL_020b;
		IL_020b:
		TextMeshProExtensions.FixArabic(cheatingSelected, text3);
	}

	private void UpdateCatcherTip()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_07e2: Expected O, but got I
		//IL_081e: Expected O, but got I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0123: Expected O, but got I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_04fc: Expected O, but got I4
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Expected O, but got Unknown
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected O, but got Unknown
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected O, but got Unknown
		//IL_0773: Expected O, but got I4
		//IL_0545: Expected O, but got I
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected O, but got Unknown
		//IL_01d3: Expected O, but got I4
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected O, but got Unknown
		//IL_05ac: Expected O, but got I4
		//IL_05c2: Expected O, but got I
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected O, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected O, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected O, but got Unknown
		//IL_066b: Expected O, but got I4
		//IL_0681: Expected O, but got I
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected O, but got Unknown
		//IL_0274: Expected O, but got I
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02db: Expected O, but got I4
		//IL_02f1: Expected O, but got I
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected O, but got Unknown
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_039a: Expected O, but got I4
		//IL_03b0: Expected O, but got I
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_0496: Expected O, but got I4
		string text2;
		string input4;
		object obj33;
		object obj36;
		string text7;
		if ((object)catcherTip != null)
		{
			catcherTip.isRightToLeftText = true;
			if ((object)catcherTip != null)
			{
				RectTransform rectTransform = catcherTip.rectTransform;
				int num = ShortcutExtensions.DOKill(rectTransform, complete: true);
				if ((object)catcherTip != null)
				{
					RectTransform rectTransform2 = catcherTip.rectTransform;
					object obj = typeof(UsageHint) + 744;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v7+B8]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v8+8]");
					object obj4 = default(object);
					float duration = 0f * (float)obj4;
					float elasticity = default(float);
					Tweener tweener = ShortcutExtensions.DOPunchScale(rectTransform2, (Vector3)10, duration, 0, elasticity);
					Button button = submitButton;
					if ((object)submitButton != null)
					{
						if (((Selectable)button).m_Interactable)
						{
							object text = "Cannot populate JSON object onto type '{0}'." + 1848;
							TextMeshProExtensions.Localize(catcherTip, (string)text);
							return;
						}
						object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v14+E4]");
						bool flag = (nint)0 == 0;
						object obj7 = !flag;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object input = "Cannot populate JSON object onto type '{0}'." + 2680;
						text2 = LocalizationUtil.Localize((string)input);
						object obj8 = "placementId" + 2688;
						if (wrongCard != null)
						{
							if (allowedCard != null)
							{
								object obj9 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v44+E4]");
								bool flag2 = (nint)0 == 0;
								object obj10 = !flag2;
								if (obj10 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object input2 = "Cannot populate JSON object onto type '{0}'." + 2656;
								string text3 = LocalizationUtil.Localize((string)input2);
								object input3 = "Cannot populate JSON object onto type '{0}'." + 1856;
								string text4 = LocalizationUtil.Localize((string)input3);
								object obj11 = typeof(SqlSingle[]) + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
								string[] array = default(string[]);
								if (array == null)
								{
									goto IL_0796;
								}
								object obj12 = (nint)0 + (nint)3728;
								object obj13 = array + 32;
								obj13 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj14 = array + 40;
								obj14 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X24_v10-10]");
								bool flag3 = (nint)0 < (nint)2;
								object obj15 = !flag3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X24_v10-10]");
								object obj16 = -2;
								bool flag4 = obj16 == null;
								object obj17 = ~obj15;
								object obj18 = obj17 | flag4;
								if (obj18 == null)
								{
									object obj19 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2800;
									object obj20 = array + 48;
									obj20 = obj19;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object obj21 = array + 56;
									obj21 = text4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X23_v16-20]");
									bool flag5 = (nint)0 < (nint)4;
									object obj22 = !flag5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X23_v16-20]");
									object obj23 = -4;
									bool flag6 = obj23 == null;
									object obj24 = ~obj22;
									object obj25 = obj24 | flag6;
									if (obj25 == null)
									{
										object obj26 = "1.2.840.113549.1.12.1.5" + 2440;
										object obj27 = array + 64;
										obj27 = obj26;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										string text5 = string.Concat(array);
										string text6 = text3 + text5;
										TextMeshProExtensions.FixArabic(catcherTip, text6);
										RectTransform rect = UIExtensions.rectTransform(typeButton);
										object obj28 = typeof(SqlSingle[]) + 3912;
										object obj29 = obj28;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v59+E4]");
										bool flag7 = (nint)0 == 0;
										object obj30 = !flag7;
										if (obj30 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										AnimationExtensions.ErrorFeedback(rect);
										return;
									}
								}
								goto IL_07a4;
							}
							object obj31 = "https://www.kammelna.com/Home/Terms" + 2400;
							object obj32 = "getSecondRescanTask" + 1952;
							input4 = (string)obj31;
							obj33 = obj32;
							object obj34 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v31+E4]");
							bool flag8 = (nint)0 == 0;
							object obj35 = !flag8;
							if (obj35 == null)
							{
								obj36 = obj32;
								text7 = (string)obj31;
								goto IL_051a;
							}
						}
						else
						{
							object obj37 = "https://www.kammelna.com/Home/Terms" + 2416;
							text7 = (string)obj37;
							obj36 = obj8;
							object obj34 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v31+E4]");
							bool flag9 = (nint)0 == 0;
							object obj38 = !flag9;
							obj33 = obj8;
							input4 = (string)obj37;
							if (obj38 == null)
							{
								goto IL_051a;
							}
						}
						goto IL_0867;
					}
				}
			}
		}
		goto IL_0796;
		IL_0867:
		string text8 = LocalizationUtil.Localize(input4);
		object obj39 = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array2 = default(string[]);
		if (array2 == null)
		{
			goto IL_0796;
		}
		object obj40 = (nint)0 + (nint)3728;
		object obj41 = array2 + 32;
		obj41 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj42 = array2 + 40;
		obj42 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X24_v5-10]");
		bool flag10 = (nint)0 < (nint)2;
		object obj43 = !flag10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X24_v5-10]");
		object obj44 = -2;
		bool flag11 = obj44 == null;
		object obj45 = ~obj43;
		object obj46 = obj45 | flag11;
		if (obj46 == null)
		{
			object obj47 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2800;
			object obj48 = array2 + 48;
			obj48 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj49 = array2 + 56;
			obj49 = text8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X23_v7-20]");
			bool flag12 = (nint)0 < (nint)4;
			object obj50 = !flag12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X23_v7-20]");
			object obj51 = -4;
			bool flag13 = obj51 == null;
			object obj52 = ~obj50;
			object obj53 = obj52 | flag13;
			if (obj53 == null)
			{
				object obj54 = "1.2.840.113549.1.12.1.5" + 2440;
				object obj55 = array2 + 64;
				obj55 = obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				string text9 = string.Concat(array2);
				string text10 = text2 + text9;
				TextMeshProExtensions.FixArabic(catcherTip, text10);
				return;
			}
		}
		goto IL_07a4;
		IL_051a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj33 = obj36;
		input4 = text7;
		goto IL_0867;
		IL_0796:
		NullReferenceException ex = new NullReferenceException();
		goto IL_07a4;
		IL_07a4:
		throw new IndexOutOfRangeException();
	}

	private void HideCheatingBoard()
	{
		popup.ShrinkToParent();
		Clear();
	}

	private void Clear()
	{
		//IL_0019: Expected I4, but got I8
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0100: Expected O, but got I
		//IL_0110: Expected O, but got I
		//IL_0132: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_007a: Expected O, but got I
		//IL_008a: Expected O, but got I
		//IL_01b9: Expected O, but got I
		//IL_0162: Expected O, but got I4
		//IL_028b: Expected O, but got I
		//IL_029b: Expected O, but got I
		//IL_02bd: Expected O, but got I4
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_0539: Expected O, but got I
		//IL_054a: Expected I, but got O
		//IL_0568: Expected O, but got I
		//IL_0256: Expected O, but got I4
		//IL_0205: Expected O, but got I
		//IL_0215: Expected O, but got I
		//IL_01a0: Expected O, but got I4
		//IL_0192: Expected O, but got I
		//IL_02ed: Expected O, but got I4
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected O, but got Unknown
		//IL_05a9: Expected O, but got I
		//IL_05ba: Expected I, but got O
		//IL_05d8: Expected O, but got I
		//IL_032b: Expected O, but got I4
		//IL_031d: Expected O, but got I
		//IL_0420: Expected O, but got I4
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected O, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected O, but got Unknown
		//IL_04a9: Expected O, but got I4
		typeButton.SetIsOnWithoutNotify(-1);
		object obj = typeof(CardUtils.<>c) + 400;
		popup.ShrinkToParent();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v37+E4]");
		object obj3;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v37+B8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v27+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v27+8]");
			if ((nint)0 != 0)
			{
				goto IL_00af;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v37+B8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v27+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v27+8]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_00af;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v37+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v33+B8]");
			obj3 = 0;
		}
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)3248;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj3, (IntPtr)obj8);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v32+B8]");
		object obj10 = (nint)0 + (nint)8;
		obj10 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = 0;
		action = action2;
		goto IL_01ad;
		IL_023a:
		bool flag3 = eatings == null;
		object obj12 = !flag3;
		if (obj12 != null)
		{
			goto IL_0338;
		}
		goto IL_0508;
		IL_01ad:
		object obj13 = (nint)0 + (nint)1888;
		((List<object>)(object)players).ForEach(action);
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v26+E4]");
		object obj15;
		Action<object> action3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v26+B8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v15+10]");
			action3 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v15+10]");
			if ((nint)0 != 0)
			{
				goto IL_023a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v26+B8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v15+10]");
			action3 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v15+10]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			if (obj16 != null)
			{
				goto IL_023a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v26+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v21+B8]");
			obj15 = 0;
		}
		object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)3256;
		Action<object> action4 = default(Action<object>);
		action4..ctor(obj15, (IntPtr)obj20);
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v20+B8]");
		object obj22 = (nint)0 + (nint)16;
		obj22 = action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = 0;
		action3 = action4;
		goto IL_0338;
		IL_00af:
		bool flag6 = players == null;
		object obj23 = !flag6;
		if (obj23 != null)
		{
			goto IL_01ad;
		}
		goto IL_0508;
		IL_0508:
		throw new NullReferenceException();
		IL_0338:
		((List<object>)(object)eatings).ForEach(action3);
		card1.enabled = false;
		card2.enabled = false;
		card1Text.enabled = true;
		card2Text.enabled = true;
		List<PlayerCheatingBox> list = players;
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		if (list._size >= 1)
		{
			Array.Clear(list._items, 0, list._size);
			obj11 = 0;
		}
		List<EatingBox> list2 = eatings;
		int version2 = list2._version + 1;
		list2._size = 0;
		list2._version = version2;
		if (list2._size >= 1)
		{
			Array.Clear(list2._items, 0, list2._size);
			obj11 = 0;
		}
		wrongCard = null;
		object obj24 = this + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		allowedCard = null;
		object obj25 = this + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		mode = null;
		object obj26 = this + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Submit()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object action = "Cannot populate JSON object onto type '{0}'." + 1872;
		ISFSObject data = CheatingInfo.CreateCheatingData(wrongCard, allowedCard, mode);
		FirebaseTrack.Event((string)action, mode);
		game.SendCatchDetails(data);
	}

	public void Close()
	{
		game.SendCatchClose();
		popup.ShrinkToParent();
		Clear();
	}

	private void HighlightTutorialCards(BaseCheatingBox cheatingBox)
	{
		//IL_0016: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_016b: Expected O, but got I
		//IL_014d: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6693]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A5]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A5]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v7+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		goto IL_015a;
		IL_015a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v3+D8]");
		List<Card> list = CardDataExtension.ToCards((List<CardData>)0);
		if (list._size >= 1)
		{
			cheatingBox.HighlightTutorialCheatingCards(list);
		}
		return;
		IL_0082:
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v13+B8]");
		object obj11 = 0;
		obj9 = obj11;
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_015a;
	}

	private void UpdateTopBar(CheatingInfo cheatingInfo)
	{
		if (!cheatingInfo.IsFirstPhase || game.IsReplay)
		{
			SetAsResult();
		}
		else if (cheatingInfo.<CurrentCatcher>k__BackingField.IsMe)
		{
			if (game.IsSun)
			{
				SetAsSun();
			}
			else
			{
				SetAsHokom();
			}
		}
		else
		{
			SetAsWatcher();
		}
	}

	private void ResetView()
	{
		watcherPanel.SetActive(value: false);
		selectedType.SetActive(value: false);
		catchType.SetActive(value: false);
		GameObject gameObject = typeButton.gameObject;
		gameObject.SetActive(value: false);
	}

	private IEnumerator ResetScroll()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private void WatchersCards(TextMeshProUGUI text, Image card, Card set)
	{
		if (set != null)
		{
			text.enabled = false;
			card.enabled = true;
			Sprite sprite = cardsSprites.GetFor(set);
			card.sprite = sprite;
		}
		else
		{
			text.enabled = true;
			card.enabled = false;
		}
	}

	private void SetAsWatcher()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		ResetView();
		watcherPanel.SetActive(value: true);
		selectedType.SetActive(value: true);
		object obj = typeof(CardUtils.<>c) + 432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
	}

	private void SetAsResult()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		ResetView();
		selectedType.SetActive(value: true);
		object obj = typeof(CardUtils.<>c) + 432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
	}

	private void SetAsSun()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		ResetView();
		selectedType.SetActive(value: true);
		object obj = typeof(CardUtils.<>c) + 432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
	}

	private void SetAsHokom()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		ResetView();
		catchType.SetActive(value: true);
		GameObject gameObject = typeButton.gameObject;
		gameObject.SetActive(value: true);
		object obj = typeof(CardUtils.<>c) + 432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
	}

	private void HandleTutorialState()
	{
		//IL_0160: Expected O, but got I4
		//IL_017a: Expected O, but got I4
		//IL_019f: Expected O, but got I4
		//IL_01f6: Expected O, but got I4
		//IL_0238: Expected O, but got I4
		//IL_0248: Expected O, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_02b0: Expected O, but got I4
		//IL_0310: Expected O, but got I4
		if ((object)game != null)
		{
			if (!game.IsTutorial)
			{
				return;
			}
			if ((object)game != null)
			{
				if (game.IsSun)
				{
					return;
				}
				if ((object)game != null)
				{
					Room room = game.Room;
					TutorialType tutorialType = SFSKammelnaRoomExtensions.GetTutorialType(room);
					ToggleGroupIndexer toggleGroupIndexer = typeButton;
					if ((object)typeButton != null)
					{
						Toggle[] toggles = toggleGroupIndexer.Toggles;
						if (toggleGroupIndexer.Toggles != null && (object)toggles[0] != null)
						{
							object obj = tutorialType - 10;
							bool flag = obj == null;
							object obj2 = !flag;
							object obj3 = ~obj2;
							bool interactable;
							if (obj3 == null)
							{
								object obj4 = tutorialType - 6;
								interactable = obj4 == null;
							}
							else
							{
								interactable = true;
							}
							toggles[0].interactable = interactable;
							if ((object)toggles[1] != null)
							{
								object obj5 = tutorialType - 7;
								bool interactable2 = obj5 == null;
								toggles[1].interactable = interactable2;
								bool flag2 = toggles.Length < 2;
								object obj6 = !flag2;
								object obj7 = toggles.Length - 2;
								bool flag3 = obj7 == null;
								object obj8 = ~obj6;
								object obj9 = obj8 | flag3;
								if (obj9 != null)
								{
									goto IL_0345;
								}
								if ((object)toggles[2] != null)
								{
									object obj10 = tutorialType - 9;
									bool interactable3 = obj10 == null;
									toggles[2].interactable = interactable3;
									if ((object)toggles[3] != null)
									{
										object obj11 = tutorialType - 8;
										bool interactable4 = obj11 == null;
										toggles[3].interactable = interactable4;
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0345;
		IL_0345:
		throw new IndexOutOfRangeException();
	}

	public CheatingCatchPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 896;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 2680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		eatings = (List<EatingBox>)(object)list;
		object obj3 = this + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		players = (List<PlayerCheatingBox>)(object)list2;
		object obj4 = this + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
