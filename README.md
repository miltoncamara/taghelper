# Tag Helpers in ASP.NET Core
Some basic examples of how to use Asp.Net Core TagHelpers.

## O que são Tag Helpers?
As Tag Helpers habilitam o código do lado do servidor para particpar na criação a renderização de elementos HTML em arquivos Razor. Por exemplo, a característica do `ImageTagHelper`pode adicionar uma número de versão ao nome de uma imagem. Sempre que a imagem muda, o servidor gera uma nova versão para a imagem, então o cliete fica garantido em receber a imagem atual. Existem muitos modelos de Tag Helpers para tarefas comuns, como criação de formulários, links, etc.

## O que os TagHelpers fornecem.
Uma experiência amigável no desenvolvimento de HTML, na maioria dos casos, as marcações Razor usam Tag Helpers como Html padrão. Desenvolvedores Front-End conseguem facilmente editar marcações Razor sem entender as sintaxes C#.

## Exemplo
No código do projeto em questão, criei duas TagHelpers que auxiliam na criação de link de e-mail e exibição de telefone formatado.
```html
<phone>11992116427</phone>
```

A TagHelper acima exibe o seguindo formato em HTML:
```html
<a href="tel:11992116427">(11) 99211-6427</a>
```
