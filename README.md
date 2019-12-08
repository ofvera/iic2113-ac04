# iic2113-ac04

## Integrantes
    - Octavio Vera 
    - Gabriel Lyon 

## Modelamiento

Para modelamiento del problema se intentó modificar lo menos posible
la clase `CurrencyExchange` y las clases hijas `Exchange1` y `Exchange2`.

En la primera imagen, se muestra un diagrama UML de estas clases.
    1. Se agregó una las tasas como atributos de las clases (_rates_).
    2. Se modificó el método `Exchange(Currency from, String to)`, cambiando el segundo
    por un _Visitor_ (`IConvertor convertorCurrency`).

![][CurrencyExchangeModeling.jpeg]

En la segunda image, se muestra el diagrama UML para el modelamiento de un _Visitor_. Para 
esto se creó una interfaz con dos métodos: `ConvertForExchange1` y `ConvertForExchange2` de esta 
manera cada clase concreta (las clases `Exchange_i` en este caso) tienen un método propio asociado 
a cada operación que se debe hacer. En este caso y como estaba modelado, se requería poder 
hacer transformaciones, según cada casa de cambio, para las siguientes monedas: Euro, Dolar y Pesos. 
Por lo que, se implemento los siguientes "convertidores" (_Visitors_):
    1. `ConvertPesoDolar`
    2. `ConverDolarPeso`
    3. `ConvertPesoEuro`
    4. `ConvertEuroPeso`
    5. `ConvertDolarEuro`
    6. `ConvertEuroDolar`

Con estos visitors, se puede modelar con un solo método `Exchange` en las sub clases `Exchange_i` 
entregado el "convertidor" correspondiente.

![][IConvertorModeling.jpeg]

Finalmente, se adjunta el diagrama de el patrón de manera genérica recuperado de 
[aquí](https://refactoring.guru/design-patterns/visitor). Este se ocupó de día al igual que 
el del vídeo recomendado por el profesor.
![][VisitorPatternDiagram]

## Estructura del Código

En el archivo `ICurrencyConvertor.cs` está la **interfaz** `IConvertor`, y en el archivo 
`Convertors.cs` están las clases que implementan la interfaz (_Visitors_).

El archivo `CurrencyExchange.cs`, `Exchange1.cs` y `Exchange2.cs` se modificó según lo descrito 
anteriormente. 

Adicionalmente, se agregó un archivo `ExchangerApp` en una versión estilo Introducción a la Programación 
pero que permite ver el correcto funcionamiento del patrón. 

## Conclusiones

Con el patrón implementado se puede agregar nuevas monedas de manera muy sencilla y sin que el 
cliente se de cuenta. Si se agregara una nueva moneda, por ejemplo Rupias, se debe agregar 6 nuevas 
clases que implementen la interfaz `IConvertor` y las clases `Exchange_i` no se "enteraría". De manera 
similar, si se desea agregar nuevas Casas de cambios digamos `Exchange3`, solo se debe agregar un método 
extra en la interfaz: `IConvertor.ConvertForExchange3`.

Nótese, que en esta solución ocurre la **particularidad** de que los métodos `ConvertForExchange1` y 
`ConvertForExchange2` ejecutan las mismas acciones para las clases `Exchange1` y `Exchange2` respectivamente. 
Sin embargo, esto es mera casualidad, ya que si ahora se quisiera cambiar la forma en que una de las casas 
de cambio calcula su `Exchange` se podría implementar en el método correspondiente asociada a esta. Por 
ejemplo: si la casa de cambio 2 (`Exchange2`) ahora agrega porcentaje de la transacción, se puede implentar 
sin afectar el funcionamiento de `Exchange1`.