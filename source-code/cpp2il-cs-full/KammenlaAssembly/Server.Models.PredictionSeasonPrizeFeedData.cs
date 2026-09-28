using System;
using System.Collections;
using System.Collections.Generic;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;

namespace Server.Models;

[Serializable]
public class PredictionSeasonPrizeFeedData : UserFeedData
{
	private sealed class <GetRewards>d__23 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private string <>2__current;

		private int <>l__initialThreadId;

		public PredictionSeasonPrizeFeedData <>4__this;

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
			//IL_0214: Expected I4, but got I8
			//IL_015f: Expected I4, but got I8
			//IL_0311: Expected I4, but got O
			//IL_004a: Expected O, but got I4
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Expected O, but got Unknown
			//IL_0070: Expected I4, but got I8
			//IL_0255: Expected O, but got I4
			//IL_025e: Expected O, but got I4
			//IL_01e9: Expected O, but got I4
			//IL_027b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Expected O, but got Unknown
			//IL_02aa: Expected O, but got I4
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d6: Expected O, but got Unknown
			//IL_02ed: Expected O, but got I4
			//IL_033b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0340: Expected O, but got Unknown
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_00ef: Expected O, but got I4
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected O, but got Unknown
			//IL_012d: Expected I8, but got I4
			//IL_013a: Expected O, but got I4
			PredictionSeasonPrizeFeedData predictionSeasonPrizeFeedData;
			bool result;
			string text2;
			int num;
			object obj5;
			if (<>1__state != 2)
			{
				predictionSeasonPrizeFeedData = <>4__this;
				if (<>1__state != 1)
				{
					bool flag = <>1__state == 0;
					object obj = !flag;
					result = false;
					if (obj != null)
					{
						goto IL_0330;
					}
					<>1__state = -1;
					if (<>4__this != null)
					{
						if (predictionSeasonPrizeFeedData.<CoinsReward>k__BackingField < 1)
						{
							goto IL_017e;
						}
						object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
						object obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v24+E4]");
						bool flag2 = (nint)0 == 0;
						object obj4 = !flag2;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object key = "AvailableVoices" + 3920;
						string text = LocalizationText.GetText((string)key, predictionSeasonPrizeFeedData.<CoinsReward>k__BackingField);
						obj5 = 0;
						text2 = text;
						num = 1;
						goto IL_0335;
					}
				}
				else
				{
					<>1__state = -1;
					if (<>4__this != null)
					{
						goto IL_017e;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			<>1__state = -1;
			return false;
			IL_0330:
			return result;
			IL_0335:
			object obj6 = this + 24;
			obj6 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<>1__state = num;
			return true;
			IL_01f7:
			result = false;
			goto IL_0330;
			IL_017e:
			object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				bool flag3 = StringsExtensions.IsNullOrEmpty(predictionSeasonPrizeFeedData.<TrophyId>k__BackingField);
				bool flag4 = !flag3;
				object obj9 = 0;
				if (!flag4)
				{
					goto IL_01f7;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag5 = StringsExtensions.IsNullOrEmpty(predictionSeasonPrizeFeedData.<TrophyId>k__BackingField);
				bool flag6 = !flag5;
				object obj10 = !flag6;
				object obj9 = 0;
				if (obj10 != null)
				{
					goto IL_01f7;
				}
			}
			object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v12+E4]");
			bool flag7 = (nint)0 == 0;
			object obj13 = !flag7;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key2 = "___# Content push apply failed [{0}]: {1}" + 2632;
			string text3 = LocalizationText.GetText((string)key2);
			obj5 = 0;
			text2 = text3;
			num = 2;
			goto IL_0335;
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
			object obj2 = (nint)0 + (nint)1728;
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
			object obj3 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3120;
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

	private int <CoinsReward>k__BackingField;

	private string <TrophyId>k__BackingField;

	private int <TrophyLevel>k__BackingField;

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

	public int CoinsReward
	{
		get
		{
			return <CoinsReward>k__BackingField;
		}
		set
		{
			<CoinsReward>k__BackingField = value;
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
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int TrophyLevel
	{
		get
		{
			return <TrophyLevel>k__BackingField;
		}
		set
		{
			<TrophyLevel>k__BackingField = value;
		}
	}

	public override bool HasPreview => false;

	public override bool ForcedPreview => false;

	public override LocalizableText GetTitle()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "Picking audio files is not supported on iOS" + 1280;
		return TextMeshProExtensions.Localize((string)text);
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
		object obj8 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3120;
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
					object text5 = "placementId" + 656;
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
		object obj2 = (nint)0 + (nint)1752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	private IEnumerable<string> GetRewards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3120;
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
