Изменения:

	Создан интерфейс IPlayer. Это позволяет нам легко изменять реализацию игрока, не изменяя код, который зависит от него.
 
	Класс Player реализует интерфейс IPlayer, что делает его более гибким и тестируемым. 
 	Теперь он отвечает только за хранение данных игрока, а не за создание экземпляра самого себя.
 
	Используем Zenject для управления зависимостями. Это позволяет нам инжектировать зависимости в классы, 
 	такие как Controller, без необходимости создавать их вручную.

Преимущества нового кода:

	Гибкость: Мы можем легко изменять реализацию игрока, не изменяя код, который зависит от него.
 
	Тестируемость: Мы можем легко тестировать классы, использующие IPlayer.
 
	Расширяемость: Мы можем добавлять новые функции и зависимости, не изменяя существующий код.

Использование DI через Zenject гарантирует, что будет создан только один экземпляр класса Player, так как мы регистрируем его как AsSingle(). 
Это предотвращает создание нескольких экземпляров и гарантирует уникальность данных игрока.

Добавлены параметры экипировки в класс Player, и теперь их можно задавать в рантайме через DI. Это позволяет нам легко изменять экипировку игрока в зависимости от контекста.
