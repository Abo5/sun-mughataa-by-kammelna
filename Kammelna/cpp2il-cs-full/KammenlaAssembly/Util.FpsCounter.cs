using System.Collections.Generic;
using System.ComponentModel;
using Cpp2ILInjected;
using UnityEngine;

namespace Util;

public class FpsCounter : Singleton<FpsCounter>
{
	private const float fpsMeasurePeriod = 1f;

	private const float touchMeasurePeriod = 1f;

	public bool EnableFPS;

	private float m_FpsNextPeriod;

	private float m_TouchNextPeriod;

	private int m_FpsAccumulator;

	private int m_AvgFps;

	private int m_MinFpsAccumulator;

	private int m_MinFps;

	private int m_MaxFpsAccumulator;

	private int m_MaxFps;

	private int m_TouchAccumulator;

	private int m_TouchesThisTurn;

	private int m_MaxTouch;

	private bool m_newRecord;

	private void Start()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float fpsNextPeriod = realtimeSinceStartup + 1f;
		m_FpsNextPeriod = fpsNextPeriod;
		float realtimeSinceStartup2 = Time.realtimeSinceStartup;
		float touchNextPeriod = realtimeSinceStartup2 + 1f;
		m_TouchNextPeriod = touchNextPeriod;
	}

	private void OnGUI()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_006a: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00e5: Expected O, but got I4
		//IL_0308: Expected O, but got I
		//IL_031a: Expected O, but got I
		//IL_0340: Invalid comparison between F8 and I4
		//IL_037e: Expected O, but got I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_026d: Expected O, but got I
		//IL_0279: Expected O, but got I
		//IL_0295: Expected O, but got I4
		//IL_03c8: Expected O, but got I4
		if (EnableFPS)
		{
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1872;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GUI.backgroundColor = (Color)0;
			GUI.contentColor = (Color)0;
			GUISkin skin = GUI.skin;
			GUIStyle label = skin.label;
			label.fontSize = 50;
			object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1880;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v13+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v9+20]");
			GUI.Box((Rect)0, (GUIContent)null);
			float smoothDeltaTime = Time.smoothDeltaTime;
			double num = 1.0 / (double)smoothDeltaTime;
			if (num == 2139095040.0)
			{
			}
			int num2 = default(int);
			string position = num2.ToString();
			GUI.Label((Rect)position, null);
			object obj8 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "AvailableVoices" + 96;
			object arg = default(object);
			string position2 = string.Format((string)format, arg);
			GUI.Label((Rect)position2, null);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format2 = "Material with texture name \"" + 1584;
			object arg2 = default(object);
			string position3 = string.Format((string)format2, arg2);
			GUI.Label((Rect)position3, null);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format3 = "Material with texture name \"" + 160;
			object arg3 = default(object);
			string position4 = string.Format((string)format3, arg3);
			GUI.Label((Rect)position4, null);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format4 = "ThisIsFakeReceiptData" + 928;
			object arg4 = default(object);
			string position5 = string.Format((string)format4, arg4);
			GUI.Label((Rect)position5, null);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format5 = "The operation is not allowed on non-connected sockets." + 4080;
			object arg5 = default(object);
			string position6 = string.Format((string)format5, arg5);
			GUI.Label((Rect)position6, null);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format6 = "Material with texture name \"" + 104;
			object arg6 = default(object);
			string text = string.Format((string)format6, arg6);
			object obj9 = (nint)0 + (nint)4008;
			object obj10 = (nint)0 + (nint)2000;
			bool flag3 = !m_newRecord;
			object obj11 = !flag3;
			object obj12 = ~obj11;
			if (obj12 != null)
			{
				obj9 = obj10;
			}
			string text2 = text + (string)obj9;
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v43+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			Rect position7 = (Rect)text2;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				position7 = (Rect)text2;
			}
			GUI.Label(position7, null);
		}
	}

	private void Update()
	{
		if (!EnableFPS)
		{
			return;
		}
		UpdateFps();
		if (InputUtil.PointerPressedThisFrame)
		{
			int touchAccumulator = m_TouchAccumulator + 1;
			m_TouchAccumulator = touchAccumulator;
		}
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		if (realtimeSinceStartup > m_TouchNextPeriod)
		{
			bool newRecord;
			if (m_TouchAccumulator > m_MaxTouch)
			{
				m_MaxTouch = m_TouchAccumulator;
				newRecord = true;
			}
			else
			{
				newRecord = false;
			}
			m_newRecord = newRecord;
			m_TouchAccumulator = 0;
			m_TouchesThisTurn = m_TouchAccumulator;
			double num = (double)m_TouchNextPeriod + 1.0;
			m_TouchNextPeriod = (float)num;
		}
	}

	private void UpdateFps()
	{
		//IL_0027: Invalid comparison between F8 and I4
		//IL_0187: Invalid comparison between F8 and I4
		//IL_0064: Invalid comparison between F8 and I4
		//IL_00c0: Invalid comparison between F8 and I4
		//IL_01a8: Expected I4, but got F8
		//IL_0088: Expected F8, but got I8
		//IL_01fb: Expected I4, but got F8
		//IL_00e4: Expected F8, but got I8
		float smoothDeltaTime = Time.smoothDeltaTime;
		double num = 1.0 / (double)smoothDeltaTime;
		if (num < (double)m_MinFpsAccumulator)
		{
			float smoothDeltaTime2 = Time.smoothDeltaTime;
			double num2 = 1.0 / (double)smoothDeltaTime2;
			double num3 = ((num2 != 2139095040.0) ? num2 : 2147483648.0);
			m_MinFpsAccumulator = (int)num3;
		}
		float smoothDeltaTime3 = Time.smoothDeltaTime;
		double num4 = 1.0 / (double)smoothDeltaTime3;
		if (num4 > (double)m_MaxFpsAccumulator)
		{
			float smoothDeltaTime4 = Time.smoothDeltaTime;
			double num5 = 1.0 / (double)smoothDeltaTime4;
			double num6 = ((num5 != 2139095040.0) ? num5 : 2147483648.0);
			m_MaxFpsAccumulator = (int)num6;
		}
		int fpsAccumulator = m_FpsAccumulator + 1;
		m_FpsAccumulator = fpsAccumulator;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		if (realtimeSinceStartup > m_FpsNextPeriod)
		{
			m_MinFpsAccumulator = 60;
			m_MinFps = m_MinFpsAccumulator;
			m_MaxFpsAccumulator = 0;
			m_MaxFps = m_MaxFpsAccumulator;
			m_FpsAccumulator = 0;
			m_AvgFps = m_FpsAccumulator;
			double num7 = (double)m_FpsNextPeriod + 1.0;
			m_FpsNextPeriod = (float)num7;
		}
	}

	private void UpdateTouchesPerSecond()
	{
		//IL_001f: Expected O, but got I4
		bool pointerPressedThisFrame = InputUtil.PointerPressedThisFrame;
		bool flag = !pointerPressedThisFrame;
		object obj = !flag;
		float touchNextPeriod;
		if (obj == null)
		{
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			touchNextPeriod = m_TouchNextPeriod;
			if (!(realtimeSinceStartup > m_TouchNextPeriod))
			{
				return;
			}
		}
		else
		{
			int touchAccumulator = m_TouchAccumulator + 1;
			m_TouchAccumulator = touchAccumulator;
			float realtimeSinceStartup2 = Time.realtimeSinceStartup;
			touchNextPeriod = m_TouchNextPeriod;
			if (!(realtimeSinceStartup2 > m_TouchNextPeriod))
			{
				return;
			}
		}
		bool newRecord;
		if (m_TouchAccumulator > m_MaxTouch)
		{
			m_MaxTouch = m_TouchAccumulator;
			newRecord = true;
		}
		else
		{
			newRecord = false;
		}
		m_newRecord = newRecord;
		m_TouchAccumulator = 0;
		m_TouchesThisTurn = m_TouchAccumulator;
		double num = (double)touchNextPeriod + 1.0;
		m_TouchNextPeriod = (float)num;
	}

	public FpsCounter()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 744;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E857F]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2000;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2000;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}
}
