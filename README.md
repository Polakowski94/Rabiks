# Rabiks
Aplikacja do rejestracji czasu pracy zdalnej - zadanie rekrutacyjne

Celem zadania było utworzenie prototypu aplikacji, która pozwoli na rejestrację czasu pracy zdalnej poprzez:
- Rozpoczęcie i zakończenie pracy
- Rozpoczęcie i zakończenie przerwy
- Zapis danych w bazie SQL

Wymagania funkcjonalne:
Rejestracja pracy zdalnej
- Pracownik może kliknąć "Start pracy", co zapisuje godzinę rozpoczęcia pracy - ZREALIZOWANE
- Pracownik może kliknąć "Stop pracy", co zapisuje godzinę rozpoczęcia pracy - ZREALIZOWANE
- Może wielokrotnie zaczynać i kończyć pracę w ciągu dnia - ZREALIZOWANE
Rejestracja przerw
- Pracownik może kliknąć "Start przerwy", co zapisuje godzinę rozpoczęcia przerwy - ZREALIZOWANE
- Pracownik może kliknąć "Stop przerwy", co zapisuje godzinę rozpoczęcia przerwy - ZREALIZOWANE
- Przerwa jest liczona jako czas pracy, ale w bazie danych powinna być zapisywana osobno - ZREALIZOWANE
- Przerwa działa niezależnie od pracy - ZREALIZOWANE

W pliku App.config można podmienić ścieżkę do bazy danych.

Udało się zrealizować wszystkie założenia. W niniejszym repozytorium znajduje się aplikacja, w osobnym pliku na maila podeślę plik z bazą danych.
W UI aplikacji znajdują się dwa gridy:
1. Pokazuje dzisiejszy dzień ze wszystkimi wystąpieniami pracy oraz przerwy, zasilany jest tabelami WorkRegistration oraz BreakRegistration
2. Pokazuje podsumowanie każdego dnia z osobna wraz z sumą czasu spędzonego na pracy, na przerwie oraz łącznie z uwzględnieniem nakładania się pracy i przerw (przerwy są traktowane jako czas pracy), zasilany jest widokiem WorkDaySummaryView

Osobno w mailu wysyłam bazę danych.
