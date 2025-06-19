# Development Challenge Project

## Visão Geral
Este projeto tem como objetivo implementar uma aplicação para manipulação e visualização de formas geométricas, contemplando múltiplas camadas: camada de dados (Data), aplicação de console (Console), interface gráfica com Avalonia UI (Avalonia) e testes automatizados (Tests). Cada camada foi desenvolvida visando clareza, manutenibilidade e segregação de responsabilidades.

---

## 📁 Estrutura do Projeto

```
DevelopmentChallenge/
├── DevelopmentChallenge.Avalonia       # Projeto de UI com Avalonia
├── DevelopmentChallenge.Console        # Projeto console (alternativa headless / debug)
├── DevelopmentChallenge.Data           # Lógica de negócios e dados
├── DevelopmentChallenge.Data.Tests     # Testes unitários
├── DevelopmentChallenge.sln            # Solução principal
└── packages                            # Dependências NuGet restauradas
```
---

## Camada Data
- Definição da interface `IShape`, que serve como contrato para todas as formas geométricas.
- Implementação das classes concretas para as formas geométricas: `Square`, `Circle`, `Triangle`, `Rectangle` e `Trapezoid`.
- Cada forma implementa métodos para cálculo de área e perímetro, além de expor propriedades relevantes, incluindo o tipo da forma (`ShapeType`).
- `ShapeType` é um enum que categoriza as formas para facilitar agrupamentos e traduções.

---

## Aplicação Console
- Apresenta um relatório textual simples e direto das formas presentes.
- Realiza agrupamento das formas pelo tipo e apresenta quantidade, área total e perímetro total de cada grupo.
- Exibe o relatório em espanhol, com tradução dos nomes das formas.
- Código focado em legibilidade e funcionalidade simples, facilitando a execução e entendimento sem interface gráfica.

---

## Interface Gráfica Avalonia
- Implementação da `MainWindowViewModel` que organiza os dados em grupos para cada idioma (Espanhol, Inglês e Italiano).
- Cada grupo exibe nome da forma traduzido, quantidade, área total e perímetro total.
- Interface XAML estruturada para exibir relatórios separados para cada idioma com cabeçalhos claros e visualização gráfica das formas (retângulo, círculo, triângulo, trapézio, quadrado).
- Utilização de `ObservableCollection` para suportar binding dinâmico e notificações de alteração.
- Uso de conversor (`ShapeToVisibilityConverter`) para mostrar a forma geométrica correta visualmente, conforme o tipo.
- Código organizado para facilitar adição de novos idiomas e formas.

---

## Testes Automatizados
- Cobertura de testes para validar cálculos de área e perímetro de cada forma.
- Testes para garantir o correto agrupamento das formas e geração de relatórios.
- Verificação das traduções dos nomes das formas para cada idioma suportado.
- Testes organizados para garantir qualidade e estabilidade das funcionalidades.

---

## 🔧 Como Rodar

### Requisitos

- .NET 8 SDK
- Avalonia UI (restaurado via NuGet)

### Restaurar e Compilar

```bash
dotnet restore
dotnet build
```

### Rodar o Projeto Avalonia

```bash
dotnet run --project DevelopmentChallenge.Avalonia
```

### Rodar o Projeto Console

```bash
dotnet run --project DevelopmentChallenge.Console
```

### Rodar Testes

```bash
dotnet test DevelopmentChallenge.Data.Tests
```

---

## 🛠 Tecnologias Utilizadas

- Avalonia UI
- C# / .NET 8
- MVVM Pattern
- xUnit para testes
- CLI do .NET

---

## Considerações Finais
Este projeto foi desenvolvido com foco em modularidade e clareza. A separação entre dados, interface e testes facilita manutenção e expansão futura, como inclusão de novos idiomas, formas geométricas ou funcionalidades.

---

## ✍️ Autor
Taylan - Desenvolvedor de Software
taylanatreu@gmail.com
(47) 98805-2919