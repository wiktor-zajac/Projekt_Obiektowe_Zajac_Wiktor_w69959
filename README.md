English README: Comming soon!

Aby uruchomić program należy przejść pod adres: `https://127.0.0.1:7199/swagger/`.

Aby uzyskać dostęp do zastrzeżonych wyjść API, należy się wpierw zarejestrować się używając `/api/Authentication/Register`, kolejno zalogować się używając `/api/Authentication/Login`, czego wynikiem będzie zwrócenie JSON Web Token. W aplikacji Swagger należy znaleźć przycisk **Authorize** i wprowadzić `Bearer`, znak spacji i swój token i nacisnąć przycisk Authorize.

`/WeatherForecast` i `/RestrictedWeatherForecast` to standardowe wyjścia tworzone przy tworzeniu projektu APS.NET API. Pierwszy jest dostępu ogólnego, gdzie do drugiego mają dostęp tylko osoby zalogowane (z prawidlowym i ważnym tokenem JWT).

Endpointy `/api/Pages` i `/api/Pages/{guid}` wymagają bycia zalogowanym i umożliwiają pełny zakres operacji CRUD na obiektach w bazie danych.

Jest to aplikacja .NET wykorzystująca taakie rozwiązania jak EntityFramework Core, JWT, Docker, AutoMapper, CQRS (MediatR) i Sqlite.

Zastosowano tutaj liczne interfejsy, operacje CRUD na obiektach, walidację danych i obsługę błędów.

Działanie w kontenerze nie było do końca testowane, zalecam uruchomienie programu lokalnie
