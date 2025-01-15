English README: Comming soon!

Aby uruchomi� program nale�y przej�� pod adres: `https://127.0.0.1:7199/swagger/`.

Aby uzyska� dost�p do zastrze�onych wyj�� API, nale�y si� wpierw zarejestrowa� si� u�ywaj�c `/api/Authentication/Register`, kolejno zalogowa� si� u�ywaj�c `/api/Authentication/Login`, czego wynikiem b�dzie zwr�cenie JSON Web Token. W aplikacji Swagger nale�y znale�� przycisk **Authorize** i wprowadzi� `Bearer`, znak spacji i sw�j token i nacisn�� przycisk Authorize.

`/WeatherForecast` i `/RestrictedWeatherForecast` to standardowe wyj�cia tworzone przy tworzeniu projektu APS.NET API. Pierwszy jest dost�pu og�lnego, gdzie do drugiego maj� dost�p tylko osoby zalogowane (z prawidlowym i wa�nym tokenem JWT).

Endpointy `/api/Pages` i `/api/Pages/{guid}` wymagaj� bycia zalogowanym i umo�liwiaj� pe�ny zakres operacji CRUD na obiektach w bazie danych.

Jest to aplikacja .NET wykorzystuj�ca taakie rozwi�zania jak EntityFramework Core, JWT, Docker, AutoMapper, CQRS (MediatR) i Sqlite.

Zastosowano tutaj liczne interfejsy, operacje CRUD na obiektach, walidacj� danych i obs�ug� b��d�w.
