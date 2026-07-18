# Exkyn.Notifications

![NuGet Version](https://img.shields.io/nuget/v/Exkyn.Notifications?style=flat-square&color=blue) 
![Build Status](https://github.com/dmodesigner/Exkyn.Notifications/actions/workflows/PublishExkynNotifications.yml/badge.svg) 
![License](https://img.shields.io/github/license/dmodesigner/Exkyn.Notifications?style=flat-square&color=green)

> ⚠️ **Importante:** Este é um pacote base compartilhado (Core/Shared). Ele **não deve** ser instalado diretamente em projetos finais, pois não contém as implementações de envio.

O **Exkyn.Notifications** fornece as abstrações, interfaces, modelos de dados e contratos comuns necessários para padronizar o envio de notificações dentro do ecossistema Exkyn.

## 🚀 Implementações Oficiais

Para enviar mensagens na sua aplicação, instale o pacote correspondente ao canal desejado. As bibliotecas abaixo já dependem deste núcleo automaticamente:

*   **[Exkyn.Notifications.Email](https://nuget.org/packages/Exkyn.Notifications.Email):** Implementação para disparo de e-mails, configurável nativamente via injeção de dependência.
*   **[Exkyn.Notifications.Whatsapp](https://nuget.org/packages/Exkyn.Notifications.Whatsapp):** Implementação focada na integração e envio de mensagens via WhatsApp. [Em breve]

## 📖 Arquitetura e Objetivo

Manter um pacote base isolado garante que:
1.  As aplicações consumam apenas as dependências do canal de notificação que realmente utilizam (evitando inchar o projeto com bibliotecas de e-mail se ele só usa WhatsApp, por exemplo).
2.  Novos canais de comunicação possam ser adicionados no futuro (ex: SMS, Push Notifications) mantendo a mesma interface e padrão arquitetural.
3.  A injeção de dependência siga o mesmo padrão em todo o ecossistema.

## 🤝 Como Contribuir

Se você deseja sugerir novos contratos, alterar interfaces ou melhorar os modelos base:

1. Faça um Fork do projeto
2. Crie sua Feature Branch (`git checkout -b feature/NovaInterface`)
3. Faça o Commit de suas alterações (`git commit -m 'Adicionando contrato para envio em massa'`)
4. Faça o Push para a Branch (`git push origin feature/NovaInterface`)
5. Abra um Pull Request

## 📄 Licença

Este projeto está sob a licença **MIT**. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---
**Desenvolvido por Daniel Moura**  
🔗 [Conecte-se comigo no LinkedIn](https://www.linkedin.com/in/danieldmo)