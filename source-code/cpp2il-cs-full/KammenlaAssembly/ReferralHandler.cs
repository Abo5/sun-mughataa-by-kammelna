using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem.XR;

public class ReferralHandler : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<UserReferralModel, bool> <>9__10_0;

		public static Func<UserReferralModel, bool> <>9__30_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_SuccessfulReferrals>b__10_0(UserReferralModel model)
		{
			//IL_004f: Expected I4, but got O
			if (model != null)
			{
				bool flag = model.<rewardType>k__BackingField == ReferralRewardType.None;
				return !flag;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <CheckHistoryForRewards>b__30_0(UserReferralModel referral)
		{
			//IL_007a: Expected I4, but got O
			if (referral != null)
			{
				if (referral.<isNew>k__BackingField)
				{
					bool flag = referral.<rewardType>k__BackingField == ReferralRewardType.None;
					return !flag;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass34_0
	{
		public UserReferralRewardModel reward;

		public Func<UserReferralRewardModel, bool> <>9__1;

		internal void <ClaimReward>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_07ec: Expected O, but got I4
			//IL_0782: Expected O, but got I
			//IL_07a9: Expected O, but got I4
			//IL_0011: Expected O, but got I
			//IL_080b: Expected O, but got I
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Expected O, but got Unknown
			//IL_023b: Expected O, but got I4
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_0081: Expected O, but got I4
			//IL_0846: Expected O, but got I
			//IL_0272: Unknown result type (might be due to invalid IL or missing references)
			//IL_0277: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I4
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_00f0: Expected O, but got I
			//IL_00f8: Expected I, but got O
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_02c5: Expected O, but got I
			//IL_02df: Expected O, but got I4
			//IL_015c: Expected O, but got I
			//IL_031d: Expected O, but got I4
			//IL_0373: Expected O, but got I4
			//IL_01c9: Expected O, but got I4
			//IL_038d: Expected O, but got I
			//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a5: Expected O, but got Unknown
			//IL_03c7: Expected O, but got I4
			//IL_0853: Expected O, but got I
			//IL_085b: Expected I, but got O
			//IL_01f8: Expected O, but got I4
			//IL_08b3: Expected O, but got I4
			//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e9: Expected O, but got Unknown
			//IL_03ff: Expected O, but got I
			//IL_040d: Expected I, but got O
			//IL_042f: Expected O, but got I4
			//IL_04a0: Expected O, but got I
			//IL_04a8: Expected I, but got O
			//IL_068c: Expected O, but got I
			//IL_06a6: Expected O, but got I4
			//IL_04f8: Expected O, but got I
			//IL_06e4: Expected O, but got I4
			//IL_0724: Expected O, but got I4
			//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a9: Expected O, but got Unknown
			//IL_05c4: Expected O, but got I
			//IL_05d2: Expected I, but got O
			//IL_05de: Expected O, but got I
			//IL_05e6: Expected I, but got O
			//IL_08e9: Expected O, but got I4
			//IL_0901: Expected O, but got I4
			//IL_0611: Expected O, but got I
			//IL_0638: Expected O, but got I4
			//IL_0657: Expected O, but got I4
			bool flag = response == null;
			object obj = response;
			object obj2 = 152985600;
			object obj3;
			object obj7;
			object obj10;
			object obj12 = default(object);
			nint num;
			NullReferenceException ex2;
			object obj6 = default(object);
			object obj17;
			if (!flag)
			{
				obj3 = (nint)0 + (nint)1048;
				obj = obj3;
				if (!response.Succeeded)
				{
					object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
					NullReferenceException ex = (NullReferenceException)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v11 (System.NullReferenceException)+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					obj6 = obj3;
					ex2 = ex;
					if (obj5 == null)
					{
						goto IL_0259;
					}
					goto IL_07fa;
				}
				obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v17+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CachedModel<List<UserReferralRewardModel>> referralRewards = CachedModels.ReferralRewards;
				bool flag4 = referralRewards == null;
				obj6 = obj3;
				obj2 = 152985600;
				if (!flag4)
				{
					obj10 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 616;
					object obj11 = (nint)0 + (nint)608;
					num = (nint)obj11;
					((CachedModel<object>)(object)referralRewards).ETag = (string)obj10;
					obj12 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
					object obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v21+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6616]");
						object obj14 = (nint)0 & (nint)1;
						if (obj14 != null)
						{
							goto IL_0179;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6616]");
						object obj15 = (nint)0 & (nint)1;
						bool flag5 = obj15 == null;
						object obj16 = !flag5;
						if (obj16 != null)
						{
							goto IL_0179;
						}
					}
					_ = 1;
					obj17 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v66+E4]");
					bool flag6 = (nint)0 == 0;
					object obj18 = !flag6;
					if (obj18 != null)
					{
						goto IL_01a6;
					}
					goto IL_032b;
				}
			}
			goto IL_0752;
			IL_0381:
			object obj19 = (nint)0 + (nint)600;
			CachedModel<object> cachedModel;
			object model = cachedModel.Model;
			object obj20 = this + 24;
			Func<object, bool> func = (Func<object, bool>)obj20;
			bool flag7 = obj20 == null;
			object obj21 = !flag7;
			object obj24;
			if (obj21 == null)
			{
				object obj22 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 144;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj23 = (nint)0 + (nint)3528;
				Func<object, bool> func2 = default(Func<object, bool>);
				func2..ctor((object)this, (IntPtr)obj23);
				<>9__1 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj24 = 0;
				func = func2;
			}
			object obj25 = (nint)0 + (nint)1384;
			num = (nint)obj25;
			object obj26 = Enumerable.FirstOrDefault((IEnumerable<object>)model, func);
			if (obj26 != null)
			{
				_ = 1;
			}
			object obj27 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v27+E4]");
			bool flag8 = (nint)0 == 0;
			object obj28 = !flag8;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CachedModel<List<UserReferralRewardModel>> referralRewards2 = CachedModels.ReferralRewards;
			bool flag9 = referralRewards2 == null;
			obj = func;
			obj6 = obj3;
			obj2 = model;
			object obj34;
			if (!flag9)
			{
				object obj29 = (nint)0 + (nint)592;
				num = (nint)obj29;
				((CachedModel<object>)(object)referralRewards2).Update(model);
				object obj30 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v31+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6616]");
					object obj31 = (nint)0 & (nint)1;
					if (obj31 != null)
					{
						goto IL_0515;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6616]");
					object obj32 = (nint)0 & (nint)1;
					bool flag10 = obj32 == null;
					object obj33 = !flag10;
					if (obj33 != null)
					{
						goto IL_0515;
					}
				}
				_ = 1;
				obj34 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v32+E4]");
				bool flag11 = (nint)0 == 0;
				object obj35 = !flag11;
				if (obj35 != null)
				{
					goto IL_0542;
				}
				goto IL_06f2;
			}
			goto IL_0752;
			IL_0752:
			ex2 = new NullReferenceException();
			goto IL_0760;
			IL_0515:
			obj34 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v32+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0542;
			}
			goto IL_06f2;
			IL_06f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CachedModel<List<UserReferralRewardModel>> referralRewards3 = CachedModels.ReferralRewards;
			bool flag12 = referralRewards3 == null;
			object obj36 = !flag12;
			CachedModel<object> cachedModel2 = (CachedModel<object>)(object)referralRewards3;
			obj = model;
			obj6 = obj3;
			obj2 = model;
			if (obj36 != null)
			{
				goto IL_0588;
			}
			goto IL_0752;
			IL_0542:
			CachedModel<List<UserReferralRewardModel>> referralRewards4 = CachedModels.ReferralRewards;
			bool flag13 = referralRewards4 == null;
			cachedModel2 = (CachedModel<object>)(object)referralRewards4;
			obj = model;
			obj6 = obj3;
			obj2 = model;
			if (!flag13)
			{
				goto IL_0588;
			}
			goto IL_0752;
			IL_07fa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v2 (System.NullReferenceException)+B8]");
			object obj37 = 0;
			object arg = ((!response.Succeeded) ? null : reward);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v4+18]");
			Actions.SafeInvoke((Action<object>)0, arg);
			return;
			IL_0760:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ex2 = (NullReferenceException)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v2 (System.NullReferenceException)+B8]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v2 (System.NullReferenceException)+E4]");
			bool flag14 = (nint)0 == 0;
			object obj39 = !flag14;
			if (obj39 == null)
			{
				obj3 = obj6;
				NullReferenceException ex = ex2;
				goto IL_0259;
			}
			goto IL_07fa;
			IL_0259:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj40 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			ex2 = (NullReferenceException)obj40;
			obj6 = obj3;
			goto IL_07fa;
			IL_0588:
			object model2 = cachedModel2.Model;
			object obj41 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj42 = (nint)0 + (nint)2080;
			Func<object, bool> func3 = default(Func<object, bool>);
			func3..ctor((object)null, (IntPtr)obj42);
			object obj43 = (nint)0 + (nint)2912;
			num = (nint)obj43;
			bool flag15 = Enumerable.Any((IEnumerable<object>)model2, func3);
			ex2 = (NullReferenceException)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v2 (System.NullReferenceException)+E4]");
			bool flag16 = (nint)0 == 0;
			obj24 = 0;
			obj = func3;
			obj6 = obj3;
			obj2 = flag15;
			if (flag16)
			{
				goto IL_0760;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v2 (System.NullReferenceException)+B8]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v2 (System.NullReferenceException)+E4]");
			bool flag17 = (nint)0 == 0;
			object obj45 = !flag17;
			obj6 = obj3;
			if (obj45 == null)
			{
				obj24 = 0;
				obj = func3;
				NullReferenceException ex = ex2;
				goto IL_0259;
			}
			goto IL_07fa;
			IL_0179:
			obj17 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v66+E4]");
			if ((nint)0 != 0)
			{
				goto IL_01a6;
			}
			goto IL_032b;
			IL_032b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CachedModel<List<UserReferralRewardModel>> referralRewards5 = CachedModels.ReferralRewards;
			bool flag18 = referralRewards5 == null;
			cachedModel = (CachedModel<object>)(object)referralRewards5;
			obj = obj10;
			obj6 = obj3;
			obj2 = 152985600;
			if (!flag18)
			{
				goto IL_0381;
			}
			goto IL_0752;
			IL_01a6:
			CachedModel<List<UserReferralRewardModel>> referralRewards6 = CachedModels.ReferralRewards;
			bool flag19 = referralRewards6 == null;
			object obj46 = !flag19;
			cachedModel = (CachedModel<object>)(object)referralRewards6;
			if (obj46 != null)
			{
				goto IL_0381;
			}
			obj = obj10;
			obj6 = obj3;
			obj2 = 152985600;
			goto IL_0752;
		}

		internal bool <ClaimReward>b__1(UserReferralRewardModel model)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (model != null)
			{
				UserReferralRewardModel userReferralRewardModel = reward;
				if (reward != null)
				{
					object obj = model.<rewardID>k__BackingField - userReferralRewardModel.<rewardID>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const string ReferralName = "ReferringUserAName";

	private const string ReferralToken = "UserAReferralId";

	private static readonly OneShotEvent <ReadyStatus>k__BackingField;

	private static List<UserReferralModel> <Referrals>k__BackingField;

	private static bool <NewReferrals>k__BackingField;

	private static bool <HasReward>k__BackingField;

	private AssetReferenceGameObject successPopupRef;

	private static OneShotEvent ReadyStatus
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
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6558]");
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
			return (OneShotEvent)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			return (OneShotEvent)0;
		}
	}

	public static List<UserReferralModel> Referrals
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6559]");
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
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+8]");
			return (List<UserReferralModel>)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+8]");
			return (List<UserReferralModel>)0;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = (nint)0 + (nint)8;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static List<UserReferralModel> SuccessfulReferrals
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_026f: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02df: Expected O, but got Unknown
			//IL_0309: Expected O, but got I4
			//IL_029d: Expected O, but got I
			//IL_02b7: Expected O, but got I4
			//IL_0111: Expected O, but got I
			//IL_0121: Expected O, but got I
			//IL_0160: Expected O, but got I
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_0349: Expected O, but got I
			//IL_0359: Expected O, but got I
			//IL_0383: Expected O, but got I4
			//IL_03a3: Expected O, but got I
			//IL_0180: Expected O, but got I
			//IL_0190: Expected O, but got I
			//IL_01b2: Expected O, but got I4
			//IL_01e2: Expected O, but got I4
			//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ec: Expected O, but got Unknown
			//IL_0402: Expected O, but got I
			//IL_0413: Expected I, but got O
			//IL_0431: Expected O, but got I
			//IL_0212: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E655B]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v13+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v13+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459E]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_02c5;
			IL_016e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v34+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v16+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v16+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			object obj12;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v34+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj11 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v22+B8]");
					obj8 = 0;
				}
				object obj13 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 136;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj14 = (nint)0 + (nint)3512;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj8, (IntPtr)obj14);
				object obj15 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v21+B8]");
				object obj16 = (nint)0 + (nint)8;
				obj16 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				predicate = func;
			}
			IEnumerable<object> source2;
			IEnumerable<object> source = Enumerable.Where(source2, predicate);
			return (List<UserReferralModel>)(object)Enumerable.ToList(source);
			IL_03b1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18;
			object obj17 = obj18;
			obj12 = obj18;
			IEnumerable<object> enumerable;
			source2 = enumerable;
			goto IL_016e;
			IL_0101:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v46+B8]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v25+8]");
			source2 = (IEnumerable<object>)0;
			obj17 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v34+E4]");
			bool flag5 = (nint)0 == 0;
			obj18 = obj12;
			object obj20 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v25+8]");
			enumerable = (IEnumerable<object>)0;
			if (!flag5)
			{
				goto IL_016e;
			}
			goto IL_03b1;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459E]");
			object obj21 = (nint)0 & (nint)1;
			if (obj21 != null)
			{
				goto IL_00b0;
			}
			goto IL_02c5;
			IL_02c5:
			_ = 1;
			obj12 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 272;
			object obj22 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v46+E4]");
			bool flag6 = (nint)0 == 0;
			object obj23 = !flag6;
			obj18 = obj12;
			object obj24 = obj22;
			if (obj23 != null)
			{
				goto IL_0101;
			}
			goto IL_0327;
			IL_00b0:
			obj12 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 272;
			obj22 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v46+E4]");
			bool flag7 = (nint)0 == 0;
			obj18 = obj12;
			obj24 = obj22;
			if (!flag7)
			{
				goto IL_0101;
			}
			goto IL_0327;
			IL_0327:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v6+B8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v4+8]");
			source2 = (IEnumerable<object>)0;
			obj17 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v34+E4]");
			bool flag8 = (nint)0 == 0;
			object obj27 = !flag8;
			obj12 = obj18;
			obj20 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v4+8]");
			enumerable = (IEnumerable<object>)0;
			if (obj27 != null)
			{
				goto IL_016e;
			}
			goto IL_03b1;
		}
	}

	public static List<UserReferralRewardModel> ReferralRewards
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e5: Expected O, but got I4
			//IL_0125: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6616]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CachedModel<List<UserReferralRewardModel>> referralRewards = CachedModels.ReferralRewards;
			bool flag2 = referralRewards == null;
			object obj5 = !flag2;
			CachedModel<object> cachedModel = (CachedModel<object>)(object)referralRewards;
			if (obj5 != null)
			{
				goto IL_00a2;
			}
			goto IL_013b;
			IL_00a2:
			return (List<UserReferralRewardModel>)cachedModel.Model;
			IL_013b:
			return (List<UserReferralRewardModel>)(object)new NullReferenceException();
			IL_0074:
			CachedModel<List<UserReferralRewardModel>> referralRewards2 = CachedModels.ReferralRewards;
			bool flag3 = referralRewards2 == null;
			cachedModel = (CachedModel<object>)(object)referralRewards2;
			if (!flag3)
			{
				goto IL_00a2;
			}
			goto IL_013b;
		}
	}

	public static bool NewReferrals
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_010a: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E655C]");
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
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+10]");
			return false;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+10]");
			return false;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00c2: Expected O, but got I4
			//IL_008c: Expected O, but got I
			//IL_00fa: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E655D]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+B8]");
			object obj7 = 0;
			return;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+B8]");
			object obj8 = 0;
		}
	}

	public static bool HasReward
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_010a: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E655E]");
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
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+11]");
			return false;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+11]");
			return false;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00c2: Expected O, but got I4
			//IL_008c: Expected O, but got I
			//IL_00fa: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E655F]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+B8]");
			object obj7 = 0;
			return;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+B8]");
			object obj8 = 0;
		}
	}

	public static event Action<UserReferralRewardModel> OnRewardClaimed
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3968;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
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
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3968;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6562]");
		object obj3 = (nint)0 & (nint)1;
		GameObject gameObject;
		UnityEngine.Object target;
		if (obj3 != null)
		{
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			target = gameObject;
			object obj5 = 0;
			if (!flag)
			{
				goto IL_0098;
			}
		}
		else
		{
			_ = 1;
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			target = gameObject;
			object obj5 = 0;
			if (obj6 != null)
			{
				goto IL_0098;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		return;
		IL_0098:
		UnityEngine.Object.DontDestroyOnLoad(target);
	}

	public static void CallWhenReady(Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0151: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01d7: Expected O, but got I4
		//IL_017f: Expected O, but got I
		//IL_0199: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_023f: Expected O, but got I
		//IL_020f: Expected O, but got I
		//IL_0306: Expected O, but got I4
		//IL_02a1: Expected O, but got I
		//IL_02c3: Expected O, but got I4
		//IL_0361: Expected O, but got I
		//IL_033e: Expected O, but got I
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_03bd: Expected O, but got I4
		//IL_03e6: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6563]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v28+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v28+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459F]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01a7;
		IL_0291:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v17+B8]");
		object obj7 = 0;
		object obj8 = obj7;
		bool flag3 = obj7 == null;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_034b;
		}
		goto IL_03ff;
		IL_034b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v5+18]");
		object obj10 = (nint)0 & (nint)1;
		if (obj10 == null)
		{
			object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v5+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj14 = (nint)0 + (nint)208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			ReferralHandler referralHandler = default(ReferralHandler);
			referralHandler.CheckReferrals();
		}
		return;
		IL_03ff:
		throw new NullReferenceException();
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459F]");
		object obj15 = (nint)0 & (nint)1;
		if (obj15 != null)
		{
			goto IL_00a7;
		}
		goto IL_01a7;
		IL_01a7:
		_ = 1;
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v40+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		object obj18 = obj16;
		if (obj17 != null)
		{
			goto IL_00dc;
		}
		goto IL_01ed;
		IL_00a7:
		obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v40+E4]");
		bool flag6 = (nint)0 == 0;
		obj18 = obj16;
		if (!flag6)
		{
			goto IL_00dc;
		}
		goto IL_01ed;
		IL_01ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v21+B8]");
		object obj20 = 0;
		OneShotEvent oneShotEvent = (OneShotEvent)obj20;
		goto IL_021c;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v40+B8]");
		object obj21 = 0;
		oneShotEvent = (OneShotEvent)obj21;
		bool flag7 = obj21 == null;
		object obj22 = !flag7;
		if (obj22 != null)
		{
			goto IL_021c;
		}
		goto IL_03ff;
		IL_021c:
		oneShotEvent.CallWhenReady(callback);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459F]");
		object obj23 = (nint)0 & (nint)1;
		if (obj23 != null)
		{
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v17+E4]");
			bool flag8 = (nint)0 == 0;
			object obj25 = obj24;
			if (!flag8)
			{
				goto IL_0291;
			}
		}
		else
		{
			_ = 1;
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v17+E4]");
			bool flag9 = (nint)0 == 0;
			object obj26 = !flag9;
			object obj25 = obj24;
			if (obj26 != null)
			{
				goto IL_0291;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v12+B8]");
		object obj28 = 0;
		obj8 = obj28;
		goto IL_034b;
	}

	public static string GetReferralLink()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (string)(object)new OutOfMemoryException();
	}

	public static void ProcessReferral(Dictionary<string, string> parameters)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected O, but got Unknown
		//IL_0540: Expected O, but got I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_012d: Expected O, but got I
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0185: Expected O, but got I4
		//IL_019b: Expected O, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01da: Expected O, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0252: Expected O, but got I4
		//IL_0268: Expected O, but got I
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_02a7: Expected O, but got I
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_0303: Expected O, but got I4
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_05f2: Expected O, but got I4
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_0385: Expected O, but got I4
		//IL_03ae: Expected O, but got I
		//IL_0425: Expected O, but got I4
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_04ad: Expected O, but got I4
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected O, but got Unknown
		//IL_04e6: Expected O, but got I
		//IL_04f4: Expected I, but got O
		if (parameters != null)
		{
			object obj = "Unsupported map type" + 808;
			object obj2 = (nint)0 + (nint)744;
			object obj3 = typeof(DataRelation) + 856;
			object obj4 = obj;
			object obj5 = obj2;
			if (((Dictionary<object, object>)(object)parameters).ContainsKey(obj))
			{
				object obj6 = "Read object reference Id '{0}' for {1}." + 1048;
				obj4 = obj6;
				obj5 = obj2;
				if (((Dictionary<object, object>)(object)parameters).ContainsKey(obj6))
				{
					object obj7 = typeof(SqlSingle[]) + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					string[] array = default(string[]);
					if (array == null)
					{
						goto IL_0568;
					}
					object obj8 = "___# Content push apply failed [{0}]: {1}" + 1280;
					object obj9 = array + 32;
					obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj10 = (nint)0 + (nint)784;
					object obj11 = ((Dictionary<object, object>)(object)parameters).get_Item(obj6);
					object obj12 = array + 40;
					obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X21_v7-10]");
					bool flag = (nint)0 < (nint)2;
					object obj13 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X21_v7-10]");
					object obj14 = -2;
					bool flag2 = obj14 == null;
					object obj15 = ~obj13;
					object obj16 = obj15 | flag2;
					if (obj16 == null)
					{
						object obj17 = (nint)0 + (nint)2728;
						object obj18 = array + 48;
						obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj19 = ((Dictionary<object, object>)(object)parameters).get_Item(obj);
						object obj20 = array + 56;
						obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X21_v11-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj21 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X21_v11-20]");
						object obj22 = -4;
						bool flag4 = obj22 == null;
						object obj23 = ~obj21;
						object obj24 = obj23 | flag4;
						if (obj24 == null)
						{
							object obj25 = (nint)0 + (nint)2664;
							object obj26 = array + 64;
							obj26 = obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							string text = string.Concat(array);
							object obj27 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v19+E4]");
							bool flag5 = (nint)0 == 0;
							object obj28 = !flag5;
							object message = text;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								message = text;
							}
							Debug.Log(message);
							object obj29 = ((Dictionary<object, object>)(object)parameters).get_Item(obj);
							object obj30 = typeof(UsageHint) + 72;
							object obj31 = obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v20+E4]");
							bool flag6 = (nint)0 == 0;
							object obj32 = !flag6;
							string referringUserToken = (string)obj29;
							if (obj32 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								referringUserToken = (string)obj29;
							}
							UserInfo.ReferringUserToken = referringUserToken;
							object referringUserName = ((Dictionary<object, object>)(object)parameters).get_Item(obj6);
							UserInfo.ReferringUserName = (string)referringUserName;
							object obj33 = typeof(Queue<string>) + 848;
							object obj34 = obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v40+E4]");
							bool flag7 = (nint)0 == 0;
							object obj35 = !flag7;
							if (obj35 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj36 = (nint)0 + (nint)2200;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
							SessionModel sessionModel = default(SessionModel);
							if ((object)sessionModel != null)
							{
								if (sessionModel.IsConnected)
								{
									object obj37 = obj30;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v45+E4]");
									bool flag8 = (nint)0 == 0;
									object obj38 = !flag8;
									if (obj38 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									string referringUserToken2 = UserInfo.ReferringUserToken;
									object obj39 = "Unsupported map type" + 600;
									object obj40 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1072;
									string text2 = (string)obj39 + referringUserToken2 + (string)obj40;
									object obj41 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v31+E4]");
									bool flag9 = (nint)0 == 0;
									object obj42 = !flag9;
									object message2 = text2;
									if (obj42 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										message2 = text2;
									}
									Debug.Log(message2);
									string referringUserToken3 = UserInfo.ReferringUserToken;
									object obj43 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj44 = (nint)0 + (nint)2088;
									Action<object> action = default(Action<object>);
									action..ctor((object)null, (IntPtr)obj44);
									KammelnaRequests.SendReferralReport(referringUserToken3, action);
								}
								return;
							}
							goto IL_0568;
						}
					}
					goto IL_0576;
				}
			}
			object message3 = "___# Content push apply failed [{0}]: {1}" + 640;
			object obj45 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v9+E4]");
			bool flag10 = (nint)0 == 0;
			object obj46 = !flag10;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message3);
			return;
		}
		goto IL_0568;
		IL_0576:
		throw new IndexOutOfRangeException();
		IL_0568:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0576;
	}

	private void CheckReferrals()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02d7: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_032f: Expected O, but got I4
		//IL_0284: Expected I, but got O
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_018d: Expected O, but got I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I
		//IL_0217: Expected O, but got I4
		//IL_0252: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6565]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string text = UserInfo.ReferringUserToken;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		string text2 = text;
		if (obj9 != null)
		{
			goto IL_00d7;
		}
		goto IL_0345;
		IL_00d7:
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 440;
		object obj11 = (nint)0 + (nint)2056;
		bool flag4 = StringsExtensions.IsNullOrEmpty(text);
		bool flag5 = !flag4;
		object obj12 = !flag5;
		Action<KammelnaResponseModel<bool>> action = null;
		if (obj12 == null)
		{
			object obj13 = "Unsupported map type" + 600;
			object obj14 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1072;
			object obj15 = typeof(DataRelation) + 856;
			object obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v43+E4]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			object obj19 = (nint)0 + (nint)2088;
			string referringUserToken = UserInfo.ReferringUserToken;
			string text3 = (string)obj13 + referringUserToken + (string)obj14;
			object obj20 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v10+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			object message = text3;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text3;
			}
			Debug.Log(message);
			string referringUserToken2 = UserInfo.ReferringUserToken;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action2 = default(Action<object>);
			action2..ctor((object)null, (IntPtr)obj19);
			KammelnaRequests.SendReferralReport(referringUserToken2, action2);
			action = action2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj11);
		KammelnaRequests.GetReferralsHistory(action3);
		return;
		IL_0345:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		text = text2;
		goto IL_00d7;
		IL_0099:
		text = UserInfo.ReferringUserToken;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v2+E4]");
		bool flag8 = (nint)0 == 0;
		text2 = text;
		if (!flag8)
		{
			goto IL_00d7;
		}
		goto IL_0345;
	}

	private void CheckHistoryForRewards(KammelnaResponseModel<List<UserReferralModel>> response)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0058: Expected O, but got I4
		//IL_0321: Expected O, but got I
		//IL_033b: Expected O, but got I4
		//IL_0211: Expected O, but got I
		//IL_06b0: Expected O, but got I
		//IL_06ca: Expected O, but got I4
		//IL_0379: Expected O, but got I4
		//IL_00b9: Expected O, but got I
		//IL_0279: Expected O, but got I
		//IL_0770: Expected O, but got I
		//IL_0720: Expected O, but got I4
		//IL_0d46: Expected O, but got I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_014b: Expected O, but got I
		//IL_0de5: Expected O, but got I
		//IL_0df4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df9: Expected O, but got Unknown
		//IL_0d0e: Expected O, but got I4
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected O, but got Unknown
		//IL_07eb: Expected O, but got I4
		//IL_03c8: Expected O, but got I
		//IL_03d8: Expected O, but got I
		//IL_03fa: Expected O, but got I4
		//IL_01c8: Expected I, but got O
		//IL_046b: Expected O, but got I
		//IL_0473: Expected I, but got O
		//IL_0488: Expected O, but got I
		//IL_02bc: Expected O, but got I
		//IL_02cc: Expected O, but got I
		//IL_02ee: Expected O, but got I4
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Expected O, but got Unknown
		//IL_0951: Expected O, but got I
		//IL_095f: Expected I, but got O
		//IL_0822: Expected O, but got I
		//IL_082a: Expected I4, but got O
		//IL_05ab: Expected O, but got I
		//IL_05c5: Expected O, but got I4
		//IL_042a: Expected O, but got I4
		//IL_04cf: Expected O, but got I
		//IL_0d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d68: Expected O, but got Unknown
		//IL_0d7e: Expected O, but got I
		//IL_0d8f: Expected I, but got O
		//IL_0dad: Expected O, but got I
		//IL_0dc8: Expected O, but got I4
		//IL_063b: Expected O, but got I
		//IL_0662: Expected O, but got I4
		//IL_0603: Expected O, but got I4
		//IL_045a: Expected O, but got I
		//IL_098e: Expected O, but got I
		//IL_09a8: Expected O, but got I4
		//IL_0531: Expected O, but got I
		//IL_0558: Expected O, but got I4
		//IL_089f: Expected O, but got I
		//IL_09e6: Expected O, but got I4
		//IL_090c: Expected O, but got I4
		//IL_0a25: Expected O, but got I
		//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Expected O, but got Unknown
		//IL_0a61: Expected O, but got I
		//IL_0a6f: Expected I, but got O
		//IL_0a7b: Expected O, but got I
		//IL_0aa7: Expected O, but got I
		//IL_0bca: Expected O, but got I4
		//IL_0b09: Expected O, but got I
		//IL_0b24: Expected O, but got I
		//IL_0c75: Expected O, but got I4
		//IL_0c02: Expected O, but got I
		//IL_0c1d: Expected O, but got I
		//IL_0c37: Expected O, but got I4
		//IL_0b7e: Expected O, but got I
		//IL_0cad: Expected O, but got I
		//IL_0ccf: Expected O, but got I4
		object obj = (nint)0 + (nint)888;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		Func<object, bool> func = (Func<object, bool>)obj;
		bool succeeded = ((KammelnaResponseModel<object>)(object)response).Succeeded;
		object obj3 = obj2;
		bool flag = !succeeded;
		object obj4 = !flag;
		object obj5;
		nint num;
		Func<object, bool> func2;
		object obj6 = default(object);
		nint num2 = default(nint);
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v72+E4]");
			bool flag2 = (nint)0 == 0;
			obj5 = obj6;
			num = num2;
			func2 = (Func<object, bool>)obj;
			if (!flag2)
			{
				goto IL_00a3;
			}
			goto IL_0690;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v72+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A0]");
			object obj7 = (nint)0 & (nint)1;
			if (obj7 != null)
			{
				goto IL_022e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A0]");
			object obj8 = (nint)0 & (nint)1;
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_022e;
			}
		}
		_ = 1;
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v83+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		object obj12 = obj10;
		if (obj11 != null)
		{
			goto IL_0263;
		}
		goto IL_038f;
		IL_07ad:
		object obj13 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CachedModel<List<UserReferralRewardModel>> referralRewards = CachedModels.ReferralRewards;
		object obj16 = (nint)0 + (nint)584;
		CanvasLayer canvasLayer = (CanvasLayer)obj16;
		bool flag6 = ((CachedModel<object>)(object)referralRewards).IsValid();
		bool flag7 = !flag6;
		obj6 = obj5;
		if (flag7)
		{
			goto IL_0927;
		}
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6616]");
			object obj18 = (nint)0 & (nint)1;
			if (obj18 != null)
			{
				goto IL_08bc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6616]");
			object obj19 = (nint)0 & (nint)1;
			bool flag8 = obj19 == null;
			object obj20 = !flag8;
			if (obj20 != null)
			{
				goto IL_08bc;
			}
		}
		_ = 1;
		object obj21 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X0_v45+E4]");
		bool flag9 = (nint)0 == 0;
		object obj22 = !flag9;
		if (obj22 != null)
		{
			goto IL_08e9;
		}
		goto IL_09f4;
		IL_0b6e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v40+B8]");
		object obj23 = 0;
		OneShotEvent oneShotEvent = (OneShotEvent)obj23;
		goto IL_0b8b;
		IL_0b41:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v40+E4]");
		bool flag10 = (nint)0 == 0;
		object obj25;
		object obj24 = obj25;
		if (!flag10)
		{
			goto IL_0b6e;
		}
		goto IL_0c8b;
		IL_0c8b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X0_v26+B8]");
		object obj27 = 0;
		oneShotEvent = (OneShotEvent)obj27;
		bool flag11 = obj27 == null;
		object obj28 = !flag11;
		if (obj28 != null)
		{
			goto IL_0b8b;
		}
		goto IL_0cdd;
		IL_022e:
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v83+E4]");
		bool flag12 = (nint)0 == 0;
		obj12 = obj10;
		if (!flag12)
		{
			goto IL_0263;
		}
		goto IL_038f;
		IL_038f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj10 = obj2;
		goto IL_0263;
		IL_0263:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v83+B8]");
		object obj29 = (nint)0 + (nint)8;
		obj29 = response.<Model>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj30 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v89+E4]");
		bool flag13 = (nint)0 == 0;
		object obj31 = !flag13;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v89+B8]");
		object obj32 = 0;
		object obj33 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 272;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v107+E4]");
		object obj35;
		Func<object, bool> func3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v107+B8]");
			obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v93+10]");
			func3 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v93+10]");
			bool flag14 = (nint)0 == 0;
			object obj36 = !flag14;
			if (obj36 == null)
			{
				goto IL_0408;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj34 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v107+B8]");
			obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v93+10]");
			func3 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v93+10]");
			bool flag15 = (nint)0 == 0;
			object obj37 = !flag15;
			if (obj37 == null)
			{
				goto IL_0408;
			}
		}
		goto IL_045f;
		IL_0cdd:
		throw new NullReferenceException();
		IL_018b:
		object obj38 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v126+E4]");
		bool flag16 = (nint)0 == 0;
		object obj40 = !flag16;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PrefabInitializer.InitializePrefab(successPopupRef, CanvasLayer.SecondaryCanvas);
		num = unchecked((nint)null);
		canvasLayer = CanvasLayer.SecondaryCanvas;
		goto IL_0927;
		IL_08bc:
		obj21 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X0_v45+E4]");
		if ((nint)0 != 0)
		{
			goto IL_08e9;
		}
		goto IL_09f4;
		IL_0b8b:
		oneShotEvent.IsReady = true;
		return;
		IL_0408:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v107+E4]");
		bool flag17 = (nint)0 == 0;
		object obj41 = !flag17;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj42 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v99+B8]");
			obj35 = 0;
		}
		object obj43 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj44 = (nint)0 + (nint)3504;
		Func<object, bool> func4 = default(Func<object, bool>);
		func4..ctor(obj35, (IntPtr)obj44);
		object obj45 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v98+B8]");
		object obj46 = (nint)0 + (nint)16;
		obj46 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj6 = 0;
		func3 = func4;
		goto IL_045f;
		IL_08e9:
		CachedModel<List<UserReferralRewardModel>> referralRewards2 = CachedModels.ReferralRewards;
		bool flag18 = referralRewards2 == null;
		object obj47 = !flag18;
		CachedModel<object> cachedModel = (CachedModel<object>)(object)referralRewards2;
		if (obj47 != null)
		{
			goto IL_0a19;
		}
		goto IL_0cdd;
		IL_09f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CachedModel<List<UserReferralRewardModel>> referralRewards3 = CachedModels.ReferralRewards;
		cachedModel = (CachedModel<object>)(object)referralRewards3;
		goto IL_0a19;
		IL_045f:
		object obj48 = (nint)0 + (nint)2904;
		num2 = (nint)obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v73+8]");
		bool flag19 = Enumerable.Any((IEnumerable<object>)0, func3);
		object obj49 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X0_v94+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A1]");
			object obj50 = (nint)0 & (nint)1;
			if (obj50 != null)
			{
				goto IL_04ec;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A1]");
			object obj51 = (nint)0 & (nint)1;
			bool flag20 = obj51 == null;
			object obj52 = !flag20;
			if (obj52 != null)
			{
				goto IL_04ec;
			}
		}
		_ = 1;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v72+E4]");
		bool flag21 = (nint)0 == 0;
		object obj53 = !flag21;
		object obj54 = obj3;
		if (obj53 != null)
		{
			goto IL_0521;
		}
		goto IL_0619;
		IL_0af9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v40+B8]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459F]");
		object obj56 = (nint)0 & (nint)1;
		if (obj56 != null)
		{
			goto IL_0b41;
		}
		goto IL_0c45;
		IL_0927:
		object obj57 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj58 = (nint)0 + (nint)2048;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj58);
		KammelnaRequests.GetReferralRewards(action);
		return;
		IL_0a19:
		object obj59 = (nint)0 + (nint)600;
		object model = cachedModel.Model;
		object obj60 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj61 = (nint)0 + (nint)2080;
		Func<object, bool> func5 = default(Func<object, bool>);
		func5..ctor((object)null, (IntPtr)obj61);
		object obj62 = (nint)0 + (nint)2912;
		bool flag22 = Enumerable.Any((IEnumerable<object>)model, func5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A3]");
		object obj63 = (nint)0 & (nint)1;
		if (obj63 != null)
		{
			obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v40+E4]");
			bool flag23 = (nint)0 == 0;
			object obj64 = obj25;
			if (!flag23)
			{
				goto IL_0af9;
			}
		}
		else
		{
			_ = 1;
			obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v40+E4]");
			bool flag24 = (nint)0 == 0;
			object obj65 = !flag24;
			object obj64 = obj25;
			if (obj65 != null)
			{
				goto IL_0af9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v40+B8]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459F]");
		object obj67 = (nint)0 & (nint)1;
		bool flag25 = obj67 == null;
		object obj68 = !flag25;
		if (obj68 != null)
		{
			goto IL_0b41;
		}
		goto IL_0c45;
		IL_04ec:
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v72+E4]");
		bool flag26 = (nint)0 == 0;
		obj54 = obj3;
		if (!flag26)
		{
			goto IL_0521;
		}
		goto IL_0619;
		IL_0619:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v72+B8]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v72+E4]");
		bool flag27 = (nint)0 == 0;
		object obj70 = !flag27;
		func = func3;
		obj5 = obj6;
		num = num2;
		func2 = func3;
		if (obj70 != null)
		{
			goto IL_00a3;
		}
		goto IL_0690;
		IL_0521:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v72+B8]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v72+E4]");
		bool flag28 = (nint)0 == 0;
		object obj72 = !flag28;
		func = func3;
		if (obj72 != null)
		{
			goto IL_00a3;
		}
		obj5 = obj6;
		num = num2;
		func2 = func3;
		goto IL_0690;
		IL_0c45:
		_ = 1;
		obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v40+E4]");
		bool flag29 = (nint)0 == 0;
		object obj73 = !flag29;
		obj24 = obj25;
		if (obj73 != null)
		{
			goto IL_0b6e;
		}
		goto IL_0c8b;
		IL_013b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v133+B8]");
		object obj74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v113+10]");
		bool flag30 = (nint)0 != 1;
		obj5 = obj6;
		num = num2;
		func2 = func;
		if (!flag30)
		{
			goto IL_018b;
		}
		goto IL_07ad;
		IL_0690:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A2]");
		object obj75 = (nint)0 & (nint)1;
		bool flag31 = obj75 == null;
		object obj76 = !flag31;
		obj6 = obj5;
		num2 = num;
		func = func2;
		if (obj76 != null)
		{
			goto IL_00ee;
		}
		goto IL_06f0;
		IL_00a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A2]");
		object obj77 = (nint)0 & (nint)1;
		bool flag32 = obj77 == null;
		obj5 = obj6;
		num = num2;
		func2 = func;
		if (!flag32)
		{
			goto IL_00ee;
		}
		goto IL_06f0;
		IL_06f0:
		_ = 1;
		object obj78 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v133+E4]");
		bool flag33 = (nint)0 == 0;
		object obj79 = !flag33;
		obj6 = obj5;
		num2 = num;
		func = func2;
		object obj80 = obj78;
		if (obj79 != null)
		{
			goto IL_013b;
		}
		goto IL_074e;
		IL_00ee:
		obj78 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v133+E4]");
		bool flag34 = (nint)0 == 0;
		obj5 = obj6;
		num = num2;
		func2 = func;
		obj80 = obj78;
		if (!flag34)
		{
			goto IL_013b;
		}
		goto IL_074e;
		IL_074e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj81 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v66+B8]");
		object obj82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v56+10]");
		bool flag35 = (nint)0 == 1;
		obj6 = obj5;
		num2 = num;
		func = func2;
		if (flag35)
		{
			goto IL_018b;
		}
		goto IL_07ad;
	}

	private void CheckClaimableReward(KammelnaResponseModel<List<UserReferralRewardModel>> response)
	{
		//IL_049b: Expected O, but got I
		//IL_04b5: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_027a: Expected O, but got I4
		//IL_057b: Expected O, but got I
		//IL_05a2: Expected O, but got I4
		//IL_051b: Expected O, but got I4
		//IL_02ed: Expected O, but got I
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0081: Expected O, but got I
		//IL_008f: Expected I, but got O
		//IL_01ee: Expected O, but got I
		//IL_0215: Expected O, but got I4
		//IL_03dc: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_00a8: Expected I, but got O
		//IL_00e6: Expected O, but got I4
		//IL_00f6: Expected O, but got I4
		//IL_034f: Expected O, but got I
		//IL_038f: Expected O, but got I4
		//IL_0414: Expected O, but got I
		//IL_0436: Expected O, but got I4
		//IL_045f: Expected O, but got I4
		//IL_011a: Expected O, but got I
		//IL_0132: Expected O, but got I4
		//IL_0142: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		//IL_0153: Expected I, but got O
		//IL_016b: Expected O, but got I4
		KammelnaResponseModel<List<UserReferralRewardModel>> kammelnaResponseModel = default(KammelnaResponseModel<List<UserReferralRewardModel>>);
		bool flag = kammelnaResponseModel == null;
		KammelnaResponseModel<List<UserReferralRewardModel>> kammelnaResponseModel2 = kammelnaResponseModel;
		if (flag)
		{
			goto IL_046d;
		}
		object obj = (nint)0 + (nint)904;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		KammelnaResponseModel<List<UserReferralRewardModel>> kammelnaResponseModel3 = (KammelnaResponseModel<List<UserReferralRewardModel>>)obj;
		nint num = default(nint);
		object obj6 = default(object);
		Func<object, bool> func2;
		object obj8;
		nint num2;
		object obj9;
		NullReferenceException ex;
		KammelnaResponseModel<List<UserReferralRewardModel>> kammelnaResponseModel4;
		if (((KammelnaResponseModel<object>)(object)kammelnaResponseModel).Succeeded)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = (nint)0 + (nint)2080;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)null, (IntPtr)obj4);
			object obj5 = (nint)0 + (nint)2912;
			num = (nint)obj5;
			bool flag2 = Enumerable.Any(kammelnaResponseModel.<Model>k__BackingField, func);
			ex = (NullReferenceException)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v10 (System.NullReferenceException)+E4]");
			bool flag3 = (nint)0 == 0;
			obj6 = 0;
			kammelnaResponseModel = (KammelnaResponseModel<List<UserReferralRewardModel>>)(object)func;
			kammelnaResponseModel2 = (KammelnaResponseModel<List<UserReferralRewardModel>>)flag2;
			if (flag3)
			{
				goto IL_047b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A3]");
			object obj7 = (nint)0 & (nint)1;
			bool flag4 = obj7 == null;
			obj6 = 0;
			func2 = func;
			kammelnaResponseModel2 = (KammelnaResponseModel<List<UserReferralRewardModel>>)flag2;
			obj8 = 0;
			num2 = (nint)obj5;
			kammelnaResponseModel = (KammelnaResponseModel<List<UserReferralRewardModel>>)(object)func;
			obj9 = obj2;
			kammelnaResponseModel4 = (KammelnaResponseModel<List<UserReferralRewardModel>>)flag2;
			if (!flag4)
			{
				goto IL_0179;
			}
			goto IL_04eb;
		}
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v27+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		obj8 = obj6;
		num2 = num;
		KammelnaResponseModel<List<UserReferralRewardModel>> kammelnaResponseModel5 = (KammelnaResponseModel<List<UserReferralRewardModel>>)obj;
		obj9 = obj2;
		if (obj11 == null)
		{
			goto IL_02a8;
		}
		goto IL_02d7;
		IL_04eb:
		_ = 1;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v27+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		obj6 = obj8;
		num = num2;
		kammelnaResponseModel5 = kammelnaResponseModel;
		obj2 = obj9;
		object obj13 = obj10;
		kammelnaResponseModel2 = kammelnaResponseModel4;
		if (obj12 != null)
		{
			goto IL_01de;
		}
		goto IL_0559;
		IL_033f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v24+B8]");
		object obj14 = 0;
		OneShotEvent oneShotEvent = (OneShotEvent)obj14;
		bool flag7 = obj14 == null;
		obj6 = obj8;
		num = num2;
		kammelnaResponseModel = kammelnaResponseModel5;
		obj2 = obj9;
		kammelnaResponseModel2 = (KammelnaResponseModel<List<UserReferralRewardModel>>)146685952;
		if (!flag7)
		{
			goto IL_039d;
		}
		goto IL_046d;
		IL_0559:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v27+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v27+E4]");
		bool flag8 = (nint)0 == 0;
		object obj16 = !flag8;
		obj8 = obj6;
		num2 = num;
		obj9 = obj2;
		if (obj16 == null)
		{
			kammelnaResponseModel3 = kammelnaResponseModel5;
			goto IL_02a8;
		}
		goto IL_02d7;
		IL_046d:
		ex = new NullReferenceException();
		goto IL_047b;
		IL_0179:
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v27+E4]");
		bool flag9 = (nint)0 == 0;
		obj8 = obj6;
		num2 = num;
		kammelnaResponseModel = (KammelnaResponseModel<List<UserReferralRewardModel>>)(object)func2;
		obj9 = obj2;
		kammelnaResponseModel4 = kammelnaResponseModel2;
		kammelnaResponseModel5 = (KammelnaResponseModel<List<UserReferralRewardModel>>)(object)func2;
		obj13 = obj10;
		if (!flag9)
		{
			goto IL_01de;
		}
		goto IL_0559;
		IL_01de:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v27+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v27+E4]");
		bool flag10 = (nint)0 == 0;
		object obj18 = !flag10;
		kammelnaResponseModel5 = kammelnaResponseModel;
		if (obj18 == null)
		{
			obj6 = obj8;
			num = num2;
			kammelnaResponseModel3 = kammelnaResponseModel;
			obj2 = obj9;
			goto IL_02a8;
		}
		goto IL_02d7;
		IL_047b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A3]");
		object obj19 = (nint)0 & (nint)1;
		bool flag11 = obj19 == null;
		object obj20 = !flag11;
		func2 = (Func<object, bool>)(object)kammelnaResponseModel;
		obj8 = obj6;
		num2 = num;
		obj9 = obj2;
		kammelnaResponseModel4 = kammelnaResponseModel2;
		if (obj20 != null)
		{
			goto IL_0179;
		}
		goto IL_04eb;
		IL_02a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj8 = obj6;
		num2 = num;
		kammelnaResponseModel5 = kammelnaResponseModel3;
		obj9 = obj2;
		goto IL_02d7;
		IL_02d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459F]");
		object obj21 = (nint)0 & (nint)1;
		if (obj21 != null)
		{
			object obj22 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v24+E4]");
			bool flag12 = (nint)0 == 0;
			object obj23 = obj22;
			if (!flag12)
			{
				goto IL_033f;
			}
		}
		else
		{
			_ = 1;
			object obj22 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v24+E4]");
			bool flag13 = (nint)0 == 0;
			object obj24 = !flag13;
			object obj23 = obj22;
			if (obj24 != null)
			{
				goto IL_033f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj25 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v17+B8]");
		object obj26 = 0;
		oneShotEvent = (OneShotEvent)obj26;
		bool flag14 = obj26 == null;
		object obj27 = !flag14;
		obj6 = obj8;
		num = num2;
		kammelnaResponseModel = kammelnaResponseModel5;
		obj2 = obj9;
		kammelnaResponseModel2 = (KammelnaResponseModel<List<UserReferralRewardModel>>)146685952;
		if (obj27 != null)
		{
			goto IL_039d;
		}
		goto IL_046d;
		IL_039d:
		oneShotEvent.IsReady = true;
	}

	private unsafe static void OnReferralReportResponse(KammelnaResponseModel<bool> response)
	{
		//IL_0135: Expected O, but got I8
		//IL_014f: Expected O, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0177: Expected O, but got I4
		//IL_0281: Expected O, but got Ref
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0063: Expected O, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I4
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02fb: Expected O, but got I4
		//IL_019d: Expected O, but got Ref
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0217: Expected O, but got I4
		//IL_0348: Expected O, but got I
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_042c: Expected O, but got I4
		//IL_00e8: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		if (response.Succeeded)
		{
			object obj = "___# Content push apply failed [{0}]: {1}" + 664;
			object obj2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 888;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X0 (KammelnaResponseModel`1<System.Boolean>)+18]");
			string text = (string)obj + (string)0 + (string)obj2;
			object obj3 = typeof(DataRelation) + 856;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v32+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			object message = text;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text;
			}
			Debug.Log(message);
			object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v42+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6619]");
				object obj8 = (nint)0 & (nint)1;
				bool flag2 = obj8 == null;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					goto IL_0110;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6619]");
				object obj10 = (nint)0 & (nint)1;
				if (obj10 == null)
				{
					goto IL_0110;
				}
			}
			goto IL_03b4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6014]");
		object obj11 = 0 + 4294958296L;
		bool flag3 = (nint)obj11 < 2;
		object obj12 = !flag3;
		object obj13 = obj11 - 2;
		bool flag4 = obj13 == null;
		object obj14 = !flag4;
		object obj15 = obj12 & obj14;
		object obj16 = default(object);
		if (obj15 == null)
		{
			string text2 = ((Enum)(&obj16)).ToString();
			object obj17 = "___# Content push apply failed [{0}]: {1}" + 648;
			object obj18 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1064;
			string text3 = (string)obj17 + text2 + (string)obj18;
			object obj19 = typeof(DataRelation) + 856;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v19+E4]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			object message2 = text3;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message2 = text3;
			}
			Debug.Log(message2);
			object obj22 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v18+E4]");
			bool flag6 = (nint)0 == 0;
			object obj24 = !flag6;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key = "Read object reference Id '{0}' for {1}." + 1064;
			object key2 = "Read object reference Id '{0}' for {1}." + 1056;
			Prefs.DeleteKey((string)key);
			Prefs.DeleteKey((string)key2);
		}
		else
		{
			string text4 = ((Enum)(&obj16)).ToString();
			object obj25 = "___# Content push apply failed [{0}]: {1}" + 656;
			object obj26 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 880;
			string text5 = (string)obj25 + text4 + (string)obj26;
			object obj27 = typeof(DataRelation) + 856;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v12+E4]");
			bool flag7 = (nint)0 == 0;
			object obj29 = !flag7;
			object message3 = text5;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message3 = text5;
			}
			Debug.Log(message3);
		}
		return;
		IL_0110:
		_ = 1;
		goto IL_03b4;
		IL_03b4:
		object key3 = "Read object reference Id '{0}' for {1}." + 1064;
		Prefs.DeleteKey((string)key3);
		object key4 = "Read object reference Id '{0}' for {1}." + 1056;
		Prefs.DeleteKey((string)key4);
	}

	public static void ClearReferralPreferences(bool complete = false)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		object key = "Read object reference Id '{0}' for {1}." + 1064;
		object key2 = "Read object reference Id '{0}' for {1}." + 1056;
		if (complete)
		{
			object key3 = "Read object reference Id '{0}' for {1}." + 1040;
			object key4 = "Read object reference Id '{0}' for {1}." + 1032;
			Prefs.DeleteKey((string)key3);
			Prefs.DeleteKey((string)key4);
		}
		Prefs.DeleteKey((string)key);
		Prefs.DeleteKey((string)key2);
	}

	public static void ClaimReward(UserReferralRewardModel reward)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0081: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = reward;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj3;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj6 = (nint)0 + (nint)3520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+10]");
		KammelnaRequests.SendClaimReward(0, action);
	}

	public static void ClaimAllRewards()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0203: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I
		//IL_02a5: Expected O, but got I4
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0245: Expected O, but got I
		//IL_025f: Expected O, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_013b: Expected O, but got I
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_015b: Expected O, but got I
		//IL_0168: Expected O, but got I
		//IL_0192: Expected I, but got O
		//IL_02e5: Expected O, but got I4
		//IL_01c0: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E661A]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6616]");
		object obj7 = (nint)0 & (nint)1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		object obj9 = obj6;
		if (obj8 != null)
		{
			goto IL_00cc;
		}
		goto IL_0275;
		IL_00f9:
		CachedModel<List<UserReferralRewardModel>> referralRewards = CachedModels.ReferralRewards;
		CachedModel<object> cachedModel = (CachedModel<object>)(object)referralRewards;
		goto IL_010f;
		IL_010f:
		object obj10 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 144;
		object obj11 = (nint)0 + (nint)2080;
		object obj12 = (nint)0 + (nint)3872;
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3968;
		object obj14 = (nint)0 + (nint)2064;
		object obj15 = (nint)0 + (nint)600;
		object model = cachedModel.Model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)null, (IntPtr)obj11);
		IEnumerable<object> enumeration = Enumerable.Where((IEnumerable<object>)model, func);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj14);
		ArraysExtensions.ForEach(enumeration, action);
		return;
		IL_02b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CachedModel<List<UserReferralRewardModel>> referralRewards2 = CachedModels.ReferralRewards;
		bool flag3 = referralRewards2 == null;
		object obj16 = !flag3;
		cachedModel = (CachedModel<object>)(object)referralRewards2;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_010f;
		IL_007d:
		obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6616]");
		object obj17 = (nint)0 & (nint)1;
		bool flag4 = obj17 == null;
		obj9 = obj6;
		if (!flag4)
		{
			goto IL_00cc;
		}
		goto IL_0275;
		IL_0275:
		_ = 1;
		object obj18 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v3+E4]");
		bool flag5 = (nint)0 == 0;
		object obj19 = !flag5;
		if (obj19 != null)
		{
			goto IL_00f9;
		}
		goto IL_02b3;
		IL_00cc:
		obj18 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00f9;
		}
		goto IL_02b3;
	}

	public static bool IsClaimable(UserReferralRewardModel reward)
	{
		//IL_013a: Expected I4, but got O
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00c5: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected I4, but got Unknown
		if (reward != null)
		{
			if (reward.<isClaimed>k__BackingField)
			{
				return false;
			}
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3696;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			List<UserReferralModel> successfulReferrals = SuccessfulReferrals;
			if (successfulReferrals != null)
			{
				object obj4 = successfulReferrals._size - reward.<referralsNeeded>k__BackingField;
				bool flag2 = (nint)obj4 < 0;
				int num = successfulReferrals._size ^ reward.<referralsNeeded>k__BackingField;
				int num2 = successfulReferrals._size ^ obj4;
				int num3 = num & num2;
				bool flag3 = num3 < 0;
				return flag2 == flag3;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void ShowNewReferralsRewards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PrefabInitializer.InitializePrefab(successPopupRef, CanvasLayer.SecondaryCanvas);
	}

	static ReferralHandler()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 3440;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		object obj3 = typeof(List<Tween>) + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent = default(OneShotEvent);
		oneShotEvent..ctor();
		object obj4 = obj2;
		object obj5 = oneShotEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+B8]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
