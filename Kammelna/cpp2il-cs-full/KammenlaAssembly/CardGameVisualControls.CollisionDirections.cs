using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities.Data;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

public class CardGameVisualControls : KGameVisualControls
{
	private enum SwayDirection
	{
		DontSway,
		SwayRight,
		SwayLeft
	}

	private enum CollisionDirections
	{
		Top,
		TopRight,
		Right,
		BottomRight,
		Bottom,
		BottomLeft,
		Left,
		TopLeft
	}

	private class CardAction
	{
		public Card card;

		public CardGamePlayer player;

		public Transform startingPoint;

		public bool isEventFromServer;

		public bool withCollision;

		public int? gameActionId;

		public int floorLayer;

		public bool hideStartingPoint;

		public Transform eatingPoint;

		public Sprite cardback;

		public bool isLastEating;

		public List<Card> allCards;

		public List<Card> playableCard;

		public bool isCardPlay
		{
			get
			{
				bool flag = card == null;
				return !flag;
			}
		}

		public bool isEating
		{
			get
			{
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Expected O, but got Unknown
				//IL_0067: Expected O, but got I4
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return eatingPoint != null;
			}
		}

		public bool isReorganizeHand
		{
			get
			{
				bool flag = allCards == null;
				return !flag;
			}
		}

