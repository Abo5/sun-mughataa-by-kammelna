using System;
using Cpp2ILInjected;

public class AssetLoadingModel<T> where T : class
{
	private string <AssetId>k__BackingField;

	private string <RemoteUrl>k__BackingField;

	private string <LocalPath>k__BackingField;

	private DateTime? <TimeStamp>k__BackingField;

	private bool <StoreLocally>k__BackingField;

	private bool <LocalOnly>k__BackingField;

	private byte[] <BinaryData>k__BackingField;

	private T <Asset>k__BackingField;

	public string AssetId
	{
		get
		{
			return <AssetId>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string RemoteUrl
	{
		get
		{
			return <RemoteUrl>k__BackingField;
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

	public string LocalPath
	{
		get
		{
			return <LocalPath>k__BackingField;
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

	public DateTime? TimeStamp
	{
		get
		{
			//IL_000d: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AssetLoadingModel`1<T>)+28]");
			return (DateTime?)(object)0;
		}
		set
		{
		}
	}

	public bool StoreLocally
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AssetLoadingModel`1<T>)+38]");
			return false;
		}
		set
		{
		}
	}

	public bool LocalOnly
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AssetLoadingModel`1<T>)+39]");
			return false;
		}
		set
		{
		}
	}

	public byte[] BinaryData
	{
		get
		{
			//IL_000d: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AssetLoadingModel`1<T>)+40]");
			return (byte[])0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public T Asset
	{
		get
		{
			//IL_000d: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AssetLoadingModel`1<T>)+48]");
			return (T)0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool IsLoaded
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AssetLoadingModel`1<T>)+48]");
			bool flag = (nint)0 == 0;
			return !flag;
		}
	}
}
