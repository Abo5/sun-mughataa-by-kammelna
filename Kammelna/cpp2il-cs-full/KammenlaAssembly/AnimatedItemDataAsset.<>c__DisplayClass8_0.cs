using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DG.Tweening;
using Dreamteck.Splines;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class AnimatedItemDataAsset : ScriptableObject
{
	private sealed class <>c__DisplayClass13_0
	{
		public GameAction gameAction;

		internal bool <ContainsItem>b__0(AnimatedItemAssetInfo item)
		{
			if (item.gameAction == gameAction)
			{
				return item.isAnimatedGift;
			}
			return false;
		}
	}

	private sealed class <>c__DisplayClass5_0<T>
	{
		public GameAction gameAction;

		internal bool <CreatePrefabItem>b__0(AnimatedItemAssetInfo i)
		{
			//IL_0014: Expected O, but got I4
			object obj = i.gameAction - gameAction;
			return obj == null;
		}
	}

	private sealed class <>c__DisplayClass6_0<T>
	{
		public GameAction gameAction;

		internal bool <CreateMarblePrefabItem>b__0(AnimatedItemAssetInfo i)
		{
			//IL_0014: Expected O, but got I4
			object obj = i.gameAction - gameAction;
			return obj == null;
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public GameAction gameAction;

		internal bool <CheckItemReusable>b__0(AnimatedItemAssetInfo item)
		{
			if (item.gameAction == gameAction)
			{
				return item.isReusable;
			}
			return false;
		}
	}

	private sealed class <>c__DisplayClass8_0
	{
		public GameAction gameAction;

		internal bool <CheckMarbleItemReusable>b__0(AnimatedItemAssetInfo item)
		{
			if (item.gameAction == gameAction)
			{
				return item.isReusable;
			}
			return false;
		}
	}

	private Material defaultCardMaterial;

	private GameObject spriteSheetGiftTemplate;

	private List<GameObject> animationSplines;

	private List<AnimatedItemAssetInfo> _cardsAnimations;

	private List<AnimatedItemAssetInfo> _marblesAnimations;

	public unsafe bool CreatePrefabItem<T>(GameAction gameAction, out T component, List<AnimatedItemAssetInfo> customItems = null)
	{
		//IL_0016: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003e: Expected O, but got I4
		//IL_04b5: Expected I4, but got O
		//IL_00bb: Expected O, but got I4
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected O, but got Unknown
		//IL_04f2: Expected O, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_024a: Expected O, but got I4
		//IL_0253: Expected O, but got I4
		//IL_025c: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		//IL_014c: Expected O, but got I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01ea: Expected O, but got I4
		//IL_034d: Expected O, but got I4
		//IL_0388: Expected O, but got I
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_02fb: Expected O, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		((<>c__DisplayClass5_0<T>)obj4)..ctor();
		Transform transform3;
		Transform transform2;
		if (obj4 != null)
		{
			bool flag2 = customItems == null;
			object obj5 = !flag2;
			List<AnimatedItemAssetInfo> source = customItems;
			if (obj5 == null)
			{
				source = _cardsAnimations;
			}
			object obj6 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<AnimatedItemAssetInfo, bool> func = default(Func<AnimatedItemAssetInfo, bool>);
			func..ctor(obj4, (IntPtr)(nint)__ldftn(<>c__DisplayClass5_0<T>.<CreatePrefabItem>b__0));
			object obj7 = (nint)0 + (nint)600;
			AnimatedItemAssetInfo animatedItemAssetInfo = Enumerable.FirstOrDefault(source, func);
			object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v9+E4]");
			UnityEngine.Object obj10 = default(UnityEngine.Object);
			if ((nint)0 != 0)
			{
				bool flag3 = obj10 == null;
				bool flag4 = !flag3;
				object obj11 = 0;
				object obj12 = 0;
				UnityEngine.Object obj13 = null;
				if (!flag4)
				{
					goto IL_015f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag5 = obj10 == null;
				bool flag6 = !flag5;
				object obj14 = !flag6;
				object obj11 = 0;
				object obj12 = 0;
				UnityEngine.Object obj13 = null;
				if (obj14 != null)
				{
					goto IL_015f;
				}
			}
			object obj16 = default(object);
			object obj15 = obj16 & 1;
			if (obj15 != null)
			{
				CanvasLayer layer = default(CanvasLayer);
				Transform canvas = CanvasLayerExtensions.GetCanvas(layer);
				if ((object)canvas == null)
				{
					goto IL_04a7;
				}
				Transform transform = canvas.transform;
				object obj17 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v21+E4]");
				bool flag7 = (nint)0 == 0;
				object obj18 = !flag7;
				transform2 = transform;
				if (obj18 == null)
				{
					UnityEngine.Object obj13 = null;
					transform3 = transform;
					goto IL_0365;
				}
			}
			else
			{
				object obj17 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v21+E4]");
				bool flag8 = (nint)0 == 0;
				object obj19 = !flag8;
				transform3 = null;
				transform2 = null;
				if (obj19 == null)
				{
					goto IL_0365;
				}
			}
			goto IL_037c;
		}
		goto IL_04a7;
		IL_04a7:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0365:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		transform2 = transform3;
		goto IL_037c;
		IL_015f:
		ref T reference = ref *(T*)null;
		object obj20 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "Added Tournament Prizes And Features" + 1624;
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj21 = typeof(DataRelation) + 856;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v30+E4]");
		bool flag9 = (nint)0 == 0;
		object obj23 = !flag9;
		object message = text;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.LogWarning(message);
		return false;
		IL_037c:
		object obj24 = (nint)0 + (nint)544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj26 = default(object);
		object obj25 = obj26 & 1;
		GameObject gameObject = default(GameObject);
		T val;
		if (obj25 != null)
		{
			if ((object)gameObject != null)
			{
				val = gameObject.GetComponentInChildren<T>();
				goto IL_041b;
			}
		}
		else if ((object)gameObject != null)
		{
			val = gameObject.GetComponent<T>();
			goto IL_041b;
		}
		goto IL_04a7;
		IL_041b:
		reference = ref *(T*)val;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag10 = System.Runtime.CompilerServices.Unsafe.As<T, object>(ref component) == null;
		return !flag10;
	}

	public unsafe bool CreateMarblePrefabItem<T>(GameAction gameAction, out T component, List<AnimatedItemAssetInfo> customItems = null)
	{
		//IL_0016: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003e: Expected O, but got I4
		//IL_0402: Expected I4, but got O
		//IL_00bb: Expected O, but got I4
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected O, but got Unknown
		//IL_043f: Expected O, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_01a0: Expected O, but got I4
		//IL_01a9: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_029a: Expected O, but got I4
		//IL_02d5: Expected O, but got I
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_0248: Expected O, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		((<>c__DisplayClass6_0<T>)obj4)..ctor();
		Transform transform3;
		Transform transform2;
		if (obj4 != null)
		{
			bool flag2 = customItems == null;
			object obj5 = !flag2;
			List<AnimatedItemAssetInfo> source = customItems;
			if (obj5 == null)
			{
				source = _marblesAnimations;
			}
			object obj6 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<AnimatedItemAssetInfo, bool> func = default(Func<AnimatedItemAssetInfo, bool>);
			func..ctor(obj4, (IntPtr)(nint)__ldftn(<>c__DisplayClass6_0<T>.<CreateMarblePrefabItem>b__0));
			object obj7 = (nint)0 + (nint)600;
			AnimatedItemAssetInfo animatedItemAssetInfo = Enumerable.FirstOrDefault(source, func);
			object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v9+E4]");
			UnityEngine.Object obj10 = default(UnityEngine.Object);
			if ((nint)0 != 0)
			{
				bool flag3 = obj10 == null;
				bool flag4 = !flag3;
				object obj11 = 0;
				UnityEngine.Object obj12 = null;
				if (!flag4)
				{
					goto IL_0156;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag5 = obj10 == null;
				bool flag6 = !flag5;
				object obj13 = !flag6;
				object obj11 = 0;
				UnityEngine.Object obj12 = null;
				if (obj13 != null)
				{
					goto IL_0156;
				}
			}
			object obj15 = default(object);
			object obj14 = obj15 & 1;
			if (obj14 != null)
			{
				CanvasLayer layer = default(CanvasLayer);
				Transform canvas = CanvasLayerExtensions.GetCanvas(layer);
				if ((object)canvas == null)
				{
					goto IL_03f4;
				}
				Transform transform = canvas.transform;
				object obj16 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v21+E4]");
				bool flag7 = (nint)0 == 0;
				object obj17 = !flag7;
				transform2 = transform;
				if (obj17 == null)
				{
					UnityEngine.Object obj12 = null;
					transform3 = transform;
					goto IL_02b2;
				}
			}
			else
			{
				object obj16 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v21+E4]");
				bool flag8 = (nint)0 == 0;
				object obj18 = !flag8;
				transform3 = null;
				transform2 = null;
				if (obj18 == null)
				{
					goto IL_02b2;
				}
			}
			goto IL_02c9;
		}
		goto IL_03f4;
		IL_03f4:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_02b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		transform2 = transform3;
		goto IL_02c9;
		IL_0156:
		ref T reference = ref *(T*)null;
		return false;
		IL_02c9:
		object obj19 = (nint)0 + (nint)544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj21 = default(object);
		object obj20 = obj21 & 1;
		GameObject gameObject = default(GameObject);
		T val;
		if (obj20 != null)
		{
			if ((object)gameObject != null)
			{
				val = gameObject.GetComponentInChildren<T>();
				goto IL_0368;
			}
		}
		else if ((object)gameObject != null)
		{
			val = gameObject.GetComponent<T>();
			goto IL_0368;
		}
		goto IL_03f4;
		IL_0368:
		reference = ref *(T*)val;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag9 = System.Runtime.CompilerServices.Unsafe.As<T, object>(ref component) == null;
		return !flag9;
	}

	public bool CheckItemReusable(GameAction gameAction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a4: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0059: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(List<Tween>) + 3064;
			object obj4 = (nint)0 + (nint)3496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<AnimatedItemAssetInfo> predicate = default(Predicate<AnimatedItemAssetInfo>);
			predicate..ctor(obj2, (IntPtr)obj4);
			if (_cardsAnimations != null)
			{
				return _cardsAnimations.Exists(predicate);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public bool CheckMarbleItemReusable(GameAction gameAction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a4: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0059: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(List<Tween>) + 3064;
			object obj4 = (nint)0 + (nint)3504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<AnimatedItemAssetInfo> predicate = default(Predicate<AnimatedItemAssetInfo>);
			predicate..ctor(obj2, (IntPtr)obj4);
			if (_marblesAnimations != null)
			{
				return _marblesAnimations.Exists(predicate);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public SpriteSheetAnimatedGift CreateSpriteSheetAnimation()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0184: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E78DC]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)360;
			GameObject gameObject = spriteSheetGiftTemplate;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			GameObject gameObject2 = spriteSheetGiftTemplate;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)360;
			GameObject gameObject = spriteSheetGiftTemplate;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			GameObject gameObject2 = spriteSheetGiftTemplate;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9A80");
		object obj8 = default(object);
		if (obj8 != null)
		{
			goto IL_0178;
		}
		goto IL_020f;
		IL_020f:
		return (SpriteSheetAnimatedGift)(object)new NullReferenceException();
		IL_0178:
		object obj9 = (nint)0 + (nint)1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E331E4");
		SpriteSheetAnimatedGift spriteSheetAnimatedGift = default(SpriteSheetAnimatedGift);
		if ((object)spriteSheetAnimatedGift != null && (object)spriteSheetAnimatedGift.root != null)
		{
			GameObject gameObject3 = spriteSheetAnimatedGift.root.gameObject;
			if ((object)gameObject3 != null)
			{
				gameObject3.SetActive(value: false);
				return spriteSheetAnimatedGift;
			}
		}
		goto IL_020f;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9A80");
		bool flag3 = obj8 == null;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_0178;
		}
		goto IL_020f;
	}

	public void SetupGift(SpriteSheetAnimatedGift gift, GiftAnimationDataModel giftAssets, Userbox sender, Userbox receiver)
	{
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0128: Expected O, but got I4
		//IL_006e: Expected O, but got I4
		//IL_007c: Expected O, but got I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I4
		//IL_0173: Expected O, but got I4
		//IL_017c: Expected O, but got I4
		//IL_018a: Expected O, but got I4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		UnityEngine.Object obj3;
		UnityEngine.Object obj4;
		if (giftAssets != null)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			obj3 = giftAssets.<AnimationData>k__BackingField;
			obj4 = giftAssets.<AnimationData>k__BackingField;
			if (!flag)
			{
				goto IL_004c;
			}
		}
		else
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			obj3 = null;
			obj4 = null;
			if (obj5 != null)
			{
				goto IL_004c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj4 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		object obj9 = 0;
		if (obj6 != null)
		{
			goto IL_008a;
		}
		goto IL_0198;
		IL_008a:
		object obj10 = typeof(DataRelation) + 856;
		object message = "SetRoomVariables request error" + 2360;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v30+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		return;
		IL_0198:
		gift.<GiftData>k__BackingField = giftAssets.<AnimationData>k__BackingField;
		object obj13 = gift + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SpriteSheetGiftData <GiftData>k__BackingField = gift.<GiftData>k__BackingField;
		bool flag6 = !<GiftData>k__BackingField.useCanvasLayer;
		Userbox userbox = sender;
		if (!flag6)
		{
			Transform canvas = CanvasLayerExtensions.GetCanvas(<GiftData>k__BackingField.TargetCanvasLayer);
			Transform transform = canvas.transform;
			gift.root.SetParent(transform, worldPositionStays: false);
			<GiftData>k__BackingField = gift.<GiftData>k__BackingField;
			userbox = null;
		}
		SplineComputer splineComputer = CreateAnimationSpline(<GiftData>k__BackingField.animationSplineIndex, gift.root);
		object obj14 = gift.spline + 16;
		obj14 = splineComputer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		gift.senderUserbox = sender;
		object obj15 = gift + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		gift.receiverUserbox = receiver;
		object obj16 = gift + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		gift.Setup(giftAssets.<SpriteSheet>k__BackingField, giftAssets.<SoundEffect>k__BackingField);
		GameObject gameObject = gift.root.gameObject;
		gameObject.SetActive(value: true);
		return;
		IL_004c:
		bool flag7 = obj3 == null;
		bool flag8 = !flag7;
		obj7 = 0;
		obj8 = null;
		obj9 = 0;
		if (!flag8)
		{
			goto IL_008a;
		}
		goto IL_0198;
	}

	private SplineComputer CreateAnimationSpline(int index, Transform parent)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_006e: Expected O, but got I4
		//IL_0097: Expected O, but got I
		if (animationSplines != null)
		{
			object obj = (nint)0 + (nint)2592;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = (nint)0 + (nint)544;
			int index2 = default(int);
			object obj4 = ((List<object>)(object)animationSplines).get_Item(index2);
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			object obj7 = default(object);
			if (obj7 != null)
			{
				object obj8 = (nint)0 + (nint)1432;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				SplineComputer result = default(SplineComputer);
				return result;
			}
		}
		return (SplineComputer)(object)new NullReferenceException();
	}

	public Material GetDefaultCardMaterial()
	{
		return defaultCardMaterial;
	}

	public bool ContainsItem(GameAction gameAction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a4: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0059: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(List<Tween>) + 3064;
			object obj4 = (nint)0 + (nint)3488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<AnimatedItemAssetInfo> predicate = default(Predicate<AnimatedItemAssetInfo>);
			predicate..ctor(obj2, (IntPtr)obj4);
			if (_cardsAnimations != null)
			{
				return _cardsAnimations.Exists(predicate);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
