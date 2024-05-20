# Лабораторная работа №4: Создание диаграмм взаимодействия

## Описание классов
Игрок (Player) - Представляет участника игры.
Игра (Game) - Представляет игровую сессию.
Раунд (Round) - Представляет один раунд в рамках игры.
Ход (Turn) - Представляет один ход игрока в рамках раунда.
Бросок (Roll) - Представляет результат броска костей.

## Диаграмма взаимодействия для системной функции "Начать новую игру"
[![](https://mermaid.ink/img/pako:eNqVU8tuEzEU_RXrrlJpEmWSDk686KoIdUFBdIdmY2Zu0pHmETweShpFqmBZPoBN1X5CVBoJAaW_4Pkj7jivqRKk1ivf43OOj33tCQRZiCAgx48FpgEeRnKoZOIrP2U0RlLpKIhGMtXsbSzHqJjMmflufpQX5q_5tYv3SiZYY812cd5lRRpa0o2ZlV_NvbmraCuqDHT0SWpc7rmClwmaBwd2E8FONHke41lVNUZ29ZimDkuL5AOqN4OFIt_bMq4UazDWzFybOYWdmzszM_flJTNXVNxakEozZ-aBktJxzB8Cv5QX5eVKXw176GaVbLElZTvNzl4qlanXmOdyiA0fnuIJ66wY57gj14MV3Jqf5nf57RnZKJq9dcGO0khHMo7O0QKNIa0fHe7VJet7soz6yqJzzU0PLLCxDBvKAo_9Qvy_4_bVVYhtLW6Fw4225lnvZg3evB5wIEGVyCiktz6piD7oUyQVCJqGOJBFrH3w0ylRZaGzk3EagNCqQAeKUUh2y68BYiCpMw7QQ36fZY9qEBP4DMJ1ecv12v0u91yvx9sd7sAYBO-1uhXcc_e7XtfruFMHzq1Du8X3e7zv9vsvuNvxeNub_gM8cmhY?type=png)](https://mermaid.live/edit#pako:eNqVU8tuEzEU_RXrrlJpEmWSDk686KoIdUFBdIdmY2Zu0pHmETweShpFqmBZPoBN1X5CVBoJAaW_4Pkj7jivqRKk1ivf43OOj33tCQRZiCAgx48FpgEeRnKoZOIrP2U0RlLpKIhGMtXsbSzHqJjMmflufpQX5q_5tYv3SiZYY812cd5lRRpa0o2ZlV_NvbmraCuqDHT0SWpc7rmClwmaBwd2E8FONHke41lVNUZ29ZimDkuL5AOqN4OFIt_bMq4UazDWzFybOYWdmzszM_flJTNXVNxakEozZ-aBktJxzB8Cv5QX5eVKXw176GaVbLElZTvNzl4qlanXmOdyiA0fnuIJ66wY57gj14MV3Jqf5nf57RnZKJq9dcGO0khHMo7O0QKNIa0fHe7VJet7soz6yqJzzU0PLLCxDBvKAo_9Qvy_4_bVVYhtLW6Fw4225lnvZg3evB5wIEGVyCiktz6piD7oUyQVCJqGOJBFrH3w0ylRZaGzk3EagNCqQAeKUUh2y68BYiCpMw7QQ36fZY9qEBP4DMJ1ecv12v0u91yvx9sd7sAYBO-1uhXcc_e7XtfruFMHzq1Du8X3e7zv9vsvuNvxeNub_gM8cmhY)


--------------------------------------------------------------

| Операция | Предусловие | Постусловие |
| --- | --- | --- |
| StartNewGame() | Приложение готово к запуску | Начало игры |
| InvalidParameters() | Игрок не указывает свое имя или выбирает некорректное количество игроков | Ввод корректных параметров |

## Диаграмма взаимодействия для системной функции "Бросок костей"
![mermaid-diagram-2024-05-17-164231](https://github.com/monoisafourletterword/closesector/assets/107469981/be84800a-471d-4409-acaa-67a02c72b42e)


--------------------------------------------------------------

| Операция | Предусловие | Постусловие |
| --- | --- | --- |
| RollDice() | Игровая сессия начата | Совершен ход игрока |
| CloseTwoBoxesOnBoard() | Сумма выпавших чисел равна 9, 8 или 7 | Два номера закрыты на доске |
| InvalidParameters() | Обнаружение некорректных параметров | Игрок выбирает корректные номера для закрытия |

## Диаграмма взаимодействия для системной функции "Закрыть номера на доске"
![mermaid-diagram-2024-05-17-163954](https://github.com/monoisafourletterword/closesector/assets/107469981/e1c75d11-0537-4641-a9f6-1ba1edace5aa)


------------------------------------------------------------------------

| Операция | Предусловие | Постусловие |
| --- | --- | --- |
| CloseBoxesOnBoard() | Произведен бросок костей | Выполнены действия по закрытию номеров на игровой доске, игра завершается, если закрыт последний номер |
| InvalidParameters() | Обнаружение некорректных параметров | Игрок выбирает корректные номера для закрытия |

Диаграмма взаимодействия для системной функции "Завершение текущей игровой сессии"
![mermaid-diagram-2024-05-17-164028](https://github.com/monoisafourletterword/closesector/assets/107469981/fc3ce54a-392b-4911-87e7-ea9c61fb8f1b)


----------------------------------------------------------------------------------

| Операция | Предусловие | Постусловие |
| --- | --- | --- |
| EndCurrentGameSession() | Игровая сессия активна | Игровая сессия завершена |
| ContinueCurrentGameSession() | Игрок передумывает завершить игру | Игра продолжается |
