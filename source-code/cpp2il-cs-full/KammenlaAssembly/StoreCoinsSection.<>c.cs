using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models.Products;
using Spine;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class StoreCoinsSection : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<StoreProductUi> <>9__8_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <RepopulateProducts>b__8_0(StoreProductUi product)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			GameObject gameObject = product.gameObject;
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

	private StoreProductUi productPrefab;

	private RectTransform coinsList;

	private StoreEventsChannel storeEventsChannel;

	private Store store;

	private readonly List<StoreProductUi> _instantiatedProducts;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_011f: Expected O, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_015d: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_009b: Expected O, but got I4
		//IL_00de: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)224;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)4032;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj8 = this + 56;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ContentPushService.OnStoreApplied -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		ContentPushService.OnStoreApplied += action2;
		PopulateCoinsProducts();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)4032;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ContentPushService.OnStoreApplied -= action;
	}

	public void PopulateCoinsProducts()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0153: Expected O, but got I
		//IL_016b: Expected I, but got O
		//IL_0185: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 752;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A1B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2024;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v7+E4]");
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
			object obj4 = (nint)0 + (nint)2024;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v7+E4]");
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
		goto IL_0133;
		IL_0133:
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+20]");
		((OneShotEvent)0).CallWhenReady(action);
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj10 = default(object);
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private void RepopulateProducts()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0248: Expected O, but got I
		//IL_0258: Expected O, but got I
		//IL_027a: Expected O, but got I4
		//IL_0212: Expected O, but got I4
		//IL_01c1: Expected O, but got I
		//IL_01d1: Expected O, but got I
		//IL_02aa: Expected O, but got I4
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_03b6: Expected O, but got I
		//IL_03c7: Expected I, but got O
		//IL_03e5: Expected O, but got I
		//IL_02da: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 752;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A1C]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2024;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v21+E4]");
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
			object obj4 = (nint)0 + (nint)2024;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v21+E4]");
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
		goto IL_0133;
		IL_02ec:
		Action<object> action;
		((List<object>)(object)_instantiatedProducts).ForEach(action);
		List<StoreProductUi> instantiatedProducts = _instantiatedProducts;
		int version = instantiatedProducts._version + 1;
		instantiatedProducts._size = 0;
		instantiatedProducts._version = version;
		if (instantiatedProducts._size >= 1)
		{
			Array.Clear(instantiatedProducts._items, 0, instantiatedProducts._size);
		}
		PopulateCoinsProducts();
		return;
		IL_01f6:
		bool flag3 = _instantiatedProducts == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_02ec;
		}
		goto IL_0385;
		IL_0385:
		throw new NullReferenceException();
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj9 = default(object);
		bool flag4 = obj9 == null;
		object obj10 = !flag4;
		if (obj10 != null)
		{
			goto IL_0133;
		}
		goto IL_0385;
		IL_0133:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+20]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+18]");
		if ((nint)0 != 1)
		{
			return;
		}
		object obj12 = typeof(SkeletonBinary.SkeletonInput) + 1432;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v10+E4]");
		object obj14;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v10+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v12+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v12+8]");
			if ((nint)0 != 0)
			{
				goto IL_01f6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v10+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v12+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v12+8]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 != null)
			{
				goto IL_01f6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v10+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj17 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v18+B8]");
			obj14 = 0;
		}
		object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)1496;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj14, (IntPtr)obj19);
		object obj20 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v17+B8]");
		object obj21 = (nint)0 + (nint)8;
		obj21 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action2;
		goto IL_02ec;
	}

	public void ActivateCurrencyCode()
	{
		storeEventsChannel.TriggerShowCodeActivation(ActivationCodeUI.ActivationType.GoldenCards);
	}

	public void ShowBuyForFriend()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00af: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69DA]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		BuyForFriendPopup.Show(2);
		return;
		IL_0074:
		BuyForFriendPopup.Show(2);
	}

	public StoreCoinsSection()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 64;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private unsafe void <PopulateCoinsProducts>b__7_0()
	{
		//IL_0a4a: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_011b: Expected O, but got I4
		//IL_012d: Expected O, but got I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0259: Expected O, but got I
		//IL_0265: Expected O, but got I
		//IL_037c: Expected O, but got I
		//IL_0153: Expected O, but got I4
		//IL_017f: Expected O, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_01d0: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		//IL_0ab5: Expected I4, but got O
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_0772: Expected O, but got I4
		//IL_0439: Expected O, but got I4
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got Unknown
		//IL_0b8b: Expected O, but got I4
		//IL_03e8: Expected O, but got I
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected O, but got Unknown
		//IL_07a3: Expected O, but got I
		//IL_04a3: Expected O, but got I
		//IL_0b63: Expected O, but got I4
		//IL_0850: Expected O, but got I4
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected O, but got Unknown
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected O, but got Unknown
		//IL_090d: Expected I, but got O
		//IL_0560: Expected O, but got I4
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_0807: Expected O, but got I
		//IL_050f: Expected O, but got I
		//IL_094f: Expected I, but got O
		//IL_0623: Expected O, but got I4
		//IL_0890: Expected O, but got I4
		//IL_0899: Expected O, but got I4
		//IL_08a2: Expected O, but got I4
		//IL_08be: Expected I, but got O
		//IL_0654: Expected I4, but got O
		//IL_06d1: Expected O, but got I4
		//IL_02a2: Expected O, but got I
		//IL_02c2: Expected O, but got I
		//IL_02f6: Expected O, but got I4
		//IL_02ff: Expected O, but got I4
		//IL_0308: Expected O, but got I4
		//IL_0322: Expected O, but got I4
		//IL_032b: Expected O, but got I4
		//IL_0334: Expected O, but got I4
		//IL_0356: Expected I, but got O
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected O, but got Unknown
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A1E]");
		int num = 0;
		IEnumerable<ProductViewModel> goldenCards = IAPController.GoldenCards;
		bool flag = goldenCards == null;
		object obj = 0;
		int num3;
		bool flag3 = default(bool);
		object obj6 = default(object);
		GiftInfo giftInfo;
		int num4 = default(int);
		object obj7;
		GiftInfo giftInfo2 = default(GiftInfo);
		object[] array;
		nint num5;
		if (!flag)
		{
			object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3640;
			nint num2 = (nint)goldenCards;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.Products.ProductViewModel>>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.Products.ProductViewModel>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.Products.ProductViewModel>>)+B0]");
			num3 = (int)((nint)0 + (nint)8);
			bool flag2 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X10_v11 (System.Int32)-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				num4 = num3 + 16;
				obj3--;
				flag3 = (nint)obj3 != 1;
				flag2 = flag3;
				num3 = num4;
				if (flag3)
				{
					continue;
				}
				goto IL_00d5;
			}
			object obj4 = num2 + ((int*)num3)->m_value;
			object obj5 = obj4 + 312;
			array = (object[])obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v38+8]");
			num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v295 @ X8_v38] (should have been resolved before IL gen)");
			bool flag4 = obj6 == null;
			obj = obj6;
			obj7 = 0;
			flag3 = flag2;
			num4 = num3;
			obj = obj6;
			obj7 = 0;
			giftInfo = giftInfo2;
			num = (int)(&obj);
			if (!flag4)
			{
				goto IL_0211;
			}
			goto IL_08c3;
		}
		goto IL_0a58;
		IL_0993:
		giftInfo2 = giftInfo;
		num4 = num3;
		goto IL_0a58;
		IL_08d1:
		NullReferenceException ex = new NullReferenceException();
		object obj9;
		object obj8 = obj9;
		object obj11;
		object obj10 = obj11;
		object obj13;
		object obj12 = obj13;
		bool flag6;
		bool flag5 = flag6;
		num3 = num4;
		num5 = (nint)coinsList;
		goto IL_0993;
		IL_0a58:
		throw new NullReferenceException();
		IL_0912:
		NullReferenceException ex2 = new NullReferenceException();
		obj8 = obj9;
		obj10 = obj11;
		obj12 = obj13;
		flag5 = false;
		giftInfo = null;
		num3 = num4;
		num5 = unchecked((nint)null);
		goto IL_0993;
		IL_08c3:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0993;
		IL_00d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj14 = default(object);
		array = (object[])obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v58+8]");
		num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v183 @ X0_v58] (should have been resolved before IL gen)");
		bool flag7 = obj6 == null;
		object obj15 = !flag7;
		obj = obj6;
		obj7 = 0;
		giftInfo2 = null;
		if (obj15 != null)
		{
			goto IL_0211;
		}
		obj = obj6;
		obj7 = 0;
		giftInfo = null;
		num3 = num4;
		num = (int)(&obj);
		goto IL_08c3;
		IL_0211:
		object obj16 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj17 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1072;
		object obj18 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj19 = (nint)0 + (nint)728;
		object obj20 = (nint)0 + (nint)3024;
		obj9 = obj8;
		obj11 = obj10;
		obj13 = obj12;
		flag6 = flag5;
		object obj21 = obj6;
		object obj24 = default(object);
		object obj26 = default(object);
		object obj36 = default(object);
		StoreProductUi storeProductUi = default(StoreProductUi);
		ProductViewModel product = default(ProductViewModel);
		while (true)
		{
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v20+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v20+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0418;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v20+B0]");
			int num6 = (int)((nint)0 + (nint)8);
			bool flag8 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X10_v26 (System.Int32)-8]");
				if (0 == (nint)obj16)
				{
					break;
				}
				num4 = num6 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v20+12E]");
				array = (object[])(-1);
				flag3 = (nint)array != 1;
				flag8 = flag3;
				num6 = num4;
				if (flag3)
				{
					continue;
				}
				goto IL_0418;
			}
			array = (object[])((int*)num6)->m_value;
			object obj23 = obj22 + ((int*)num6)->m_value;
			obj24 = obj23 + 312;
			flag3 = flag8;
			num4 = num6;
			goto IL_0aad;
			IL_0aad:
			num = (int)obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v29+8]");
			num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v544 @ X0_v29] (should have been resolved before IL gen)");
			object obj25 = obj26 & 1;
			if (obj25 != null)
			{
				if (obj == null)
				{
					break;
				}
				object obj27 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v23+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v23+12E]");
				if ((nint)0 == 0)
				{
					goto IL_053f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v23+B0]");
				int num7 = (int)((nint)0 + (nint)8);
				bool flag9 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X10_v21 (System.Int32)-8]");
					if (0 == (nint)obj17)
					{
						break;
					}
					num4 = num7 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v23+12E]");
					array = (object[])(-1);
					flag3 = (nint)array != 1;
					flag9 = flag3;
					num7 = num4;
					if (flag3)
					{
						continue;
					}
					goto IL_053f;
				}
				array = (object[])((int*)num7)->m_value;
				object obj28 = obj27 + ((int*)num7)->m_value;
				object obj29 = obj28 + 312;
				flag3 = flag9;
				num4 = num7;
				goto IL_0b1f;
			}
			obj8 = obj9;
			obj10 = obj11;
			obj12 = obj13;
			flag5 = flag6;
			object obj30 = 0;
			while (true)
			{
				if (obj == null)
				{
					goto IL_0b71;
				}
				object obj31 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj32 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v7+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v7+12E]");
				if ((nint)0 == 0)
				{
					goto IL_082f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v7+B0]");
				int num8 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X10_v7 (System.Int32)-8]");
					if (0 == (nint)obj31)
					{
						break;
					}
					num4 = num8 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v7+12E]");
					array = (object[])(-1);
					bool flag10 = (nint)array != 1;
					num8 = num4;
					if (flag10)
					{
						continue;
					}
					goto IL_082f;
				}
				array = (object[])((int*)num8)->m_value;
				object obj33 = obj32 + ((int*)num8)->m_value;
				object obj34 = obj33 + 312;
				num4 = num8;
				goto IL_0bbd;
				IL_0b71:
				bool flag11 = obj30 == null;
				object obj35 = !flag11;
				if (obj35 == null)
				{
					return;
				}
				OutOfMemoryException ex4 = new OutOfMemoryException();
				if (num5 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj30 = obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj7 = obj36;
				continue;
				IL_082f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				giftInfo2 = null;
				goto IL_0bbd;
				IL_0bbd:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v6+8]");
				num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v750 @ X0_v6] (should have been resolved before IL gen)");
				goto IL_0b71;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_053f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			giftInfo2 = null;
			goto IL_0b1f;
			IL_0b1f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v758 @ X0_v33] (should have been resolved before IL gen)");
			object obj37 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X0_v36+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X0_v36+E4]");
			bool flag12 = (nint)0 == 0;
			object obj38 = !flag12;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			giftInfo = (GiftInfo)obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			if ((object)storeProductUi == null)
			{
				goto IL_08d1;
			}
			storeProductUi.PopulateProduct(product);
			RectTransform rectTransform = UIExtensions.rectTransform(storeProductUi);
			if ((object)rectTransform != null)
			{
				rectTransform.localScale = (Vector3)0;
				List<object> instantiatedProducts = (List<object>)(object)_instantiatedProducts;
				if (_instantiatedProducts != null)
				{
					num = (int)obj20;
					int version = instantiatedProducts._version + 1;
					instantiatedProducts._version = version;
					array = instantiatedProducts._items;
					if (instantiatedProducts._items != null)
					{
						num4 = instantiatedProducts._size;
						bool flag13 = instantiatedProducts._size < array.Length;
						object obj39 = !flag13;
						object obj41;
						if (obj39 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v27 (System.Int32)+20]");
							object obj40 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v31+C0]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v27 (System.Int32)+70]");
							giftInfo2 = (GiftInfo)0;
							((List<object>)(object)_instantiatedProducts).AddWithResize((object)storeProductUi);
							obj41 = storeProductUi;
						}
						else
						{
							num = instantiatedProducts._size + 1;
							instantiatedProducts._size = num;
							object obj42 = instantiatedProducts._items + instantiatedProducts._size;
							object obj43 = obj42 + 32;
							obj43 = storeProductUi;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							giftInfo2 = null;
							obj41 = storeProductUi;
						}
						bool flag14 = obj == null;
						obj9 = 1069128090;
						obj11 = 1069128090;
						obj13 = 1069128090;
						flag6 = false;
						obj21 = obj;
						obj8 = 1069128090;
						obj10 = 1069128090;
						obj12 = 1069128090;
						flag5 = false;
						giftInfo = giftInfo2;
						num3 = num4;
						num5 = (nint)obj41;
						if (!flag14)
						{
							continue;
						}
						goto IL_08c3;
					}
				}
				goto IL_087e;
			}
			goto IL_0912;
			IL_0418:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			giftInfo2 = null;
			goto IL_0aad;
		}
		NullReferenceException ex5 = new NullReferenceException();
		obj8 = obj9;
		obj10 = obj11;
		obj12 = obj13;
		flag5 = flag6;
		giftInfo = giftInfo2;
		num3 = num4;
		goto IL_0993;
		IL_087e:
		NullReferenceException ex6 = new NullReferenceException();
		obj8 = 1069128090;
		obj10 = 1069128090;
		obj12 = 1069128090;
		flag5 = false;
		giftInfo = null;
		num3 = num4;
		num5 = unchecked((nint)null);
		goto IL_0993;
	}
}