		private unsafe CardAction(Card card = null, CardGamePlayer player = null, Transform startingPoint = null, bool isEventFromServer = true, bool withCollision = true, int? gameActionId = null, int floorLayer = 0, Transform eatingPoint = null, Sprite cardback = null, bool isLastEating = false, List<Card> allCards = null, List<Card> playableCard = null, bool hideStartingPoint = false)
		{
			//IL_0008: Expected O, but got Ref
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected O, but got Unknown
			//IL_00b3: Expected O, but got I
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			//IL_00d8: Expected O, but got I
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Expected O, but got Unknown
			//IL_011e: Expected O, but got I
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected O, but got Unknown
			//IL_0143: Expected O, but got I
			object obj2 = default(object);
			object obj = (object)(&obj2);
			this.isEventFromServer = true;
			base..ctor();
			object obj3 = this + 16;
			obj3 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = this + 24;
			obj4 = player;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = this + 32;
			obj5 = startingPoint;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			this.isEventFromServer = isEventFromServer;
			this.withCollision = withCollision;
			this.gameActionId = gameActionId;
			object obj6 = this + 64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+18]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+20]");
			this.isLastEating = false;
			this.floorLayer = floorLayer;
			object obj8 = this + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+28]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = this + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+30]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+38]");
			_ = 0;
		}

		public static CardAction InitCardPlay(Card card, CardGamePlayer player, Transform startingPoint, bool isEventFromServer, bool withCollision, int? gameActionId, int floorLayer, bool hideStartingPoint)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected O, but got Unknown
			//IL_0084: Expected O, but got I4
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_00a5: Expected O, but got I4
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			//IL_00d6: Expected O, but got I4
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected O, but got Unknown
			//IL_00f7: Expected O, but got I4
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			_ = 257;
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 16;
			obj3 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = player;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 32;
			obj5 = startingPoint;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj2 + 64;
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 72;
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 0;
			object obj8 = obj2 + 88;
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj2 + 96;
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (CardAction)obj2;
		}

		public static CardAction InitEating(CardGamePlayer player, Transform eatingPoint, Sprite cardback, bool isLastEating)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected O, but got Unknown
			//IL_013d: Expected O, but got I4
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0050: Expected O, but got I4
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected O, but got Unknown
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			//IL_00d2: Expected O, but got I4
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected O, but got Unknown
			//IL_00f3: Expected O, but got I4
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			_ = 257;
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 16;
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = player;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 32;
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 257;
			_ = 0;
			object obj6 = obj2 + 64;
			obj6 = eatingPoint;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 72;
			obj7 = cardback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 0;
			object obj8 = obj2 + 88;
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj2 + 96;
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 0;
			return (CardAction)obj2;
		}

		public static CardAction InitReorganizeHand(List<Card> allCards, List<Card> playableCards)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected O, but got Unknown
			//IL_013f: Expected O, but got I4
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0030: Expected O, but got I4
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0051: Expected O, but got I4
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_0083: Expected O, but got I4
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a4: Expected O, but got I4
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			_ = 257;
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 16;
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 32;
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 257;
			_ = 0;
			object obj6 = obj2 + 64;
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 72;
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 0;
			_ = 0;
			object obj8 = obj2 + 88;
			obj8 = allCards;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj2 + 96;
			obj9 = playableCards;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 0;
			return (CardAction)obj2;
		}

		public override string ToString()
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Expected O, but got Unknown
			//IL_0197: Expected O, but got I
			//IL_01b1: Expected O, but got I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0066: Expected O, but got I
			//IL_01f7: Expected O, but got I4
			//IL_024c: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			//IL_00ee: Expected O, but got I4
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected O, but got Unknown
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Expected O, but got Unknown
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Expected O, but got Unknown
			//IL_0293: Expected O, but got I4
			//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ac: Expected O, but got Unknown
			//IL_031e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0323: Expected O, but got Unknown
			object obj = 152993792;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AF3]");
			object obj2 = (nint)0 & (nint)1;
			object obj3;
			object obj5;
			if (obj2 != null)
			{
				obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AF2]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				obj5 = obj3;
				if (!flag)
				{
					goto IL_008b;
				}
			}
			else
			{
				_ = 1;
				obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AF2]");
				object obj6 = (nint)0 & (nint)1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				obj5 = obj3;
				if (obj7 != null)
				{
					goto IL_008b;
				}
			}
			_ = 1;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			UnityEngine.Object obj10 = eatingPoint;
			UnityEngine.Object obj11 = eatingPoint;
			if (obj9 != null)
			{
				goto IL_00cc;
			}
			goto IL_0219;
			IL_00fc:
			if (player != null)
			{
				string nickName = player.NickName;
				object obj12 = "placementId" + 120;
				object obj13 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 824;
				return (string)obj12 + nickName + (string)obj13;
			}
			goto IL_0358;
			IL_0358:
			return (string)(object)new NullReferenceException();
			IL_0263:
			if (allCards != null)
			{
				object obj14 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format = "placementId" + 3264;
				object arg = default(object);
				return string.Format((string)format, arg);
			}
			if (card != null)
			{
				if (player != null)
				{
					string nickName2 = player.NickName;
					object format2 = "placementId" + 136;
					return string.Format((string)format2, nickName2, card);
				}
				goto IL_0358;
			}
			return "com.unity.services.authentication.profile" + 1392;
			IL_008b:
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			obj10 = eatingPoint;
			obj11 = eatingPoint;
			if (!flag4)
			{
				goto IL_00cc;
			}
			goto IL_0219;
			IL_0219:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = obj11 != null;
			bool flag6 = !flag5;
			object obj15 = !flag6;
			object obj16 = 0;
			if (obj15 != null)
			{
				goto IL_00fc;
			}
			goto IL_0263;
			IL_00cc:
			bool flag7 = obj10 != null;
			bool flag8 = !flag7;
			obj16 = 0;
			if (!flag8)
			{
				goto IL_00fc;
			}
			goto IL_0263;
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Predicate<CardAction> <>9__73_0;

		public static Action<SpriteRenderer> <>9__79_0;

		public static Action<SpriteRenderer> <>9__80_0;

		public static Action<SpriteRenderer> <>9__98_0;

		public static Action<SpriteRenderer> <>9__98_1;

		public static Action<SpriteRenderer> <>9__98_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3984;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <IsTooEarlyToPlayCard>b__73_0(CardAction action)
		{
			//IL_006b: Expected I4, but got O
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_0095: Expected O, but got I4
			if (action != null)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return action.eatingPoint != null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <ShowControls>b__79_0(SpriteRenderer sprite)
		{
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleSprite.DOFade(sprite, 1f, 0.3f);
		}

		internal void <HideControls>b__80_0(SpriteRenderer sprite)
		{
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleSprite.DOFade(sprite, 0f, 0.3f);
		}

		internal void <ResetGameGround>b__98_0(SpriteRenderer l)
		{
			GameObject gameObject = l.gameObject;
			gameObject.SetActive(value: false);
		}

		internal void <ResetGameGround>b__98_1(SpriteRenderer l)
		{
			GameObject gameObject = l.gameObject;
			gameObject.SetActive(value: false);
		}

		internal void <ResetGameGround>b__98_2(SpriteRenderer c)
		{
			//IL_0037: Expected O, but got I4
			Transform transform = c.transform;
			int num = ShortcutExtensions.DOKill(transform);
			transform.localScale = (Vector3)0;
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <>c__DisplayClass77_0
	{
		public CardGameVisualControls <>4__this;

		public Card card;

		public CardGamePlayer player;

		public Transform startingPoint;

		public bool isEventFromServer;

		public bool withCollision;

		public bool hideStartingPoint;
	}

	[StructLayout((LayoutKind)3)]
	private struct <>c__DisplayClass78_0
	{
		public CardGameVisualControls <>4__this;

		public Transform eatingPoint;

		public Sprite cardback;
	}

	private sealed class <>c__DisplayClass85_0
	{
		public Transform containerTransform;

		public Vector3 originalPosition;

		public SpriteRenderer sprite;

		public int floorCardsNumber;

		internal void <AnimatePlayCard>b__0()
		{
			//IL_0015: Expected O, but got I4
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			containerTransform.localPosition = (Vector3)0;
			object sortingLayerName = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3648;
			sprite.sortingLayerName = (string)sortingLayerName;
			sprite.sortingOrder = floorCardsNumber;
		}
	}

	private sealed class <>c__DisplayClass93_0
	{
		public CardGameVisualControls <>4__this;

		public SpriteRenderer playedCard;

		public KPlayer player;

		internal void <CardCollisionAnim>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_22be: Unknown result type (might be due to invalid IL or missing references)
			//IL_22c3: Expected O, but got Unknown
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_0145: Expected I4, but got I8
			//IL_015f: Expected O, but got I4
			//IL_0349: Expected O, but got I
			//IL_03c0: Expected O, but got I4
			//IL_0cde: Expected O, but got I
			//IL_0ced: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf2: Expected O, but got Unknown
			//IL_0444: Expected O, but got I
			//IL_0454: Expected O, but got I
			//IL_0464: Expected O, but got I
			//IL_01e0: Expected O, but got I4
			//IL_0400: Unknown result type (might be due to invalid IL or missing references)
			//IL_0405: Expected O, but got Unknown
			//IL_040e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0413: Expected O, but got Unknown
			//IL_01fc: Expected O, but got I4
			//IL_0242: Expected O, but got I4
			//IL_00ec: Expected O, but got I
			//IL_0114: Expected O, but got I4
			//IL_011d: Expected O, but got I4
			//IL_0985: Expected O, but got I4
			//IL_09b4: Expected I4, but got I8
			//IL_09ce: Expected O, but got I4
			//IL_054f: Expected O, but got I4
			//IL_05d3: Expected O, but got I
			//IL_05e3: Expected O, but got I
			//IL_05f3: Expected O, but got I
			//IL_058f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0594: Expected O, but got Unknown
			//IL_059d: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a2: Expected O, but got Unknown
			//IL_0e26: Expected O, but got I4
			//IL_0e40: Expected O, but got I4
			//IL_0a05: Expected O, but got I
			//IL_0a0e: Expected O, but got I4
			//IL_0e8d: Expected O, but got I
			//IL_0683: Expected O, but got I4
			//IL_0693: Expected O, but got I4
			//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b8: Expected O, but got Unknown
			//IL_2271: Expected O, but got I4
			//IL_0f41: Expected O, but got I4
			//IL_0f4b: Expected I4, but got O
			//IL_0f5c: Expected O, but got I4
			//IL_0edf: Expected O, but got I4
			//IL_0ee9: Expected I4, but got O
			//IL_0a65: Expected O, but got I4
			//IL_0f00: Expected O, but got I4
			//IL_073d: Expected O, but got I4
			//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a85: Expected O, but got Unknown
			//IL_0a8d: Expected I, but got O
			//IL_07c1: Expected O, but got I
			//IL_07d1: Expected O, but got I
			//IL_07e1: Expected O, but got I
			//IL_077d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0782: Expected O, but got Unknown
			//IL_078b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0790: Expected O, but got Unknown
			//IL_0afc: Expected O, but got I4
			//IL_0bb8: Expected O, but got I
			//IL_0bc8: Expected O, but got I
			//IL_0bd8: Expected O, but got I
			//IL_0bed: Expected O, but got I
			//IL_0b3c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b41: Expected O, but got Unknown
			//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4f: Expected O, but got Unknown
			//IL_0b5f: Expected O, but got I
			//IL_0c4c: Expected O, but got I4
			//IL_0fdf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe4: Expected O, but got Unknown
			//IL_0ffc: Expected O, but got I
			//IL_1004: Expected F4, but got O
			//IL_1014: Expected F4, but got I
			//IL_1022: Unknown result type (might be due to invalid IL or missing references)
			//IL_1027: Expected O, but got Unknown
			//IL_1030: Expected O, but got I4
			//IL_1074: Expected O, but got I
			//IL_08c5: Expected O, but got I4
			//IL_10aa: Expected O, but got I
			//IL_0905: Unknown result type (might be due to invalid IL or missing references)
			//IL_090a: Expected O, but got Unknown
			//IL_0913: Unknown result type (might be due to invalid IL or missing references)
			//IL_0918: Expected O, but got Unknown
			//IL_103e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1043: Expected O, but got Unknown
			//IL_1139: Unknown result type (might be due to invalid IL or missing references)
			//IL_113e: Expected O, but got Unknown
			//IL_1168: Expected O, but got I4
			//IL_119d: Unknown result type (might be due to invalid IL or missing references)
			//IL_11a2: Expected O, but got Unknown
			//IL_11ae: Expected O, but got I
			//IL_147f: Expected F4, but got I4
			//IL_2375: Expected O, but got I4
			//IL_130f: Expected F4, but got I4
			//IL_13b0: Expected F4, but got I4
			//IL_249e: Expected F4, but got I4
			//IL_1223: Expected F4, but got I4
			//IL_14cc: Expected O, but got I4
			//IL_1608: Expected O, but got I4
			//IL_1611: Expected F4, but got I4
			//IL_135c: Expected O, but got I4
			//IL_153c: Expected O, but got I4
			//IL_1545: Expected F4, but got I4
			//IL_141a: Expected O, but got I4
			//IL_1423: Expected F4, but got I4
			//IL_128d: Expected O, but got I4
			//IL_1296: Expected F4, but got I4
			//IL_1909: Expected O, but got I4
			//IL_1925: Expected O, but got I4
			//IL_19fc: Invalid comparison between F8 and I4
			//IL_1a0b: Expected O, but got I4
			//IL_2581: Expected O, but got I4
			//IL_1a76: Invalid comparison between F8 and I4
			//IL_1a85: Invalid comparison between F8 and I4
			//IL_1a9d: Expected O, but got F8
			//IL_1aaa: Expected O, but got F8
			//IL_1adf: Expected O, but got I4
			//IL_1ae7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aec: Expected O, but got Unknown
			//IL_1a3b: Expected O, but got I4
			//IL_1b0c: Expected F4, but got I4
			//IL_1c21: Expected O, but got I4
			//IL_1c3c: Expected O, but got I4
			//IL_1d38: Invalid comparison between F4 and I4
			//IL_1d49: Expected O, but got I4
			//IL_1d63: Expected O, but got F4
			//IL_1d6c: Expected F4, but got I4
			//IL_1d77: Expected F4, but got I4
			//IL_1d80: Expected F4, but got I4
			//IL_1d91: Expected F4, but got I4
			//IL_1c9e: Invalid comparison between F4 and I4
			//IL_1caf: Expected O, but got I4
			//IL_1cc9: Expected O, but got F4
			//IL_1cd2: Expected F4, but got I4
			//IL_1cdd: Expected F4, but got I4
			//IL_1ce6: Expected F4, but got I4
			//IL_1d05: Expected F4, but got I4
			//IL_1e01: Expected O, but got I4
			//IL_1e1c: Expected O, but got I4
			//IL_1f3f: Invalid comparison between F4 and I4
			//IL_1f50: Expected O, but got I4
			//IL_1f6a: Expected O, but got F4
			//IL_1f73: Expected F4, but got I4
			//IL_1f7e: Expected F4, but got I4
			//IL_1f87: Expected F4, but got I4
			//IL_1e92: Invalid comparison between F4 and I4
			//IL_1ea3: Expected O, but got I4
			//IL_1ebd: Expected O, but got F4
			//IL_1ec6: Expected F4, but got I4
			//IL_1ed1: Expected F4, but got I4
			//IL_1eda: Expected F4, but got I4
			//IL_20c3: Expected O, but got I4
			//IL_20d8: Expected O, but got I
			//IL_21be: Expected O, but got F4
			//IL_21f8: Expected I4, but got O
			UnityEngine.Object obj = (UnityEngine.Object)(typeof(List<AdaptivePerformanceScaler>) + 3504);
			object obj2 = (nint)0 + (nint)2464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityEngine.Object obj3 = (UnityEngine.Object)obj2;
			List<object> list = default(List<object>);
			list..ctor();
			object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v4+E4]");
			object obj6;
			object obj7;
			if ((nint)0 != 0)
			{
				obj6 = typeof(MemberAchievementClanFeedData) + 2976;
				Games currentGame = Preferences.CurrentGame;
				bool flag = currentGame != Games.Jackaroo;
				obj7 = obj6;
				if (!flag)
				{
					goto IL_006a;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = typeof(MemberAchievementClanFeedData) + 2976;
				Games currentGame2 = Preferences.CurrentGame;
				bool flag2 = currentGame2 == Games.Jackaroo;
				obj7 = obj6;
				if (flag2)
				{
					goto IL_006a;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list2 = default(List<object>);
			list2..ctor();
			CardGameVisualControls cardGameVisualControls = <>4__this;
			List<object> list3;
			if ((object)<>4__this != null)
			{
				SpriteRenderer[] playingCardsSprites = cardGameVisualControls.playingCardsSprites;
				if (cardGameVisualControls.playingCardsSprites != null && list2 != null)
				{
					object obj8 = (nint)0 + (nint)2472;
					object obj9 = obj8;
					int version = list2._version + 1;
					list2._version = version;
					object[] items = list2._items;
					if (list2._items != null)
					{
						bool flag3 = list2._size < items.Length;
						object obj10 = !flag3;
						if (obj10 == null)
						{
							int size = list2._size + 1;
							list2._size = size;
							object obj11 = list2._items + list2._size;
							object obj12 = obj11 + 32;
							obj12 = playingCardsSprites[0];
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v63+20]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X8_v85+C0]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1082 @ X8_v86+70]");
							object obj15 = 0;
							list2.AddWithResize((object)playingCardsSprites[0]);
						}
						CardGameVisualControls cardGameVisualControls2 = <>4__this;
						if ((object)<>4__this != null)
						{
							SpriteRenderer[] playingCardsSprites2 = cardGameVisualControls2.playingCardsSprites;
							if (cardGameVisualControls2.playingCardsSprites != null)
							{
								object obj16 = obj8;
								int version2 = list2._version + 1;
								list2._version = version2;
								object[] items2 = list2._items;
								if (list2._items != null)
								{
									bool flag4 = list2._size < items2.Length;
									object obj17 = !flag4;
									if (obj17 == null)
									{
										int size2 = list2._size + 1;
										list2._size = size2;
										object obj18 = list2._items + list2._size;
										object obj19 = obj18 + 32;
										obj19 = playingCardsSprites2[1];
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v67+20]");
										object obj20 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X8_v82+C0]");
										object obj21 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1193 @ X8_v83+70]");
										object obj15 = 0;
										list2.AddWithResize((object)playingCardsSprites2[1]);
									}
									CardGameVisualControls cardGameVisualControls3 = <>4__this;
									if ((object)<>4__this != null)
									{
										SpriteRenderer[] playingCardsSprites3 = cardGameVisualControls3.playingCardsSprites;
										if (cardGameVisualControls3.playingCardsSprites != null)
										{
											bool flag5 = playingCardsSprites3.Length < 2;
											object obj22 = !flag5;
											object obj23 = playingCardsSprites3.Length - 2;
											bool flag6 = obj23 == null;
											object obj24 = ~obj22;
											object obj25 = obj24 | flag6;
											if (obj25 != null)
											{
												goto IL_228d;
											}
											object obj26 = obj8;
											int version3 = list2._version + 1;
											list2._version = version3;
											object[] items3 = list2._items;
											if (list2._items != null)
											{
												bool flag7 = list2._size < items3.Length;
												object obj27 = !flag7;
												if (obj27 == null)
												{
													int size3 = list2._size + 1;
													list2._size = size3;
													object obj28 = list2._items + list2._size;
													object obj29 = obj28 + 32;
													obj29 = playingCardsSprites3[2];
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v71+20]");
													object obj30 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1235 @ X8_v79+C0]");
													object obj31 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1236 @ X8_v80+70]");
													object obj15 = 0;
													list2.AddWithResize((object)playingCardsSprites3[2]);
												}
												CardGameVisualControls cardGameVisualControls4 = <>4__this;
												if ((object)<>4__this != null)
												{
													SpriteRenderer[] playingCardsSprites4 = cardGameVisualControls4.playingCardsSprites;
													if (cardGameVisualControls4.playingCardsSprites != null)
													{
														int version4 = list2._version + 1;
														list2._version = version4;
														object[] items4 = list2._items;
														if (list2._items != null)
														{
															bool flag8 = list2._size < items4.Length;
															object obj32 = !flag8;
															if (obj32 == null)
															{
																int size4 = list2._size + 1;
																list2._size = size4;
																object obj33 = list2._items + list2._size;
																object obj34 = obj33 + 32;
																obj34 = playingCardsSprites4[3];
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																obj6 = obj7;
																list3 = list2;
															}
															else
															{
																list2.AddWithResize((object)playingCardsSprites4[3]);
																obj6 = obj7;
																list3 = list2;
															}
															goto IL_0cb0;
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
			goto IL_227f;
			IL_006a:
			CardGameVisualControls cardGameVisualControls5 = <>4__this;
			int num;
			if ((object)<>4__this != null)
			{
				SpriteRenderer[] playingCardsSprites5 = cardGameVisualControls5.playingCardsSprites;
				if (cardGameVisualControls5.playingCardsSprites != null)
				{
					num = playingCardsSprites5.Length - 1;
					while (true)
					{
						int num2 = (int)(num & 0x80000000L);
						bool flag9 = num2 == 0;
						object obj35 = !flag9;
						if (obj35 != null)
						{
							break;
						}
						CardGameVisualControls cardGameVisualControls6 = <>4__this;
						if ((object)<>4__this != null)
						{
							SpriteRenderer[] playingCardsSprites6 = cardGameVisualControls6.playingCardsSprites;
							if (cardGameVisualControls6.playingCardsSprites != null)
							{
								bool flag10 = num < playingCardsSprites6.Length;
								object obj36 = !flag10;
								if (obj36 == null)
								{
									object[] items4 = (object[])(num & 0x7FFFFFFF);
									object obj37 = (object)cardGameVisualControls6.playingCardsSprites + (object)items4;
									obj = playedCard;
									object obj38 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1065 @ X0_v179+E4]");
									bool flag11 = (nint)0 == 0;
									object obj39 = !flag11;
									if (obj39 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X8_v95+20]");
									bool flag12 = (UnityEngine.Object)0 == obj;
									num--;
									bool flag13 = !flag12;
									object obj40 = !flag13;
									object obj15 = 0;
									obj3 = obj;
									if (obj40 == null)
									{
										continue;
									}
									goto IL_0977;
								}
								goto IL_228d;
							}
						}
						goto IL_227f;
					}
					goto IL_0c8b;
				}
			}
			goto IL_227f;
			IL_227f:
			NullReferenceException ex = new NullReferenceException();
			goto IL_228d;
			IL_228d:
			throw new IndexOutOfRangeException();
			IL_0cb0:
			if (list3._size < 1)
			{
				return;
			}
			object obj41 = (nint)0 + (nint)2504;
			object obj42 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			int num3 = 0;
			double num10 = default(double);
			Vector3 euler = default(Vector3);
			while (true)
			{
				object obj43 = list3.get_Item(num3);
				if (obj43 == null)
				{
					break;
				}
				GameObject gameObject = ((Component)obj43).gameObject;
				if ((object)gameObject == null)
				{
					break;
				}
				float num4;
				float num5;
				float num6;
				if (gameObject.activeSelf)
				{
					object obj44 = list3.get_Item(num3);
					if (obj44 == null)
					{
						break;
					}
					int sortingOrder = ((Renderer)obj44).sortingOrder;
					if ((object)playedCard == null)
					{
						break;
					}
					int sortingOrder2 = playedCard.sortingOrder;
					object obj45 = sortingOrder - sortingOrder2;
					bool flag14 = obj45 == null;
					object obj46 = !flag14;
					bool flag15 = sortingOrder > sortingOrder2;
					num = sortingOrder;
					if (!flag15)
					{
						object obj47 = list3.get_Item(num3);
						object obj48 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1179 @ X8_v12+E4]");
						object[] items4 = (object[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1179 @ X8_v12+E4]");
						if ((nint)0 != 0)
						{
							bool flag16 = (UnityEngine.Object)obj47 == playedCard;
							bool flag17 = !flag16;
							object obj49 = !flag17;
							num = (int)playedCard;
							if (obj49 != null)
							{
								goto IL_0d00;
							}
							object obj50 = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag18 = (UnityEngine.Object)obj47 == playedCard;
							bool flag19 = !flag18;
							object obj51 = !flag19;
							num = (int)playedCard;
							obj = (UnityEngine.Object)obj47;
							object obj50 = 0;
							if (obj51 != null)
							{
								goto IL_0d00;
							}
						}
						num4 = UnityEngine.Random.Range(0.35f, 0.45f);
						CardGameVisualControls cardGameVisualControls7 = <>4__this;
						if ((object)<>4__this == null)
						{
							break;
						}
						Userbox[] allUserboxes = cardGameVisualControls7.allUserboxes;
						if (cardGameVisualControls7.allUserboxes == null || allUserboxes.Length < 1)
						{
							break;
						}
						object obj52 = typeof(UsageHint) + 744;
						object obj53 = obj52;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1288 @ X8_v24+B8]");
						object obj54 = 0;
						num5 = (float)obj54;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1289 @ X8_v25+4]");
						num6 = 0f;
						object obj55 = cardGameVisualControls7.allUserboxes + 32;
						object obj56 = 0;
						do
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X24_v8+v265 @ X27_v9*8]");
							Component component = (Component)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X24_v8+v265 @ X27_v9*8]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X24_v8+v265 @ X27_v9*8]");
							GameObject gameObject2 = ((Component)0).gameObject;
							if ((object)gameObject2 == null)
							{
								break;
							}
							if (gameObject2.activeInHierarchy)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X23_v10 (UnityEngine.Component)+198]");
								if (0 == (nint)player)
								{
									goto IL_111a;
								}
							}
							obj56++;
						}
						while ((nint)obj56 < allUserboxes.Length);
						break;
					}
				}
				goto IL_0d00;
				IL_2465:
				SwayDirection swayDirection;
				float num7 = GetSwayValue(swayDirection);
				float num8 = num7;
				CollisionDirections collidingDirection = CollisionDirections.BottomRight;
				goto IL_24ce;
				IL_111a:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X23_v10 (UnityEngine.Component)+24]");
				num = 0;
				object obj57 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				object obj58 = obj57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1317 @ X0_v30+E4]");
				bool flag20 = (nint)0 == 0;
				object obj59 = !flag20;
				if (obj59 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Games currentGame3 = Preferences.CurrentGame;
				obj6 = typeof(MemberAchievementClanFeedData) + 2976;
				obj = (UnityEngine.Object)((nint)0 + (nint)2904);
				SwayDirection swayDirection2;
				SwayDirection swayDirection3;
				SwayDirection swayDirection4;
				if (currentGame3 == Games.Jackaroo)
				{
					if (num <= 1)
					{
						if (num != 0)
						{
							bool flag21 = num != 1;
							num8 = 0f;
							num7 = num4;
							if (!flag21)
							{
								if (num3 == 2)
								{
									swayDirection2 = SwayDirection.SwayRight;
									goto IL_241f;
								}
								if (num3 == 1)
								{
									num7 = GetSwayValue(SwayDirection.DontSway);
									num8 = num7;
									collidingDirection = CollisionDirections.Left;
									goto IL_24ce;
								}
								bool flag22 = num3 == 0;
								object obj60 = !flag22;
								num8 = 0f;
								num7 = num4;
								if (obj60 == null)
								{
									swayDirection3 = SwayDirection.SwayLeft;
									goto IL_2393;
								}
							}
						}
						else
						{
							if (num3 == 2)
							{
								swayDirection4 = SwayDirection.SwayRight;
								goto IL_23d9;
							}
							if (num3 == 1)
							{
								num7 = GetSwayValue(SwayDirection.DontSway);
								num8 = num7;
								collidingDirection = CollisionDirections.Top;
								goto IL_24ce;
							}
							bool flag23 = num3 == 0;
							object obj61 = !flag23;
							num8 = 0f;
							num7 = num4;
							if (obj61 == null)
							{
								swayDirection2 = SwayDirection.SwayLeft;
								goto IL_241f;
							}
						}
					}
					else if (num != 2)
					{
						bool flag24 = num != 3;
						num8 = 0f;
						num7 = num4;
						if (!flag24)
						{
							if (num3 == 2)
							{
								swayDirection = SwayDirection.SwayRight;
								goto IL_2465;
							}
							if (num3 == 1)
							{
								num7 = GetSwayValue(SwayDirection.DontSway);
								num8 = num7;
								collidingDirection = CollisionDirections.Right;
								goto IL_24ce;
							}
							bool flag25 = num3 == 0;
							object obj62 = !flag25;
							num8 = 0f;
							num7 = num4;
							if (obj62 == null)
							{
								swayDirection4 = SwayDirection.SwayLeft;
								goto IL_23d9;
							}
						}
					}
					else
					{
						if (num3 == 2)
						{
							swayDirection3 = SwayDirection.SwayRight;
							goto IL_2393;
						}
						if (num3 == 1)
						{
							num7 = GetSwayValue(SwayDirection.DontSway);
							num8 = num7;
							collidingDirection = CollisionDirections.Bottom;
							goto IL_24ce;
						}
						bool flag26 = num3 == 0;
						object obj63 = !flag26;
						num8 = 0f;
						num7 = num4;
						if (obj63 == null)
						{
							swayDirection = SwayDirection.SwayLeft;
							goto IL_2465;
						}
					}
					goto IL_2342;
				}
				SwayDirection swayDirection5;
				CollisionDirections collidingDirection2;
				SwayDirection swayDirection7;
				SwayDirection swayDirection8;
				if (num3 <= 1)
				{
					SwayDirection swayDirection6;
					if (num3 != 0)
					{
						bool flag27 = num3 != 1;
						num8 = 0f;
						num7 = num4;
						if (flag27)
						{
							goto IL_2342;
						}
						if (num != 2)
						{
							bool flag28 = num == 0;
							object obj64 = !flag28;
							if (obj64 == null)
							{
								swayDirection5 = SwayDirection.SwayRight;
								goto IL_23b6;
							}
							num7 = GetSwayValue(SwayDirection.DontSway);
							num8 = num7;
							collidingDirection2 = CollisionDirections.Right;
							goto IL_2488;
						}
						swayDirection6 = SwayDirection.SwayLeft;
					}
					else
					{
						if (num != 3)
						{
							if (num == 1)
							{
								swayDirection7 = SwayDirection.SwayLeft;
								goto IL_2442;
							}
							num7 = GetSwayValue(SwayDirection.DontSway);
							num8 = num7;
							collidingDirection2 = CollisionDirections.Bottom;
							goto IL_2488;
						}
						swayDirection6 = SwayDirection.SwayRight;
					}
					num7 = GetSwayValue(swayDirection6);
					num8 = num7;
					collidingDirection2 = CollisionDirections.BottomRight;
				}
				else if (num3 != 2)
				{
					bool flag29 = num3 != 3;
					num8 = 0f;
					num7 = num4;
					if (flag29)
					{
						goto IL_2342;
					}
					if (num == 2)
					{
						swayDirection7 = SwayDirection.SwayRight;
						goto IL_2442;
					}
					bool flag30 = num == 0;
					object obj65 = !flag30;
					if (obj65 == null)
					{
						swayDirection8 = SwayDirection.SwayLeft;
						goto IL_23fc;
					}
					num7 = GetSwayValue(SwayDirection.DontSway);
					num8 = num7;
					collidingDirection2 = CollisionDirections.Left;
				}
				else
				{
					if (num == 3)
					{
						swayDirection5 = SwayDirection.SwayLeft;
						goto IL_23b6;
					}
					if (num == 1)
					{
						swayDirection8 = SwayDirection.SwayRight;
						goto IL_23fc;
					}
					num7 = GetSwayValue(SwayDirection.DontSway);
					num8 = num7;
					collidingDirection2 = CollisionDirections.Top;
				}
				goto IL_2488;
				IL_0d00:
				num3++;
				if (num3 < list3._size)
				{
					continue;
				}
				return;
				IL_24ce:
				Vector2 collisionValues = GetCollisionValues(collidingDirection);
				num5 = num7 * 0.5f;
				float num9 = 1.0552869E+09f * 0.5f;
				object obj66 = obj41;
				object obj67 = list3.get_Item(num3);
				bool flag31 = obj67 == null;
				num10 = 0.5;
				double num11 = num9;
				Component component2 = (Component)obj67;
				if (flag31)
				{
					break;
				}
				goto IL_1815;
				IL_2488:
				Vector2 collisionValues2 = GetCollisionValues(collidingDirection2);
				num6 = 1.0552869E+09f;
				num5 = num7;
				goto IL_2342;
				IL_1815:
				Transform transform = component2.transform;
				if ((object)transform == null)
				{
					break;
				}
				Vector3 localEulerAngles = transform.localEulerAngles;
				double num12 = (double)num8 + num10;
				num10 = num12 * 1016003125.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				float num13 = num7 * num4;
				Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
				CardGameVisualControls cardGameVisualControls8 = <>4__this;
				if ((object)<>4__this == null)
				{
					break;
				}
				Vector3[] originalEatingCardsTransformsRotations = cardGameVisualControls8._originalEatingCardsTransformsRotations;
				if (cardGameVisualControls8._originalEatingCardsTransformsRotations == null)
				{
					break;
				}
				bool flag32 = num3 < originalEatingCardsTransformsRotations.Length;
				object obj68 = !flag32;
				if (obj68 == null)
				{
					object obj69 = num3 * 12;
					object obj70 = (object)cardGameVisualControls8._originalEatingCardsTransformsRotations + obj69;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1777 @ X8_v33+28]");
					float num14 = 0f * 1.01600314E+09f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1777 @ X8_v33+20]");
					float num15 = 0f * num4;
					Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(ref euler);
					float num16 = num13 * num14;
					float num17 = 0f * num15;
					float num18 = num16 + num17;
					double num19 = num10 * num10;
					double num20 = num19 + (double)num18;
					float num21 = 1.01600314E+09f * 1.01600314E+09f;
					double num22 = (double)num21 + num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
					bool flag33 = num22 > 1065353199.0;
					object obj71 = 1065353199;
					if (!flag33)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0DC0");
						num22 += num22;
						obj71 = 1113927393;
					}
					object obj72 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1819 @ X0_v45+E4]");
					bool flag34 = (nint)0 == 0;
					object obj73 = !flag34;
					if (obj73 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					double num23 = num22 - 12.0;
					bool flag35 = num23 < 0.0;
					bool flag36 = num23 == 0.0;
					object obj74 = num22 ^ 12.0;
					object obj75 = num22 ^ num23;
					object obj76 = obj74 & obj75;
					bool flag37 = (nint)obj76 < 0;
					bool flag38 = flag35 == flag37;
					object obj77 = !flag36;
					object obj78 = flag38 & obj77;
					object obj79 = ~obj78;
					float num24 = ((obj79 != null) ? num8 : 0f);
					object obj80 = list3.get_Item(num3);
					if (obj80 == null)
					{
						break;
					}
					Transform transform2 = ((Component)obj80).transform;
					if ((object)transform2 == null)
					{
						break;
					}
					Vector3 localPosition = transform2.localPosition;
					object obj81 = list3.get_Item(num3);
					if (obj81 == null)
					{
						break;
					}
					Transform transform3 = ((Component)obj81).transform;
					if ((object)transform3 == null)
					{
						break;
					}
					Vector3 localPosition2 = transform3.localPosition;
					CardGameVisualControls cardGameVisualControls9 = <>4__this;
					if ((object)<>4__this == null)
					{
						break;
					}
					Vector3[] originalEatingCardsTransformsPositions = cardGameVisualControls9._originalEatingCardsTransformsPositions;
					if (cardGameVisualControls9._originalEatingCardsTransformsPositions == null)
					{
						break;
					}
					object[] items4 = (object[])originalEatingCardsTransformsPositions.Length;
					bool flag39 = num3 < originalEatingCardsTransformsPositions.Length;
					object obj82 = !flag39;
					if (obj82 == null)
					{
						object obj83 = obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ X0_v55+E4]");
						float endValue;
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
							float num25 = 0f - 1.1190927E+09f;
							bool flag40 = num25 == 0f;
							object obj46 = !flag40;
							bool flag41 = 0 > 1119092736;
							euler = (Vector3)num15;
							float num26 = 1.01600314E+09f;
							float num27 = 1.1190927E+09f;
							float num28 = 0f;
							if (flag41)
							{
								goto IL_0d00;
							}
							endValue = num5;
							float num29 = 1.1190927E+09f;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
							float num30 = 0f - 1.1190927E+09f;
							bool flag42 = num30 == 0f;
							object obj46 = !flag42;
							bool flag43 = 0 > 1119092736;
							euler = (Vector3)num15;
							float num26 = 1.01600314E+09f;
							float num27 = 1.1190927E+09f;
							float num28 = 0f;
							endValue = num5;
							float num29 = 1.1190927E+09f;
							if (flag43)
							{
								goto IL_0d00;
							}
						}
						CardGameVisualControls cardGameVisualControls10 = <>4__this;
						if ((object)<>4__this == null)
						{
							break;
						}
						Vector3[] originalEatingCardsTransformsPositions2 = cardGameVisualControls10._originalEatingCardsTransformsPositions;
						if (cardGameVisualControls10._originalEatingCardsTransformsPositions == null)
						{
							break;
						}
						items4 = (object[])originalEatingCardsTransformsPositions2.Length;
						bool flag44 = num3 < originalEatingCardsTransformsPositions2.Length;
						object obj84 = !flag44;
						if (obj84 == null)
						{
							object obj85 = obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1170 @ X0_v57+E4]");
							double num32;
							object obj86;
							float num26;
							float num27;
							float num28;
							object obj46;
							if ((nint)0 != 0)
							{
								num11 += 12.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
								float num31 = 0f - 1.1190927E+09f;
								bool flag45 = num31 == 0f;
								obj46 = !flag45;
								bool flag46 = 0 > 1119092736;
								euler = (Vector3)num15;
								num26 = 1.01600314E+09f;
								num27 = 1.1190927E+09f;
								num28 = 0f;
								if (flag46)
								{
									goto IL_0d00;
								}
								num32 = num11;
								obj86 = obj46;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								num11 += 12.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
								float num33 = 0f - 1.1190927E+09f;
								bool flag47 = num33 == 0f;
								obj46 = !flag47;
								bool flag48 = 0 > 1119092736;
								euler = (Vector3)num15;
								num26 = 1.01600314E+09f;
								num27 = 1.1190927E+09f;
								num28 = 0f;
								num32 = num11;
								obj86 = obj46;
								if (flag48)
								{
									goto IL_0d00;
								}
							}
							object obj87 = list3.get_Item(num3);
							if (obj87 == null)
							{
								break;
							}
							Transform transform4 = ((Component)obj87).transform;
							int num34 = ShortcutExtensions.DOKill(transform4, complete: true);
							object obj88 = list3.get_Item(num3);
							if (obj88 == null)
							{
								break;
							}
							Transform transform5 = ((Component)obj88).transform;
							object obj89 = list3.get_Item(num3);
							if (obj89 == null)
							{
								break;
							}
							Transform transform6 = ((Component)obj89).transform;
							if ((object)transform6 == null)
							{
								break;
							}
							Vector3 localEulerAngles2 = transform6.localEulerAngles;
							float num35 = num24 + (float)num10;
							TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(transform5, (Vector3)0, 0f);
							object obj90 = (nint)0 + (nint)2848;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
							object obj91 = list3.get_Item(num3);
							if (obj91 == null)
							{
								break;
							}
							Transform transform7 = ((Component)obj91).transform;
							TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOLocalMoveX(transform7, endValue, num4);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
							object obj92 = list3.get_Item(num3);
							if (obj92 == null)
							{
								break;
							}
							Transform transform8 = ((Component)obj92).transform;
							TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOLocalMoveY(transform8, (float)num32, num4);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
							euler = (Vector3)num15;
							num26 = num4;
							num10 = num35;
							num11 = num32;
							num27 = num4;
							num28 = (float)num32;
							obj46 = obj86;
							num = (int)transform5;
							goto IL_0d00;
						}
					}
				}
				goto IL_228d;
				IL_2342:
				obj66 = obj41;
				object obj93 = list3.get_Item(num3);
				bool flag49 = obj93 == null;
				object obj94 = !flag49;
				num11 = num6;
				component2 = (Component)obj93;
				if (obj94 == null)
				{
					break;
				}
				goto IL_1815;
				IL_2442:
				num7 = GetSwayValue(swayDirection7);
				num8 = num7;
				collidingDirection2 = CollisionDirections.BottomLeft;
				goto IL_2488;
				IL_2393:
				num7 = GetSwayValue(swayDirection3);
				num8 = num7;
				collidingDirection = CollisionDirections.BottomLeft;
				goto IL_24ce;
				IL_23fc:
				num7 = GetSwayValue(swayDirection8);
				num8 = num7;
				collidingDirection2 = CollisionDirections.TopLeft;
				goto IL_2488;
				IL_23b6:
				num7 = GetSwayValue(swayDirection5);
				num8 = num7;
				collidingDirection2 = CollisionDirections.TopRight;
				goto IL_2488;
				IL_23d9:
				num7 = GetSwayValue(swayDirection4);
				num8 = num7;
				collidingDirection = CollisionDirections.TopRight;
				goto IL_24ce;
				IL_241f:
				num7 = GetSwayValue(swayDirection2);
				num8 = num7;
				collidingDirection = CollisionDirections.TopLeft;
				goto IL_24ce;
			}
			goto IL_227f;
			IL_0c8b:
			bool flag50 = list == null;
			list3 = list;
			if (!flag50)
			{
				goto IL_0cb0;
			}
			goto IL_227f;
			IL_0977:
			object obj95 = num + 1;
			if (obj95 != null)
			{
				int num36 = (int)(num & 0x80000000L);
				bool flag51 = num36 == 0;
				object obj96 = !flag51;
				if (obj96 == null)
				{
					if (list != null)
					{
						obj = (UnityEngine.Object)((nint)0 + (nint)2472);
						object obj97 = 0;
						int num37 = num;
						while (true)
						{
							CardGameVisualControls cardGameVisualControls11 = <>4__this;
							if ((object)<>4__this == null)
							{
								break;
							}
							SpriteRenderer[] playingCardsSprites7 = cardGameVisualControls11.playingCardsSprites;
							if (cardGameVisualControls11.playingCardsSprites == null)
							{
								break;
							}
							bool flag52 = num37 < playingCardsSprites7.Length;
							object obj98 = !flag52;
							object[] items4;
							if (obj98 == null)
							{
								object obj99 = cardGameVisualControls11.playingCardsSprites + num37;
								nint num38 = (nint)obj;
								int version5 = list._version + 1;
								list._version = version5;
								object[] items5 = list._items;
								if (list._items == null)
								{
									break;
								}
								bool flag53 = list._size < items5.Length;
								object obj100 = !flag53;
								if (obj100 == null)
								{
									int size5 = list._size + 1;
									list._size = size5;
									object obj101 = list._items + list._size;
									object obj102 = obj101 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ X8_v103+20]");
									obj102 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									if (list._size != 3)
									{
										goto IL_0c24;
									}
									items4 = list._items;
									list3 = list;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v104 (Il2CppClass<UnityEngine.Object>)+20]");
									object obj103 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X8_v106+C0]");
									object obj104 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X8_v107+70]");
									obj97 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ X8_v103+20]");
									list.AddWithResize((object)0);
									bool flag54 = list._size == 3;
									items4 = list._items;
									list3 = list;
									if (!flag54)
									{
										goto IL_0c24;
									}
								}
								goto IL_0cb0;
							}
							goto IL_228d;
							IL_0c24:
							bool flag55 = num37 == 0;
							int num39 = num37 - 1;
							object obj46 = !flag55;
							bool flag56 = num37 > 0;
							num37 = num39;
							if (flag56)
							{
								continue;
							}
							items4 = list._items;
							list3 = list;
							goto IL_0cb0;
						}
					}
					else
					{
						CardGameVisualControls cardGameVisualControls12 = <>4__this;
						if ((object)<>4__this != null)
						{
							SpriteRenderer[] playingCardsSprites8 = cardGameVisualControls12.playingCardsSprites;
							if (cardGameVisualControls12.playingCardsSprites != null)
							{
								bool flag57 = num < playingCardsSprites8.Length;
								object obj105 = !flag57;
								if (obj105 != null)
								{
									goto IL_228d;
								}
							}
						}
					}
					goto IL_227f;
				}
			}
			goto IL_0c8b;
		}
	}

	private const string RevealedCardsLayer = "Revealed cards";

	private const string GroundCardsLayer = "Ground cards";

	private const string UserboxElements = "Userbox Elements";

	private const string HandCardsLayer = "Hand cards";

	private Transform playGround;

	private Transform eatingsParent;

	private Transform playingParent;

	private SpriteRenderer eatingCountTemplate;

	protected SpriteRenderer[] eatingCardsSprites;

	protected SpriteRenderer[] playingCardsSprites;

	private AnimationCurve UserboxCardPlayIntroRotation;

	private AnimationCurve UserboxCardPlayIntroScale;

	protected CardsSprites cardsSprites;

	private bool <AreOthersCardsVisible>k__BackingField;

	private SpriteRenderer[] _eatingsCount;

	private Vector3 _originalPlayingCardsScale;

	private Vector3 _originalEatingCardsParentPosition;

	protected Vector3[] _originalEatingCardsTransformsPositions;

	protected Vector3[] _originalEatingCardsTransformsRotations;

	private Sequence _animateEatingTween;

	private SpriteRenderer[] _allGroundCards;

	private readonly Dictionary<KPlayer, SpriteRenderer> _playingCardsMapping;

	private Coroutine _eatingCoroutine;

	private readonly List<CardAction> _actionsBuffer;

	private const float MinRandSlide = 0f;

	private const float MaxRandSlide = 30f;

	private const float MinRandRot = 1f;

	private const float RandRot = 3f;

	private const float MinRandPos = 6f;

	private const float RandPos = 9f;

	private const float MinRandPosTime = 0.35f;

	private const float MaxRandPosTime = 0.45f;

	private const float HumanPerceptionTime = 0.6f;

	private const float ConsecutiveCardPlayTime = 0.1f;

	private const float AnimationPreCollisionTime = 0.3f;

	protected float localCardMoveDuration;

	protected float localCardMoveDelay;

	protected float localCardRotDuration;

	protected float localCardScaleDuration;

	protected float serverCardMoveDuration;

	protected float serverCardMoveDelay;

	protected float serverCardRotDuration;

	protected float serverCardScaleDuration;

	protected Vector3 localCardStartScale;

	protected Vector3 serverCardStartScale;

	protected float cardSlotFlingY;

	private bool _shouldAnimateEatingNow;

	private bool _shouldPlayCardNow;

	private bool _isLastEating;

	private float _updateBufferTime;

	private float _pauseUntil;

	private float _lastActionPlayedTime;

	private bool _isLastActionInBufferPlayCard;

	public Transform PlayGround => playGround;

	public CardsSprites CardsSprites => cardsSprites;

	public bool AreOthersCardsVisible
	{
		get
		{
			return <AreOthersCardsVisible>k__BackingField;
		}
		private set
		{
			<AreOthersCardsVisible>k__BackingField = value;
		}
	}

	private CardGame Game
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			CardGame game = (CardGame)_game;
			if ((object)_game != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
				object obj2 = obj;
				nint num = (nint)game;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<CardGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<CardGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (CardGame)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (CardGame)_game;
		}
	}

	public float LocalCardFlightDuration => localCardMoveDelay + localCardMoveDuration;

	public unsafe void GetPlayerCardInfo(KPlayer player, Card card, out SpriteRenderer cardRenderer, out Sprite cardSprite)
	{
		//IL_0005: Expected I, but got O
		nint num = (nint)this;
		SpriteRenderer cardSprite2 = GetCardSprite(player);
		ref SpriteRenderer reference = ref *(SpriteRenderer*)cardSprite2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Sprite sprite = cardsSprites.GetFor(card);
		ref Sprite reference2 = ref *(Sprite*)sprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected unsafe override void Init()
	{
		//IL_1154: Expected I, but got O
		//IL_115e: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0036: Expected O, but got I4
		//IL_0055: Expected O, but got I
		//IL_0074: Expected I, but got O
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected I4, but got Unknown
		//IL_0bd5: Expected O, but got I
		//IL_0bef: Expected O, but got I4
		//IL_0bf8: Expected O, but got I4
		//IL_0bfd: Expected I, but got O
		//IL_0c06: Expected O, but got I4
		//IL_0c0b: Expected I, but got O
		//IL_0aff: Expected O, but got I
		//IL_0b17: Expected O, but got I4
		//IL_0b1c: Expected I, but got O
		//IL_0b25: Expected O, but got I4
		//IL_0b2a: Expected I, but got O
		//IL_00d2: Expected I, but got O
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected O, but got Unknown
		//IL_0b72: Expected O, but got I4
		//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c33: Expected O, but got Unknown
		//IL_0c7e: Expected I, but got O
		//IL_0c86: Expected I, but got O
		//IL_0cb1: Expected O, but got I4
		//IL_0d5b: Expected I, but got O
		//IL_00f1: Expected O, but got I
		//IL_0122: Expected I, but got O
		//IL_0d9e: Expected O, but got I4
		//IL_0da6: Expected O, but got I
		//IL_0ce5: Expected O, but got I
		//IL_0d06: Expected O, but got I4
		//IL_0177: Expected I, but got O
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected I4, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01ba: Expected O, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d7: Expected O, but got I4
		//IL_01e0: Expected O, but got I4
		//IL_0e9a: Expected O, but got I
		//IL_0ea2: Expected I, but got O
		//IL_0eb0: Expected I, but got O
		//IL_1175: Unknown result type (might be due to invalid IL or missing references)
		//IL_117a: Expected I, but got Unknown
		//IL_1196: Expected O, but got I4
		//IL_0ecd: Expected O, but got I4
		//IL_0dd6: Expected I, but got O
		//IL_0e01: Expected O, but got I4
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected O, but got Unknown
		//IL_06f1: Expected O, but got I4
		//IL_071f: Expected I, but got O
		//IL_0205: Expected I, but got O
		//IL_0e35: Expected O, but got I
		//IL_0e56: Expected O, but got I4
		//IL_073e: Expected O, but got I
		//IL_0752: Expected O, but got I
		//IL_021b: Expected I, but got O
		//IL_022c: Expected O, but got I
		//IL_0247: Expected I, but got O
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbf: Expected O, but got Unknown
		//IL_0fd5: Expected O, but got I
		//IL_0fdd: Expected I, but got O
		//IL_0feb: Expected I, but got O
		//IL_11d5: Expected I, but got O
		//IL_1008: Expected O, but got I4
		//IL_0efd: Expected I, but got O
		//IL_0f28: Expected O, but got I4
		//IL_027a: Expected I, but got O
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_0783: Expected O, but got I
		//IL_078b: Expected I, but got O
		//IL_0799: Expected O, but got I4
		//IL_07a1: Expected I, but got O
		//IL_0f5c: Expected O, but got I
		//IL_0f7d: Expected O, but got I4
		//IL_02aa: Expected O, but got I4
		//IL_103e: Expected O, but got I
		//IL_1046: Expected I, but got O
		//IL_1054: Expected I, but got O
		//IL_106e: Expected O, but got I4
		//IL_07d0: Expected I, but got O
		//IL_11fd: Expected O, but got I
		//IL_1228: Expected O, but got I4
		//IL_0301: Expected I, but got O
		//IL_10a9: Expected I, but got O
		//IL_10e9: Expected O, but got I4
		//IL_10f1: Expected O, but got I
		//IL_032c: Expected O, but got I4
		//IL_0360: Expected I, but got O
		//IL_08a5: Expected O, but got I4
		//IL_038a: Expected O, but got I
		//IL_03a5: Expected I, but got O
		//IL_03af: Expected I, but got O
		//IL_08ca: Expected I, but got O
		//IL_08f5: Expected O, but got I4
		//IL_03e4: Expected I, but got O
		//IL_03ee: Expected I, but got O
		//IL_0917: Expected O, but got I
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Expected O, but got Unknown
		//IL_092d: Expected O, but got I4
		//IL_095f: Expected O, but got I4
		//IL_0418: Expected O, but got I4
		//IL_0991: Expected O, but got I4
		//IL_0471: Expected I, but got O
		//IL_047b: Expected I, but got O
		//IL_09ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Expected O, but got Unknown
		//IL_09dc: Expected O, but got I4
		//IL_04a6: Expected O, but got I4
		//IL_0a31: Expected O, but got I4
		//IL_0a4a: Expected O, but got I4
		//IL_0a52: Expected I, but got O
		//IL_04da: Expected I, but got O
		//IL_04e4: Expected I, but got O
		//IL_0504: Expected O, but got I
		//IL_051f: Expected I, but got O
		//IL_0529: Expected I, but got O
		//IL_0569: Expected I, but got O
		//IL_057c: Expected I, but got O
		//IL_05a7: Expected O, but got I4
		//IL_05db: Expected I, but got O
		//IL_05ee: Expected I, but got O
		//IL_060e: Expected O, but got I
		//IL_0629: Expected I, but got O
		//IL_063c: Expected I, but got O
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected O, but got Unknown
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected O, but got Unknown
		//IL_069b: Expected O, but got I4
		//IL_06ae: Expected I, but got O
		//IL_06c5: Expected I, but got O
		base.Init();
		SpriteRenderer[] array = playingCardsSprites;
		bool flag = playingCardsSprites == null;
		Vector3 vector = default(Vector3);
		nint num = (nint)vector;
		KGame kGame = (KGame)152993792;
		object obj = default(object);
		Component component = default(Component);
		Transform transform;
		nint num6 = default(nint);
		if (!flag)
		{
			int num2 = typeof(SqlSingle[]) + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			kGame = (KGame)(this + 192);
			int num3 = default(int);
			kGame = (KGame)num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X20_v3 (KGame)-48]");
			array = (SpriteRenderer[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X20_v3 (KGame)-48]");
			bool flag2 = (nint)0 == 0;
			num = (nint)vector;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				num2 = this + 200;
				int value = default(int);
				((int*)num2)->m_value = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X21_v2 (System.Int32)-68]");
				bool flag3 = (nint)0 == 0;
				num = (nint)vector;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X21_v2 (System.Int32)-68]");
					Vector3 localScale = ((Transform)0).localScale;
					_originalPlayingCardsScale = vector;
					bool flag4 = (object)eatingsParent == null;
					num = (nint)vector;
					if (!flag4)
					{
						Vector3 localPosition = eatingsParent.localPosition;
						_originalEatingCardsParentPosition = vector;
						array = playingCardsSprites;
						bool flag5 = playingCardsSprites == null;
						num = (nint)vector;
						if (!flag5)
						{
							num2 = typeof(TypeConverter<ushort, char>) + 3976;
							obj = typeof(MemberAchievementClanFeedData) + 2976;
							object obj2 = (nint)0 + (nint)680;
							object obj3 = typeof(SqlSingle[]) + 2376;
							transform = (Transform)40;
							component = (Component)4;
							object obj6 = default(object);
							int num7 = default(int);
							int num14 = default(int);
							while (true)
							{
								nint num4 = (nint)(component - 4);
								bool flag6 = num4 < array.Length;
								object obj4 = !flag6;
								if (num4 < array.Length)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v47 (UnityEngine.SpriteRenderer[])+v267 @ X22_v14 (UnityEngine.Component)*8]");
									bool flag7 = (nint)0 == 0;
									num = (nint)vector;
									if (flag7)
									{
										break;
									}
									nint num5 = (nint)kGame;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v47 (UnityEngine.SpriteRenderer[])+v267 @ X22_v14 (UnityEngine.Component)*8]");
									Transform transform2 = ((Component)0).transform;
									bool flag8 = (object)transform2 == null;
									num = (nint)vector;
									if (flag8)
									{
										break;
									}
									Vector3 localPosition2 = transform2.localPosition;
									bool flag9 = (object)kGame == null;
									num = (nint)vector;
									if (flag9)
									{
										break;
									}
									nint intPtr = num4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X28_v5 (Il2CppClass<KGame>)+18]");
									bool flag10 = intPtr < 0;
									obj4 = !flag10;
									if (obj4 == null)
									{
										object obj5 = (object)kGame + (object)transform;
										obj5 = obj6;
										array = playingCardsSprites;
										bool flag11 = playingCardsSprites == null;
										num = (nint)vector;
										if (flag11)
										{
											break;
										}
										bool flag12 = num4 < array.Length;
										obj4 = !flag12;
										if (obj4 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v47 (UnityEngine.SpriteRenderer[])+v267 @ X22_v14 (UnityEngine.Component)*8]");
											bool flag13 = (nint)0 == 0;
											num = (nint)vector;
											if (flag13)
											{
												break;
											}
											Vector3[] originalEatingCardsTransformsRotations = _originalEatingCardsTransformsRotations;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v47 (UnityEngine.SpriteRenderer[])+v267 @ X22_v14 (UnityEngine.Component)*8]");
											Transform transform3 = ((Component)0).transform;
											bool flag14 = (object)transform3 == null;
											num = (nint)vector;
											num5 = (nint)_originalEatingCardsTransformsRotations;
											if (flag14)
											{
												break;
											}
											Vector3 localEulerAngles = transform3.localEulerAngles;
											bool flag15 = _originalEatingCardsTransformsRotations == null;
											num = (nint)vector;
											num5 = (nint)_originalEatingCardsTransformsRotations;
											if (flag15)
											{
												break;
											}
											bool flag16 = num4 < originalEatingCardsTransformsRotations.Length;
											obj4 = !flag16;
											if (obj4 == null)
											{
												object obj7 = (object)_originalEatingCardsTransformsRotations + (object)transform;
												obj7 = obj6;
												array = eatingCardsSprites;
												bool flag17 = eatingCardsSprites == null;
												num = (nint)vector;
												num5 = (nint)_originalEatingCardsTransformsRotations;
												if (flag17)
												{
													break;
												}
												bool flag18 = num4 < array.Length;
												obj4 = !flag18;
												if (obj4 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v47 (UnityEngine.SpriteRenderer[])+v267 @ X22_v14 (UnityEngine.Component)*8]");
													bool flag19 = (nint)0 == 0;
													num = (nint)vector;
													num5 = (nint)_originalEatingCardsTransformsRotations;
													if (flag19)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v47 (UnityEngine.SpriteRenderer[])+v267 @ X22_v14 (UnityEngine.Component)*8]");
													GameObject gameObject = ((Component)0).gameObject;
													bool flag20 = (object)gameObject == null;
													num = (nint)vector;
													num5 = (nint)_originalEatingCardsTransformsRotations;
													if (flag20)
													{
														break;
													}
													gameObject.SetActive(value: false);
													array = playingCardsSprites;
													bool flag21 = playingCardsSprites == null;
													num = (nint)vector;
													num6 = 0;
													num5 = (nint)_originalEatingCardsTransformsRotations;
													if (flag21)
													{
														break;
													}
													bool flag22 = num4 < array.Length;
													obj4 = !flag22;
													if (obj4 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v47 (UnityEngine.SpriteRenderer[])+v267 @ X22_v14 (UnityEngine.Component)*8]");
														bool flag23 = (nint)0 == 0;
														num = (nint)vector;
														num6 = 0;
														num5 = (nint)_originalEatingCardsTransformsRotations;
														if (flag23)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v47 (UnityEngine.SpriteRenderer[])+v267 @ X22_v14 (UnityEngine.Component)*8]");
														GameObject gameObject2 = ((Component)0).gameObject;
														bool flag24 = (object)gameObject2 == null;
														num = (nint)vector;
														num6 = 0;
														num5 = (nint)_originalEatingCardsTransformsRotations;
														if (flag24)
														{
															break;
														}
														gameObject2.SetActive(value: false);
														array = playingCardsSprites;
														component = (Component)(component + 1);
														transform = (Transform)(transform + 12);
														bool flag25 = playingCardsSprites == null;
														object obj8 = !flag25;
														num6 = 0;
														num5 = (nint)_originalEatingCardsTransformsRotations;
														if (obj8 == null)
														{
															num = (nint)vector;
															num6 = 0;
															break;
														}
														continue;
													}
												}
											}
										}
									}
									goto IL_1119;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
								kGame = (KGame)(this + 160);
								kGame = (KGame)num7;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X20_v3 (KGame)-38]");
								bool flag26 = (nint)0 == 0;
								num = (nint)vector;
								if (flag26)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X20_v3 (KGame)-38]");
								Transform transform4 = ((Component)0).transform;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
								array = (SpriteRenderer[])0;
								bool flag27 = (object)transform4 == null;
								num = (nint)vector;
								num2 = 146599936;
								if (flag27)
								{
									break;
								}
								object obj9 = typeof(UsageHint) + 816;
								object obj10 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v53+B8]");
								array = (SpriteRenderer[])0;
								num = (nint)array;
								transform4.localScale = (Vector3)0;
								num4 = (nint)kGame;
								bool flag28 = (object)kGame == null;
								num2 = 146599936;
								if (flag28)
								{
									break;
								}
								nint num8 = (nint)kGame;
								nint num9 = num6;
								Transform transform5 = transform;
								int num10 = 0;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X27_v9 (Il2CppClass<KGame>)+18]");
									array = (SpriteRenderer[])0;
									component = eatingCountTemplate;
									int num11 = num10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X27_v9 (Il2CppClass<KGame>)+18]");
									bool flag29 = (nint)num11 < (nint)0;
									obj4 = !flag29;
									int num12 = num10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X27_v9 (Il2CppClass<KGame>)+18]");
									bool flag30 = (nint)num12 >= (nint)0;
									num6 = num9;
									transform = transform5;
									num2 = num10;
									if (flag30)
									{
										break;
									}
									bool flag31 = (object)eatingCountTemplate == null;
									num6 = num9;
									transform = transform5;
									num2 = num10;
									if (flag31)
									{
										goto end_IL_116c;
									}
									Transform transform6 = eatingCountTemplate.transform;
									bool flag32 = (object)transform6 == null;
									num6 = num9;
									transform = transform5;
									num2 = num10;
									if (flag32)
									{
										goto end_IL_116c;
									}
									Transform parent = transform6.parent;
									object obj11 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X0_v70+E4]");
									bool flag33 = (nint)0 == 0;
									object obj12 = !flag33;
									if (obj12 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									num6 = (nint)obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
									int num13 = num10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X27_v9 (Il2CppClass<KGame>)+18]");
									bool flag34 = (nint)num13 < (nint)0;
									obj4 = !flag34;
									if (obj4 == null)
									{
										object obj13 = num8 + num10;
										object obj14 = obj13 + 32;
										obj14 = num14;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										array = (SpriteRenderer[])(object)kGame;
										bool flag35 = (object)kGame == null;
										transform = parent;
										component = (Component)num10;
										num2 = num10;
										if (flag35)
										{
											goto end_IL_116c;
										}
										bool flag36 = num10 < array.Length;
										obj4 = !flag36;
										if (obj4 == null)
										{
											array = (SpriteRenderer[])(array + num10);
											bool flag37 = (object)array[0] == null;
											transform = parent;
											component = (Component)num10;
											num2 = num10;
											if (flag37)
											{
												goto end_IL_116c;
											}
											array[0].sortingOrder = num10;
											num2 = num10 + 1;
											bool flag38 = (object)kGame == null;
											object obj15 = !flag38;
											num6 = 0;
											transform = parent;
											component = (Component)num10;
											num8 = (nint)kGame;
											num9 = 0;
											transform5 = parent;
											num10 = num2;
											if (obj15 == null)
											{
												goto end_IL_116c;
											}
											continue;
										}
									}
									goto IL_1119;
								}
								goto IL_0a88;
								IL_1119:
								throw new IndexOutOfRangeException();
								continue;
								end_IL_116c:
								break;
							}
						}
					}
				}
			}
		}
		goto IL_0a7a;
		IL_0a88:
		if ((object)component == null)
		{
			goto IL_0a7a;
		}
		GameObject obj16 = component.gameObject;
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v6+E4]");
		Component component2;
		nint num15;
		nint num16;
		if ((nint)0 != 0)
		{
			UnityEngine.Object.Destroy(obj16);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE5]");
			object obj18 = (nint)0 & (nint)1;
			bool flag39 = obj18 == null;
			component2 = (Component)152993792;
			num15 = unchecked((nint)null);
			component = (Component)152993792;
			num16 = unchecked((nint)null);
			if (!flag39)
			{
				goto IL_0b38;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(obj16);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE5]");
			object obj19 = (nint)0 & (nint)1;
			bool flag40 = obj19 == null;
			object obj20 = !flag40;
			component2 = (Component)152993792;
			num15 = unchecked((nint)null);
			component = (Component)152993792;
			num16 = unchecked((nint)null);
			if (obj20 != null)
			{
				goto IL_0b38;
			}
		}
		_ = 1;
		Transform transform7 = (Transform)(typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328);
		KGame game = _game;
		bool flag41 = (object)_game == null;
		component2 = component;
		transform = transform7;
		kGame = _game;
		if (!flag41)
		{
			goto IL_0c76;
		}
		goto IL_0d4c;
		IL_0fab:
		object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		array = (SpriteRenderer[])((nint)0 + (nint)3320);
		num6 = (nint)array;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)array);
		bool flag42 = (object)kGame == null;
		object obj22 = 0;
		if (!flag42)
		{
			kGame.OnGameEnd += action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			array = (SpriteRenderer[])((nint)0 + (nint)3344);
			num6 = (nint)array;
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)array);
			bool flag43 = (object)gameEventChannel == null;
			obj22 = 0;
			kGame = (KGame)(object)gameEventChannel;
			if (!flag43)
			{
				gameEventChannel.ShowUi += action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num17 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v23 (Il2CppClass<CardGameVisualControls>)+210]");
				num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v23 (Il2CppClass<CardGameVisualControls>)+210]");
				Action action3 = default(Action);
				action3..ctor(this, (IntPtr)0);
				bool flag44 = (object)gameEventChannel == null;
				obj22 = 0;
				array = (SpriteRenderer[])num17;
				kGame = (KGame)(object)gameEventChannel;
				if (!flag44)
				{
					gameEventChannel.HideUi += action3;
					return;
				}
			}
		}
		goto IL_0a7a;
		IL_0d4c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num18 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v8 (Il2CppClass<CardGameVisualControls>)+1F0]");
		num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v8 (Il2CppClass<CardGameVisualControls>)+1F0]");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)0);
		bool flag45 = (object)kGame == null;
		obj22 = 0;
		array = (SpriteRenderer[])num18;
		if (flag45)
		{
			goto IL_0a7a;
		}
		kGame.OnGameStateUpdated += action4;
		kGame = _game;
		bool flag46 = (object)_game == null;
		Action action5 = action4;
		if (flag46)
		{
			goto IL_0e84;
		}
		action5 = (Action)(object)transform;
		nint num19 = (nint)kGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v29 (Il2CppClass<KGame>)+130]");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X1_v8 (System.Action)+130]");
		bool flag47 = num20 < 0;
		object obj23 = !flag47;
		object obj24 = ~obj23;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v29 (Il2CppClass<KGame>)+C8]");
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X1_v8 (System.Action)+130]");
			object obj25 = num21 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v31-8]");
			bool flag48 = 0 < (nint)action5;
			object obj4 = !flag48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v31-8]");
			if (0 == (nint)action5)
			{
				goto IL_0e84;
			}
		}
		goto IL_1124;
		IL_1124:
		throw new InvalidCastException();
		IL_0b38:
		transform7 = (Transform)(typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328);
		game = _game;
		bool flag49 = (object)_game == null;
		object obj26 = !flag49;
		if (obj26 != null)
		{
			goto IL_0c76;
		}
		transform = transform7;
		component = component2;
		num16 = num15;
		kGame = _game;
		goto IL_0d4c;
		IL_0c76:
		num16 = (nint)transform7;
		nint num22 = (nint)game;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v35 (Il2CppClass<KGame>)+130]");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X1_v5 (Il2CppClass<UnityEngine.Transform>)+130]");
		bool flag50 = num23 < 0;
		object obj27 = !flag50;
		object obj28 = ~obj27;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v35 (Il2CppClass<KGame>)+C8]");
			nint num24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X1_v5 (Il2CppClass<UnityEngine.Transform>)+130]");
			object obj29 = num24 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v37-8]");
			bool flag51 = 0 < num16;
			object obj4 = !flag51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v37-8]");
			bool flag30 = 0 != num16;
			transform = transform7;
			component = component2;
			kGame = game;
			if (!flag30)
			{
				goto IL_0d4c;
			}
		}
		goto IL_1124;
		IL_0e84:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		array = (SpriteRenderer[])((nint)0 + (nint)3328);
		num6 = (nint)array;
		Action action6 = default(Action);
		action6..ctor(this, (IntPtr)array);
		bool flag52 = (object)kGame == null;
		obj22 = 0;
		if (flag52)
		{
			goto IL_0a7a;
		}
		kGame.OnRoundEnd += action6;
		kGame = _game;
		bool flag53 = (object)_game == null;
		Action action7 = action6;
		if (flag53)
		{
			goto IL_0fab;
		}
		action7 = (Action)(object)transform;
		nint num25 = (nint)kGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v24 (Il2CppClass<KGame>)+130]");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X1_v11 (System.Action)+130]");
		bool flag54 = num26 < 0;
		object obj30 = !flag54;
		object obj31 = ~obj30;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v24 (Il2CppClass<KGame>)+C8]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X1_v11 (System.Action)+130]");
			object obj32 = num27 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v26-8]");
			bool flag55 = 0 < (nint)action7;
			object obj4 = !flag55;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v26-8]");
			if (0 == (nint)action7)
			{
				goto IL_0fab;
			}
		}
		goto IL_1124;
		IL_0a7a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0a88;
	}

	protected unsafe virtual void Update()
	{
		//IL_05f9: Invalid comparison between F4 and I4
		//IL_0042: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_063b: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_036f: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_03c2: Expected F4, but got I4
		//IL_014c: Expected F4, but got I4
		//IL_0674: Invalid comparison between F4 and I4
		//IL_0685: Expected O, but got I4
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected O, but got Unknown
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected O, but got Unknown
		//IL_013e: Expected F4, but got I4
		//IL_05be: Expected O, but got I
		//IL_05be: Expected O, but got I
		//IL_03b4: Expected F4, but got I4
		//IL_06d5: Expected O, but got Ref
		//IL_06ed: Expected O, but got Ref
		//IL_01bf: Expected O, but got I
		//IL_01bf: Expected O, but got I
		//IL_04eb: Expected O, but got I
		//IL_04eb: Expected O, but got I
		//IL_04eb: Expected O, but got I
		//IL_04eb: Expected O, but got I
		//IL_02c0: Expected O, but got I
		//IL_02c0: Expected O, but got I
		float deltaTime = Time.deltaTime;
		float updateBufferTime = _updateBufferTime + deltaTime;
		_updateBufferTime = updateBufferTime;
		float num;
		if (_pauseUntil < 0f)
		{
			List<object> actionsBuffer = (List<object>)(object)_actionsBuffer;
			if (actionsBuffer._size < 1)
			{
				return;
			}
			object obj = (nint)0 + (nint)1240;
			object obj2 = actionsBuffer.get_Item(0);
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v9 (System.Object)+40]");
			if ((UnityEngine.Object)0 != null)
			{
				object obj6 = ((List<object>)(object)_actionsBuffer).get_Item(0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v53 (System.Object)+18]");
				bool isMe = ((KPlayer)0).IsMe;
				object obj7 = ((List<object>)(object)_actionsBuffer).get_Item(0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v57 (System.Object)+50]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj9 = ~obj8;
				num = ((obj9 != null) ? 1.0586423E+09f : 1.0670309E+09f);
				float num2 = _updateBufferTime - _lastActionPlayedTime;
				float num3 = num2 - num;
				bool flag3 = num3 < 0f;
				object obj10 = !flag3;
				object obj11 = obj10 | isMe;
				object obj12 = obj11 & 1;
				if (obj12 != null)
				{
					object obj13 = ((List<object>)(object)_actionsBuffer).get_Item(0);
					object obj14 = ((List<object>)(object)_actionsBuffer).get_Item(0);
					object obj15 = ((List<object>)(object)_actionsBuffer).get_Item(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					CardGameVisualControls cardGameVisualControls = default(CardGameVisualControls);
					object obj16 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref cardGameVisualControls, 8));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref cardGameVisualControls, 16));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v61 (System.Object)+40]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v63 (System.Object)+48]");
					TweenCardEating((Transform)num4, (Sprite)0);
					_isLastActionInBufferPlayCard = false;
					_lastActionPlayedTime = _updateBufferTime;
					((List<object>)(object)_actionsBuffer).RemoveAt(0);
					List<object> actionsBuffer2 = (List<object>)(object)_actionsBuffer;
					if (actionsBuffer2._size >= 1)
					{
						object obj18 = actionsBuffer2.get_Item(0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v75 (System.Object)+58]");
						if ((nint)0 != 0)
						{
							Hand hand = base.hand;
							object obj19 = ((List<object>)(object)_actionsBuffer).get_Item(0);
							object obj20 = ((List<object>)(object)_actionsBuffer).get_Item(0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v79 (System.Object)+58]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v81 (System.Object)+60]");
							hand.ShowActualHandCards((List<Card>)num5, (List<Card>)0, animateNow: true);
							<Update>g__ProgressActionsBuffer|68_2();
							Hand hand2 = base.hand;
							hand2.DoPendingAction();
						}
					}
					return;
				}
			}
			else
			{
				object obj21 = ((List<object>)(object)_actionsBuffer).get_Item(0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v16 (System.Object)+10]");
				if ((nint)0 == 0)
				{
					object obj22 = ((List<object>)(object)_actionsBuffer).get_Item(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v18 (System.Object)+58]");
					if ((nint)0 != 0)
					{
						Hand hand3 = base.hand;
						object obj23 = ((List<object>)(object)_actionsBuffer).get_Item(0);
						object obj24 = ((List<object>)(object)_actionsBuffer).get_Item(0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v22 (System.Object)+58]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v24 (System.Object)+60]");
						hand3.ShowActualHandCards((List<Card>)num6, (List<Card>)0, animateNow: true);
						<Update>g__ProgressActionsBuffer|68_2();
					}
					return;
				}
				object obj25 = ((List<object>)(object)_actionsBuffer).get_Item(0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v27 (System.Object)+18]");
				float num7 = ((!((KPlayer)0).IsMe || !_isLastActionInBufferPlayCard) ? 1.03683194E+09f : 1.0502537E+09f);
				float num8 = _updateBufferTime - _lastActionPlayedTime;
				bool flag4 = num8 < num7;
				num = num7;
				if (!flag4)
				{
					object obj26 = ((List<object>)(object)_actionsBuffer).get_Item(0);
					object obj27 = ((List<object>)(object)_actionsBuffer).get_Item(0);
					object obj28 = ((List<object>)(object)_actionsBuffer).get_Item(0);
					object obj29 = ((List<object>)(object)_actionsBuffer).get_Item(0);
					object obj30 = ((List<object>)(object)_actionsBuffer).get_Item(0);
					object obj31 = ((List<object>)(object)_actionsBuffer).get_Item(0);
					object obj32 = ((List<object>)(object)_actionsBuffer).get_Item(0);
					object obj33 = ((List<object>)(object)_actionsBuffer).get_Item(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v31 (System.Object)+10]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v33 (System.Object)+18]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v35 (System.Object)+20]");
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v37 (System.Object)+28]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v39 (System.Object)+29]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v41 (System.Object)+2C]");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v43 (System.Object)+34]");
					PlayCard((Card)num9, (CardGamePlayer)num10, (Transform)num11, (byte)num12 != 0, (byte)num13 != 0, (int?)(object)num14, 0, playImmediately: false, hideStartingPoint: false);
					_isLastActionInBufferPlayCard = true;
					_lastActionPlayedTime = _updateBufferTime;
					((List<object>)(object)_actionsBuffer).RemoveAt(0);
					return;
				}
			}
		}
		else
		{
			float deltaTime2 = Time.deltaTime;
			num = _pauseUntil - deltaTime2;
		}
		_pauseUntil = num;
	}

	protected virtual void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_008b: Expected I, but got O
		//IL_0048: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		gameEventChannel.ShowUi -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v4 (Il2CppClass<CardGameVisualControls>)+210]");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)0);
		gameEventChannel.HideUi -= action2;
	}

	protected virtual void OnGameStateUpdated()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_00f7: Expected I, but got O
		//IL_0120: Expected O, but got I4
		//IL_0154: Expected O, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01a4: Expected I, but got O
		//IL_01cd: Expected O, but got I4
		//IL_0201: Expected O, but got I
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_02f1: Expected O, but got I4
		KGame game = _game;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
		object obj2 = obj;
		nint num = (nint)game;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<KGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X1_v3+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<KGame>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X1_v3+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v8-8]");
			if (0 == (nint)obj2)
			{
				bool isSpectator = game.IsSpectator;
				bool flag2 = !isSpectator;
				object obj6 = !flag2;
				if (obj6 != null)
				{
					return;
				}
				KGame game2 = _game;
				object obj7 = obj;
				nint num4 = (nint)game2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v13 (Il2CppClass<KGame>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X1_v7+130]");
				bool flag3 = num5 < 0;
				object obj8 = !flag3;
				object obj9 = ~obj8;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v13 (Il2CppClass<KGame>)+C8]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X1_v7+130]");
					object obj10 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v15-8]");
					if (0 == (nint)obj7)
					{
						KPlayer myPlayer = game2.MyPlayer;
						object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 352;
						object obj12 = obj11;
						nint num7 = (nint)myPlayer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v21 (Il2CppClass<KPlayer>)+130]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X1_v9+130]");
						bool flag4 = num8 < 0;
						object obj13 = !flag4;
						object obj14 = ~obj13;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v21 (Il2CppClass<KPlayer>)+C8]");
							nint num9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X1_v9+130]");
							object obj15 = num9 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v23-8]");
							if (0 == (nint)obj12)
							{
								if (((CardGamePlayer)myPlayer).CanEat)
								{
									object obj16 = typeof(SqlSingle[]) + 3912;
									object obj17 = obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v27+E4]");
									bool flag5 = (nint)0 == 0;
									object obj18 = !flag5;
									if (obj18 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									AnimationExtensions.AnimPulsing(playingParent, 0.4f, 1.01f, 1.6f);
								}
								return;
							}
						}
						goto IL_0277;
					}
				}
				throw new InvalidCastException();
			}
		}
		goto IL_0277;
		IL_0277:
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	private void OnGameEnd(ISFSObject _)
	{
		ResetGameGround();
	}

	private void OnRoundEnd()
	{
		ResetGameGround();
		List<CardAction> actionsBuffer = _actionsBuffer;
		int version = actionsBuffer._version + 1;
		actionsBuffer._size = 0;
		actionsBuffer._version = version;
		if (actionsBuffer._size >= 1)
		{
			Array.Clear(actionsBuffer._items, 0, actionsBuffer._size);
		}
		_lastActionPlayedTime = 0f;
		_updateBufferTime = 0f;
	}

	public bool IsTooEarlyToPlayCard()
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
		object obj = 152993792;
		object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3984;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AAD]");
		object obj3 = (nint)0 & (nint)1;
		List<CardAction> list;
		List<CardAction> list2;
		object obj4;
		if (obj3 != null)
		{
			list = _actionsBuffer;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			list2 = _actionsBuffer;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			list = _actionsBuffer;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			list2 = _actionsBuffer;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v4+8]");
		Predicate<object> match = (Predicate<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v4+8]");
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
		return (byte)(int)ex != 0;
		IL_010b:
		return list3.Exists(match);
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v4+8]");
		match = (Predicate<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v4+8]");
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
		object obj11 = typeof(List<Tween>) + 3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)2464;
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj7, (IntPtr)obj12);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v9+B8]");
		object obj14 = (nint)0 + (nint)8;
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

	private unsafe void AddPlayedCardToActionsBuffer(Card card, CardGamePlayer player, Transform startingPoint, bool isEventFromServer, bool withCollision, int? gameActionId, int floorLayer, bool hideStartingPoint)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0061: Expected O, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		object obj2 = default(object);
		object obj = (object)(&obj2);
		List<object> actionsBuffer = (List<object>)(object)_actionsBuffer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		CardAction cardAction = CardAction.InitCardPlay(card, player, startingPoint, isEventFromServer, withCollision, gameActionId, floorLayer, hideStartingPoint: false);
		int version = actionsBuffer._version + 1;
		actionsBuffer._version = version;
		object[] items = actionsBuffer._items;
		bool flag = actionsBuffer._size < items.Length;
		object obj3 = !flag;
		if (obj3 == null)
		{
			int size = actionsBuffer._size + 1;
			actionsBuffer._size = size;
			object obj4 = items + actionsBuffer._size;
			object obj5 = obj4 + 32;
			obj5 = cardAction;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			actionsBuffer.AddWithResize((object)cardAction);
		}
	}

	private void AddEatingToActionsBuffer(CardGamePlayer player, Transform eatingPoint, Sprite cardback, bool isLastEating)
	{
		//IL_0059: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		List<object> actionsBuffer = (List<object>)(object)_actionsBuffer;
		CardAction cardAction = CardAction.InitEating(player, eatingPoint, cardback, isLastEating);
		int version = actionsBuffer._version + 1;
		actionsBuffer._version = version;
		object[] items = actionsBuffer._items;
		bool flag = actionsBuffer._size < items.Length;
		object obj = !flag;
		if (obj == null)
		{
			int size = actionsBuffer._size + 1;
			actionsBuffer._size = size;
			object obj2 = items + actionsBuffer._size;
			object obj3 = obj2 + 32;
			obj3 = cardAction;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			actionsBuffer.AddWithResize((object)cardAction);
		}
	}

	public void AddReorganizeHandToActionsBuffer(List<Card> allCards, List<Card> playableCards)
	{
		//IL_0059: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		List<object> actionsBuffer = (List<object>)(object)_actionsBuffer;
		CardAction cardAction = CardAction.InitReorganizeHand(allCards, playableCards);
		int version = actionsBuffer._version + 1;
		actionsBuffer._version = version;
		object[] items = actionsBuffer._items;
		bool flag = actionsBuffer._size < items.Length;
		object obj = !flag;
		if (obj == null)
		{
			int size = actionsBuffer._size + 1;
			actionsBuffer._size = size;
			object obj2 = items + actionsBuffer._size;
			object obj3 = obj2 + 32;
			obj3 = cardAction;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			actionsBuffer.AddWithResize((object)cardAction);
		}
	}

	public unsafe virtual void PlayCard(Card card, CardGamePlayer player, Transform startingPoint, bool isEventFromServer, bool withCollision, int? gameActionId, int floorLayer, bool playImmediately, bool hideStartingPoint)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0418: Expected O, but got Ref
		//IL_0430: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		//IL_003b: Expected O, but got I
		//IL_0055: Expected O, but got I4
		//IL_01db: Expected O, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_008c: Expected I, but got O
		//IL_00b5: Expected O, but got I4
		//IL_00e9: Expected O, but got I
		//IL_0137: Expected O, but got I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_033c: Expected I, but got O
		//IL_0365: Expected O, but got I4
		//IL_027f: Expected I, but got O
		//IL_02a8: Expected O, but got I4
		//IL_0399: Expected O, but got I
		//IL_02dc: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<>c__DisplayClass77_0 <>c__DisplayClass77_ = default(<>c__DisplayClass77_0);
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref <>c__DisplayClass77_, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref <>c__DisplayClass77_, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref <>c__DisplayClass77_, 24));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		object obj6 = (nint)0 & (nint)1;
		bool flag = obj6 == null;
		object obj7 = !flag;
		int num7;
		if (obj7 == null)
		{
			KGame game = _game;
			object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
			object obj9 = obj8;
			nint num = (nint)game;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v10 (Il2CppClass<KGame>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X1_v10+130]");
			bool flag2 = num2 < 0;
			object obj10 = !flag2;
			object obj11 = ~obj10;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v10 (Il2CppClass<KGame>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X1_v10+130]");
				object obj12 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v13-8]");
				if (0 == (nint)obj9)
				{
					bool isReplay = game.IsReplay;
					bool flag3 = !isReplay;
					object obj13 = !flag3;
					if (obj13 != null)
					{
						goto IL_01af;
					}
					object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v23+E4]");
					if ((nint)0 != 0)
					{
						Games currentGame = Preferences.CurrentGame;
						if (currentGame == Games.Jackaroo)
						{
							goto IL_01af;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Games currentGame2 = Preferences.CurrentGame;
						if (currentGame2 == Games.Jackaroo)
						{
							goto IL_01af;
						}
					}
					if (isEventFromServer)
					{
						CardGame game2 = (CardGame)_game;
						object obj16 = obj8;
						nint num4 = (nint)game2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v30 (Il2CppClass<CardGame>)+130]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X1_v16+130]");
						bool flag4 = num5 < 0;
						object obj17 = !flag4;
						object obj18 = ~obj17;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v30 (Il2CppClass<CardGame>)+C8]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X1_v16+130]");
							object obj19 = num6 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v32-8]");
							if (0 == (nint)obj16)
							{
								List<Card> cardsOnFloor = game2.CardsOnFloor;
								num7 = cardsOnFloor._size;
								goto IL_045d;
							}
						}
					}
					else
					{
						CardGame game3 = (CardGame)_game;
						object obj20 = obj8;
						nint num8 = (nint)game3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v23 (Il2CppClass<CardGame>)+130]");
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X1_v15+130]");
						bool flag5 = num9 < 0;
						object obj21 = !flag5;
						object obj22 = ~obj21;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v23 (Il2CppClass<CardGame>)+C8]");
							nint num10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X1_v15+130]");
							object obj23 = num10 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v25-8]");
							if (0 == (nint)obj20)
							{
								List<Card> cardsOnFloor2 = game3.CardsOnFloor;
								num7 = cardsOnFloor2._size + 1;
								goto IL_045d;
							}
						}
					}
				}
			}
			InvalidCastException ex = new InvalidCastException();
			throw new NullReferenceException();
		}
		goto IL_01af;
		IL_045d:
		int floorLayer2 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+11]");
		AddPlayedCardToActionsBuffer(card, player, startingPoint, isEventFromServer, withCollision, gameActionId, floorLayer2, hideStartingPoint: false);
		return;
		IL_01af:
		bool flag6 = <PlayCard>g__CustomPlayCard|77_1(gameActionId, ref <>c__DisplayClass77_);
		bool flag7 = !flag6;
		object obj24 = !flag7;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+11]");
			AnimatePlayCard(card, player, startingPoint, isEventFromServer, withCollision, floorLayer, hideStartingPoint: false);
		}
	}

	public unsafe void EatCards(CardGamePlayer player, Transform eatingPoint, Sprite cardback, bool playImmediately)
	{
		//IL_028f: Expected O, but got Ref
		//IL_02a7: Expected O, but got Ref
		//IL_001f: Expected O, but got I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0056: Expected I, but got O
		//IL_007f: Expected O, but got I4
		//IL_00b3: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_01e2: Expected O, but got I4
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		CardGameVisualControls cardGameVisualControls = default(CardGameVisualControls);
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref cardGameVisualControls, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref cardGameVisualControls, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = !playImmediately;
		object obj3 = !flag;
		if (obj3 == null)
		{
			KGame game = _game;
			object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
			object obj5 = obj4;
			nint num = (nint)game;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9 (Il2CppClass<KGame>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X1_v7+130]");
			bool flag2 = num2 < 0;
			object obj6 = !flag2;
			object obj7 = ~obj6;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9 (Il2CppClass<KGame>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X1_v7+130]");
				object obj8 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v12-8]");
				if (0 == (nint)obj5)
				{
					bool isReplay = game.IsReplay;
					bool flag3 = !isReplay;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v16+E4]");
						if ((nint)0 != 0)
						{
							Games currentGame = Preferences.CurrentGame;
							if (currentGame == Games.Jackaroo)
							{
								goto IL_0179;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							Games currentGame2 = Preferences.CurrentGame;
							if (currentGame2 == Games.Jackaroo)
							{
								goto IL_0179;
							}
						}
						List<Card> <Cards>k__BackingField = player.<Cards>k__BackingField;
						object obj12 = <Cards>k__BackingField._size - 1;
						bool flag4 = (nint)obj12 < 0;
						int num4 = <Cards>k__BackingField._size ^ 1;
						int num5 = <Cards>k__BackingField._size ^ obj12;
						int num6 = num4 & num5;
						bool flag5 = num6 < 0;
						bool flag6 = flag4 == flag5;
						bool isLastEating = !flag6;
						AddEatingToActionsBuffer(player, eatingPoint, cardback, isLastEating);
						return;
					}
					goto IL_0179;
				}
			}
			InvalidCastException ex = new InvalidCastException();
			throw new NullReferenceException();
		}
		goto IL_0179;
		IL_0179:
		TweenCardEating(eatingPoint, cardback);
	}

	public void ShowControls()
	{
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0279: Expected O, but got I4
		//IL_0092: Expected O, but got I
		//IL_00a3: Invalid comparison between O and F8
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_0016: Expected O, but got I
		//IL_0183: Expected O, but got I
		//IL_0193: Expected O, but got I
		//IL_01b5: Expected O, but got I4
		//IL_01c5: Expected O, but got I
		//IL_010b: Expected O, but got I
		//IL_011b: Expected O, but got I
		//IL_013d: Expected O, but got I4
		//IL_01f5: Expected O, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02df: Expected O, but got I
		//IL_02f0: Expected I, but got O
		//IL_030e: Expected O, but got I
		//IL_015b: Expected O, but got I
		//IL_0225: Expected O, but got I
		object obj = this + 216;
		object obj2 = obj;
		bool flag = obj == null;
		object obj3 = !flag;
		if (obj3 != null)
		{
			goto IL_005c;
		}
		if ((object)playGround != null)
		{
			object obj4 = (nint)0 + (nint)832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31D00");
			object obj5 = default(object);
			obj = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj2 = obj;
			if (obj != null)
			{
				goto IL_005c;
			}
		}
		goto IL_0237;
		IL_01d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		object obj8;
		object obj9;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v18+B8]");
			obj9 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)2496;
		Action<object> action = default(Action<object>);
		action..ctor(obj9, (IntPtr)obj11);
		object obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v17+B8]");
		object obj13 = (nint)0 + (nint)16;
		obj13 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Action<object> action2 = action;
		goto IL_02a6;
		IL_02a6:
		ArraysExtensions.ForEach((IEnumerable<object>)obj, action2);
		return;
		IL_005c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6+20]");
		if ((nint)0 == 0)
		{
			goto IL_0237;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6+20]");
		Color color = ((SpriteRenderer)0).color;
		object obj14 = default(object);
		if (obj14 >= (object)1.0)
		{
			return;
		}
		obj8 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3984;
		object obj15 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v12+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v12+10]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v12+10]");
			bool flag3 = (nint)0 == 0;
			object obj16 = !flag3;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v12+10]");
				Action<object> action3 = (Action<object>)0;
				goto IL_01d3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v12+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v12+10]");
			Action<object> action3 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v12+10]");
			bool flag4 = (nint)0 == 0;
			object obj17 = !flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v12+10]");
			action2 = (Action<object>)0;
			if (obj17 == null)
			{
				goto IL_01d3;
			}
		}
		goto IL_02a6;
		IL_0237:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	public virtual void HideControls()
	{
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01e9: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0105: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_0147: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_009a: Expected O, but got I
		//IL_00aa: Expected O, but got I
		//IL_00cc: Expected O, but got I4
		//IL_0016: Expected O, but got I
		//IL_0028: Expected O, but got I
		//IL_017f: Expected O, but got I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0221: Expected O, but got I
		//IL_0232: Expected I, but got O
		//IL_0250: Expected O, but got I
		//IL_01af: Expected O, but got I
		object obj = this + 216;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = (nint)0 + (nint)832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31D00");
			IntPtr intPtr = default(IntPtr);
			obj = (nint)intPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		object obj4 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3984;
		ResetGameGround();
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v7+E4]");
		object obj7;
		Action<object> action;
		object obj9;
		object obj6;
		if ((nint)0 != 0)
		{
			obj6 = (nint)0 + (nint)2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v7+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v8+18]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v8+18]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				obj9 = obj6;
				goto IL_015d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj4;
			obj9 = (nint)0 + (nint)2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v7+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v8+18]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v8+18]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			obj6 = obj9;
			if (obj10 == null)
			{
				goto IL_015d;
			}
		}
		goto IL_01b4;
		IL_01b4:
		ArraysExtensions.ForEach(_allGroundCards, action);
		return;
		IL_015d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v14+B8]");
			obj7 = 0;
		}
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)2456;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj7, (IntPtr)obj14);
		object obj15 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v13+B8]");
		object obj16 = (nint)0 + (nint)24;
		obj16 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj6 = obj9;
		action = action2;
		goto IL_01b4;
	}

	public void ShowWatcherControls()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)1576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E331E4");
		Userbox userbox = default(Userbox);
		userbox.ShowControls();
	}

	public void HideWatcherControls()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)1576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E331E4");
		Userbox userbox = default(Userbox);
		userbox.HideControls();
	}

	public void ShowOthersCards(int exceptPlayerIndex = 0)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I4
		Userbox[] array = allUserboxes;
		if (array.Length < 1)
		{
			return;
		}
		object obj = array + 32;
		int num = default(int);
		do
		{
			object obj2 = obj;
			obj += 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X11_v4+198]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null && num != 0)
			{
				_ = 1;
			}
			num--;
		}
		while (array.Length != 1);
	}

	public void HideOthersCards(int exceptPlayerIndex = 0)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I4
		Userbox[] array = allUserboxes;
		if (array.Length < 1)
		{
			return;
		}
		object obj = array + 32;
		int num = default(int);
		do
		{
			object obj2 = obj;
			obj += 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X10_v4+198]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null && num != 0)
			{
				_ = 0;
			}
			num--;
		}
		while (array.Length != 1);
	}

	protected unsafe virtual void AnimatePlayCard(Card card, KPlayer player, Transform startingPoint, bool isEventFromServer, bool withCollision, int floorLayer, bool hideStartingPoint)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0bbb: Expected O, but got I4
		//IL_0beb: Expected O, but got I4
		//IL_0075: Expected O, but got I4
		//IL_0c0d: Expected O, but got I4
		//IL_0067: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		//IL_0c2f: Expected O, but got I4
		//IL_0083: Expected O, but got I4
		//IL_0c51: Expected O, but got I4
		//IL_00b2: Expected I, but got O
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0178: Expected O, but got I
		//IL_01c8: Expected I, but got O
		//IL_021a: Expected O, but got I4
		//IL_0236: Expected O, but got I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Ref, but got Unknown
		//IL_02b4: Expected O, but got I4
		//IL_0ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca7: Expected O, but got Unknown
		//IL_0cbf: Expected O, but got I
		//IL_0540: Expected O, but got I
		//IL_0367: Expected O, but got I4
		//IL_0374: Expected O, but got I4
		//IL_038a: Expected O, but got I
		//IL_05c8: Expected F4, but got I4
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected O, but got Unknown
		//IL_0615: Expected O, but got I
		//IL_062f: Expected O, but got I4
		//IL_0d72: Expected I, but got O
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03d1: Expected O, but got I
		//IL_06a0: Expected O, but got I4
		//IL_04a8: Invalid comparison between F4 and I4
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected O, but got Unknown
		//IL_0709: Expected O, but got I
		//IL_0719: Expected F4, but got I
		//IL_0721: Expected F4, but got O
		//IL_0d2e: Expected O, but got F4
		//IL_07f5: Expected O, but got I4
		//IL_0832: Expected O, but got I4
		//IL_0920: Expected O, but got I4
		//IL_097d: Expected O, but got I4
		//IL_097d: Expected O, but got I4
		//IL_0dbd: Expected O, but got I4
		//IL_0dd4: Expected O, but got I4
		//IL_09da: Expected O, but got I
		//IL_09e6: Expected O, but got I
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected O, but got Unknown
		//IL_0a06: Expected O, but got I
		//IL_0a12: Expected O, but got I
		//IL_0a20: Expected O, but got I4
		//IL_0a45: Expected F4, but got O
		//IL_0a45: Expected O, but got I4
		//IL_0a82: Expected I, but got O
		//IL_0aad: Expected O, but got I4
		//IL_0ac2: Expected O, but got I
		//IL_0aeb: Expected F4, but got I
		//IL_0aeb: Expected O, but got I4
		//IL_0b00: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass85_0 <>c__DisplayClass85_ = default(<>c__DisplayClass85_0);
		<>c__DisplayClass85_..ctor();
		bool flag = (object)startingPoint == null;
		object obj2 = !flag;
		Transform transform = startingPoint;
		if (obj2 == null)
		{
			Userbox activeUserbox = GetActiveUserbox(player);
			if ((object)activeUserbox == null)
			{
				goto IL_0b79;
			}
			Transform transform2 = activeUserbox.transform;
			transform = transform2;
		}
		bool flag2 = !isEventFromServer;
		object obj3 = !flag2;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			object obj5 = 264;
		}
		else
		{
			object obj5 = 248;
		}
		object obj6 = !flag2;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
			object obj8 = 268;
		}
		else
		{
			object obj8 = 252;
		}
		object obj9 = !flag2;
		object obj10 = ~obj9;
		if (obj10 == null)
		{
		}
		object obj11 = !flag2;
		object obj12 = ~obj11;
		if (obj12 == null)
		{
		}
		int floorCardsNumber = FloorCardsNumber(floorLayer);
		object obj13;
		object obj14;
		ref Vector3 reference;
		float num4;
		object obj24;
		float num5;
		float num6;
		float num7 = default(float);
		float num8;
		float num9;
		KPlayer kPlayer;
		bool flag8;
		bool flag9;
		object obj29;
		if (<>c__DisplayClass85_ != null)
		{
			<>c__DisplayClass85_.floorCardsNumber = floorCardsNumber;
			nint num = (nint)this;
			SpriteRenderer cardSprite = GetCardSprite(player);
			obj13 = <>c__DisplayClass85_ + 40;
			obj13 = cardSprite;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj13 != null)
			{
				Transform transform3 = ((Component)obj13).transform;
				obj14 = <>c__DisplayClass85_ + 16;
				obj14 = transform3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X27_v3+18]");
				if ((nint)0 != 0)
				{
					object sortingLayerName = "HH:mm:ss.ffZ" + 656;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X27_v3+18]");
					((Renderer)0).sortingLayerName = (string)sortingLayerName;
					if (obj13 != null)
					{
						((Renderer)obj13).sortingOrder = <>c__DisplayClass85_.floorCardsNumber;
						int num2 = ShortcutExtensions.DOKill(<>c__DisplayClass85_.containerTransform, complete: true);
						nint num3 = (nint)this;
						int playerSlotIndex = GetPlayerSlotIndex(player);
						Vector3[] originalEatingCardsTransformsPositions = _originalEatingCardsTransformsPositions;
						if (_originalEatingCardsTransformsPositions != null)
						{
							bool flag3 = playerSlotIndex < originalEatingCardsTransformsPositions.Length;
							object obj15 = !flag3;
							if (obj15 != null)
							{
								goto IL_0b87;
							}
							object obj16 = playerSlotIndex * 12;
							object obj17 = (object)_originalEatingCardsTransformsPositions + obj16;
							reference = ref *(Vector3*)(<>c__DisplayClass85_ + 24);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X9_v9+20]");
							reference = ref *(Vector3*)null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X9_v9+28]");
							_ = 0;
							Vector3[] originalEatingCardsTransformsRotations = _originalEatingCardsTransformsRotations;
							if (_originalEatingCardsTransformsRotations != null)
							{
								bool flag4 = playerSlotIndex < originalEatingCardsTransformsRotations.Length;
								object obj18 = !flag4;
								if (obj18 != null)
								{
									goto IL_0b87;
								}
								object obj19 = typeof(UsageHint) + 816;
								object obj20 = obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v24+B8]");
								object obj21 = 0;
								if (isEventFromServer)
								{
									num4 = UnityEngine.Random.Range(0f, 30f);
									if ((object)<>c__DisplayClass85_.containerTransform != null)
									{
										Transform parent = <>c__DisplayClass85_.containerTransform.parent;
										if ((object)transform != null)
										{
											Vector3 position = transform.position;
											if ((object)parent != null)
											{
												Vector3 vector = parent.InverseTransformPoint((Vector3)0);
												object obj22 = 146599936;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CA]");
												object obj23 = (nint)0 & (nint)1;
												object obj26;
												if (obj23 != null)
												{
													obj24 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
													object obj25 = (nint)0 & (nint)1;
													bool flag5 = obj25 == null;
													obj26 = obj24;
													if (!flag5)
													{
														goto IL_03f6;
													}
												}
												else
												{
													_ = 1;
													obj24 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
													object obj27 = (nint)0 & (nint)1;
													bool flag6 = obj27 == null;
													object obj28 = !flag6;
													obj26 = obj24;
													if (obj28 != null)
													{
														goto IL_03f6;
													}
												}
												_ = 1;
												num5 = (float)<>c__DisplayClass85_.originalPosition - num4;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (CardGameVisualControls+<>c__DisplayClass85_0)+20]");
												num6 = 0f - num7;
												obj29 = obj26;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X0_v86+E4]");
												bool flag7 = (nint)0 == 0;
												object obj30 = !flag7;
												num8 = num5;
												num9 = num6;
												if (obj30 != null)
												{
													goto IL_045e;
												}
												goto IL_06be;
											}
										}
									}
								}
								else if ((object)transform != null)
								{
									GameObject gameObject = transform.gameObject;
									if ((object)gameObject != null)
									{
										object obj31 = (nint)0 + (nint)1856;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
										object obj32 = default(object);
										int sortingOrder2;
										if (obj32 != null)
										{
											Renderer renderer = default(Renderer);
											if ((object)renderer == null)
											{
												goto IL_0b79;
											}
											int sortingOrder = renderer.sortingOrder;
											sortingOrder2 = sortingOrder - 1;
										}
										else
										{
											sortingOrder2 = 0;
										}
										if (obj13 != null)
										{
											((Renderer)obj13).sortingOrder = sortingOrder2;
											num4 = 0f;
											kPlayer = player;
											flag8 = isEventFromServer;
											flag9 = hideStartingPoint;
											goto IL_0d6d;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0b79;
		IL_045e:
		float num10 = num5 * num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		float num11 = num6 * num6;
		float num12 = num11 + num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num13;
		float num14;
		if (num12 > 925353400f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			num13 = num5 / 925353400f;
			num14 = num6 / num12;
		}
		else
		{
			object obj33 = typeof(UsageHint) + 816;
			object obj34 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v60+B8]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v61+8]");
			num14 = 0f;
			num13 = (float)obj35;
		}
		object obj36 = default(object);
		float num15 = num13 * (float)obj36;
		float num16 = num4 * num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (CardGameVisualControls+<>c__DisplayClass85_0)+20]");
		float num17 = 0f + num16;
		float num18 = (float)<>c__DisplayClass85_.originalPosition + num15;
		<>c__DisplayClass85_.originalPosition = (Vector3)num18;
		kPlayer = player;
		flag8 = isEventFromServer;
		flag9 = hideStartingPoint;
		goto IL_0d6d;
		IL_0d6d:
		nint num19 = (nint)this;
		float originalRotation = default(float);
		AdjustOpponentCardStart(ref reference, ref *(Vector3*)(&originalRotation), transform, kPlayer, num4, flag8);
		if ((object)cardsSprites != null)
		{
			Sprite sprite = cardsSprites.GetFor(card);
			if (obj13 != null)
			{
				((SpriteRenderer)obj13).sprite = sprite;
				if (obj13 != null)
				{
					GameObject gameObject2 = ((Component)obj13).gameObject;
					if ((object)gameObject2 != null)
					{
						gameObject2.SetActive(value: true);
						Vector3 position2 = transform.position;
						if (obj14 != null)
						{
							((Transform)obj14).position = (Vector3)0;
							Vector3 eulerAngles = transform.eulerAngles;
							if (obj14 != null)
							{
								((Transform)obj14).eulerAngles = (Vector3)0;
								if (flag9)
								{
									GameObject gameObject3 = transform.gameObject;
									if ((object)gameObject3 == null)
									{
										goto IL_0b79;
									}
									gameObject3.SetActive(value: false);
								}
								if (flag8)
								{
									Vector3 serverEventStartingScale = GetServerEventStartingScale(transform);
									if (obj14 == null)
									{
										goto IL_0b79;
									}
									bool flag10 = flag8;
									float? num20 = (float?)kPlayer;
									float? num21 = (float?)transform;
									transform = (Transform)obj14;
								}
								else
								{
									if (obj14 == null)
									{
										goto IL_0b79;
									}
									((Transform)obj14).localScale = (Vector3)0;
									bool flag11 = !flag9;
									bool flag10 = flag8;
									float? num20 = (float?)kPlayer;
									float? num21 = (float?)transform;
									if (flag11)
									{
										goto IL_0987;
									}
									float? num22 = cardSlotFlingY;
									UIExtensions.MoveTo(transform, isWorldPositions: false, (float?)(object)0, num22, (float?)(object)0);
									flag10 = false;
									num20 = (float?)(object)0;
									num21 = num22;
								}
								transform.localScale = (Vector3)0;
								goto IL_0987;
							}
						}
					}
				}
			}
		}
		goto IL_0b79;
		IL_06be:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num5 = num8;
		num6 = num9;
		goto IL_045e;
		IL_0987:
		if (obj14 != null)
		{
			Transform parent2 = ((Transform)obj14).parent;
			if ((object)parent2 != null)
			{
				object obj37 = (nint)0 + (nint)2776;
				object obj38 = (nint)0 + (nint)2904;
				object obj39 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				object obj40 = (nint)0 + (nint)2504;
				object obj41 = (nint)0 + (nint)2504;
				Vector3 vector2 = parent2.TransformPoint((Vector3)0);
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOMove(<>c__DisplayClass85_.containerTransform, (Vector3)0, (float)<>c__DisplayClass85_.originalPosition);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				TweenCallback tweenCallback = default(TweenCallback);
				tweenCallback..ctor(<>c__DisplayClass85_, (IntPtr)obj40);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
				TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = ShortcutExtensions.DOLocalRotate(<>c__DisplayClass85_.containerTransform, (Vector3)0, originalRotation);
				object obj42 = (nint)0 + (nint)2840;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
				Transform containerTransform = <>c__DisplayClass85_.containerTransform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v25+C]");
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(containerTransform, (Vector3)0, 0f);
				object obj43 = (nint)0 + (nint)2896;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
				GameSoundManager instance = GameSoundManager.Instance;
				if ((object)instance != null)
				{
					instance.PlaySound(GameSoundEffect.CARD, withDelay: false);
					if (withCollision)
					{
						CardCollisionAnim((SpriteRenderer)obj13, kPlayer, flag8);
					}
					return;
				}
			}
		}
		goto IL_0b79;
		IL_03f6:
		num5 = (float)<>c__DisplayClass85_.originalPosition - num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (CardGameVisualControls+<>c__DisplayClass85_0)+20]");
		num6 = 0f - num7;
		obj29 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X0_v86+E4]");
		bool flag12 = (nint)0 == 0;
		num8 = num5;
		num9 = num6;
		if (!flag12)
		{
			goto IL_045e;
		}
		goto IL_06be;
		IL_0b87:
		throw new IndexOutOfRangeException();
		IL_0b79:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b87;
	}

	protected virtual void AdjustOpponentCardStart(ref Vector3 originalPosition, ref Vector3 originalRotation, Transform startingPoint, KPlayer player, float randSlide, bool isEventFromServer)
	{
	}

	protected virtual Vector3 GetServerEventStartingScale(Transform startingPoint)
	{
		return (Vector3)this;
	}

	protected virtual Vector3 GetCardRestingLocalPosition(KPlayer player)
	{
		//IL_0018: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		Vector3[] originalEatingCardsTransformsPositions = _originalEatingCardsTransformsPositions;
		Vector3 vector = (Vector3)GetPlayerSlotIndex(player);
		if (_originalEatingCardsTransformsPositions != null)
		{
			bool flag = (nint)vector < originalEatingCardsTransformsPositions.Length;
			object obj = !flag;
			if (obj == null)
			{
				return vector;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (Vector3)new IndexOutOfRangeException();
	}

	public Vector3 GetCardLandingWorldPosition(KPlayer player)
	{
		//IL_006e: Expected O, but got I4
		//IL_0130: Expected O, but got I4
		SpriteRenderer cardSprite = GetCardSprite(player);
		Vector3 cardRestingLocalPosition = GetCardRestingLocalPosition(player);
		Vector3[] originalEatingCardsTransformsRotations = _originalEatingCardsTransformsRotations;
		int playerSlotIndex = GetPlayerSlotIndex(player);
		if (_originalEatingCardsTransformsRotations != null)
		{
			bool flag = playerSlotIndex < originalEatingCardsTransformsRotations.Length;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_0147;
			}
			if ((object)cardSprite != null)
			{
				Transform startingPoint = cardSprite.transform;
				Vector3 originalPosition = default(Vector3);
				Vector3 originalRotation = default(Vector3);
				AdjustOpponentCardStart(ref originalPosition, ref originalRotation, startingPoint, player, 0f, isEventFromServer: false);
				Transform transform = cardSprite.transform;
				if ((object)transform != null)
				{
					Transform parent = transform.parent;
					if ((object)parent != null)
					{
						return parent.TransformPoint((Vector3)0);
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0147;
		IL_0147:
		return (Vector3)new IndexOutOfRangeException();
	}

	protected virtual int GetPlayerSlotIndex(KPlayer player)
	{
		//IL_0016: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0136: Expected I, but got O
		//IL_015f: Expected O, but got I4
		//IL_0217: Expected I4, but got O
		//IL_0193: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AEC]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE5]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE5]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		KGame game = _game;
		if ((object)_game != null)
		{
			goto IL_0112;
		}
		goto IL_0209;
		IL_0209:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0112:
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
		object obj6 = obj5;
		nint num = (nint)game;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6 (Il2CppClass<KGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X1_v2+130]");
		bool flag2 = num2 < 0;
		object obj7 = !flag2;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6 (Il2CppClass<KGame>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X1_v2+130]");
			object obj9 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v9-8]");
			if (0 == (nint)obj6)
			{
				List<KPlayer> players = game.Players;
				if (players != null)
				{
					return ((List<object>)(object)players).IndexOf((object)player);
				}
				goto IL_0209;
			}
		}
		InvalidCastException ex2 = new InvalidCastException();
		goto IL_0209;
		IL_0066:
		game = _game;
		bool flag3 = (object)_game == null;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_0112;
		}
		goto IL_0209;
	}

	protected virtual int FloorCardsNumber(int floorLayer)
	{
		//IL_0016: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0136: Expected I, but got O
		//IL_015f: Expected O, but got I4
		//IL_02db: Expected I4, but got O
		//IL_0193: Expected O, but got I
		//IL_01fd: Expected I, but got O
		//IL_0226: Expected O, but got I4
		//IL_025a: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AED]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE5]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE5]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		KGame game = _game;
		if ((object)_game != null)
		{
			goto IL_0112;
		}
		goto IL_02cd;
		IL_02cd:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_02db:
		int result;
		return result;
		IL_0112:
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
		object obj6 = obj5;
		nint num = (nint)game;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4 (Il2CppClass<KGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X1_v2+130]");
		bool flag2 = num2 < 0;
		object obj7 = !flag2;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4 (Il2CppClass<KGame>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X1_v2+130]");
			object obj9 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v7-8]");
			if (0 == (nint)obj6)
			{
				bool isReplay = game.IsReplay;
				bool flag3 = !isReplay;
				result = floorLayer;
				if (flag3)
				{
					goto IL_02db;
				}
				CardGame game2 = (CardGame)_game;
				if ((object)_game == null)
				{
					goto IL_02cd;
				}
				object obj10 = obj5;
				nint num4 = (nint)game2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v12 (Il2CppClass<CardGame>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X1_v6+130]");
				bool flag4 = num5 < 0;
				object obj11 = !flag4;
				object obj12 = ~obj11;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v12 (Il2CppClass<CardGame>)+C8]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X1_v6+130]");
					object obj13 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v14-8]");
					if (0 == (nint)obj10)
					{
						List<Card> cardsOnFloor = ((CardGame)_game).CardsOnFloor;
						if (cardsOnFloor == null)
						{
							goto IL_02cd;
						}
						result = cardsOnFloor._size;
						goto IL_02db;
					}
				}
			}
		}
		InvalidCastException ex2 = new InvalidCastException();
		goto IL_02cd;
		IL_0066:
		game = _game;
		bool flag5 = (object)_game == null;
		object obj14 = !flag5;
		if (obj14 != null)
		{
			goto IL_0112;
		}
		goto IL_02cd;
	}

	protected virtual SpriteRenderer GetCardSprite(KPlayer player)
	{
		//IL_0052: Expected O, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_007c: Expected O, but got I
		SpriteRenderer[] array = playingCardsSprites;
		int playerSlotIndex = GetPlayerSlotIndex(player);
		if (playingCardsSprites != null)
		{
			bool flag = playerSlotIndex < array.Length;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = playingCardsSprites + playerSlotIndex;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+20]");
				return (SpriteRenderer)0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (SpriteRenderer)(object)new IndexOutOfRangeException();
	}

	public void CardCollisionAnim(SpriteRenderer playedCard, KPlayer player, bool isEventFromServer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0095: Expected O, but got I4
		//IL_018e: Expected F4, but got I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0255: Expected O, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_0284: Expected I, but got O
		//IL_02ae: Expected O, but got I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d4: Expected I, but got O
		//IL_00fd: Expected O, but got I4
		//IL_0131: Expected O, but got I
		//IL_01a1: Expected F4, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass93_0 <>c__DisplayClass93_ = default(<>c__DisplayClass93_0);
		<>c__DisplayClass93_..ctor();
		float seconds;
		if (<>c__DisplayClass93_ != null)
		{
			object obj2 = <>c__DisplayClass93_ + 16;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj3 = <>c__DisplayClass93_ + 24;
			obj3 = playedCard;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = <>c__DisplayClass93_ + 32;
			obj4 = player;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag = !isEventFromServer;
			object obj5 = !flag;
			KPlayer kPlayer = player;
			if (obj5 != null)
			{
				goto IL_0185;
			}
			KGame game = _game;
			if ((object)_game != null)
			{
				object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
				object obj7 = obj6;
				nint num = (nint)game;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v16 (Il2CppClass<KGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X1_v11+130]");
				bool flag2 = num2 < 0;
				object obj8 = !flag2;
				object obj9 = ~obj8;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v16 (Il2CppClass<KGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X1_v11+130]");
					object obj10 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v18-8]");
					if (0 == (nint)obj7)
					{
						bool isSpectator = _game.IsSpectator;
						bool flag3 = !isSpectator;
						kPlayer = null;
						if (!flag3)
						{
							goto IL_0185;
						}
						kPlayer = null;
						seconds = 1.04522054E+09f;
						goto IL_0235;
					}
				}
				goto IL_01d5;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01d5;
		IL_0235:
		object obj11 = typeof(SqlSingle[]) + 2376;
		object obj12 = (nint)0 + (nint)2512;
		object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(<>c__DisplayClass93_, (IntPtr)obj12);
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v20+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(seconds, action);
		return;
		IL_01d5:
		throw new InvalidCastException();
		IL_0185:
		seconds = 1.05193146E+09f;
		goto IL_0235;
	}

	private static float GetSwayValue(SwayDirection swayDirection)
	{
		//IL_00a0: Expected F4, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0136: Expected O, but got I
		switch (swayDirection)
		{
		case SwayDirection.SwayRight:
			return UnityEngine.Random.Range(-3f, -1f);
		case SwayDirection.SwayLeft:
			return UnityEngine.Random.Range(1f, 3f);
		case SwayDirection.DontSway:
			return 0f;
		default:
		{
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4016;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = "startPosition" + 1520;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			string paramName = default(string);
			object actualValue = default(object);
			ex..ctor(paramName, actualValue, null);
			object obj4 = (nint)0 + (nint)3312;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
		}
	}

	private static Vector2 GetCollisionValues(CollisionDirections collidingDirection)
	{
		//IL_01ba: Expected O, but got I4
		//IL_0321: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_0156: Expected O, but got I4
		//IL_0071: Expected O, but got I4
		//IL_030a: Expected O, but got I4
		//IL_02d3: Expected O, but got I4
		float minInclusive;
		float maxInclusive;
		Vector2 result;
		float minInclusive2;
		float maxInclusive2;
		float minInclusive3;
		float maxInclusive3;
		float minInclusive4;
		float maxInclusive4;
		if (collidingDirection <= CollisionDirections.BottomRight)
		{
			if (collidingDirection <= CollisionDirections.TopRight)
			{
				if (collidingDirection == CollisionDirections.Top)
				{
					float num = UnityEngine.Random.Range(-4.5f, 4.5f);
					minInclusive = 6f;
					maxInclusive = 9f;
					goto IL_030a;
				}
				bool flag = collidingDirection != CollisionDirections.TopRight;
				result = (Vector2)collidingDirection;
				if (!flag)
				{
					minInclusive2 = 6f;
					maxInclusive2 = 9f;
					goto IL_029e;
				}
			}
			else
			{
				if (collidingDirection == CollisionDirections.Right)
				{
					minInclusive3 = 6f;
					maxInclusive3 = 9f;
					goto IL_0321;
				}
				bool flag2 = collidingDirection != CollisionDirections.BottomRight;
				result = (Vector2)collidingDirection;
				if (!flag2)
				{
					minInclusive4 = 6f;
					maxInclusive4 = 9f;
					goto IL_02d8;
				}
			}
		}
		else if (collidingDirection <= CollisionDirections.BottomLeft)
		{
			if (collidingDirection == CollisionDirections.Bottom)
			{
				float num2 = UnityEngine.Random.Range(-4.5f, 4.5f);
				minInclusive = -9f;
				maxInclusive = -6f;
				goto IL_030a;
			}
			bool flag3 = collidingDirection != CollisionDirections.BottomLeft;
			result = (Vector2)collidingDirection;
			if (!flag3)
			{
				minInclusive2 = -9f;
				maxInclusive2 = -6f;
				goto IL_029e;
			}
		}
		else
		{
			if (collidingDirection == CollisionDirections.Left)
			{
				minInclusive3 = -9f;
				maxInclusive3 = -6f;
				goto IL_0321;
			}
			bool flag4 = collidingDirection != CollisionDirections.TopLeft;
			result = (Vector2)collidingDirection;
			if (!flag4)
			{
				minInclusive4 = -9f;
				maxInclusive4 = -6f;
				goto IL_02d8;
			}
		}
		goto IL_0299;
		IL_030a:
		float num3 = UnityEngine.Random.Range(minInclusive, maxInclusive);
		return (Vector2)0;
		IL_02d8:
		float num4 = UnityEngine.Random.Range(minInclusive4, maxInclusive4);
		float num5 = UnityEngine.Random.Range(-4.5f, 4.5f);
		return (Vector2)0;
		IL_029e:
		float num6 = UnityEngine.Random.Range(minInclusive2, maxInclusive2);
		float num7 = UnityEngine.Random.Range(-4.5f, 4.5f);
		result = (Vector2)0;
		goto IL_0299;
		IL_0321:
		float num8 = UnityEngine.Random.Range(minInclusive3, maxInclusive3);
		minInclusive = -4.5f;
		maxInclusive = 4.5f;
		goto IL_030a;
		IL_0299:
		return result;
	}

	private void InitializeGroundCards()
	{
		//IL_0011: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31D00");
		object obj2 = this + 216;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void AnimateEatingCardsPulsing()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 3912;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AnimationExtensions.AnimPulsing(playingParent, 0.4f, 1.01f, 1.6f);
	}

	public void ResetGameGround()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		//IL_0584: Expected O, but got I4
		//IL_0038: Expected I, but got O
		//IL_00fd: Expected O, but got I
		//IL_010d: Expected O, but got I
		//IL_011d: Expected O, but got I
		//IL_013f: Expected O, but got I4
		//IL_0082: Expected O, but got I
		//IL_0092: Expected O, but got I
		//IL_00a2: Expected O, but got I
		//IL_00c4: Expected O, but got I4
		//IL_025f: Expected O, but got I
		//IL_026f: Expected O, but got I
		//IL_0291: Expected O, but got I4
		//IL_0177: Expected O, but got I4
		//IL_01f8: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_022a: Expected O, but got I4
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected O, but got Unknown
		//IL_05bc: Expected O, but got I
		//IL_05cd: Expected I, but got O
		//IL_05eb: Expected O, but got I
		//IL_0606: Expected O, but got I4
		//IL_03e1: Expected O, but got I
		//IL_03f1: Expected O, but got I
		//IL_0413: Expected O, but got I4
		//IL_02c1: Expected O, but got I4
		//IL_01a7: Expected O, but got I
		//IL_03ac: Expected O, but got I4
		//IL_0342: Expected O, but got I
		//IL_0352: Expected O, but got I
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected O, but got Unknown
		//IL_0645: Expected O, but got I
		//IL_0656: Expected I, but got O
		//IL_0674: Expected O, but got I
		//IL_068f: Expected O, but got I4
		//IL_0443: Expected O, but got I4
		//IL_02f1: Expected O, but got I
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected O, but got Unknown
		//IL_06c6: Expected O, but got I
		//IL_06d7: Expected I, but got O
		//IL_06f5: Expected O, but got I
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected O, but got Unknown
		//IL_04cc: Expected O, but got I4
		//IL_0473: Expected O, but got I
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected O, but got Unknown
		//IL_04f0: Expected O, but got I
		//IL_0506: Expected O, but got I
		//IL_0520: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3984;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy.StopInstanceCoroutine(_eatingCoroutine);
		nint num = (nint)this;
		ResetPlayedCards();
		ResetEatingCards();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v48+E4]");
		object obj7;
		Action<object> action;
		object obj9;
		object obj6;
		if ((nint)0 != 0)
		{
			obj6 = (nint)0 + (nint)2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v48+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v41+20]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v41+20]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				obj9 = obj6;
				goto IL_0155;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
			obj9 = (nint)0 + (nint)2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v48+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v41+20]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v41+20]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			obj6 = obj9;
			if (obj10 == null)
			{
				goto IL_0155;
			}
		}
		goto IL_01ac;
		IL_029f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v38+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		object obj13;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v36+B8]");
			obj13 = 0;
		}
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)2480;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj13, (IntPtr)obj15);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v35+B8]");
		object obj17 = (nint)0 + (nint)40;
		obj17 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj18 = 0;
		Action<object> action3 = action2;
		goto IL_02f6;
		IL_0496:
		Userbox[] array;
		if (array.Length >= 1)
		{
			object obj19 = array + 32;
			object obj20 = 0;
			do
			{
				obj20++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X22_v7+v311 @ X21_v10*8]");
				((MonoBehaviour)0).StopAllCoroutines();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X22_v7+v311 @ X21_v10*8]");
				int num2 = ShortcutExtensions.DOKill((Component)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X22_v7+v311 @ X21_v10*8]");
				((Userbox)0).HideProjectCards();
			}
			while ((nint)obj20 < array.Length);
		}
		return;
		IL_02f6:
		ArraysExtensions.ForEach(eatingCardsSprites, action3);
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v24+E4]");
		object obj22;
		Action<object> action4;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v24+B8]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v17+30]");
			action4 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v17+30]");
			if ((nint)0 != 0)
			{
				goto IL_0377;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v24+B8]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v17+30]");
			action4 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v17+30]");
			bool flag5 = (nint)0 == 0;
			object obj23 = !flag5;
			if (obj23 != null)
			{
				goto IL_0377;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v24+E4]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v23+B8]");
			obj22 = 0;
		}
		object obj26 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)2488;
		Action<object> action5 = default(Action<object>);
		action5..ctor(obj22, (IntPtr)obj27);
		object obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v22+B8]");
		object obj29 = (nint)0 + (nint)48;
		obj29 = action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ArraysExtensions.ForEach(_eatingsCount, action5);
		array = allUserboxes;
		goto IL_0496;
		IL_01ac:
		ArraysExtensions.ForEach(playingCardsSprites, action);
		object obj30 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v38+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v38+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v30+28]");
			action3 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v30+28]");
			bool flag7 = (nint)0 == 0;
			object obj31 = !flag7;
			if (obj31 == null)
			{
				goto IL_029f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v38+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v30+28]");
			action3 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v30+28]");
			bool flag8 = (nint)0 == 0;
			object obj32 = !flag8;
			if (obj32 == null)
			{
				goto IL_029f;
			}
		}
		goto IL_02f6;
		IL_0377:
		ArraysExtensions.ForEach(_eatingsCount, action4);
		array = allUserboxes;
		bool flag9 = allUserboxes == null;
		object obj33 = !flag9;
		if (obj33 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0496;
		IL_0155:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v48+E4]");
		bool flag10 = (nint)0 == 0;
		object obj34 = !flag10;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj35 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v47+B8]");
			obj7 = 0;
		}
		object obj36 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)2472;
		Action<object> action6 = default(Action<object>);
		action6..ctor(obj7, (IntPtr)obj37);
		object obj38 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v46+B8]");
		object obj39 = (nint)0 + (nint)32;
		obj39 = action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj18 = 0;
		obj6 = obj9;
		action = action6;
		goto IL_01ac;
	}

	protected virtual void ResetPlayedCards()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010d: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_0174: Expected O, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01ba: Expected O, but got I4
		//IL_02e3: Expected O, but got I
		//IL_02fd: Expected O, but got I
		//IL_032e: Expected O, but got I4
		//IL_032e: Expected O, but got I
		//IL_0346: Expected O, but got I4
		//IL_038a: Expected O, but got I4
		//IL_03a6: Expected O, but got I4
		//IL_03ea: Expected O, but got I4
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_0423: Expected O, but got I4
		//IL_0434: Expected O, but got I
		//IL_05a8: Expected O, but got I
		//IL_05c2: Expected O, but got I4
		//IL_04ab: Expected O, but got I
		//IL_0600: Expected O, but got I4
		//IL_050d: Expected O, but got I
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_065e: Expected O, but got I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_057e: Expected O, but got I4
		//IL_0758: Expected O, but got I
		//IL_0772: Expected O, but got I4
		//IL_06b4: Expected O, but got I
		//IL_06ce: Expected O, but got I4
		//IL_0703: Expected O, but got I
		//IL_0725: Expected O, but got I4
		//IL_0243: Expected O, but got I
		//IL_01fc: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(SqlSingle[]) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AB5]");
		object obj3 = (nint)0 & (nint)1;
		Transform rect;
		Transform rect2;
		if (obj3 != null)
		{
			rect = playingParent;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v56+E4]");
			bool flag = (nint)0 == 0;
			rect2 = playingParent;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			rect = playingParent;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v56+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			rect2 = playingParent;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AnimationExtensions.AnimEndAnimation(rect2);
		Transform transform = playingParent;
		if ((object)playingParent != null)
		{
			goto IL_0166;
		}
		goto IL_078c;
		IL_078c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_079a;
		IL_079a:
		throw new IndexOutOfRangeException();
		IL_0166:
		transform.localScale = (Vector3)0;
		SpriteRenderer[] array = playingCardsSprites;
		if (playingCardsSprites != null)
		{
			object obj6 = typeof(SqlSingle[]) + 3832;
			object obj7 = 0;
			do
			{
				if ((nint)obj7 >= array.Length)
				{
					return;
				}
				object obj8 = (object)array + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v7+20]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v7+20]");
				Transform transform2 = ((Component)0).transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v7+20]");
				int num = ShortcutExtensions.DOKill((Component)0, complete: true);
				int num2 = ShortcutExtensions.DOKill(transform2, complete: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v7+20]");
				((SpriteRenderer)0).color = (Color)0;
				if ((object)transform2 == null)
				{
					break;
				}
				transform2.localScale = (Vector3)0;
				Vector3[] originalEatingCardsTransformsRotations = _originalEatingCardsTransformsRotations;
				if (_originalEatingCardsTransformsRotations == null)
				{
					break;
				}
				bool flag3 = (nint)obj7 < originalEatingCardsTransformsRotations.Length;
				object obj9 = !flag3;
				object obj19;
				object obj17;
				if (obj9 == null)
				{
					transform2.localEulerAngles = (Vector3)0;
					Vector3[] originalEatingCardsTransformsPositions = _originalEatingCardsTransformsPositions;
					if (_originalEatingCardsTransformsPositions == null)
					{
						break;
					}
					bool flag4 = (nint)obj7 < originalEatingCardsTransformsPositions.Length;
					object obj10 = !flag4;
					if (obj10 == null)
					{
						object obj11 = obj7 * 12;
						object obj12 = (object)_originalEatingCardsTransformsPositions + obj11;
						transform2.localPosition = (Vector3)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v7+20]");
						GameObject gameObject = ((Component)0).gameObject;
						if ((object)gameObject == null)
						{
							break;
						}
						gameObject.SetActive(value: false);
						object obj13 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v20+E4]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
							object obj14 = (nint)0 & (nint)1;
							if (obj14 != null)
							{
								goto IL_04c8;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
							object obj15 = (nint)0 & (nint)1;
							bool flag5 = obj15 == null;
							object obj16 = !flag5;
							if (obj16 != null)
							{
								goto IL_04c8;
							}
						}
						_ = 1;
						obj17 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v29+E4]");
						bool flag6 = (nint)0 == 0;
						object obj18 = !flag6;
						obj19 = obj17;
						if (obj18 != null)
						{
							goto IL_04fd;
						}
						goto IL_0616;
					}
				}
				goto IL_079a;
				IL_04fd:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v29+B8]");
				object obj20 = 0;
				object obj21 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v26+E4]");
				if ((nint)0 != 0)
				{
					if (!((UnityEngine.Object)obj20 != null))
					{
						goto IL_0248;
					}
					object obj23 = 0;
					UnityEngine.Object obj24 = null;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag7 = (UnityEngine.Object)obj20 != null;
					bool flag8 = !flag7;
					object obj23 = 0;
					UnityEngine.Object obj24 = null;
					if (flag8)
					{
						goto IL_0248;
					}
				}
				object obj25 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v32+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
					object obj26 = (nint)0 & (nint)1;
					bool flag9 = obj26 == null;
					object obj27 = !flag9;
					if (obj27 != null)
					{
						goto IL_01bf;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
					object obj28 = (nint)0 & (nint)1;
					bool flag10 = obj28 == null;
					object obj29 = !flag10;
					if (obj29 != null)
					{
						goto IL_01bf;
					}
				}
				_ = 1;
				goto IL_01bf;
				IL_04c8:
				obj17 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v29+E4]");
				bool flag11 = (nint)0 == 0;
				obj19 = obj17;
				if (!flag11)
				{
					goto IL_04fd;
				}
				goto IL_0616;
				IL_0616:
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj6;
				goto IL_04fd;
				IL_01bf:
				object obj30 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v38+E4]");
				AnimatedItemController animatedItemController;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v38+B8]");
					object obj31 = 0;
					animatedItemController = (AnimatedItemController)obj31;
					if (obj31 == null)
					{
						break;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj32 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v40+B8]");
					object obj33 = 0;
					animatedItemController = (AnimatedItemController)obj33;
					bool flag12 = obj33 == null;
					object obj34 = !flag12;
					if (obj34 == null)
					{
						break;
					}
				}
				Material defaultCardMaterial = animatedItemController.GetDefaultCardMaterial();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v7+20]");
				((Renderer)0).material = defaultCardMaterial;
				goto IL_0248;
				IL_0248:
				obj7++;
				array = playingCardsSprites;
			}
			while (playingCardsSprites != null);
		}
		goto IL_078c;
		IL_0091:
		AnimationExtensions.AnimEndAnimation(rect);
		transform = playingParent;
		bool flag13 = (object)playingParent == null;
		object obj35 = !flag13;
		if (obj35 != null)
		{
			goto IL_0166;
		}
		goto IL_078c;
	}

	private void ResetEatingCards()
	{
		//IL_005d: Expected O, but got I4
		//IL_0072: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_00b2: Expected O, but got I
		//IL_00e0: Expected O, but got I4
		//IL_0111: Expected O, but got I
		//IL_0156: Expected O, but got I4
		//IL_018c: Expected O, but got I4
		//IL_018c: Expected O, but got I
		//IL_01b6: Expected O, but got I4
		//IL_01e7: Expected O, but got I
		//IL_01fe: Expected O, but got I4
		//IL_0228: Expected O, but got I4
		//IL_0259: Expected O, but got I
		//IL_0287: Expected O, but got I4
		//IL_02a3: Expected O, but got I4
		//IL_02cd: Expected O, but got I4
		//IL_02fe: Expected O, but got I
		//IL_032c: Expected O, but got I4
		//IL_0348: Expected O, but got I4
		//IL_0372: Expected O, but got I4
		//IL_03a3: Expected O, but got I
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03ee: Expected O, but got I4
		if (_animateEatingTween != null)
		{
			TweenExtensions.Kill(_animateEatingTween, complete: true);
		}
		int num = ShortcutExtensions.DOKill(eatingsParent, complete: true);
		eatingsParent.localPosition = (Vector3)0;
		eatingsParent.localScale = (Vector3)0;
		SpriteRenderer[] array = eatingCardsSprites;
		object obj = 0;
		while (true)
		{
			if ((nint)obj < array.Length)
			{
				object obj2 = (object)array + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v5+20]");
				int num2 = ShortcutExtensions.DOKill((Component)0, complete: true);
				SpriteRenderer[] array2 = eatingCardsSprites;
				bool flag = (nint)obj < array2.Length;
				object obj3 = !flag;
				if (obj3 != null)
				{
					break;
				}
				object obj4 = (object)array2 + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v8+20]");
				Transform target = ((Component)0).transform;
				int num3 = ShortcutExtensions.DOKill(target, complete: true);
				SpriteRenderer[] array3 = eatingCardsSprites;
				bool flag2 = (nint)obj < array3.Length;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					break;
				}
				object obj6 = (object)array3 + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v10+20]");
				((SpriteRenderer)0).color = (Color)0;
				SpriteRenderer[] array4 = eatingCardsSprites;
				bool flag3 = (nint)obj < array4.Length;
				object obj7 = !flag3;
				if (obj7 != null)
				{
					break;
				}
				object obj8 = (object)array4 + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v12+20]");
				Transform transform = ((Component)0).transform;
				transform.localScale = (Vector3)0;
				SpriteRenderer[] array5 = eatingCardsSprites;
				bool flag4 = (nint)obj < array5.Length;
				object obj9 = !flag4;
				if (obj9 != null)
				{
					break;
				}
				object obj10 = (object)array5 + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v17+20]");
				Transform transform2 = ((Component)0).transform;
				Vector3[] originalEatingCardsTransformsRotations = _originalEatingCardsTransformsRotations;
				bool flag5 = (nint)obj < originalEatingCardsTransformsRotations.Length;
				object obj11 = !flag5;
				if (obj11 != null)
				{
					break;
				}
				transform2.localEulerAngles = (Vector3)0;
				SpriteRenderer[] array6 = eatingCardsSprites;
				bool flag6 = (nint)obj < array6.Length;
				object obj12 = !flag6;
				if (obj12 != null)
				{
					break;
				}
				object obj13 = (object)array6 + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v21+20]");
				Transform transform3 = ((Component)0).transform;
				Vector3[] originalEatingCardsTransformsPositions = _originalEatingCardsTransformsPositions;
				bool flag7 = (nint)obj < originalEatingCardsTransformsPositions.Length;
				object obj14 = !flag7;
				if (obj14 != null)
				{
					break;
				}
				transform3.localPosition = (Vector3)0;
				SpriteRenderer[] array7 = eatingCardsSprites;
				bool flag8 = (nint)obj < array7.Length;
				object obj15 = !flag8;
				if (obj15 != null)
				{
					break;
				}
				object obj16 = (object)array7 + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v25+20]");
				GameObject gameObject = ((Component)0).gameObject;
				obj++;
				gameObject.SetActive(value: false);
				array = eatingCardsSprites;
				bool flag9 = eatingCardsSprites == null;
				object obj17 = !flag9;
				if (obj17 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			return;
		}
		throw new IndexOutOfRangeException();
	}

	private void TweenCardEating(Transform eatingPoint, Sprite cardback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0043: Expected O, but got I4
		//IL_008d: Expected O, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00d9: Expected O, but got I
		//IL_00e5: Expected O, but got I
		//IL_00f1: Expected O, but got I
		//IL_0809: Expected O, but got I4
		//IL_01ed: Expected I, but got O
		//IL_020c: Expected I, but got O
		//IL_022e: Expected O, but got I4
		//IL_012b: Expected O, but got I
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0183: Expected O, but got I4
		//IL_018c: Expected F4, but got I4
		//IL_0195: Expected F4, but got I4
		//IL_0286: Expected O, but got I
		//IL_02a2: Expected I, but got O
		//IL_01b9: Expected F4, but got I4
		//IL_01c2: Expected F4, but got I4
		//IL_02ca: Expected O, but got I4
		//IL_02e2: Expected O, but got I
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected O, but got Unknown
		//IL_085b: Expected O, but got I4
		//IL_087a: Expected I, but got O
		//IL_0894: Expected F4, but got I4
		//IL_0303: Expected I, but got O
		//IL_031d: Expected F4, but got I4
		//IL_0740: Expected O, but got I4
		//IL_0354: Expected O, but got I
		//IL_0378: Expected I, but got O
		//IL_0392: Expected F4, but got I4
		//IL_03cd: Expected O, but got I4
		//IL_03fe: Expected I, but got O
		//IL_0418: Expected F4, but got I4
		//IL_0448: Expected O, but got I
		//IL_0460: Expected I, but got O
		//IL_047a: Expected F4, but got I4
		//IL_04be: Expected O, but got I4
		//IL_050b: Expected F4, but got I4
		//IL_0510: Expected I, but got O
		//IL_0519: Expected F4, but got I4
		//IL_0522: Expected F4, but got I4
		//IL_0534: Expected F4, but got I4
		//IL_0573: Expected O, but got I4
		//IL_05a8: Expected F4, but got I4
		//IL_05ad: Expected I, but got O
		//IL_05b6: Expected F4, but got I4
		//IL_05bf: Expected F4, but got I4
		//IL_05d1: Expected F4, but got I4
		//IL_060f: Expected O, but got I
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected O, but got Unknown
		//IL_0685: Expected O, but got I4
		//IL_068e: Expected F4, but got I4
		//IL_0693: Expected I, but got O
		//IL_069c: Expected F4, but got I4
		//IL_06a5: Expected F4, but got I4
		//IL_06af: Expected F4, but got I4
		//IL_06c6: Expected F4, but got I4
		Sequence sequence = (Sequence)(typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848);
		ResetPlayedCards();
		ResetEatingCards();
		PrepareEatingCards();
		Sprite sprite = default(Sprite);
		TweenEatingCount(eatingPoint, sprite);
		nint num = (nint)sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v7 (Il2CppClass<DG.Tweening.Sequence>)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence2 = DOTween.Sequence();
		SpriteRenderer[] array = eatingCardsSprites;
		bool flag2 = eatingCardsSprites == null;
		object obj2 = 152993792;
		Transform transform = eatingPoint;
		Sequence sequence3 = (Sequence)(object)sprite;
		if (!flag2)
		{
			float num2 = 0f + 2816f;
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Transform transform2 = (Transform)((nint)0 + (nint)3336);
			obj2 = (nint)0 + (nint)2512;
			object obj4 = (nint)0 + (nint)2904;
			Transform transform3 = eatingPoint;
			transform = null;
			Tween tween = default(Tween);
			TweenCallback tweenCallback = default(TweenCallback);
			Tween t = default(Tween);
			Tween t2 = default(Tween);
			float num3 = default(float);
			Tween t3 = default(Tween);
			Tween t4 = default(Tween);
			while (true)
			{
				bool flag3 = (nint)transform < array.Length;
				object obj5 = !flag3;
				if ((nint)transform < array.Length)
				{
					object obj6 = (object)array + (object)transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v22+20]");
					TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleSprite.DOFade((SpriteRenderer)0, 0f, 0.3f);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
					Sequence sequence4 = TweenSettingsExtensions.Join(sequence2, tween);
					transform = (Transform)(transform + 1);
					array = eatingCardsSprites;
					bool flag4 = eatingCardsSprites == null;
					object obj7 = !flag4;
					num3 = 0f;
					float num4 = 1.0502537E+09f;
					sprite = null;
					transform3 = (Transform)(object)tween;
					if (obj7 == null)
					{
						num3 = 0f;
						num4 = 1.0502537E+09f;
						sprite = null;
						sequence3 = sequence2;
						break;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				tweenCallback..ctor(this, (IntPtr)transform2);
				sprite = (Sprite)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
				nint num5 = (nint)sequence;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v33 (Il2CppClass<DG.Tweening.Sequence>)+E4]");
				bool flag5 = (nint)0 == 0;
				object obj8 = !flag5;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Sequence sequence5 = DOTween.Sequence();
				transform = (Transform)(this + 208);
				transform = (Transform)(object)sequence5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X22_v2 (UnityEngine.Transform)-60]");
				array = (SpriteRenderer[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X22_v2 (UnityEngine.Transform)-60]");
				bool flag6 = (nint)0 == 0;
				nint num6 = unchecked((nint)null);
				sequence3 = sequence2;
				if (flag6)
				{
					break;
				}
				float num7 = num3;
				object obj9 = 4;
				Sequence sequence6 = sequence;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X22_v2 (UnityEngine.Transform)-60]");
				SpriteRenderer[] array2 = (SpriteRenderer[])0;
				while (true)
				{
					obj2 = obj9 - 4;
					bool flag7 = (nint)obj2 < array2.Length;
					obj5 = !flag7;
					bool flag8 = (nint)obj2 >= array2.Length;
					num6 = unchecked((nint)null);
					num3 = num7;
					obj3 = obj9;
					num2 = 1.04522054E+09f;
					sequence = sequence6;
					array = array2;
					sequence3 = sequence2;
					if (!flag8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v17 (UnityEngine.SpriteRenderer[])+v207 @ X26_v7*8]");
						bool flag9 = (nint)0 == 0;
						num6 = unchecked((nint)null);
						num3 = num7;
						obj3 = obj9;
						num2 = 1.04522054E+09f;
						sequence = sequence6;
						array = array2;
						sequence3 = sequence2;
						if (flag9)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v17 (UnityEngine.SpriteRenderer[])+v207 @ X26_v7*8]");
						Transform target = ((Component)0).transform;
						array = eatingCardsSprites;
						bool flag10 = eatingCardsSprites == null;
						num6 = unchecked((nint)null);
						num3 = num7;
						obj3 = obj9;
						num2 = 1.04522054E+09f;
						sequence = (Sequence)(object)transform;
						sequence3 = sequence2;
						if (flag10)
						{
							break;
						}
						bool flag11 = (nint)obj2 < array.Length;
						obj5 = !flag11;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v6 (UnityEngine.SpriteRenderer[])+v207 @ X26_v7*8]");
							bool flag12 = (nint)0 == 0;
							num6 = unchecked((nint)null);
							num3 = num7;
							obj3 = obj9;
							num2 = 1.04522054E+09f;
							sequence = (Sequence)(object)transform;
							sequence3 = sequence2;
							if (flag12)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v6 (UnityEngine.SpriteRenderer[])+v207 @ X26_v7*8]");
							Transform transform4 = ((Component)0).transform;
							bool flag13 = (object)transform4 == null;
							num6 = unchecked((nint)null);
							num3 = num7;
							obj3 = obj9;
							num2 = 1.04522054E+09f;
							sequence = (Sequence)(object)transform;
							sequence3 = sequence2;
							if (flag13)
							{
								break;
							}
							Vector3 localPosition = transform4.localPosition;
							TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOLocalMove(target, (Vector3)0, 0f);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
							Sequence sequence7 = TweenSettingsExtensions.Join((Sequence)(object)transform, t);
							array = eatingCardsSprites;
							bool flag14 = eatingCardsSprites == null;
							float num8 = 1.04522054E+09f;
							num6 = unchecked((nint)null);
							num3 = 0f;
							float num4 = 0f;
							obj3 = obj9;
							num2 = 1.04522054E+09f;
							sprite = null;
							sequence = (Sequence)(object)transform;
							sequence3 = sequence2;
							if (flag14)
							{
								break;
							}
							bool flag15 = (nint)obj2 < array.Length;
							obj5 = !flag15;
							if (obj5 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v6 (UnityEngine.SpriteRenderer[])+v207 @ X26_v7*8]");
								bool flag16 = (nint)0 == 0;
								num8 = 1.04522054E+09f;
								num6 = unchecked((nint)null);
								num3 = 0f;
								num4 = 0f;
								obj3 = obj9;
								num2 = 1.04522054E+09f;
								sprite = null;
								sequence = (Sequence)(object)transform;
								sequence3 = sequence2;
								if (flag16)
								{
									break;
								}
								sequence = _animateEatingTween;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v6 (UnityEngine.SpriteRenderer[])+v207 @ X26_v7*8]");
								Transform target2 = ((Component)0).transform;
								TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(target2, 0.96f, 0.2f);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
								Sequence sequence8 = TweenSettingsExtensions.Join(_animateEatingTween, t2);
								array = eatingCardsSprites;
								obj3 = obj9 + 1;
								bool flag17 = eatingCardsSprites == null;
								object obj10 = !flag17;
								num8 = 1.04522054E+09f;
								num6 = unchecked((nint)null);
								num3 = 1.0646821E+09f;
								num4 = 1.04522054E+09f;
								num2 = 1.04522054E+09f;
								sprite = null;
								sequence3 = sequence2;
								num7 = 1.0646821E+09f;
								obj9 = obj3;
								sequence6 = _animateEatingTween;
								array2 = eatingCardsSprites;
								if (obj10 == null)
								{
									break;
								}
								continue;
							}
						}
						throw new IndexOutOfRangeException();
					}
					if ((object)eatingPoint == null)
					{
						break;
					}
					Vector3 position = eatingPoint.position;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ShortcutExtensions.DOMove(eatingsParent, (Vector3)0, num3);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
					Sequence sequence9 = TweenSettingsExtensions.Append(_animateEatingTween, t3);
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore5 = ShortcutExtensions.DOScale(eatingsParent, 0.4f, 0.3f);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
					Sequence sequence10 = TweenSettingsExtensions.Join(_animateEatingTween, t4);
					Sequence sequence11 = TweenSettingsExtensions.Join(_animateEatingTween, sequence3);
					return;
				}
				break;
			}
		}
		throw new NullReferenceException();
	}

	private void PrepareEatingCards()
	{
		//IL_0018: Expected O, but got I4
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_0047: Expected O, but got I4
		//IL_0066: Expected O, but got I
		//IL_0085: Expected O, but got I4
		//IL_0085: Expected O, but got I
		//IL_00af: Expected O, but got I4
		//IL_00ce: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_011b: Expected O, but got I
		//IL_0144: Expected O, but got I4
		//IL_016e: Expected O, but got I4
		//IL_018d: Expected O, but got I
		//IL_01bb: Expected O, but got I4
		//IL_01da: Expected O, but got I
		//IL_0203: Expected O, but got I4
		//IL_022d: Expected O, but got I4
		//IL_024c: Expected O, but got I
		//IL_027a: Expected O, but got I4
		//IL_0299: Expected O, but got I
		//IL_02c2: Expected O, but got I4
		//IL_02ec: Expected O, but got I4
		//IL_0324: Expected O, but got I4
		//IL_0343: Expected O, but got I
		//IL_0361: Expected O, but got I
		//IL_038b: Expected O, but got I4
		//IL_03c3: Expected O, but got I4
		//IL_03e2: Expected O, but got I
		//IL_040e: Expected O, but got I
		//IL_0438: Expected O, but got I4
		//IL_0457: Expected O, but got I
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_04a2: Expected O, but got I4
		SpriteRenderer[] array = eatingCardsSprites;
		object obj = 4;
		while (true)
		{
			object obj2 = obj - 4;
			if ((nint)obj2 < array.Length)
			{
				SpriteRenderer[] array2 = playingCardsSprites;
				bool flag = (nint)obj2 < array2.Length;
				object obj3 = !flag;
				if (obj3 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X9_v5 (UnityEngine.SpriteRenderer[])+v232 @ X21_v5*8]");
				Color color = ((SpriteRenderer)0).color;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v4 (UnityEngine.SpriteRenderer[])+v232 @ X21_v5*8]");
				((SpriteRenderer)0).color = (Color)0;
				SpriteRenderer[] array3 = eatingCardsSprites;
				bool flag2 = (nint)obj2 < array3.Length;
				object obj4 = !flag2;
				if (obj4 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v6 (UnityEngine.SpriteRenderer[])+v232 @ X21_v5*8]");
				Transform transform = ((Component)0).transform;
				SpriteRenderer[] array4 = playingCardsSprites;
				bool flag3 = (nint)obj2 < array4.Length;
				object obj5 = !flag3;
				if (obj5 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v7 (UnityEngine.SpriteRenderer[])+v232 @ X21_v5*8]");
				Transform transform2 = ((Component)0).transform;
				Vector3 localScale = transform2.localScale;
				transform.localScale = (Vector3)0;
				SpriteRenderer[] array5 = eatingCardsSprites;
				bool flag4 = (nint)obj2 < array5.Length;
				object obj6 = !flag4;
				if (obj6 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v8 (UnityEngine.SpriteRenderer[])+v232 @ X21_v5*8]");
				Transform transform3 = ((Component)0).transform;
				SpriteRenderer[] array6 = playingCardsSprites;
				bool flag5 = (nint)obj2 < array6.Length;
				object obj7 = !flag5;
				if (obj7 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v9 (UnityEngine.SpriteRenderer[])+v232 @ X21_v5*8]");
				Transform transform4 = ((Component)0).transform;
				Vector3 localEulerAngles = transform4.localEulerAngles;
				transform3.localEulerAngles = (Vector3)0;
				SpriteRenderer[] array7 = eatingCardsSprites;
				bool flag6 = (nint)obj2 < array7.Length;
				object obj8 = !flag6;
				if (obj8 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v10 (UnityEngine.SpriteRenderer[])+v232 @ X21_v5*8]");
				Transform transform5 = ((Component)0).transform;
				SpriteRenderer[] array8 = playingCardsSprites;
				bool flag7 = (nint)obj2 < array8.Length;
				object obj9 = !flag7;
				if (obj9 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v11 (UnityEngine.SpriteRenderer[])+v232 @ X21_v5*8]");
				Transform transform6 = ((Component)0).transform;
				Vector3 localPosition = transform6.localPosition;
				transform5.localPosition = (Vector3)0;
				SpriteRenderer[] array9 = eatingCardsSprites;
				bool flag8 = (nint)obj2 < array9.Length;
				object obj10 = !flag8;
				if (obj10 != null)
				{
					break;
				}
				SpriteRenderer[] array10 = playingCardsSprites;
				bool flag9 = (nint)obj2 < array10.Length;
				object obj11 = !flag9;
				if (obj11 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X9_v14 (UnityEngine.SpriteRenderer[])+v232 @ X21_v5*8]");
				Sprite sprite = ((SpriteRenderer)0).sprite;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v12 (UnityEngine.SpriteRenderer[])+v232 @ X21_v5*8]");
				((SpriteRenderer)0).sprite = sprite;
				SpriteRenderer[] array11 = eatingCardsSprites;
				bool flag10 = (nint)obj2 < array11.Length;
				object obj12 = !flag10;
				if (obj12 != null)
				{
					break;
				}
				SpriteRenderer[] array12 = playingCardsSprites;
				bool flag11 = (nint)obj2 < array12.Length;
				object obj13 = !flag11;
				if (obj13 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X9_v16 (UnityEngine.SpriteRenderer[])+v232 @ X21_v5*8]");
				int sortingOrder = ((Renderer)0).sortingOrder;
				int sortingOrder2 = sortingOrder - 5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v13 (UnityEngine.SpriteRenderer[])+v232 @ X21_v5*8]");
				((Renderer)0).sortingOrder = sortingOrder2;
				SpriteRenderer[] array13 = eatingCardsSprites;
				bool flag12 = (nint)obj2 < array13.Length;
				object obj14 = !flag12;
				if (obj14 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v14 (UnityEngine.SpriteRenderer[])+v232 @ X21_v5*8]");
				GameObject gameObject = ((Component)0).gameObject;
				gameObject.SetActive(value: true);
				array = eatingCardsSprites;
				obj++;
				bool flag13 = eatingCardsSprites == null;
				object obj15 = !flag13;
				if (obj15 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			return;
		}
		throw new IndexOutOfRangeException();
	}

	private void TweenEatingCount(Transform eatingTarget, Sprite cardback)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_004f: Expected O, but got I4
		//IL_0065: Expected O, but got I
		//IL_01c7: Expected O, but got I
		//IL_01ea: Expected O, but got I
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I
		//IL_00d3: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00fc: Expected O, but got I4
		//IL_010d: Expected O, but got I
		//IL_0275: Expected O, but got I
		//IL_0288: Expected I4, but got I8
		//IL_0135: Expected F4, but got I
		//IL_0135: Expected O, but got I4
		//IL_0146: Expected O, but got I
		//IL_017a: Expected O, but got I
		//IL_0195: Expected O, but got I
		SpriteRenderer[] eatingsCount = _eatingsCount;
		if (eatingsCount.Length < 1)
		{
			return;
		}
		object obj = eatingsCount + 32;
		object obj2 = typeof(UsageHint) + 816;
		object obj3 = 0;
		object obj7 = default(object);
		object obj10 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X25_v4+v120 @ X24_v5*8]");
			Transform transform = ((Component)0).transform;
			Vector3 localScale = transform.localScale;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v8+B8]");
			object obj5 = 0;
			object obj6 = obj7 - obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v9+4]");
			object obj8 = (nint)786163454 - (nint)0;
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v9+8]");
			obj10 = obj9 - 0;
			object obj11 = obj6 * obj6;
			object obj12 = obj8 * obj8;
			object obj13 = obj11 + obj12;
			object obj14 = obj10 * obj10;
			obj7 = obj14 + obj13;
			if ((nint)obj7 < 786163454)
			{
				break;
			}
			obj3++;
			if ((nint)obj3 >= eatingsCount.Length)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X25_v4+v120 @ X24_v5*8]");
		((SpriteRenderer)0).sprite = cardback;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X25_v4+v120 @ X24_v5*8]");
		Transform transform2 = ((Component)0).transform;
		Vector3 position = eatingTarget.position;
		transform2.position = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X25_v4+v120 @ X24_v5*8]");
		Transform transform3 = ((Component)0).transform;
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v12+B8]");
		object obj16 = 0;
		int num = UnityEngine.Random.Range(-180, 180);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v13+48]");
		transform3.Rotate((Vector3)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X25_v4+v120 @ X24_v5*8]");
		Transform target = ((Component)0).transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 1f, 0.5f);
		object obj17 = (nint)0 + (nint)2776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj18 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	public CardGameVisualControls()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0081: Expected F4, but got I
		//IL_0093: Expected F4, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1744;
		object obj2 = typeof(List<Tween>) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj3 = this + 224;
		obj3 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = this + 240;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		localCardMoveDuration = 0.2f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253660]");
		localCardRotDuration = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253670]");
		serverCardRotDuration = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253680]");
		_ = 0;
		cardSlotFlingY = 1860f;
		_shouldAnimateEatingNow = true;
		base..ctor();
	}

	private bool <Update>g__CanAnimate|68_0()
	{
		//IL_000b: Invalid comparison between F4 and I4
		//IL_0053: Invalid comparison between F4 and I4
		if (!(_pauseUntil < 0f))
		{
			float deltaTime = Time.deltaTime;
			float pauseUntil = _pauseUntil - deltaTime;
			_pauseUntil = pauseUntil;
		}
		return _pauseUntil < 0f;
	}

	private void <Update>g__AddPauseUntil|68_1(float delaySeconds)
	{
		_pauseUntil = delaySeconds;
	}

	private void <Update>g__ProgressActionsBuffer|68_2()
	{
		((List<object>)(object)_actionsBuffer).RemoveAt(0);
	}

	private void <PlayCard>g__DoPlayCard|77_0(int? _gameActionId, int layer, ref <>c__DisplayClass77_0 P_2)
	{
		//IL_002c: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_008c: Expected O, but got I
		//IL_008c: Expected O, but got I
		bool flag = <PlayCard>g__CustomPlayCard|77_1(_gameActionId, ref P_2);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X3 (<>c__DisplayClass77_0&)+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X3 (<>c__DisplayClass77_0&)+10]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X3 (<>c__DisplayClass77_0&)+18]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X3 (<>c__DisplayClass77_0&)+20]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X3 (<>c__DisplayClass77_0&)+21]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X3 (<>c__DisplayClass77_0&)+22]");
			AnimatePlayCard((Card)num, (KPlayer)num2, (Transform)num3, (byte)num4 != 0, (byte)num5 != 0, layer, hideStartingPoint: false);
		}
	}

	private bool <PlayCard>g__CustomPlayCard|77_1(int? actionId = null, ref <>c__DisplayClass77_0 P_1)
	{
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0121: Expected O, but got I
		//IL_013b: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01b1: Expected O, but got I
		//IL_0179: Expected O, but got I4
		//IL_03dd: Expected I4, but got O
		//IL_00be: Expected O, but got I
		//IL_00e0: Expected O, but got I4
		//IL_0209: Expected I, but got O
		//IL_021b: Expected O, but got I
		//IL_025f: Expected O, but got I
		//IL_02ae: Expected O, but got I
		//IL_02c9: Expected O, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_0306: Expected I, but got O
		//IL_0316: Expected O, but got I
		//IL_0351: Expected O, but got I
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		object obj = (??)actionId & 1;
		object obj2;
		object obj7;
		object obj9;
		if (obj != null)
		{
			obj2 = typeof(SqlSingle[]) + 3832;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
				object obj4 = (nint)0 & (nint)1;
				if (obj4 != null)
				{
					goto IL_0079;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
				object obj5 = (nint)0 & (nint)1;
				bool flag = obj5 == null;
				object obj6 = !flag;
				if (obj6 != null)
				{
					goto IL_0079;
				}
			}
			_ = 1;
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v39+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj9 = obj7;
			if (obj8 != null)
			{
				goto IL_00ae;
			}
			goto IL_018f;
		}
		bool flag3 = false;
		goto IL_0408;
		IL_0392:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0431;
		IL_01d6:
		AnimatedItemController animatedItemController;
		flag3 = animatedItemController.CreateCustomPlayAnimation(actionId, out var animation);
		if (flag3)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass77_0&)+10]");
			SpriteRenderer cardSprite = GetCardSprite((KPlayer)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if ((object)cardsSprites != null)
			{
				CardsSprites obj10 = cardsSprites;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass77_0&)+8]");
				Sprite sprite = obj10.GetFor((Card)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				SpriteRenderer spriteRenderer = default(SpriteRenderer);
				if ((object)spriteRenderer != null)
				{
					Sprite sprite2 = default(Sprite);
					spriteRenderer.sprite = sprite2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass77_0&)+10]");
					Userbox activeUserbox = GetActiveUserbox((KPlayer)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass77_0&)+10]");
					Vector3 cardLandingWorldPosition = GetCardLandingWorldPosition((KPlayer)0);
					if (animation != null)
					{
						object obj11 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2016;
						nint num2 = (nint)animation;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v10 (Il2CppClass<ICustomPlayAnimation>)+12E]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v10 (Il2CppClass<ICustomPlayAnimation>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0392;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v10 (Il2CppClass<ICustomPlayAnimation>)+B0]");
						object obj13 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X10_v6-8]");
							if (0 == (nint)obj11)
							{
								break;
							}
							obj13 += 16;
							obj12--;
							if ((nint)obj12 != 1)
							{
								continue;
							}
							goto IL_0392;
						}
						object obj14 = obj13 + 2;
						object obj15 = num2 + obj14;
						object obj16 = obj15 + 312;
						goto IL_0431;
					}
				}
			}
			goto IL_03cf;
		}
		goto IL_0408;
		IL_03cf:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0408:
		return flag3;
		IL_0431:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v381 @ X0_v22] (should have been resolved before IL gen)");
		flag3 = true;
		goto IL_0408;
		IL_0079:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v39+E4]");
		bool flag4 = (nint)0 == 0;
		obj9 = obj7;
		if (!flag4)
		{
			goto IL_00ae;
		}
		goto IL_018f;
		IL_018f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v31+B8]");
		object obj18 = 0;
		animatedItemController = (AnimatedItemController)obj18;
		if (obj18 != null)
		{
			goto IL_01d6;
		}
		goto IL_03cf;
		IL_00ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v39+B8]");
		object obj19 = 0;
		animatedItemController = (AnimatedItemController)obj19;
		bool flag5 = obj19 == null;
		object obj20 = !flag5;
		if (obj20 != null)
		{
			goto IL_01d6;
		}
		goto IL_03cf;
	}

	private void <EatCards>g__EatCardsLocal|78_0(ref <>c__DisplayClass78_0 P_0)
	{
		//IL_001e: Expected O, but got I
		//IL_001e: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass78_0&)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass78_0&)+10]");
		TweenCardEating((Transform)num, (Sprite)0);
	}
}
