# nUnitTestProject
# NumberCompressor

Консольное приложение на C#, которое сжимает массив чисел, удаляя последовательные дубликаты.

## Запуск проекта

1. **Клонировать репозиторий**
```bash
git clone <url-репозитория>
cd NumberCompressor
```
   
2. Собрать проект
```bash
dotnet build
```

3. Запустить
```bash
dotnet run --project NumberCompressor
```

4. Запуск тестов
Проект использует NUnit для модульного тестирования.
```bash
dotnet test NumberCompressor.Tests
```

Или из корня решения:
```bash
dotnet test
```
Требования: <br>
.NET SDK (версия 6.0 или выше)
