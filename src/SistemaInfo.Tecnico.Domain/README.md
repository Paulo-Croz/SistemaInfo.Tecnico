# Camada de domínio

A camada de domínio é responsável por centralizar todas as regras de negócio. Implemente nessa camada, suas entidades de domínio, contendo suas regras particulares. Crie 
também os contratos para a comunicação com a camada de infraestrutura, e caso necessário crie os contratos para a implementação dos seus serviços.

## Objetivo

- Implementar uma classe chamada Motorista.cs, contendo as propriedades, construtores e regras de negócio necessárias;
- Na classe motorista, a propriedade que representará o tipo de contrato, deverá ser uma enumeração com os seguintes itens:
	* Frota = 1;
	* Agregado = 2;
	* Terceiro = 3;
	
- Implementar os contratos para acesso a camada de infraestrutura.
- Caso necessário implemente os contratos para os serviços do domínio.

## DICAS

- Você pode fazer uso de uma API externa, site, serviço ou implementar o seu próprio algoritmo de cálculo de distância entre os pontos (latitude e longitude).
- Lembre-se de criar o que for necessário para a injeção de dependência na API.
- Você pode usar qualquer componente que seja necessário para a sua implementação funcionar desde que este componente possa ser instalável via Nuget e esteja disponível na web.
- Esta camada não deve ser acessada diretamente pela API, qualquer acesso a esta camada deve ser feita pela camada de aplicação.
- Quanto mais completa sua camada de domínio, com mapeamentos, validações e tratamentos de exceções, mais completo será o seu teste.



