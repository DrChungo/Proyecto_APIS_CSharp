
 Programa que permite realizar una busqueda de un anime y saber la información de este.
 
#  Cómo Ejecutar
Tienes que tener descargado .NET .Descarga el prorama en un zip, descomprimelo donde desees.
Una vez echo esto haz click derecho y abrir en una terminal. Al abrirse la terminal escribe dotnet run
una vez echo esto deberia de funcionar. Acontinuacion tienes un ejemplo


<img width="994" height="413" alt="Captura de pantalla 2025-11-21 190057" src="https://github.com/user-attachments/assets/83dd4322-b45a-4cfc-9b4e-70de43b4eb88" />

---------------------------------------
# Estructura del Proyecto 
/Models
    AnimeResponse.cs
    AnimeData.cs
    CharacterResponse.cs
    CharacterData.cs
    ItemInfo.cs
    Person.cs
    VoiceActor.cs

/Validations
    Validation.cs
    ValidationString.cs
    ValidationNumber.cs
    ValidationOption.cs

/Functions
    GetJson.cs
    Show.cs
    BasicInfo.cs
    Synopsis.cs
    Genre.cs
    Characters.cs

Program.cs

---------------------------------------
#  API Utilizada
Jikan API

Permite acceder a información de MyAnimeList:

- Animes

- Personajes

- Géneros

- Staff
>Documentación oficial: https://docs.api.jikan.moe

--------------------------------------
#  Tecnologías Utilizadas

- C#

- .NET

- System.Net.Http para solicitudes HTTP

- System.Text.Json para deserializar JSON

- Async/Await


---------------------------------------

# Funcionalidades principales

Buscar cualquier anime escribiendo su nombre.

- Mostrar:

- Información básica (título japonés, ranking, episodios, estado…)

- Sinopsis completa

- Géneros del anime

- Primeros 20 personajes

- Información detallada de un personaje (rol + actores de voz)
  
----------------------------------------

Validaciones exhaustivas:

- Strings vacíos

- Números inválidos

- Datos nulos desde la API
  
----------------------------------------

Sistema modular dividido en:

- Validaciones

- Modelos

- Funciones de visualización

----------------------------------------

# Explicacion de cada funcion
 
Main()

Inicia el programa, pide el nombre del anime, consulta la API, valida los datos obtenidos y abre el menú principal con las opciones relacionadas al anime.

-----------------------------
 # Functions
 
GetJsonAsync(url)

- Realiza una petición HTTP a la URL indicada, obtiene el JSON y lo convierte al tipo solicitado (deserializa).

ShowOptionsAsync(anime, name, id)

- Muestra un menú interactivo que permite consultar la información del anime. Ejecuta la acción correspondiente según la opción elegida por el usuario.

GetBasicInfo(anime, name)

- Muestra información básica del anime:

- Título japonés

- Ranking

- Número de episodios

- Estado (en emisión, finalizado, etc.)

GetSynopsis(anime, name)
- Muestra la sinopsis completa del anime.

GetGenre(anime, name)
- Lista todos los géneros asociados al anime (acción, comedia, drama, etc.).

GetCharactersAsync(name, id)

- Obtiene los personajes del anime desde la API.

- Muestra los primeros 20 personajes.

- Pregunta si quieres consultar la información de uno en concreto.

- Si dices que sí, permite buscarlo por nombre y muestra:

- Su rol en el anime

- Los actores de voz (nombre e idioma)
---------------------------------------
 # VALIDATIONS

  
IsValid(…)

- Conjunto de validaciones que comprueban:

- Si las respuestas de la API contienen datos

- Si cadenas de texto no están vacías

- Si números son válidos

- Si objetos contienen información esencial

AskForNumber(input)

- Comprueba si el usuario ingresó un número válido.

- Si no lo hace, vuelve a pedirlo hasta que lo ingrese correctamente.

AskForOption(input)

- Valida opciones tipo s/n.

- Si no es válido, se vuelve a pedir.

AskForString(input)

- Valida que el texto ingresado: No esté vacío ,no sea un número, si no cumple, también se vuelve a pedir.

---------------------------------------------

 # MODELS
 
AnimeResponse / AnimeData

- Modelos que representan toda la información de un anime: títulos, géneros, episodios, ranking, sinopsis, estado, etc.

CharacterResponse / CharacterData

- Modelos con la información de los personajes del anime y su rol.

-----------------------------------

Character

- Datos básicos del personaje (ID, nombre, URL).

VoiceActor

- Datos del actor de voz que interpreta al personaje (nombre + idioma).

Person

- Información general de un actor de voz registrado en MyAnimeList.

ItemInfo

- Estructura usada para géneros, estudios, productores, licencias y categorías similares.




