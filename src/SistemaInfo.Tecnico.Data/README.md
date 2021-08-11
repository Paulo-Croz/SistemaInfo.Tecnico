# Camada de infraestrutura (acesso a dados)

Na camada de infraestrutura, parte de acesso a dados, deverá ser implementado os contratos dos repositórios criados na camada de domínio. Use esta camada para prover os dados que serão
utilizados na aplicação.

## Objetivo

- Implementar os repositórios necessários para a aplicação conforme seus respectivos contratos;
- Ler o arquivo Motoristas.csv fornecido no diretório deste projeto para disponibilizar os dados que serão manipulados conforme as regras de negócios descritas;
- Fique a vontade para decidir como o arquivo será lido.

## DICAS

- Lembre-se de criar o que for necessário para a injeção de dependência.
- Esta camada não deve ser acessada diretamente pela API, qualquer acesso a esta camada deve ser feita pela camada de aplicação ou camada de domínio.
- Você pode usar qualquer componente que seja necessário para a sua implementação funcionar desde que este componente possa ser instalável via Nuget e esteja disponível na web.



