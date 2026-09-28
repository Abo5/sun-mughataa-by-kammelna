using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class CardBackSetter : AvatarComponent
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Image, bool> <>9__17_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3848;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <AssignImage>b__17_2(Image image)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return image != null;
		}
	}

	private sealed class <>c__DisplayClass15_0
	{
		public CardBackSetter <>4__this;

		public int cardBackID;

		public bool isMyCard;

		public Action<bool> onSuccess;

		public bool animateCards;

		internal void <AssignCardBack>b__0()
		{
			<>4__this.AssignCardBackHelper(cardBackID, isMyCard, onSuccess, animateCards);
		}
	}

	private sealed class <>c__DisplayClass17_0
	{
		public CardBackSetter <>4__this;

		public Action<bool> onSuccess;

		public Action<Image> <>9__3;

		internal void <AssignImage>b__0(bool success)
		{
			//IL_02dc: Expected O, but got I4
			//IL_0297: Expected O, but got I
			//IL_02a7: Expected O, but got I
			//IL_02b7: Expected O, but got I
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_00cc: Expected O, but got I
			//IL_00dc: Expected O, but got I
			//IL_00fe: Expected O, but got I4
			//IL_016f: Expected O, but got I
			//IL_0065: Expected O, but got I
			//IL_0075: Expected O, but got I
			//IL_0097: Expected O, but got I4
			//IL_012e: Expected O, but got I4
			//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fe: Expected O, but got Unknown
			//IL_0314: Expected O, but got I
			//IL_0325: Expected I, but got O
			//IL_0343: Expected O, but got I
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Expected O, but got Unknown
			//IL_01da: Expected O, but got I4
			//IL_015e: Expected O, but got I
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Expected O, but got Unknown
			//IL_0212: Expected O, but got I
			//IL_0220: Expected I, but got O
			bool flag = !success;
			object obj = !flag;
			CardBackSetter cardBackSetter;
			object obj2;
			object obj4;
			Func<object, bool> predicate;
			if (obj == null)
			{
				cardBackSetter = <>4__this;
				obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3848;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v16+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v16+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v20+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v20+8]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						goto IL_010c;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v16+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v20+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v20+8]");
					bool flag3 = (nint)0 == 0;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						goto IL_010c;
					}
				}
				goto IL_0163;
			}
			goto IL_025e;
			IL_010c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v16+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v26+B8]");
				obj4 = 0;
			}
			object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)2280;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj4, (IntPtr)obj10);
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v25+B8]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func;
			goto IL_0163;
			IL_0163:
			object obj13 = (nint)0 + (nint)1880;
			if (Enumerable.All(cardBackSetter.cards, predicate))
			{
				CardBackSetter cardBackSetter2 = <>4__this;
				object obj14 = this + 32;
				Action<object> action = (Action<object>)obj14;
				bool flag5 = obj14 == null;
				object obj15 = !flag5;
				if (obj15 == null)
				{
					object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2392;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj17 = (nint)0 + (nint)2312;
					Action<object> action2 = default(Action<object>);
					action2..ctor((object)this, (IntPtr)obj17);
					<>9__3 = action2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					action = action2;
				}
				((List<object>)(object)cardBackSetter2.cards).ForEach(action);
			}
			goto IL_025e;
			IL_025e:
			Action<bool> action3 = onSuccess;
			if (onSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4 (System.Action`1<System.Boolean>)+18]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4 (System.Action`1<System.Boolean>)+40]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4 (System.Action`1<System.Boolean>)+28]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v115 @ X3_v2 (should have been resolved before IL gen)");
			}
		}

		internal void <AssignImage>b__3(Image image)
		{
			CardBackSetter cardBackSetter = <>4__this;
			image.sprite = cardBackSetter.defaultCardBack;
		}

		internal void <AssignImage>b__1(Image image)
		{
			CardBackSetter cardBackSetter = <>4__this;
			image.sprite = cardBackSetter.defaultCardBack;
		}
	}

	private sealed class <>c__DisplayClass19_0
	{
		public CardBackSetter <>4__this;

		public User userClient;

		internal void <Initialize>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected O, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected O, but got Unknown
			//IL_012f: Expected O, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(userClient);
			User user = userClient;
			object obj = typeof(UsageHint) + 8;
			nint num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v6-8]");
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
			object obj4 = obj3 + 19;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v199 @ X0_v12] (should have been resolved before IL gen)");
			bool flag = (object)<>4__this == null;
			object obj7 = !flag;
			if (obj7 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00c6;
			IL_00c6:
			bool isMyCard = default(bool);
			<>4__this.AssignCardBack(activeCardbackID, isMyCard);
			return;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v133 @ X0_v9] (should have been resolved before IL gen)");
			goto IL_00c6;
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public StoreItem model;

		public CardBackSetter <>4__this;

		internal void <AssignMaterial>b__0(Image c)
		{
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_00a9: Expected I, but got O
			//IL_00b9: Expected O, but got I
			//IL_00c9: Expected O, but got I
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected O, but got Unknown
			StoreItem storeItem = model;
			object obj;
			if (model != null && storeItem.<isUnique>k__BackingField)
			{
				CardBackSetter cardBackSetter = <>4__this;
				obj = cardBackSetter.cardbackMaterialStore + 32;
			}
			else
			{
				CardBackSetter cardBackSetter2 = <>4__this;
				obj = cardBackSetter2.cardbackMaterialStore + 24;
			}
			object obj2 = obj;
			nint num = (nint)c;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X9_v1 (Il2CppClass<UnityEngine.UI.Image>)+348]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X9_v1 (Il2CppClass<UnityEngine.UI.Image>)+350]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v54 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private List<Image> cards;

	private RectTransform cardSizer;

	private RectTransform tiltedCard;

	private bool animateWithEnable = true;

	private bool displayUniqueOnly;

	private MaterialStore cardbackMaterialStore;

	private GameObject uniqueCardbackPS;

	private Sprite defaultCardBack;

	private int activeCardBackID;

	private bool isMyCardBack;

	private bool isInitialized;

	private GameObject _uniquePsInstance;

	private Vector3? targetRotation;

	private void OnEnable()
	{
		if (isInitialized && animateWithEnable)
		{
			AssignCardBack(activeCardBackID, isMyCardBack);
		}
	}

	public void Test(int testId)
	{
		AssignCardBack(testId);
	}

	public void AssignCardBack(int cardBackID, bool isMyCard = false, Action<bool> onSuccess = null, bool animateCards = true)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00b9: Expected I, but got O
		//IL_00e8: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2288;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj6 = obj2 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 32;
		obj7 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action);
	}

	private void AssignCardBackHelper(int cardBackID, bool isMyCard, Action<bool> onSuccess, bool animateCards)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_0356: Expected O, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0091: Expected O, but got I4
		//IL_00cd: Expected O, but got I4
		//IL_0220: Expected O, but got I
		//IL_0249: Expected O, but got I
		//IL_02d3: Expected O, but got I
		//IL_02e3: Expected O, but got I
		//IL_02f3: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		StoreItem storeItem = Store.GetStoreItem(cardBackID);
		object obj5 = this + 88;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = (UnityEngine.Object)obj5 == null;
			bool flag3 = !flag2;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				goto IL_009f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!((UnityEngine.Object)obj5 == null))
			{
				goto IL_009f;
			}
		}
		object obj8 = (nint)0 + (nint)872;
		object obj9 = ((List<object>)(object)cards).get_Item(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11 (System.Object)+D8]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		isMyCardBack = isMyCard;
		activeCardBackID = cardBackID;
		if (!isMyCard)
		{
			goto IL_00db;
		}
		goto IL_00f3;
		IL_009f:
		isMyCardBack = isMyCard;
		activeCardBackID = cardBackID;
		bool flag4 = !isMyCard;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			goto IL_00db;
		}
		goto IL_00f3;
		IL_00db:
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		goto IL_00f3;
		IL_0308:
		isInitialized = true;
		return;
		IL_00f3:
		if (!displayUniqueOnly || (cardBackID >= 1 && storeItem != null && storeItem.<isUnique>k__BackingField))
		{
			GameObject gameObject = base.gameObject;
			gameObject.SetActive(value: true);
			AssignMaterial(storeItem);
			AssignEffect(storeItem);
			AssignImage(cardBackID, onSuccess);
			if (animateCards)
			{
				ShowCardsAnimated();
				goto IL_0308;
			}
		}
		else
		{
			GameObject gameObject2 = base.gameObject;
			gameObject2.SetActive(value: false);
			if (onSuccess == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [onSuccess @ X3 (System.Action`1<System.Boolean>)+18]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [onSuccess @ X3 (System.Action`1<System.Boolean>)+40]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [onSuccess @ X3 (System.Action`1<System.Boolean>)+28]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v213 @ X3_v1 (should have been resolved before IL gen)");
		}
		ShowCards();
		goto IL_0308;
	}

	private void AssignImage(int cardBackID, Action<bool> onSuccess)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I
		//IL_010c: Expected I, but got O
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0098: Expected O, but got I
		//IL_00b3: Expected I, but got O
		//IL_0156: Expected O, but got I
		//IL_0166: Expected O, but got I
		//IL_0176: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (cardBackID >= 1)
		{
			object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj6 = (nint)0 + (nint)2296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<bool> action = default(Action<bool>);
			action..ctor(obj2, (IntPtr)obj6);
			UIExtensions.LoadItemImage(cards, cardBackID, ImageCacher.ItemImageType.InGame, action);
			return;
		}
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)2304;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj2, (IntPtr)obj8);
		((List<object>)(object)cards).ForEach(action2);
		object obj9 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v10+18]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v10+40]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v10+28]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v138 @ X3_v3 (should have been resolved before IL gen)");
		}
	}

	private void AssignEffect(StoreItem model)
	{
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_01fc: Expected O, but got I4
		//IL_013e: Expected O, but got I4
		//IL_0143: Expected I, but got O
		//IL_014d: Expected I, but got O
		//IL_007f: Expected I, but got O
		//IL_0089: Expected I, but got O
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_023d: Expected O, but got I4
		//IL_027f: Expected O, but got I4
		//IL_02a8: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		bool flag = model == null;
		UnityEngine.Object obj2 = (UnityEngine.Object)(object)model;
		if (!flag)
		{
			bool flag2 = !model.<isUnique>k__BackingField;
			obj2 = (UnityEngine.Object)(object)model;
			if (!flag2)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v14+E4]");
				if ((nint)0 != 0)
				{
					bool flag3 = uniqueCardbackPS != null;
					bool flag4 = !flag3;
					nint num = unchecked((nint)null);
					UnityEngine.Object obj4 = null;
					nint num2 = unchecked((nint)null);
					obj2 = null;
					if (!flag4)
					{
						goto IL_009c;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag5 = uniqueCardbackPS != null;
					bool flag6 = !flag5;
					object obj5 = !flag6;
					nint num = unchecked((nint)null);
					UnityEngine.Object obj4 = null;
					nint num2 = unchecked((nint)null);
					obj2 = null;
					if (obj5 != null)
					{
						goto IL_009c;
					}
				}
			}
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (!(_uniquePsInstance != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = _uniquePsInstance != null;
			bool flag8 = !flag7;
			object obj7 = !flag8;
			if (obj7 == null)
			{
				return;
			}
		}
		_uniquePsInstance.SetActive(value: false);
		return;
		IL_00fa:
		object obj8;
		((GameObject)obj8).SetActive(value: true);
		return;
		IL_009c:
		obj8 = this + 104;
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v19+E4]");
		if ((nint)0 != 0)
		{
			if ((bool)(UnityEngine.Object)obj8)
			{
				goto IL_00fa;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = (UnityEngine.Object)obj8;
			bool flag10 = !flag9;
			object obj10 = !flag10;
			if (obj10 != null)
			{
				goto IL_00fa;
			}
		}
		Transform transform = base.transform;
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v23+E4]");
		bool flag11 = (nint)0 == 0;
		object obj12 = !flag11;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = (nint)0 + (nint)544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj14 = default(object);
		obj8 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform transform2 = ((GameObject)obj8).transform;
		transform2.SetAsFirstSibling();
	}

	public override void Initialize(User userClient)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0113: Expected O, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_014f: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = userClient;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		GameObject go2 = base.gameObject;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)2320;
		object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1976;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj10);
		VariableBinderExtensions.Bind(go2, localUser, (string)varName, action);
	}

	private void AssignMaterial(StoreItem model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0111: Expected O, but got I4
		//IL_011a: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0157: Expected O, but got I
		//IL_0168: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			bool flag = cardbackMaterialStore == null;
			bool flag2 = !flag;
			object obj7 = 0;
			UnityEngine.Object obj8 = null;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = cardbackMaterialStore == null;
			bool flag4 = !flag3;
			object obj9 = !flag4;
			object obj7 = 0;
			UnityEngine.Object obj8 = null;
			if (obj9 != null)
			{
				return;
			}
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)2328;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj11);
		((List<object>)(object)cards).ForEach(action);
	}

	private void ShowCardsAnimated()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e4: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0175: Expected O, but got I4
		//IL_0126: Expected O, but got I4
		//IL_012f: Expected O, but got I4
		//IL_03c6: Expected O, but got I
		//IL_03e1: Expected O, but got I
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0247: Expected O, but got I4
		//IL_041a: Expected O, but got I
		//IL_0428: Expected I, but got O
		//IL_0434: Expected O, but got I
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_0320: Expected O, but got I4
		//IL_032e: Expected O, but got I4
		//IL_01d6: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_01ed: Expected O, but got I4
		//IL_0357: Expected O, but got I
		//IL_02d8: Expected O, but got I
		//IL_02e8: Expected O, but got I4
		//IL_02b6: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E735A]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v41+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v41+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0142;
		IL_021d:
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = tiltedCard != null;
		object obj11 = typeof(UsageHint) + 816;
		if (flag5)
		{
			tiltedCard.localEulerAngles = (Vector3)0;
		}
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v25+B8]");
		object obj13 = 0;
		cardSizer.localScale = (Vector3)0;
		goto IL_039d;
		IL_039d:
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(cardSizer, 1f, 0.3f);
		object obj14 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj15 = (nint)0 + (nint)2776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)3248;
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj17);
		object obj18 = (nint)0 + (nint)2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_01fb:
		if (animateWithEnable)
		{
			goto IL_021d;
		}
		goto IL_039d;
		IL_007d:
		bool flag6 = this == null;
		bool flag7 = !flag6;
		obj7 = 0;
		obj8 = null;
		if (!flag7)
		{
			return;
		}
		goto IL_0142;
		IL_0142:
		object obj19 = this + 112;
		object obj20 = obj19 & 1;
		bool flag8 = obj20 == null;
		object obj21 = !flag8;
		if (obj21 != null)
		{
			goto IL_01fb;
		}
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v31+E4]");
		object obj24;
		if ((nint)0 != 0)
		{
			bool flag9 = tiltedCard != null;
			bool flag10 = !flag9;
			object obj23 = !flag10;
			obj7 = 0;
			obj8 = null;
			obj24 = 0;
			if (obj23 == null)
			{
				goto IL_01fb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag11 = tiltedCard != null;
			bool flag12 = !flag11;
			obj7 = 0;
			obj8 = null;
			obj24 = 0;
			if (flag12)
			{
				goto IL_01fb;
			}
		}
		Vector3 localEulerAngles = tiltedCard.localEulerAngles;
		object obj25 = (nint)0 + (nint)768;
		Vector3? vector = (Vector3)obj25;
		bool flag13 = animateWithEnable;
		obj7 = obj24;
		obj8 = (UnityEngine.Object)obj25;
		if (flag13)
		{
			goto IL_021d;
		}
		goto IL_039d;
	}

	private unsafe void ShowCards()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e4: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0175: Expected O, but got I4
		//IL_0216: Expected O, but got I
		//IL_0230: Expected O, but got I4
		//IL_0126: Expected O, but got I4
		//IL_012f: Expected O, but got I4
		//IL_0279: Expected O, but got I4
		//IL_02f0: Expected O, but got I4
		//IL_02f9: Expected O, but got I4
		//IL_01d6: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_01e8: Expected O, but got I4
		//IL_02bc: Expected O, but got I4
		//IL_0322: Expected O, but got I
		//IL_035c: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E735B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v24+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0142;
		IL_01f6:
		RectTransform rectTransform = cardSizer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BB]");
		object obj9 = (nint)0 & (nint)1;
		bool flag4 = obj9 == null;
		object obj10 = !flag4;
		Transform transform = cardSizer;
		object obj11 = obj7;
		if (obj10 == null)
		{
			goto IL_0250;
		}
		goto IL_026b;
		IL_0250:
		_ = 1;
		transform = rectTransform;
		obj11 = obj7;
		goto IL_026b;
		IL_026b:
		transform.localScale = (Vector3)0;
		Vector3? vector;
		if ((nint)vector == 1)
		{
			Vector3 value = ((Vector3?*)vector)->Value;
			tiltedCard.localEulerAngles = (Vector3)0;
		}
		return;
		IL_007d:
		bool flag5 = this == null;
		bool flag6 = !flag5;
		obj7 = 0;
		obj8 = null;
		if (!flag6)
		{
			return;
		}
		goto IL_0142;
		IL_0142:
		vector = (Vector3?)(object)(this + 112);
		object obj12 = (??)vector & 1;
		bool flag7 = obj12 == null;
		object obj13 = !flag7;
		if (obj13 != null)
		{
			goto IL_01f6;
		}
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			bool flag8 = tiltedCard != null;
			bool flag9 = !flag8;
			object obj15 = !flag9;
			obj7 = 0;
			obj11 = 0;
			if (obj15 == null)
			{
				goto IL_01f6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag10 = tiltedCard != null;
			bool flag11 = !flag10;
			obj7 = 0;
			obj11 = 0;
			if (flag11)
			{
				goto IL_01f6;
			}
		}
		Vector3 localEulerAngles = tiltedCard.localEulerAngles;
		object value2 = (nint)0 + (nint)768;
		Vector3? vector2 = (Vector3)value2;
		vector = vector2;
		rectTransform = cardSizer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BB]");
		object obj16 = (nint)0 & (nint)1;
		bool flag12 = obj16 == null;
		obj7 = obj11;
		if (flag12)
		{
			goto IL_0250;
		}
		transform = cardSizer;
		goto IL_026b;
	}

	public override void Initialize(AvatarData avatarData)
	{
		AssignCardBack(avatarData.<CardbackId>k__BackingField, isMyCard: false, null, avatarData.<alsoAnimate>k__BackingField);
	}

	public override void Clear()
	{
		AssignCardBack(0);
	}

	private unsafe void <ShowCardsAnimated>b__21_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e6: Expected O, but got I4
		//IL_0095: Expected O, but got I4
		//IL_009e: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_0188: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_0225: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E735C]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this != null;
		bool flag3 = !flag2;
		object obj5 = 0;
		UnityEngine.Object obj6 = null;
		if (!flag3)
		{
			goto IL_0135;
		}
		return;
		IL_0135:
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag4 = tiltedCard != null;
			bool flag5 = !flag4;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(tiltedCard != null))
			{
				return;
			}
		}
		Vector3? vector = (Vector3?)(object)(this + 112);
		if ((nint)vector == 1)
		{
			Vector3 value = ((Vector3?*)vector)->Value;
			float duration = default(float);
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(tiltedCard, (Vector3)0, duration);
		}
		return;
		IL_0074:
		bool flag6 = this != null;
		bool flag7 = !flag6;
		object obj9 = !flag7;
		obj5 = 0;
		obj6 = null;
		if (obj9 == null)
		{
			return;
		}
		goto IL_0135;
	}
}
