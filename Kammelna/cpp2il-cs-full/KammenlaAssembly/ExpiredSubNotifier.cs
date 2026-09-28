using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Rendering;

public class ExpiredSubNotifier : MonoBehaviour
{
	private record ExpiredSubNotifierData(DateTime DateTime, int ShownCount)
	{
		protected virtual Type EqualityContract
		{
			get
			{
				//IL_0009: Expected O, but got I4
				//IL_0018: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Expected O, but got Unknown
				//IL_0033: Expected O, but got I
				//IL_00d3: Expected O, but got I4
				//IL_00e3: Expected O, but got I
				//IL_0105: Expected O, but got I4
				//IL_0067: Expected O, but got I4
				//IL_0077: Expected O, but got I
				object obj = 152989696;
				object obj2 = typeof(SqlDouble) + 2352;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77C6]");
				object obj3 = (nint)0 & (nint)1;
				RuntimeTypeHandle handle;
				RuntimeTypeHandle handle2;
				if (obj3 != null)
				{
					handle = (RuntimeTypeHandle)obj2;
					object obj4 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v9+E0]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v1+E4]");
					bool flag = (nint)0 == 0;
					handle2 = (RuntimeTypeHandle)obj2;
					if (!flag)
					{
						goto IL_00a4;
					}
				}
				else
				{
					_ = 1;
					handle = (RuntimeTypeHandle)obj2;
					object obj6 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+E0]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v1+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					handle2 = (RuntimeTypeHandle)obj2;
					if (obj7 != null)
					{
						goto IL_00a4;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return Type.GetTypeFromHandle(handle2);
				IL_00a4:
				return Type.GetTypeFromHandle(handle);
			}
		}

		public override string ToString()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_00b6: Expected I, but got O
			//IL_00c6: Expected O, but got I
			//IL_00d6: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			StringBuilder stringBuilder = default(StringBuilder);
			stringBuilder..ctor();
			if (stringBuilder != null)
			{
				object value = "Error reading data from socket: " + 1832;
				object value2 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2336;
				StringBuilder stringBuilder2 = stringBuilder.Append((string)value);
				StringBuilder stringBuilder3 = stringBuilder.Append((string)value2);
				if (PrintMembers(stringBuilder))
				{
					StringBuilder stringBuilder4 = stringBuilder.Append(' ');
				}
				StringBuilder stringBuilder5 = stringBuilder.Append('}');
				nint num = (nint)stringBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6 (Il2CppClass<System.Text.StringBuilder>)+168]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6 (Il2CppClass<System.Text.StringBuilder>)+170]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X2_v6 (should have been resolved before IL gen)");
			}
			return (string)(object)new NullReferenceException();
		}

		protected virtual bool PrintMembers(StringBuilder builder)
		{
			//IL_00fc: Expected I4, but got O
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0073: Expected O, but got I4
			RuntimeHelpers.EnsureSufficientExecutionStack();
			if (builder != null)
			{
				object value = "DNQUALIFIER" + 1352;
				object obj = typeof(DataRelation) + 712;
				object value2 = "&action=sign-up" + 3736;
				StringBuilder stringBuilder = builder.Append((string)value);
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime dateTime = default(DateTime);
				string value3 = dateTime.ToString();
				StringBuilder stringBuilder2 = builder.Append(value3);
				StringBuilder stringBuilder3 = builder.Append((string)value2);
				int num = default(int);
				string value4 = num.ToString();
				StringBuilder stringBuilder4 = builder.Append(value4);
				return true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		public override int GetHashCode()
		{
			//IL_000c: Expected O, but got I
			//IL_00fe: Expected I4, but got O
			//IL_001d: Expected O, but got I
			//IL_0062: Expected O, but got I
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected O, but got Unknown
			//IL_00eb: Expected I4, but got O
			object obj = (nint)0 + (nint)168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
			Type equalityContract = EqualityContract;
			object obj2 = default(object);
			if (obj2 != null)
			{
				object obj3 = (nint)0 + (nint)40;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ X8_v5+1C8] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C0E3DC");
				object obj5 = default(object);
				if (obj5 != null)
				{
					object obj6 = (nint)0 + (nint)96;
					object obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ X8_v6+1C8] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C102CC");
					object obj8 = default(object);
					if (obj8 != null)
					{
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v116 @ X8_v7+1C8] (should have been resolved before IL gen)");
						object obj11 = default(object);
						object obj10 = obj11 * 2773833001L;
						object obj13 = default(object);
						object obj12 = obj13 + obj10;
						object obj14 = obj12 * 2773833001L;
						object obj15 = default(object);
						return (int)(obj15 + obj14);
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		public virtual bool Equals(ExpiredSubNotifierData other)
		{
			//IL_0034: Expected I, but got O
			//IL_0050: Expected O, but got I4
			//IL_0060: Expected O, but got I
			//IL_0110: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_0132: Expected O, but got I
			//IL_020e: Expected I4, but got O
			//IL_0190: Expected O, but got I
			//IL_01e6: Expected O, but got I
			//IL_01f6: Expected O, but got I
			bool flag;
			if ((object)this != other)
			{
				if ((object)other != null)
				{
					Type equalityContract = EqualityContract;
					nint num = (nint)other;
					Type equalityContract2 = other.EqualityContract;
					object obj = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+E0]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v8+E4]");
					if ((nint)0 != 0)
					{
						flag = equalityContract == equalityContract2;
						bool flag2 = !flag;
						object obj3 = !flag2;
						object obj4 = 0;
						Type type = equalityContract2;
						if (obj3 == null)
						{
							goto IL_00cb;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						flag = equalityContract == equalityContract2;
						bool flag3 = !flag;
						object obj4 = 0;
						Type type = equalityContract2;
						if (flag3)
						{
							goto IL_00cb;
						}
					}
					object obj5 = (nint)0 + (nint)40;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C0E3DC");
					object obj6 = default(object);
					if (obj6 != null)
					{
						object obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ X8_v11+1B8] (should have been resolved before IL gen)");
						if (!flag)
						{
							goto IL_00cb;
						}
						object obj8 = (nint)0 + (nint)96;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C102CC");
						object obj9 = default(object);
						if (obj9 != null)
						{
							int num2 = other.ShownCount;
							int num3 = ShownCount;
							object obj10 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v14+1B8]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v14+1C0]");
							object obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v88 @ X4_v1 (should have been resolved before IL gen)");
						}
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				return false;
			}
			return true;
			IL_00cb:
			return flag;
		}

		public unsafe void Deconstruct(out DateTime DateTime, out int ShownCount)
		{
			ref DateTime reference = ref *(DateTime*)DateTime;
			ref int reference2 = ref *(int*)ShownCount;
		}
	}

	private static ExpiredSubNotifierData NotifierData
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0064: Expected O, but got I
			//IL_008e: Expected O, but got I4
			//IL_00ac: Expected O, but got I
			object obj = typeof(DataRelation) + 712;
			object obj2 = typeof(DebugUI.BitField) + 1944;
			object obj3 = "Error reading data from socket: " + 1832;
			object obj4 = (nint)0 + (nint)2464;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+10]");
			_ = 0;
			_ = 0;
			object obj8 = default(object);
			obj8..ctor();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81144");
			ExpiredSubNotifierData result = default(ExpiredSubNotifierData);
			return result;
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001b: Expected O, but got I
			object obj = "Error reading data from socket: " + 1832;
			object obj2 = (nint)0 + (nint)2512;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81418");
		}
	}

	private void Start()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0065: Expected O, but got I4
		//IL_008e: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_0338: Expected O, but got I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_039b: Expected O, but got I4
		//IL_02a5: Expected O, but got I
		//IL_02b5: Expected O, but got I
		//IL_02cf: Expected O, but got I
		//IL_02ee: Expected O, but got I4
		//IL_02f7: Expected O, but got I4
		//IL_0300: Expected O, but got I4
		//IL_0144: Expected O, but got I
		//IL_0154: Expected O, but got I
		//IL_016e: Expected O, but got I
		//IL_0186: Expected O, but got I4
		//IL_018f: Expected O, but got I4
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_0553: Expected O, but got I
		//IL_0563: Expected O, but got I
		//IL_057d: Expected O, but got I
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_03f5: Expected O, but got I4
		//IL_01b3: Expected I, but got O
		//IL_01ea: Expected O, but got I4
		//IL_059a: Expected O, but got I4
		//IL_04d5: Expected O, but got I
		//IL_04e5: Expected O, but got I
		//IL_04ff: Expected O, but got I
		//IL_0519: Expected O, but got I4
		//IL_0522: Expected O, but got I4
		//IL_09cf: Expected O, but got I
		//IL_09df: Expected O, but got I
		//IL_09f9: Expected O, but got I
		//IL_0a11: Expected O, but got I4
		//IL_0238: Expected O, but got I
		//IL_0252: Expected O, but got I4
		//IL_05e1: Expected O, but got I4
		//IL_0444: Expected O, but got I4
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected O, but got Unknown
		//IL_0994: Expected I4, but got O
		//IL_09a0: Expected O, but got I
		//IL_0a37: Expected O, but got I
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4b: Expected O, but got Unknown
		//IL_0a87: Expected O, but got I
		//IL_0646: Expected O, but got I4
		//IL_06d2: Expected O, but got I4
		//IL_0737: Expected O, but got I4
		//IL_07c3: Expected O, but got I4
		//IL_0ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abb: Expected O, but got Unknown
		//IL_0ac7: Expected O, but got I
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Expected O, but got Unknown
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Expected O, but got Unknown
		//IL_092d: Expected O, but got I4
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected O, but got Unknown
		ExpiredSubNotifierData notifierData = NotifierData;
		if (notifierData.ShownCount > 2)
		{
			return;
		}
		object obj = typeof(Queue<string>) + 848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		SubscriptionStatus subscriptionStatus = SFSKammelnaUserExtensions.GetSubscriptionStatus(localUser);
		bool flag2 = subscriptionStatus != SubscriptionStatus.Expired;
		DateTime dateTime = (DateTime)0;
		object obj5;
		object obj9;
		if (!flag2)
		{
			ExpiredSubNotifierData notifierData2 = NotifierData;
			obj5 = typeof(DataRelation) + 712;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v108+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v108+B8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v69+10]");
				dateTime = (DateTime)0;
				DateTime <DateTime>k__BackingField = notifierData2.DateTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v69+10]");
				bool flag3 = <DateTime>k__BackingField == (DateTime)0;
				bool flag4 = !flag3;
				object obj8 = 0;
				obj9 = 0;
				if (!flag4)
				{
					goto IL_019d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v110+B8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v63+10]");
				dateTime = (DateTime)0;
				DateTime <DateTime>k__BackingField2 = notifierData2.DateTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v63+10]");
				bool flag3 = <DateTime>k__BackingField2 == (DateTime)0;
				bool flag5 = !flag3;
				object obj12 = !flag5;
				object obj8 = 0;
				obj9 = 0;
				if (obj12 != null)
				{
					goto IL_019d;
				}
			}
		}
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v80+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		SubscriptionStatus subscriptionStatus2 = SFSKammelnaUserExtensions.GetSubscriptionStatus(localUser2);
		bool flag7 = subscriptionStatus2 == SubscriptionStatus.Expired;
		DateTime dateTime2 = (DateTime)0;
		ExpiredSubNotifierData expiredSubNotifierData;
		DateTime dateTime3;
		if (!flag7)
		{
			ExpiredSubNotifierData notifierData3 = NotifierData;
			object obj15 = typeof(DataRelation) + 712;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v51+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v51+B8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v52+10]");
			dateTime2 = (DateTime)0;
			DateTime <DateTime>k__BackingField3 = notifierData3.DateTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v52+10]");
			bool flag9 = <DateTime>k__BackingField3 != (DateTime)0;
			bool flag10 = !flag9;
			obj9 = 0;
			subscriptionStatus2 = (flag9 ? SubscriptionStatus.Expired : SubscriptionStatus.None);
			if (!flag10)
			{
				object obj19 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v91+E4]");
				bool flag11 = (nint)0 == 0;
				object obj20 = !flag11;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj19 = obj15;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v91+B8]");
				object obj21 = 0;
				object obj22 = typeof(DebugUI.BitField) + 1944;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v54+10]");
				_ = 0;
				_ = 0;
				object obj23 = default(object);
				obj23..ctor();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7885]");
				object obj24 = (nint)0 & (nint)1;
				bool flag12 = obj24 == null;
				expiredSubNotifierData = (ExpiredSubNotifierData)obj23;
				if (flag12)
				{
					goto IL_0270;
				}
				dateTime3 = (DateTime)obj23;
				goto IL_097d;
			}
		}
		goto IL_0476;
		IL_0270:
		_ = 1;
		dateTime3 = (DateTime)expiredSubNotifierData;
		goto IL_097d;
		IL_086e:
		ExpiredSubNotifierData notifierData4 = NotifierData;
		ExpiredSubNotifierData expiredSubNotifierData2 = notifierData4.<Clone>$();
		ExpiredSubNotifierData notifierData5 = NotifierData;
		int <ShownCount>k__BackingField = notifierData5.ShownCount + 1;
		expiredSubNotifierData2.ShownCount = <ShownCount>k__BackingField;
		object obj25 = "Error reading data from socket: " + 1832;
		object obj26 = (nint)0 + (nint)2512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81418");
		ExpiredSubNotifierData notifierData6 = NotifierData;
		int num = default(int);
		string text = num.ToString();
		object obj27 = "Error reading data from socket: " + 1824;
		string context = (string)obj27 + text;
		object obj28 = typeof(MemberAchievementClanFeedData) + 3448;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X0_v38+E4]");
		bool flag13 = (nint)0 == 0;
		object obj30 = !flag13;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object text2 = "WhiteSmoke" + 2280;
		OnlyForSubscribersPopup.Show(TrackingFeature.ExpiredSubReminder, null, (string)text2, null, null, context);
		return;
		IL_097d:
		object obj31 = "Error reading data from socket: " + 1832;
		subscriptionStatus2 = (SubscriptionStatus)obj31;
		object obj32 = (nint)0 + (nint)2512;
		obj9 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81418");
		dateTime2 = dateTime3;
		goto IL_0476;
		IL_019d:
		ExpiredSubNotifierData notifierData7 = NotifierData;
		nint num2 = (nint)notifierData7;
		ExpiredSubNotifierData expiredSubNotifierData3 = notifierData7.<Clone>$();
		object obj33 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v116+E4]");
		bool flag14 = (nint)0 == 0;
		object obj34 = !flag14;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		expiredSubNotifierData3.DateTime = now;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7885]");
		object obj35 = (nint)0 & (nint)1;
		bool flag15 = obj35 == null;
		object obj36 = !flag15;
		expiredSubNotifierData = expiredSubNotifierData3;
		dateTime3 = (DateTime)expiredSubNotifierData3;
		if (obj36 == null)
		{
			goto IL_0270;
		}
		goto IL_097d;
		IL_0476:
		ExpiredSubNotifierData notifierData8 = NotifierData;
		object obj37 = typeof(DataRelation) + 712;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v13+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v13+B8]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v47+10]");
			DateTime dateTime4 = (DateTime)0;
			DateTime <DateTime>k__BackingField4 = notifierData8.DateTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v47+10]");
			bool flag16 = <DateTime>k__BackingField4 != (DateTime)0;
			bool flag17 = !flag16;
			object obj40 = !flag17;
			object obj41 = 0;
			if (obj40 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj42 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v45+B8]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v46+10]");
			DateTime dateTime4 = (DateTime)0;
			DateTime <DateTime>k__BackingField5 = notifierData8.DateTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v46+10]");
			bool flag16 = <DateTime>k__BackingField5 != (DateTime)0;
			bool flag18 = !flag16;
			object obj41 = 0;
			if (flag18)
			{
				return;
			}
		}
		ExpiredSubNotifierData notifierData9 = NotifierData;
		object obj44 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v19+E4]");
		bool flag19 = (nint)0 == 0;
		object obj45 = !flag19;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime6 = default(DateTime);
		DateTime dateTime5 = dateTime6.AddDays(2.0000000002328306);
		DateTime now2 = DateTime.Now;
		bool flag20 = dateTime5 < now2;
		bool flag21 = !flag20;
		ExpiredSubNotifierData expiredSubNotifierData4 = (ExpiredSubNotifierData)flag20;
		ExpiredSubNotifierData expiredSubNotifierData5;
		double num3;
		if (!flag21)
		{
			expiredSubNotifierData4 = NotifierData;
			bool flag22 = expiredSubNotifierData4.ShownCount == 0;
			num3 = 2.0000000002328306;
			expiredSubNotifierData5 = expiredSubNotifierData4;
			if (flag22)
			{
				goto IL_086e;
			}
		}
		ExpiredSubNotifierData notifierData10 = NotifierData;
		object obj46 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v50+E4]");
		bool flag23 = (nint)0 == 0;
		object obj47 = !flag23;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime7 = dateTime6.AddDays(8.000000001396984);
		DateTime now3 = DateTime.Now;
		bool flag24 = dateTime7 < now3;
		bool flag25 = !flag24;
		ExpiredSubNotifierData expiredSubNotifierData6 = (ExpiredSubNotifierData)flag24;
		if (!flag25)
		{
			expiredSubNotifierData6 = NotifierData;
			bool flag26 = expiredSubNotifierData6.ShownCount == 1;
			num3 = 8.000000001396984;
			expiredSubNotifierData5 = expiredSubNotifierData6;
			if (flag26)
			{
				goto IL_086e;
			}
		}
		ExpiredSubNotifierData notifierData11 = NotifierData;
		object obj48 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X0_v60+E4]");
		bool flag27 = (nint)0 == 0;
		object obj49 = !flag27;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime8 = dateTime6.AddDays(16.00000000325963);
		DateTime now4 = DateTime.Now;
		if (!(dateTime8 < now4))
		{
			return;
		}
		expiredSubNotifierData5 = NotifierData;
		bool flag28 = expiredSubNotifierData5.ShownCount != 2;
		num3 = 16.00000000325963;
		if (flag28)
		{
			return;
		}
		goto IL_086e;
	}
}
