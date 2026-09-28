using System;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem.UI;
using UnityEngine.Purchasing.Telemetry;

public static class TweenHelpers
{
	private sealed class <>c__DisplayClass0_0
	{
		public GameObject gameObject;

		internal void <Enable>b__0()
		{
			gameObject.SetActive(value: true);
		}
	}

	private sealed class <>c__DisplayClass1_0
	{
		public GameObject gameObject;

		internal void <Disable>b__0()
		{
			gameObject.SetActive(value: false);
		}
	}

	private sealed class <>c__DisplayClass2_0
	{
		public Component comp;

		internal void <Enable>b__0()
		{
			GameObject gameObject = comp.gameObject;
			gameObject.SetActive(value: true);
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public Component comp;

		internal void <Disable>b__0()
		{
			GameObject gameObject = comp.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	public static TweenCallback Enable(GameObject gameObject)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj4 = (nint)0 + (nint)936;
			object obj5 = obj2 + 16;
			obj5 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(obj2, (IntPtr)obj4);
			return tweenCallback;
		}
		return (TweenCallback)(object)new NullReferenceException();
	}

	public static TweenCallback Disable(GameObject gameObject)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj4 = (nint)0 + (nint)944;
			object obj5 = obj2 + 16;
			obj5 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(obj2, (IntPtr)obj4);
			return tweenCallback;
		}
		return (TweenCallback)(object)new NullReferenceException();
	}

	public static TweenCallback Enable(Component comp)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj4 = (nint)0 + (nint)952;
			object obj5 = obj2 + 16;
			obj5 = comp;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(obj2, (IntPtr)obj4);
			return tweenCallback;
		}
		return (TweenCallback)(object)new NullReferenceException();
	}

	public static TweenCallback Disable(Component comp)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj4 = (nint)0 + (nint)960;
			object obj5 = obj2 + 16;
			obj5 = comp;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(obj2, (IntPtr)obj4);
			return tweenCallback;
		}
		return (TweenCallback)(object)new NullReferenceException();
	}
}
