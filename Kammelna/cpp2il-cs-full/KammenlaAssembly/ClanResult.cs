using System.Runtime.CompilerServices;
using Cpp2ILInjected;

public struct ClanResult<T>
{
	private readonly T <Value>k__BackingField;

	private readonly KammelnaError <Error>k__BackingField;

	public unsafe T Value => (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);

	public KammelnaError Error
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanResult`1<T>)+8]");
			return (KammelnaError)0;
		}
	}

	public bool Succeeded
	{
		get
		{
			//IL_000c: Expected O, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0034: Expected O, but got I4
			//IL_0067: Expected O, but got I
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanResult`1<T>)+8]");
			object obj4 = -1000;
			return obj4 == null;
		}
	}

	private ClanResult(T value, KammelnaError error)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public static ClanResult<T> Ok(T value)
	{
		//IL_000c: Expected O, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0034: Expected O, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ClanResult<T> result = default(ClanResult<T>);
		return result;
	}

	public static ClanResult<T> Fail(KammelnaError error)
	{
		//IL_000c: Expected O, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0034: Expected O, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ClanResult<T> result = default(ClanResult<T>);
		return result;
	}
}
