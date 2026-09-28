using System.Formats.Asn1;
using Cpp2ILInjected;

public class SoundOptions
{
	public enum Mode
	{
		Instant,
		Queued
	}

	public enum Channel
	{
		Master,
		Gameplay,
		Notifications,
		SFX
	}

	public Channel channel;

	public Mode mode;

	public static readonly SoundOptions Default;

	public static readonly SoundOptions SFX;

	public SoundOptions(Channel channel, Mode mode)
	{
		this.channel = channel;
		this.mode = mode;
	}

	static SoundOptions()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005c: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DC7A8]");
		_ = 0;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+B8]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
