using System;
using System.Buffers.Text;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;

public class GameSoundAlbum : SoundAlbum<GameSoundAlbumTrack>
{
	public SingleSound GetStampSound(PlayerPerformance stampLevel)
	{
		//IL_000c: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0020: Expected O, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I
		object obj = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		bool flag = stampLevel < (PlayerPerformance)5;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = 119873536 + 2760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound result = default(SingleSound);
			return result;
		}
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = "setMimeType" + 3888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj7 = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (SingleSound)(object)new OutOfMemoryException();
	}

	public SingleSound GetStampSound(CheatingPerformance stampLevel)
	{
		//IL_000c: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0020: Expected O, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I
		object obj = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		bool flag = stampLevel < (CheatingPerformance)8;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = 119873536 + 2780;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound result = default(SingleSound);
			return result;
		}
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = "setMimeType" + 3888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj7 = (nint)0 + (nint)2400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (SingleSound)(object)new OutOfMemoryException();
	}

	public GameSoundAlbum()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF2E0");
	}
}
