# EatAndDrink
Онлайн сервис по доставке еды "Eat and Drink"

# Задание
# Внимание!!! Задание выполняется в отдельной ветке, создание ветки описано ниже

## [Лабораторная работа №4](https://drive.google.com/file/d/1DpZU8VfQ2dDqCWErH71tgsequ3VIK-7b/view?usp=sharing)
- Необходимо установить MS SQL Server Express и Mannagment Studio (см. лабораторную работу №4)
- Склонировать проект
- Переключиться на ветку `main-lab4`. Команда `git checkout main-lab4`
- Создать ветку `git checkout -b имя_фамилия_lab4_pi_2_20` подробно про ветки в git, читай [здесь](https://git-scm.com/book/ru/v2/%D0%92%D0%B5%D1%82%D0%B2%D0%BB%D0%B5%D0%BD%D0%B8%D0%B5-%D0%B2-Git-%D0%9E-%D0%B2%D0%B5%D1%82%D0%B2%D0%BB%D0%B5%D0%BD%D0%B8%D0%B8-%D0%B2-%D0%B4%D0%B2%D1%83%D1%85-%D1%81%D0%BB%D0%BE%D0%B2%D0%B0%D1%85). Имя и фамилию вводим на англ. языке
- В Диспетчере пакетов NuGet, необходимо выполнить следующие команды:
  - `Install-Package Microsoft.EntityFrameworkCore.SqlServer` - установка пакета библиотек для работы  с MS SQL Server
  - `Install-Package Microsoft.EntityFrameworkCore.Tools` - установка инструментов Entity Framework
- Изменить строку подключения к БД в файле `EatAndDrinkDbContext.cs` [вот в этой строчке](https://github.com/PI-2-20/EatAndDrink/blob/main-lab4/src/Models/EatAndDrinkDbContext.cs#L17)
- В Диспетчере пакетов NuGet, необходимо выполнить следующие команды:
  - `Add-Migration MyInitial` - создание первой миграции
  - `Update-Database` - выполнение миграции и обновление БД (если при выполнении этой команды возникла ошибка, то это значит, что указано неверная строка подключения)
- Зафиксировать изменения в системе контроля версий (`git add -A`, `git commit -m 'сообщение'`)
- Запушить изменения в свою ветку `git push -u origin имя_фамилия_lab4_pi_2_20`

## Самостоятельно
- Добавить в класс `EatAndDrinkDbContext.cs` след. свойства:
  - `public DbSet<Client> Clients { get; set; }`
  - `public DbSet<Courier> Couriers { get; set; }`
  - `public DbSet<Dish> Dishes { get; set; }`
  - `public DbSet<Menu> Menus { get; set; }`
  - `public DbSet<Order> Orders { get; set; }`
  - `public DbSet<Restorant> Restorants { get; set; }`
 - Создать миграцию: `Add-Migration MySecondInitial`
 - Обновить БД: `Update-Database`
- Зафиксировать изменения в системе контроля версий (`git add -A`, `git commit -m 'сообщение'`)
- Запушить изменения в свою ветку `git push`

# Deadline! Задание необходимо выполнить до 01.03.2022
## Приемка лабораторной работы
- Корректно созданная ветка. Название ветки должно соответствовать формату `имя_фамилия_lab4_pi_2_20`
- Наличие в классе `EatAndDrinkDbContext.cs` вышеописанных свойтв
- Наличие миграций, создающие соответсвующщие таблицы
