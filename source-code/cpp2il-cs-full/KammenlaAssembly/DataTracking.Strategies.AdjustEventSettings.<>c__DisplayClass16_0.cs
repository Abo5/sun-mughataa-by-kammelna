using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using GoogleMobileAds.Api.AdManager;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;

namespace DataTracking.Strategies;

public class AdjustEventSettings : ScriptableObject
{
	[Serializable]
	public class DesignEventDefinition
	{
		public TrackingContext context;

		public TrackingFeature feature;

		public TrackingPlacement placement;

		public TrackingOutcome outcome;

		public string eventToken;
	}

	[Serializable]
	public class ResourceEventDefinition
	{
		public ResourceFlowType flowType;

		public ResourceItemType itemType;

		public ResourceCurrency currency;

		public string itemId;

		public string eventToken;
	}

	[Serializable]
	public class PurchaseEventDefinition
	{
		public TrackerPurchase purchaseType;

		public string itemId;

		public string eventToken;
	}

	[Serializable]
	public class AdEventDefinition
	{
		public string adSdk;

		public AdAction adAction;

		public AdType adType;

		public AdPlace placement;

		public string eventToken;
	}

	private sealed class <>c__DisplayClass13_0
	{
		public ITrackEvent trackEvent;

		internal bool <TryGetDesignEventToken>b__0(DesignEventDefinition d)
		{
			//IL_0532: Expected I4, but got O
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_004a: Expected I, but got O
			//IL_005a: Expected O, but got I
			//IL_0095: Expected O, but got I
			//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Expected O, but got Unknown
			//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0403: Expected O, but got Unknown
			//IL_040c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0411: Expected O, but got Unknown
			//IL_0148: Expected I, but got O
			//IL_0158: Expected O, but got I
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected O, but got Unknown
			//IL_0193: Expected O, but got I
			//IL_044b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0450: Expected O, but got Unknown
			//IL_0458: Unknown result type (might be due to invalid IL or missing references)
			//IL_045d: Expected O, but got Unknown
			//IL_0466: Unknown result type (might be due to invalid IL or missing references)
			//IL_046b: Expected O, but got Unknown
			//IL_0246: Expected I, but got O
			//IL_0256: Expected O, but got I
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Expected O, but got Unknown
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Expected O, but got Unknown
			//IL_0291: Expected O, but got I
			//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Expected O, but got Unknown
			//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b7: Expected O, but got Unknown
			//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c5: Expected O, but got Unknown
			//IL_0344: Expected I, but got O
			//IL_0354: Expected O, but got I
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Expected O, but got Unknown
			//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Expected O, but got Unknown
			//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fb: Expected O, but got Unknown
			//IL_038f: Expected O, but got I
			//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0504: Expected O, but got Unknown
			//IL_050c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0511: Expected O, but got Unknown
			//IL_051a: Unknown result type (might be due to invalid IL or missing references)
			//IL_051f: Expected O, but got Unknown
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a2: Expected O, but got Unknown
			//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b0: Expected O, but got Unknown
			object obj;
			if (d != null)
			{
				ITrackEvent trackEvent = this.trackEvent;
				if (this.trackEvent != null)
				{
					obj = typeof(System.IOAsyncCallback) + 1816;
					nint num = (nint)trackEvent;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v4 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v4 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00d6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v4 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X10_v27-8]");
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
						goto IL_00d6;
					}
					object obj4 = obj3 + 2;
					object obj5 = num + obj4;
					object obj6 = obj5 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v339 @ X0_v38] (should have been resolved before IL gen)");
					object obj7 = default(object);
					if ((nint)d.context == (nint)obj7)
					{
						goto IL_0117;
					}
					goto IL_043c;
				}
			}
			goto IL_0524;
			IL_0313:
			ITrackEvent trackEvent2 = this.trackEvent;
			if (this.trackEvent == null)
			{
				goto IL_0524;
			}
			nint num2 = (nint)trackEvent2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v13 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v13 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03d0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v13 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
			object obj9 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X10_v12-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj9 += 16;
				obj8--;
				if ((nint)obj8 != 1)
				{
					continue;
				}
				goto IL_03d0;
			}
			object obj10 = obj9 + 5;
			object obj11 = num2 + obj10;
			object obj12 = obj11 + 312;
			goto IL_05df;
			IL_05df:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v593 @ X0_v13] (should have been resolved before IL gen)");
			object obj14 = default(object);
			object obj13 = d.outcome - obj14;
			return obj13 == null;
			IL_01d4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v385 @ X0_v28] (should have been resolved before IL gen)");
			object obj15 = default(object);
			bool flag = (nint)d.feature != (nint)obj15;
			nint num3 = 3;
			if (!flag)
			{
				goto IL_0215;
			}
			goto IL_0496;
			IL_0496:
			return false;
			IL_0215:
			ITrackEvent trackEvent3 = this.trackEvent;
			if (this.trackEvent != null)
			{
				nint num4 = (nint)trackEvent3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v10 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v10 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02d2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v10 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
				object obj17 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X10_v17-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj17 += 16;
					obj16--;
					if ((nint)obj16 != 1)
					{
						continue;
					}
					goto IL_02d2;
				}
				object obj18 = obj17 + 4;
				object obj19 = num4 + obj18;
				object obj20 = obj19 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v511 @ X0_v24] (should have been resolved before IL gen)");
				object obj21 = default(object);
				if ((nint)d.placement == (nint)obj21)
				{
					goto IL_0313;
				}
				goto IL_04f0;
			}
			goto IL_0524;
			IL_0524:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00d6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ X0_v35] (should have been resolved before IL gen)");
			object obj22 = default(object);
			bool flag2 = (nint)d.context != (nint)obj22;
			num3 = 2;
			if (!flag2)
			{
				goto IL_0117;
			}
			goto IL_043c;
			IL_043c:
			return false;
			IL_0117:
			ITrackEvent trackEvent4 = this.trackEvent;
			if (this.trackEvent != null)
			{
				nint num5 = (nint)trackEvent4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v7 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v7 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01d4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v7 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
				object obj24 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X10_v22-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj24 += 16;
					obj23--;
					if ((nint)obj23 != 1)
					{
						continue;
					}
					goto IL_01d4;
				}
				object obj25 = obj24 + 3;
				object obj26 = num5 + obj25;
				object obj27 = obj26 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v425 @ X0_v31] (should have been resolved before IL gen)");
				object obj28 = default(object);
				if ((nint)d.feature == (nint)obj28)
				{
					goto IL_0215;
				}
				goto IL_0496;
			}
			goto IL_0524;
			IL_03d0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = 5;
			goto IL_05df;
			IL_02d2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v471 @ X0_v21] (should have been resolved before IL gen)");
			object obj29 = default(object);
			bool flag3 = (nint)d.placement != (nint)obj29;
			num3 = 4;
			if (!flag3)
			{
				goto IL_0313;
			}
			goto IL_04f0;
			IL_04f0:
			return false;
		}
	}

	private sealed class <>c__DisplayClass14_0
	{
		public ResourceFlowType flowType;

		public ResourceItemType itemType;

		public ResourceCurrency currency;

		public string itemId;

		internal bool <TryGetResourceEventToken>b__0(ResourceEventDefinition r)
		{
			//IL_00fa: Expected I4, but got O
			if (r != null)
			{
				if (r.flowType == flowType && r.itemType == itemType && r.currency == currency)
				{
					if (string.IsNullOrEmpty(r.itemId))
					{
						return true;
					}
					return string.Equals(r.itemId, itemId, StringComparison.OrdinalIgnoreCase);
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass15_0
	{
		public TrackerPurchase purchaseType;

		public string itemId;

		internal bool <TryGetPurchaseEventToken>b__0(PurchaseEventDefinition p)
		{
			//IL_00ae: Expected I4, but got O
			if (p != null)
			{
				if (p.purchaseType == purchaseType)
				{
					if (string.IsNullOrEmpty(p.itemId))
					{
						return true;
					}
					return string.Equals(p.itemId, itemId, StringComparison.OrdinalIgnoreCase);
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public string adSdk;

		public AdAction adAction;

		public AdType adType;

		public AdPlace placement;

		internal bool <TryGetAdEventToken>b__0(AdEventDefinition a)
		{
			//IL_011d: Expected I4, but got O
			//IL_0049: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			bool flag3;
			if (a != null)
			{
				bool flag = string.IsNullOrEmpty(a.adSdk);
				bool flag2 = !flag;
				object obj = !flag2;
				if (obj == null)
				{
					flag3 = string.Equals(a.adSdk, adSdk, StringComparison.OrdinalIgnoreCase);
					if (!flag3)
					{
						goto IL_011d;
					}
				}
				if (a.adAction == adAction && a.adType == adType)
				{
					object obj2 = a.placement - placement;
					bool flag4 = obj2 == null;
					flag3 = flag4;
					goto IL_011d;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_011d:
			return flag3;
		}
	}

	public const string ResourcePath = "AdjustEventSettings";

	private string defaultDesignEventToken;

	private string defaultResourceEventToken;

	private string defaultPurchaseEventToken;

	private string defaultAdEventToken;

	private List<DesignEventDefinition> designEvents;

	private List<ResourceEventDefinition> resourceEvents;

	private List<PurchaseEventDefinition> purchaseEvents;

	private List<AdEventDefinition> adEvents;

	public unsafe bool TryGetDesignEventToken(ITrackEvent trackEvent, out string token)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0156: Expected I4, but got O
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0076: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_009d: Expected I, but got O
		//IL_0109: Expected O, but got I4
		//IL_00e2: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = trackEvent;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			ref string reference;
			if (obj3 != null)
			{
				object obj4 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 320;
				object obj5 = (nint)0 + (nint)2880;
				object obj6 = (nint)0 + (nint)1424;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj5);
				object obj7 = Enumerable.FirstOrDefault(designEvents, func);
				object obj8;
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v13 (System.Object)+20]");
					obj8 = 0;
				}
				else
				{
					obj8 = 0;
				}
				reference = ref *(string*)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (string.IsNullOrEmpty(token))
				{
					reference = ref *(string*)defaultDesignEventToken;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				bool flag = string.IsNullOrEmpty(token);
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
			reference = ref *(string*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe bool TryGetResourceEventToken(ResourceFlowType flowType, ResourceItemType itemType, string itemId, ResourceCurrency currency, out string token)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0134: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0094: Expected I, but got O
		//IL_00e7: Expected O, but got I4
		//IL_00d9: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 336;
			object obj4 = (nint)0 + (nint)2888;
			object obj5 = (nint)0 + (nint)1440;
			object obj6 = obj2 + 32;
			obj6 = itemId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			object obj7 = Enumerable.FirstOrDefault(resourceEvents, func);
			object obj8;
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v11 (System.Object)+28]");
				obj8 = 0;
			}
			else
			{
				obj8 = 0;
			}
			ref string reference = ref *(string*)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (string.IsNullOrEmpty(token))
			{
				reference = ref *(string*)defaultResourceEventToken;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			bool flag = string.IsNullOrEmpty(token);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe bool TryGetPurchaseEventToken(TrackerPurchase purchaseType, string itemId, out string token)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012a: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_008a: Expected I, but got O
		//IL_00dd: Expected O, but got I4
		//IL_00cf: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 328;
			object obj4 = (nint)0 + (nint)2896;
			object obj5 = (nint)0 + (nint)1432;
			object obj6 = obj2 + 24;
			obj6 = itemId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			object obj7 = Enumerable.FirstOrDefault(purchaseEvents, func);
			object obj8;
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v11 (System.Object)+20]");
				obj8 = 0;
			}
			else
			{
				obj8 = 0;
			}
			ref string reference = ref *(string*)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (string.IsNullOrEmpty(token))
			{
				reference = ref *(string*)defaultPurchaseEventToken;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			bool flag = string.IsNullOrEmpty(token);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe bool TryGetAdEventToken(string adSdk, AdAction adAction, AdType adType, AdPlace placement, out string token)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0134: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0094: Expected I, but got O
		//IL_00e7: Expected O, but got I4
		//IL_00d9: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 312;
			object obj4 = (nint)0 + (nint)2904;
			object obj5 = (nint)0 + (nint)1416;
			object obj6 = obj2 + 16;
			obj6 = adSdk;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			object obj7 = Enumerable.FirstOrDefault(adEvents, func);
			object obj8;
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v11 (System.Object)+28]");
				obj8 = 0;
			}
			else
			{
				obj8 = 0;
			}
			ref string reference = ref *(string*)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (string.IsNullOrEmpty(token))
			{
				reference = ref *(string*)defaultAdEventToken;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			bool flag = string.IsNullOrEmpty(token);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static bool Matches(string configuredValue, string actualValue)
	{
		if (string.IsNullOrEmpty(configuredValue))
		{
			return true;
		}
		return string.Equals(configuredValue, actualValue, StringComparison.OrdinalIgnoreCase);
	}

	public AdjustEventSettings()
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
		object obj = typeof(List<Tween>) + 560;
		object obj2 = typeof(List<Tween>) + 576;
		object obj3 = typeof(List<Tween>) + 568;
		object obj4 = typeof(List<Tween>) + 552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj5 = this + 56;
		obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj6 = this + 64;
		obj6 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list3 = default(List<object>);
		list3..ctor();
		object obj7 = this + 72;
		obj7 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list4 = default(List<object>);
		list4..ctor();
		object obj8 = this + 80;
		obj8 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
