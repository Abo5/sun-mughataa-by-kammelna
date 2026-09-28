using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;

namespace Server.Models;

[Serializable]
public class PredictionResultFeedData : UserFeedData
{
	private sealed class <GetRewards>d__23 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private string <>2__current;

		private int <>l__initialThreadId;

		public PredictionResultFeedData <>4__this;

		string IEnumerator<string>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <GetRewards>d__23(int <>1__state)
		{
			this.<>1__state = <>1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			<>l__initialThreadId = currentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_029b: Expected I4, but got I8
			//IL_03e7: Expected I4, but got O
			//IL_0101: Expected I4, but got I8
			//IL_02c7: Expected I8, but got I4
			//IL_00ed: Expected I4, but got I8
			//IL_012d: Expected I8, but got I4
			//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fd: Expected O, but got Unknown
			//IL_030f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0314: Expected O, but got Unknown
			//IL_0336: Expected O, but got I4
			//IL_0354: Expected I8, but got I4
			//IL_01e3: Expected I8, but got I4
			//IL_005e: Expected I4, but got I8
			//IL_007a: Expected O, but got I4
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ae: Expected O, but got Unknown
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected O, but got Unknown
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Expected O, but got Unknown
			//IL_019c: Expected O, but got I4
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Expected O, but got Unknown
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Expected O, but got Unknown
			//IL_0252: Expected O, but got I4
			//IL_01c8: Expected I8, but got I4
			//IL_027e: Expected I8, but got I4
			PredictionResultFeedData predictionResultFeedData = <>4__this;
			bool result;
			long n;
			object obj4;
			int num;
			object obj6;
			long num2;
			int num3;
			object obj3;
			if (<>1__state <= 1)
			{
				if (<>1__state != 0)
				{
					bool flag = <>1__state != 1;
					result = false;
					if (flag)
					{
						goto IL_0410;
					}
					<>1__state = -1;
					bool flag2 = <>4__this == null;
					object obj = !flag2;
					if (obj != null)
					{
						goto IL_01d6;
					}
				}
				else
				{
					<>1__state = -1;
					if (<>4__this != null)
					{
						n = predictionResultFeedData.<Points>k__BackingField;
						if (predictionResultFeedData.<Points>k__BackingField < 1)
						{
							goto IL_01d6;
						}
						object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
						obj3 = obj2;
						obj4 = "Picking audio files is not supported on iOS" + 776;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v13+E4]");
						bool flag3 = (nint)0 == 0;
						object obj5 = !flag3;
						num = 1;
						if (obj5 == null)
						{
							obj6 = obj4;
							num2 = predictionResultFeedData.<Points>k__BackingField;
							num3 = 1;
							goto IL_036b;
						}
						goto IL_0392;
					}
				}
			}
			else
			{
				if (<>1__state != 2)
				{
					bool flag4 = <>1__state != 3;
					result = false;
					if (flag4)
					{
						goto IL_0410;
					}
					result = false;
					num = -1;
					goto IL_0415;
				}
				<>1__state = -1;
				if (<>4__this != null)
				{
					goto IL_02ba;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0410:
			return result;
			IL_0392:
			string text = LocalizationText.GetText((string)obj4, n);
			object obj7 = this + 24;
			obj7 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			result = true;
			goto IL_0415;
			IL_036b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj6;
			n = num2;
			num = num3;
			goto IL_0392;
			IL_0415:
			<>1__state = num;
			goto IL_0410;
			IL_02ba:
			num2 = predictionResultFeedData.<Coins>k__BackingField;
			if (predictionResultFeedData.<Coins>k__BackingField >= 1)
			{
				object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
				obj3 = obj8;
				obj6 = "AvailableVoices" + 3920;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v13+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				num3 = 3;
				obj4 = obj6;
				n = predictionResultFeedData.<Coins>k__BackingField;
				num = 3;
				if (obj9 == null)
				{
					goto IL_036b;
				}
				goto IL_0392;
			}
			return false;
			IL_01d6:
			n = predictionResultFeedData.<SubDays>k__BackingField;
			if (predictionResultFeedData.<SubDays>k__BackingField < 1)
			{
				goto IL_02ba;
			}
			object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
			obj3 = obj10;
			obj4 = "SERVICE_DISABLED" + 1344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			num = 2;
			if (obj11 == null)
			{
				obj6 = obj4;
				num2 = predictionResultFeedData.<SubDays>k__BackingField;
				num3 = 2;
				goto IL_036b;
			}
			goto IL_0392;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1720;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}

		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			//IL_00b8: Expected O, but got I4
			//IL_00d2: Expected O, but got I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			object obj = <>1__state + 2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (<>l__initialThreadId == currentManagedThreadId)
				{
					<>1__state = 0;
					return this;
				}
			}
			object obj3 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = default(object);
			obj4..ctor();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			object obj5 = obj4 + 40;
			obj5 = <>4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (IEnumerator<string>)obj4;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<string>)this).GetEnumerator();
		}
	}

	private PredictionRewardType <Result>k__BackingField;

	private int <Points>k__BackingField;

	private int <SubDays>k__BackingField;

	private int <Coins>k__BackingField;

	public PredictionRewardType Result
	{
		get
		{
			return <Result>k__BackingField;
		}
		set
		{
			<Result>k__BackingField = value;
		}
	}

	public int Points
	{
		get
		{
			return <Points>k__BackingField;
		}
		set
		{
			<Points>k__BackingField = value;
		}
	}

	public int SubDays
	{
		get
		{
			return <SubDays>k__BackingField;
		}
		set
		{
			<SubDays>k__BackingField = value;
		}
	}

	public int Coins
	{
		get
		{
			return <Coins>k__BackingField;
		}
		set
		{
			<Coins>k__BackingField = value;
		}
	}

	public override bool HasPreview => false;

	public override bool ForcedPreview => false;

	public override LocalizableText GetTitle()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "Picking audio files is not supported on iOS" + 1216;
		return TextMeshProExtensions.Localize((string)text);
	}

	public override LocalizableText GetDetails()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_0490: Expected O, but got I
		//IL_04ba: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0040: Expected O, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0250: Expected O, but got I4
		//IL_00fa: Expected O, but got I4
		//IL_0537: Expected O, but got I4
		//IL_0540: Expected O, but got I4
		//IL_0120: Expected O, but got I4
		//IL_0285: Expected O, but got I4
		//IL_0305: Expected O, but got I4
		//IL_0136: Expected I, but got O
		//IL_0146: Expected O, but got I
		//IL_0177: Expected O, but got I
		//IL_029b: Expected I, but got O
		//IL_02ab: Expected O, but got I
		//IL_02cd: Expected O, but got I4
		//IL_02dd: Expected O, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_03c4: Expected O, but got I8
		//IL_03dc: Expected O, but got I4
		//IL_0360: Expected I, but got O
		//IL_0370: Expected O, but got I
		//IL_0392: Expected O, but got I4
		//IL_03a2: Expected O, but got I
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object key = "alignContent" + 264;
		object obj2 = (nint)0 + (nint)3072;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2000;
		object obj6 = (nint)0 + (nint)2856;
		string text = LocalizationText.GetText((string)key);
		string text2 = (string)obj2 + text;
		object obj7 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3112;
		object obj8 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = default(object);
		obj9..ctor();
		_ = 4294967294L;
		int currentManagedThreadId = Environment.CurrentManagedThreadId;
		object obj10 = obj9 + 40;
		obj10 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C97D90");
		object obj12 = default(object);
		string text4;
		NullReferenceException ex = default(NullReferenceException);
		string text3;
		if (<Result>k__BackingField == PredictionRewardType.Participation)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag2 = array == null;
			object obj11 = obj5;
			text3 = (string)1;
			if (!flag2)
			{
				bool flag3 = obj12 == null;
				text4 = (string)1;
				if (!flag3)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
					text4 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					obj11 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
					text3 = (string)0;
					if (flag4)
					{
						goto IL_0458;
					}
				}
				bool flag5 = array.Length == 0;
				obj11 = obj5;
				if (!flag5)
				{
					object obj13 = array + 32;
					obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object text5 = "placementId" + 640;
					return TextMeshProExtensions.LocalizeWith((string)text5, array);
				}
				goto IL_0434;
			}
		}
		else
		{
			object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 1584;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text6 = LocalizationText.GetText(friendlyName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array2 = default(object[]);
			bool flag7 = array2 == null;
			object obj11 = 0;
			text3 = (string)2;
			if (!flag7)
			{
				bool flag8 = text6 == null;
				text4 = (string)2;
				if (!flag8)
				{
					nint num2 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
					text4 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag9 = ex == null;
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
					text3 = (string)0;
					if (flag9)
					{
						goto IL_0458;
					}
				}
				bool flag10 = array2.Length == 0;
				obj11 = 0;
				if (!flag10)
				{
					object obj17 = array2 + 32;
					obj17 = text6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag11 = obj12 == null;
					text4 = text6;
					if (!flag11)
					{
						nint num3 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
						text4 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag12 = ex == null;
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
						text3 = (string)0;
						if (flag12)
						{
							goto IL_0458;
						}
					}
					object obj18 = array2.Length & 0xFFFFFFFEL;
					bool flag13 = obj18 == null;
					obj11 = 0;
					if (!flag13)
					{
						object obj19 = array2 + 40;
						obj19 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object text7 = "placementId" + 648;
						return TextMeshProExtensions.LocalizeWith((string)text7, array2);
					}
				}
				goto IL_0434;
			}
		}
		goto IL_044a;
		IL_044a:
		ex = new NullReferenceException();
		goto IL_0458;
		IL_0458:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
		IL_0434:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		text3 = text4;
		goto IL_044a;
	}

	public override void ShowPreview(Action markSeen)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(System.IOAsyncCallback) + 3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InvalidOperationException ex = default(InvalidOperationException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	private IEnumerable<string> GetRewards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 4294967294L;
		int currentManagedThreadId = Environment.CurrentManagedThreadId;
		object obj3 = obj2 + 40;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerable<string>)obj2;
	}
}
