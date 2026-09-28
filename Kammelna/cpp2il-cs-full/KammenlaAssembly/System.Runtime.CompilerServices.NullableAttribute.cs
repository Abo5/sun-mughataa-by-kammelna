using Cpp2ILInjected;
using Unity.Properties;

namespace System.Runtime.CompilerServices;

internal sealed class NullableAttribute : Attribute
{
	public readonly byte[] NullableFlags;

	public NullableAttribute(byte P_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 1880;
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = default(object);
		if (obj2 != null)
		{
			object obj3 = this + 16;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	public NullableAttribute(byte[] P_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = P_0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
