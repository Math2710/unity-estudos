# Unity — Estudos e Exercícios

![Unity](https://img.shields.io/badge/Unity-6000.3-000000?style=flat-square&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white)
![URP](https://img.shields.io/badge/render%20pipeline-URP%202D-1D4ED8?style=flat-square)
![Curso](https://img.shields.io/badge/curso-Oficina%20Indie-FF6B00?style=flat-square)

Repositório com meus estudos de **desenvolvimento de jogos com Unity e C#**, acompanhando as aulas do curso **Oficina Indie**, do André Young. Cada pasta é um desafio proposto no curso, com sua própria cena e seu próprio script.

Todo o código é escrito à mão, sem assets de terceiros — o foco aqui é a base: o ciclo de vida do `MonoBehaviour`, variáveis expostas no Inspector e lógica de programação aplicada a situações de jogo (vida, dano, inimigos, runas).

## Tecnologias

- Unity 6 (`6000.3.23f1`)
- C# — scripts de `MonoBehaviour`
- Universal Render Pipeline (template Universal 2D)

## Como rodar

1. Clone o repositório:

   ```bash
   git clone https://github.com/Math2710/unity-estudos.git
   ```

2. Abra a pasta pelo **Unity Hub**, usando a versão `6000.3.23f1`.
3. No painel *Project*, abra a cena do desafio que quiser executar — por exemplo, `Assets/Desafio_2/Desafio_2.unity`.
4. Aperte **Play** e acompanhe o resultado na janela **Console**.

Os valores de cada desafio (vida, dano, runa, nomes dos jogadores...) são campos públicos: dá para alterá-los direto no **Inspector**, sem mexer no código, e rodar de novo para ver o resultado mudar.

## Estrutura

Os desafios estão na ordem em que foram propostos no curso:

| Desafio | Tópico |
| --- | --- |
| [`Desafio_1/`](Assets/Desafio_1/) | Variáveis e operadores aritméticos — cálculo de vida restante a partir do dano recebido, com saída via `Debug.Log` |
| [`Desafio_2/`](Assets/Desafio_2/) | Estruturas de decisão `if` / `else if` / `else` com o operador `&&` — descobrir qual inimigo tem o maior dano |
| [`Desafio_3/`](Assets/Desafio_3/) | Operador lógico `\|\|` — verificar se a runa sorteada é uma vogal e decidir entre magia de cura ou de ataque |
| [`Desafio_4/`](Assets/Desafio_4/) | Condicionais compostas combinando `&&` e `\|\|` — classificar uma runa triangular em perfeita, balanceada ou instável |
| [`Desafio_5/`](Assets/Desafio_5/) | Condicionais aninhadas e operador de resto `%` — jogo de par ou ímpar entre dois jogadores |

Dentro de cada pasta:

- `Desafio_N.unity` — a cena do desafio, com o script já anexado a um GameObject
- `Desafio_N.cs` — o script do desafio, com a lógica dentro de `Start()`

## Convenções

- **Uma pasta por desafio**, numerada na ordem das aulas, mantendo cena e script juntos.
- **Classes e arquivos** em `PascalCase`, com o nome do arquivo sempre igual ao da classe — exigência do Unity para que o script possa ser anexado a um GameObject.
- Os valores de entrada ficam em **campos públicos**, para poderem ser ajustados pelo Inspector sem recompilar.
- A lógica dos exercícios roda em `Start()`, já que são desafios de execução única, e não de atualização por frame.
- Os arquivos `.meta` são versionados junto com os assets — é o que preserva as referências entre cenas e scripts. As pastas `Library/`, `Temp/`, `Logs/` e `UserSettings/` são geradas pelo Unity e ficam fora do controle de versão.

## Outros repositórios de estudo

| Repositório | Conteúdo |
| --- | --- |
| [csharp-estudos](https://github.com/Math2710/csharp-estudos) | Fundamentos de C# e .NET |
| [java-estudos](https://github.com/Math2710/java-estudos) | Fundamentos de Java e orientação a objetos |
| [python-estudos](https://github.com/Math2710/python-estudos) | Fundamentos de Python — tipos, operadores e laços |
| [html-estudos](https://github.com/Math2710/html-estudos) | HTML5 semântico — estrutura, tabelas, formulários e mídia |
| [css-estudos](https://github.com/Math2710/css-estudos) | CSS — cores, tipografia, layout e componentes |

## Autor

**Matheus Westphal** — estudante de Engenharia de Software, em formação para desenvolvimento back-end com Java, Spring e SQL.

[![LinkedIn](https://img.shields.io/badge/LinkedIn-matheus--westphal-0A66C2?style=flat-square&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/matheus-westphal-65a264201)
[![GitHub](https://img.shields.io/badge/GitHub-Math2710-181717?style=flat-square&logo=github&logoColor=white)](https://github.com/Math2710)

---

Repositório em constante atualização, conforme avanço nas aulas.
