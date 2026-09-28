using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ColorSelectorItem : MonoBehaviour, ISelectable
{
	private sealed class <>c__DisplayClass7_0
	{
		public ColorSelector manager;

		public ColorSelectorItem <>4__this;

		internal void <Init>b__0()
		{
			manager.SetSelectedItem(<>4__this, addUndo: true);
		}
	}

	private Graphic graphic;

	private Button button;

	private GameObject selectionIndicator;

	private Color <Color>k__BackingField;

	public Color Color
	{
		get
		{
			return (Color)this;
		}
		private set
		{
			Color color = default(Color);
			<Color>k__BackingField = color;
		}
	}

	public void Init(Color color, ColorSelector manager)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0096: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I
		//IL_00fd: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = color;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selectionIndicator.SetActive(value: false);
		Color color2 = default(Color);
		<Color>k__BackingField = color2;
		graphic.color = (Color)0;
		Button button = this.button;
		button.m_OnClick.RemoveAllListeners();
		Button button2 = this.button;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj6 = (nint)0 + (nint)1216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(obj2, (IntPtr)obj6);
		button2.m_OnClick.AddListener(unityAction);
	}

	public void Select()
	{
		selectionIndicator.SetActive(value: true);
	}

	public void Deselect()
	{
		selectionIndicator.SetActive(value: false);
	}
}
