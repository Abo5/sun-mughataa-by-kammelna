using System;
using System.Collections;
using System.Collections.Generic;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine.InputSystem.UI;

namespace Server.Models;

[Serializable]
public class WonTournamentFeedData : UserFeedData
{
	private sealed class <GetRewards>d__31 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private string <>2__current;

		private int <>l__initialThreadId;

		public WonTournamentFeedData <>4__this;

		string IEnumerator<string>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <GetRewards>d__31(int <>1__state)
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
			//IL_049e: Expected O, but got I4
			//IL_04b8: Expected O, but got I4
			//IL_013d: Expected I4, but got I8
			//IL_0014: Expected I4, but got I8
			//IL_048e: Expected I4, but got O
			//IL_005f: Expected O, but got I4
			//IL_0312: Unknown result type (might be due to invalid IL or missing references)
			//IL_0317: Expected O, but got Unknown
			//IL_0341: Expected O, but got I4
			//IL_0085: Expected I4, but got I8
			//IL_0502: Unknown result type (might be due to invalid IL or missing references)
			//IL_0507: Expected O, but got Unknown
			//IL_0519: Expected I8, but got I4
			//IL_053c: Expected O, but got I4
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d6: Expected O, but got Unknown
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Expected O, but got Unknown
			//IL_02a2: Expected O, but got I4
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Expected O, but got Unknown
			//IL_02e0: Expected I8, but got I4
			//IL_02ed: Expected O, but got I4
			//IL_03a7: Expected O, but got I4
			//IL_03ac: Expected I, but got O
			//IL_03b1: Expected I, but got O
			//IL_0111: Expected O, but got I4
			//IL_0116: Expected I, but got O
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Expected O, but got Unknown
			//IL_0203: Expected O, but got I4
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Expected O, but got Unknown
			//IL_0241: Expected I8, but got I4
			//IL_024e: Expected O, but got I4
			//IL_0129: Expected I, but got O
			//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fd: Expected O, but got Unknown
			//IL_0427: Expected O, but got I4
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Expected O, but got Unknown
			//IL_046a: Expected O, but got I4
			object obj = <>1__state - 2;
			bool flag = (nint)obj < 3;
			object obj2 = !flag;
			if (obj2 == null)
			{
				<>1__state = -1;
				return false;
			}
			WonTournamentFeedData wonTournamentFeedData = <>4__this;
			bool result;
			string text2;
			int num3;
			if (<>1__state != 1)
			{
				bool flag2 = <>1__state == 0;
				object obj3 = !flag2;
				result = false;
				if (obj3 != null)
				{
					goto IL_04c6;
				}
				<>1__state = -1;
				if (<>4__this != null)
				{
					object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v28+E4]");
					nint num2;
					nint num;
					if ((nint)0 != 0)
					{
						bool flag3 = StringsExtensions.IsNullOrEmpty(wonTournamentFeedData.<TrophyId>k__BackingField);
						bool flag4 = !flag3;
						object obj6 = !flag4;
						num = unchecked((nint)null);
						if (obj6 != null)
						{
							goto IL_015c;
						}
						num2 = unchecked((nint)null);
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag5 = StringsExtensions.IsNullOrEmpty(wonTournamentFeedData.<TrophyId>k__BackingField);
						bool flag6 = !flag5;
						object obj7 = !flag6;
						num = unchecked((nint)null);
						num2 = unchecked((nint)null);
						if (obj7 != null)
						{
							goto IL_015c;
						}
					}
					bool flag7 = wonTournamentFeedData.<PrizeType>k__BackingField == TournamentPrizeType.MonthlyPrize;
					num = num2;
					if (flag7)
					{
						goto IL_015c;
					}
					object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v30+E4]");
					bool flag8 = (nint)0 == 0;
					object obj10 = !flag8;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object key = "___# Content push apply failed [{0}]: {1}" + 2624;
					string text = LocalizationText.GetText((string)key);
					object obj11 = 0;
					text2 = text;
					num3 = 1;
					goto IL_04cb;
				}
			}
			else
			{
				<>1__state = -1;
				if (<>4__this != null)
				{
					goto IL_015c;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_015c:
			if (wonTournamentFeedData.<PrizeType>k__BackingField != TournamentPrizeType.MonthlyPrize)
			{
				if (wonTournamentFeedData.<PrizeType>k__BackingField != TournamentPrizeType.TournamentPoints)
				{
					if (wonTournamentFeedData.<PrizeType>k__BackingField != TournamentPrizeType.Aces)
					{
						result = false;
						goto IL_04c6;
					}
					object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
					object obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v23+E4]");
					bool flag9 = (nint)0 == 0;
					object obj14 = !flag9;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object key2 = "AvailableVoices" + 3920;
					string text3 = LocalizationText.GetText((string)key2, wonTournamentFeedData.<Prize>k__BackingField);
					object obj11 = 0;
					text2 = text3;
					num3 = 2;
				}
				else
				{
					object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
					object obj16 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v17+E4]");
					bool flag10 = (nint)0 == 0;
					object obj17 = !flag10;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object key3 = "ThisIsFakeReceiptData" + 1456;
					string text4 = LocalizationText.GetText((string)key3, wonTournamentFeedData.<Prize>k__BackingField);
					object obj11 = 0;
					text2 = text4;
					num3 = 3;
				}
			}
			else
			{
				object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v11+E4]");
				bool flag11 = (nint)0 == 0;
				object obj20 = !flag11;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object key4 = "___# Content push apply failed [{0}]: {1}" + 2624;
				string text5 = LocalizationText.GetText((string)key4, wonTournamentFeedData.<Prize>k__BackingField);
				string text6 = text5 + wonTournamentFeedData.<TournamentName>k__BackingField;
				object obj11 = 0;
				text2 = text6;
				num3 = 4;
			}
			goto IL_04cb;
			IL_04c6:
			return result;
			IL_04cb:
			object obj21 = this + 24;
			obj21 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<>1__state = num3;
			return true;
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
			object obj2 = (nint)0 + (nint)4048;
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
			object obj3 = typeof(TrackedDeviceRaycaster.<>c) + 2856;
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

	private int <Place>k__BackingField;

	private string <TournamentName>k__BackingField;

	private TournamentPrizeType <PrizeType>k__BackingField;

	private int <Prize>k__BackingField;

	private string <TrophyId>k__BackingField;

	private int <LevelId>k__BackingField;

	public int Place
	{
		get
		{
			return <Place>k__BackingField;
		}
		set
		{
			<Place>k__BackingField = value;
		}
	}

	public string TournamentName
	{
		get
		{
			return <TournamentName>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public TournamentPrizeType PrizeType
	{
		get
		{
			return <PrizeType>k__BackingField;
		}
		set
		{
			<PrizeType>k__BackingField = value;
		}
	}

	public int Prize
	{
		get
		{
			return <Prize>k__BackingField;
		}
		set
		{
			<Prize>k__BackingField = value;
		}
	}

	public string TrophyId
	{
		get
		{
			return <TrophyId>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int LevelId
	{
		get
		{
			return <LevelId>k__BackingField;
		}
		set
		{
			<LevelId>k__BackingField = value;
		}
	}

	public override bool HasPreview => false;

	public override bool ForcedPreview => false;

	public override LocalizableText GetTitle()
	{
		return TextMeshProExtensions.FixOnly(<TournamentName>k__BackingField);
	}

	public override LocalizableText GetDetails()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_030a: Expected O, but got I
		//IL_0334: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0040: Expected O, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_0128: Expected O, but got I4
		//IL_013e: Expected I, but got O
		//IL_014e: Expected O, but got I
		//IL_0177: Expected O, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_024c: Expected O, but got I8
		//IL_01f1: Expected I, but got O
		//IL_0201: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
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
		object key2 = "Network Authentication Required" + 3288;
		object obj7 = typeof(TypeConverter<ushort, char>) + 3400;
		string text = LocalizationText.GetText((string)key);
		string text2 = (string)obj2 + text;
		object obj8 = typeof(TrackedDeviceRaycaster.<>c) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = default(object);
		obj9..ctor();
		_ = 4294967294L;
		int currentManagedThreadId = Environment.CurrentManagedThreadId;
		object obj10 = obj9 + 40;
		obj10 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C97D90");
		string ordinalText = LocalizationText.GetOrdinalText((string)key2, <Place>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		if (array != null)
		{
			bool flag2 = ordinalText == null;
			string text3 = (string)2;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			string text4;
			if (!flag2)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
				text3 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
				text4 = (string)0;
				if (flag3)
				{
					goto IL_02c9;
				}
			}
			if (array.Length != 0)
			{
				object obj11 = array + 32;
				obj11 = ordinalText;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj12 = default(object);
				bool flag4 = obj12 == null;
				text3 = ordinalText;
				if (!flag4)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
					text3 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag5 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
					text4 = (string)0;
					if (flag5)
					{
						goto IL_02c9;
					}
				}
				object obj13 = array.Length & 0xFFFFFFFEL;
				if (obj13 != null)
				{
					object text5 = "tournament_participate_warning_body_with_tickets_warning_daily" + 80;
					object obj14 = array + 40;
					obj14 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return TextMeshProExtensions.LocalizeWith((string)text5, array);
				}
			}
			ex = new IndexOutOfRangeException();
			text4 = text3;
			goto IL_02c9;
		}
		goto IL_02e1;
		IL_02e1:
		return (LocalizableText)(object)new NullReferenceException();
		IL_02c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_02e1;
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
		object obj2 = (nint)0 + (nint)1760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	private IEnumerable<string> GetRewards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 2856;
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
