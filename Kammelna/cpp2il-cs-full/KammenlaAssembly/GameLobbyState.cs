using System.Collections.Generic;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;
using Unity.Properties;
using UnityEngine.AdaptivePerformance;

public class GameLobbyState
{
	private readonly List<int> <Team1Players>k__BackingField;

	private readonly List<int> <Team2Players>k__BackingField;

	private readonly List<int> <Spectators>k__BackingField;

	public string Error;

	public List<int> Team1Players => <Team1Players>k__BackingField;

	public List<int> Team2Players => <Team2Players>k__BackingField;

	public List<int> Spectators => <Spectators>k__BackingField;

	public void Update(ISFSObject state)
	{
		//IL_001b: Expected O, but got I
		//IL_004b: Expected O, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0094: Expected O, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0192: Expected O, but got I4
		//IL_01a2: Expected O, but got I
		//IL_01b2: Expected O, but got I
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		List<int> list = <Team1Players>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X21_v2 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj = (nint)0 + (nint)1;
		_ = 0;
		List<int> list2 = <Team2Players>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj2 = (nint)0 + (nint)1;
		_ = 0;
		List<int> list3 = <Spectators>k__BackingField;
		object obj3 = typeof(TypeConverter<ushort, char>) + 3048;
		object varName = "startPosition" + 2152;
		object obj4 = (nint)0 + (nint)1344;
		object varName2 = "startPosition" + 2168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj5 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		int[] defaultValue = default(int[]);
		int[] collection = SFSExtensions.Get(state, (string)varName, defaultValue);
		list.AddRange(collection);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		int[] defaultValue2 = default(int[]);
		int[] collection2 = SFSExtensions.Get(state, (string)varName2, defaultValue2);
		object varName3 = "setMimeType" + 3528;
		<Team2Players>k__BackingField.AddRange(collection2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		int[] defaultValue3 = default(int[]);
		int[] collection3 = SFSExtensions.Get(state, (string)varName3, defaultValue3);
		object varName4 = "destinationTimeZone" + 2696;
		<Spectators>k__BackingField.AddRange(collection3);
		object obj6 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v9+90]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v10+B8]");
		object defaultValue4 = 0;
		string text = SFSExtensions.Get(state, (string)varName4, (string)defaultValue4);
		object obj8 = this + 40;
		obj8 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public GameLobbyState()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<int> list = default(List<int>);
		list..ctor();
		object obj2 = this + 16;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<int> list2 = default(List<int>);
		list2..ctor();
		object obj3 = this + 24;
		obj3 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<int> list3 = default(List<int>);
		list3..ctor();
		object obj4 = this + 32;
		obj4 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
