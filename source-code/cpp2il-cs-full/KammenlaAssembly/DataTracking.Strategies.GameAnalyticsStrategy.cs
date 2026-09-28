using System;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using GameAnalyticsSDK;
using UnityEngine.Purchasing.Telemetry;

namespace DataTracking.Strategies;

public class GameAnalyticsStrategy : IAnalyticsStrategy
{
	public unsafe void AdEvent(string adSDK, AdAction adAction, AdType adType, AdPlace adPlacement)
	{
		//IL_006d: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_0095: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected I4, but got Unknown
		//IL_00e6: Expected O, but got I4
		//IL_0014: Expected O, but got I4
		//IL_0110: Expected O, but got Ref
		bool flag = adAction < AdAction.Clicked;
		object obj = !flag;
		object obj2 = adAction - 7;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		GAAdAction adAction2;
		if (obj4 == null)
		{
			object obj5 = 119877632 + 600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X9_v6+adAction @ X2 (AdAction)*4]");
			adAction2 = GAAdAction.Undefined;
		}
		else
		{
			adAction2 = GAAdAction.Undefined;
		}
		object obj6 = (int)adType << 1;
		GAAdType gAAdType = (GAAdType)(obj6 + 2);
		bool flag3 = adType < (AdType)3;
		object obj7 = !flag3;
		object obj8 = ~obj7;
		object obj9 = ~obj8;
		GAAdType adType2 = ((obj9 == null) ? gAAdType : GAAdType.Undefined);
		object obj10 = default(object);
		string adPlacement2 = ((Enum)(&obj10)).ToString();
		GameAnalytics.NewAdEvent(adAction2, adType2, adSDK, adPlacement2);
	}

	public void PurchaseEvent(string shop, TrackerPurchase purchaseType, string itemId, double price, string currencyCode)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0070: Invalid comparison between F8 and I8
		//IL_0033: Expected I4, but got F8
		//IL_0026: Expected I4, but got I8
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		double num = price * 4.636737291354636E+18;
		int amount = (int)((num != 9.218868437227405E+18) ? ((int)num) : 2147483648L);
		GameAnalytics.NewBusinessEvent(currencyCode, amount, friendlyName, itemId, shop);
	}

	public void DesignEvent(ITrackEvent trackEvent)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00db: Expected O, but got I4
		//IL_00e0: Expected I, but got O
		//IL_014a: Expected I, but got O
		//IL_015a: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_00f3: Expected I, but got O
		//IL_0348: Expected I, but got O
		//IL_0358: Expected O, but got I
		//IL_0195: Expected O, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0402: Expected O, but got I4
		//IL_0407: Expected I, but got O
		//IL_022f: Expected I, but got O
		//IL_023f: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0460: Expected I, but got O
		//IL_0470: Expected O, but got I
		//IL_0393: Expected O, but got I
		//IL_02ca: Expected I, but got O
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_032a: Expected O, but got I4
		//IL_04fb: Expected I, but got O
		//IL_065b: Expected I, but got O
		//IL_066b: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_04ab: Expected O, but got I
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_0556: Expected O, but got I
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected O, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected O, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected O, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected O, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected O, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected O, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 1816;
		nint num = (nint)trackEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v37-8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ X0_v46] (should have been resolved before IL gen)");
		object obj6 = default(object);
		bool flag = obj6 == null;
		nint num3 = default(nint);
		nint num2 = num3;
		if (!flag)
		{
			goto IL_0142;
		}
		goto IL_0340;
		IL_06d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v577 @ X0_v5] (should have been resolved before IL gen)");
		string eventName = default(string);
		GameAnalytics.NewDesignEvent(eventName);
		return;
		IL_0597:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num3 = 6;
		goto IL_0710;
		IL_0458:
		nint num4 = (nint)trackEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v7 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v7 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04ec;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v7 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj8 += 16;
			obj7--;
			if ((nint)obj7 != 1)
			{
				continue;
			}
			goto IL_04ec;
		}
		object obj9 = num4 + obj8;
		object obj10 = obj9 + 312;
		goto IL_06d8;
		IL_04ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = unchecked((nint)null);
		goto IL_06d8;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ X0_v43] (should have been resolved before IL gen)");
		object obj11 = default(object);
		bool flag2 = obj11 == null;
		object obj12 = !flag2;
		num3 = unchecked((nint)null);
		if (obj12 != null)
		{
			goto IL_0142;
		}
		num2 = unchecked((nint)null);
		goto IL_0340;
		IL_0142:
		nint num5 = (nint)trackEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v16 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v16 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01d6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v16 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X10_v32-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj14 += 16;
			obj13--;
			if ((nint)obj13 != 1)
			{
				continue;
			}
			goto IL_01d6;
		}
		object obj15 = obj14 + 6;
		object obj16 = num5 + obj15;
		object obj17 = obj16 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v392 @ X0_v39] (should have been resolved before IL gen)");
		object obj19 = default(object);
		object obj18 = obj19 & 1;
		bool flag3 = obj18 == null;
		object obj20 = !flag3;
		num2 = num3;
		if (obj20 != null)
		{
			goto IL_0227;
		}
		goto IL_0340;
		IL_0649:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v563 @ X0_v21] (should have been resolved before IL gen)");
		nint num6 = (nint)trackEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v21 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v21 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0597;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v21 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
		object obj22 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X10_v22-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj22 += 16;
			obj21--;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_0597;
		}
		object obj23 = obj22 + 6;
		object obj24 = num6 + obj23;
		object obj25 = obj24 + 312;
		goto IL_0710;
		IL_0710:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v636 @ X0_v24] (should have been resolved before IL gen)");
		float? num7 = default(float?);
		float value = num7.Value;
		string eventName2 = default(string);
		GameAnalytics.NewDesignEvent(eventName2, value);
		return;
		IL_02bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num3 = unchecked((nint)null);
		goto IL_0649;
		IL_03d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v348 @ X0_v13] (should have been resolved before IL gen)");
		object obj26 = default(object);
		bool flag4 = obj26 == null;
		object obj27 = !flag4;
		num2 = unchecked((nint)null);
		if (obj27 == null)
		{
			return;
		}
		goto IL_0458;
		IL_01d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v319 @ X0_v36] (should have been resolved before IL gen)");
		object obj29 = default(object);
		object obj28 = obj29 & 1;
		bool flag5 = obj28 == null;
		num3 = 6;
		num2 = 6;
		if (!flag5)
		{
			goto IL_0227;
		}
		goto IL_0340;
		IL_0227:
		nint num8 = (nint)trackEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v18 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v18 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02bb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v18 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
		object obj31 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X10_v27-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj31 += 16;
			obj30--;
			if ((nint)obj30 != 1)
			{
				continue;
			}
			goto IL_02bb;
		}
		object obj32 = num8 + obj31;
		object obj33 = obj32 + 312;
		goto IL_0649;
		IL_0340:
		nint num9 = (nint)trackEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v5 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v5 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03d4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v5 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
		object obj35 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X10_v13-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj35 += 16;
			obj34--;
			if ((nint)obj34 != 1)
			{
				continue;
			}
			goto IL_03d4;
		}
		object obj36 = num9 + obj35;
		object obj37 = obj36 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v420 @ X0_v16] (should have been resolved before IL gen)");
		object obj38 = default(object);
		if (obj38 == null)
		{
			return;
		}
		goto IL_0458;
	}

	public void ResourceEvent(ResourceFlowType flowType, ResourceItemType type, string itemId, double amount, ResourceCurrency currency)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I4
		//IL_00d7: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 896;
		object obj2 = typeof(RegisteredWaitHandle) + 936;
		ResourceFlowType resourceFlowType = ((flowType == ResourceFlowType.Sink) ? flowType : ResourceFlowType.None);
		object obj3 = flowType - 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		object obj5 = ~obj4;
		ResourceFlowType flowType2 = ((obj5 != null) ? ResourceFlowType.Source : resourceFlowType);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration2 = default(Enum);
		string friendlyName2 = EnumExtensions.GetFriendlyName(enumeration2);
		GameAnalytics.NewResourceEvent((GAResourceFlowType)flowType2, friendlyName, (float)amount, friendlyName2, itemId);
	}

	public void SetDimensions(DimensionsModel dimensions)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I4
		//IL_0100: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_0159: Expected O, but got I4
		//IL_023c: Expected O, but got I4
		//IL_0245: Expected O, but got I4
		//IL_01f7: Expected O, but got I4
		//IL_02ee: Expected O, but got I4
		//IL_02fe: Expected O, but got I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_029e: Expected O, but got I4
		//IL_03d3: Expected O, but got I4
		//IL_042c: Expected O, but got I4
		//IL_043c: Expected O, but got I4
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		object obj;
		if (dimensions != null)
		{
			string[] dimensionArray = dimensions.DimensionArray;
			if (dimensions.DimensionArray != null)
			{
				obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v6+E4]");
				if ((nint)0 != 0)
				{
					if (!StringsExtensions.IsNullOrEmpty(dimensionArray[0]))
					{
						goto IL_010e;
					}
					object obj3 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag = StringsExtensions.IsNullOrEmpty(dimensionArray[0]);
					bool flag2 = !flag;
					object obj4 = !flag2;
					object obj3 = 0;
					if (obj4 == null)
					{
						goto IL_010e;
					}
				}
				goto IL_015e;
			}
		}
		goto IL_0483;
		IL_0491:
		throw new IndexOutOfRangeException();
		IL_015e:
		string[] dimensionArray2 = dimensions.DimensionArray;
		if (dimensions.DimensionArray != null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v9+E4]");
			if ((nint)0 != 0)
			{
				if (!StringsExtensions.IsNullOrEmpty(dimensionArray2[1]))
				{
					goto IL_0253;
				}
				object obj6 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = StringsExtensions.IsNullOrEmpty(dimensionArray2[1]);
				bool flag4 = !flag3;
				object obj7 = !flag4;
				object obj6 = 0;
				if (obj7 == null)
				{
					goto IL_0253;
				}
			}
			goto IL_02a3;
		}
		goto IL_0483;
		IL_02a3:
		string[] dimensionArray3 = dimensions.DimensionArray;
		if (dimensions.DimensionArray == null)
		{
			goto IL_0483;
		}
		bool flag5 = dimensionArray3.Length < 2;
		object obj8 = !flag5;
		object obj9 = dimensionArray3.Length - 2;
		bool flag6 = obj9 == null;
		object obj10 = ~obj8;
		object obj11 = obj10 | flag6;
		if (obj11 == null)
		{
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				if (StringsExtensions.IsNullOrEmpty(dimensionArray3[2]))
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag7 = StringsExtensions.IsNullOrEmpty(dimensionArray3[2]);
				bool flag8 = !flag7;
				object obj13 = !flag8;
				if (obj13 != null)
				{
					return;
				}
			}
			string[] dimensionArray4 = dimensions.DimensionArray;
			if (dimensions.DimensionArray == null)
			{
				goto IL_0483;
			}
			bool flag9 = dimensionArray4.Length < 2;
			object obj14 = !flag9;
			object obj15 = dimensionArray4.Length - 2;
			bool flag10 = obj15 == null;
			object obj16 = ~obj14;
			object obj17 = obj16 | flag10;
			if (obj17 == null)
			{
				GameAnalytics.SetCustomDimension03(dimensionArray4[2]);
				return;
			}
		}
		goto IL_0491;
		IL_0483:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0491;
		IL_010e:
		string[] dimensionArray5 = dimensions.DimensionArray;
		if (dimensions.DimensionArray != null)
		{
			GameAnalytics.SetCustomDimension01(dimensionArray5[0]);
			object obj3 = 0;
			goto IL_015e;
		}
		goto IL_0483;
		IL_0253:
		string[] dimensionArray6 = dimensions.DimensionArray;
		if (dimensions.DimensionArray != null)
		{
			GameAnalytics.SetCustomDimension02(dimensionArray6[1]);
			object obj6 = 0;
			goto IL_02a3;
		}
		goto IL_0483;
	}
}
