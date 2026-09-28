using System;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Spine;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.Purchasing.Telemetry;

public class TextureScale
{
	public class ThreadData
	{
		public int start;

		public int end;

		public ThreadData(int s, int e)
		{
			start = s;
			end = e;
		}
	}

	private static Color[] texColors;

	private static Color[] newColors;

	private static int w;

	private static float ratioX;

	private static float ratioY;

	private static int w2;

	private static int finishCount;

	private static Mutex mutex;

	public static void Point(Texture2D tex, int newWidth, int newHeight)
	{
		ThreadedScale(tex, newWidth, newHeight, useBilinear: false);
	}

	public static void Bilinear(Texture2D tex, int newWidth, int newHeight)
	{
		ThreadedScale(tex, newWidth, newHeight, useBilinear: true);
	}

	private static void ThreadedScale(Texture2D tex, int newWidth, int newHeight, bool useBilinear)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0066: Expected O, but got I4
		//IL_008e: Expected O, but got I
		//IL_018d: Expected O, but got I
		//IL_077e: Expected O, but got I
		//IL_078b: Expected I, but got O
		//IL_079b: Expected O, but got I
		//IL_07c0: Expected O, but got I
		//IL_07e0: Expected O, but got I4
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected I4, but got Unknown
		//IL_083e: Expected O, but got I4
		//IL_00d9: Expected O, but got I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected I4, but got Unknown
		//IL_0112: Expected O, but got I
		//IL_0163: Expected I4, but got F8
		//IL_086d: Expected O, but got I
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_02d0: Expected O, but got I
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_032f: Expected O, but got I4
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_0543: Expected O, but got I
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		//IL_0570: Expected O, but got I4
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Expected O, but got Unknown
		//IL_038d: Expected O, but got I
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03ba: Expected O, but got I4
		//IL_04c2: Expected O, but got I
		//IL_04d7: Expected O, but got I
		//IL_0583: Expected I, but got O
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected O, but got Unknown
		//IL_04f6: Expected O, but got I4
		//IL_03cd: Expected I, but got O
		//IL_0523: Expected O, but got I
		//IL_052c: Expected O, but got I4
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected O, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected O, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected O, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected O, but got Unknown
		//IL_06c4: Expected O, but got I
		//IL_0725: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 800;
		object obj2 = typeof(TypeConverter<ushort, char>) + 1976;
		Color[] pixels = tex.GetPixels();
		object obj3 = obj;
		object obj4 = pixels;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = newHeight * newWidth;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v5+B8]");
		object obj7 = (nint)0 + (nint)8;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int width = tex.width;
		if (useBilinear)
		{
			object obj9 = width - 1;
			int num = newWidth / obj9;
			double num2 = 1.0 / (double)num;
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v44+B8]");
			object obj11 = 0;
			int height = tex.height;
			int num3 = height - 1;
			int num4 = newHeight / num3;
			double num5 = 1.0 / (double)num4;
			int num6 = num3;
			int num7 = (int)num5;
		}
		else
		{
			int num8 = width / newWidth;
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v40+B8]");
			object obj13 = 0;
			int height2 = tex.height;
			int num7 = height2 / newHeight;
			int num6 = newHeight;
		}
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v8+B8]");
		object obj15 = 0;
		nint num9 = (nint)tex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v10 (Il2CppClass<UnityEngine.Texture2D>)+190]");
		Mutex mutex = (Mutex)0;
		int width2 = tex.width;
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v11+B8]");
		object obj17 = 0;
		int processorCount = UnityEngine.Device.SystemInfo.processorCount;
		object obj18 = processorCount - newHeight;
		bool flag = (nint)obj18 < 0;
		int num10 = processorCount ^ newHeight;
		int num11 = processorCount ^ obj18;
		int num12 = num10 & num11;
		bool flag2 = num12 < 0;
		bool flag3 = flag == flag2;
		object obj19 = !flag3;
		object obj20 = ~obj19;
		int num13 = ((obj20 != null) ? newHeight : processorCount);
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v13+B8]");
		object obj22 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v14+28]");
		if ((nint)0 != 0)
		{
			bool flag4 = num13 >= 2;
			int num14 = newHeight;
			int num15 = newHeight;
			object obj23 = mutex;
			if (!flag4)
			{
				goto IL_020b;
			}
		}
		else
		{
			object obj24 = typeof(MemberAchievementClanFeedData) + 1880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Mutex mutex2 = default(Mutex);
			mutex2..ctor(initiallyOwned: false);
			object obj25 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v36+B8]");
			object obj26 = (nint)0 + (nint)40;
			obj26 = mutex2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag5 = num13 < 2;
			int num14 = 0;
			mutex = mutex2;
			int num15 = 0;
			object obj23 = mutex2;
			if (flag5)
			{
				goto IL_020b;
			}
		}
		object obj27 = num13 - 1;
		int num16 = newHeight / num13;
		object obj28 = typeof(SkeletonBinary.SkeletonInput) + 2928;
		object obj29 = typeof(MemberAchievementClanFeedData) + 4048;
		if (useBilinear)
		{
			object obj30 = (nint)0 + (nint)2432;
			object obj31 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 872;
			bool flag6 = useBilinear;
			object obj32 = obj27;
			object obj33 = 0;
			object obj35 = default(object);
			ParameterizedThreadStart parameterizedThreadStart = default(ParameterizedThreadStart);
			Thread thread = default(Thread);
			bool flag7;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj34 = num16 + obj33;
				obj35..ctor();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				parameterizedThreadStart..ctor(null, (IntPtr)obj30);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				thread..ctor(parameterizedThreadStart);
				thread.Start(obj35);
				obj33 += num16;
				obj32--;
				flag7 = (nint)obj32 != 1;
				flag6 = false;
				int num15 = 0;
				object obj23 = obj35;
			}
			while (flag7);
			bool flag8 = false;
			int num17 = 0;
			object obj36 = obj35;
		}
		else
		{
			object obj37 = (nint)0 + (nint)2440;
			object obj38 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 872;
			bool flag9 = useBilinear;
			object obj39 = obj27;
			object obj40 = 0;
			object obj42 = default(object);
			ParameterizedThreadStart parameterizedThreadStart2 = default(ParameterizedThreadStart);
			Thread thread2 = default(Thread);
			bool flag10;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj41 = num16 + obj40;
				obj42..ctor();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				parameterizedThreadStart2..ctor(null, (IntPtr)obj37);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				thread2..ctor(parameterizedThreadStart2);
				thread2.Start(obj42);
				obj40 += num16;
				obj39--;
				flag10 = (nint)obj39 != 1;
				bool flag8 = false;
				int num17 = 0;
				object obj36 = obj42;
				flag9 = false;
				int num15 = 0;
				object obj23 = obj42;
			}
			while (flag10);
		}
		object obj43 = typeof(SkeletonBinary.SkeletonInput) + 2928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj44 = obj27 * num16;
		object obj45 = default(object);
		obj45..ctor();
		if (useBilinear)
		{
			BilinearScale(obj45);
		}
		else
		{
			PointScale(obj45);
		}
		obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 800;
		object obj46 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v27+B8]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v28+20]");
		bool flag11 = (nint)0 >= (nint)num13;
		Texture2D texture2D = tex;
		int width3 = newWidth;
		int height3 = newHeight;
		if (!flag11)
		{
			do
			{
				Thread.Sleep(1);
				object obj48 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v31+B8]");
				object obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v32+20]");
			}
			while ((nint)0 < (nint)num13);
			texture2D = tex;
			width3 = newWidth;
			height3 = newHeight;
		}
		goto IL_0495;
		IL_020b:
		object obj50 = typeof(SkeletonBinary.SkeletonInput) + 2928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj51 = default(object);
		obj51..ctor();
		_ = 0;
		if (useBilinear)
		{
			BilinearScale(obj51);
			texture2D = tex;
			width3 = newWidth;
			height3 = newHeight;
		}
		else
		{
			PointScale(obj51);
			texture2D = tex;
			width3 = newWidth;
			height3 = newHeight;
		}
		goto IL_0495;
		IL_0495:
		bool flag12 = texture2D.Reinitialize(width3, height3);
		object obj52 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v17+B8]");
		object obj53 = 0;
		Texture2D texture2D2 = texture2D;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v18+8]");
		texture2D2.SetPixels((Color[])0);
		texture2D.Apply();
		object obj54 = obj;
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj56 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v20+B8]");
		object obj57 = (nint)0 + (nint)8;
		obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public static void BilinearScale(object obj)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I
		//IL_00e9: Expected O, but got I
		//IL_046c: Expected O, but got I
		//IL_049b: Expected O, but got I
		//IL_04b1: Expected O, but got I
		//IL_04cc: Expected O, but got I
		//IL_015a: Expected O, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_017e: Expected O, but got I
		//IL_019b: Expected O, but got I
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_0520: Expected O, but got I4
		//IL_01b5: Expected O, but got I8
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_055b: Expected O, but got I4
		//IL_01d4: Expected O, but got I8
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0215: Expected O, but got I4
		//IL_0251: Expected O, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_028e: Expected O, but got I4
		//IL_02bd: Expected O, but got I4
		//IL_02e8: Expected O, but got I
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_0349: Expected O, but got I
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 2928;
		object obj3 = obj2;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v7 (Il2CppClass<System.Object>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X1_v3+130]");
		bool flag = num2 < 0;
		object obj4 = !flag;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v7 (Il2CppClass<System.Object>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X1_v3+130]");
			object obj6 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v9-8]");
			if (0 == (nint)obj3)
			{
				object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 800;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X0 (System.Object)+10]");
				object obj8 = 0;
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v4+B8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X0 (System.Object)+10]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X0 (System.Object)+14]");
				if (num4 < 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v5+1C]");
					if ((nint)0 >= (nint)1)
					{
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v5+8]");
						object obj12 = 0;
						object obj13 = obj10 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v5+8]");
						object obj14 = (nint)0 + (nint)32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X0 (System.Object)+10]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v5+1C]");
						object obj15 = num5 * 0;
						object obj17 = default(object);
						object obj16 = obj17;
						object obj39 = default(object);
						object obj48 = default(object);
						bool flag7;
						do
						{
							object obj18 = obj15 << 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v5+18]");
							object obj19 = 0 * obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
							object obj20 = (((nint)obj16 != 2139095040) ? obj19 : ((object)2147483648L));
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v5+10]");
							object obj21 = obj20 * 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v5+10]");
							object obj22 = 0 + obj21;
							object obj23 = 0;
							object obj24 = obj15;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v5+14]");
								object obj25 = 0 * obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
								object obj26 = (((nint)obj23 != 2139095040) ? obj25 : ((object)2147483648L));
								object obj27 = obj26 + obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X16_v4+18]");
								bool flag2 = (nint)obj27 < 0;
								object obj28 = !flag2;
								if (obj28 == null)
								{
									object obj29 = obj27 + 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X16_v4+18]");
									bool flag3 = (nint)obj29 < 0;
									object obj30 = !flag3;
									if (obj30 == null)
									{
										object obj31 = obj26 + obj22;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X16_v4+18]");
										bool flag4 = (nint)obj31 < 0;
										object obj32 = !flag4;
										if (obj32 == null)
										{
											object obj33 = obj31 + 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X16_v4+18]");
											bool flag5 = (nint)obj33 < 0;
											object obj34 = !flag5;
											if (obj34 == null)
											{
												object obj35 = obj24;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X13_v4+18]");
												bool flag6 = (nint)obj35 < 0;
												object obj36 = !flag6;
												if (obj36 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X14_v4+v114 @ X23_v8*16]");
													nint num6 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X14_v4+v240 @ X19_v8*16]");
													object obj37 = num6 - 0;
													object obj38 = obj37 * obj39;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X14_v4+v240 @ X19_v8*16]");
													object obj40 = 0 + obj38;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v5+18]");
													object obj41 = 0 * obj8;
													object obj42 = obj41 - obj20;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X14_v4+v106 @ X21_v8*16]");
													nint num7 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X14_v4+v110 @ X7_v8*16]");
													object obj43 = num7 - 0;
													object obj44 = obj43 * obj39;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X14_v4+v110 @ X7_v8*16]");
													object obj45 = 0 + obj44;
													object obj46 = obj45 - obj40;
													object obj47 = obj46 * obj48;
													obj17 = obj40 + obj47;
													object obj49 = obj18 >> 28;
													obj23++;
													obj18 += 4294967296L;
													obj24++;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v5+1C]");
													if (0 == (nint)obj23)
													{
														break;
													}
													continue;
												}
											}
										}
									}
								}
								IndexOutOfRangeException ex = new IndexOutOfRangeException();
								throw new NullReferenceException();
							}
							object obj50 = obj8 + 1;
							object obj51 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v5+1C]");
							object obj52 = obj51 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X0 (System.Object)+14]");
							flag7 = obj50 != null;
							obj16 = obj17;
							obj15 = obj52;
							obj8 = obj50;
						}
						while (flag7);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v5+28]");
				object obj53 = 0;
				object obj54 = obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v391 @ X8_v13+1E8] (should have been resolved before IL gen)");
				object obj55 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v14+B8]");
				object obj56 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v15+20]");
				object obj57 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v15+28]");
				((Mutex)0).ReleaseMutex();
				return;
			}
		}
		throw new InvalidCastException();
	}

	public static void PointScale(object obj)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_0072: Expected O, but got I4
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_00a6: Expected O, but got I
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected O, but got Unknown
		//IL_05b2: Expected O, but got I
		//IL_044d: Expected O, but got I8
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0101: Expected O, but got I
		//IL_035c: Expected O, but got I
		//IL_05f8: Expected O, but got I4
		//IL_046c: Expected O, but got I8
		//IL_03ab: Expected O, but got I
		//IL_03c1: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_03fc: Expected O, but got I
		//IL_01a2: Expected O, but got I
		//IL_01b2: Expected O, but got I
		//IL_01e5: Expected O, but got I
		//IL_01fb: Expected O, but got I
		//IL_0218: Expected O, but got I
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04ce: Expected O, but got I4
		//IL_022a: Expected O, but got I8
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_04f4: Expected O, but got I4
		//IL_0249: Expected O, but got I8
		//IL_027c: Expected O, but got I4
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		object obj4;
		object obj5;
		object obj9;
		if (obj != null)
		{
			object obj2 = typeof(SkeletonBinary.SkeletonInput) + 2928;
			object obj3 = obj2;
			nint num = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+130]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X1_v3+130]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X1_v3+130]");
			bool flag = num2 < 0;
			object obj6 = !flag;
			object obj7 = ~obj6;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X1_v3+130]");
				object obj8 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v20-8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v20-8]");
				if (0 == (nint)obj3)
				{
					obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 800;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X0 (System.Object)+10]");
					obj4 = 0;
					object obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v22+B8]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X0 (System.Object)+10]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X0 (System.Object)+14]");
					if (num4 < 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+1C]");
						if ((nint)0 >= (nint)1)
						{
							object obj11 = num;
							if (num == 0)
							{
								goto IL_047e;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+8]");
							object obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X15_v5+18]");
							obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+8]");
							if ((nint)0 == 0)
							{
								goto IL_040b;
							}
							object obj13 = num + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+8]");
							object obj14 = (nint)0 + (nint)32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X0 (System.Object)+10]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+1C]");
							object obj15 = num5 * 0;
							while (true)
							{
								object obj16 = obj15 << 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+18]");
								object obj17 = 0 * obj4;
								object obj18 = (((nint)obj17 != 2139095040) ? obj17 : ((object)2147483648L));
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+10]");
								object obj19 = obj18 * 0;
								object obj20 = 0;
								object obj21 = obj15;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+14]");
									object obj22 = 0 * obj20;
									object obj23 = obj22 + obj19;
									object obj24 = (((nint)obj23 != 2139095040) ? obj23 : ((object)2147483648L));
									bool flag2 = obj24 < obj5;
									object obj25 = !flag2;
									if (obj25 != null)
									{
										break;
									}
									object obj26 = obj21;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X14_v5+18]");
									bool flag3 = (nint)obj26 < 0;
									object obj27 = !flag3;
									if (obj27 != null)
									{
										break;
									}
									object obj28 = obj16 >> 28;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X15_v6+v76 @ X5_v3*16]");
									_ = 0;
									obj20++;
									obj16 += 4294967296L;
									obj21++;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+1C]");
									if (0 != (nint)obj20)
									{
										continue;
									}
									goto IL_02fa;
								}
								break;
								IL_02fa:
								obj4++;
								object obj29 = obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+1C]");
								object obj30 = obj29 + 0;
								object obj31 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X0 (System.Object)+14]");
								bool flag4 = obj31 != null;
								obj15 = obj30;
								if (flag4)
								{
									continue;
								}
								goto IL_034c;
							}
							goto IL_048c;
						}
					}
					goto IL_034c;
				}
			}
			InvalidCastException ex = new InvalidCastException();
			goto IL_040b;
		}
		goto IL_047e;
		IL_048c:
		throw new IndexOutOfRangeException();
		IL_047e:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_048c;
		IL_034c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+28]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+28]");
		if ((nint)0 != 0)
		{
			object obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v384 @ X8_v24+1E8] (should have been resolved before IL gen)");
			object obj34 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v25+B8]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v26+20]");
			object obj36 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v26+28]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v26+28]");
				((Mutex)0).ReleaseMutex();
				return;
			}
		}
		goto IL_047e;
		IL_040b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+18]");
		object obj37 = 0 * obj4;
		object obj38 = (((nint)obj37 != 2139095040) ? obj37 : ((object)2147483648L));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+10]");
		object obj39 = obj38 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<System.Object>)+14]");
		object obj40 = (nint)0 * (nint)0;
		object obj41 = obj40 + obj39;
		object obj42 = (((nint)obj41 != 2139095040) ? obj41 : ((object)2147483648L));
		bool flag5 = obj42 < obj5;
		object obj43 = !flag5;
		if (obj43 == null)
		{
			goto IL_047e;
		}
		goto IL_048c;
	}

	private static Color ColorLerpUnclamped(Color c1, Color c2, float value)
	{
		return c1;
	}
}
