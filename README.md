# Sun Mughataa — by Kammelna (صن مغطى)

تحليل كامل وإعادة بناء لتطبيق **كملنا Enjoy** (`net.peakgames.kammelna`) — لعبة الورق
(بلوت · طرنيب · جكارو) من Peak Games على iOS (Unity / IL2CPP).

هذا المستودع يحتوي على **كل نتائج العمل**، مقسّمة إلى مجلدات معزولة وواضحة.

## البنية

| المجلد | المحتوى |
|---|---|
| [`archive/`](archive/) | **الأرشفة + التعليمات**: أرشيفات المواصفات الهندسية (بلوت · طرنيب · جكارو · …) + أدوات الأرشيف + الفهرس + دليل التنقّل |
| [`source-code/`](source-code/) | **سورس كود كملنا**: الكود المصدري المفكوك (C#) + مخرجات Il2CppDumper / Cpp2IL |
| [`extracted/`](extracted/) | الملفات الخام المستخرجة من التطبيق (1018 ملف بدون تشفير) |
| [`tooling/`](tooling/) | أدوات الاستخراج المخصصة (سكربتات Ghidra · cecilcount · ildecomp · extract_ipa) |

ابدأ من [`archive/README.md`](archive/README.md) لفهم الأرشيف كاملًا
(معلومات التطبيق، سُلّم اليقين، دليل التنقّل، وفهرس العناوين).

## ملاحظات

- **الملفات المضغوطة (gzip)**: بعض الملفات الكبيرة ضُغطت لتجاوز حد GitHub البالغ
  100MB للملف الواحد — `source-code/il2cpp-dump/script.json.gz` و
  `source-code/il2cpp-dump/il2cpp.h.gz` و
  `extracted/Payload/كملنا.app/Frameworks/UnityFramework.framework/UnityFramework.gz`.
  لفكّها: `gunzip <اسم-الملف>`.
- **الأدوات الخارجية** (Ghidra · JDK · Il2CppDumper · Cpp2IL · mobrecon-go) غير
  مرفوعة هنا لأنها أدوات طرف ثالث قابلة للتحميل، وقواعد بياناتها الثنائية
  (مثل مشروع Ghidra بحجم 2.5GB) تتجاوز حدود GitHub — وموثّقة في `archive/README.md`.
