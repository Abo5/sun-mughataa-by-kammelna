using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;

public class ReferralRewardsListView : UiListView<ReferralRewardHolder, ReferralRewardItem>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<UserReferralRewardModel, ReferralRewardHolder> <>9__0_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal unsafe ReferralRewardHolder <SetData>b__0_0(UserReferralRewardModel reward)
		{
			//IL_000e: Expected O, but got Ref
			//IL_003f: Expected O, but got I4
			object obj2 = default(object);
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (reward != null)
			{
				return (ReferralRewardHolder)reward.<rewardID>k__BackingField;
			}
			return (ReferralRewardHolder)new NullReferenceException();
		}
	}

	public void SetData(List<UserReferralRewardModel> referralRewards)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0103: Expected O, but got I4
		//IL_019b: Expected O, but got I
		//IL_01ab: Expected O, but got I
		//IL_01cd: Expected O, but got I4
		//IL_00af: Expected I, but got O
		//IL_00bf: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_0052: Expected O, but got I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_013b: Expected O, but got I
		//IL_014c: Expected I, but got O
		//IL_016a: Expected O, but got I
		//IL_0082: Expected O, but got I
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 288;
		Func<object, ReferralRewardHolder> func = default(Func<object, ReferralRewardHolder>);
		while (true)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v8+8]");
			Func<object, ReferralRewardHolder> selector = (Func<object, ReferralRewardHolder>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v8+8]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v14+B8]");
					obj4 = 0;
				}
				object obj8 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 152;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)3536;
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v13+B8]");
				object obj11 = (nint)0 + (nint)8;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			IEnumerable<ReferralRewardHolder> source = Enumerable.Select(referralRewards, selector);
			List<ReferralRewardHolder> list = Enumerable.ToList(source);
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6 (Il2CppClass<ReferralRewardsListView>)+2A8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6 (Il2CppClass<ReferralRewardsListView>)+2B0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v123 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	public ReferralRewardsListView()
	{
		((UiListView<ReferralRewardHolder, object>)(object)this)..ctor();
	}
}
