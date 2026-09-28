using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DataTracking;
using Features.GameReplay;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models.Products;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class NotEnoughAcesPopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass10_0
	{
		public long remaining;

		internal void <ShowNotEnoughAces>b__0(NotEnoughAcesPopup instance)
		{
			instance.popup.PopFromCenter();
			instance.DeleteProducts();
			instance.Setup(remaining);
		}
	}

	private sealed class <>c__DisplayClass13_0
	{
		public long remaining;

		public NotEnoughAcesPopup <>4__this;

		internal void <Populate>b__0()
		{
			//IL_08ea: Expected O, but got I4
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0022: Expected I, but got O
			//IL_0032: Expected O, but got I
			//IL_00fc: Expected O, but got I4
			//IL_010e: Expected O, but got I4
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Expected O, but got Unknown
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Expected O, but got Unknown
			//IL_020b: Expected O, but got I
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Expected O, but got Unknown
			//IL_022b: Expected O, but got I
			//IL_006d: Expected O, but got I
			//IL_02b5: Expected O, but got I
			//IL_0134: Expected O, but got I4
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Expected O, but got Unknown
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected O, but got Unknown
			//IL_01a5: Expected O, but got I4
			//IL_01c0: Expected O, but got I4
			//IL_0971: Unknown result type (might be due to invalid IL or missing references)
			//IL_0976: Expected O, but got Unknown
			//IL_02f0: Expected O, but got I
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0634: Expected O, but got I4
			//IL_0373: Unknown result type (might be due to invalid IL or missing references)
			//IL_0378: Expected O, but got Unknown
			//IL_0a0a: Expected O, but got I4
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0303: Expected O, but got Unknown
			//IL_0319: Expected O, but got I
			//IL_0648: Unknown result type (might be due to invalid IL or missing references)
			//IL_064d: Expected O, but got Unknown
			//IL_0665: Expected O, but got I
			//IL_03ba: Expected O, but got I
			//IL_06a0: Expected O, but got I
			//IL_03f5: Expected O, but got I
			//IL_0723: Unknown result type (might be due to invalid IL or missing references)
			//IL_0728: Expected O, but got Unknown
			//IL_0478: Unknown result type (might be due to invalid IL or missing references)
			//IL_047d: Expected O, but got Unknown
			//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b3: Expected O, but got Unknown
			//IL_06c9: Expected O, but got I
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Expected O, but got Unknown
			//IL_041e: Expected O, but got I
			//IL_04cc: Expected I, but got O
			//IL_0560: Expected I, but got O
			//IL_056d: Expected I8, but got O
			//IL_0598: Expected O, but got I4
			//IL_082e: Expected I, but got O
			//IL_051c: Expected I, but got O
			//IL_0600: Expected O, but got I4
			//IL_0616: Expected I, but got O
			IEnumerable<ProductViewModel> goldenCards = IAPController.GoldenCards;
			bool flag = goldenCards == null;
			object obj = 0;
			object obj4;
			object obj9 = default(object);
			GiftInfo giftInfo;
			object obj8;
			object obj5 = default(object);
			object obj10;
			GiftInfo giftInfo2 = default(GiftInfo);
			nint num2;
			if (!flag)
			{
				object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3640;
				nint num = (nint)goldenCards;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.Products.ProductViewModel>>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.Products.ProductViewModel>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00b6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.Products.ProductViewModel>>)+B0]");
				obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X10_v11-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj5 = obj4 + 16;
					obj3--;
					bool flag2 = (nint)obj3 != 1;
					obj4 = obj5;
					if (flag2)
					{
						continue;
					}
					goto IL_00b6;
				}
				object obj6 = num + obj4;
				object obj7 = obj6 + 312;
				obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v37+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v283 @ X8_v37] (should have been resolved before IL gen)");
				bool flag3 = obj9 == null;
				obj = obj9;
				obj10 = 0;
				obj5 = obj4;
				obj = obj9;
				obj10 = 0;
				giftInfo = giftInfo2;
				if (!flag3)
				{
					goto IL_01d7;
				}
				goto IL_0736;
			}
			goto IL_08f8;
			IL_07fd:
			NullReferenceException ex = new NullReferenceException();
			object obj12;
			object obj11 = obj12;
			bool flag5;
			bool flag4 = flag5;
			giftInfo = giftInfo2;
			obj4 = obj5;
			object obj13;
			num2 = (nint)obj13;
			goto IL_0833;
			IL_07a0:
			NullReferenceException ex2 = new NullReferenceException();
			obj11 = obj12;
			flag4 = flag5;
			giftInfo = giftInfo2;
			obj4 = obj5;
			goto IL_0833;
			IL_0736:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_0833;
			IL_0744:
			NullReferenceException ex4 = new NullReferenceException();
			obj11 = obj12;
			flag4 = flag5;
			giftInfo = giftInfo2;
			obj4 = obj5;
			goto IL_0833;
			IL_0833:
			giftInfo2 = giftInfo;
			obj5 = obj4;
			goto IL_08f8;
			IL_00b6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj14 = default(object);
			obj8 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v56+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v177 @ X0_v56] (should have been resolved before IL gen)");
			bool flag6 = obj9 == null;
			object obj15 = !flag6;
			obj = obj9;
			obj10 = 0;
			giftInfo2 = null;
			if (obj15 != null)
			{
				goto IL_01d7;
			}
			obj = obj9;
			obj10 = 0;
			giftInfo = null;
			obj4 = obj5;
			goto IL_0736;
			IL_01d7:
			object obj16 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			object obj17 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1072;
			obj13 = (nint)0 + (nint)1728;
			object obj18 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj19 = (nint)0 + (nint)728;
			obj12 = obj11;
			flag5 = flag4;
			IntPtr intPtr = default(IntPtr);
			nint num3 = intPtr;
			object obj20 = obj9;
			ProductViewModel productViewModel = default(ProductViewModel);
			StoreProductUi storeProductUi = default(StoreProductUi);
			object obj29 = default(object);
			object obj41 = default(object);
			while (true)
			{
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v20+12E]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v20+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0341;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v20+B0]");
				object obj22 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X10_v25-8]");
					if (0 == (nint)obj16)
					{
						break;
					}
					obj5 = obj22 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v20+12E]");
					obj8 = -1;
					bool flag7 = (nint)obj8 != 1;
					obj22 = obj5;
					if (flag7)
					{
						continue;
					}
					goto IL_0341;
				}
				obj8 = obj22;
				object obj23 = obj21 + obj22;
				object obj24 = obj23 + 312;
				obj5 = obj22;
				goto IL_094d;
				IL_0250:
				bool flag8 = obj == null;
				obj20 = obj;
				obj11 = obj12;
				flag4 = flag5;
				giftInfo = giftInfo2;
				obj4 = obj5;
				nint num4;
				num2 = num4;
				if (!flag8)
				{
					continue;
				}
				goto IL_0736;
				IL_0446:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				giftInfo2 = null;
				goto IL_09b8;
				IL_09b8:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X0_v33+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v757 @ X0_v33] (should have been resolved before IL gen)");
				if (productViewModel == null)
				{
					goto IL_0744;
				}
				long num5 = remaining;
				if (remaining > productViewModel.<coins>k__BackingField)
				{
					IEnumerable<ProductViewModel> goldenCards2 = IAPController.GoldenCards;
					num4 = (nint)obj13;
					object obj25 = Enumerable.Last((IEnumerable<object>)goldenCards2);
					if (obj25 == null)
					{
						goto IL_07fd;
					}
					long num6 = remaining;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X0_v47 (System.Object)+20]");
					bool flag9 = num6 < 0;
					num2 = (nint)obj13;
					if (flag9)
					{
						goto IL_0250;
					}
				}
				NotEnoughAcesPopup notEnoughAcesPopup = <>4__this;
				if ((object)<>4__this == null)
				{
					goto IL_07a0;
				}
				num3 = (nint)notEnoughAcesPopup.coinsList;
				num5 = (long)notEnoughAcesPopup.productPrefab;
				object obj26 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X0_v39+E4]");
				bool flag10 = (nint)0 == 0;
				object obj27 = !flag10;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				giftInfo = (GiftInfo)obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
				if ((object)storeProductUi != null)
				{
					storeProductUi.PopulateProduct(productViewModel, null, usePopup: true);
					obj12 = 0;
					flag5 = true;
					giftInfo2 = null;
					num4 = (nint)productViewModel;
					goto IL_0250;
				}
				goto IL_07cf;
				IL_0341:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				giftInfo2 = null;
				goto IL_094d;
				IL_094d:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v29+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v546 @ X0_v29] (should have been resolved before IL gen)");
				object obj28 = obj29 & 1;
				if (obj28 != null)
				{
					if (obj == null)
					{
						break;
					}
					object obj30 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v23+12E]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v23+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0446;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v23+B0]");
					object obj31 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X10_v20-8]");
						if (0 == (nint)obj17)
						{
							break;
						}
						obj5 = obj31 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v23+12E]");
						obj8 = -1;
						bool flag11 = (nint)obj8 != 1;
						obj31 = obj5;
						if (flag11)
						{
							continue;
						}
						goto IL_0446;
					}
					obj8 = obj31;
					object obj32 = obj30 + obj31;
					object obj33 = obj32 + 312;
					obj5 = obj31;
					goto IL_09b8;
				}
				obj11 = obj12;
				flag4 = flag5;
				object obj34 = 0;
				while (true)
				{
					if (obj == null)
					{
						goto IL_09f0;
					}
					object obj35 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
					object obj36 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v7+12E]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v7+12E]");
					if ((nint)0 == 0)
					{
						goto IL_06f1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v7+B0]");
					object obj37 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X10_v7-8]");
						if (0 == (nint)obj35)
						{
							break;
						}
						obj5 = obj37 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v7+12E]");
						obj8 = -1;
						bool flag12 = (nint)obj8 != 1;
						obj37 = obj5;
						if (flag12)
						{
							continue;
						}
						goto IL_06f1;
					}
					obj8 = obj37;
					object obj38 = obj36 + obj37;
					object obj39 = obj38 + 312;
					obj5 = obj37;
					goto IL_0a3c;
					IL_09f0:
					bool flag13 = obj34 == null;
					object obj40 = !flag13;
					if (obj40 == null)
					{
						return;
					}
					OutOfMemoryException ex5 = new OutOfMemoryException();
					if (num2 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj34 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					obj10 = obj41;
					continue;
					IL_06f1:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					giftInfo2 = null;
					goto IL_0a3c;
					IL_0a3c:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v6+8]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v750 @ X0_v6] (should have been resolved before IL gen)");
					goto IL_09f0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
			}
			NullReferenceException ex6 = new NullReferenceException();
			obj11 = obj12;
			flag4 = flag5;
			giftInfo = giftInfo2;
			obj4 = obj5;
			goto IL_0833;
			IL_08f8:
			throw new NullReferenceException();
			IL_07cf:
			NullReferenceException ex7 = new NullReferenceException();
			obj11 = obj12;
			flag4 = flag5;
			obj4 = obj5;
			num2 = num3;
			goto IL_0833;
		}
	}

	private static readonly AddressReference<NotEnoughAcesPopup> Address;

	private static TrackingFeature _trackingFeature;

	private RectTransform coinsList;

	private StoreProductUi productPrefab;

	private PopupUI popup;

	private TextMeshProUGUI myaces;

	private TextMeshProUGUI description;

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00e7: Expected O, but got I
		//IL_0111: Expected O, but got I4
		//IL_004f: Expected I, but got O
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0074: Expected O, but got I
		//IL_00a8: Expected I, but got O
		object obj = typeof(Queue<string>) + 752;
		object obj2 = (nint)0 + (nint)2024;
		object obj3 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1840;
		object obj4 = (nint)0 + (nint)3384;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IAPController.IAPAction iAPAction = default(IAPController.IAPAction);
		iAPAction..ctor(this, (IntPtr)obj4);
		object obj7 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1848;
		object obj8 = (nint)0 + (nint)3392;
		IAPController iAPController = default(IAPController);
		iAPController.OnIAPPurchaseComplete += iAPAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IAPController.IAPFailure iAPFailure = default(IAPController.IAPFailure);
		iAPFailure..ctor(this, (IntPtr)obj8);
		IAPController iAPController2 = default(IAPController);
		iAPController2.OnIAPPurchaseFailed += iAPFailure;
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00e7: Expected O, but got I
		//IL_0111: Expected O, but got I4
		//IL_004f: Expected I, but got O
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0074: Expected O, but got I
		//IL_00a8: Expected I, but got O
		object obj = typeof(Queue<string>) + 752;
		object obj2 = (nint)0 + (nint)2024;
		object obj3 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1840;
		object obj4 = (nint)0 + (nint)3384;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IAPController.IAPAction iAPAction = default(IAPController.IAPAction);
		iAPAction..ctor(this, (IntPtr)obj4);
		object obj7 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1848;
		object obj8 = (nint)0 + (nint)3392;
		IAPController iAPController = default(IAPController);
		iAPController.OnIAPPurchaseComplete -= iAPAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IAPController.IAPFailure iAPFailure = default(IAPController.IAPFailure);
		iAPFailure..ctor(this, (IntPtr)obj8);
		IAPController iAPController2 = default(IAPController);
		iAPController2.OnIAPPurchaseFailed -= iAPFailure;
	}

	public void Close()
	{
		popup.ShrinkToParent();
	}

	public static void ShowNotEnoughAces(long remaining, TrackingFeature feature)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0090: Expected O, but got I4
		//IL_0168: Expected O, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_018c: Expected O, but got I
		//IL_01a7: Expected I, but got O
		//IL_01d1: Expected O, but got I4
		//IL_00e6: Expected O, but got I
		//IL_0127: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2608;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2816;
		object obj5 = (nint)0 + (nint)2592;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		object obj9 = (nint)0 + (nint)2176;
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v6+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v6+B8]");
		object obj15 = 0;
		ITrackEvent trackEvent = TrackerLibrary.NotEnoughAcesPopupViewed(feature);
		object obj16 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	private void Popup(long remaining)
	{
		popup.PopFromCenter();
		DeleteProducts();
		Setup(remaining);
	}

	private void Setup(long remaining)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f6: Expected O, but got I
		//IL_012a: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01d4: Expected I8, but got I4
		//IL_01ea: Expected I, but got O
		//IL_0223: Expected O, but got I4
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_0416: Expected I8, but got I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_029c: Expected O, but got I4
		//IL_02de: Expected I, but got O
		//IL_0383: Expected I, but got O
		//IL_0321: Expected I, but got O
		//IL_0331: Expected I8, but got I
		//IL_034f: Expected I, but got O
		//IL_035f: Expected I8, but got I
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E79AE]");
		object obj3 = (nint)0 & (nint)1;
		TextMeshProUGUI textMeshProUGUI;
		TextMeshProUGUI textMeshProUGUI2;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			textMeshProUGUI = myaces;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v32+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			textMeshProUGUI2 = myaces;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			textMeshProUGUI = myaces;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v32+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			textMeshProUGUI2 = myaces;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		textMeshProUGUI = textMeshProUGUI2;
		long num = remaining;
		if (!flag3)
		{
			goto IL_0190;
		}
		goto IL_041b;
		IL_0429:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0437;
		IL_041b:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0429;
		IL_0437:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_0190;
		}
		num = remaining;
		goto IL_041b;
		IL_0190:
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		int num2 = default(int);
		string text = num2.ToString();
		bool flag5 = (object)textMeshProUGUI == null;
		num = 0L;
		if (!flag5)
		{
			nint num3 = (nint)textMeshProUGUI;
			textMeshProUGUI.text = text;
			long num4 = remaining & -9223372036854775808L;
			bool flag6 = num4 == 0;
			object obj9 = !flag6;
			long remaining2;
			if (obj9 == null)
			{
				object obj10 = typeof(TypeConverter<ushort, char>) + 3400;
				object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
				object input = "AvailableVoices" + 3920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v20+E4]");
				bool flag7 = (nint)0 == 0;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text2 = LocalizationUtil.Localize((string)input, remaining);
				object[] array = default(object[]);
				bool flag8 = array == null;
				nint num5 = unchecked((nint)null);
				num = remaining;
				if (flag8)
				{
					goto IL_041b;
				}
				bool flag9 = text2 == null;
				long num6 = remaining;
				if (!flag9)
				{
					nint num7 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
					num6 = 0L;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag10 = ex == null;
					num5 = unchecked((nint)null);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
					num = 0L;
					if (flag10)
					{
						goto IL_0437;
					}
				}
				bool flag11 = array.Length == 0;
				num5 = unchecked((nint)null);
				num = num6;
				if (flag11)
				{
					goto IL_0429;
				}
				object text3 = "not" + 96;
				object obj14 = array + 32;
				obj14 = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				TextMeshProExtensions.Localize(description, (string)text3, array);
				remaining2 = remaining;
			}
			else
			{
				object text4 = "not" + 88;
				TextMeshProExtensions.Localize(description, (string)text4);
				remaining2 = 0L;
			}
			Populate(remaining2);
			return;
		}
		goto IL_041b;
	}

	private void Populate(long remaining)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0085: Expected O, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I
		//IL_00ec: Expected I, but got O
		//IL_0106: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 752;
		object obj4 = (nint)0 + (nint)2024;
		object obj5 = obj2 + 24;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)2600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v12+20]");
		((OneShotEvent)0).CallWhenReady(action);
	}

	private void DeleteProducts()
	{
		//IL_000c: Expected O, but got I
		//IL_0022: Expected O, but got I
		//IL_021f: Expected O, but got I
		//IL_0241: Expected O, but got I4
		//IL_00a8: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I
		//IL_0061: Expected O, but got I
		//IL_0323: Expected O, but got I4
		//IL_027b: Expected O, but got I
		//IL_028b: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02c9: Expected O, but got I4
		//IL_02e9: Expected O, but got I
		//IL_014e: Expected O, but got I
		//IL_015e: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_019c: Expected O, but got I4
		//IL_01ac: Expected O, but got I
		//IL_01e9: Expected O, but got I
		//IL_035b: Expected O, but got I
		//IL_036b: Expected O, but got I
		//IL_0381: Expected O, but got I
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_03c4: Expected O, but got I
		object obj = (nint)0 + (nint)3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E79B0]");
		object obj2 = (nint)0 & (nint)1;
		RectTransform rectTransform;
		RectTransform rectTransform2;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			rectTransform = coinsList;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v10+38]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v10+38]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			rectTransform2 = coinsList;
			if (!flag)
			{
				goto IL_0098;
			}
		}
		else
		{
			_ = 1;
			rectTransform = coinsList;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v10+38]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v10+38]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			rectTransform2 = coinsList;
			if (obj6 != null)
			{
				goto IL_0098;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X20_v3+38]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v9+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v9+10]");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		obj3 = obj5;
		rectTransform = rectTransform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v9+10]");
		object obj12 = 0;
		if (obj11 != null)
		{
			goto IL_0109;
		}
		goto IL_02f7;
		IL_01c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Transform transform = rectTransform;
		goto IL_01d9;
		IL_013e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v10+38]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v18+10]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v18+10]");
		object obj15 = (nint)0 + (nint)309;
		object obj16 = obj15 & 1;
		bool flag4 = obj16 == null;
		object obj17 = !flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v18+10]");
		object obj18 = 0;
		transform = rectTransform;
		if (obj17 == null)
		{
			goto IL_01c2;
		}
		goto IL_01d9;
		IL_01d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v13+B8]");
		object except = 0;
		UIExtensions.DestroyAllChildren(transform, (GameObject[])except);
		return;
		IL_0098:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v23+10]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v23+10]");
		object obj19 = (nint)0 + (nint)309;
		object obj20 = obj19 & 1;
		bool flag5 = obj20 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v23+10]");
		obj12 = 0;
		obj5 = obj3;
		rectTransform2 = rectTransform;
		if (!flag5)
		{
			goto IL_0109;
		}
		goto IL_02f7;
		IL_02f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v1+E4]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		obj3 = obj5;
		rectTransform = rectTransform2;
		if (obj21 != null)
		{
			goto IL_013e;
		}
		goto IL_0341;
		IL_0109:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		obj5 = obj3;
		rectTransform2 = rectTransform;
		if (!flag7)
		{
			goto IL_013e;
		}
		goto IL_0341;
		IL_0341:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X20_v3+38]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v3+10]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v3+10]");
		object obj23 = (nint)0 + (nint)309;
		object obj24 = obj23 & 1;
		bool flag8 = obj24 == null;
		rectTransform = rectTransform2;
		if (flag8)
		{
			goto IL_01c2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v3+10]");
		obj18 = 0;
		transform = rectTransform2;
		goto IL_01d9;
	}

	private void OnIAPPurchaseComplete(ProductListingModel model, GiftInfo __)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		//IL_0083: Expected O, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_011f: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2608;
		popup.ShrinkToParent();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+B8]");
		object obj4 = 0;
		ProductViewModel product = model.getProduct();
		object obj5 = "Cannot populate JSON object onto type '{0}'." + 3480;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		int num = default(int);
		string text = num.ToString();
		string product2 = text + (string)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5+8]");
		ITrackEvent trackEvent = TrackerLibrary.NotEnoughAcesPopupBoughtProduct(TrackingFeature.FirstUseExperience, product2);
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	private void OnIAPPurchaseFailed(ProductListingModel _, string errorMessage)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0118: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_00ad: Expected O, but got I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_01b0: Expected O, but got I4
		//IL_0146: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A62]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			int num = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A45]");
		object obj6 = (nint)0 & (nint)1;
		if (obj6 == null)
		{
			goto IL_00bb;
		}
		goto IL_0168;
		IL_0168:
		object title = "Drop Menu Toggle" + 3600;
		object buttonText = "Network Authentication Required" + 3128;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError((string)title, errorMessage, (string)buttonText);
		return;
		IL_00bb:
		int num2 = 1;
		goto IL_0168;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A45]");
		object obj9 = (nint)0 & (nint)1;
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			goto IL_00bb;
		}
		goto IL_0168;
	}

	static NotEnoughAcesPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "Network Authentication Required" + 1768;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3088;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
