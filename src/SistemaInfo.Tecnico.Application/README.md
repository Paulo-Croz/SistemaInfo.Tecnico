# Camada de aplicação

A camada de aplicação é responsável por implementar os serviços para orquestrar as chamadas que são realizadas nas outras camadas. Lembre-se, nesta camada não se deve ter regras de negócio, pois
elas estão centralizadas no domínio.

## Objetivo

- Implementar os serviços que realizarão chamadas nas outras camadas;
- Implementar as 'ViewModels' para evitar referências circulares;
- Utilizar o Auto Mapper para realizar a transferência de dados entre entidades e view models.

## DICAS

- Utilize o Auto Mapper para realizar a transfêrencia de dados entre entidades de domínio e view models.
- Lembre-se de criar o que for necessário para a injeção de dependência.
- Esta camada deve ser acessada diretamente pela API para realizar a orquestração entre as outras camadas.
- Você pode usar qualquer componente que seja necessário para a sua implementação funcionar desde que este componente possa ser instalável via Nuget e esteja disponível na web.



