// Console.WriteLine("Банковский счёт");

// double balance = 1000;
// Console.WriteLine($"Начальный баланс: {balance}");

// balance += 500; // пополнение
// Console.WriteLine($"После пополнения на 500: {balance}");

// balance -= 200; // покупка
// Console.WriteLine($"После покупки на 200: {balance}");

// balance *= 1.05; // начисление 5% процентов
// Console.WriteLine($"После начисления 5%: {balance}");

// balance /= 2; // разделили счёт пополам с партнёром
// Console.WriteLine($"После деления пополам: {balance}");


// Console.WriteLine();
// Console.WriteLine("Постфикс vs префикс");

// int lessonNumber = 1;
// Console.WriteLine($"lessonNumber++  выводит: {lessonNumber++}");
// Console.WriteLine($"После этого lessonNumber = {lessonNumber}");

// int weekNumber = 1;
// Console.WriteLine($"++weekNumber  выводит: {++weekNumber}");
// Console.WriteLine($"После этого weekNumber = {weekNumber}");

// Console.WriteLine();
// Console.WriteLine("Практическая ловушка");

// int attempts = 0;
// Console.WriteLine($"Попытка №{++attempts}");
// Console.WriteLine($"Попытка №{++attempts}");
// Console.WriteLine($"Всего попыток: {attempts}");


// Console.WriteLine();
// Console.WriteLine("Операторы сравнения");

// double myGrade = 4.6;
// double passingGrade = 4.0;
// int myAge = 20;
// int votingAge = 18;
// bool isPassing = myGrade >= passingGrade;
// bool isExactAge = myAge == votingAge;
// bool canVote = myAge >= votingAge;
// bool isNotFailing = myGrade != 2.0;

// Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
// Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
// Console.WriteLine($"Возраст {myAge} >= {votingAge} (может голосовать): {canVote}");
// Console.WriteLine($"Балл {myGrade} != 2.0 (не двойка): {isNotFailing}");


// Console.WriteLine();
// Console.WriteLine("Логические операторы");

// bool hasPassingGrade = true;
// bool hasAttendance = false;
// bool hasDebt = true;

// bool canGetScholarship = hasPassingGrade && hasAttendance;
// bool canRetakeExam = hasPassingGrade || hasAttendance;
// bool isDebtFree = !hasDebt;

// Console.WriteLine($"Может получить стипендию (оценка И посещаемость): {canGetScholarship}");
// Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canRetakeExam}");
// Console.WriteLine($"Нет долгов: {isDebtFree}");


// Console.WriteLine();
// Console.WriteLine("Короткое замыкание");

// bool CheckAndPrint(string label, bool value) {
//     Console.WriteLine($"  Вычисляется: {label}");
//     return value;
// }

// Console.WriteLine("Проверяем && (первый операнд false):");
// bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
// Console.WriteLine($"Результат: {resultAnd}");

// Console.WriteLine();
// Console.WriteLine("Проверяем || (первый операнд true):");
// bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
// Console.WriteLine($"Результат: {resultOr}");


// Console.WriteLine();
// Console.WriteLine("Приоритет операций");

// int resultNoParens = 2 + 3 * 4;
// int resultWithParens = (2 + 3) * 4;
// Console.WriteLine($"2 + 3 * 4        = {resultNoParens}");
// Console.WriteLine($"(2 + 3) * 4      = {resultWithParens}");

// bool logicResult = 5 > 3 && 2 < 4 || false;
// bool logicResultParens = (5 > 3 && 2 < 4) || false;
// Console.WriteLine($"5>3 && 2<4 || false    = {logicResult}");
// Console.WriteLine($"(5>3 && 2<4) || false  = {logicResultParens}");


// Console.WriteLine();
// Console.WriteLine("Приёмная комиссия");

// Console.Write("Введите средний балл аттестата: ");
// double averageGrade = double.Parse(Console.ReadLine());

// Console.Write("Введите баллы за экзамен (0-100): ");
// int examScore = int.Parse(Console.ReadLine());

// Console.Write("Есть льгота? (1 - да, 0 - нет): ");
// int benefitInput = int.Parse(Console.ReadLine());
// bool hasBenefit = (benefitInput == 1);

// // TODO 1
// bool hasGoodCertificate = averageGrade >= 4.0;

// // TODO 2
// bool hasGoodExam = examScore >= 60;

// // TODO 3
// bool isEligibleByRules = (hasGoodCertificate && hasGoodExam) || hasBenefit;

// // TODO 4
// double totalScore = averageGrade * 10;
// totalScore += examScore;

// Console.WriteLine();
// Console.WriteLine("Результат");
// Console.WriteLine($"Хороший аттестат (>= 4.0): {hasGoodCertificate}");
// Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
// Console.WriteLine($"Льгота: {hasBenefit}");
// Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
// Console.WriteLine($"Итоговый балл: {totalScore}");

// //Задание 1. Чётное или нечётное—без if ★
// Console.WriteLine();
// Console.WriteLine("Задание 1. Чётное или нечётное");

// Console.Write("Введите целое число: ");
// int number = int.Parse(Console.ReadLine());

// bool isEven = number % 2 == 0;
// Console.WriteLine($"Число {number} чётное: {isEven}");


// Console.WriteLine();
// Console.WriteLine("Задание 2. Инкремент в выражении");

// // Место 1: присваивание
// int a = 0;
// int idPost = a++; // постфикс: сначала берётся старое значение 0, потом a становится 1
// int b = 0;
// int idPre = ++b;  // префикс: сначала b становится 1, потом берётся значение 1
// Console.WriteLine($"Место 1: {idPost} и {idPre}");

// // Место 2: арифметика
// int x = 5;
// int sumPost = 1000 + x++; // 1000 + 5 = 1005, x станет 6 только после
// int y = 5;
// int sumPre = 1000 + ++y;  // y сразу 6, поэтому 1000 + 6 = 1006
// Console.WriteLine($"Место 2: {sumPost} и {sumPre}");

// // Место 3: условие
// int p = 2;
// bool okPost = p++ < 3; // сравнивается старое 2 < 3, True
// int q = 2;
// bool okPre = ++q < 3;  // сначала q = 3, потом 3 < 3, False
// Console.WriteLine($"Место 3: {okPost} и {okPre}");


//задание 3
Console.WriteLine();
Console.WriteLine("Задание 3. Калькулятор скидки");

Console.Write("Введите сумму покупки: ");
double purchaseSum = double.Parse(Console.ReadLine());

Console.Write("Есть карта постоянного клиента? (1 - да, 0 - нет): ");
int cardInput = int.Parse(Console.ReadLine());
bool hasCard = (cardInput == 1);

Console.Write("Введите количество товаров в чеке: ");
int itemsCount = int.Parse(Console.ReadLine());

bool enoughSum = purchaseSum >= 3000;
bool enoughItems = itemsCount >= 3;
bool bigPurchase = enoughSum && enoughItems;
bool eligibleForDiscount = bigPurchase || hasCard;

Console.WriteLine();
Console.WriteLine($"Сумма >= 3000: {enoughSum}");
Console.WriteLine($"Товаров >= 3: {enoughItems}");
Console.WriteLine($"Сумма >= 3000 И товаров >= 3: {bigPurchase}");
Console.WriteLine($"Есть карта: {hasCard}");
Console.WriteLine($"Скидка положена: {eligibleForDiscount}");