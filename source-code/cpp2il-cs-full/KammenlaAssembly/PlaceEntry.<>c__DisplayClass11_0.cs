using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Mono.Btls;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;

[Serializable]
public class PlaceEntry
{
	private sealed class <>c__DisplayClass11_0
	{
		public int totalLevels;

		internal bool <GetPreset>b__0(DisplayPreset p)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (p != null)
			{
				object obj = p.LevelCount - totalLevels;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public string Name;

	public AchievementDisplayPlace Place;

	public Vector2 AnchoredPosition;

	public Vector2 SizeDelta;

	public Vector2 Pivot;

	public Vector3 LocalScale;

	public Sprite TestImage;

	public Vector2 ContainerAnchoredPosition;

	private List<DisplayPreset> _presets;

	public IReadOnlyList<DisplayPreset> Presets => _presets;

	public DisplayPreset GetPreset(int totalLevels)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0079: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			if (_presets != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 944;
				object obj4 = (nint)0 + (nint)608;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj4);
				return (DisplayPreset)Enumerable.FirstOrDefault(_presets, func);
			}
			return null;
		}
		return (DisplayPreset)(object)new NullReferenceException();
	}

	public PlaceEntry()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_003e: Expected O, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_006f: Expected O, but got I
		//IL_0081: Expected O, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 864;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252D50]");
		AnchoredPosition = (Vector2)0;
		Pivot = (Vector2)63;
		object obj2 = typeof(UsageHint) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v6+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+C]");
		LocalScale = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = this + 80;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
