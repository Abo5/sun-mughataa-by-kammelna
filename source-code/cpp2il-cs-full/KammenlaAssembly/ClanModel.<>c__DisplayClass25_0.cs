using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

[Serializable]
public class ClanModel
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ClanUserModel, bool> <>9__17_0;

		public static Func<ClanUserModel, bool> <>9__19_0;

		public static Func<ClanUserModel, bool> <>9__21_0;

		public static Func<ClanUserModel, bool> <>9__23_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_GetMembers>b__17_0(ClanUserModel m)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (m != null)
			{
				object obj = m.Status - 1;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_GetJoinRequests>b__19_0(ClanUserModel m)
		{
			//IL_0044: Expected I4, but got O
			if (m != null)
			{
				return m.Status == ClanMembershipStatus.Requested;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_GetBannedUsers>b__21_0(ClanUserModel m)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (m != null)
			{
				object obj = m.Status - 2;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_Admins>b__23_0(ClanUserModel m)
		{
			//IL_004f: Expected I4, but got O
			if (m != null)
			{
				bool flag = m.Permissions == ClanPermissions.None;
				return !flag;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass24_0
	{
		public int dbid;

		internal bool <GetClanMemberByDbid>b__0(ClanUserModel m)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (m != null)
			{
				object obj = m.UserId - dbid;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass25_0
	{
		public ClanViewModel viewModel;

		internal ClanUserModel <op_Implicit>b__0(ClanMemberViewModel m)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_014f: Expected O, but got I8
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			_ = 1;
			object obj2 = default(object);
			obj2..ctor();
			if (m != null)
			{
				object obj3 = obj2 + 24;
				obj3 = m.Name;
				_ = m.UserId;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [m @ X1 (Kammelna.Server.Models.Clans.ClanMemberViewModel)+28]");
				_ = 0;
				ClanViewModel clanViewModel = viewModel;
				if (viewModel != null)
				{
					object obj4 = obj2 + 32;
					obj4 = clanViewModel.Name;
					_ = clanViewModel.Id;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					ClanViewModel clanViewModel2 = viewModel;
					if (viewModel != null)
					{
						object obj5 = obj2 + 48;
						obj5 = m.RoleTitle;
						_ = clanViewModel2.Tier;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = m.Permissions;
						ClanViewModel clanViewModel3 = viewModel;
						if (viewModel != null)
						{
							object obj6 = m.UserId - clanViewModel3.OwnerId;
							bool flag = obj6 == null;
							_ = 1;
							return (ClanUserModel)obj2;
						}
					}
				}
			}
			return (ClanUserModel)(object)new NullReferenceException();
		}

		internal bool <op_Implicit>b__1(ClanUserModel m)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I8
			if (m != null)
			{
				ClanViewModel clanViewModel = viewModel;
				if (viewModel != null)
				{
					object obj = m.UserId - clanViewModel.OwnerId;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public int ClanId;

	public string Name;

	public string Description;

	public string Rules;

	public int Points;

	public long MonthlyPoints;

	public int MaxPlayers;

	public int ParticipantCount;

	public int Tier;

	public int PurchasedEmblemTier;

	public int ActiveEmblemTier;

	public ClanUserModel Owner;

	public List<ClanUserModel> Members;

	public ClanLogoModel Logo;

	public FileInfoModel Emblem;

	public bool AutoRenewal;

	public DateTime? DateSubscriptionExpires;

	public IEnumerable<ClanUserModel> GetMembers
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_00a5: Expected O, but got I
			//IL_00b5: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01aa: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0289: Expected O, but got I
			//IL_029a: Expected I, but got O
			//IL_02b8: Expected O, but got I
			//IL_0244: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(CardUtils.<>c) + 1216;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8935]");
			object obj3 = (nint)0 & (nint)1;
			List<ClanUserModel> members;
			List<ClanUserModel> members2;
			object obj4;
			if (obj3 != null)
			{
				members = Members;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				members2 = Members;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				members = Members;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				members2 = Members;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)3368;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			IEnumerable<object> enumerable = members2;
			object obj10 = obj7;
			IEnumerable<object> source = members2;
			if (obj9 == null)
			{
				goto IL_01f2;
			}
			goto IL_0249;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)424;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj7;
			predicate = func;
			source = enumerable;
			goto IL_0249;
			IL_0249:
			return (IEnumerable<ClanUserModel>)Enumerable.Where(source, predicate);
			IL_0099:
			obj10 = (nint)0 + (nint)3368;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			source = members;
			if (obj17 == null)
			{
				obj7 = obj10;
				enumerable = members;
				goto IL_01f2;
			}
			goto IL_0249;
		}
	}

	public IEnumerable<ClanUserModel> GetJoinRequests
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_00a5: Expected O, but got I
			//IL_00b5: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01aa: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0289: Expected O, but got I
			//IL_029a: Expected I, but got O
			//IL_02b8: Expected O, but got I
			//IL_0244: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(CardUtils.<>c) + 1216;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8936]");
			object obj3 = (nint)0 & (nint)1;
			List<ClanUserModel> members;
			List<ClanUserModel> members2;
			object obj4;
			if (obj3 != null)
			{
				members = Members;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				members2 = Members;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				members = Members;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				members2 = Members;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)3368;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+10]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+10]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			IEnumerable<object> enumerable = members2;
			object obj10 = obj7;
			IEnumerable<object> source = members2;
			if (obj9 == null)
			{
				goto IL_01f2;
			}
			goto IL_0249;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)416;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
			object obj16 = (nint)0 + (nint)16;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj7;
			predicate = func;
			source = enumerable;
			goto IL_0249;
			IL_0249:
			return (IEnumerable<ClanUserModel>)Enumerable.Where(source, predicate);
			IL_0099:
			obj10 = (nint)0 + (nint)3368;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+10]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			source = members;
			if (obj17 == null)
			{
				obj7 = obj10;
				enumerable = members;
				goto IL_01f2;
			}
			goto IL_0249;
		}
	}

	public IEnumerable<ClanUserModel> GetBannedUsers
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_00a5: Expected O, but got I
			//IL_00b5: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01aa: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0289: Expected O, but got I
			//IL_029a: Expected I, but got O
			//IL_02b8: Expected O, but got I
			//IL_0244: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(CardUtils.<>c) + 1216;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8937]");
			object obj3 = (nint)0 & (nint)1;
			List<ClanUserModel> members;
			List<ClanUserModel> members2;
			object obj4;
			if (obj3 != null)
			{
				members = Members;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				members2 = Members;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				members = Members;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				members2 = Members;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)3368;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+18]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+18]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			IEnumerable<object> enumerable = members2;
			object obj10 = obj7;
			IEnumerable<object> source = members2;
			if (obj9 == null)
			{
				goto IL_01f2;
			}
			goto IL_0249;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)408;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
			object obj16 = (nint)0 + (nint)24;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj7;
			predicate = func;
			source = enumerable;
			goto IL_0249;
			IL_0249:
			return (IEnumerable<ClanUserModel>)Enumerable.Where(source, predicate);
			IL_0099:
			obj10 = (nint)0 + (nint)3368;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+18]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+18]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			source = members;
			if (obj17 == null)
			{
				obj7 = obj10;
				enumerable = members;
				goto IL_01f2;
			}
			goto IL_0249;
		}
	}

	public IEnumerable Admins
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_00a5: Expected O, but got I
			//IL_00b5: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01aa: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0289: Expected O, but got I
			//IL_029a: Expected I, but got O
			//IL_02b8: Expected O, but got I
			//IL_0244: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(CardUtils.<>c) + 1216;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8938]");
			object obj3 = (nint)0 & (nint)1;
			List<ClanUserModel> members;
			List<ClanUserModel> members2;
			object obj4;
			if (obj3 != null)
			{
				members = Members;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				members2 = Members;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				members = Members;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				members2 = Members;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)3368;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+20]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+20]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			IEnumerable<object> enumerable = members2;
			object obj10 = obj7;
			IEnumerable<object> source = members2;
			if (obj9 == null)
			{
				goto IL_01f2;
			}
			goto IL_0249;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)400;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
			object obj16 = (nint)0 + (nint)32;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj7;
			predicate = func;
			source = enumerable;
			goto IL_0249;
			IL_0249:
			return Enumerable.Where(source, predicate);
			IL_0099:
			obj10 = (nint)0 + (nint)3368;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+20]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+20]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			source = members;
			if (obj17 == null)
			{
				obj7 = obj10;
				enumerable = members;
				goto IL_01f2;
			}
			goto IL_0249;
		}
	}

	public ClanUserModel GetClanMemberByDbid(int dbid)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005a: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 760;
			object obj4 = (nint)0 + (nint)432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return (ClanUserModel)Enumerable.FirstOrDefault(Members, func);
		}
		return (ClanUserModel)(object)new NullReferenceException();
	}

	public unsafe static implicit operator ClanModel(ClanViewModel viewModel)
	{
		//IL_0010: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0e65: Expected O, but got I4
		//IL_0c62: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0c98: Expected O, but got I4
		//IL_0ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd2: Expected O, but got Unknown
		//IL_0ce2: Expected O, but got I
		//IL_0d0e: Expected O, but got I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01aa: Expected O, but got I
		//IL_01f9: Expected O, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I
		//IL_00d6: Expected I, but got O
		//IL_00e7: Expected O, but got I
		//IL_0104: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_0238: Expected O, but got I4
		//IL_0148: Expected O, but got I4
		//IL_0151: Expected O, but got I4
		//IL_015a: Expected O, but got I4
		//IL_0d9f: Expected O, but got I
		//IL_0da7: Expected I4, but got O
		//IL_0dc8: Expected O, but got I4
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected O, but got Unknown
		//IL_0845: Expected O, but got I
		//IL_0856: Expected I, but got O
		//IL_0867: Expected O, but got I
		//IL_088f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Expected O, but got Unknown
		//IL_0258: Expected O, but got I
		//IL_08bc: Expected O, but got I
		//IL_08dc: Expected O, but got I4
		//IL_066c: Expected O, but got I
		//IL_07fd: Expected O, but got I4
		//IL_0e96: Expected I4, but got O
		//IL_0285: Expected O, but got I
		//IL_0291: Expected O, but got I
		//IL_0902: Expected O, but got I4
		//IL_0758: Expected O, but got I
		//IL_0760: Expected I4, but got O
		//IL_0772: Expected O, but got I4
		//IL_077a: Expected O, but got Ref
		//IL_02e0: Expected I4, but got O
		//IL_05fd: Expected O, but got I
		//IL_0605: Expected I4, but got O
		//IL_0617: Expected O, but got I4
		//IL_061f: Expected O, but got Ref
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Expected O, but got Unknown
		//IL_093e: Expected O, but got I
		//IL_0975: Expected O, but got I4
		//IL_0bdf: Expected O, but got Ref
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Expected O, but got Unknown
		//IL_09a1: Expected O, but got I
		//IL_09cb: Expected O, but got I4
		//IL_06d5: Expected O, but got I4
		//IL_06de: Expected O, but got Ref
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e7: Expected O, but got Unknown
		//IL_09f7: Expected O, but got I
		//IL_0a21: Expected O, but got I4
		//IL_072a: Expected O, but got Ref
		//IL_0a69: Expected O, but got I
		//IL_03bc: Expected O, but got Ref
		//IL_0eca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecf: Expected O, but got Unknown
		//IL_0eea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eef: Expected O, but got Unknown
		//IL_0f21: Expected O, but got I4
		//IL_0a9e: Expected O, but got I
		//IL_0406: Expected O, but got Ref
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected O, but got Unknown
		//IL_0ac1: Expected O, but got I
		//IL_0aeb: Expected O, but got I4
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0467: Expected O, but got I
		//IL_0490: Expected O, but got Ref
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b07: Expected O, but got Unknown
		//IL_0b17: Expected O, but got I
		//IL_0b41: Expected O, but got I4
		//IL_04f6: Expected O, but got I
		//IL_0524: Expected O, but got Ref
		//IL_0b6c: Expected O, but got I
		//IL_0b99: Expected O, but got I4
		//IL_057d: Expected O, but got I4
		//IL_02a6: Expected O, but got I
		//IL_02b6: Expected O, but got I
		//IL_02c6: Expected O, but got I
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E893A]");
		object obj = 0;
		object obj2 = typeof(CardUtils.<>c) + 1232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		bool flag = obj3 == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		ClanViewModel clanViewModel = viewModel;
		if (flag)
		{
			goto IL_0c01;
		}
		obj2 = obj3 + 16;
		obj2 = viewModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2;
		object obj11 = default(object);
		object obj8 = default(object);
		ClanViewModel clanViewModel3;
		object obj12;
		object obj13;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v40+68]");
			bool flag2 = (nint)0 == 0;
			ClanViewModel clanViewModel2 = viewModel;
			if (!flag2)
			{
				object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 696;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj6 = (nint)0 + (nint)440;
				Func<object, object> func = default(Func<object, object>);
				func..ctor(obj3, (IntPtr)obj6);
				object obj7 = (nint)0 + (nint)3096;
				obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v40+68]");
				IEnumerable<object> source = Enumerable.Select((IEnumerable<object>)0, func);
				object obj9 = (nint)0 + (nint)2000;
				clanViewModel2 = (ClanViewModel)obj9;
				List<object> list = Enumerable.ToList(source);
				bool flag3 = list == null;
				object obj10 = !flag3;
				obj11 = 0;
				obj12 = 0;
				obj13 = obj7;
				clanViewModel3 = (ClanViewModel)obj9;
				clanViewModel = (ClanViewModel)(object)list;
				if (obj10 != null)
				{
					goto IL_01d8;
				}
			}
			object obj14 = typeof(List<AdaptivePerformanceScaler>) + 560;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)3448;
			clanViewModel3 = (ClanViewModel)obj15;
			List<object> list2 = default(List<object>);
			list2..ctor();
			obj12 = obj11;
			obj13 = obj8;
			clanViewModel = (ClanViewModel)(object)list2;
			goto IL_01d8;
		}
		ClanModel result = null;
		goto IL_0e89;
		IL_0e7b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0d4a;
		IL_0bce:
		ex = new NullReferenceException();
		List<object>.Enumerator enumerator2 = (List<object>.Enumerator)(&enumerator);
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator3 = enumerator4;
		ClanModel clanModel = null;
		obj11 = obj12;
		obj8 = obj13;
		goto IL_0d4a;
		IL_0d1c:
		ex = new NullReferenceException();
		goto IL_0d4a;
		IL_0e06:
		OutOfMemoryException ex2 = new OutOfMemoryException();
		List<object>.Enumerator enumerator5;
		enumerator3 = enumerator5;
		obj11 = obj12;
		obj8 = obj13;
		NullReferenceException ex3 = (NullReferenceException)(object)ex2;
		goto IL_0f2f;
		IL_0f2f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E440");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		ClanModel result2 = default(ClanModel);
		return result2;
		IL_01d8:
		obj = obj2;
		bool flag4 = obj2 == null;
		enumerator = (List<object>.Enumerator)0;
		obj11 = obj12;
		obj8 = obj13;
		if (flag4)
		{
			goto IL_0c01;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+88]");
		bool flag5 = (nint)0 == 0;
		enumerator = (List<object>.Enumerator)0;
		if (flag5)
		{
			goto IL_081b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+88]");
		List<object>.Enumerator enumerator6 = ((List<object>)0).GetEnumerator();
		ClanPendingMembershipViewModel clanPendingMembershipViewModel = default(ClanPendingMembershipViewModel);
		object obj30;
		int num;
		if (clanViewModel != null)
		{
			object obj16 = (nint)0 + (nint)4064;
			object obj17 = (nint)0 + (nint)3456;
			while (true)
			{
				num = (int)obj16;
				if (!enumerator.MoveNext())
				{
					break;
				}
				if (clanPendingMembershipViewModel == null)
				{
					goto IL_0bce;
				}
				if (clanPendingMembershipViewModel.Direction != ClanPendingDirection.JoinRequest)
				{
					continue;
				}
				object obj18 = obj2;
				if (obj2 == null)
				{
					goto IL_0719;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v59+10]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v59+10]");
				ClanUserModel clanUserModel = ClanUserModel.FromJoinRequest(clanPendingMembershipViewModel, 0);
				object obj19 = obj2;
				bool flag6 = obj2 == null;
				enumerator2 = (List<object>.Enumerator)(&enumerator);
				enumerator = enumerator4;
				enumerator3 = enumerator4;
				clanModel = null;
				obj11 = obj12;
				obj8 = obj13;
				if (flag6)
				{
					goto IL_0c70;
				}
				bool flag7 = clanUserModel == null;
				enumerator2 = (List<object>.Enumerator)(&enumerator);
				enumerator = enumerator4;
				enumerator3 = enumerator4;
				clanModel = null;
				obj11 = obj12;
				obj8 = obj13;
				if (flag7)
				{
					goto IL_0ca6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v60+18]");
				num = 0;
				object obj20 = clanUserModel + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v60+18]");
				obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj21 = obj2;
				bool flag8 = obj2 == null;
				enumerator2 = (List<object>.Enumerator)(&enumerator);
				enumerator = enumerator4;
				enumerator3 = enumerator4;
				clanModel = null;
				obj11 = obj12;
				obj8 = obj13;
				if (flag8)
				{
					goto IL_0d1c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v61+38]");
				clanUserModel.ClanTier = 0;
				object obj22 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X20_v14 (Kammelna.Server.Models.Clans.ClanViewModel)+1C]");
				object obj23 = (nint)0 + (nint)1;
				int id = clanViewModel.Id;
				bool flag9 = clanViewModel.Id == 0;
				enumerator2 = (List<object>.Enumerator)(&enumerator);
				enumerator = enumerator4;
				enumerator3 = enumerator4;
				clanModel = null;
				obj11 = obj12;
				obj8 = obj13;
				if (!flag9)
				{
					string name = clanViewModel.Name;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X9_v17 (System.Int32)+18]");
					bool flag10 = (nint)name < 0;
					object obj24 = !flag10;
					if (obj24 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X8_v63+20]");
						object obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X8_v65+C0]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v66+70]");
						obj13 = 0;
						((List<object>)(object)clanViewModel).AddWithResize((object)clanUserModel);
					}
					else
					{
						string name2 = clanViewModel.Name + 1;
						clanViewModel.Name = name2;
						object obj27 = clanViewModel.Id + clanViewModel.Name;
						object obj28 = obj27 + 32;
						obj28 = clanUserModel;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					continue;
				}
				goto IL_0e7b;
			}
			object obj29 = (nint)0 + (nint)4056;
			num = (int)obj29;
			enumerator.Dispose();
			obj30 = 6;
			enumerator2 = (List<object>.Enumerator)(&enumerator);
			enumerator3 = enumerator4;
			clanModel = null;
			obj11 = obj12;
			obj8 = obj13;
			result = null;
			clanViewModel3 = (ClanViewModel)obj29;
			goto IL_07b6;
		}
		object obj31 = (nint)0 + (nint)4064;
		while (true)
		{
			num = (int)obj31;
			if (!enumerator.MoveNext())
			{
				break;
			}
			if (clanPendingMembershipViewModel != null)
			{
				if (clanPendingMembershipViewModel.Direction != ClanPendingDirection.JoinRequest)
				{
					continue;
				}
				goto IL_06b3;
			}
			goto IL_0bce;
		}
		object obj32 = (nint)0 + (nint)4056;
		num = (int)obj32;
		enumerator.Dispose();
		obj30 = 6;
		enumerator2 = (List<object>.Enumerator)(&enumerator);
		enumerator3 = enumerator4;
		clanModel = null;
		obj11 = obj12;
		obj8 = obj13;
		result = null;
		clanViewModel3 = (ClanViewModel)obj32;
		enumerator5 = enumerator4;
		clanModel = null;
		goto IL_0e06;
		IL_0719:
		ex = new NullReferenceException();
		enumerator2 = (List<object>.Enumerator)(&enumerator);
		enumerator3 = enumerator4;
		clanModel = null;
		obj11 = obj12;
		obj8 = obj13;
		goto IL_0d4a;
		IL_0e89:
		return result;
		IL_0c70:
		ex = new NullReferenceException();
		goto IL_0d4a;
		IL_0d4a:
		bool flag11 = num != 1;
		ex3 = ex;
		if (!flag11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj33 = default(object);
			result = (ClanModel)obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj34 = (nint)0 + (nint)4056;
			num = (int)obj34;
			((List<object>.Enumerator*)enumerator2)->Dispose();
			bool flag12 = obj33 == null;
			obj30 = 0;
			clanModel = (ClanModel)obj33;
			clanViewModel3 = (ClanViewModel)obj34;
			enumerator5 = enumerator3;
			clanModel = (ClanModel)obj33;
			obj12 = obj11;
			obj13 = obj8;
			if (flag12)
			{
				goto IL_07b6;
			}
			goto IL_0e06;
		}
		goto IL_0f2f;
		IL_0c17:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+10]");
		num = 0;
		ClanPendingMembershipViewModel clanPendingMembershipViewModel2;
		ClanPendingMembershipViewModel pending = clanPendingMembershipViewModel2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+10]");
		ClanUserModel clanUserModel2 = ClanUserModel.FromJoinRequest(pending, 0);
		object obj35 = obj2;
		bool flag13 = obj2 == null;
		object obj36 = !flag13;
		if (obj36 == null)
		{
			goto IL_0c70;
		}
		bool flag14 = clanUserModel2 == null;
		object obj37 = !flag14;
		if (obj37 == null)
		{
			goto IL_0ca6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v14+18]");
		num = 0;
		object obj38 = clanUserModel2 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v14+18]");
		obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj39 = obj2;
		bool flag15 = obj2 == null;
		object obj40 = !flag15;
		if (obj40 == null)
		{
			goto IL_0d1c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v15+38]");
		clanUserModel2.ClanTier = 0;
		goto IL_0e7b;
		IL_081b:
		object obj41 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj42 = (nint)0 + (nint)448;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj3, (IntPtr)obj42);
		object obj43 = (nint)0 + (nint)720;
		obj8 = obj43;
		object obj44 = Enumerable.FirstOrDefault((IEnumerable<object>)clanViewModel, func2);
		object obj45 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj46 = default(object);
		obj46..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+10]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+10]");
		bool flag16 = (nint)0 == 0;
		obj11 = 0;
		if (!flag16)
		{
			bool flag17 = obj46 == null;
			obj11 = 0;
			if (!flag17)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+10]");
				int id = 0;
				object obj47 = obj46 + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+18]");
				obj47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj = obj2;
				bool flag18 = obj2 == null;
				obj11 = 0;
				if (!flag18)
				{
					object obj48 = obj46 + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+20]");
					obj48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj = obj2;
					bool flag19 = obj2 == null;
					obj11 = 0;
					if (!flag19)
					{
						object obj49 = obj46 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+28]");
						obj49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj = obj2;
						bool flag20 = obj2 == null;
						obj11 = 0;
						if (!flag20)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+44]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+48]");
							id = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+48]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+68]");
							object obj50 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+68]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X8_v32+18]");
								obj50 = 0;
							}
							object obj51 = obj46 + 88;
							obj51 = obj44;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj52 = obj46 + 96;
							obj52 = clanViewModel;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj = obj2;
							bool flag21 = obj2 == null;
							obj11 = 0;
							if (!flag21)
							{
								object obj53 = obj46 + 104;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+90]");
								obj53 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								obj = obj2;
								bool flag22 = obj2 == null;
								obj11 = 0;
								if (!flag22)
								{
									object obj54 = obj46 + 112;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+60]");
									obj54 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									obj = obj2;
									bool flag23 = obj2 == null;
									obj11 = 0;
									if (!flag23)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+81]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+70]");
										enumerator3 = (List<object>.Enumerator)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+70]");
										_ = 0;
										obj = obj2;
										bool flag24 = obj2 == null;
										obj11 = 0;
										if (!flag24)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+38]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+40]");
											_ = 0;
											result = (ClanModel)obj46;
											goto IL_0e89;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0c01;
		IL_0c01:
		NullReferenceException ex4 = new NullReferenceException();
		clanPendingMembershipViewModel2 = (ClanPendingMembershipViewModel)(object)ex4;
		goto IL_0c17;
		IL_06b3:
		obj = obj2;
		bool flag25 = obj2 == null;
		object obj55 = !flag25;
		enumerator2 = (List<object>.Enumerator)(&enumerator);
		enumerator = enumerator4;
		enumerator3 = enumerator4;
		clanModel = null;
		obj11 = obj12;
		obj8 = obj13;
		clanPendingMembershipViewModel2 = clanPendingMembershipViewModel;
		if (obj55 == null)
		{
			goto IL_0719;
		}
		goto IL_0c17;
		IL_07b6:
		bool flag26 = (nint)obj30 == 6;
		obj12 = obj11;
		obj13 = obj8;
		if (!flag26)
		{
			bool flag27 = obj30 == null;
			object obj56 = !flag27;
			obj12 = obj11;
			obj13 = obj8;
			if (obj56 != null)
			{
				goto IL_0e89;
			}
		}
		goto IL_081b;
		IL_0ca6:
		ex = new NullReferenceException();
		goto IL_0d4a;
	}

	public static implicit operator ClanModel(ClanBadgeModel badge)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		if (badge != null)
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = typeof(List<AdaptivePerformanceScaler>) + 560;
				_ = badge.ClanId;
				object obj4 = obj2 + 24;
				obj4 = badge.Name;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = badge.Tier;
				_ = badge.Tier;
				object obj5 = obj2 + 112;
				obj5 = badge.Emblem;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<object> list = default(List<object>);
				list..ctor();
				object obj6 = obj2 + 96;
				obj6 = list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return (ClanModel)obj2;
			}
			return (ClanModel)(object)new NullReferenceException();
		}
		return null;
	}

	public static implicit operator ClanModel(ClanCardModel cardModel)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		if (cardModel != null)
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = typeof(List<AdaptivePerformanceScaler>) + 560;
				_ = cardModel.ClanId;
				object obj4 = obj2 + 24;
				obj4 = cardModel.Name;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = cardModel.Tier;
				object obj5 = obj2 + 112;
				obj5 = cardModel.Emblem;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = cardModel.ActiveEmblemTier;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				_ = cardModel.MembersCount;
				_ = cardModel.MonthlyPoints;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<object> list = default(List<object>);
				list..ctor();
				object obj6 = obj2 + 96;
				obj6 = list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return (ClanModel)obj2;
			}
			return (ClanModel)(object)new NullReferenceException();
		}
		return null;
	}
}
