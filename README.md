***Projekt imageSharing ma w prosty sposób umożliwić użytkownikom przesyłanie zdjęć i dzielenie się z nimi z innymi użytkownikami również zdjęciami nsfw.***
## Założenia
### Języki programowania
1. C#
2. Python
3. HTML
4. Css + sass
5. JavaScript ==(Jak będzie potrzeba)==
### Frameworki
1. EntityFramework
2. Blazor
### Python 
1. Głównie do analizy kontentu nsfw ==(Coś się ogarnie)==
### Bazy Danych
1. PostgreSQL
## Funkcjonalność
### Ogólne 
1. Header
2. [[Logowanie i rejestracja]]
3. Wyszukiwarka 
4. Stopka
5. Opcja włączenie filtru nsfw
### Strona główna 
1.  Wyświetlanie najlepiej like'owanych zdjęć w tym tygodniu.
2. Wyświetlanie kategorii.
3. Sekcja więcej z automatycznym doładowywaniem w trakcie scrollowania w dół
4. powiadomienia
### Strona z zdjęciem
1. Lajki
2. Wyświetlanie tagów do zdjęcia
3. Autor zdjęcia
4. Mini profil autora
5. Więcej zdjęć autora
6. Więcej zdjęć z podobnymi tagami
7. komentarze
8. Reportowanie zdjęć
### Profil użytkownika
1. Nazwa użytkownika
2. Awatar
3. Zdjęcie w tle
4. Obserwatorzy
5. Obserwujący
6. Ilość lajków w sumie zdobytych przez użytkownika
7. Opis konta
8. Wyróżnione przez użytkownika
9. Kolekcje
10. Najpopularniejsze tagi używane przez użytkownika

### Uploadowanie zdjęć
1. Tytuł zdjęcia
2. Opis zdjęcia
3. Zdjęcie
4. Tagi do zdjęcia
5. Filtracja contentu nsfw po uplodowaniu, jesli zawiera  flaga true zostanie dodana do bazy danych.
6. Limity uploadu
### Strona wyszukiwarki
1. Opcję do wyboru czego chcemy szukać
   - Użytkowników
   - Zdjęć - opisu
   - Tagów
1. Opcję filtracji dla poszczególnej opcji
   - Użytkownicy
	   1. Ilość obserwujących
	   2. Ilość obserwowanych
	   3. Ilość lajków
	   4. Ilość dodanych zdjęć
   -    Zdjęcia 
	   1. Ilość like'ow
	   2. Rozdzielczości
	   3. Proporcji
   -  Tagi
	   1. Ilość zdjęc przypisanego do danego tagu
	   2. Ilość lajków przypisanego do danego tagu
1. Sortowanie rezultatów