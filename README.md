# iProspect TestApp
#### Тестовое задание для разработчика
Дописать консольное приложение для преобразования файла из формата `.csv` в формат `.yml`.

#### Входные данные
Товарный каталог в формате `.csv` c разделителем `;` и следующими заголовками:

| guid | title | price | description | img | availability |
|------|-------|-------|-------------|-----|--------------|

[Пример](https://raw.githubusercontent.com/iProspect-Russia/TestApp/master/data/amazon_product_info_sample_modified.csv)

#### Выходные данные
Файл  в формате `.xml`, соответствующий XML Schema [Yandex Market Language](https://yandex.ru/support/partnermarket/export/yml.html)
- [Необязательные элементы, которые относятся к информации о магазине](https://yandex.ru/support/partnermarket/elements/shop.html), игнорировать. Для обязательных использовать произвольные значения.
- [Валюта](https://yandex.ru/support/partnermarket/elements/currencies.html) одна: RUR
- [Категория](https://yandex.ru/support/partnermarket/elements/categories.html) одна: `<category id="1">Электроника</category>`
- [Для предложений](https://yandex.ru/support/partnermarket/offers.html) заполнить следующие элементы:
    - id
    - name
    - url
    - price
    - currencyId
    - categoryId
    - picture
    - available
    - description

[Пример](https://download.cdn.yandex.net/from/yandex.ru/support/ru/partnermarket/files/yml-simplified.zip)

#### Будет дополнительным плюсом
- Реализовать получение файла по сети
- Написать юнит-тесты

#### Полезные ссылки:
- [Валидатор XML-фидов от  Яндекса](https://webmaster.yandex.ru/tools/xml-validator/)

#### Структура репозитория:

| Папка    | Описание               |
| ---      | ---                    |
| `/data`  | Примеры входных данных |
| `/src`   | Исходники              |
| `/tests` | Юнит-тесты             |