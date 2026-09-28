namespace System.Runtime.CompilerServices;

internal sealed class NullableContextAttribute : Attribute
{
	public readonly byte Flag;

	public NullableContextAttribute(byte P_0)
	{
		Flag = P_0;
	}
}
