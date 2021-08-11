# Camada de apresentação

A camada de ampresentação é responsável por expor o todo o conteúdo processado nas camadas inferiores da aplicação. Esta camada pode ser usada para implementação de API`s,
projetos Web, projetos Desktop entre outros.

## Objetivo

- Implemente um método acessível pelo verbo GET para exibir o resultado processado dentro da aplicação;
- Este método, deve ter como entrada três parâmetros, sendo eles: latitude, longitude, quantidadeRegistros;
- A latitude e longitude representa as coordenadas para buscar o motorista mais próximo dela, a quantidadeRegistros representa a quantidade de motoristas que serão buscados.
- Retorne um objeto onde tenha o nome do motorista, a cidade onde ele se encontra, sua nota, e seu tipo de contrato conforme o exemplo a seguir:


[
	{
		"Nome": "Motorista 1",
		"Cidade": "Criciúma",
		"Nota": 10,
		"TipoContrato": "Frota"
	}, {
		"Nome": "Motorista 1",
		"Cidade": "Criciúma",
		"Nota": 10,
		"TipoContrato": "Frota"
	}
]


## DICAS

- Crie uma ViewModel para realizar a saída dos dados.
- Retorne um array de objetos conforme o exemplo acima.
- Utilize o Postman ou qualquer client Rest para fazer seus testes.



