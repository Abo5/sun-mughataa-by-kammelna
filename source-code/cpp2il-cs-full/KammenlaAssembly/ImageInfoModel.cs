using System;
using Cpp2ILInjected;

[Serializable]
public class ImageInfoModel<T> : FileInfoModel
{
	private T <type>k__BackingField;

	public T type
	{
		get
		{
			//IL_000d: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ImageInfoModel`1<T>)+20]");
			return (T)0;
		}
		set
		{
		}
	}
}
