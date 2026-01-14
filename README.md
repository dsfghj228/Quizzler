**Quizzler** - приложение, где каждый зарегистрированный пользователь может создать квиз на основе банка вопросов и тем.

## Запуск проекта

Для запуска с помощью **Docker Compose** выполните команду:
```
docker compose up --build
```

После сборки документация **Swagger** будет доступна по адресу:
`http://localhost:8081/swagger/index.html`

Cам проект будет доступен по адресу:
`http://localhost:3000/`
## Технологии

- ASP.NET Core
- Entity Framework Core
- PostgreSQL
- MediatR (CQRS)
- FluentValidation
- Hangfire (фоновая обработка задач)
- Redis (Кэширование данных)
- Docker & Docker Compose
- React
- Typescript
- Tailwind Css
- Axios# Real-time-Multiplayer-Quiz