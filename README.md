# LeoECS Lite Network
LeoECS Lite Network - легковесный ECS-фреймворк, основанный на структурах. С поддержкой сетевых операций через Mirror.

[![license](https://img.shields.io/badge/LICENSE-MIT-green.svg)](LICENSE)

## Содержание


### Features
* Leo Ecs Lite extension for Mirror Networking
* Code can be generated automatically when compiling

## Установка

### Требования
* Unity 2023.2 or higher

### Добавление в проект
1. Open the Package Manager from Window > Package Manager
2. "+" button > Add package from git URL
3. Enter the following to install
   * "com.leopotam.ecslite.network": "https://github.com/karim-dev-coder/ecs-lite-network.git"


or open Packages/manifest.json and add the following to the dependencies block.

```json
{
    "dependencies": {
		"com.leopotam.ecslite.network": "https://github.com/karim-dev-coder/ecs-lite-network.git",
    }
}
```

## Зависимости
Open Packages/manifest.json and add the following to the dependencies block.

```json
{
    "dependencies": {
		"com.leopotam.ecslite": "https://github.com/Leopotam/ecslite.git",
        "com.annulusgames.unity-codegen": "https://github.com/AnnulusGames/UnityCodeGen.git?path=/Assets/UnityCodeGen",
    }
}
```

## Как использовать

## Лицензия

[MIT License](LICENSE)