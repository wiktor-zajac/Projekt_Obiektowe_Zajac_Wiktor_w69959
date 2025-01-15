English README: Comming soon!

Aby uruchomiæ program nale¿y przejœæ pod adres: `https://127.0.0.1:7199/swagger/`.

Aby uzyskaæ dostêp do zastrze¿onych wyjœæ API, nale¿y siê wpierw zarejestrowaæ siê u¿ywaj¹c `/api/Authentication/Register`, kolejno zalogowaæ siê u¿ywaj¹c `/api/Authentication/Login`, czego wynikiem bêdzie zwrócenie JSON Web Token. W aplikacji Swagger nale¿y znaleŸæ przycisk **Authorize** i wprowadziæ `Bearer`, znak spacji i swój token i nacisn¹æ przycisk Authorize.

`/WeatherForecast` i `/RestrictedWeatherForecast` to standardowe wyjœcia tworzone przy tworzeniu projektu APS.NET API. Pierwszy jest dostêpu ogólnego, gdzie do drugiego maj¹ dostêp tylko osoby zalogowane (z prawidlowym i wa¿nym tokenem JWT).

Endpointy `/api/Pages` i `/api/Pages/{guid}` wymagaj¹ bycia zalogowanym i umo¿liwiaj¹ pe³ny zakres operacji CRUD na obiektach w bazie danych.

Jest to aplikacja .NET wykorzystuj¹ca taakie rozwi¹zania jak EntityFramework Core, JWT, Docker, AutoMapper, CQRS (MediatR) i Sqlite.

Zastosowano tutaj liczne interfejsy, operacje CRUD na obiektach, walidacjê danych i obs³ugê b³êdów.
