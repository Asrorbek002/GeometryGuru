🧮 Geometry Guru

Geometry Guru — bu C# tilida yozilgan, Clean Architecture asosida qurilgan konsol ilova bo‘lib, turli geometrik shakllarning yuzalarini hisoblash imkonini beradi. 
---
🎬  **Demo (GIF)**

Quyidagi GIF’da dastur qanday ishlashi ko‘rsatilgan:

![Gif](https://github.com/user-attachments/assets/6e643613-d08a-4dd2-9d84-2bdc10c9073a)

---

🚀 Imkoniyatlar

📐 Circle (Doira) yuzini hisoblash

▭ Rectangle (To‘rtburchak) yuzini hisoblash

🔺 Triangle (Uchburchak) yuzini hisoblash

🧭 Konsol menyu orqali tanlash

✅ Foydalanuvchi kiritgan sonlarni tekshirish (validation)

🧱 Clean Architecture (Layered structure)

🧠 OOP va Polymorphism
---

🗂 Loyiha tuzilmasi
GeometryGuru (Solution)
 ├── GeometryGuru.Client          // Console UI
 ├── GeometryGuru.Application     // Service layer
 ├── GeometryGuru.Domain          // Models (Shape)
 └── GeometryGuru.Infrastructure  // (ixtiyoriy)
 ---
🔗 Reference bog‘lanishi
Client → Application → Domain
---
**⚙️ Qanday ishlaydi?**

Dastur ishga tushirilganda menyu chiqadi

Foydalanuvchi shaklni tanlaydi (1–2–3)

Kerakli o‘lchamlar kiritiladi

Dastur yuzani hisoblab natijani ko‘rsatadi

Foydalanuvchi menyuga qaytadi yoki chiqadi
---

🧪 Namuna chiqish
=== GEOMETRY GURU ===
1. Circle
2. Rectangle
3. Triangle
0. Exit
Tanlang: 2


Enini kiriting: 30
Bo'yini kiriting: 20


Yuzi: 600.00
🧠 Kod haqida qisqacha
**🔹 Domain Layer**

Shape — abstract class

Circle, Rectangle, Triangle — Shape dan meros oladi

Har bir shakl CalculateArea() metodini override qiladi

**🔹 Application Layer**

ShapeService — hisoblashni boshqaradi

Business logic shu yerda joylashgan

**🔹 Client Layer**

Program.cs — menyu, input, output

Foydalanuvchi bilan aloqa

**👤 Muallif**

Ism: Asrorbek

Til: C# (.NET)

Maqsad: OOP, Clean Architecture va Console Application’ni amaliy o‘rganish

