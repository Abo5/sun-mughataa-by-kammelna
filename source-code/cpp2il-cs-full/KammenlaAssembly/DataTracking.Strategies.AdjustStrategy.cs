using System.Data.SqlTypes;
using AdjustSdk;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

namespace DataTracking.Strategies;

public class AdjustStrategy : IAnalyticsStrategy
{
	private readonly AdjustEventSettings _settings;

	public AdjustStrategy(AdjustEventSettings settings)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = settings;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void AdEvent(string adSDK, AdAction adAction, AdType adType, AdPlace adPlacement)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DAF]");
		object obj3 = (nint)0 & (nint)1;
		Object settings;
		Object settings2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			settings = _settings;
			settings2 = _settings;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			settings = _settings;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			settings2 = _settings;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = settings2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			goto IL_0158;
		}
		return;
		IL_0158:
		if (_settings.TryGetAdEventToken(adSDK, adAction, adType, adPlacement, out var token))
		{
			object obj7 = typeof(SqlSingle[]) + 3104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			AdjustEvent adjustEvent = default(AdjustEvent);
			adjustEvent..ctor(token);
			Adjust.TrackEvent(adjustEvent);
		}
		return;
		IL_0091:
		if (settings == null)
		{
			return;
		}
		goto IL_0158;
	}

	public void PurchaseEvent(string shop, TrackerPurchase purchaseType, string itemId, double price, string currencyCode)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DB0]");
		object obj3 = (nint)0 & (nint)1;
		Object settings;
		Object settings2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			settings = _settings;
			settings2 = _settings;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			settings = _settings;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			settings2 = _settings;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = settings2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			goto IL_0158;
		}
		return;
		IL_0158:
		if (_settings.TryGetPurchaseEventToken(purchaseType, itemId, out var token))
		{
			object obj7 = typeof(SqlSingle[]) + 3104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			AdjustEvent adjustEvent = default(AdjustEvent);
			adjustEvent..ctor(token);
			adjustEvent.SetRevenue(price, currencyCode);
			Adjust.TrackEvent(adjustEvent);
		}
		return;
		IL_0091:
		if (settings == null)
		{
			return;
		}
		goto IL_0158;
	}

	public void DesignEvent(ITrackEvent trackEvent)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DB1]");
		object obj3 = (nint)0 & (nint)1;
		Object settings;
		Object settings2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			settings = _settings;
			settings2 = _settings;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			settings = _settings;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			settings2 = _settings;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = settings2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0154;
		IL_0154:
		if (_settings.TryGetDesignEventToken(trackEvent, out var token))
		{
			object obj7 = typeof(SqlSingle[]) + 3104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			AdjustEvent adjustEvent = default(AdjustEvent);
			adjustEvent..ctor(token);
			Adjust.TrackEvent(adjustEvent);
		}
		return;
		IL_0091:
		if (settings == null)
		{
			return;
		}
		goto IL_0154;
	}

	public void ResourceEvent(ResourceFlowType flowType, ResourceItemType type, string itemId, double amount, ResourceCurrency currency)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DB2]");
		object obj3 = (nint)0 & (nint)1;
		Object settings;
		Object settings2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			settings = _settings;
			settings2 = _settings;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			settings = _settings;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			settings2 = _settings;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = settings2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			goto IL_0158;
		}
		return;
		IL_0158:
		if (_settings.TryGetResourceEventToken(flowType, type, itemId, currency, out var token))
		{
			object obj7 = typeof(SqlSingle[]) + 3104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			AdjustEvent adjustEvent = default(AdjustEvent);
			adjustEvent..ctor(token);
			Adjust.TrackEvent(adjustEvent);
		}
		return;
		IL_0091:
		if (settings == null)
		{
			return;
		}
		goto IL_0158;
	}

	public void SetDimensions(DimensionsModel dimensions)
	{
	}
}
