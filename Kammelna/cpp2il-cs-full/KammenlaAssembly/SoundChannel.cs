using System;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using Cpp2ILInjected;

public class SoundChannel
{
	public static event Action<SingleSound, SoundOptions> OnPlaySoundWithMode
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1008;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 680;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			object obj8 = default(object);
			bool flag2;
			Delegate obj11 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj11 == obj5;
				obj5 = obj11;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1008;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 680;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			object obj8 = default(object);
			bool flag2;
			Delegate obj11 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj11 == obj5;
				obj5 = obj11;
			}
			while (!flag2);
		}
	}

	public static event Action OnStopSound
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1008;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1008;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static event Action<SingleSound[], SoundOptions> OnPlaySoundsWithMode
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1008;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 176;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1008;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 176;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static void PlaySound(SingleSound singleSound)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0087: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1008;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1016;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+B8]");
		object action = 0;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
		object arg = 0;
		Actions.SafeInvoke((Action<object, object>)action, singleSound, arg);
	}

	public static void StopSound()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0042: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1008;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+8]");
		Actions.SafeInvoke((Action)0);
	}

	public static void PlaySFXSound(SingleSound singleSound)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0087: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00be: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1008;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1016;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+B8]");
		object action = 0;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v6+8]");
		Actions.SafeInvoke((Action<object, object>)action, singleSound, 0);
	}

	public static void PlaySoundWithMode(SingleSound singleSound, SoundOptions playSoundChannel)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1008;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+B8]");
		object action = 0;
		Actions.SafeInvoke((Action<object, object>)action, singleSound, playSoundChannel);
	}

	public static void PlaySoundsWithMode(SingleSound[] sounds, SoundOptions playSoundChannel)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_004b: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1008;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+10]");
		Actions.SafeInvoke((Action<object, object>)0, sounds, playSoundChannel);
	}
}
