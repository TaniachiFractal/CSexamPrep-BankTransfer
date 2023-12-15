# Банковский перевод

![Image alt](https://github.com/
![Image alt](https://github.com/
![Image alt](https://github.com/
![Image alt](https://github.com/


Разработать прикладное приложение с графическим интерфейсом. Приложение предназначено для заполнения упрощенного платежного поручения.

1. Автоматически формируемые реквизиты:
* А) Номер.
* Б) Дата.

2. Реквизиты, заполняемые пользователем:
* А) Плательщик (Произвольный текст).
* Б) Сумма (цифра - рубли, копейки)
* В) Банк плательщика (перечисление: {ПАО «Лучший банк», ПАО «Главный банк», ПАО «Замечательный банк»}
* Г) БИК (9 цифр)
* Д) ИНН (10 цифр – юрлицо, 12 цифр – предприниматель).
* Е) Банк получателя (перечисление, как для банка плательщика).
* Ж) Счет получателя (20 цифр).

3. Кнопки: «Отправить», «Отменить».
Любая кнопка запрашивает подтверждение действия.

4. Результатом работы программы должны стать:
	1) Кнопка «Отправить» (после подтверждения отправки):
		* А) Все поля становятся недоступными для внесения информации.
		* Б) Ниже кнопок «Отправить» и «Отмена» пользователю выводится сообщение о том, что его платежное поручение принято к исполнению и показываются все заполненные реквизиты.

	2) Кнопка «Отменить» (после подтверждения отмены) очищает заполненные пользователем поля.
