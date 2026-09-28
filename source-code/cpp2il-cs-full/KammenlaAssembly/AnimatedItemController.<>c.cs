using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.TextCore;

public class AnimatedItemController : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<IAnimatedGift, bool> <>9__21_0;

		public static Func<Userbox, bool> <>9__42_0;

		public static Action<SpriteRenderer> <>9__52_1;

		public static Action<GameCard> <>9__54_0;

		public static Func<char, bool> <>9__59_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1080;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_isAnyGiftTargetMainPlayer>b__21_0(IAnimatedGift g)
		{
			//IL_01de: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0035: Expected I, but got O
			//IL_0045: Expected O, but got I
			//IL_00db: Expected O, but got I
			//IL_0080: Expected O, but got I
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Expected O, but got Unknown
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected O, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected O, but got Unknown
			//IL_0165: Expected O, but got I
			//IL_0199: Expected O, but got I4
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			object obj2;
			Userbox userbox;
			Userbox userbox2 = default(Userbox);
			object obj8;
			object obj9;
			if (g != null)
			{
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 768;
				obj2 = typeof(SqlSingle[]) + 3832;
				nint num = (nint)g;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<IAnimatedGift>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<IAnimatedGift>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00c1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<IAnimatedGift>)+B0]");
				object obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v6-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj4 += 16;
					obj3--;
					if ((nint)obj3 != 1)
					{
						continue;
					}
					goto IL_00c1;
				}
				object obj5 = obj4 + 3;
				object obj6 = num + obj5;
				object obj7 = obj6 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v14+8]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ X0_v14] (should have been resolved before IL gen)");
				obj9 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj10 = !flag;
				userbox = userbox2;
				if (obj10 != null)
				{
					goto IL_011a;
				}
				goto IL_01af;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_01af:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return ValidateIsMainPlayer(userbox);
			IL_00c1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v11+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ X0_v11] (should have been resolved before IL gen)");
			obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v6+E4]");
			bool flag2 = (nint)0 == 0;
			userbox = userbox2;
			if (!flag2)
			{
				goto IL_011a;
			}
			goto IL_01af;
			IL_011a:
			return ValidateIsMainPlayer(userbox2);
		}

		internal bool <get_ActiveUserBoxes>b__42_0(Userbox u)
		{
			//IL_0067: Expected I4, but got O
			if ((object)u != null)
			{
				GameObject gameObject = u.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeInHierarchy;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <ResetChanges>b__52_1(SpriteRenderer backCard)
		{
			backCard.enabled = true;
		}

		internal void <OnPlayerHandChanged>b__54_0(GameCard card)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object materialProperty = "_InputUv1BufferOffset" + 3072;
			SpriteExensions.SetAtlasRectInfo(card.sprite, isSharedMaterial: true, (string)materialProperty);
		}

		internal bool <NormalizeHardcodedGiftKey>b__59_0(char c)
		{
			//IL_000f: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_0041: Expected O, but got I4
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v2+88]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = char.IsWhiteSpace(c);
			return (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
		}
	}

	private sealed class <>c__DisplayClass52_0
	{
		public Material defaultMaterial;

		public Action<GameCard> <>9__0;

		public Action<SpriteRenderer> <>9__2;

		internal void <ResetChanges>b__0(GameCard c)
		{
			c.sprite.material = defaultMaterial;
		}

		internal void <ResetChanges>b__2(SpriteRenderer card)
		{
			card.material = defaultMaterial;
		}
	}

	private sealed class <>c__DisplayClass55_0
	{
		public AnimatedGiftNotification giftInfo;

		public AnimatedItemController <>4__this;

		internal bool <OnAnimatedGiftReceived>b__0(Userbox u)
		{
			//IL_0110: Expected I4, but got O
			//IL_00e6: Expected O, but got I4
			bool flag;
			if ((object)u != null && u.<player>k__BackingField != null)
			{
				flag = u.<player>k__BackingField.IsHuman;
				if (!flag)
				{
					goto IL_0110;
				}
				CardGamePlayer <player>k__BackingField = u.<player>k__BackingField;
				if (u.<player>k__BackingField != null)
				{
					int intDbId = SFSKammelnaUserExtensions.GetIntDbId(((KPlayer)<player>k__BackingField).<User>k__BackingField);
					AnimatedGiftNotification animatedGiftNotification = giftInfo;
					if (giftInfo != null)
					{
						object obj = intDbId - animatedGiftNotification.<TargetId>k__BackingField;
						bool flag2 = obj == null;
						flag = flag2;
						goto IL_0110;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0110:
			return flag;
		}

		internal void <OnAnimatedGiftReceived>b__1()
		{
			<>4__this.OnAnimatedGiftReceived(giftInfo);
		}

		internal bool <OnAnimatedGiftReceived>b__2(Userbox u)
		{
			//IL_0110: Expected I4, but got O
			//IL_00e6: Expected O, but got I4
			bool flag;
			if ((object)u != null && u.<player>k__BackingField != null)
			{
				flag = u.<player>k__BackingField.IsHuman;
				if (!flag)
				{
					goto IL_0110;
				}
				CardGamePlayer <player>k__BackingField = u.<player>k__BackingField;
				if (u.<player>k__BackingField != null)
				{
					int intDbId = SFSKammelnaUserExtensions.GetIntDbId(((KPlayer)<player>k__BackingField).<User>k__BackingField);
					AnimatedGiftNotification animatedGiftNotification = giftInfo;
					if (giftInfo != null)
					{
						object obj = intDbId - animatedGiftNotification.<SenderId>k__BackingField;
						bool flag2 = obj == null;
						flag = flag2;
						goto IL_0110;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0110:
			return flag;
		}
	}

	private sealed class <>c__DisplayClass56_0
	{
		public AnimatedItemController <>4__this;

		public SpriteSheetAnimatedGift gift;

		public Userbox senderUserbox;

		public Userbox receiverUserbox;

		internal void <CreateSpriteSheetAnimatedGift>b__0(GiftAnimationDataModel giftAssets)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected O, but got Unknown
			//IL_0072: Expected I, but got O
			AnimatedItemController animatedItemController = <>4__this;
			object obj = typeof(SqlSingle[]) + 2376;
			animatedItemController.itemData.SetupGift(gift, giftAssets, senderUserbox, receiverUserbox);
			object obj2 = gift;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			nint num = (nint)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v4 (Il2CppClass<System.Object>)+290]");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)0);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v7+E4]");
			if ((nint)0 != 0)
			{
				CoroutineDummy.WaitForEndOfFrame(action);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CoroutineDummy.WaitForEndOfFrame(action);
		}
	}

	private sealed class <>c__DisplayClass61_0
	{
		public GameAction action;

		internal bool <CreateCustomPlayAnimation>b__0(ICustomPlayAnimation a)
		{
			//IL_00ea: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Expected O, but got Unknown
			//IL_006c: Expected O, but got I
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			if (a != null)
			{
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2016;
				nint num = (nint)a;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<ICustomPlayAnimation>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<ICustomPlayAnimation>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<ICustomPlayAnimation>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v5-8]");
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
					goto IL_00ad;
				}
				object obj4 = num + obj3;
				object obj5 = obj4 + 312;
				goto IL_012b;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_012b:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ X0_v3] (should have been resolved before IL gen)");
			object obj7 = default(object);
			object obj6 = obj7 - action;
			return obj6 == null;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_012b;
		}
	}

	private sealed class <>c__DisplayClass62_0
	{
		public GameAction? gameAction;

		internal unsafe bool <CreateCustomMarbleAnimation>b__0(ICustomMarbleMove a)
		{
			//IL_0052: Expected I4, but got O
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0030: Expected O, but got I4
			if ((object)a != null)
			{
				System.Int32Enum? int32Enum = (System.Int32Enum?)(object)(this + 16);
				System.Int32Enum value = ((System.Int32Enum?*)int32Enum)->Value;
				object obj = (int)a.<GameAction>k__BackingField - (int)value;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass70_0
	{
		public Userbox target;

		internal bool <ClearActiveGift>b__0(IAnimatedGift g)
		{
			//IL_028e: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0035: Expected I, but got O
			//IL_0045: Expected O, but got I
			//IL_0080: Expected O, but got I
			//IL_0222: Expected O, but got I4
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_0132: Expected I, but got O
			//IL_0142: Expected O, but got I
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_01e0: Expected O, but got I
			//IL_017d: Expected O, but got I
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0243: Expected O, but got Unknown
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Expected O, but got Unknown
			//IL_0259: Unknown result type (might be due to invalid IL or missing references)
			//IL_025e: Expected O, but got Unknown
			//IL_0276: Expected O, but got I
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected O, but got Unknown
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected O, but got Unknown
			if (g == null)
			{
				goto IL_0280;
			}
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 768;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			nint num = (nint)g;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3 (Il2CppClass<IAnimatedGift>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3 (Il2CppClass<IAnimatedGift>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00c1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3 (Il2CppClass<IAnimatedGift>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v10-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00c1;
			}
			object obj5 = obj4 + 3;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_02cf;
			IL_01be:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj9 = default(object);
			object obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v126 @ X2_v6 (should have been resolved before IL gen)");
			goto IL_01ea;
			IL_012a:
			nint num2 = (nint)g;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v7 (Il2CppClass<IAnimatedGift>)+12E]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v7 (Il2CppClass<IAnimatedGift>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01be;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v7 (Il2CppClass<IAnimatedGift>)+B0]");
			object obj12 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj12 += 16;
				obj11--;
				if ((nint)obj11 != 1)
				{
					continue;
				}
				goto IL_01be;
			}
			object obj13 = obj12 + 5;
			object obj14 = num2 + obj13;
			object obj15 = obj14 + 312;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v15+8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v128 @ X2_v7 (should have been resolved before IL gen)");
			goto IL_0280;
			IL_0280:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0230:
			bool flag;
			return flag;
			IL_01ea:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object obj18 = default(UnityEngine.Object);
			flag = obj18 == target;
			bool flag2 = !flag;
			object obj19 = !flag2;
			if (obj19 != null)
			{
				goto IL_012a;
			}
			goto IL_0230;
			IL_00c1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_02cf;
			IL_02cf:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v216 @ X0_v3] (should have been resolved before IL gen)");
			object obj20 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v6+E4]");
			if ((nint)0 == 0)
			{
				goto IL_01ea;
			}
			flag = obj18 == target;
			if (flag)
			{
				goto IL_012a;
			}
			goto IL_0230;
		}
	}

	private sealed class <>c__DisplayClass74_0
	{
		public EmoteNotification emoteInfo;

		public AnimatedItemController <>4__this;

		public Userbox senderUserbox;

		public EmoteViewer emoteViewer;

		internal bool <OnEmoteReceived>b__0(Userbox u)
		{
			//IL_0110: Expected I4, but got O
			//IL_00e6: Expected O, but got I4
			bool flag;
			if ((object)u != null && u.<player>k__BackingField != null)
			{
				flag = u.<player>k__BackingField.IsHuman;
				if (!flag)
				{
					goto IL_0110;
				}
				CardGamePlayer <player>k__BackingField = u.<player>k__BackingField;
				if (u.<player>k__BackingField != null)
				{
					int intDbId = SFSKammelnaUserExtensions.GetIntDbId(((KPlayer)<player>k__BackingField).<User>k__BackingField);
					EmoteNotification emoteNotification = emoteInfo;
					if (emoteInfo != null)
					{
						object obj = intDbId - emoteNotification.<SenderId>k__BackingField;
						bool flag2 = obj == null;
						flag = flag2;
						goto IL_0110;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0110:
			return flag;
		}

		internal void <OnEmoteReceived>b__1(EmoteAnimationDataModel data)
		{
			if (data != null)
			{
				<>4__this.CreateEmote(data.<EmoteData>k__BackingField, senderUserbox, data.<SpriteSheet>k__BackingField, data.<Clip>k__BackingField);
			}
			else
			{
				emoteViewer.Reset();
			}
		}
	}

	private sealed class <>c__DisplayClass75_0
	{
		public int userId;

		internal bool <NotifyEmotePlaybackCompleted>b__0(EmoteNotification f)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (f != null)
			{
				object obj = f.<SenderId>k__BackingField - userId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private Userbox[] _userboxes;

	private AnimatedItemDataAsset itemData;

	private static AnimatedItemController <Instance>k__BackingField;

	private CardGameVisualControls <CardVisualControls>k__BackingField;

	private float <CanvasScale>k__BackingField;

	protected KGame _game;

	private readonly List<IAnimatedGift> _activeGifts;

	private readonly List<ICustomPlayAnimation> _playAnimations;

	private readonly List<ICustomMarbleMove> _marbleAnimations;

	private readonly List<EmoteNotification> _emoteNotifications;

	private static readonly Dictionary<string, GameAction> HardcodedAnimatedGiftNames;

	private Hand _playerHand;

	private int _lastActiveCardCount;

	private bool _isLastSawaAnimated;

	private bool _isGiftAffectedMainPlayer;

	public static AnimatedItemController Instance
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ca: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_0102: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(SqlSingle[]) + 3832;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B6E]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			return (AnimatedItemController)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			return (AnimatedItemController)0;
		}
		protected set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 3832;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public CardGameVisualControls CardVisualControls
	{
		get
		{
			return <CardVisualControls>k__BackingField;
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

	public bool isAnyGiftActive
	{
		get
		{
			//IL_009e: Expected I4, but got O
			//IL_007e: Expected O, but got I4
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected I4, but got Unknown
			List<IAnimatedGift> activeGifts = _activeGifts;
			if (_activeGifts != null)
			{
				bool flag = activeGifts._size < 0;
				bool flag2 = activeGifts._size == 0;
				int num = activeGifts._size ^ activeGifts._size;
				int num2 = activeGifts._size & num;
				bool flag3 = num2 < 0;
				bool flag4 = flag == flag3;
				object obj = !flag2;
				return (byte)((flag4 & obj) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public bool isSpectator
	{
		get
		{
			//IL_0041: Expected I4, but got O
			if ((object)_game != null)
			{
				return _game.IsSpectator;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public bool IsModerator
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_02a7: Expected I4, but got O
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected O, but got Unknown
			//IL_0196: Expected I, but got O
			//IL_01a6: Expected O, but got I
			//IL_0244: Expected O, but got I
			//IL_0257: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Expected O, but got Unknown
			//IL_0264: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Expected O, but got Unknown
			//IL_0272: Unknown result type (might be due to invalid IL or missing references)
			//IL_0277: Expected O, but got Unknown
			//IL_028f: Expected O, but got I
			//IL_01e1: Expected O, but got I
			//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Expected O, but got Unknown
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0202: Expected O, but got Unknown
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B70]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				goto IL_0150;
			}
			goto IL_0299;
			IL_024e:
			object obj9 = default(object);
			object obj8 = obj9 + 14;
			nint num;
			object obj10 = num + obj8;
			object obj11 = obj10 + 312;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v9+8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v96 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0299;
			IL_0222:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj15 = default(object);
			object obj14 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v5+8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v95 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_024e;
			IL_0299:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag3 = (object)sessionModel == null;
			object obj17 = !flag3;
			if (obj17 != null)
			{
				goto IL_0150;
			}
			goto IL_0299;
			IL_0150:
			User localUser = sessionModel.LocalUser;
			if (localUser != null)
			{
				object obj18 = typeof(UsageHint) + 8;
				num = (nint)localUser;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0222;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
				obj9 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X10_v4-8]");
					if (0 == (nint)obj18)
					{
						break;
					}
					obj9 += 16;
					obj19--;
					if ((nint)obj19 != 1)
					{
						continue;
					}
					goto IL_0222;
				}
				goto IL_024e;
			}
			goto IL_0299;
		}
	}

	public Transform PlayGround
	{
		get
		{
			CardGameVisualControls cardGameVisualControls = <CardVisualControls>k__BackingField;
			if ((object)<CardVisualControls>k__BackingField != null)
			{
				return cardGameVisualControls.playGround;
			}
			return (Transform)(object)new NullReferenceException();
		}
	}

	public bool isMainPlayerNotFullySeated
	{
		get
		{
			//IL_00ad: Expected I4, but got O
			KGame game = _game;
			if ((object)_game != null)
			{
				int index = game.<MySeatIndex>k__BackingField - 1;
				if (game.<MySeatIndex>k__BackingField >= 1)
				{
					if (game.<SeatStatuses>k__BackingField == null)
					{
						goto IL_009f;
					}
					System.Int32Enum int32Enum = ((List<System.Int32Enum>)(object)game.<SeatStatuses>k__BackingField).get_Item(index);
					if (int32Enum != (System.Int32Enum)6)
					{
						return true;
					}
				}
				return false;
			}
			goto IL_009f;
			IL_009f:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public bool isAnyGiftTargetMainPlayer
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_0169: Expected O, but got I
			//IL_0183: Expected O, but got I4
			//IL_0052: Expected O, but got I
			//IL_01b3: Expected O, but got I4
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_01fa: Expected O, but got I
			//IL_020a: Expected O, but got I
			//IL_021a: Expected O, but got I
			//IL_023c: Expected O, but got I4
			//IL_00f0: Expected O, but got I
			//IL_0100: Expected O, but got I
			//IL_0110: Expected O, but got I
			//IL_0132: Expected O, but got I4
			//IL_0274: Expected O, but got I4
			//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ed: Expected O, but got Unknown
			//IL_0303: Expected O, but got I
			//IL_0314: Expected I, but got O
			//IL_0332: Expected O, but got I
			//IL_02a4: Expected O, but got I
			object obj = 152985600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BCD]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BCB]");
				object obj3 = (nint)0 & (nint)1;
				if (obj3 != null)
				{
					goto IL_006f;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BCB]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_006f;
				}
			}
			_ = 1;
			bool flag2 = _activeGifts == null;
			object obj6 = !flag2;
			IEnumerable<object> activeGifts = _activeGifts;
			if (obj6 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_007e;
			IL_02a9:
			Func<object, bool> predicate;
			object obj7 = Enumerable.FirstOrDefault(activeGifts, predicate);
			bool flag3 = obj7 == null;
			return !flag3;
			IL_007e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X19_v6 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
			object obj8;
			object obj11;
			object obj13;
			object obj10;
			if ((nint)0 >= (nint)1)
			{
				obj8 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1080;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v27+E4]");
				if ((nint)0 != 0)
				{
					obj10 = (nint)0 + (nint)848;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v27+B8]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v13+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v13+8]");
					bool flag4 = (nint)0 == 0;
					object obj12 = !flag4;
					if (obj12 == null)
					{
						obj13 = obj10;
						goto IL_0252;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj8;
					obj13 = (nint)0 + (nint)848;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v27+B8]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v13+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v13+8]");
					bool flag5 = (nint)0 == 0;
					object obj14 = !flag5;
					obj10 = obj13;
					if (obj14 == null)
					{
						goto IL_0252;
					}
				}
				goto IL_02a9;
			}
			return false;
			IL_006f:
			activeGifts = _activeGifts;
			goto IL_007e;
			IL_0252:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v27+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj16 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v19+B8]");
				obj11 = 0;
			}
			object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)3384;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj11, (IntPtr)obj18);
			object obj19 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v18+B8]");
			object obj20 = (nint)0 + (nint)8;
			obj20 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj13;
			predicate = func;
			goto IL_02a9;
		}
	}

	public float CanvasScale
	{
		get
		{
			return <CanvasScale>k__BackingField;
		}
		private set
		{
			<CanvasScale>k__BackingField = value;
		}
	}

	public int ActiveGiftsCount
	{
		get
		{
			//IL_001d: Expected I4, but got O
			List<IAnimatedGift> activeGifts = _activeGifts;
			if (_activeGifts != null)
			{
				return activeGifts._size;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private Userbox[] ActiveUserBoxes
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00db: Expected O, but got I4
			//IL_0173: Expected O, but got I
			//IL_0183: Expected O, but got I
			//IL_01a5: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_0113: Expected O, but got I
			//IL_0124: Expected I, but got O
			//IL_0142: Expected O, but got I
			//IL_0082: Expected O, but got I
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1080;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+10]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+10]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12+B8]");
					obj4 = 0;
				}
				object obj8 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)3376;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v11+B8]");
				object obj11 = (nint)0 + (nint)16;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				predicate = func;
			}
			IEnumerable<object> source = Enumerable.Where(_userboxes, predicate);
			return (Userbox[])Enumerable.ToArray(source);
		}
	}

	public static event Action OnMainPlayerCardChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(SqlSingle[]) + 3832;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(SqlSingle[]) + 3832;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	private static bool ValidateIsMainPlayer(Userbox userbox)
	{
		//IL_0068: Expected I4, but got O
		//IL_002b: Expected I4, but got O
		//IL_005a: Expected I4, but got O
		if ((object)userbox != null)
		{
			if ((int)(~userbox.<player>k__BackingField) == 0)
			{
				return userbox.<player>k__BackingField.IsMe;
			}
			return (byte)(int)userbox.<player>k__BackingField != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	protected void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_011c: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01a2: Expected O, but got I4
		//IL_014a: Expected O, but got I
		//IL_0164: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 3832;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B75]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AF]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_0172;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_01b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj;
		goto IL_00dc;
		IL_00a7:
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = obj7;
		if (!flag3)
		{
			goto IL_00dc;
		}
		goto IL_01b8;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AF]");
		object obj9 = (nint)0 & (nint)1;
		if (obj9 != null)
		{
			goto IL_00a7;
		}
		goto IL_0172;
		IL_0172:
		_ = 1;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		obj8 = obj7;
		if (obj10 != null)
		{
			goto IL_00dc;
		}
		goto IL_01b8;
	}

	private void InitializeInstance()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_011c: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01a2: Expected O, but got I4
		//IL_014a: Expected O, but got I
		//IL_0164: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 3832;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B75]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AF]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_0172;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_01b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj;
		goto IL_00dc;
		IL_00a7:
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = obj7;
		if (!flag3)
		{
			goto IL_00dc;
		}
		goto IL_01b8;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AF]");
		object obj9 = (nint)0 & (nint)1;
		if (obj9 != null)
		{
			goto IL_00a7;
		}
		goto IL_0172;
		IL_0172:
		_ = 1;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		obj8 = obj7;
		if (obj10 != null)
		{
			goto IL_00dc;
		}
		goto IL_01b8;
	}

	public Userbox GetNextPlayerUserbox(KPlayer player)
	{
		//IL_0031: Expected I, but got O
		CardGameVisualControls cardGameVisualControls = <CardVisualControls>k__BackingField;
		if ((object)<CardVisualControls>k__BackingField != null)
		{
			nint num = (nint)cardGameVisualControls;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v3 @ X8_v1 (Il2CppClass<CardGameVisualControls>)+1B8] (should have been resolved before IL gen)");
		}
		return (Userbox)(object)new NullReferenceException();
	}

	protected virtual void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_024f: Expected O, but got I
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_026f: Expected O, but got I
		//IL_0299: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00bb: Expected I, but got O
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I
		//IL_010c: Expected I, but got O
		//IL_011d: Expected O, but got I
		//IL_0149: Expected I, but got O
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_016e: Expected O, but got I
		//IL_019a: Expected I, but got O
		//IL_01ab: Expected O, but got I
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_020e: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1104;
		object obj4 = (nint)0 + (nint)1736;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 64;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)1728;
		((KGame)obj7).OnAnimatedGiftSent += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj10);
		object obj11 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj12 = (nint)0 + (nint)1776;
		_game.OnGameInitialized += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj12);
		object obj13 = (nint)0 + (nint)1760;
		_game.OnPlayerSwitchSeat += playerSwitchSeatDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj13);
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1896;
		object obj15 = (nint)0 + (nint)1744;
		_game.OnRoundEnd += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj15);
		object obj16 = (nint)0 + (nint)32;
		_game.OnEmoteSent += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj17 = this + 48;
		object obj18 = default(object);
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj19 = obj17;
		object obj20 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v5+20]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform canvas = CanvasLayerExtensions.GetCanvas(CanvasLayer.SecondaryCanvas);
		Vector3 localScale = canvas.localScale;
		float num = default(float);
		<CanvasScale>k__BackingField = num;
	}

	private void OnGameInitialized()
	{
		GetMainPlayerBoxInfo();
	}

	private void OnGameRoundEnd()
	{
		ResetChanges();
	}

	private void OnPlayerSwitchSeat(int userId, string error)
	{
		GetMainPlayerBoxInfo();
	}

	public Material GetDefaultCardMaterial()
	{
		AnimatedItemDataAsset animatedItemDataAsset = itemData;
		if ((object)itemData != null)
		{
			return animatedItemDataAsset.defaultCardMaterial;
		}
		return (Material)(object)new NullReferenceException();
	}

	private void ResetChanges()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0026: Expected I4, but got O
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0099: Expected O, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I4
		//IL_0620: Expected O, but got I
		//IL_037b: Expected O, but got I
		//IL_039a: Expected O, but got I4
		//IL_00c5: Expected O, but got I
		//IL_01a3: Expected O, but got I4
		//IL_00db: Expected O, but got I
		//IL_00ec: Expected O, but got I
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03df: Expected O, but got I
		//IL_03f0: Expected I, but got O
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_046e: Expected I4, but got O
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0423: Expected O, but got I4
		//IL_043b: Expected O, but got I
		//IL_0119: Expected O, but got I
		//IL_01f6: Expected O, but got I
		//IL_0139: Expected O, but got I4
		//IL_0149: Expected O, but got I
		//IL_0275: Expected O, but got I4
		//IL_058b: Expected O, but got I
		//IL_05ad: Expected O, but got I
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected O, but got Unknown
		//IL_05c9: Expected I, but got O
		//IL_0493: Expected I, but got O
		//IL_04b3: Expected O, but got I
		//IL_04d5: Expected O, but got I4
		//IL_04e5: Expected O, but got I
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_02ad: Expected O, but got I
		//IL_02be: Expected I, but got O
		//IL_031e: Expected O, but got I
		//IL_0340: Expected O, but got I4
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_02f1: Expected O, but got I4
		//IL_0515: Expected O, but got I4
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected O, but got Unknown
		//IL_066c: Expected O, but got I
		//IL_067e: Expected I, but got O
		//IL_067e: Expected O, but got I4
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected O, but got Unknown
		//IL_06b0: Expected O, but got I
		//IL_035e: Expected O, but got I
		//IL_053b: Expected O, but got I4
		//IL_0544: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass52_0 <>c__DisplayClass52_ = default(<>c__DisplayClass52_0);
		<>c__DisplayClass52_..ctor();
		AnimatedItemDataAsset animatedItemDataAsset = itemData;
		bool flag = (byte)(int)animatedItemDataAsset.defaultCardMaterial != 0;
		object obj2 = <>c__DisplayClass52_ + 16;
		obj2 = animatedItemDataAsset.defaultCardMaterial;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Userbox[] activeUserBoxes = ActiveUserBoxes;
		if (activeUserBoxes.Length >= 1)
		{
			object obj3 = typeof(SqlSingle[]) + 3832;
			object obj4 = (nint)0 + (nint)2344;
			object obj5 = activeUserBoxes + 32;
			object obj6 = 0;
			Action<object> action4 = default(Action<object>);
			Action<object> action6 = default(Action<object>);
			bool flag8;
			Action<object> action7 = default(Action<object>);
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X27_v4+v99 @ X25_v5*8]");
				object obj7 = 0;
				Action<object> action;
				object obj8;
				CardsRevealer cardsRevealer;
				if (_isLastSawaAnimated)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v5+A8]");
					cardsRevealer = (CardsRevealer)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v5+A8]");
					((CardsRevealer)0).ResetAll();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v5+A8]");
					GameObject gameObject = ((UnityEngine.Component)0).gameObject;
					gameObject.SetActive(value: false);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v5+170]");
					GameObject gameObject2 = ((UnityEngine.Component)0).gameObject;
					gameObject2.SetActive(value: true);
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v5+170]");
					action = (Action<object>)0;
					flag = true;
				}
				Action<object> action2;
				object obj15;
				if (_isGiftAffectedMainPlayer)
				{
					object obj9 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v24+E4]");
					bool flag2 = (nint)0 == 0;
					object obj10 = !flag2;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v5+198]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v5+198]");
						if (((KPlayer)0).IsMe)
						{
							bool flag3 = !_isGiftAffectedMainPlayer;
							action2 = null;
							if (flag3)
							{
								goto IL_0448;
							}
							Hand playerHand = _playerHand;
							Action<object> action3 = (Action<object>)<>c__DisplayClass52_.<>9__0;
							bool flag4 = <>c__DisplayClass52_.<>9__0 == null;
							object obj11 = !flag4;
							if (obj11 == null)
							{
								object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj13 = (nint)0 + (nint)3392;
								action4..ctor((object)<>c__DisplayClass52_, (IntPtr)obj13);
								<>c__DisplayClass52_.<>9__0 = action4;
								object obj14 = <>c__DisplayClass52_ + 24;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								obj15 = 0;
								action3 = action4;
							}
							object obj16 = (nint)0 + (nint)2144;
							ArraysExtensions.ForEach(playerHand.gameCardsSprite, action3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v5+98]");
							action = (Action<object>)0;
							cardsRevealer = (CardsRevealer)(typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1080);
							nint num = (nint)cardsRevealer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X0_v30 (Il2CppClass<CardsRevealer>)+E4]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X0_v30 (Il2CppClass<CardsRevealer>)+B8]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v42 (Il2CppStaticFields<CardsRevealer>)+18]");
								action2 = (Action<object>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v42 (Il2CppStaticFields<CardsRevealer>)+18]");
								bool flag5 = (nint)0 == 0;
								object obj17 = !flag5;
								if (obj17 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v42 (Il2CppStaticFields<CardsRevealer>)+18]");
									Action<object> action5 = (Action<object>)0;
									nint num3 = num;
									goto IL_04f3;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								nint num3 = (nint)cardsRevealer;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v33 (Il2CppClass<CardsRevealer>)+B8]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v41 (Il2CppStaticFields<CardsRevealer>)+18]");
								Action<object> action5 = (Action<object>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v41 (Il2CppStaticFields<CardsRevealer>)+18]");
								bool flag6 = (nint)0 == 0;
								object obj18 = !flag6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v41 (Il2CppStaticFields<CardsRevealer>)+18]");
								action2 = (Action<object>)0;
								if (obj18 == null)
								{
									goto IL_04f3;
								}
							}
							goto IL_05ee;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v5+98]");
				IEnumerable<object> enumeration = (IEnumerable<object>)0;
				bool flag7 = <>c__DisplayClass52_.<>9__2 == null;
				object obj19 = !flag7;
				action2 = (Action<object>)<>c__DisplayClass52_.<>9__2;
				if (obj19 == null)
				{
					object obj20 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3496;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj21 = (nint)0 + (nint)3400;
					action6..ctor((object)<>c__DisplayClass52_, (IntPtr)obj21);
					<>c__DisplayClass52_.<>9__2 = action6;
					object obj22 = <>c__DisplayClass52_ + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj15 = 0;
					action = action6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v5+98]");
					cardsRevealer = (CardsRevealer)0;
					action2 = action6;
				}
				obj8 = obj4;
				goto IL_06c7;
				IL_0448:
				obj6++;
				flag8 = (nint)obj6 < activeUserBoxes.Length;
				flag = (byte)(int)action2 != 0;
				continue;
				IL_06c7:
				ArraysExtensions.ForEach(enumeration, action2);
				goto IL_0448;
				IL_05ee:
				obj8 = obj4;
				enumeration = (IEnumerable<object>)(object)action;
				goto IL_06c7;
				IL_04f3:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v33 (Il2CppClass<CardsRevealer>)+E4]");
				bool flag9 = (nint)0 == 0;
				object obj23 = !flag9;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj24 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3496;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj25 = (nint)0 + (nint)3368;
				action7..ctor((object)UnityEngine.Object.OffsetOfInstanceIDInCPlusPlusObject, (IntPtr)obj25);
				object obj26 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1080;
				object obj27 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v36+B8]");
				object obj28 = (nint)0 + (nint)24;
				obj28 = action7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj15 = 0;
				cardsRevealer = (CardsRevealer)UnityEngine.Object.OffsetOfInstanceIDInCPlusPlusObject;
				action2 = action7;
				goto IL_05ee;
			}
			while (flag8);
		}
		_isLastSawaAnimated = false;
	}

	private void GetMainPlayerBoxInfo()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_011c: Expected O, but got I4
		//IL_00c6: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0171: Expected O, but got I4
		//IL_017a: Expected O, but got I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01d8: Expected O, but got I
		//IL_01e4: Expected O, but got I
		//IL_01ed: Expected O, but got I4
		//IL_024e: Expected O, but got I
		//IL_0264: Expected O, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_02c9: Expected O, but got I
		//IL_0398: Expected O, but got I4
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03d2: Expected I, but got O
		//IL_0363: Expected O, but got I4
		//IL_03f3: Expected O, but got I4
		//IL_020a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B78]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		object obj8;
		object obj4;
		if (obj3 != null)
		{
			obj4 = this + 104;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (!flag)
			{
				goto IL_00a0;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 104;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v26+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj7 != null;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		object obj11 = 0;
		obj4 = obj8;
		if (obj10 == null)
		{
			goto IL_0190;
		}
		return;
		IL_0190:
		Userbox[] userboxes = _userboxes;
		if (userboxes.Length < 1)
		{
			return;
		}
		object obj12 = userboxes + 32;
		object obj13 = (nint)0 + (nint)3824;
		object obj14 = (nint)0 + (nint)1768;
		object obj15 = 0;
		object obj16 = default(object);
		Action action = default(Action);
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X26_v4+v213 @ X25_v5*8]");
			UnityEngine.Component component = (UnityEngine.Component)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X26_v4+v213 @ X25_v5*8]");
			GameObject gameObject = ((UnityEngine.Component)0).gameObject;
			if (gameObject.activeInHierarchy)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X21_v6 (UnityEngine.Component)+198]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X21_v6 (UnityEngine.Component)+198]");
					if (((KPlayer)0).IsMe)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
						obj4 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj17 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v7+E4]");
						if ((nint)0 != 0)
						{
							if (!(UnityEngine.Object)obj4)
							{
								goto IL_020f;
							}
							object obj18 = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag5 = (UnityEngine.Object)obj4;
							bool flag6 = !flag5;
							object obj18 = 0;
							if (flag6)
							{
								goto IL_020f;
							}
						}
						object obj19 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						action..ctor(this, (IntPtr)obj14);
						bool flag7 = (object)_playerHand == null;
						object obj20 = !flag7;
						if (obj20 == null)
						{
							throw new NullReferenceException();
						}
						_playerHand.OnHandChanged += action;
						obj11 = 0;
					}
				}
			}
			goto IL_020f;
			IL_020f:
			obj15++;
		}
		while ((nint)obj15 < userboxes.Length);
		return;
		IL_00a0:
		bool flag8 = obj5 != null;
		bool flag9 = !flag8;
		obj11 = 0;
		if (!flag9)
		{
			return;
		}
		goto IL_0190;
	}

	private void OnPlayerHandChanged()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_014e: Expected O, but got I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_0254: Expected O, but got I
		//IL_0264: Expected O, but got I
		//IL_0286: Expected O, but got I4
		//IL_02f7: Expected O, but got I
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_0347: Expected O, but got I4
		//IL_01ed: Expected O, but got I
		//IL_01fd: Expected O, but got I
		//IL_021f: Expected O, but got I4
		//IL_04a1: Expected O, but got I
		//IL_04b1: Expected O, but got I
		//IL_02b6: Expected O, but got I4
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_0443: Expected O, but got I
		//IL_0454: Expected I, but got O
		//IL_0472: Expected O, but got I
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_02e6: Expected O, but got I
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03ec: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B79]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object playerHand;
		UnityEngine.Object playerHand2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v32+E4]");
			bool flag = (nint)0 == 0;
			playerHand = _playerHand;
			playerHand2 = _playerHand;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			playerHand = _playerHand;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v32+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			playerHand2 = _playerHand;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = playerHand2;
		bool flag4 = !flag3;
		object obj6 = 0;
		if (flag4)
		{
			return;
		}
		goto IL_015c;
		IL_02eb:
		object obj7 = (nint)0 + (nint)2144;
		Hand playerHand3;
		Action<object> action;
		ArraysExtensions.ForEach(playerHand3.gameCardsSprite, action);
		object obj8 = typeof(SqlSingle[]) + 3832;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v8+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v12+10]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v12+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v232 @ X8_v13+18] (should have been resolved before IL gen)");
		}
		int num = default(int);
		string text = num.ToString();
		object obj13 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 864;
		string text2 = (string)obj13 + text;
		object obj14 = typeof(DataRelation) + 856;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v20+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		object message = text2;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text2;
		}
		Debug.LogWarning(message);
		return;
		IL_0294:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		object obj19;
		object obj20;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v28+B8]");
			obj20 = 0;
		}
		object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)3360;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj20, (IntPtr)obj22);
		object obj23 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v27+B8]");
		object obj24 = (nint)0 + (nint)32;
		obj24 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action2;
		goto IL_02eb;
		IL_015c:
		List<IAnimatedGift> activeGifts = _activeGifts;
		if (activeGifts._size == 0)
		{
			return;
		}
		playerHand3 = _playerHand;
		obj19 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1080;
		object obj25 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v22+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v22+B8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v22+20]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v22+20]");
			bool flag8 = (nint)0 == 0;
			object obj26 = !flag8;
			if (obj26 == null)
			{
				goto IL_0294;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v22+B8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v22+20]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v22+20]");
			bool flag9 = (nint)0 == 0;
			object obj27 = !flag9;
			if (obj27 == null)
			{
				goto IL_0294;
			}
		}
		goto IL_02eb;
		IL_0091:
		bool flag10 = playerHand;
		bool flag11 = !flag10;
		object obj28 = !flag11;
		obj6 = 0;
		if (obj28 == null)
		{
			return;
		}
		goto IL_015c;
	}

	private void OnAnimatedGiftReceived(AnimatedGiftNotification giftInfo)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00b1: Expected I, but got O
		//IL_00d7: Expected O, but got I
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_0201: Expected O, but got I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_012e: Expected O, but got I
		//IL_013f: Expected I, but got O
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0182: Expected O, but got I4
		//IL_022a: Expected O, but got I
		//IL_023b: Expected I, but got O
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0301: Expected O, but got I4
		//IL_02b5: Expected O, but got I4
		//IL_02be: Expected O, but got I4
		//IL_0339: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass55_0 <>c__DisplayClass55_ = default(<>c__DisplayClass55_0);
		<>c__DisplayClass55_..ctor();
		object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 176;
		object obj3 = (nint)0 + (nint)3408;
		object obj4 = (nint)0 + (nint)1392;
		object obj5 = <>c__DisplayClass55_ + 16;
		obj5 = giftInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = <>c__DisplayClass55_ + 24;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Userbox[] activeUserBoxes = ActiveUserBoxes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)<>c__DisplayClass55_, (IntPtr)obj3);
		object obj7 = Enumerable.FirstOrDefault(activeUserBoxes, func);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v16 (System.Object)+78]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+60]");
		if ((nint)0 == 1)
		{
			object obj9 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)3416;
			Action action = default(Action);
			action..ctor(<>c__DisplayClass55_, (IntPtr)obj10);
			object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v47+E4]");
			bool flag = (nint)0 == 0;
			object obj13 = !flag;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
			return;
		}
		object obj14 = obj5;
		object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj17 = !flag2;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v6+10]");
		StoreItem storeItem = Store.GetStoreItem(0);
		Userbox[] activeUserBoxes2 = ActiveUserBoxes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)3424;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor((object)<>c__DisplayClass55_, (IntPtr)obj18);
		object obj19 = Enumerable.FirstOrDefault(activeUserBoxes2, func2);
		object obj20 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v26+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = (UnityEngine.Object)obj19;
			bool flag4 = !flag3;
			object obj22 = !flag4;
			object obj23 = 0;
			if (obj22 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = (UnityEngine.Object)obj19;
			bool flag6 = !flag5;
			object obj23 = 0;
			if (flag6)
			{
				return;
			}
		}
		object obj24 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v29+E4]");
		bool flag7 = (nint)0 == 0;
		object obj25 = !flag7;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((bool)(UnityEngine.Object)obj7 && storeItem != null && storeItem.<isActive>k__BackingField && !TryHandleHardcodedAnimatedGift(storeItem, (Userbox)obj19, (Userbox)obj7))
		{
			CreateSpriteSheetAnimatedGift(storeItem.<id>k__BackingField, (Userbox)obj19, (Userbox)obj7);
		}
	}

	public void CreateSpriteSheetAnimatedGift(int giftId, Userbox senderUserbox, Userbox receiverUserbox)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_014a: Expected O, but got I
		//IL_0177: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass56_0 <>c__DisplayClass56_ = default(<>c__DisplayClass56_0);
		<>c__DisplayClass56_..ctor();
		object obj2 = <>c__DisplayClass56_ + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = <>c__DisplayClass56_ + 32;
		obj3 = senderUserbox;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = <>c__DisplayClass56_ + 40;
		obj4 = receiverUserbox;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = typeof(Queue<string>) + 688;
		object obj6 = (nint)0 + (nint)1888;
		SpriteSheetAnimatedGift spriteSheetAnimatedGift = itemData.CreateSpriteSheetAnimation();
		object obj7 = <>c__DisplayClass56_ + 24;
		obj7 = spriteSheetAnimatedGift;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v19+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2120;
		object obj11 = (nint)0 + (nint)3432;
		GameObject go = ((UnityEngine.Component)obj7).gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)<>c__DisplayClass56_, (IntPtr)obj11);
		((AnimatedAssetsLoader)(object)action).LoadAnimatedGiftItem(giftId, (UnityEngine.Object)go, (Action<GiftAnimationDataModel>)action);
	}

	private bool TryHandleHardcodedAnimatedGift(StoreItem storeItem, Userbox senderUserbox, Userbox receiverUserbox)
	{
		GameAction action;
		bool flag = TryMapHardcodedAnimatedGift(storeItem, out action);
		if (flag)
		{
			CreateCustomAnimatedGift(action, senderUserbox, receiverUserbox);
		}
		return flag;
	}

	private unsafe bool TryMapHardcodedAnimatedGift(StoreItem storeItem, out GameAction action)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00e5: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_0082: Expected O, but got I4
		//IL_012e: Expected O, but got I4
		//IL_01e2: Expected O, but got I
		//IL_01a8: Expected I4, but got O
		//IL_016d: Expected O, but got I
		ref GameAction reference = ref *(GameAction*)4294967196L;
		object obj;
		string key;
		if (storeItem != null)
		{
			obj = typeof(SqlSingle[]) + 3832;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				string text = NormalizeHardcodedGiftKey(storeItem.<name>k__BackingField);
				bool flag = string.IsNullOrEmpty(text);
				bool flag2 = !flag;
				object obj3 = 0;
				key = text;
				if (flag2)
				{
					goto IL_0104;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				string text2 = NormalizeHardcodedGiftKey(storeItem.<name>k__BackingField);
				bool flag3 = string.IsNullOrEmpty(text2);
				bool flag4 = !flag3;
				object obj4 = !flag4;
				object obj3 = 0;
				key = text2;
				if (obj4 == null)
				{
					goto IL_0104;
				}
			}
		}
		goto IL_0194;
		IL_0104:
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj6 = !flag5;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v7+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v7+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v7+8]");
			if (((Dictionary<object, System.Int32Enum>)0).TryGetValue(key, out System.Runtime.CompilerServices.Unsafe.As<GameAction, System.Int32Enum>(ref action)))
			{
				return true;
			}
			goto IL_0194;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0194:
		return false;
	}

	private static string NormalizeHardcodedGiftKey(string name)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		//IL_018e: Expected O, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01ae: Expected O, but got I
		//IL_01c0: Expected O, but got I
		//IL_01d0: Expected O, but got I
		//IL_01f2: Expected O, but got I4
		//IL_0014: Expected O, but got I4
		//IL_0024: Expected O, but got I
		//IL_0034: Expected O, but got I
		//IL_0121: Expected I, but got O
		//IL_00be: Expected O, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_022a: Expected O, but got I
		//IL_023b: Expected I, but got O
		//IL_0259: Expected O, but got I
		//IL_00ee: Expected O, but got I
		if (string.IsNullOrWhiteSpace(name))
		{
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v15+90]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v16+B8]");
			return (string)0;
		}
		object obj3 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1080;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		object obj6 = (nint)0 + (nint)3288;
		object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 552;
		object obj8 = (nint)0 + (nint)4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v5+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v6+28]");
		Func<char, bool> predicate = (Func<char, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v6+28]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v12+B8]");
				obj9 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 544;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)3352;
			Func<char, bool> func = default(Func<char, bool>);
			func..ctor(obj9, (IntPtr)obj14);
			object obj15 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v11+B8]");
			object obj16 = (nint)0 + (nint)40;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func;
		}
		IEnumerable<char> source = Enumerable.Where(name, predicate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<char, char> func2 = default(Func<char, char>);
		func2..ctor((object)null, (IntPtr)obj8);
		IEnumerable<char> source2 = Enumerable.Select(source, func2);
		char[] val = Enumerable.ToArray(source2);
		return ((string)null).CreateString(val);
	}

	private GameAction GetGameAction(int? actionId)
	{
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_0258: Expected I4, but got I8
		//IL_0011: Expected O, but got I
		//IL_002d: Expected O, but got I4
		//IL_003c: Expected O, but got I4
		//IL_004c: Expected O, but got I
		//IL_006e: Expected O, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00cb: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01c8: Expected O, but got I4
		object obj = (??)actionId & 1;
		int result;
		if (obj != null)
		{
			object obj2 = (nint)0 + (nint)3176;
			int? num = default(int?);
			int value = num.Value;
			object handle = 147423232 + 3704;
			object obj3 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X23_v5+E0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
			object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X23_v5+98]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object value2 = default(object);
			bool flag3 = Enum.IsDefined(typeFromHandle, value2);
			bool flag4 = !flag3;
			object obj9 = !flag4;
			result = value;
			if (obj9 != null)
			{
				goto IL_0288;
			}
			object obj10 = (??)num & -9223372036854775807L;
			if ((nint)obj10 == 1)
			{
				int value3 = num.Value;
				object obj11 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v19+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				StoreItem storeItem = Store.GetStoreItem(value3);
				if (storeItem != null && storeItem.HasGameAction)
				{
					result = (int)storeItem.<GameAction>k__BackingField;
					goto IL_0288;
				}
			}
		}
		result = -100;
		goto IL_0288;
		IL_0288:
		return (GameAction)result;
	}

	public ICustomPlayAnimation CreateCustomPlayAnimation(int? actionId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0051: Expected O, but got I4
		//IL_006b: Expected O, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I
		//IL_00b6: Expected I, but got O
		//IL_00e9: Expected O, but got I4
		//IL_00fa: Expected O, but got I4
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0266: Expected I, but got O
		//IL_0276: Expected O, but got I
		//IL_02b1: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_0157: Expected O, but got I4
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_0379: Expected O, but got I4
		//IL_0234: Expected O, but got I4
		//IL_020d: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass61_0 <>c__DisplayClass61_ = default(<>c__DisplayClass61_0);
		<>c__DisplayClass61_..ctor();
		GameAction gameAction = ((AnimatedItemController)(object)<>c__DisplayClass61_).GetGameAction(actionId);
		object obj6;
		if (<>c__DisplayClass61_ != null)
		{
			<>c__DisplayClass61_.action = gameAction;
			object obj2 = gameAction + 100;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				return null;
			}
			object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = (nint)0 + (nint)3440;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)<>c__DisplayClass61_, (IntPtr)obj5);
			obj6 = Enumerable.FirstOrDefault(_playAnimations, func);
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			object obj8 = obj6;
			object obj9 = 0;
			if (obj7 != null)
			{
				goto IL_024a;
			}
			if ((object)itemData != null)
			{
				object obj10 = (nint)0 + (nint)1800;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3147ED4");
				object obj11 = default(object);
				bool flag3 = obj11 == null;
				object obj12 = !flag3;
				object obj13 = ~obj12;
				bool flag4 = obj13 != null || obj6 == null;
				object obj14 = !flag4;
				if (obj14 == null)
				{
					return null;
				}
				if ((object)itemData != null)
				{
					if (itemData.CheckItemReusable(<>c__DisplayClass61_.action))
					{
						if (_playAnimations == null)
						{
							goto IL_0337;
						}
						object obj15 = (nint)0 + (nint)3856;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9C1C4");
					}
					bool flag5 = obj6 == null;
					obj9 = 0;
					obj6 = obj6;
					if (!flag5)
					{
						goto IL_024a;
					}
				}
			}
		}
		goto IL_0337;
		IL_03ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v206 @ X8_v14] (should have been resolved before IL gen)");
		return (ICustomPlayAnimation)obj6;
		IL_0337:
		return (ICustomPlayAnimation)new NullReferenceException();
		IL_024a:
		object obj16 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2016;
		nint num = (nint)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v13 (Il2CppClass<System.Object>)+12E]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v13 (Il2CppClass<System.Object>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02f2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v13 (Il2CppClass<System.Object>)+B0]");
		object obj18 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X10_v5-8]");
			if (0 == (nint)obj16)
			{
				break;
			}
			obj18 += 16;
			obj17--;
			if ((nint)obj17 != 1)
			{
				continue;
			}
			goto IL_02f2;
		}
		object obj19 = obj18 + 1;
		object obj20 = num + obj19;
		object obj21 = obj20 + 312;
		goto IL_03ab;
		IL_02f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj22 = default(object);
		obj21 = obj22;
		goto IL_03ab;
	}

	public unsafe ICustomMarbleMove CreateCustomMarbleAnimation(GameAction? gameAction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0084: Expected O, but got I
		//IL_0095: Expected I, but got O
		//IL_00a6: Expected O, but got I
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_011e: Expected O, but got I4
		//IL_01b2: Expected O, but got I
		//IL_02cb: Expected O, but got I4
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass62_0 <>c__DisplayClass62_ = default(<>c__DisplayClass62_0);
		<>c__DisplayClass62_..ctor();
		System.Int32Enum? int32Enum;
		object obj10 = default(object);
		if (<>c__DisplayClass62_ != null)
		{
			int32Enum = (System.Int32Enum?)(object)(<>c__DisplayClass62_ + 16);
			int32Enum = (System.Int32Enum?)gameAction;
			object obj2 = (??)gameAction & 1;
			if (obj2 != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1544;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj4 = (nint)0 + (nint)3448;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor((object)<>c__DisplayClass62_, (IntPtr)obj4);
				object obj5 = (nint)0 + (nint)864;
				object obj6 = Enumerable.FirstOrDefault(_marbleAnimations, func);
				object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12+E4]");
				if ((nint)0 != 0)
				{
					bool flag = (UnityEngine.Object)obj6 == null;
					bool flag2 = !flag;
					object obj9 = !flag2;
					if (obj9 != null)
					{
						goto IL_0179;
					}
					obj10 = obj6;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag3 = (UnityEngine.Object)obj6 == null;
					bool flag4 = !flag3;
					obj10 = obj6;
					if (!flag4)
					{
						goto IL_0179;
					}
				}
				goto IL_034b;
			}
			return null;
		}
		goto IL_0350;
		IL_034b:
		return (ICustomMarbleMove)obj10;
		IL_0179:
		System.Int32Enum value = ((System.Int32Enum?*)int32Enum)->Value;
		if ((object)itemData != null)
		{
			object obj11 = (nint)0 + (nint)1784;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31479D0");
			object obj12 = default(object);
			if (obj12 == null)
			{
				goto IL_034b;
			}
			System.Int32Enum value2 = ((System.Int32Enum?*)int32Enum)->Value;
			if ((object)itemData != null)
			{
				if (!itemData.CheckMarbleItemReusable((GameAction)value2))
				{
					goto IL_034b;
				}
				List<object> marbleAnimations = (List<object>)(object)_marbleAnimations;
				if (_marbleAnimations != null)
				{
					int version = marbleAnimations._version + 1;
					marbleAnimations._version = version;
					object[] items = marbleAnimations._items;
					if (marbleAnimations._items != null)
					{
						bool flag5 = marbleAnimations._size < items.Length;
						object obj13 = !flag5;
						if (obj13 == null)
						{
							int size = marbleAnimations._size + 1;
							marbleAnimations._size = size;
							object obj14 = marbleAnimations._items + marbleAnimations._size;
							object obj15 = obj14 + 32;
							obj15 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
						else
						{
							((List<object>)(object)_marbleAnimations).AddWithResize(obj10);
						}
						goto IL_034b;
					}
				}
			}
		}
		goto IL_0350;
		IL_0350:
		return (ICustomMarbleMove)(object)new NullReferenceException();
	}

	public ICustomSawaAnimation CreateCustomSawaAnimation(int? actionId)
	{
		//IL_00b6: Expected O, but got I4
		//IL_0030: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		int? actionId2 = default(int?);
		GameAction gameAction = GetGameAction(actionId2);
		object obj = gameAction + 100;
		bool flag = obj == null;
		ICustomSawaAnimation result = null;
		if (!flag)
		{
			if ((object)itemData == null)
			{
				return (ICustomSawaAnimation)new NullReferenceException();
			}
			object obj2 = (nint)0 + (nint)1808;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3147ED4");
			ICustomSawaAnimation customSawaAnimation = default(ICustomSawaAnimation);
			bool flag2 = default(bool);
			bool isLastSawaAnimated = customSawaAnimation != null && flag2;
			bool flag3 = !flag2;
			object obj3 = !flag3;
			object obj4 = ~obj3;
			result = ((obj4 != null) ? null : customSawaAnimation);
			_isLastSawaAnimated = isLastSawaAnimated;
		}
		return result;
	}

	public unsafe bool CreateCustomSawaAnimation(int? actionId, out ICustomSawaAnimation animation)
	{
		//IL_00ba: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_009e: Expected I4, but got O
		//IL_0030: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_008b: Expected O, but got I4
		int? actionId2 = default(int?);
		GameAction gameAction = GetGameAction(actionId2);
		object obj = gameAction + 100;
		bool flag = obj == null;
		ref ICustomSawaAnimation reference = ref animation;
		object obj2 = 0;
		if (!flag)
		{
			if ((object)itemData == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			object obj3 = (nint)0 + (nint)1808;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3147ED4");
			object obj4 = default(object);
			bool flag2 = default(bool);
			bool isLastSawaAnimated = obj4 != null && flag2;
			bool flag3 = !flag2;
			object obj5 = !flag3;
			object obj6 = ~obj5;
			obj2 = ((obj6 != null) ? ((object)0) : obj4);
			_isLastSawaAnimated = isLastSawaAnimated;
			reference = ref *(ICustomSawaAnimation*)(&obj4);
		}
		ref ICustomSawaAnimation reference2 = ref *(ICustomSawaAnimation*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag4 = animation == null;
		return !flag4;
	}

	public unsafe bool CreateCustomPlayAnimation(int? actionId, out ICustomPlayAnimation animation)
	{
		ICustomPlayAnimation customPlayAnimation = CreateCustomPlayAnimation(actionId);
		ref ICustomPlayAnimation reference = ref *(ICustomPlayAnimation*)customPlayAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = animation == null;
		return !flag;
	}

	private unsafe void CreateCustomAnimatedGift(GameAction action, Userbox sender, Userbox receiver)
	{
		//IL_0749: Expected O, but got I4
		//IL_00a0: Expected O, but got Ref
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_011d: Expected I, but got O
		//IL_012d: Expected O, but got I
		//IL_0793: Expected I, but got O
		//IL_07a3: Expected O, but got I
		//IL_0168: Expected O, but got I
		//IL_01fe: Expected I, but got O
		//IL_020e: Expected O, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_02a4: Expected I, but got O
		//IL_02c9: Expected O, but got I4
		//IL_02da: Expected O, but got I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0383: Expected I, but got O
		//IL_0393: Expected O, but got I
		//IL_0249: Expected O, but got I
		//IL_0429: Expected I, but got O
		//IL_044c: Expected O, but got I4
		//IL_0462: Expected O, but got I4
		//IL_02f6: Expected O, but got I4
		//IL_03ce: Expected O, but got I
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_0331: Expected I, but got O
		//IL_047d: Expected I, but got O
		//IL_048d: Expected O, but got I
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0535: Expected O, but got I4
		//IL_0546: Expected O, but got I4
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected O, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected O, but got Unknown
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected O, but got Unknown
		//IL_0673: Expected I, but got O
		//IL_0698: Expected O, but got I4
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_05c8: Expected O, but got I4
		//IL_04c8: Expected O, but got I
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Expected O, but got Unknown
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected O, but got Unknown
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_0710: Expected O, but got I4
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B82]");
		nint num = 0;
		GameAction gameAction = default(GameAction);
		object obj = gameAction + 100;
		if (obj == null)
		{
			return;
		}
		bool flag = (object)itemData == null;
		Userbox userbox = receiver;
		IAnimatedGift gift = null;
		Userbox userbox2 = sender;
		Userbox userbox3 = sender;
		object obj3;
		object obj9 = default(object);
		object obj6 = default(object);
		if (!flag)
		{
			num = (nint)0 + (nint)1792;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3147ED4");
			object obj2 = default(object);
			if (obj2 == null)
			{
				return;
			}
			bool flag2 = (object)receiver == null;
			userbox = null;
			userbox2 = (Userbox)(&gift);
			userbox3 = sender;
			if (!flag2)
			{
				IgnoreAffectCards(ref gift, receiver.<player>k__BackingField);
				bool flag3 = 0 == 0;
				userbox = null;
				userbox2 = (Userbox)(object)receiver.<player>k__BackingField;
				userbox3 = sender;
				if (!flag3)
				{
					obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 768;
					nint num2 = (nint)gift;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v16 (Il2CppClass<IAnimatedGift>)+12E]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v16 (Il2CppClass<IAnimatedGift>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_01b1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v16 (Il2CppClass<IAnimatedGift>)+B0]");
					object obj5 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X10_v27-8]");
						if (0 == (nint)obj3)
						{
							break;
						}
						obj6 = obj5 + 16;
						obj4--;
						bool flag4 = (nint)obj4 != 1;
						obj5 = obj6;
						if (flag4)
						{
							continue;
						}
						goto IL_01b1;
					}
					object obj7 = obj5 + 12;
					object obj8 = num2 + obj7;
					obj9 = obj8 + 312;
					obj6 = obj5;
					goto IL_078b;
				}
			}
		}
		goto IL_06b8;
		IL_078b:
		num = (nint)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v21+8]");
		userbox = (Userbox)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v428 @ X0_v21] (should have been resolved before IL gen)");
		bool flag5 = 0 == 0;
		userbox2 = receiver;
		userbox3 = null;
		object obj11;
		Userbox userbox4;
		Userbox userbox5;
		if (!flag5)
		{
			nint num3 = (nint)gift;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v19 (Il2CppClass<Userbox>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v19 (Il2CppClass<Userbox>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0292;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v19 (Il2CppClass<Userbox>)+B0]");
			obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X10_v14-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj6 = obj11 + 16;
				obj10--;
				bool flag6 = (nint)obj10 != 1;
				obj11 = obj6;
				if (flag6)
				{
					continue;
				}
				goto IL_0292;
			}
			object obj12 = obj11 + 11;
			object obj13 = num3 + obj12;
			object obj14 = obj13 + 312;
			num = (nint)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v466 @ X0_v41] (should have been resolved before IL gen)");
			bool flag7 = 0 == 0;
			userbox4 = receiver;
			userbox5 = null;
			obj6 = obj11;
			userbox2 = receiver;
			userbox3 = null;
			if (!flag7)
			{
				goto IL_037b;
			}
		}
		goto IL_06b8;
		IL_0475:
		Userbox userbox6;
		num = (nint)userbox6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v4 (Il2CppClass<Userbox>)+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v4 (Il2CppClass<Userbox>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0509;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v4 (Il2CppClass<Userbox>)+B0]");
		obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X10_v19-8]");
			bool flag8 = 0 == (nint)obj3;
			userbox2 = userbox4;
			userbox3 = userbox6;
			if (flag8)
			{
				break;
			}
			obj6 += 16;
			obj15--;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_0509;
		}
		object obj16 = obj6 + 8;
		object obj17 = num + obj16;
		object obj18 = obj17 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v306 @ X0_v5] (should have been resolved before IL gen)");
		object obj19 = default(object);
		bool flag9 = obj19 == null;
		object obj20 = !flag9;
		if (obj20 != null)
		{
			goto IL_055c;
		}
		Userbox userbox7 = userbox;
		Userbox userbox8 = userbox2;
		IntPtr intPtr = num;
		goto IL_0583;
		IL_06b8:
		throw new NullReferenceException();
		IL_0509:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v552 @ X0_v27] (should have been resolved before IL gen)");
		object obj21 = default(object);
		bool flag10 = obj21 == null;
		userbox2 = (Userbox)8;
		userbox7 = userbox;
		userbox8 = (Userbox)8;
		intPtr = num;
		if (!flag10)
		{
			goto IL_055c;
		}
		goto IL_0583;
		IL_0417:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj22 = default(object);
		num = (nint)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v503 @ X0_v31] (should have been resolved before IL gen)");
		bool flag11 = 0 == 0;
		userbox4 = (Userbox)10;
		userbox6 = null;
		obj6 = obj11;
		userbox2 = (Userbox)10;
		userbox3 = null;
		if (!flag11)
		{
			goto IL_0475;
		}
		goto IL_06b8;
		IL_055c:
		ClearActiveGift(receiver);
		userbox7 = userbox;
		userbox8 = userbox2;
		intPtr = num;
		goto IL_0583;
		IL_0292:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj23 = default(object);
		num = (nint)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v449 @ X0_v38] (should have been resolved before IL gen)");
		bool flag12 = 0 == 0;
		object obj24 = !flag12;
		obj11 = obj6;
		userbox4 = (Userbox)11;
		userbox5 = null;
		if (obj24 != null)
		{
			goto IL_037b;
		}
		userbox2 = (Userbox)11;
		userbox3 = null;
		goto IL_06b8;
		IL_037b:
		nint num4 = (nint)userbox5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v21 (Il2CppClass<Userbox>)+12E]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v21 (Il2CppClass<Userbox>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0417;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v21 (Il2CppClass<Userbox>)+B0]");
		obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X10_v19-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj11 = obj6 + 16;
			obj25--;
			bool flag13 = (nint)obj25 != 1;
			obj6 = obj11;
			if (flag13)
			{
				continue;
			}
			goto IL_0417;
		}
		object obj26 = obj6 + 10;
		object obj27 = num4 + obj26;
		object obj28 = obj27 + 312;
		num = (nint)obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v519 @ X0_v34] (should have been resolved before IL gen)");
		bool flag14 = 0 == 0;
		object obj29 = !flag14;
		userbox6 = null;
		userbox2 = userbox4;
		userbox3 = null;
		if (obj29 != null)
		{
			goto IL_0475;
		}
		goto IL_06b8;
		IL_0583:
		RegisterGift(null);
		object obj30 = typeof(SqlSingle[]) + 3832;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v12+E4]");
		bool flag15 = (nint)0 == 0;
		object obj32 = !flag15;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (receiver.<player>k__BackingField != null && receiver.<player>k__BackingField.IsMe)
		{
			_isGiftAffectedMainPlayer = true;
		}
		return;
		IL_01b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_078b;
	}

	public void CreateSpriteSheetGift(Userbox sender, Userbox receiver, Texture2D framesTexture, AudioClip clip)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		//IL_00c2: Expected O, but got I4
		SpriteSheetAnimatedGift spriteSheetAnimatedGift = itemData.CreateSpriteSheetAnimation();
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		spriteSheetAnimatedGift.SetUserboxes(sender, receiver);
		spriteSheetAnimatedGift.Setup(framesTexture, clip);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)spriteSheetAnimatedGift;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v3 (Il2CppClass<SpriteSheetAnimatedGift>)+290]");
		Action action = default(Action);
		action..ctor(spriteSheetAnimatedGift, (IntPtr)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy.WaitForEndOfFrame(action);
	}

	public void CreateEmote(EmoteItemData data, Userbox target, Texture2D framesTexture, AudioClip clip)
	{
		framesTexture.filterMode = FilterMode.Bilinear;
		target.emoteViewer.PlayEmote(clip, framesTexture, data.gridSize, data.duration, data.delayAudio, data.shiftMask);
	}

	private void IgnoreAffectCards(ref IAnimatedGift gift, KPlayer targetPlayer)
	{
		//IL_0056: Expected O, but got I4
		//IL_0036: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0125: Expected I, but got O
		//IL_0135: Expected O, but got I
		//IL_0247: Expected O, but got I
		//IL_0170: Expected O, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		bool flag = _game.IsSpectator;
		object obj;
		if (flag)
		{
			bool isModerator = ((AnimatedItemController)flag).IsModerator;
			obj = (isModerator ? 1 : 0) ^ 1;
		}
		else
		{
			obj = 1;
		}
		KPlayer myPlayer = _game.MyPlayer;
		if (targetPlayer == myPlayer)
		{
			KGame game = _game;
			int index = game.<MySeatIndex>k__BackingField - 1;
			if (game.<MySeatIndex>k__BackingField >= 1)
			{
				System.Int32Enum int32Enum = ((List<System.Int32Enum>)(object)game.<SeatStatuses>k__BackingField).get_Item(index);
				object obj2 = int32Enum - 6;
				bool flag2 = obj2 == null;
				obj = flag2 & obj;
			}
		}
		IAnimatedGift animatedGift = gift;
		object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 768;
		nint num = (nint)animatedGift;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v7 (Il2CppClass<IAnimatedGift>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v7 (Il2CppClass<IAnimatedGift>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01b1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v7 (Il2CppClass<IAnimatedGift>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X10_v5-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj5 += 16;
			obj4--;
			if ((nint)obj4 != 1)
			{
				continue;
			}
			goto IL_01b1;
		}
		object obj6 = obj5 + 9;
		object obj7 = num + obj6;
		object obj8 = obj7 + 312;
		goto IL_022f;
		IL_022f:
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v10+8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v131 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_01b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_022f;
	}

	private void ClearActiveGift(Userbox target)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00cb: Expected I, but got O
		//IL_00db: Expected O, but got I
		//IL_01f1: Expected O, but got I
		//IL_0116: Expected O, but got I
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass70_0 <>c__DisplayClass70_ = default(<>c__DisplayClass70_0);
		<>c__DisplayClass70_..ctor();
		object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1472;
		object obj3 = (nint)0 + (nint)3456;
		object obj4 = <>c__DisplayClass70_ + 16;
		obj4 = target;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)<>c__DisplayClass70_, (IntPtr)obj3);
		object obj5 = Enumerable.FirstOrDefault(_activeGifts, func);
		if (obj5 == null)
		{
			return;
		}
		object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 768;
		nint num = (nint)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v5 (Il2CppClass<System.Object>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v5 (Il2CppClass<System.Object>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0157;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v5 (Il2CppClass<System.Object>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X10_v5-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj8 += 16;
			obj7--;
			if ((nint)obj7 != 1)
			{
				continue;
			}
			goto IL_0157;
		}
		object obj9 = obj8 + 6;
		object obj10 = num + obj9;
		object obj11 = obj10 + 312;
		goto IL_01d9;
		IL_01d9:
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v6+8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v124 @ X3_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0157:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj14 = default(object);
		obj11 = obj14;
		goto IL_01d9;
	}

	public bool UnregisterGift(IAnimatedGift gift)
	{
		//IL_002c: Expected I4, but got O
		if (_activeGifts != null)
		{
			return ((List<object>)(object)_activeGifts).Remove((object)gift);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void RegisterGift(IAnimatedGift gift)
	{
		//IL_0059: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		List<object> activeGifts = (List<object>)(object)_activeGifts;
		int version = activeGifts._version + 1;
		activeGifts._version = version;
		object[] items = activeGifts._items;
		bool flag = activeGifts._size < items.Length;
		object obj = !flag;
		if (obj == null)
		{
			int size = activeGifts._size + 1;
			activeGifts._size = size;
			object obj2 = items + activeGifts._size;
			object obj3 = obj2 + 32;
			obj3 = gift;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			activeGifts.AddWithResize((object)gift);
		}
	}

	public void NotifyEmoteSent(int itemId)
	{
		_game.NotifyEmoteSent(itemId);
	}

	private void OnEmoteReceived(EmoteNotification emoteInfo)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00c5: Expected I, but got O
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_0420: Expected O, but got I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0179: Expected O, but got I
		//IL_01a6: Expected O, but got I
		//IL_01c0: Expected O, but got I4
		//IL_01e4: Expected O, but got I
		//IL_01fe: Expected O, but got I4
		//IL_038d: Expected O, but got I4
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_027d: Expected O, but got I4
		//IL_02a6: Expected O, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02f6: Expected O, but got I
		//IL_0307: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass74_0 <>c__DisplayClass74_ = default(<>c__DisplayClass74_0);
		<>c__DisplayClass74_..ctor();
		object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 176;
		object obj3 = (nint)0 + (nint)3464;
		object obj4 = (nint)0 + (nint)1392;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = <>c__DisplayClass74_ + 16;
		obj6 = emoteInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = <>c__DisplayClass74_ + 24;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Userbox[] activeUserBoxes = ActiveUserBoxes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)<>c__DisplayClass74_, (IntPtr)obj3);
		object obj8 = Enumerable.FirstOrDefault(activeUserBoxes, func);
		object obj9 = <>c__DisplayClass74_ + 32;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v19+E4]");
		if ((nint)0 != 0)
		{
			if (!(UnityEngine.Object)obj9)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = (UnityEngine.Object)obj9;
			bool flag2 = !flag;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				return;
			}
		}
		object obj12 = obj9;
		object obj13 = <>c__DisplayClass74_ + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v5+78]");
		obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Behaviour behaviour = (Behaviour)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v27 (UnityEngine.Behaviour)+60]");
		object obj14 = (nint)0 & (nint)1;
		bool flag3 = obj14 == null;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v27 (UnityEngine.Behaviour)+61]");
			object obj16 = (nint)0 & (nint)1;
			bool flag4 = obj16 == null;
			object obj17 = !flag4;
			if (obj17 == null && behaviour.isActiveAndEnabled)
			{
				((EmoteViewer)obj13).PlayLoadingEmote();
				object obj18 = typeof(Queue<string>) + 688;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v35+E4]");
				bool flag5 = (nint)0 == 0;
				object obj20 = !flag5;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj21 = (nint)0 + (nint)1888;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				object obj22 = obj6;
				GameObject go = base.gameObject;
				object obj23 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1888;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj24 = (nint)0 + (nint)3472;
				Action<object> action = default(Action<object>);
				action..ctor((object)<>c__DisplayClass74_, (IntPtr)obj24);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v20+10]");
				((AnimatedAssetsLoader)(object)action).LoadEmoteItem(0, (UnityEngine.Object)go, (Action<EmoteAnimationDataModel>)action);
				return;
			}
		}
		List<object> emoteNotifications = (List<object>)(object)_emoteNotifications;
		int version = emoteNotifications._version + 1;
		emoteNotifications._version = version;
		object[] items = emoteNotifications._items;
		bool flag6 = emoteNotifications._size < items.Length;
		object obj25 = !flag6;
		if (obj25 == null)
		{
			int size = emoteNotifications._size + 1;
			emoteNotifications._size = size;
			object obj26 = items + emoteNotifications._size;
			object obj27 = obj26 + 32;
			obj27 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			emoteNotifications.AddWithResize(obj6);
		}
	}

	public void NotifyEmotePlaybackCompleted(int userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0062: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass75_0 <>c__DisplayClass75_ = default(<>c__DisplayClass75_0);
		<>c__DisplayClass75_..ctor();
		object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 984;
		object obj3 = (nint)0 + (nint)3480;
		<>c__DisplayClass75_.userId = userId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)<>c__DisplayClass75_, (IntPtr)obj3);
		object obj4 = Enumerable.FirstOrDefault(_emoteNotifications, func);
		if (obj4 != null)
		{
			bool flag = ((List<object>)(object)_emoteNotifications).Remove(obj4);
			OnEmoteReceived((EmoteNotification)obj4);
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0273: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_0082: Expected O, but got I
		//IL_00ae: Expected I, but got O
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_00ff: Expected I, but got O
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0124: Expected O, but got I
		//IL_0150: Expected I, but got O
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0243: Expected O, but got I4
		//IL_024c: Expected O, but got I4
		//IL_01c8: Expected O, but got I4
		//IL_01ec: Expected O, but got I
		//IL_01fa: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1104;
		object obj2 = (nint)0 + (nint)1736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1752;
		_game.OnAnimatedGiftSent -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)1760;
		_game.OnGameInitialized -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		object obj6 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj7 = (nint)0 + (nint)1776;
		_game.OnRoundEnd -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj7);
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1896;
		object obj9 = (nint)0 + (nint)1744;
		_game.OnPlayerSwitchSeat -= playerSwitchSeatDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj9);
		object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
		_game.OnEmoteSent -= action4;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag = _playerHand;
			bool flag2 = !flag;
			object obj12 = 0;
			if (flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = _playerHand;
			bool flag4 = !flag3;
			object obj13 = !flag4;
			object obj12 = 0;
			if (obj13 == null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1768;
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj14);
		_playerHand.OnHandChanged -= action5;
	}

	public AnimatedItemController()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1336;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 1464;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 1456;
		object obj4 = typeof(List<AdaptivePerformanceScaler>) + 904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj5 = this + 72;
		obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj6 = this + 80;
		obj6 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list3 = default(List<object>);
		list3..ctor();
		object obj7 = this + 88;
		obj7 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list4 = default(List<object>);
		list4..ctor();
		object obj8 = this + 96;
		obj8 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	static AnimatedItemController()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_009f: Expected O, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, System.Int32Enum> dictionary = default(Dictionary<object, System.Int32Enum>);
		dictionary..ctor();
		object key = "alignContent" + 2792;
		object obj2 = (nint)0 + (nint)2648;
		object key2 = "destinationTimeZone" + 1664;
		object obj3 = typeof(SqlSingle[]) + 3832;
		dictionary.Add(key, (System.Int32Enum)0);
		dictionary.Add(key2, (System.Int32Enum)1);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v5+B8]");
		object obj5 = (nint)0 + (nint)8;
		obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
