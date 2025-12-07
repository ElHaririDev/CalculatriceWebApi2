# Calculatrice Web API (.NET)

Cette API web permet de calculer la somme de deux nombres (a + b) via un endpoint simple.

## ⚙️ Fonctionnalités

- Addition de deux nombres entiers.  
- Architecture propre : séparation entre la logique métier (Service) et l’API (Controller).  
- Test facile des endpoints avec Swagger / OpenAPI.  

## 🧱 Structure du projet

Calculatrice/
│
├── Controllers/
│ └── CalculatorController.cs
│
├── Services/
│ └── CalculatorService.cs
│
├── Program.cs
├── launchSettings.json
└── README.md

## 🚀 Installation & exécution

1. Cloner le dépôt :  
   ```bash
2.Restaurer les dépendances :

dotnet restore


3.Lancer l’application :

dotnet run
L’API sera disponible à l’adresse :

HTTP : http://localhost:5185

HTTPS : https://localhost:7173
🧪 Tester l’API

Ouvre Swagger dans ton navigateur :

https://localhost:7173/swagger
Tu y trouveras l’endpoint suivant :

GET /api/calculator/add?a=5&b=3
| Requête          | Résultat                     |
| ---------------- | ---------------------------- |
| `a = 5`, `b = 3` | `{"a":5, "b":3, "result":8}` |

📄 Endpoint disponible
GET /api/calculator/add

Paramètres de query

a : int — premier nombre

b : int — deuxième nombre

Retourne :

{
  "a": 5,
  "b": 3,
  "result": 8
}

👤 Auteur

Projet développé par Abdelmajid EL HARIRI.

📝 Licence

Ce projet est libre d’utilisation pour l’apprentissage et l’expérimentation.


---

Si tu veux — je peux aussi préparer **un `.gitignore`** pour ton projet, pour t’assurer que les fichiers temporaires/ binaires ne sont pas poussés sur GitHub (meilleur bonne pratique). Veux‑tu que je le crée pour toi ?
::contentReference[oaicite:1]{index=1}


   git clone https://github.com/ElHaririDev/CalculatriceWebApi.git
   cd CalculatriceWebApi
