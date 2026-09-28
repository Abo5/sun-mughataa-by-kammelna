# مراجع: الجداول الثابتة المقروءة من الثنائي

**الملف**: `Kammelna/extracted/Payload/كملنا.app/Frameworks/UnityFramework.framework/UnityFramework`
**ملاحظة**: مقطع `__TEXT` يبدأ من `vmaddr = 0` و`fileoff = 0`، لذلك **العنوان الافتراضي = إزاحة الملف مباشرة**.

```
__TEXT        vmaddr 0x0        size 0x8430000   fileoff 0x0
__DATA_CONST  vmaddr 0x8430000  size 0x60c000    fileoff 0x8430000
__DATA        vmaddr 0x8a3c000  size 0xa24000    fileoff 0x8a3c000
```

قاعدة الجداول المستخدمة في البلوت: **`0x7253000`** (= 119877632 عشري).

---

## 1. `0x7253448` — رتب القوة في الصن
**الدالة**: `[CS: KammelnaOffline.Baloot.BalootUtils.cs → GetCardValueRank]` (الفرع غير الحكم)
**الفهرسة**: `Rank - 5` أي من `SEVEN` إلى `ACE` (8 عناصر `int32`)

```
[1, 2, 3, 7, 4, 5, 6, 8]
 ↑7 ↑8 ↑9 ↑10 ↑J ↑Q ↑K ↑A
```
⇒ إكة 8 > عشرة 7 > شايب 6 > بنت 5 > ولد 4 > تسعة 3 > ثمانية 2 > سبعة 1

---

## 2. `0x7253468` — رتب القوة في نوع الحكم
**الدالة**: نفسها (فرع `gameMode == Hokom`)
**الفهرسة**: `Rank - 5` (8 عناصر)

```
[9, 10, 15, 13, 16, 11, 12, 14]
 ↑7  ↑8  ↑9 ↑10  ↑J  ↑Q  ↑K  ↑A
```
⇒ ولد 16 > تسعة 15 > إكة 14 > عشرة 13 > شايب 12 > بنت 11 > ثمانية 10 > سبعة 9

> القيم 9..16 أعلى من 1..8 ⇒ أي ورقة حكم تغلب أي ورقة غير حكم بمقارنة عددية واحدة.

---

## 3. `0x7253488` — أبناط الصن
**الدالة**: `[CS: KammelnaOffline.Baloot.BalootUtils.cs → GetCardValueForScores]`
**الفهرسة**: `Rank - 8` أي من `TEN` إلى `ACE` (5 عناصر)

```
[10, 2, 3, 4, 11]
 ↑10 ↑J ↑Q ↑K ↑A
```
⇒ إكة 11 · عشرة 10 · شايب 4 · بنت 3 · ولد 2 · (٩، ٨، ٧ = صفر)
**المجموع لكل نوع = 30 بنط · أربعة أنواع = 120 · + 10 آخر أكلة = 130**

---

## 4. `0x725349C` — أبناط نوع الحكم
**الدالة**: نفسها (فرع الحكم)
**الفهرسة**: `Rank - 5` أي من `SEVEN` إلى `ACE` (8 عناصر)

```
[0, 0, 14, 10, 20, 3, 4, 11]
 ↑7 ↑8  ↑9 ↑10  ↑J ↑Q ↑K ↑A
```
⇒ ولد 20 · تسعة 14 · إكة 11 · عشرة 10 · شايب 4 · بنت 3 · (٨، ٧ = صفر)
**مجموع نوع الحكم = 62 · + 3 أنواع × 30 = 90 · + 10 آخر أكلة = 162**

---

## 5. `0x72534F0` — أبناط المشاريع
**الدالة**: `[CS: KammelnaOffline.Baloot.BalootUtils.cs → ProjectAbnat]`
**الفهرسة**: `BalootProject` (4 عناصر)

```
[20, 50, 100, 400]
 ↑Sira ↑P50 ↑P100 ↑P400
```

---

## 6. `0x72536A0` — قيمة ترتيب المشاريع
**الدالة**: `[CS: BalootProjectMethods.cs → OrderingValue]`
**الفهرسة**: `BalootProject` (4 عناصر)

```
[1, 10, 100, 1000]
```

---

## 7. `0x72536C0` — الرتبة الأساسية لـ `GetValue`
**الدالة**: `[CS: BalootCardUtils.cs → GetValue(Card)]`
**الفهرسة**: `Rank - 8` من `TEN` إلى `ACE` (5 عناصر)

```
[7, 4, 5, 6, 8]
 ↑10 ↑J ↑Q ↑K ↑A
```
(للمراتب الأدنى: `base = Rank - 4` ⇒ سبعة 1، ثمانية 2، تسعة 3)

---

## 8. `0x713BC70` — خريطة المقعد إلى الفريق
**الدالة**: `[CS: KammelnaOffline.Baloot.BalootUtils.cs → GetPlayerTeam]`
**الفهرسة**: `seatIndex - 1` (4 عناصر)

```
[1, 2, 1, 2]
 ↑مقعد1 ↑مقعد2 ↑مقعد3 ↑مقعد4
```

---

## 9. ثابت 64-بت مضمّن — قيم المشاريع
**الدالة**: `[CS: KammelnaOffline.Baloot.BalootUtils.cs → ProjectValue]`

```
0x0190006400320014
   ↑400 ↑100 ↑50 ↑20     (كل قيمة 16 بت، الأدنى أولًا)
```
الاستخراج: `(0x0190006400320014 >> (project * 16)) & 0x1FFFE`

---

## سكربت القراءة

```python
import struct
BASE = 0x7253000
f = open("UnityFramework", "rb")

def table(addr, n):
    f.seek(addr)
    return struct.unpack(f"<{n}i", f.read(4 * n))

print("sun rank   ", table(0x7253448, 8))
print("hokom rank ", table(0x7253468, 8))
print("sun points ", table(0x7253488, 5))
print("hokom pts  ", table(0x725349C, 8))
print("proj abnat ", table(0x72534F0, 4))
print("proj order ", table(0x72536A0, 4))
print("base rank  ", table(0x72536C0, 5))
print("seat→team  ", table(0x713BC70, 4))
```
